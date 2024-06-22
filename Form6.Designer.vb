Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.cmb_tipo_relatorio = New System.Windows.Forms.ComboBox()
        Me.btn_gerar_relatorio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmb_tipo_relatorio
        '
        Me.cmb_tipo_relatorio.FormattingEnabled = True
        Me.cmb_tipo_relatorio.Items.AddRange(New Object() {"Listagem Geral de Atletas", "Relatório de Ficha Médica", "Relatório de Desempenho Técnico"})
        Me.cmb_tipo_relatorio.Location = New System.Drawing.Point(51, 85)
        Me.cmb_tipo_relatorio.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_tipo_relatorio.Name = "cmb_tipo_relatorio"
        Me.cmb_tipo_relatorio.Size = New System.Drawing.Size(363, 25)
        Me.cmb_tipo_relatorio.TabIndex = 1
        '
        'btn_gerar_relatorio
        '
        Me.btn_gerar_relatorio.BackColor = System.Drawing.Color.DarkGray
        Me.btn_gerar_relatorio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gerar_relatorio.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_gerar_relatorio.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerar_relatorio.ForeColor = System.Drawing.Color.Black
        Me.btn_gerar_relatorio.Location = New System.Drawing.Point(470, 71)
        Me.btn_gerar_relatorio.Name = "btn_gerar_relatorio"
        Me.btn_gerar_relatorio.Size = New System.Drawing.Size(127, 52)
        Me.btn_gerar_relatorio.TabIndex = 2
        Me.btn_gerar_relatorio.Text = "GERAR RELATÓRIO"
        Me.btn_gerar_relatorio.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ebrima", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Escolha o tipo de relatório:"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(622, 170)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_gerar_relatorio)
        Me.Controls.Add(Me.cmb_tipo_relatorio)
        Me.Font = New System.Drawing.Font("Ebrima", 9.75!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emitir Relatório"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_tipo_relatorio As ComboBox
    Friend WithEvents btn_gerar_relatorio As Button
    Friend WithEvents Label1 As Label

    Private Sub GerarRelatorioDesempenhoTecnico()
        Try
            Dim doc As New Document()
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(Application.StartupPath & "\FOTOS\RelatorioDesempenhoTecnico.pdf", FileMode.Create))
            doc.Open()
            doc.Add(New Paragraph("Relatório de Desempenho Técnico"))
            doc.Add(New Paragraph(" "))

            conectar_banco_sql() ' Conectar ao banco de dados
            Dim rs As New ADODB.Recordset
            Dim SQL As String = "SELECT * FROM tb_dados_tec"

            rs.Open(SQL, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            While Not rs.EOF
                doc.Add(New Paragraph("Nome do Atleta: " & rs.Fields("nomeAtleta").Value.ToString()))
                doc.Add(New Paragraph("Idade: " & rs.Fields("idadeAtleta").Value.ToString()))
                doc.Add(New Paragraph("CPF: " & rs.Fields("CPF").Value.ToString()))
                doc.Add(New Paragraph("Altura: " & rs.Fields("altura").Value.ToString()))
                doc.Add(New Paragraph("Peso: " & rs.Fields("peso").Value.ToString()))
                doc.Add(New Paragraph("Posição: " & rs.Fields("posicao").Value.ToString()))
                doc.Add(New Paragraph("Habilidades Técnicas: " & rs.Fields("habTecnica").Value.ToString()))
                doc.Add(New Paragraph("Habilidades Físicas: " & rs.Fields("habFisica").Value.ToString()))
                doc.Add(New Paragraph("Avaliação de Desempenho: " & rs.Fields("avalDesemp").Value.ToString()))
                doc.Add(New Paragraph(" "))

                ' Para adicionar a foto ao relatório, caso exista:
                Dim fotoPath As String = rs.Fields("foto").Value.ToString()
                If File.Exists(fotoPath) Then
                    Dim foto As Image = Image.GetInstance(fotoPath)
                    foto.ScaleToFit(100.0F, 100.0F)
                    doc.Add(foto)
                End If

                doc.Add(New Paragraph(" "))
                rs.MoveNext()
            End While

            rs.Close()
            db.Close()

            doc.Close()
            writer.Close()
            MsgBox("Relatório de Desempenho Técnico gerado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro ao gerar o relatório de desempenho técnico: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub GerarRelatorioFichaMedica()
        Try
            Dim doc As New Document()
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(Application.StartupPath & "\FOTOS\RelatorioFichaMedica.pdf", FileMode.Create))
            doc.Open()
            doc.Add(New Paragraph("Relatório de Ficha Médica"))
            doc.Add(New Paragraph(" "))

            conectar_banco_sql() ' Conectar ao banco de dados
            Dim rs As New ADODB.Recordset
            Dim SQL As String = "SELECT * FROM tb_ficha_medica"

            rs.Open(SQL, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            While Not rs.EOF
                doc.Add(New Paragraph("Nome do Atleta: " & rs.Fields("nomeAtleta").Value.ToString()))
                doc.Add(New Paragraph("Idade: " & rs.Fields("idadeAtleta").Value.ToString()))
                doc.Add(New Paragraph("CPF: " & rs.Fields("CPF").Value.ToString()))
                doc.Add(New Paragraph("Altura: " & rs.Fields("altura").Value.ToString()))
                doc.Add(New Paragraph("Nome da Mãe: " & rs.Fields("nomeMae").Value.ToString()))
                doc.Add(New Paragraph("Peso: " & rs.Fields("peso").Value.ToString()))
                doc.Add(New Paragraph("Nome do Pai: " & rs.Fields("nomePai").Value.ToString()))
                doc.Add(New Paragraph("Tipo Sanguíneo: " & rs.Fields("tipoSangue").Value.ToString()))
                doc.Add(New Paragraph("Problemas Cardíacos: " & rs.Fields("coracao").Value.ToString()))
                doc.Add(New Paragraph("Medicação: " & rs.Fields("medicacao").Value.ToString()))
                doc.Add(New Paragraph("Doenças: " & rs.Fields("doencas").Value.ToString()))
                doc.Add(New Paragraph("Alergia a Medicamentos: " & rs.Fields("alergiaMedic").Value.ToString()))
                doc.Add(New Paragraph("Alergias: " & rs.Fields("alergia").Value.ToString()))
                doc.Add(New Paragraph("Histórico de Lesões: " & rs.Fields("lesoes").Value.ToString()))
                doc.Add(New Paragraph("Condições Médicas: " & rs.Fields("condicoes").Value.ToString()))
                doc.Add(New Paragraph("Cirurgias: " & rs.Fields("cirurgia").Value.ToString()))
                doc.Add(New Paragraph(" "))
                rs.MoveNext()
            End While

            rs.Close()
            db.Close()

            doc.Close()
            writer.Close()
            MsgBox("Relatório de Ficha Médica gerado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro ao gerar o relatório de ficha médica: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub


    Private Sub GerarRelatorioGeralAtletas()
        Try
            Dim doc As New Document()
            Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(Application.StartupPath & "\FOTOS\RelatorioGeralAtletas.pdf", FileMode.Create))
            doc.Open()
            doc.Add(New Paragraph("Listagem Geral de Atletas"))
            doc.Add(New Paragraph(" "))

            conectar_banco_sql() ' Conectar ao banco de dados
            Dim rs As New ADODB.Recordset
            Dim SQL As String = "SELECT * FROM tb_cadastro"

            rs.Open(SQL, db, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)

            While Not rs.EOF
                doc.Add(New Paragraph("Nome Completo: " & rs.Fields("Nome").Value.ToString()))
                doc.Add(New Paragraph("Data de Nascimento: " & rs.Fields("dataNasc").Value.ToString()))
                doc.Add(New Paragraph("CPF: " & rs.Fields("CPF").Value.ToString()))
                doc.Add(New Paragraph("Gênero: " & rs.Fields("genero").Value.ToString()))
                doc.Add(New Paragraph("CEP: " & rs.Fields("cep").Value.ToString()))
                doc.Add(New Paragraph("Cidade: " & rs.Fields("cidade").Value.ToString()))
                doc.Add(New Paragraph("Endereço: " & rs.Fields("endereco").Value.ToString()))
                doc.Add(New Paragraph("Número: " & rs.Fields("numero").Value.ToString()))
                doc.Add(New Paragraph("Bairro: " & rs.Fields("bairro").Value.ToString()))
                doc.Add(New Paragraph("UF: " & rs.Fields("uf").Value.ToString()))
                doc.Add(New Paragraph("Telefone: " & rs.Fields("fone").Value.ToString()))
                doc.Add(New Paragraph("E-mail: " & rs.Fields("email").Value.ToString()))
                doc.Add(New Paragraph("Responsável Legal: " & rs.Fields("nomeResp").Value.ToString()))
                doc.Add(New Paragraph("Grau de Parentesco: " & rs.Fields("grau").Value.ToString()))
                doc.Add(New Paragraph("Telefone do Responsável: " & rs.Fields("foneResp").Value.ToString()))
                doc.Add(New Paragraph(" "))

                ' Para adicionar a foto ao relatório, caso exista:
                Dim fotoPath As String = rs.Fields("foto").Value.ToString()
                If File.Exists(fotoPath) Then
                    Dim foto As Image = Image.GetInstance(fotoPath)
                    foto.ScaleToFit(100.0F, 100.0F)
                    doc.Add(foto)
                End If

                doc.Add(New Paragraph(" "))
                rs.MoveNext()
            End While

            rs.Close()
            db.Close()

            doc.Close()
            writer.Close()
            MsgBox("Relatório Geral de Atletas gerado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Aviso")
        Catch ex As Exception
            MsgBox("Erro ao gerar o relatório geral de atletas: " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Atenção")
        End Try
    End Sub

    Private Sub btn_gerar_relatorio_Click(sender As Object, e As EventArgs) Handles btn_gerar_relatorio.Click
        conectar_banco_sql()
        Dim tipoRelatorio As String = cmb_tipo_relatorio.SelectedItem.ToString()
        Select Case tipoRelatorio
            Case "Listagem Geral de Atletas"
                GerarRelatorioGeralAtletas()
            Case "Relatório de Ficha Médica"
                GerarRelatorioFichaMedica()
            Case "Relatório de Desempenho Técnico"
                GerarRelatorioDesempenhoTecnico()
            Case Else
                MsgBox("Selecione um tipo de relatório.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Atenção")
        End Select
    End Sub
End Class
