Imports MySql.Data.MySqlClient
Public Class frm_buscar_cliente_pos
    'Dim objcliente As New CapaEntidad.ClassCliente
    'Dim cnn As New MySqlConnection
    'Dim objcnn As New CapaDatos.ClassConexion
    'Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
    '    --------------------------------------
    '    ---------using shortcuts keys---------
    '    **************************************
    '    Select Case keyData
    '        Case Keys.Enter
    '            If String.IsNullOrEmpty(Me.lbl_cliente.Text) Then
    '                metadatos()
    '            Else
    '                Me.Close()
    '            End If

    '        Case Keys.Escape

    '        Case Keys.Delete

    '        Case Keys.F1

    '        Case Keys.F2

    '        Case Keys.F3

    '        Case Keys.F4

    '        Case Else
    '            Return MyBase.ProcessCmdKey(msg, keyData)
    '    End Select
    '    Return True
    'End Function
    'Sub metadatos()
    '    Try
    '        If Me.txt_documento.Text > 0 Then
    '            objcliente.getdocumento = Convert.ToString(Me.txt_documento.Text)
    '            cnn = objcnn.conectar
    '            Dim cmd As New MySqlCommand("sp_search_cliente_pos", cnn)
    '            cmd.CommandType = CommandType.StoredProcedure
    '            Dim r As MySqlDataReader
    '            Dim p As New MySqlParameter
    '            p = New MySqlParameter("?_name", MySql.Data.MySqlClient.MySqlDbType.VarChar)
    '            p.Value = objcliente.getdocumento
    '            p.Direction = ParameterDirection.Input
    '            cmd.Parameters.Add(p)
    '            r = cmd.ExecuteReader
    '            If r.Read Then
    '                Me.lbl_cliente.Text = Convert.ToString(r("cliente").ToString)
    '                Me.lbl_direccion.Text = Convert.ToString(r("direccion").ToString)
    '                Me.lbl_telefono.Text = Convert.ToString(r("telefono").ToString)
    '                frm_pos._idcliente = Convert.ToUInt64(r("idcliente"))
    '                frm_pos._idtipo_pago_venta = Convert.ToInt64(1)
    '            End If
    '            r.Close()
    '            cnn.Close()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error  al buscar el cliente", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End Try
    'End Sub
    'Private Sub frm_buscar_cliente_pos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    'Private Sub txt_documento_TextChanged(sender As Object, e As EventArgs) Handles txt_documento.TextChanged

    'End Sub
End Class