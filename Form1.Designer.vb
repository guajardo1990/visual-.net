<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chIniciar_sistema = New System.Windows.Forms.CheckBox()
        Me.chEnviar = New System.Windows.Forms.CheckBox()
        Me.rbGmail = New System.Windows.Forms.RadioButton()
        Me.rbHotmail = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btPGuardar = New System.Windows.Forms.Button()
        Me.btProbar = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbInternet = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 120000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "IP PUBLICA"
        Me.NotifyIcon1.Visible = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chIniciar_sistema)
        Me.TabPage2.Controls.Add(Me.chEnviar)
        Me.TabPage2.Controls.Add(Me.rbGmail)
        Me.TabPage2.Controls.Add(Me.rbHotmail)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtClave)
        Me.TabPage2.Controls.Add(Me.txtCorreo)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.btPGuardar)
        Me.TabPage2.Controls.Add(Me.btProbar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(268, 200)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "CONFIG"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chIniciar_sistema
        '
        Me.chIniciar_sistema.AutoSize = True
        Me.chIniciar_sistema.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chIniciar_sistema.Location = New System.Drawing.Point(6, 175)
        Me.chIniciar_sistema.Name = "chIniciar_sistema"
        Me.chIniciar_sistema.Size = New System.Drawing.Size(158, 17)
        Me.chIniciar_sistema.TabIndex = 13
        Me.chIniciar_sistema.Text = "Iniciar con el sistema"
        Me.chIniciar_sistema.UseVisualStyleBackColor = True
        '
        'chEnviar
        '
        Me.chEnviar.AutoSize = True
        Me.chEnviar.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chEnviar.Location = New System.Drawing.Point(6, 158)
        Me.chEnviar.Name = "chEnviar"
        Me.chEnviar.Size = New System.Drawing.Size(200, 17)
        Me.chEnviar.TabIndex = 12
        Me.chEnviar.Text = "Enviar correo de cambio de IP"
        Me.chEnviar.UseVisualStyleBackColor = True
        '
        'rbGmail
        '
        Me.rbGmail.AutoSize = True
        Me.rbGmail.Checked = True
        Me.rbGmail.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbGmail.Location = New System.Drawing.Point(202, 94)
        Me.rbGmail.Name = "rbGmail"
        Me.rbGmail.Size = New System.Drawing.Size(60, 19)
        Me.rbGmail.TabIndex = 10
        Me.rbGmail.TabStop = True
        Me.rbGmail.Text = "GMAIL"
        Me.rbGmail.UseVisualStyleBackColor = True
        '
        'rbHotmail
        '
        Me.rbHotmail.AutoSize = True
        Me.rbHotmail.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHotmail.Location = New System.Drawing.Point(123, 94)
        Me.rbHotmail.Name = "rbHotmail"
        Me.rbHotmail.Size = New System.Drawing.Size(74, 19)
        Me.rbHotmail.TabIndex = 9
        Me.rbHotmail.Text = "HOTMAIL"
        Me.rbHotmail.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "CLAVE"
        '
        'txtClave
        '
        Me.txtClave.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.Location = New System.Drawing.Point(89, 62)
        Me.txtClave.MaxLength = 200
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(173, 26)
        Me.txtClave.TabIndex = 5
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtClave.WordWrap = False
        '
        'txtCorreo
        '
        Me.txtCorreo.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.Location = New System.Drawing.Point(1, 30)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(261, 26)
        Me.txtCorreo.TabIndex = 3
        Me.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CORREO"
        '
        'btPGuardar
        '
        Me.btPGuardar.BackColor = System.Drawing.Color.White
        Me.btPGuardar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPGuardar.Location = New System.Drawing.Point(136, 117)
        Me.btPGuardar.Name = "btPGuardar"
        Me.btPGuardar.Size = New System.Drawing.Size(126, 30)
        Me.btPGuardar.TabIndex = 2
        Me.btPGuardar.Text = "GUARDAR"
        Me.btPGuardar.UseVisualStyleBackColor = False
        '
        'btProbar
        '
        Me.btProbar.BackColor = System.Drawing.Color.White
        Me.btProbar.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btProbar.Location = New System.Drawing.Point(42, 117)
        Me.btProbar.Name = "btProbar"
        Me.btProbar.Size = New System.Drawing.Size(72, 30)
        Me.btProbar.TabIndex = 1
        Me.btProbar.Text = "PROBAR"
        Me.btProbar.UseVisualStyleBackColor = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.lbInternet)
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(268, 200)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "INICIO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(216, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "V 1.0.5"
        '
        'lbInternet
        '
        Me.lbInternet.AutoSize = True
        Me.lbInternet.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInternet.Location = New System.Drawing.Point(67, 152)
        Me.lbInternet.Name = "lbInternet"
        Me.lbInternet.Size = New System.Drawing.Size(150, 22)
        Me.lbInternet.TabIndex = 10
        Me.lbInternet.Text = "Tiene internet"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(6, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(261, 124)
        Me.ListBox1.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.get_ip2.My.Resources.Resources.loop_13_433104
        Me.PictureBox1.Location = New System.Drawing.Point(6, 136)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(276, 226)
        Me.TabControl1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 227)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents chIniciar_sistema As CheckBox
    Friend WithEvents chEnviar As CheckBox
    Friend WithEvents rbGmail As RadioButton
    Friend WithEvents rbHotmail As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClave As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btPGuardar As Button
    Friend WithEvents btProbar As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents lbInternet As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Label3 As Label
End Class
