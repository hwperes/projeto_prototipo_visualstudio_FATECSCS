<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.img_foto = New System.Windows.Forms.PictureBox()
        Me.txt_altura = New System.Windows.Forms.TextBox()
        Me.txt_peso = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_dados_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_idade = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.cmb_posicao = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_gravar = New System.Windows.Forms.Button()
        Me.txt_aval_desemp = New System.Windows.Forms.TextBox()
        Me.txt_hab_fisicas = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_hab_tecnicas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome do Atleta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Idade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CPF"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.img_foto)
        Me.GroupBox1.Controls.Add(Me.txt_altura)
        Me.GroupBox1.Controls.Add(Me.txt_peso)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_dados_cpf)
        Me.GroupBox1.Controls.Add(Me.txt_idade)
        Me.GroupBox1.Controls.Add(Me.txt_nome)
        Me.GroupBox1.Controls.Add(Me.cmb_posicao)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 171)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados Pessoais"
        '
        'img_foto
        '
        Me.img_foto.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.img_foto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.img_foto.Image = CType(resources.GetObject("img_foto.Image"), System.Drawing.Image)
        Me.img_foto.Location = New System.Drawing.Point(455, 41)
        Me.img_foto.Name = "img_foto"
        Me.img_foto.Size = New System.Drawing.Size(103, 116)
        Me.img_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_foto.TabIndex = 10
        Me.img_foto.TabStop = False
        '
        'txt_altura
        '
        Me.txt_altura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_altura.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_altura.Location = New System.Drawing.Point(238, 86)
        Me.txt_altura.Multiline = True
        Me.txt_altura.Name = "txt_altura"
        Me.txt_altura.Size = New System.Drawing.Size(87, 20)
        Me.txt_altura.TabIndex = 9
        '
        'txt_peso
        '
        Me.txt_peso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_peso.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_peso.Location = New System.Drawing.Point(336, 86)
        Me.txt_peso.Multiline = True
        Me.txt_peso.Name = "txt_peso"
        Me.txt_peso.Size = New System.Drawing.Size(87, 20)
        Me.txt_peso.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(337, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Peso"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(235, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Altura"
        '
        'txt_dados_cpf
        '
        Me.txt_dados_cpf.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_dados_cpf.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dados_cpf.Location = New System.Drawing.Point(103, 87)
        Me.txt_dados_cpf.Mask = "999,999,999-99"
        Me.txt_dados_cpf.Name = "txt_dados_cpf"
        Me.txt_dados_cpf.Size = New System.Drawing.Size(120, 17)
        Me.txt_dados_cpf.TabIndex = 5
        Me.txt_dados_cpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_idade
        '
        Me.txt_idade.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_idade.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_idade.Location = New System.Drawing.Point(25, 87)
        Me.txt_idade.Multiline = True
        Me.txt_idade.Name = "txt_idade"
        Me.txt_idade.Size = New System.Drawing.Size(69, 19)
        Me.txt_idade.TabIndex = 4
        '
        'txt_nome
        '
        Me.txt_nome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nome.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(25, 48)
        Me.txt_nome.Multiline = True
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(398, 20)
        Me.txt_nome.TabIndex = 3
        '
        'cmb_posicao
        '
        Me.cmb_posicao.FormattingEnabled = True
        Me.cmb_posicao.Items.AddRange(New Object() {"Goleiro", "Lateral direito", "Lateral Esquerdo", "Zagueiro", "Zagueiro central", "Volante", "Meio-campista direito (Ala)", "Meio-campista esquerdo (Ala)", "Meio-campista (Meia armador)", "Meio-campista-ofensivo (Meia-atacante)", "Centroavante"})
        Me.cmb_posicao.Location = New System.Drawing.Point(25, 134)
        Me.cmb_posicao.Name = "cmb_posicao"
        Me.cmb_posicao.Size = New System.Drawing.Size(155, 23)
        Me.cmb_posicao.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Posição de Jogo Preferida"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_cancelar)
        Me.GroupBox2.Controls.Add(Me.btn_gravar)
        Me.GroupBox2.Controls.Add(Me.txt_aval_desemp)
        Me.GroupBox2.Controls.Add(Me.txt_hab_fisicas)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txt_hab_tecnicas)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(5, 179)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 444)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dados de Desempenho e Habilidades"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(325, 377)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(109, 50)
        Me.btn_cancelar.TabIndex = 10
        Me.btn_cancelar.Text = "CANCELAR"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_gravar
        '
        Me.btn_gravar.Location = New System.Drawing.Point(449, 377)
        Me.btn_gravar.Name = "btn_gravar"
        Me.btn_gravar.Size = New System.Drawing.Size(109, 50)
        Me.btn_gravar.TabIndex = 9
        Me.btn_gravar.Text = "GRAVAR"
        Me.btn_gravar.UseVisualStyleBackColor = True
        '
        'txt_aval_desemp
        '
        Me.txt_aval_desemp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_aval_desemp.Location = New System.Drawing.Point(25, 272)
        Me.txt_aval_desemp.Multiline = True
        Me.txt_aval_desemp.Name = "txt_aval_desemp"
        Me.txt_aval_desemp.Size = New System.Drawing.Size(533, 91)
        Me.txt_aval_desemp.TabIndex = 8
        '
        'txt_hab_fisicas
        '
        Me.txt_hab_fisicas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_hab_fisicas.Location = New System.Drawing.Point(25, 158)
        Me.txt_hab_fisicas.Multiline = True
        Me.txt_hab_fisicas.Name = "txt_hab_fisicas"
        Me.txt_hab_fisicas.Size = New System.Drawing.Size(533, 91)
        Me.txt_hab_fisicas.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 254)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 15)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Avaliação de Desempenho"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Habilidades Físicas"
        '
        'txt_hab_tecnicas
        '
        Me.txt_hab_tecnicas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_hab_tecnicas.Location = New System.Drawing.Point(25, 46)
        Me.txt_hab_tecnicas.Multiline = True
        Me.txt_hab_tecnicas.Name = "txt_hab_tecnicas"
        Me.txt_hab_tecnicas.Size = New System.Drawing.Size(533, 91)
        Me.txt_hab_tecnicas.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Habilidades Técnicas"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(598, 614)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dados de Desempenho Técnico"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.img_foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_idade As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_dados_cpf As MaskedTextBox
    Friend WithEvents txt_altura As TextBox
    Friend WithEvents txt_peso As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents img_foto As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_hab_fisicas As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_hab_tecnicas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_posicao As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_aval_desemp As TextBox
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_gravar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub btn_gravar_Click(sender As Object, e As EventArgs) Handles btn_gravar.Click
        Try
            If txt_nome.Text = "" Or
                txt_idade.Text = "" Or
                txt_dados_cpf.Text = "" Or
                txt_altura.Text = "" Or
                txt_peso.Text = "" Or
                cmb_posicao.Text = "" Or
                txt_hab_tecnicas.Text = "" Or
                txt_hab_fisicas.Text = "" Or
                txt_aval_desemp.Text = "" Then
                MsgBox("Preencha todos os campos!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If
            SQL = "select * from tb_dados_tec where nomeAtleta='" & txt_nome.Text & "'"
            rs = db.Execute(SQL)
            If rs.EOF = False Then
                MsgBox("Ficha do atleta já preenchida.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
            End If

            gerar_id_atleta_dados_tec()
            SQL = "insert into tb_dados_tec values (" & id_atleta & ", '" & txt_nome.Text & "', " &
                                                  "'" & txt_idade.Text & "', " &
                                                  "'" & txt_dados_cpf.Text & "', " &
                                                  "'" & txt_altura.Text & "', " &
                                                  "'" & txt_peso.Text & "', " &
                                                  "'" & cmb_posicao.Text & "', " &
                                                  "'" & txt_hab_tecnicas.Text & "', " &
                                                  "'" & txt_hab_fisicas.Text & "', " &
                                                  "'" & txt_aval_desemp.Text & "', " &
                                                  "'" & diretorio & "')"
            rs = db.Execute(SQL)
            MsgBox("Ficha preenchida com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            limpar_ficha_dados_tec()
        Catch ex As Exception
            MsgBox("Erro ao preencher ficha do atleta.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
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
End Class
