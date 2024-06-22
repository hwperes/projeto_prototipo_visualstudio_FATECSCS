<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_altura_ficha = New System.Windows.Forms.TextBox()
        Me.txt_peso_ficha = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.frm_dados_medicos = New System.Windows.Forms.GroupBox()
        Me.btn_ficha_menu = New System.Windows.Forms.Button()
        Me.txt_ficha_nome_pai = New System.Windows.Forms.TextBox()
        Me.txt_ficha_nome_mae = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_ficha_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_ficha_idade = New System.Windows.Forms.TextBox()
        Me.txt_ficha_nome_atleta = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_gravar_ficha = New System.Windows.Forms.Button()
        Me.txt_ficha_cirurgia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_ficha_historico_lesoes = New System.Windows.Forms.TextBox()
        Me.txt_ficha_alergia_medicacao = New System.Windows.Forms.TextBox()
        Me.txt_ficha_medicacao = New System.Windows.Forms.TextBox()
        Me.txt_ficha_condicoes = New System.Windows.Forms.TextBox()
        Me.txt_ficha_coracao = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_ficha_doencas = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_tipo_sanguineo = New System.Windows.Forms.ComboBox()
        Me.txt_ficha_alergia = New System.Windows.Forms.TextBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.frm_dados_medicos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(481, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Tipo Sanguíneo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(481, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 15)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Peso"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(481, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 15)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Altura"
        '
        'txt_altura_ficha
        '
        Me.txt_altura_ficha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_altura_ficha.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_altura_ficha.Location = New System.Drawing.Point(484, 41)
        Me.txt_altura_ficha.Multiline = True
        Me.txt_altura_ficha.Name = "txt_altura_ficha"
        Me.txt_altura_ficha.Size = New System.Drawing.Size(121, 20)
        Me.txt_altura_ficha.TabIndex = 4
        '
        'txt_peso_ficha
        '
        Me.txt_peso_ficha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_peso_ficha.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_peso_ficha.Location = New System.Drawing.Point(484, 82)
        Me.txt_peso_ficha.Multiline = True
        Me.txt_peso_ficha.Name = "txt_peso_ficha"
        Me.txt_peso_ficha.Size = New System.Drawing.Size(121, 20)
        Me.txt_peso_ficha.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(421, 313)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 15)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Histórico de lesões"
        '
        'frm_dados_medicos
        '
        Me.frm_dados_medicos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.frm_dados_medicos.AutoSize = True
        Me.frm_dados_medicos.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.frm_dados_medicos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.frm_dados_medicos.Controls.Add(Me.btn_ficha_menu)
        Me.frm_dados_medicos.Controls.Add(Me.txt_ficha_nome_pai)
        Me.frm_dados_medicos.Controls.Add(Me.txt_ficha_nome_mae)
        Me.frm_dados_medicos.Controls.Add(Me.Label17)
        Me.frm_dados_medicos.Controls.Add(Me.Label15)
        Me.frm_dados_medicos.Controls.Add(Me.txt_ficha_cpf)
        Me.frm_dados_medicos.Controls.Add(Me.Label13)
        Me.frm_dados_medicos.Controls.Add(Me.txt_ficha_idade)
        Me.frm_dados_medicos.Controls.Add(Me.txt_ficha_nome_atleta)
        Me.frm_dados_medicos.Controls.Add(Me.Label12)
        Me.frm_dados_medicos.Controls.Add(Me.Label10)
        Me.frm_dados_medicos.Controls.Add(Me.btn_gravar_ficha)
        Me.frm_dados_medicos.Controls.Add(Me.txt_ficha_cirurgia)
        Me.frm_dados_medicos.Controls.Add(Me.Label8)
        Me.frm_dados_medicos.Controls.Add(Me.Label2)
        Me.frm_dados_medicos.Controls.Add(Me.txt_ficha_historico_lesoes)
        Me.frm_dados_medicos.Controls.Add(Me.txt_ficha_alergia_medicacao)
        Me.frm_dados_medicos.Controls.Add(Me.txt_ficha_medicacao)
        Me.frm_dados_medicos.Controls.Add(Me.txt_ficha_condicoes)
        Me.frm_dados_medicos.Controls.Add(Me.txt_ficha_coracao)
        Me.frm_dados_medicos.Controls.Add(Me.Label7)
        Me.frm_dados_medicos.Controls.Add(Me.txt_ficha_doencas)
        Me.frm_dados_medicos.Controls.Add(Me.Label6)
        Me.frm_dados_medicos.Controls.Add(Me.Label5)
        Me.frm_dados_medicos.Controls.Add(Me.Label4)
        Me.frm_dados_medicos.Controls.Add(Me.Label3)
        Me.frm_dados_medicos.Controls.Add(Me.cmb_tipo_sanguineo)
        Me.frm_dados_medicos.Controls.Add(Me.txt_ficha_alergia)
        Me.frm_dados_medicos.Controls.Add(Me.Label16)
        Me.frm_dados_medicos.Controls.Add(Me.txt_peso_ficha)
        Me.frm_dados_medicos.Controls.Add(Me.txt_altura_ficha)
        Me.frm_dados_medicos.Controls.Add(Me.Label14)
        Me.frm_dados_medicos.Controls.Add(Me.Label11)
        Me.frm_dados_medicos.Controls.Add(Me.Label9)
        Me.frm_dados_medicos.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.frm_dados_medicos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.frm_dados_medicos.Location = New System.Drawing.Point(12, 12)
        Me.frm_dados_medicos.Name = "frm_dados_medicos"
        Me.frm_dados_medicos.Size = New System.Drawing.Size(809, 548)
        Me.frm_dados_medicos.TabIndex = 2
        Me.frm_dados_medicos.TabStop = False
        Me.frm_dados_medicos.Text = "Dados Médicos"
        '
        'btn_ficha_menu
        '
        Me.btn_ficha_menu.BackColor = System.Drawing.Color.DarkGray
        Me.btn_ficha_menu.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ficha_menu.Location = New System.Drawing.Point(484, 491)
        Me.btn_ficha_menu.Name = "btn_ficha_menu"
        Me.btn_ficha_menu.Size = New System.Drawing.Size(149, 35)
        Me.btn_ficha_menu.TabIndex = 17
        Me.btn_ficha_menu.Text = "MENU"
        Me.btn_ficha_menu.UseVisualStyleBackColor = False
        '
        'txt_ficha_nome_pai
        '
        Me.txt_ficha_nome_pai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ficha_nome_pai.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ficha_nome_pai.Location = New System.Drawing.Point(28, 124)
        Me.txt_ficha_nome_pai.Multiline = True
        Me.txt_ficha_nome_pai.Name = "txt_ficha_nome_pai"
        Me.txt_ficha_nome_pai.Size = New System.Drawing.Size(450, 20)
        Me.txt_ficha_nome_pai.TabIndex = 7
        '
        'txt_ficha_nome_mae
        '
        Me.txt_ficha_nome_mae.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ficha_nome_mae.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ficha_nome_mae.Location = New System.Drawing.Point(28, 82)
        Me.txt_ficha_nome_mae.Multiline = True
        Me.txt_ficha_nome_mae.Name = "txt_ficha_nome_mae"
        Me.txt_ficha_nome_mae.Size = New System.Drawing.Size(450, 20)
        Me.txt_ficha_nome_mae.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 108)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 15)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "Nome do pai"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(25, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 15)
        Me.Label15.TabIndex = 80
        Me.Label15.Text = "Nome da mãe"
        '
        'txt_ficha_cpf
        '
        Me.txt_ficha_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ficha_cpf.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ficha_cpf.Location = New System.Drawing.Point(380, 41)
        Me.txt_ficha_cpf.Mask = "999,999,999-99"
        Me.txt_ficha_cpf.Name = "txt_ficha_cpf"
        Me.txt_ficha_cpf.Size = New System.Drawing.Size(98, 17)
        Me.txt_ficha_cpf.TabIndex = 3
        Me.txt_ficha_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(379, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(27, 15)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "CPF"
        '
        'txt_ficha_idade
        '
        Me.txt_ficha_idade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ficha_idade.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ficha_idade.Location = New System.Drawing.Point(287, 41)
        Me.txt_ficha_idade.Multiline = True
        Me.txt_ficha_idade.Name = "txt_ficha_idade"
        Me.txt_ficha_idade.Size = New System.Drawing.Size(83, 20)
        Me.txt_ficha_idade.TabIndex = 2
        '
        'txt_ficha_nome_atleta
        '
        Me.txt_ficha_nome_atleta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ficha_nome_atleta.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ficha_nome_atleta.Location = New System.Drawing.Point(28, 41)
        Me.txt_ficha_nome_atleta.Multiline = True
        Me.txt_ficha_nome_atleta.Name = "txt_ficha_nome_atleta"
        Me.txt_ficha_nome_atleta.Size = New System.Drawing.Size(248, 20)
        Me.txt_ficha_nome_atleta.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(284, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 15)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Idade"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 15)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Nome do atleta"
        '
        'btn_gravar_ficha
        '
        Me.btn_gravar_ficha.BackColor = System.Drawing.Color.DarkGray
        Me.btn_gravar_ficha.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gravar_ficha.Location = New System.Drawing.Point(652, 491)
        Me.btn_gravar_ficha.Name = "btn_gravar_ficha"
        Me.btn_gravar_ficha.Size = New System.Drawing.Size(149, 35)
        Me.btn_gravar_ficha.TabIndex = 18
        Me.btn_gravar_ficha.Text = "GRAVAR"
        Me.btn_gravar_ficha.UseVisualStyleBackColor = False
        '
        'txt_ficha_cirurgia
        '
        Me.txt_ficha_cirurgia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ficha_cirurgia.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ficha_cirurgia.Location = New System.Drawing.Point(423, 408)
        Me.txt_ficha_cirurgia.Multiline = True
        Me.txt_ficha_cirurgia.Name = "txt_ficha_cirurgia"
        Me.txt_ficha_cirurgia.Size = New System.Drawing.Size(378, 60)
        Me.txt_ficha_cirurgia.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(421, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(227, 15)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Já realizou algum tipo de cirurgia? Qual?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 15)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Condições médicas pré-existentes"
        '
        'txt_ficha_historico_lesoes
        '
        Me.txt_ficha_historico_lesoes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ficha_historico_lesoes.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ficha_historico_lesoes.Location = New System.Drawing.Point(423, 329)
        Me.txt_ficha_historico_lesoes.Multiline = True
        Me.txt_ficha_historico_lesoes.Name = "txt_ficha_historico_lesoes"
        Me.txt_ficha_historico_lesoes.Size = New System.Drawing.Size(378, 60)
        Me.txt_ficha_historico_lesoes.TabIndex = 14
        '
        'txt_ficha_alergia_medicacao
        '
        Me.txt_ficha_alergia_medicacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ficha_alergia_medicacao.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ficha_alergia_medicacao.Location = New System.Drawing.Point(423, 250)
        Me.txt_ficha_alergia_medicacao.Multiline = True
        Me.txt_ficha_alergia_medicacao.Name = "txt_ficha_alergia_medicacao"
        Me.txt_ficha_alergia_medicacao.Size = New System.Drawing.Size(379, 60)
        Me.txt_ficha_alergia_medicacao.TabIndex = 12
        '
        'txt_ficha_medicacao
        '
        Me.txt_ficha_medicacao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ficha_medicacao.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ficha_medicacao.Location = New System.Drawing.Point(423, 172)
        Me.txt_ficha_medicacao.Multiline = True
        Me.txt_ficha_medicacao.Name = "txt_ficha_medicacao"
        Me.txt_ficha_medicacao.Size = New System.Drawing.Size(380, 59)
        Me.txt_ficha_medicacao.TabIndex = 10
        '
        'txt_ficha_condicoes
        '
        Me.txt_ficha_condicoes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ficha_condicoes.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ficha_condicoes.Location = New System.Drawing.Point(28, 408)
        Me.txt_ficha_condicoes.Multiline = True
        Me.txt_ficha_condicoes.Name = "txt_ficha_condicoes"
        Me.txt_ficha_condicoes.Size = New System.Drawing.Size(380, 60)
        Me.txt_ficha_condicoes.TabIndex = 15
        '
        'txt_ficha_coracao
        '
        Me.txt_ficha_coracao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ficha_coracao.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ficha_coracao.Location = New System.Drawing.Point(28, 172)
        Me.txt_ficha_coracao.Multiline = True
        Me.txt_ficha_coracao.Name = "txt_ficha_coracao"
        Me.txt_ficha_coracao.Size = New System.Drawing.Size(380, 59)
        Me.txt_ficha_coracao.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 15)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Doenças que já teve:"
        '
        'txt_ficha_doencas
        '
        Me.txt_ficha_doencas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ficha_doencas.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ficha_doencas.Location = New System.Drawing.Point(28, 250)
        Me.txt_ficha_doencas.Multiline = True
        Me.txt_ficha_doencas.Name = "txt_ficha_doencas"
        Me.txt_ficha_doencas.Size = New System.Drawing.Size(380, 60)
        Me.txt_ficha_doencas.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(421, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(200, 15)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Possui alergia a alguma medicação?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(420, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 15)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Toma alguma medicação?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 15)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Possui algum problema de coração?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 15)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Possui algum tipo de alergia?"
        '
        'cmb_tipo_sanguineo
        '
        Me.cmb_tipo_sanguineo.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_sanguineo.FormattingEnabled = True
        Me.cmb_tipo_sanguineo.Items.AddRange(New Object() {"O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-"})
        Me.cmb_tipo_sanguineo.Location = New System.Drawing.Point(484, 121)
        Me.cmb_tipo_sanguineo.Name = "cmb_tipo_sanguineo"
        Me.cmb_tipo_sanguineo.Size = New System.Drawing.Size(121, 23)
        Me.cmb_tipo_sanguineo.TabIndex = 8
        '
        'txt_ficha_alergia
        '
        Me.txt_ficha_alergia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_ficha_alergia.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ficha_alergia.Location = New System.Drawing.Point(28, 329)
        Me.txt_ficha_alergia.Multiline = True
        Me.txt_ficha_alergia.Name = "txt_ficha_alergia"
        Me.txt_ficha_alergia.Size = New System.Drawing.Size(380, 60)
        Me.txt_ficha_alergia.TabIndex = 13
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(834, 550)
        Me.Controls.Add(Me.frm_dados_medicos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ficha Médica"
        Me.frm_dados_medicos.ResumeLayout(False)
        Me.frm_dados_medicos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_altura_ficha As TextBox
    Friend WithEvents txt_peso_ficha As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents frm_dados_medicos As GroupBox
    Friend WithEvents txt_ficha_alergia As TextBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmb_tipo_sanguineo As ComboBox
    Friend WithEvents txt_ficha_coracao As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_ficha_doencas As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_ficha_historico_lesoes As TextBox
    Friend WithEvents txt_ficha_alergia_medicacao As TextBox
    Friend WithEvents txt_ficha_medicacao As TextBox
    Friend WithEvents txt_ficha_condicoes As TextBox
    Friend WithEvents txt_ficha_cirurgia As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_gravar_ficha As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_ficha_idade As TextBox
    Friend WithEvents txt_ficha_nome_atleta As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_ficha_cpf As MaskedTextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_ficha_nome_pai As TextBox
    Friend WithEvents txt_ficha_nome_mae As TextBox
    Friend WithEvents btn_ficha_menu As Button

    Private Sub btn_gravar_ficha_Click(sender As Object, e As EventArgs) Handles btn_gravar_ficha.Click
        Try
            If txt_ficha_nome_atleta.Text = "" Or
                txt_ficha_idade.Text = "" Or
                txt_ficha_cpf.Text = "" Or
                txt_altura_ficha.Text = "" Or
                txt_ficha_nome_mae.Text = "" Or
                txt_peso_ficha.Text = "" Or
                txt_ficha_nome_pai.Text = "" Or
                cmb_tipo_sanguineo.Text = "" Or
                txt_ficha_coracao.Text = "" Or
                txt_ficha_medicacao.Text = "" Or
                txt_ficha_doencas.Text = "" Or
                txt_ficha_alergia_medicacao.Text = "" Or
                txt_ficha_alergia.Text = "" Or
                txt_ficha_historico_lesoes.Text = "" Or
                txt_ficha_condicoes.Text = "" Or
                txt_ficha_cirurgia.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If
            SQL = "select * from tb_ficha_medica where nomeAtleta='" & txt_ficha_nome_atleta.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                MsgBox("Ficha do atleta já preenchida.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If

            gerar_id_atleta_ficha_medic()
            SQL = "insert into tb_ficha_medica values (" & id_atleta & ", '" & txt_ficha_nome_atleta.Text & "', " &
                                                  "'" & txt_ficha_idade.Text & "', " &
                                                  "'" & txt_ficha_cpf.Text & "', " &
                                                  "'" & txt_altura_ficha.Text & "', " &
                                                  "'" & txt_ficha_nome_mae.Text & "', " &
                                                  "'" & txt_peso_ficha.Text & "', " &
                                                  "'" & txt_ficha_nome_pai.Text & "', " &
                                                  "'" & cmb_tipo_sanguineo.Text & "', " &
                                                  "'" & txt_ficha_coracao.Text & "', " &
                                                  "'" & txt_ficha_medicacao.Text & "', " &
                                                  "'" & txt_ficha_doencas.Text & "', " &
                                                  "'" & txt_ficha_alergia_medicacao.Text & "', " &
                                                  "'" & txt_ficha_alergia.Text & "', " &
                                                  "'" & txt_ficha_historico_lesoes.Text & "', " &
                                                  "'" & txt_ficha_condicoes.Text & "', " &
                                                  "'" & txt_ficha_cirurgia.Text & "')"
            rs = db.Execute(SQL)
            MsgBox("Ficha preenchida com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            limpar_ficha_medica()
        Catch ex As Exception
            MsgBox("Erro ao preencher ficha do atleta.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Private Sub btn_ficha_menu_Click(sender As Object, e As EventArgs) Handles btn_ficha_menu.Click
        Form4.Show()
        Me.Close()
    End Sub
End Class
