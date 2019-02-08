Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Text.RegularExpressions
Imports Microsoft.Win32

Public Class Form1



    Sub ini()
        Try
            txtCorreo.Text = My.Settings.correo
            txtClave.Text = My.Settings.clave
            If Val(My.Settings.tipo_mail) = 2 Then
                rbGmail.Checked = True
            ElseIf Val(My.Settings.tipo_mail) = 1 Then
                rbHotmail.Checked = True
            End If

            If Val(My.Settings.envios) = 1 Then
                chEnviar.Checked = True
            Else
                chEnviar.Checked = False
            End If

            If Val(My.Settings.iniciar_con_sistema) = 1 Then
                chIniciar_sistema.Checked = True
            Else
                chIniciar_sistema.Checked = False
            End If
            'txtPuerto.Text = My.Settings.tipo_mail

            GetComputerName()
            GetIPv4Address()
            public_ip()
            getMacAddress()
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    Function getMacAddress()
        Try
            Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
            ListBox1.Items.Add("------MAC-----")
            For Each adapter In nics
                ListBox1.Items.Add(adapter.GetPhysicalAddress.ToString)
            Next
        Catch ex As Exception

        End Try

        Return True
    End Function

    Public Function GetComputerName() As String
        Dim ComputerName As String = ""
        Dim username As String = ""
        Try
            ComputerName = Dns.GetHostName
            ListBox1.Items.Add(Environment.UserName)
            ListBox1.Items.Add(ComputerName)
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
        Return ComputerName
    End Function

    Private Function GetIPv4Address() As String
        Try
            ListBox1.Items.Add("------LOCAL------")
            GetIPv4Address = String.Empty
            Dim strHostName As String = Dns.GetHostName()
            Dim iphe As IPHostEntry = Dns.GetHostEntry(strHostName)
            For Each ipheal As IPAddress In iphe.AddressList
                If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                    GetIPv4Address = ipheal.ToString()
                    ListBox1.Items.Add(GetIPv4Address)
                    'Console.WriteLine(GetIPv4Address.ToString)
                End If
            Next
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
        Return 0
    End Function

    Sub public_ip()
        Try
            ListBox1.Items.Add("------PUBLIC-----")
            If internet() Then
                Dim client As New WebClient
                '// Add a user agent header in case the requested URI contains a query.
                client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR1.0.3705;)")
                Dim baseurl As String = "http://checkip.dyndns.org/"
                ' with proxy server only:
                Dim proxy As IWebProxy = WebRequest.GetSystemWebProxy()
                proxy.Credentials = CredentialCache.DefaultNetworkCredentials
                client.Proxy = proxy
                Dim data As Stream
                Try
                    data = client.OpenRead(baseurl)
                Catch ex As Exception
                    ' MsgBox("open url " & ex.Message)
                    Exit Sub
                End Try
                Dim reader As StreamReader = New StreamReader(data)
                Dim s As String = reader.ReadToEnd()
                data.Close()
                reader.Close()
                s = s.Replace("<html><head><title>Current IP Check</title></head><body>", "").Replace("</body></html>", "").ToString()
                'MessageBox.Show(s)
                Dim iptext() As String = Split(s, ":")
                'Console.WriteLine(iptext(1).ToString) 
                ListBox1.Items.Add(iptext(1).ToString.Trim)
                compara(iptext(1).ToString.Trim)
                NotifyIcon1.Text = iptext(1).ToString.Trim
                ' Me.Text = s
            End If

        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        ListBox1.Items.Clear()

        ini()

    End Sub
    Function compara(ByVal x As String) As Boolean
        Try
            If x.Equals(My.Settings.ip_public.ToString()) Then
                Console.WriteLine("mantiene la misma ip")
            Else
                My.Settings.ip_public = x.ToString
                My.Settings.Save()
                Console.WriteLine("se guarda nueva ip")
                If chEnviar.Checked = True Then
                    If rbHotmail.Checked = True Then
                        Console.WriteLine("Enviado")
                        If correo(1) Then
                            Console.WriteLine("Enviado")
                        Else
                            Console.WriteLine("Correo no enviado")
                        End If
                    Else
                        If correo(2) Then
                            Console.WriteLine("Enviado")
                        Else
                            Console.WriteLine("Correo no enviado")
                        End If
                    End If
                End If
                Return False
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString)
        End Try
        Return True

    End Function


    Private Sub btProbar_Click(sender As Object, e As EventArgs) Handles btProbar.Click
        If rbHotmail.Checked = True Then
            If correo(1) Then
                MsgBox("Enviado", MsgBoxStyle.Information, "INFO")
            Else
                MsgBox("Correo no enviado", MsgBoxStyle.Exclamation, "INFO")
            End If

        Else
            If correo(2) Then
                MsgBox("Enviado", MsgBoxStyle.Information, "INFO")
            Else
                MsgBox("Correo no enviado", MsgBoxStyle.Exclamation, "INFO")
            End If
        End If


    End Sub

    Private Sub btPGuardar_Click(sender As Object, e As EventArgs) Handles btPGuardar.Click
        Try
            My.Settings.correo = txtCorreo.Text.Trim
            My.Settings.clave = txtClave.Text.Trim
            If rbHotmail.Checked = True Then
                My.Settings.tipo_mail = "1"
            Else
                My.Settings.tipo_mail = "2"
            End If
            '  My.Settings.tipo_mail = txtPuerto.Text.Trim
            My.Settings.Save()
            MsgBox("DATOS GUARDADOS", MsgBoxStyle.Information, "INFO")
        Catch ex As Exception
            MsgBox("DATOS NO GUARDADOS", MsgBoxStyle.Exclamation, "INFO")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ListBox1.Items.Clear()
        ini()
    End Sub

    Private Function correo(ByVal opcion As Int16) As Boolean
        Try
            Dim contar As Int16 = ListBox1.Items.Count
            Dim x As Int16 = 0
            If opcion = 1 Then
                Console.WriteLine("HOTMAIL")

                If txtCorreo.Text.Length > 0 And txtClave.Text.Length > 0 Then


                    Dim Mail As New Mail.MailMessage
                    Dim SMTP As New Mail.SmtpClient("smtp.live.com", 25) 'smtp.live.com smtp.gmail.com
                    Mail.Subject = "Security Update"
                    Mail.From = New Mail.MailAddress(txtCorreo.Text.Trim)
                    SMTP.Credentials = New NetworkCredential(txtCorreo.Text.Trim, txtClave.Text.Trim) '<-- Password Here
                    Mail.To.Add(txtCorreo.Text.Trim) 'I used ByVal here for address 
                    For Each i As String In ListBox1.Items
                        Mail.Body = Mail.Body.ToString + i.ToString + vbNewLine
                    Next
                    ' Mail.Body = Mail.Body.ToString + Date.Today.ToString + "<-->" + Date.Today.Hour.ToString + ":" + Date.Today.Minute.ToString + ":" + Date.Today.Second.ToString
                    ' Mail.Body = "" ' ListBox1.Items(0) + "<->" + ListBox1.Items(contar - 1)
                    SMTP.EnableSsl = True
                    SMTP.Timeout = 10000
                    'SMTP.Port = txtPuerto.Text.Trim
                    SMTP.Send(Mail)
                Else
                    Return False
                End If
            ElseIf opcion = 2 Then
                Console.WriteLine("GMAIL")
                If txtCorreo.Text.Length > 0 And txtClave.Text.Length > 0 Then

                    Dim Mail As New Mail.MailMessage
                    Dim SMTP As New Mail.SmtpClient("smtp.gmail.com", 587) 'smtp.live.com smtp.gmail.com
                    Mail.Subject = "Security Update"
                    Mail.From = New Mail.MailAddress(txtCorreo.Text.Trim)
                    SMTP.Credentials = New NetworkCredential(txtCorreo.Text.Trim, txtClave.Text.Trim) '<-- Password Here
                    Mail.To.Add(txtCorreo.Text.Trim) 'I used ByVal here for address 
                    For Each i As String In ListBox1.Items
                        Mail.Body = Mail.Body.ToString + i.ToString + vbNewLine
                    Next
                    SMTP.EnableSsl = True
                    SMTP.Timeout = 10000
                    'SMTP.Port = txtPuerto.Text.Trim
                    SMTP.Send(Mail)
                Else
                    Return False
                End If
            End If
            'Dim Mail As New MailMessage
            'Dim SMTP As New SmtpClient("smtp.gmail.com")
            'Mail.Subject = "Security Update"
            'Mail.From = New MailAddress("name@gmail.com")
            'SMTP.Credentials = New System.Net.NetworkCredential("name@gmail.com", "password") '<-- Password Here
            'Mail.To.Add(address & "@gmail.com") 'I used ByVal here for address 
            'Mail.Body = "" 'Message Here 
            'SMTP.EnableSsl = True
            'SMTP.Port = "587"
            'SMTP.Send(Mail)

            '            SmtpClient smtp = New SmtpClient("smtp.gmail.com", 465); 
            'smtp.Credentials = New NetworkCredential("mrbk.writely@gmail.com", "***"); 
            'smtp.EnableSsl = True; 
            'smtp.Send(Mail);  

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function internet() As Boolean
        Try
            If My.Computer.Network.Ping("www.google.com", 1000) Then
                Console.WriteLine("tiene internet")
                lbInternet.Text = "Tiene internet."
                lbInternet.ForeColor = Color.Green
                Return True
            Else
                Console.WriteLine("no tiene internet")
                lbInternet.Text = "No tiene internet."
                lbInternet.ForeColor = Color.Red
                Return False
            End If
        Catch ex As Exception
            lbInternet.Text = "No tiene internet."
            lbInternet.ForeColor = Color.Red
            Return False
        End Try
    End Function

    Private Sub chEnviar_CheckedChanged(sender As Object, e As EventArgs)
        If chEnviar.Checked = True Then
            My.Settings.envios = "1"
        Else
            My.Settings.envios = "0"
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShowInTaskbar = False
        ListBox1.Items.Clear()
        ini()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        If Me.WindowState = FormWindowState.Minimized Then
            ' Me.Hide()
            Me.Show()
            Me.WindowState = FormWindowState.Normal

        Else
            'Me.Show()
        End If


        Me.BringToFront()
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        NotifyIcon1.Visible = Me.WindowState = FormWindowState.Minimized
        ' Me.Hide()

    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If (Me.WindowState = FormWindowState.Minimized) Then
            Me.Hide()
        End If


    End Sub

    Private Sub chIniciar_sistema_CheckedChanged(sender As Object, e As EventArgs)
        If chIniciar_sistema.Checked = True Then
            My.Settings.iniciar_con_sistema = "1"
            RunAtStartup(Application.ProductName, Application.ExecutablePath)
        Else
            My.Settings.iniciar_con_sistema = "0"
            RemoveValue(Application.ProductName)
        End If
        My.Settings.Save()
    End Sub

    Public Sub RunAtStartup(ByVal ApplicationName As String, ByVal ApplicationPath As String)
        Dim CU As Microsoft.Win32.RegistryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run")
        With CU
            .OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)

            .SetValue(ApplicationName, ApplicationPath)

        End With
    End Sub
    'remove value
    Public Sub RemoveValue(ByVal ApplicationName As String)
        Dim CU As Microsoft.Win32.RegistryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run")
        With CU
            .OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)

            .DeleteValue(ApplicationName, False)

        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub chEnviar_CheckedChanged_1(sender As Object, e As EventArgs) Handles chEnviar.CheckedChanged
        If chEnviar.Checked = True Then
            My.Settings.envios = "1"
        Else
            My.Settings.envios = "0"
        End If
    End Sub

    Private Sub chIniciar_sistema_CheckedChanged_1(sender As Object, e As EventArgs) Handles chIniciar_sistema.CheckedChanged
        If chIniciar_sistema.Checked = True Then
            My.Settings.iniciar_con_sistema = "1"
            RunAtStartup(Application.ProductName, Application.ExecutablePath)
        Else
            My.Settings.iniciar_con_sistema = "0"
            RemoveValue(Application.ProductName)
        End If
        My.Settings.Save()
    End Sub
End Class

