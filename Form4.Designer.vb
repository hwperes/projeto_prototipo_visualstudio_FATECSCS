<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.d = New System.Windows.Forms.GroupBox()
        Me.btn_preencher_desemp = New System.Windows.Forms.Button()
        Me.btn_cadastrar_novo = New System.Windows.Forms.Button()
        Me.btn_gerar_relat = New System.Windows.Forms.Button()
        Me.btn_consultar_atleta = New System.Windows.Forms.Button()
        Me.btn_encerrar = New System.Windows.Forms.Button()
        Me.btn_preencher_ficha = New System.Windows.Forms.Button()
        Me.d.SuspendLayout()
        Me.SuspendLayout()
        '
        'd
        '
        Me.d.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.d.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.d.Controls.Add(Me.btn_preencher_desemp)
        Me.d.Controls.Add(Me.btn_cadastrar_novo)
        Me.d.Controls.Add(Me.btn_gerar_relat)
        Me.d.Controls.Add(Me.btn_consultar_atleta)
        Me.d.Controls.Add(Me.btn_encerrar)
        Me.d.Controls.Add(Me.btn_preencher_ficha)
        Me.d.Font = New System.Drawing.Font("Ebrima", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.d.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.d.Location = New System.Drawing.Point(7, 12)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(528, 321)
        Me.d.TabIndex = 6
        Me.d.TabStop = False
        Me.d.Text = "MENU"
        '
        'btn_preencher_desemp
        '
        Me.btn_preencher_desemp.Font = New System.Drawing.Font("Ebrima", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_preencher_desemp.Image = CType(resources.GetObject("btn_preencher_desemp.Image"), System.Drawing.Image)
        Me.btn_preencher_desemp.Location = New System.Drawing.Point(278, 117)
        Me.btn_preencher_desemp.Name = "btn_preencher_desemp"
        Me.btn_preencher_desemp.Size = New System.Drawing.Size(209, 84)
        Me.btn_preencher_desemp.TabIndex = 4
        Me.btn_preencher_desemp.Text = "PREENCHER FICHA DE DESEMPENHO"
        Me.btn_preencher_desemp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_preencher_desemp.UseVisualStyleBackColor = True
        '
        'btn_cadastrar_novo
        '
        Me.btn_cadastrar_novo.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar_novo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_cadastrar_novo.Image = CType(resources.GetObject("btn_cadastrar_novo.Image"), System.Drawing.Image)
        Me.btn_cadastrar_novo.Location = New System.Drawing.Point(38, 25)
        Me.btn_cadastrar_novo.Name = "btn_cadastrar_novo"
        Me.btn_cadastrar_novo.Size = New System.Drawing.Size(209, 86)
        Me.btn_cadastrar_novo.TabIndex = 1
        Me.btn_cadastrar_novo.Text = "CADASTRAR     NOVO           ATLETA"
        Me.btn_cadastrar_novo.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_cadastrar_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_cadastrar_novo.UseVisualStyleBackColor = True
        '
        'btn_gerar_relat
        '
        Me.btn_gerar_relat.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerar_relat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_gerar_relat.Image = CType(resources.GetObject("btn_gerar_relat.Image"), System.Drawing.Image)
        Me.btn_gerar_relat.Location = New System.Drawing.Point(38, 209)
        Me.btn_gerar_relat.Name = "btn_gerar_relat"
        Me.btn_gerar_relat.Size = New System.Drawing.Size(209, 86)
        Me.btn_gerar_relat.TabIndex = 5
        Me.btn_gerar_relat.Text = "GERAR RELATÓRIO"
        Me.btn_gerar_relat.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_gerar_relat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_gerar_relat.UseVisualStyleBackColor = True
        '
        'btn_consultar_atleta
        '
        Me.btn_consultar_atleta.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_consultar_atleta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_consultar_atleta.Image = CType(resources.GetObject("btn_consultar_atleta.Image"), System.Drawing.Image)
        Me.btn_consultar_atleta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_consultar_atleta.Location = New System.Drawing.Point(278, 27)
        Me.btn_consultar_atleta.Name = "btn_consultar_atleta"
        Me.btn_consultar_atleta.Size = New System.Drawing.Size(209, 86)
        Me.btn_consultar_atleta.TabIndex = 2
        Me.btn_consultar_atleta.Text = "CONSULTAR    ATLETA"
        Me.btn_consultar_atleta.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_consultar_atleta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_consultar_atleta.UseVisualStyleBackColor = True
        '
        'btn_encerrar
        '
        Me.btn_encerrar.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_encerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_encerrar.Image = CType(resources.GetObject("btn_encerrar.Image"), System.Drawing.Image)
        Me.btn_encerrar.Location = New System.Drawing.Point(278, 209)
        Me.btn_encerrar.Name = "btn_encerrar"
        Me.btn_encerrar.Size = New System.Drawing.Size(209, 86)
        Me.btn_encerrar.TabIndex = 6
        Me.btn_encerrar.Text = "ENCERRAR LOGIN"
        Me.btn_encerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_encerrar.UseVisualStyleBackColor = True
        '
        'btn_preencher_ficha
        '
        Me.btn_preencher_ficha.Font = New System.Drawing.Font("Ebrima", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_preencher_ficha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_preencher_ficha.Image = CType(resources.GetObject("btn_preencher_ficha.Image"), System.Drawing.Image)
        Me.btn_preencher_ficha.Location = New System.Drawing.Point(38, 117)
        Me.btn_preencher_ficha.Name = "btn_preencher_ficha"
        Me.btn_preencher_ficha.Size = New System.Drawing.Size(209, 86)
        Me.btn_preencher_ficha.TabIndex = 3
        Me.btn_preencher_ficha.Text = "PREENCHER      FICHA      MÉDICA"
        Me.btn_preencher_ficha.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btn_preencher_ficha.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(542, 339)
        Me.Controls.Add(Me.d)
        Me.Font = New System.Drawing.Font("Ebrima", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.d.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents d As GroupBox
    Friend WithEvents btn_cadastrar_novo As Button
    Friend WithEvents btn_gerar_relat As Button
    Friend WithEvents btn_consultar_atleta As Button
    Friend WithEvents btn_encerrar As Button
    Friend WithEvents btn_preencher_ficha As Button
    Friend WithEvents btn_preencher_desemp As Button

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_cadastrar_novo.Enabled = False
        btn_consultar_atleta.Enabled = False
        btn_encerrar.Enabled = False
        btn_gerar_relat.Enabled = False
        btn_preencher_desemp.Enabled = False
        btn_preencher_ficha.Enabled = False
        Dim tipo_conta As String
        tipo_conta = rs.Fields(3).Value

        Select Case tipo_conta
            Case "TÉCNICO"
                btn_consultar_atleta.Enabled = True
                btn_preencher_desemp.Enabled = True
                btn_encerrar.Enabled = True
                btn_gerar_relat.Enabled = True
            Case "OLHEIRO"
                btn_cadastrar_novo.Enabled = True
                btn_consultar_atleta.Enabled = True
                btn_preencher_desemp.Enabled = True
                btn_gerar_relat.Enabled = True
                btn_encerrar.Enabled = True
            Case "MÉDICO"
                btn_preencher_ficha.Enabled = True
                btn_gerar_relat.Enabled = True
                btn_encerrar.Enabled = True
            Case "ATLETA"
                MsgBox("Teste realizado com sucesso!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")

            Case Else
                MsgBox("Conta Inválida!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ATENÇÃO")
                Exit Sub
        End Select
    End Sub

    Private Sub btn_cadastrar_novo_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_novo.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_consultar_atleta_Click(sender As Object, e As EventArgs) Handles btn_consultar_atleta.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub btn_preencher_ficha_Click(sender As Object, e As EventArgs) Handles btn_preencher_ficha.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_preencher_desemp_Click(sender As Object, e As EventArgs) Handles btn_preencher_desemp.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btn_gerar_relat_Click(sender As Object, e As EventArgs) Handles btn_gerar_relat.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub btn_encerrar_Click(sender As Object, e As EventArgs) Handles btn_encerrar.Click
        Application.Exit()
    End Sub
End Class
