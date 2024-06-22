Module mod_global
    Public diretorio, SQL, aux_cpf, resp, aux_usuario As String
    Public db As ADODB.Connection
    Public rs As ADODB.Recordset
    Public cont, id_conta, id_atleta As Integer

    Sub conectar_banco_sql()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source=DESKTOP-5RVS0C1\SQLEXPRESS2022;initial catalog=db_signt;trusted_connection=yes;")
            MsgBox("Conexão bem sucedida!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")

        Catch ex As Exception
            MsgBox("Erro ao conectar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")

        End Try
    End Sub

    Sub gerar_id_conta()
        SQL = "select * from tb_login order by id_conta desc"
        rs = db.Execute(SQL)
        If rs.BOF = True Then 'Se a tabela não conter nenhum registro
            id_conta = 1
        Else
            id_conta = rs.Fields(0).Value + 1
        End If
    End Sub

    Sub gerar_id_atleta()
        SQL = "select * from tb_cadastro order by id_atleta desc"
        rs = db.Execute(SQL)
        If rs.BOF = True Then
            id_atleta = 1
        Else
            id_atleta = rs.Fields(0).Value + 1
        End If
    End Sub

    Sub gerar_id_atleta_ficha_medic()
        SQL = "select * from tb_ficha_medica order by id_atleta desc"
        rs = db.Execute(SQL)
        If rs.BOF = True Then
            id_atleta = 1
        Else
            id_atleta = rs.Fields(0).Value + 1
        End If
    End Sub

    Sub gerar_id_atleta_dados_tec()
        SQL = "select * from tb_dados_tec order by id_atleta desc"
        rs = db.Execute(SQL)
        If rs.BOF = True Then
            id_atleta = 1
        Else
            id_atleta = rs.Fields(0).Value + 1
        End If
    End Sub

    Sub carregar_contas()
        Try
            With frm_login.dgv_contas
                id_conta = 1
                SQL = "select * from tb_login order by usuario asc"
                rs = db.Execute(SQL)
                .Rows.Clear()
                Do While rs.EOF = False
                    .Rows.Add(id_conta, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(5).Value, Nothing, Nothing, Nothing)
                    id_conta = id_conta + 1
                    rs.MoveNext()
                Loop
            End With
        Catch ex As Exception
            MsgBox("Erro ao carregar dados da conta!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_cadastros()
        Try
            SQL = "select * from tb_cadastro order by Nome asc"
            rs = db.Execute(SQL)
            id_atleta = 1
            With Form5.dgv_atletas
                .Rows.Clear()
                Do While rs.EOF = False 'Enquanto existir o registro no banco
                    .Rows.Add(id_atleta, rs.Fields(3).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(11).Value, rs.Fields(12).Value, Nothing)
                    id_atleta = id_atleta + 1
                    rs.MoveNext()
                Loop

            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub carregar_tipo()
        Try
            With Form5.cmb_tipo.Items
                .Add("CPF")
                .Add("Nome")
            End With
            Form5.cmb_tipo.SelectedIndex = 1
        Catch ex As Exception
            MsgBox("Erro ao carregar o tipo do campo!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_cadastro()
        Try
            With Form1
                .txt_cadast_nome.Clear()
                .cmb_data_nasc.Value = Now
                .txt_cadast_cpf.Clear()
                .cmb_genero.SelectedIndex = -1
                .txt_cadast_cep.Clear()
                .txt_cadast_cidade.Clear()
                .txt_cadast_endereco.Clear()
                .txt_cadast_num.Clear()
                .txt_cadast_bairro.Clear()
                .txt_cadast_uf.Clear()
                .txt_cadast_fone.Clear()
                .txt_cadast_email.Clear()
                .img_foto.Load(Application.StartupPath & "\FOTOS\nova_foto.png")
                .txt_nome_resplegal.Clear()
                .txt_grau_parent.Clear()
                .txt_resp_fone.Clear()
                .txt_cadast_nome.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_ficha_medica()
        Try
            With Form2
                .txt_ficha_nome_atleta.Clear()
                .txt_ficha_idade.Clear()
                .txt_ficha_cpf.Clear()
                .txt_altura_ficha.Clear()
                .txt_ficha_nome_mae.Clear()
                .txt_peso_ficha.Clear()
                .txt_ficha_nome_pai.Clear()
                .cmb_tipo_sanguineo.SelectedIndex = -1
                .txt_ficha_coracao.Clear()
                .txt_ficha_medicacao.Clear()
                .txt_ficha_doencas.Clear()
                .txt_ficha_alergia_medicacao.Clear()
                .txt_ficha_alergia.Clear()
                .txt_ficha_historico_lesoes.Clear()
                .txt_ficha_condicoes.Clear()
                .txt_ficha_cirurgia.Clear()
                .txt_ficha_nome_atleta.Focus()
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

    Sub limpar_ficha_dados_tec()
        Try
            With Form3
                .txt_nome.Clear()
                .txt_idade.Clear()
                .txt_dados_cpf.Clear()
                .txt_altura.Clear()
                .txt_peso.Clear()
                .cmb_posicao.SelectedIndex = -1
                .txt_hab_tecnicas.Clear()
                .txt_hab_fisicas.Clear()
                .txt_aval_desemp.Clear()
                .img_foto.Load(Application.StartupPath & "\FOTOS\nova_foto.png")
            End With
        Catch ex As Exception
            MsgBox("Erro ao processar!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ATENÇÃO")
        End Try
    End Sub

End Module
