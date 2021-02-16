Imports System
Imports WhatsAppApi
Imports System.IO

Public Class ClassAll

    Public Sub cleartext(ByVal group As Object)
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(RichTextBox) Then
                ctrl.Text = Nothing
            End If
        Next
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(ComboBox) Then
                ctrl.Text = "---Select---"
            End If
        Next
    End Sub
    'Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
    '    If DataGridView5.RowCount = Nothing Then
    '        MessageBox.Show("Sorry nothing to export into excel sheet.." & vbCrLf & "Please retrieve data in datagridview", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        Exit Sub
    '    End If
    '    Dim rowsTotal, colsTotal As Short
    '    Dim I, j, iC As Short
    '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
    '    Dim xlApp As New excel.Application

    '    Try
    '        Dim excelBook As excel.Workbook = xlApp.Workbooks.Add
    '        Dim excelWorksheet As excel.Worksheet = CType(excelBook.Worksheets(1), excel.Worksheet)
    '        xlApp.Visible = True

    '        rowsTotal = DataGridView5.RowCount - 1
    '        colsTotal = DataGridView5.Columns.Count - 1
    '        With excelWorksheet
    '            .Cells.Select()
    '            .Cells.Delete()
    '            For iC = 0 To colsTotal
    '                .Cells(1, iC + 1).Value = DataGridView5.Columns(iC).HeaderText
    '            Next
    '            For I = 0 To rowsTotal - 1
    '                For j = 0 To colsTotal
    '                    .Cells(I + 2, j + 1).value = DataGridView5.Rows(I).Cells(j).Value
    '                Next j
    '            Next I
    '            .Rows("1:1").Font.FontStyle = "Bold"
    '            .Rows("1:1").Font.Size = 12

    '            .Cells.Columns.AutoFit()
    '            .Cells.Select()
    '            .Cells.EntireColumn.AutoFit()
    '            .Cells(1, 1).Select()
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    Finally
    '        'RELEASE ALLOACTED RESOURCES
    '        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    '        xlApp = Nothing
    '    End Try
    'End Sub
    'Private Sub btnBrowseCompanyLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseCompanyLogo.Click
    '    Try
    '        Dim dlgImage As FileDialog = New OpenFileDialog()

    '        dlgImage.Filter = "Image File (*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"

    '        If dlgImage.ShowDialog() = DialogResult.OK Then
    '            imgName = dlgImage.FileName

    '            Dim newimg As New Bitmap(imgName)

    '            picBoxSettings.SizeMode = PictureBoxSizeMode.StretchImage
    '            picBoxSettings.Image = DirectCast(newimg, Image)
    '        End If

    '        dlgImage = Nothing
    '    Catch ae As System.ArgumentException
    '        imgName = " "

    '        MessageBox.Show(ae.Message.ToString())
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message.ToString())
    '    End Try
    'End Sub
    ' ''Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

    ' ''    Using ms As MemoryStream = New MemoryStream()

    ' ''        Dim bm As Bitmap = New Bitmap(picBoxSettings.Image)
    ' ''        bm.Save(ms, picBoxSettings.Image.RawFormat)
    ' ''        Dim arrPic() As Byte = ms.GetBuffer()

    ' ''        Dim cmd As New OleDbCommand
    ' ''        cnn.Open()

    ' ''        cmd = New OleDbCommand("update tblSettings set CompanyPicture=@CompanyPicture where CompanyID='" & 1 & "'", cnn)

    ' ''        With cmd
    ' ''            .Parameters.AddWithValue("@CompanyPicture", arrPic)
    ' ''            .ExecuteNonQuery()
    ' ''            If cnn.State = ConnectionState.Open Then
    ' ''                cnn.Close()
    ' ''            End If
    ' ''        End With

    ' ''    End Using
    ' ''End Sub
    'Private dv As New DataView
    'Private Sub btnbuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbuscar.Click
    '    Dim cnn As New SqlConnection("Data SOURCE= RICARDO-HP\SQLEXPRESS; Initial Catalog=EMPLEADOS;Integrated Security=SSPI;")
    '    Dim da As New SqlDataAdapter("Select * from DatosEmpleados", cnn)
    '    Dim ds As New DataSet
    '    da.Fill(ds)
    '    dv.Table = ds.Tables(0)
    '    DataGridView1.DataSource = dv
    'End Sub
    'Private Sub txtbuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbuscar.TextChanged
    '    dv.RowFilter = String.Format("Nombre like '{0}%'", txtbuscar.Text)
    'End Sub
    ' *********************************************
    'If MaskedTextBox1.MaskFull = False Then
    '        MsgBox("El campo de Telefono no puede estar vacio.", MsgBoxStyle.Information)
    '    Else
    'Imports Microsoft.Office.Interop
    'Public Class ExportaExcel
    '    Public Sub exportarExcel(ByVal tabla As DataTable)
    '        Dim fila As DataRow 'Filas de Exel
    '        Dim posicion As Integer = 5 'Posiciones de Excel
    '        Dim MExcel As Excel.Application 'Variable para la Aplicacion de Excel
    '        Dim objLIBROExcel As Excel.Workbook = MExcel.Workbooks.Add 'Libro de Excel
    '        Dim objHOJAExcel As Excel.Worksheet = objLIBROExcel.Worksheets(1) 'Hoja de Excel

    '        With objHOJAExcel
    '            .Visible = Excel.XlSheetVisibility.xlSheetVisible
    '            .Activate()
    '            .Name = "Datos Exportados"
    '            .Range("A1").Value = "Datos de Exportacion"
    '            .Range("A1").Font.Size = 28
    '            .Range("A1").Font.Name = "Calibri (Cuerpo)"
    '            .Range("A1").Font.Italic = True
    '            .Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    '            .Range("A1").RowHeight = 30
    '            .Range("A1:F1").MergeCells = True
    '            .Range("A2").Value = "Codigo"
    '            .Range("A2").ColumnWidth = 10
    '            .Range("B2").Value = "Nombre"
    '            .Range("B2").ColumnWidth = 30
    '            .Range("C2").Value = "Apellido"
    '            .Range("C2").ColumnWidth = 30
    '            .Range("D2").Value = "Cargo"
    '            .Range("D2").ColumnWidth = 30
    '            .Range("E2").Value = "Sueldo"
    '            .Range("E2").ColumnWidth = 30

    '            For Each fila In tabla.Rows
    '                objHOJAExcel.Range("A" & posicion).Value = fila.Item("Codigo")
    '                objHOJAExcel.Range("B" & posicion).Value = fila.Item("Nombre")
    '                objHOJAExcel.Range("C" & posicion).Value = fila.Item("Apellido")
    '                objHOJAExcel.Range("D" & posicion).Value = fila.Item("Cargo")
    '                objHOJAExcel.Range("E" & posicion).Value = fila.Item("Sueldo")
    '                posicion += 1

    '            Next

    '            MExcel.Visible = True

    '        End With
    '    End Sub
    'End Class
    'Imports MySql.Data.MySqlClient
    'Public Class estudiante

    '    Dim nue_conexion As New conexion
    '    Dim nue_var As New variables

    '    'funcion para listar los estudiantes
    '    Public Function listar() As DataTable
    '        nue_var.dt = New DataTable
    '        nue_conexion.conectar()
    '        nue_var.da = New MysqlDataAdapter("SELECT * FROM estudiante", nue_conexion.conex())
    '        nue_var.da.Fill(nue_var.dt)
    '        nue_conexion.desconectar()
    '        listar = nue_var.dt
    '        Return listar
    '    End Function

    '    'procedimiento para insertar estudiantes
    '    Public Sub insertar(ByVal num_id As Double, ByVal nom As String, ByVal ape1 As String, ByVal ape2 As String, ByVal fecha As Date, ByVal dir As String, ByVal tel As Double)
    '        nue_var.consulta = "INSERT INTO estudiante VALUES('', ?num_id, ?nom, ?ape1, ?ape2, ?fech, ?dir, ?tel)"
    '        Try
    '            nue_conexion.conectar()
    '            nue_var.cmd = New MysqlCommand(nue_var.consulta, nue_conexion.conex())
    '            nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_id
    '            nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
    '            nue_var.cmd.Parameters.Add("?ape1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ape1
    '            nue_var.cmd.Parameters.Add("?ape2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ape2
    '            nue_var.cmd.Parameters.Add("?fech", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
    '            nue_var.cmd.Parameters.Add("?dir", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = dir
    '            nue_var.cmd.Parameters.Add("?tel", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = tel
    '            nue_var.cmd.ExecuteNonQuery()
    '            nue_conexion.desconectar()
    '        Catch mierror As MySqlException
    '            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
    '        End Try
    '    End Sub

    '    'procedimiento para modificar estudiantes
    '    Public Sub modificar(ByVal cod_est As Integer, ByVal num_id As Double, ByVal nom As String, ByVal ape1 As String, ByVal ape2 As String, ByVal fecha As Date, ByVal dir As String, ByVal tel As Double)
    '        nue_var.consulta = "UPDATE estudiante SET num_documento = ?num_id, nombres = ?nom, apellido1 = ?ape1, apellido2 = ?ape2, direccion= ?dir, telefono = ?tel WHERE cod_estudiante = ?cod_est"
    '        Try
    '            nue_conexion.conectar()
    '            nue_var.cmd = New MysqlCommand(nue_var.consulta, nue_conexion.conex())
    '            nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
    '            nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_id
    '            nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
    '            nue_var.cmd.Parameters.Add("?ape1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ape1
    '            nue_var.cmd.Parameters.Add("?ape2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ape2
    '            nue_var.cmd.Parameters.Add("?fech", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
    '            nue_var.cmd.Parameters.Add("?dir", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = dir
    '            nue_var.cmd.Parameters.Add("?tel", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = tel
    '            nue_var.cmd.ExecuteNonQuery()
    '            nue_conexion.desconectar()
    '        Catch mierror As MySqlException
    '            MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
    '        End Try
    '    End Sub

    '    'funcion para buscar el nombre del estudiante
    '    Public Function nombre_estudiante(ByVal num_id As Double) As String
    '        nue_var.consulta = "SELECT nombres FROM estudiante WHERE num_documento = ?num_id"
    '        nue_conexion.conectar()
    '        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
    '        nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_id
    '        nue_var.dr = nue_var.cmd.ExecuteReader()
    '        If nue_var.dr.Read Then
    '            nombre_estudiante = nue_var.dr("nombres")
    '        End If
    '        nue_var.dr.Close()
    '        nue_conexion.desconectar()
    '        Return nombre_estudiante
    '    End Function

    '    'funcion para buscar el apellido del estudiante
    '    Public Function apellido_estudiante(ByVal num_id As Double) As String
    '        nue_var.consulta = "SELECT apellido1 FROM estudiante WHERE num_documento = ?num_id"
    '        nue_conexion.conectar()
    '        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
    '        nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_id
    '        nue_var.dr = nue_var.cmd.ExecuteReader()
    '        If nue_var.dr.Read Then
    '            apellido_estudiante = nue_var.dr("apellido1")
    '        End If
    '        nue_var.dr.Close()
    '        nue_conexion.desconectar()
    '        Return apellido_estudiante
    '    End Function

    '    'funcion que retorna el codigo del estudiante
    '    Public Function cod_estudiante(ByVal num_id As Double) As Integer
    '        nue_var.consulta = "SELECT cod_estudiante FROM estudiante WHERE num_documento = ?num_id"
    '        nue_conexion.conectar()
    '        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
    '        nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_id
    '        nue_var.dr = nue_var.cmd.ExecuteReader()
    '        If nue_var.dr.Read Then
    '            cod_estudiante = nue_var.dr("cod_estudiante")
    '        End If
    '        nue_var.dr.Close()
    '        nue_conexion.desconectar()
    '        Return cod_estudiante
    '    End Function

    '    'funcion que verifica si un estudiante existe
    '    Public Function verificar(ByVal num_id As Double) As Boolean
    '        nue_var.consulta = "SELECT * FROM estudiante WHERE num_documento = ?num_id"
    '        nue_conexion.conectar()
    '        nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
    '        nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_id
    '        nue_var.dr = nue_var.cmd.ExecuteReader()
    '        If nue_var.dr.Read Then
    '            verificar = True
    '        Else
    '            verificar = False
    '        End If
    '        nue_var.dr.Close()
    '        nue_conexion.desconectar()
    '        Return verificar
    '    End Function

    'End Class
    'Private Sub GUARDARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GUARDARToolStripMenuItem.Click
    '    Dim Save As New SaveFileDialog()
    '    Dim myStreamWriter As System.IO.StreamWriter
    '    Save.Filter = "Text (*.txt)|*.txt|HTML(*.html*)|*.html|PHP(*.php*)|*.php*|All files(*.*)|*.*"
    '    Save.CheckPathExists = True
    '    Save.Title = "Guardar como"
    '    Save.ShowDialog(Me)
    '    myStreamWriter = System.IO.File.AppendText(Save.FileName)
    '    myStreamWriter.Write(RichTextBox1.Text)
    '    myStreamWriter.Flush()
    'End Sub
    '    Imports System.Security.Cryptography
    'Imports System.IO
    'Imports System.Text
    '    Public Class Encriptacion
    '        Public Function EncriptaSHA(ByVal strcadena As String) As String
    '            Dim Codificacion As New UTF8Encoding
    '            Dim data() As Byte = Codificacion.GetBytes(strcadena)
    '            Dim resultado() As Byte
    '            Dim sha As New SHA1CryptoServiceProvider()
    '            resultado = sha.ComputeHash(data)
    '            Dim sb As New StringBuilder
    '            For i As Integer = 0 To resultado.Length - 1
    '                If resultado(i) < 16 Then
    '                    sb.Append("0")
    '                End If
    '                sb.Append(resultado(i).ToString("x"))
    '            Next
    '            Return sb.ToString().ToUpper
    '        End Function
    '    End Class
    Sub consutar_excel()

        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim DtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        MyConnection = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='e:\Max80.xlsx';Extended Properties=Excel 8.0;")
        MyCommand = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet2$]", MyConnection)
        MyCommand.TableMappings.Add("Table", "Net-informations.com")
        DtSet = New System.Data.DataSet
        MyCommand.Fill(DtSet)
        'DataGridView1.DataSource = DtSet.Tables(0)
        MyConnection.Close()
    End Sub


    Sub llenar_mysql_datagrid()

        'getData()
        'Dim i As Integer
        'For i = 0 To DataGridView1.RowCount - 1
        '    'Adding criteria rating to Rating table
        '    AddEditData("INSERT INTO Transmutation(Equivalent, Score, Max) VALUES('" & DataGridView1.Rows(i).Cells(0).Value & "','" & DataGridView1.Rows(i).Cells(1).Value & "', '" & DataGridView1.Rows(i).Cells(2).Value & "')")

        'Next
        'MsgBox("Added")
    End Sub
    'Dim serie As String
    '        If objLetras.id_letras < 10 Then
    '            serie = "0000000" & objLetras.id_letras.ToString
    '        ElseIf objLetras.id_letras < 100 Then
    '            serie = "000000" & objLetras.id_letras.ToString
    '        ElseIf objLetras.id_letras < 1000 Then
    '            serie = "00000" & objLetras.id_letras.ToString
    '        ElseIf objLetras.id_letras < 10000 Then
    '            serie = "0000" & objLetras.id_letras.ToString
    '        ElseIf objLetras.id_letras < 100000 Then
    '            serie = "000" & objLetras.id_letras.ToString
    '        ElseIf objLetras.id_letras < 1000000 Then
    '            serie = "00" & objLetras.id_letras.ToString
    '        ElseIf objLetras.id_letras < 10000000 Then
    '            serie = "0" & objLetras.id_letras.ToString
    '        Else
    '            serie = objLetras.id_letras.ToString
    '        End If
    '#Region "PANEL MOVING"
    '    '[1] DECLARATION
    '    Dim drag As Boolean
    '    Dim mousex As Integer
    '    Dim mousey As Integer

    '    'Move FORM WHeN PANEL MOVED
    '    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
    '        drag = True 'Sets the variable drag to true.
    '        mousex = Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
    '        mousey = Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey
    '    End Sub
    '    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
    '        If drag Then
    '            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
    '            Me.Left = Windows.Forms.Cursor.Position.X - mousex
    '        End If

    '    End Sub
    '    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
    '        drag = False
    '    End Sub
    '#End Region
    'Me.WindowState = FormWindowState.Minimized
    'http://www.messenger.com
    ' ****************************************+
    'Timer1.Interval = CInt(TextBoxSEGUNDOS.Text * 1000)
    '       Timer1.Start()
    '*********************************
    '        WebBrowser1.Navigate(TextBoxNAVEGACION.Text)
    '************************************
    ' If e.KeyCode = Keys.Enter Then
    '***************************************
    'Function StartExcel(Optional ByVal IsVisible As Boolean = True) As Excel.Application
    '    Dim objExcel As New Excel.Application
    '    objExcel.Visible = IsVisible
    '    Return objExcel
    'End Function
    '********************************
    'Sub ForceExcelToQuit(ByVal objExcel As Excel.Application)
    '    Try
    '        objExcel.Quit()
    '    Catch ex As Exception
    '    End Try
    'End Sub
    '*******************************
    'Sub DataTableToExcelSheet(ByVal dt As DataTable, ByVal objSheet As Excel.Worksheet, ByVal nStartRow As Integer, ByVal nStartCol As Integer)
    '    Dim nRow As Integer, nCol As Integer
    '    For nRow = 0 To dt.Rows.Count - 1
    '        For nCol = 0 To dt.Columns.Count - 1
    '            objSheet.Cells(nStartRow + nRow, nStartCol + nCol) = dt.Rows(nRow).Item(nCol)
    '        Next nCol
    '    Next nRow
    'End Sub
    '*************************************
    ''Select Case Me.cboRecurrence.Text
    '        Case "Minutes" : Me.udEvery.Maximum = 1439
    '        Case "Hours" : Me.udEvery.Maximum = 23
    '        Case "Days" : Me.udEvery.Maximum = 365
    '    End Select
    '************************************
    '        encodingComboBox.Items.AddRange(New String() {"ASCII", "BigEndianUnicode", "Unicode", "UTF7", "UTF8", "UTF32"})
    ' Private Function GetImageFormat() As ImageFormat
    '    Select Case SaveFileDialog1.FilterIndex
    '        Case 1
    '            Return ImageFormat.Bmp
    '        Case 2
    '            Return ImageFormat.Jpeg
    '        Case 3
    '            Return ImageFormat.Gif
    '        Case Else
    '            Return ImageFormat.Tiff
    '    End Select
    'End Function
    '#Region "Zoom Methods"

    '    ''' <summary>
    '    ''' Zooms to 25%
    '    ''' </summary>
    '    Private Sub Zoom25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zoom25.Click
    '        Zoom(0.25)
    '    End Sub

    '    ''' <summary>
    '    ''' Zooms to 50%
    '    ''' </summary>
    '    Private Sub Zoom50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zoom50.Click
    '        Zoom(0.5)
    '    End Sub

    '    ''' <summary>
    '    ''' Zooms to 100%
    '    ''' </summary>
    '    Private Sub Zoom100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zoom100.Click
    '        Zoom(1)
    '    End Sub

    '    ''' <summary>
    '    ''' Zooms to 150%
    '    ''' </summary>
    '    Private Sub Zoom150_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zoom150.Click
    '        Zoom(1.5)
    '    End Sub

    '    ''' <summary>
    '    ''' Zooms to 200%
    '    ''' </summary>
    '    Private Sub Zoom200_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Zoom200.Click
    '        Zoom(2)
    '    End Sub
    '***************************************++
    'Public Function ListaDatosCategorias() As DataTable
    '    Using Da As New SqlDataAdapter("USPDEMOCATEGORIAS", Cn)
    '        Da.SelectCommand.CommandType = CommandType.StoredProcedure
    '        Using Dt As New DataTable
    '            Da.Fill(Dt)
    '            Return Dt
    '        End Using
    '    End Using
    'End Function
    '******************************************
    'Public Sub ListaProveedores(ByVal Cbo As ComboBox)
    '    Dim Da As New SqlDataAdapter("USP_LISTAPROVEEDOR", Cn)
    '    Da.SelectCommand.CommandType = CommandType.StoredProcedure
    '    Dim Dt As New DataTable
    '    Da.Fill(Dt)
    '    With Cbo
    '        .DataSource = Dt
    '        .DisplayMember = "NomProveedor"
    '        .ValueMember = "IdProveedor"
    '    End With
    'End Sub
    '*************************************************
    'Public Sub ListaProductos(ByVal x As Integer, ByVal Dg As DataGridView)
    '    Dim Da As New SqlDataAdapter("USP_LISTAPRODUCTOSXPROVEEDOR", Cn)
    '    Da.SelectCommand.CommandType = CommandType.StoredProcedure
    '    Da.SelectCommand.Parameters.AddWithValue("@codigo", x)
    '    Dim Dt As New DataTable
    '    Da.Fill(Dt)
    '    Dg.DataSource = Dt
    'End Sub
    '**************************************************+
    'IdPedidos de Clientes entre un rango de fechas
    'Public Function NroPedidos(ByVal Nom As String, ByVal Fi As Date, ByVal Ff As Date) As DataTable
    '    Dim Da As New SqlDataAdapter("USP_PEDCLIENTESXFECHA", Cn)
    '    Da.SelectCommand.CommandType = CommandType.StoredProcedure

    '    Da.SelectCommand.Parameters.AddWithValue("@NOMCLI", Nom)
    '    Da.SelectCommand.Parameters.AddWithValue("@FINICIAL", Fi)
    '    Da.SelectCommand.Parameters.AddWithValue("@FFINAL", Ff)
    '    Dim Dt As New DataTable
    '    Da.Fill(Dt)
    '    Return Dt
    'End Function
    '******************************************************
    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    If Me.OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        Me.RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(Me.OpenFileDialog1.FileName)
    '    End If
    'End Sub
    '*******************************************************
    ' Set objVoice = CreateObject("SAPI.SpVoice")
    'set v = objVoice.getvoices
    'for each i in v
    '	Msgbox i.getdescription
    'Next
    '********************************************************
    'Public Function nombre_estudiante(ByVal num_id As Double) As String
    '    nue_var.consulta = "SELECT nombres FROM estudiante WHERE num_documento = ?num_id"
    '    nue_conexion.conectar()
    '    nue_var.cmd = New MySqlCommand(nue_var.consulta, nue_conexion.conex())
    '    nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_id
    '    nue_var.dr = nue_var.cmd.ExecuteReader()
    '    If nue_var.dr.Read Then
    '        nombre_estudiante = nue_var.dr("nombres")
    '    End If
    '    nue_var.dr.Close()
    '    nue_conexion.desconectar()
    '    Return nombre_estudiante
    'End Function
    '*************************************************
    'Public Function listar() As DataTable
    '    nue_var.dt = New DataTable
    '    nue_conexion.conectar()
    '    nue_var.da = New MysqlDataAdapter("SELECT * FROM estudiante", nue_conexion.conex())
    '    nue_var.da.Fill(nue_var.dt)
    '    nue_conexion.desconectar()
    '    listar = nue_var.dt
    '    Return listar
    'End Function
    '*************************************************
    'procedimiento para insertar estudiantes
    'Public Sub insertar(ByVal num_id As Double, ByVal nom As String, ByVal ape1 As String, ByVal ape2 As String, ByVal fecha As Date, ByVal dir As String, ByVal tel As Double)
    '    nue_var.consulta = "INSERT INTO estudiante VALUES('', ?num_id, ?nom, ?ape1, ?ape2, ?fech, ?dir, ?tel)"
    '    Try
    '        nue_conexion.conectar()
    '        nue_var.cmd = New MysqlCommand(nue_var.consulta, nue_conexion.conex())
    '        nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_id
    '        nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
    '        nue_var.cmd.Parameters.Add("?ape1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ape1
    '        nue_var.cmd.Parameters.Add("?ape2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ape2
    '        nue_var.cmd.Parameters.Add("?fech", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
    '        nue_var.cmd.Parameters.Add("?dir", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = dir
    '        nue_var.cmd.Parameters.Add("?tel", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = tel
    '        nue_var.cmd.ExecuteNonQuery()
    '        nue_conexion.desconectar()
    '    Catch mierror As MySqlException
    '        MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
    '    End Try
    'End Sub
    '***************************************************
    'procedimiento para modificar estudiantes
    'Public Sub modificar(ByVal cod_est As Integer, ByVal num_id As Double, ByVal nom As String, ByVal ape1 As String, ByVal ape2 As String, ByVal fecha As Date, ByVal dir As String, ByVal tel As Double)
    '    nue_var.consulta = "UPDATE estudiante SET num_documento = ?num_id, nombres = ?nom, apellido1 = ?ape1, apellido2 = ?ape2, direccion= ?dir, telefono = ?tel WHERE cod_estudiante = ?cod_est"
    '    Try
    '        nue_conexion.conectar()
    '        nue_var.cmd = New MysqlCommand(nue_var.consulta, nue_conexion.conex())
    '        nue_var.cmd.Parameters.Add("?cod_est", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = cod_est
    '        nue_var.cmd.Parameters.Add("?num_id", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = num_id
    '        nue_var.cmd.Parameters.Add("?nom", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = nom
    '        nue_var.cmd.Parameters.Add("?ape1", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ape1
    '        nue_var.cmd.Parameters.Add("?ape2", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = ape2
    '        nue_var.cmd.Parameters.Add("?fech", MySql.Data.MySqlClient.MySqlDbType.Date).Value = fecha
    '        nue_var.cmd.Parameters.Add("?dir", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = dir
    '        nue_var.cmd.Parameters.Add("?tel", MySql.Data.MySqlClient.MySqlDbType.Int64).Value = tel
    '        nue_var.cmd.ExecuteNonQuery()
    '        nue_conexion.desconectar()
    '    Catch mierror As MySqlException
    '        MsgBox("Error de Conexión a la Base de Datos: " & mierror.Message)
    '    End Try
    'End Sub
    '***********************************************************************
    'Imports MySql.Data.MySqlClient
    'Public Class conexion

    '    'aqui coloca tu cadena de conexion de xampp, wampp o lo que sea que uses
    '    Private con As New MySqlConnection("server=localhost; user=root; database=sistema-matriculas")

    '    'procedimiento que abre la conexion mysql
    '    Public Sub conectar()
    '        con.Open()
    '    End Sub

    '    'procedimiento quecierra la conexion mysql
    '    Public Sub desconectar()
    '        con.Close()
    '    End Sub

    '    'funcion que devuelve la conexion mysql
    '    Function conex() As MySqlConnection
    '        conex = con
    '        Return conex
    '    End Function

    'End Class
    '*******************************************************
    'Private Sub dgvCliente_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCliente.CellClick
    '    If dgvCliente.Rows.Count > 0 Then
    '        Dim dgvFila As DataGridViewRow = Me.dgvCliente.CurrentRow()
    '        Me.txtCodCliente.Text = dgvFila.Cells(0).Value
    '        Me.txtNomCliente.Text = dgvFila.Cells(1).Value
    '        Me.txtApeCliente.Text = dgvFila.Cells(2).Value
    '        Me.txtDirrCliente.Text = dgvFila.Cells(3).Value
    '        Me.txtDNICliente.Text = dgvFila.Cells(4).Value
    '        Me.txtTelfCliente.Text = dgvFila.Cells(5).Value
    '        Me.txtRUC.Text = dgvFila.Cells(6).Value
    '    Else
    '        MsgBox("No hay ningun registro seleccionado")
    '    End If
    '*********************************************************
    Private mstrConnection As String = _
        "Provider=Microsoft.Jet.OLEDB.4.0;" & _
        "Data Source=|DataDirectory|\employeedb.mdb;"
    '' If dr.Read Then

    ''            Try
    ''                bytImage = CType(dr(0), Byte())
    ''Dim ms As New System.IO.MemoryStream(bytImage)
    ''Dim bmImage As New Bitmap(MS)
    ''                ms.Close()

    ''                myimage.Image = bmImage
    ''                myimage.Refresh()
    ''            Catch ex As Exception
    ''                MsgBox(ex.ToString)
    ''            End Try
    ''        End If
    'Dim command As New OleDbCommand("insert into administrator ([username], [password], [date_reg], [myimage]) values (@user, @pass, @datereg, @myimage)", conn)
    '                            With command.Parameters
    '                                .AddWithValue("@user", user.Text)
    '                                .AddWithValue("@pass", pass.Text)
    '                                .AddWithValue("@datereg", DateReg.Text)

    '                                Try
    'Dim ms As New System.IO.MemoryStream
    'Dim bmpImage As New Bitmap(myimage.Image)

    '                                    bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
    '                                    bytImage = ms.ToArray()
    '                                    ms.Close()
    '                                Catch ex As Exception
    '                                    MsgBox(ex.ToString)
    '                                End Try

    '                                .AddWithValue("@myimage", bytImage)

    '                            End With
    'Dim FileToMove As String
    'Dim MoveLocation As String
    'Dim FileToDel As String

    '        FileToMove = "" & System.Environment.CurrentDirectory & "\employeedb.mdb"
    '        MoveLocation = "" & System.Environment.CurrentDirectory & "\backup\employeedb.mdb"
    '        FileToDel = "" & System.Environment.CurrentDirectory & "\backup\employeedb.mdb"

    '        System.IO.File.Delete(FileToDel)
    '        System.IO.File.Copy(FileToMove, MoveLocation)
    '        MsgBox("Database successfully backed up!")
    '#Region "Minimize Button"
    '    Private Sub btnMinimize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinimize.Click
    '        If Me.WindowState = FormWindowState.Normal Then
    '            Me.WindowState = FormWindowState.Minimized
    '        Else
    '            Me.Refresh()
    '        End If
    '    End Sub
    '#End Region
    'Private Sub upload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upload.Click
    '    Dim OpenFile As New OpenFileDialog()
    '    Try
    '        With OpenFile
    '            .FileName = ""
    '            .Title = "Upload Student Photo..."
    '            .Filter = "Image file (*.jpg)|*.jpg|(*.png)|*.png|(*.jpeg)|*.jpeg|(*.giff)|*.giff| All Files (*.*)|*.*"

    '            If .ShowDialog = Windows.Forms.DialogResult.OK Then
    '                Me.PictureBox1.Image = System.Drawing.Bitmap.FromFile(.FileName)
    '            Else
    '            End If
    '        End With
    '    Catch ex As Exception
    '        MsgBox(ex.Message())
    '    End Try
    'End Sub
    'Private Sub registerstudent()
    '    Try
    '        ConnDB()
    '        Dim cmd As New OleDbCommand("INSERT INTO register VALUES(@fullName,@sex,@datebirth,@address,@class,@lga,@state,@parentname,@occupation,@phone,@email,@dayborder,@admissionnumber,@photo)", conn)
    '        cmd.Parameters.AddWithValue("@fullName", txtstudname.Text)
    '        cmd.Parameters.AddWithValue("@sex", cmdsex.Text)
    '        cmd.Parameters.AddWithValue("@datebirth", txtdatebirth.Text)
    '        cmd.Parameters.AddWithValue("@address", txtaddress.Text)
    '        cmd.Parameters.AddWithValue("@class", txtclass.Text)
    '        cmd.Parameters.AddWithValue("@lga", txtlga.Text)
    '        cmd.Parameters.AddWithValue("@state", cmdstate.Text)
    '        cmd.Parameters.AddWithValue("@parentname", txtparentname.Text)
    '        cmd.Parameters.AddWithValue("@occupation", txtparentoccupation.Text)
    '        cmd.Parameters.AddWithValue("@phone", txtparentphone.Text)
    '        cmd.Parameters.AddWithValue("@email", Txtparentemail.Text)
    '        cmd.Parameters.AddWithValue("@dayborder", cmddayborder.Text)
    '        cmd.Parameters.AddWithValue("@admissionnumber", txtadmissionnumber.Text)

    '        Dim ms As New MemoryStream()
    '        PictureBox1.Image.Save(ms, Imaging.ImageFormat.Jpeg)
    '        '    Picphoto.Image.Save(ms, Picphoto.Image.RawFormat)
    '        Dim data As Byte() = ms.GetBuffer()
    '        Dim p As New OleDbParameter("@photo", OleDbType.Binary)
    '        p.Value = data
    '        cmd.Parameters.Add(p)
    '        cmd.ExecuteNonQuery()
    '        MessageBox.Show("Student Was Registered Successfully", "Database Report", MessageBoxButtons.OK)
    '    Catch ex As Exception
    '        MsgBox(ex.Message())
    '    End Try
    'End Sub
    'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    '    Dim ObjDataView As New DataView
    '    Dim buscar As Integer


    '    Try
    '        Me.dgConsultas.DataSource = Nothing
    '        buscar = Me.txtNoContrato.Text 'Or Me.txtFolioFactura.Text
    '        ObjDataView.Table = ds.Tables("contratos,factservicio")
    '        ObjDataView.RowFilter = "no_contrato='" & buscar & "'" ' Or "id_usuario='" & buscar & "'"
    '        If ObjDataView.Count > 0 Then
    '            Me.dgConsultas.DataSource = ObjDataView
    '            Me.dgConsultas.Refresh()
    '            Me.dgConsultas.AutoResizeColumns()
    '            campos()
    '            Label5.Text = dgConsultas.RowCount - 1
    '        Else
    '            MsgBox("Usuario no encontrado", MsgBoxStyle.Information, "Advertencia")

    '        End If
    '        Me.txtClaveUsuario.Enabled = False
    '        Me.txtNoContrato.Enabled = False
    '        Me.txtNombre.Enabled = False


    '    Catch ex As Exception

    '    End Try

    'End Sub
    'Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
    '    If MonthCalendar1.SelectionRange.Start.Date.ToShortDateString > Date.Today Then
    '        MsgBox("La fecha debe de ser menor a la indicada", MsgBoxStyle.Information, "Cambiar Fecha")
    '    Else
    '        Me.txtFecha_ult_pago.Text = MonthCalendar1.SelectionRange.Start.Date.ToShortDateString()
    '    End If
    'End Sub
    'Sub enviar_mail()
    '    Try
    '        mail.To.Clear()
    '        mail.Body = ""
    '        mail.Subject = ""
    '        mail.Body = Me.txtMensaje.Text
    '        mail.Subject = Me.txtAsunto.Text
    '        mail.IsBodyHtml = True
    '        mail.To.Add(Trim(Me.txtPara.Text))
    '        mail.Attachments.Add(New Attachment(lblAdjunto.Text))
    '        mail.From = New MailAddress(Me.txtDe.Text.Trim, "[Enviado por:]" & txtDe.Text)

    '        If cboMail.SelectedIndex = 1 Then
    '            direccioncompleta = txtCorreo.Text & "@gmail.com"

    '        ElseIf cboMail.SelectedIndex = 2 Then
    '            direccioncompleta = txtCorreo.Text & "@hotmail.com"

    '        End If
    '        send.Credentials = New NetworkCredential(direccioncompleta, Me.txtContraseña.Text.Trim)

    '        If cboMail.SelectedIndex = 1 Then
    '            send.Host = "smtp.gmail.com"
    '            send.Port = 587
    '            send.EnableSsl = True
    '        End If
    '        If cboMail.SelectedIndex = 2 Then
    '            send.Host = "smtp.live.com"
    '            send.Port = 587
    '            send.EnableSsl = True
    '        End If
    '        send.Send(mail)

    '        Me.Cursor = Cursors.Default
    '        Me.Text = "Enviar Mensaje"
    '        MsgBox("El mensaje fue enviado correctamente", MsgBoxStyle.Information, "Mensaje")

    '        txtAsunto.Text = String.Empty
    '        txtPara.Text = String.Empty
    '        txtMensaje.Text = String.Empty
    '        lblAdjunto.Text = String.Empty
    '        str_archivo = ""
    '        btnAdjuntar.Enabled = True
    '        btnCancelarAdjunto.Enabled = False

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Mensajeria", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub
    '------------------------------------
    '----guardar un archivo bynario----- 
    '------------------------------------
    ''  Public Shared Sub AddEmployee( _
    ''lastName As String, _
    ''firstName As String, _
    ''title As String, _
    ''hireDate As DateTime, _
    ''reportsTo As Integer, _
    ''photoFilePath As String, _
    ''connectionString As String)

    ''      Dim photo() As Byte = GetPhoto(photoFilePath)

    ''      Using connection As SqlConnection = New SqlConnection( _
    ''        connectionString)

    ''          Dim command As SqlCommand = New SqlCommand( _
    ''            "INSERT INTO Employees (LastName, FirstName, Title, " & _
    ''            "HireDate, ReportsTo, Photo) " & _
    ''            "Values(@LastName, @FirstName, @Title, " & _
    ''            "@HireDate, @ReportsTo, @Photo)", connection)

    ''          command.Parameters.Add("@LastName", _
    ''            SqlDbType.NVarChar, 20).Value = lastName
    ''          command.Parameters.Add("@FirstName", _
    ''            SqlDbType.NVarChar, 10).Value = firstName
    ''          command.Parameters.Add("@Title", _
    ''            SqlDbType.NVarChar, 30).Value = title
    ''          command.Parameters.Add("@HireDate", _
    ''            SqlDbType.DateTime).Value = hireDate
    ''          command.Parameters.Add("@ReportsTo", _
    ''            SqlDbType.Int).Value = reportsTo

    ''          command.Parameters.Add("@Photo", _
    ''            SqlDbType.Image, photo.Length).Value = photo

    ''          connection.Open()
    ''          command.ExecuteNonQuery()

    ''      End Using
    ''  End Sub

    ''  Public Shared Function GetPhoto(filePath As String) As Byte()
    ''      Dim stream As FileStream = New FileStream( _
    ''         filePath, FileMode.Open, FileAccess.Read)
    ''      Dim reader As BinaryReader = New BinaryReader(stream)

    ''      Dim photo() As Byte = reader.ReadBytes(stream.Length)

    ''      reader.Close()
    ''      stream.Close()

    ''      Return photo
    ''  End Function
    'Public Function validar_caja(ByVal dtr As VCaja)
    '    Try
    '        conectado()
    '        cmd = New SqlCommand("validar_caja")
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = cnn
    '        Dim dr As SqlDataReader
    '        dr = cmd.ExecuteReader
    '        If dr.HasRows = True Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '        If cmd.ExecuteNonQuery Then
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False
    '    Finally
    '        desconectado()
    '    End Try
    'End Function     
    '*********************************************
    ' ------herencia y parametros-----------------
    '---------------------------------------------
    'Imports System.Data.SqlClient
    'Public Class FCambiarContraseña
    '    Inherits Conexion
    '    Dim cmd As New SqlCommand
    '    Public Function Cambiar_contraseña(ByVal dt As VCambiarContraseña)
    '        Try
    '            conectado()
    '            cmd = New SqlCommand("Cambiar_Contraseña")
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.Connection = cnn

    '            cmd.Parameters.AddWithValue("@login", dt.gLogin)
    '            cmd.Parameters.AddWithValue("@password", dt.gPassword)
    '            cmd.Parameters.AddWithValue("@nuevopassword", dt.gConfirmacion)
    '            If cmd.ExecuteNonQuery Then
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)

    '            Return False
    '        Finally
    '            desconectado()

    '        End Try
    '    End Function
    'End Class
    '*************************************+++++
    'Imports System.Data.SqlClient
    'Public Class fCliente
    '    Inherits Conexion
    '    Dim cmd As New SqlCommand

    '    Public Function mostrar() As DataTable
    '        Try
    '            conectado()
    '            cmd = New SqlCommand("mostrar_cliente")
    '            cmd.CommandType = CommandType.StoredProcedure
    '            cmd.Connection = cnn

    '            If cmd.ExecuteNonQuery Then
    '                Dim dt As New DataTable
    '                Dim da As New SqlDataAdapter(cmd)
    '                da.Fill(dt)
    '                Return dt
    '            Else
    '                Return Nothing


    '            End If
    '        Catch ex As Exception
    '            MsgBox(ex.Message)
    '            Return Nothing
    '        Finally
    '            desconectado()
    '        End Try
    '    End Function
    '*****************************************
    'Private Sub cbeliminar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbeliminar.CheckedChanged
    '    If cbeliminar.CheckState = CheckState.Checked Then
    '        datalistado.Columns.Item("eliminar").Visible = True
    '    Else
    '        datalistado.Columns.Item("eliminar").Visible = False
    '    End If
    'End Sub
    '*****************************************
    'Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
    '    If dlg.ShowDialog() = DialogResult.OK Then
    '        imagen.BackgroundImage = Nothing
    '        imagen.Image = New Bitmap(dlg.FileName)
    '        imagen.SizeMode = PictureBoxSizeMode.StretchImage
    '    End If
    'End Sub
    '*****************************************
    'Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
    '    imagen.Image = Nothing
    '    imagen.BackgroundImage = My.Resources.NOIMAGEN
    '    imagen.SizeMode = PictureBoxSizeMode.StretchImage
    'End Sub
    '************************************************************************
    'Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
    '    Try
    '        If Me.ValidateChildren = True And TxtNombreProducto.Text <> "" And TxtCodProducto.Text <> "" And TxtPrecioUnitario.Text <> "" Then

    '            Dim dts As New vProducto
    '            Dim func As New fProductos

    '            'INSERTAR PRODUCTO
    '            dts.gcod_Producto = TxtCodProducto.Text
    '            dts.gNombre_Producto = TxtNombreProducto.Text
    '            dts.gcood_Proveedor = TxtCodProveedor.Text
    '            dts.gcantidad = "0"
    '            'dts.gPrecio_compra = "0"

    '            dts.gPrecio_Unitario = TxtPrecioUnitario.Text
    '            dts.gSPrecio_unitario = txtSPrecioUnitario.Text
    '            dts.gLimite = txtLimite.Text

    '            Dim ms As New IO.MemoryStream()

    '            If Not imagen.Image Is Nothing Then
    '                imagen.Image.Save(ms, imagen.Image.RawFormat)
    '            Else
    '                imagen.Image = My.Resources.NOIMAGEN
    '                imagen.Image.Save(ms, imagen.Image.RawFormat)
    '            End If
    '            dts.gimagen = ms.GetBuffer
    '            If func.insertar(dts) Then
    '                MessageBox.Show("Producto registrado correctamente", _
    '                                "Guardado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                mostrar()
    '                limpiar()
    '                bloquear()
    '                BtnGuardar.Enabled = False
    '                BtnNuevo.Enabled = True
    '            Else
    '                MessageBox.Show("Producto no registrado", _
    '                           "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                mostrar()
    '            End If
    '        Else
    '            MessageBox.Show("Falta ingresar algunos datos", "Ingrese de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    '***************************************************
    'Private Sub datalistado_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datalistadoProducto.CellClick
    '    desbloquear()
    '    TxtCodProducto.Text = datalistadoProducto.SelectedCells.Item(1).Value
    '    TxtNombreProducto.Text = datalistadoProducto.SelectedCells.Item(2).Value
    '    txtCantidad.Text = datalistadoProducto.SelectedCells.Item(3).Value
    '    TxtPrecioUnitario.Text = datalistadoProducto.SelectedCells.Item(4).Value
    '    txtSPrecioUnitario.Text = datalistadoProducto.SelectedCells.Item(5).Value
    '    TxtCodProveedor.Text = datalistadoProducto.SelectedCells.Item(6).Value
    '    txtLimite.Text = datalistadoProducto.SelectedCells.Item(8).Value
    '    txtCantidad.Enabled = True
    '    imagen.BackgroundImage = Nothing
    '    Dim b() As Byte = datalistadoProducto.SelectedCells.Item(7).Value
    '    Dim ms As New IO.MemoryStream(b)
    '    imagen.Image = Image.FromStream(ms)
    '    imagen.SizeMode = PictureBoxSizeMode.StretchImage
    '    BtnEditar.Enabled = True
    '    BtnGuardar.Enabled = False
    'End Sub
    '*******************************************************
    'Private Sub BtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEliminar.Click
    '    Dim result As DialogResult
    '    result = MessageBox.Show("Realmente desea eliminar estos productos", "Eliminar productos", _
    '                             MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
    '    If result = DialogResult.OK Then
    '        FrmBloqueo.ShowDialog()
    '        If FrmBloqueo.txtPermiso.Text = "1" Then
    '            Try
    '                For Each row As DataGridViewRow In datalistadoProducto.Rows
    '                    Dim marcado As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)
    '                    If marcado Then
    '                        'Dim onekey As Integer = Convert.ToInt32(row.Cells("Cod_producto").Value)
    '                        Dim vdb As New vProducto
    '                        Dim func As New fProductos
    '                        vdb.gcod_Producto = TxtCodProducto.Text
    '                        If func.eliminar(vdb) Then
    '                            MessageBox.Show("Producto eliminado", "Eliminacion completa", _
    '                                            MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                        End If
    '                    End If
    '                Next
    '                Call mostrar()
    '            Catch ex As Exception
    '                MsgBox(ex.Message)
    '            End Try
    '        Else
    '            MessageBox.Show("Cancelando eliminacion", "Eliminacion incompleta", _
    '                            MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Call mostrar()
    '        End If
    '    End If
    '    Call limpiar()
    'End Sub
    '***************************************************************
    'Sub Color_Textbox()
    '    Dim ctrl As Control
    '    For Each ctrl In Me.Controls
    '        If (TypeOf (ctrl) Is TextBox) Then
    '            Dim miTextBox As TextBox
    '            miTextBox = CType(ctrl, TextBox)
    '            AddHandler miTextBox.Enter, AddressOf TieneFoco
    '            AddHandler miTextBox.Leave, AddressOf PierdeFoco
    '        End If
    '    Next
    'End Sub
    'Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
    '    TextBox1.Text = String.Empty
    '    Select Case ComboBox1.SelectedIndex
    '        Case 0
    '            TipoBaseDatos = BaseDatos.SQLServer
    '            TextBox1.Text = "Data Source=localhost\TU-INSTANCIA-SQLSERVER;Initial Catalog=master;User ID=sa;Password=TU-CLAVE-DE-ACCESO;"
    '            TextBox2.Text = "SELECT * FROM Information_Schema.Tables;"
    '        Case 1
    '            TipoBaseDatos = BaseDatos.MySQL
    '            TextBox1.Text = "server=localhost;database=test;uid=root;pwd=1234;port=3306;"
    '            TextBox2.Text = "SELECT * FROM Information_Schema.Tables;"
    '        Case 2
    '            TipoBaseDatos = BaseDatos.ODBC
    '            TextBox2.Text = "INSERTE SU SENTENCIA AQUÍ."
    '        Case 3
    '            TipoBaseDatos = BaseDatos.OLEDB
    '            TextBox1.Text = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\BD\BasePrueba.mdb;User Id=Admin;Password=;"
    '            TextBox2.Text = "SELECT * FROM MSysObjects WHERE Type = 1"
    '    End Select
    'End Sub
    '********************************************************************
    'tratamientos de imagenes
    '********************************
    'Private Sub CmdAgregarP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAgregarP.Click
    '    Dim Ruta As String
    '    OFD.ShowDialog()
    '    Ruta = OFD.FileName.ToString()
    '    Me.PBImage.ImageLocation = Ruta
    '    Imagen_Bytes(Me.PBImage.Image)
    'End Sub
    'funciones para imagenes
    '''''''''''''''''''''''''''''''
    Private Function Imagen_Bytes(ByVal Imagen As Image) As Byte()
        'si hay imagen
        If Not Imagen Is Nothing Then
            'variable de datos binarios en stream(flujo
            Dim Bin As New MemoryStream
            'convertir a bytes
            Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
            'retorna binario
            Return Bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function
    'convertir binario a imagen
    Private Function Bytes_Imagen(ByVal Imagen As Byte()) As Image
        Try
            'si hay imagen
            If Not Imagen Is Nothing Then
                'caturar array con memorystream hacia Bin
                Dim Bin As New MemoryStream(Imagen)
                'con el método FroStream de Image obtenemos imagen
                Dim Resultado As Image = Image.FromStream(Bin)
                'y la retornamos
                Return Resultado
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    '**********************************************
    'storeprocedure
    '---------------------------------------------
    'Dim csb As New MySqlConnectionStringBuilder

    '    With csb
    '        .Server = "localhost"
    '        .Database = "inventario"
    '        .UserID = "root"
    '        .Password = "abc123A"
    '    End With
    '    Using con As New MySqlConnection(csb.ConnectionString)
    '        con.Open()
    'Dim cmd2 As New MySqlCommand("call id_usuario", con)
    '        With cmd2
    '            .Parameters.Add("@spusuario", Me.txtUsuario.Text).Direction = ParameterDirection.Input
    '            .Parameters.Add("@spclave", Me.txtClave.Text).Direction = ParameterDirection.Input
    '        End With
    'Dim i As Integer
    '        i = CInt(cmd2.ExecuteScalar())
    '        If i > 0 Then
    '            contador = 0
    '            MsgBox("Bienvenido", MsgBoxStyle.Information)
    '            Exit Sub
    '        Else
    '            contador = contador + 1
    '            MsgBox("Verifique su usuario y contraseña", MsgBoxStyle.Exclamation)
    '        End If
    '        If contador = 3 Then
    '            MsgBox("Ha intendado ingresar mas de tres veces", MsgBoxStyle.Critical)
    '            con.Dispose()
    '            con.Close()
    '            Application.Exit()
    '        End If
    '    End Usin
    'end sub
    '-------------------------------------------------------------------------------------------------------------
    '    Parameters.AddWithValue("@spusuario", Me.txtUsuario.Text).Direction = ParameterDirection.Input
    '.Parameters.AddWithValue("@spclave", Me.txtClave.Text).Direction = ParameterDirection.Input
    '-------------------------------------------------------------------------------------------------------------
    'Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
    '    Dim csb As New MySqlConnectionStringBuilder

    '    With csb
    '        .Server = "localhost"
    '        .Database = "inventario"
    '        .UserID = "root"
    '        .Password = "abc123A"
    '    End With
    '    Using con As New MySqlConnection(csb.ConnectionString)
    '        con.Open()
    '        Dim cmd2 As New MySqlCommand("call id_usuario('" & Me.txtUsuario.Text & "','" & txtClave.Text & "')", con)   ' Esto me hacia falta!! y no se porque no podia ingresar bien los parametros. Tratare de averiguar el porque pero asi funciona bien!!
    '        Dim i As Integer
    '        i = CInt(cmd2.ExecuteScalar())
    '        If i > 0 Then
    '            contador = 0
    '            MsgBox("Bienvenido", MsgBoxStyle.Information)
    '            Exit Sub
    '        Else
    '            contador = contador + 1
    '            MsgBox("Verifique su usuario y contraseña", MsgBoxStyle.Exclamation)
    '        End If
    '        If contador = 3 Then
    '            MsgBox("Ha intendado ingresar mas de tres veces", MsgBoxStyle.Critical)
    '            con.Dispose()
    '            con.Close()
    '            Application.Exit()
    '        End If
    '    End Using
    'End Sub
    '************************************************************
    'Public Function Codigo() As String
    '    Dim i As String = ""
    '    Dim cmd As New OdbcCommand
    '    cmd.Connection = cn
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.CommandText = "GenCodMoneda"
    '    cmd.Parameters.Add("@cod", OdbcType.Char, 4)
    '    cmd.Parameters("@cod").Direction = ParameterDirection.Output
    '    Try
    '        cn.Open()
    '        cmd.ExecuteNonQuery()
    '        cn.Close()
    '        i = cmd.Parameters("@cod").Value
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        cn.Close()
    '    End Try
    '    Return i
    'End Function
    '*************************************************************
    '    delimiter // 
    'CREATE procedure GenCodMoneda(out cod char(4))
    '    begin 
    '      SET cod = (SELECT max(idmoneda) FROM monedas) ;      
    '        SET cod = RIGHT('0000' + ltrim(RIGHT(ifnull(cod,'0000'),4)+1),4);
    '    end //
    'delimiter ;
    '****************************************************************
    '     System.Diagnostics.Process.Start("http://facebook.com/miguelvifusot")
    '        System.Diagnostics.Process.Start("http://www.youtube.com/user/MiguelVifuSoft")
    '         System.Diagnostics.Process.Start("https://twitter.com/#!/Miguel_Vifusoft")
    '        System.Diagnostics.Process.Start("http://miguel-vifusoft.atwebpages.com/")
    'BtnFacebook.Image = System.Drawing.Bitmap.FromFile("imagenes\Facebook_logo.PNG")
    'BtnTwitter.Image = System.Drawing.Bitmap.FromFile("imagenes\Twitter_logo.PNG")
    'BtnYouTube.Image = System.Drawing.Bitmap.FromFile("imagenes\Youtube_logo.jpg")
    'Private Sub FormatoDataGridView()
    '    'Formato a su gusto:
    '    With Me.DgvArticulos
    '        .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
    '        .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders
    '        .ReadOnly = True
    '        .SelectionMode = DataGridViewSelectionMode.FullRowSelect
    '        .ShowCellToolTips = False

    '        .Columns("idart").HeaderText = "Código"
    '        .Columns("idart").Visible = True
    '        .Columns("idart").Width = 70
    '        .Columns("idart").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '        .Columns("idart").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

    '        .Columns("nombre").HeaderText = "Artículo"
    '        .Columns("nombre").Visible = True
    '        .Columns("nombre").Width = 265
    '        .Columns("nombre").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '        .Columns("nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

    '        .Columns("p_pvp").HeaderText = "PVPx"
    '        .Columns("p_pvp").Visible = True
    '        .Columns("p_pvp").Width = 70
    '        .Columns("p_pvp").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '        .Columns("p_pvp").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    '        .Columns("p_blister").HeaderText = "PVPx Blister"
    '        .Columns("p_blister").Visible = True
    '        .Columns("p_blister").Width = 70
    '        .Columns("p_blister").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '        .Columns("p_blister").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    '        .Columns("p_fraccion").HeaderText = "PVPx Fracción"
    '        .Columns("p_fraccion").Visible = True
    '        .Columns("p_fraccion").Width = 70
    '        .Columns("p_fraccion").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    '        .Columns("p_fraccion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

    '        .Columns("categoria").Visible = False
    '        .Columns("imagen").Visible = False
    '    End With
    'End Sub
    '************************************
    'evento del teclado
    '------------------------------------
    'Private Sub btngrabar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btngrabar.KeyPress
    '    If e.KeyChar = Convert.ToChar(Keys.Enter) Then
    '        btnsalir.Select()
    '    End If

    'End Sub
    '--------------------------------------
    'Private Sub txtapelabo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtapelabo.KeyPress

    '    If Char.IsLetter(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsSeparator(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    '-----------------------------------------
    'Function SoloNumeros(ByVal Keyascii As Short) As Short
    '    If InStr("1234567890", Chr(Keyascii)) = 0 Then
    '        SoloNumeros = 0
    '    Else
    '        SoloNumeros = Keyascii
    '    End If
    '    Select Case Keyascii
    '        Case 8
    '            SoloNumeros = Keyascii
    '        Case 13
    '            SoloNumeros = Keyascii
    '    End Select
    'End Function



End Class
