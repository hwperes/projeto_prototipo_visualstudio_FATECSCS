<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_cadast_cep = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.btn_cadastro_menu = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_genero = New System.Windows.Forms.ComboBox()
        Me.btn_cadast_gravar = New System.Windows.Forms.Button()
        Me.txt_resp_fone = New System.Windows.Forms.MaskedTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_cadast_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_cadast_fone = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cadast_email = New System.Windows.Forms.TextBox()
        Me.txt_grau_parent = New System.Windows.Forms.TextBox()
        Me.txt_nome_resplegal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_cadast_uf = New System.Windows.Forms.TextBox()
        Me.cmb_data_nasc = New System.Windows.Forms.DateTimePicker()
        Me.txt_cadast_endereco = New System.Windows.Forms.TextBox()
        Me.txt_cadast_cidade = New System.Windows.Forms.TextBox()
        Me.txt_cadast_bairro = New System.Windows.Forms.TextBox()
        Me.txt_cadast_num = New System.Windows.Forms.TextBox()
        Me.txt_cadast_nome = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.txt_cadast_cep)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.img_foto)
        Me.GroupBox1.Controls.Add(Me.btn_cadastro_menu)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_genero)
        Me.GroupBox1.Controls.Add(Me.btn_cadast_gravar)
        Me.GroupBox1.Controls.Add(Me.txt_resp_fone)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_cadast_cpf)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txt_cadast_fone)
        Me.GroupBox1.Controls.Add(Me.txt_cadast_email)
        Me.GroupBox1.Controls.Add(Me.txt_grau_parent)
        Me.GroupBox1.Controls.Add(Me.txt_nome_resplegal)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_cadast_uf)
        Me.GroupBox1.Controls.Add(Me.cmb_data_nasc)
        Me.GroupBox1.Controls.Add(Me.txt_cadast_endereco)
        Me.GroupBox1.Controls.Add(Me.txt_cadast_cidade)
        Me.GroupBox1.Controls.Add(Me.txt_cadast_bairro)
        Me.GroupBox1.Controls.Add(Me.txt_cadast_num)
        Me.GroupBox1.Controls.Add(Me.txt_cadast_nome)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(587, 382)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cadastro de Atleta"
        '
        'txt_cadast_cep
        '
        Me.txt_cadast_cep.Location = New System.Drawing.Point(77, 128)
        Me.txt_cadast_cep.Mask = "99999-999"
        Me.txt_cadast_cep.Name = "txt_cadast_cep"
        Me.txt_cadast_cep.Size = New System.Drawing.Size(67, 23)
        Me.txt_cadast_cep.TabIndex = 39
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(28, 131)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "CEP"
        '
        'img_foto
        '
        Me.img_foto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.img_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_foto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(450, 48)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(112, 133)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 37
        Me.img_foto.TabStop = False
        '
        'btn_cadastro_menu
        '
        Me.btn_cadastro_menu.BackColor = System.Drawing.Color.DarkGray
        Me.btn_cadastro_menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadastro_menu.Location = New System.Drawing.Point(462, 275)
        Me.btn_cadastro_menu.Name = "btn_cadastro_menu"
        Me.btn_cadastro_menu.Size = New System.Drawing.Size(104, 43)
        Me.btn_cadastro_menu.TabIndex = 36
        Me.btn_cadastro_menu.Text = "MENU"
        Me.btn_cadastro_menu.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Data de Nascimento"
        '
        'cmb_genero
        '
        Me.cmb_genero.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_genero.FormattingEnabled = True
        Me.cmb_genero.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.cmb_genero.Location = New System.Drawing.Point(77, 102)
        Me.cmb_genero.Name = "cmb_genero"
        Me.cmb_genero.Size = New System.Drawing.Size(336, 23)
        Me.cmb_genero.TabIndex = 4
        '
        'btn_cadast_gravar
        '
        Me.btn_cadast_gravar.BackColor = System.Drawing.Color.DarkGray
        Me.btn_cadast_gravar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cadast_gravar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_cadast_gravar.Location = New System.Drawing.Point(462, 325)
        Me.btn_cadast_gravar.Name = "btn_cadast_gravar"
        Me.btn_cadast_gravar.Size = New System.Drawing.Size(104, 44)
        Me.btn_cadast_gravar.TabIndex = 15
        Me.btn_cadast_gravar.Text = "GRAVAR"
        Me.btn_cadast_gravar.UseVisualStyleBackColor = False
        '
        'txt_resp_fone
        '
        Me.txt_resp_fone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_resp_fone.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_resp_fone.Location = New System.Drawing.Point(90, 342)
        Me.txt_resp_fone.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_resp_fone.Mask = "+55 (99) 99999-9999"
        Me.txt_resp_fone.Name = "txt_resp_fone"
        Me.txt_resp_fone.Size = New System.Drawing.Size(122, 17)
        Me.txt_resp_fone.TabIndex = 14
        Me.txt_resp_fone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(27, 345)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 13)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Telefone"
        '
        'txt_cadast_cpf
        '
        Me.txt_cadast_cpf.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cadast_cpf.Location = New System.Drawing.Point(286, 74)
        Me.txt_cadast_cpf.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cadast_cpf.Mask = "999,999,999-99"
        Me.txt_cadast_cpf.Name = "txt_cadast_cpf"
        Me.txt_cadast_cpf.Size = New System.Drawing.Size(127, 24)
        Me.txt_cadast_cpf.TabIndex = 3
        Me.txt_cadast_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(251, 79)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(30, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "CPF"
        '
        'txt_cadast_fone
        '
        Me.txt_cadast_fone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cadast_fone.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cadast_fone.Location = New System.Drawing.Point(77, 212)
        Me.txt_cadast_fone.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cadast_fone.Mask = "+55 (99) 99999-9999"
        Me.txt_cadast_fone.Name = "txt_cadast_fone"
        Me.txt_cadast_fone.Size = New System.Drawing.Size(128, 17)
        Me.txt_cadast_fone.TabIndex = 10
        Me.txt_cadast_fone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cadast_email
        '
        Me.txt_cadast_email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cadast_email.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cadast_email.Location = New System.Drawing.Point(77, 234)
        Me.txt_cadast_email.Multiline = True
        Me.txt_cadast_email.Name = "txt_cadast_email"
        Me.txt_cadast_email.Size = New System.Drawing.Size(188, 20)
        Me.txt_cadast_email.TabIndex = 11
        '
        'txt_grau_parent
        '
        Me.txt_grau_parent.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_grau_parent.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_grau_parent.Location = New System.Drawing.Point(136, 316)
        Me.txt_grau_parent.Multiline = True
        Me.txt_grau_parent.Name = "txt_grau_parent"
        Me.txt_grau_parent.Size = New System.Drawing.Size(278, 20)
        Me.txt_grau_parent.TabIndex = 13
        '
        'txt_nome_resplegal
        '
        Me.txt_nome_resplegal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome_resplegal.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_resplegal.Location = New System.Drawing.Point(77, 290)
        Me.txt_nome_resplegal.Multiline = True
        Me.txt_nome_resplegal.Name = "txt_nome_resplegal"
        Me.txt_nome_resplegal.Size = New System.Drawing.Size(337, 20)
        Me.txt_nome_resplegal.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(22, 215)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Telefone"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(25, 237)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "E-mail"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(28, 293)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Nome"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(28, 319)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Grau Parentesco"
        '
        'txt_cadast_uf
        '
        Me.txt_cadast_uf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cadast_uf.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cadast_uf.Location = New System.Drawing.Point(347, 188)
        Me.txt_cadast_uf.Multiline = True
        Me.txt_cadast_uf.Name = "txt_cadast_uf"
        Me.txt_cadast_uf.Size = New System.Drawing.Size(67, 20)
        Me.txt_cadast_uf.TabIndex = 9
        '
        'cmb_data_nasc
        '
        Me.cmb_data_nasc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_data_nasc.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_data_nasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.cmb_data_nasc.Location = New System.Drawing.Point(147, 76)
        Me.cmb_data_nasc.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_data_nasc.Name = "cmb_data_nasc"
        Me.cmb_data_nasc.Size = New System.Drawing.Size(95, 24)
        Me.cmb_data_nasc.TabIndex = 2
        Me.cmb_data_nasc.Value = New Date(2024, 4, 26, 0, 0, 0, 0)
        '
        'txt_cadast_endereco
        '
        Me.txt_cadast_endereco.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cadast_endereco.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cadast_endereco.Location = New System.Drawing.Point(95, 160)
        Me.txt_cadast_endereco.Multiline = True
        Me.txt_cadast_endereco.Name = "txt_cadast_endereco"
        Me.txt_cadast_endereco.Size = New System.Drawing.Size(318, 20)
        Me.txt_cadast_endereco.TabIndex = 5
        '
        'txt_cadast_cidade
        '
        Me.txt_cadast_cidade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cadast_cidade.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cadast_cidade.Location = New System.Drawing.Point(197, 131)
        Me.txt_cadast_cidade.Multiline = True
        Me.txt_cadast_cidade.Name = "txt_cadast_cidade"
        Me.txt_cadast_cidade.Size = New System.Drawing.Size(216, 20)
        Me.txt_cadast_cidade.TabIndex = 8
        '
        'txt_cadast_bairro
        '
        Me.txt_cadast_bairro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cadast_bairro.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cadast_bairro.Location = New System.Drawing.Point(173, 187)
        Me.txt_cadast_bairro.Multiline = True
        Me.txt_cadast_bairro.Name = "txt_cadast_bairro"
        Me.txt_cadast_bairro.Size = New System.Drawing.Size(141, 20)
        Me.txt_cadast_bairro.TabIndex = 7
        '
        'txt_cadast_num
        '
        Me.txt_cadast_num.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cadast_num.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cadast_num.Location = New System.Drawing.Point(79, 187)
        Me.txt_cadast_num.Multiline = True
        Me.txt_cadast_num.Name = "txt_cadast_num"
        Me.txt_cadast_num.Size = New System.Drawing.Size(51, 20)
        Me.txt_cadast_num.TabIndex = 6
        '
        'txt_cadast_nome
        '
        Me.txt_cadast_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_cadast_nome.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cadast_nome.Location = New System.Drawing.Point(125, 48)
        Me.txt_cadast_nome.Multiline = True
        Me.txt_cadast_nome.Name = "txt_cadast_nome"
        Me.txt_cadast_nome.Size = New System.Drawing.Size(288, 20)
        Me.txt_cadast_nome.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(145, 134)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Cidade"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(133, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Bairro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(27, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Número"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(318, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "UF"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(25, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Endereço"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(25, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gênero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(24, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome Completo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(24, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dados Pessoais"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(23, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(398, 98)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Responsável legal"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(606, 406)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Atleta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_resp_fone As MaskedTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_cadast_cpf As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_cadast_fone As MaskedTextBox
    Friend WithEvents txt_cadast_email As TextBox
    Friend WithEvents txt_grau_parent As TextBox
    Friend WithEvents txt_nome_resplegal As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_cadast_uf As TextBox
    Friend WithEvents cmb_data_nasc As DateTimePicker
    Friend WithEvents txt_cadast_endereco As TextBox
    Friend WithEvents txt_cadast_cidade As TextBox
    Friend WithEvents txt_cadast_bairro As TextBox
    Friend WithEvents txt_cadast_num As TextBox
    Friend WithEvents txt_cadast_nome As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cadast_gravar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_genero As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_cadastro_menu As Button
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents txt_cadast_cep As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents EventLog1 As EventLog

    Private Sub btn_cadastro_menu_Click(sender As Object, e As EventArgs) Handles btn_cadastro_menu.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Function CalculateAge(ByVal birthDate As DateTime) As Integer
        Dim today As DateTime = DateTime.Today
        Dim age As Integer = today.Year - birthDate.Year
        If (birthDate > today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Private Sub btn_cadast_gravar_Click(sender As Object, e As EventArgs) Handles btn_cadast_gravar.Click
        Try
            If txt_cadast_nome.Text = "" Or
                cmb_data_nasc.Text = "" Or
                txt_cadast_cpf.Text = "" Or
                cmb_genero.Text = "" Or
                txt_cadast_cep.Text = "" Or
                txt_cadast_cidade.Text = "" Or
                txt_cadast_endereco.Text = "" Or
                txt_cadast_num.Text = "" Or
                txt_cadast_bairro.Text = "" Or
                txt_cadast_uf.Text = "" Or
                txt_cadast_fone.Text = "" Or
                txt_cadast_email.Text = "" Or
                txt_nome_resplegal.Text = "" Or
                txt_grau_parent.Text = "" Or
                txt_resp_fone.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If
            SQL = "select * from tb_cadastro where Nome='" & txt_cadast_nome.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                MsgBox("Atleta já cadastrado.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If

            Dim dataNascimento As DateTime
            If DateTime.TryParse(cmb_data_nasc.Text, dataNascimento) Then
                Dim idade As Integer = CalculateAge(dataNascimento)
                If idade > 15 Then
                    MessageBox.Show("Apenas atletas com no máximo 15 anos de idade podem ser cadastrados.", "Idade Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            Else
                MessageBox.Show("Data de nascimento inválida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            gerar_id_atleta()
            SQL = "insert into tb_cadastro values (" & id_atleta & ", '" & txt_cadast_nome.Text & "', " &
                                                   "'" & cmb_data_nasc.Text & "', " &
                                                   "'" & txt_cadast_cpf.Text & "', " &
                                                   "'" & cmb_genero.Text & "', " &
                                                   "'" & txt_cadast_cep.Text & "', " &
                                                   "'" & txt_cadast_cidade.Text & "', " &
                                                   "'" & txt_cadast_endereco.Text & "', " &
                                                   "'" & txt_cadast_num.Text & "', " &
                                                   "'" & txt_cadast_bairro.Text & "', " &
                                                   "'" & txt_cadast_uf.Text & "', " &
                                                   "'" & txt_cadast_fone.Text & "', " &
                                                   "'" & txt_cadast_email.Text & "', " &
                                                   "'" & diretorio & "', " &
                                                   "'" & txt_nome_resplegal.Text & "', " &
                                                   "'" & txt_grau_parent.Text & "', " &
                                                   "'" & txt_resp_fone.Text & "')"
            rs = db.Execute(SQL)
            MsgBox("Atleta cadastrado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            limpar_cadastro()
            carregar_cadastros()
        Catch ex As Exception
            MsgBox("Erro ao cadastrar atleta.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try

    End Sub

    Private Sub img_foto_Click(sender As Object, e As EventArgs) Handles img_foto.Click
        Try
            With OpenFileDialog1
                .Title = "SELECIONE UM FOTO DO CLIENTE."
                .InitialDirectory = Application.StartupPath & "\FOTOS"
                .ShowDialog()
                diretorio = .FileName
                img_foto.Load(diretorio)
            End With
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txt_cadast_cep_Leave(sender As Object, e As EventArgs) Handles txt_cadast_cep.Leave
        SQL = "select * from tb_cep where CEP='" & txt_cadast_cep.Text & "'"
        rs = db.Execute(SQL)
        If rs.EOF = False Then 'Se existir o CEP na tabela
            txt_cadast_cidade.Text = rs.Fields(3).Value
            txt_cadast_endereco.Text = rs.Fields(1).Value
            txt_cadast_bairro.Text = rs.Fields(2).Value
            txt_cadast_uf.Text = rs.Fields(4).Value
        End If
    End Sub

End Class
