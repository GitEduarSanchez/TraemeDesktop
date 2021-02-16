'Imports Microsoft.Office.Interop.Excel
'agregar la referencia excel objets. 12.0   
'**********************************************************
Imports Microsoft.Office.Interop.Excel.ApplicationClass
Imports Microsoft.Office.Interop
Imports System.Data.OleDb
Imports System.IO

Public Class Class_exportar_excel
    Private libro As String
    Private hoja As String
    Private dtg As DataGridView
    Dim ds As New DataSet
    'Private Shared exp As Class_exportar_excel = Nothing
    Sub New(ByVal ElGrid As DataGridView)
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            '-----------------------------------------------------------------------
            '-------------Añadimos el Libro al programa, y la hoja al libro  -------
            '***********************************************************************
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            '------------------------------------------------------------------------
            '----------------- ¿Cuantas columnas y cuantas filas?--------------------
            '*************************************************************************
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount
            '------------------------------------------------------------------------------------
            '-------------Aqui recorremos todas las filas, y por cada fila todas las columnas ---
            '*************************************************************************************
            '-------------y vamos escribiendo.  -------------------------------------------------
            '------------------------------------------------------------------------------------
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Item(Col, Fila).Value
                Next
            Next
            '---------------------------------------------------------------------------------
            '-------------Titulo en negrita, Alineado al centro y que el tamaño de la columna
            '-------------se ajuste al texto    ----------------------------------------------
            '*********************************************************************************
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'Aplicación visible
            '**********************
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

        End Try

    End Sub
    'Public Function instanciar() As Class_exportar_excel
    '    If IsNothing(exp) Then
    '        exp = New Class_exportar_excel

    '    End If
    '    Return exp
    'End Function
    Public Sub ExportarDatosExcel(ByVal DataGridView1 As DataGridView, ByVal titulo As String)

        'Dim m_Excel As New Excel.Application
        'm_Excel.Cursor = Excel.XlMousePointer.xlWait
        'm_Excel.Visible = True
        'Dim objLibroExcel As Excel.Workbook = m_Excel.Workbooks.Add
        'Dim objHojaExcel As Excel.Worksheet = objLibroExcel.Worksheets(1)
        'With objHojaExcel
        '    .Visible = Excel.XlSheetVisibility.xlSheetVisible
        '    .Activate()
        '    'Encabezado
        '    .Range("A1").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '    .Range("A1:L1").Merge()
        '    .Range("A1:L1").Value = "Actualizar Precios"
        '    .Range("A1:L1").Font.Bold = True
        '    .Range("A1:L1").Font.Size = 16
        '    'Texto despues del encabezado
        '    .Range("A2:L2").Merge()
        '    .Range("A2:L2").Value = titulo
        '    .Range("A2:L2").Font.Bold = True
        '    .Range("A2:L2").Font.Size = 10
        '    'Espacio
        '    .Range("A3:L3").Merge()
        '    .Range("A3:L3").Value = ""
        '    .Range("A3:L3").Font.Bold = True
        '    .Range("A3:L3").Font.Size = 10
        '    'Estilos a titulos de la Tabla
        '    .Range("A4:P4").Font.Bold = True
        '    'Establecer tipo de Letra al Rango Determinado
        '    .Range("A1:P100").Font.Name = "Tahoma"
        '    'Los datos se registran a partir de la Columna A, Fila 4
        '    Const PrimeraLetra As Char = "A"
        '    Const PrimerNumero As Short = 4
        '    Dim letra As Char
        '    Dim UltimaLetra As Char
        '    Dim Numero As Integer
        '    Dim UltimoNumero As Integer
        '    Dim cod_letra As Byte = Asc(PrimeraLetra) - 1
        '    Dim sepDec As String = Application.CurrentCulture.NumberFormat.CurrencyDecimalSeparator
        '    Dim sepFil As String = Application.CurrentCulture.NumberFormat.CurrencyDecimalSeparator
        '    Dim strColumna As String = ""
        '    Dim LetraIzq As String = ""
        '    Dim cod_LetraIzq As Byte = Asc(PrimeraLetra) - 1
        '    letra = PrimeraLetra
        '    Numero = PrimerNumero
        '    Dim objCelda As Excel.Range
        '    For Each c As DataGridViewColumn In dtvListado_Productos.Columns
        '        If c.Visible Then
        '            If letra = "Z" Then
        '                letra = PrimeraLetra
        '                cod_letra = Asc(PrimeraLetra)
        '                cod_LetraIzq += 1
        '                LetraIzq = Chr(cod_LetraIzq)
        '            Else
        '                cod_letra += 1
        '                letra = Chr(cod_letra)
        '            End If
        '            strColumna = LetraIzq + letra + Numero.ToString
        '            objCelda = .Range(strColumna, Type.Missing)
        '            objCelda.Value = c.HeaderText
        '            objCelda.EntireColumn.Font.Size = 10
        '            'Establece un formato a los numeros por default
        '            'objcelda.entirecolumn.numberformat = c.defaultCellStyle.Format
        '            If c.ValueType Is GetType(Decimal) OrElse c.ValueType Is GetType(Double) Then
        '                objCelda.EntireColumn.NumberFormat = "#" + sepFil + "0" + sepDec + "00"
        '            End If
        '        End If
        '    Next
        '    Dim objRangoEncab As Excel.Range = .Range(PrimeraLetra + Numero.ToString, LetraIzq + letra + Numero.ToString)
        '    objRangoEncab.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        '    UltimaLetra = letra
        '    Dim UltimaLetraIzq As String = LetraIzq
        '    'Cargar Datos del DataGridView
        '    Dim i As Integer = Numero + 1
        '    For Each reg As DataGridViewRow In DataGridView1.Rows
        '        LetraIzq = ""
        '        cod_LetraIzq = Asc(PrimeraLetra) - 1
        '        letra = PrimeraLetra
        '        cod_letra = Asc(PrimeraLetra) - 1
        '        For Each c As DataGridViewColumn In DataGridView1.Columns
        '            If c.Visible Then
        '                If letra = "Z" Then
        '                    letra = PrimeraLetra
        '                    cod_letra = Asc(PrimeraLetra)
        '                    cod_LetraIzq += 1
        '                    LetraIzq = Asc(cod_LetraIzq)
        '                Else
        '                    cod_letra += 1
        '                    letra = Chr(cod_letra)
        '                End If
        '                strColumna = LetraIzq + letra
        '                'Aqui se realiza la carga de datos
        '                .Cells(i, strColumna) = IIf(IsDBNull(reg.ToString), "", reg.Cells(c.Index).Value)
        '            End If
        '        Next
        '        Dim objRangoReg As Excel.Range = .Range(PrimeraLetra + i.ToString, strColumna + i.ToString)
        '        objRangoReg.Rows.BorderAround()
        '        objRangoReg.Select()
        '        i += 1
        '    Next
        '    UltimoNumero = i
        '    LetraIzq = ""
        '    cod_LetraIzq = Asc("A")
        '    cod_letra = Asc(PrimeraLetra)
        '    letra = PrimeraLetra
        '    For Each c As DataGridViewColumn In DataGridView1.Columns
        '        If c.Visible Then
        '            objCelda = .Range(LetraIzq + letra + PrimerNumero.ToString, LetraIzq + letra + (UltimoNumero - 1).ToString)
        '            objCelda.BorderAround()
        '            If letra = "Z" Then
        '                letra = PrimeraLetra
        '                cod_letra = Asc(PrimeraLetra)
        '                LetraIzq = Chr(cod_LetraIzq)
        '                cod_LetraIzq += 1
        '            Else
        '                cod_letra += 1
        '                letra = Chr(cod_letra)
        '            End If
        '        End If
        '    Next
        '    ' Dibujar el border exterior grueso de la tabla 
        '    Dim objRango As Excel.Range = .Range(PrimeraLetra + PrimerNumero.ToString, UltimaLetraIzq + UltimaLetra + (UltimoNumero - 1).ToString)
        '    objRango.Select()
        '    objRango.Columns.AutoFit()
        '    objRango.Columns.BorderAround(1, Excel.XlBorderWeight.xlMedium)
        'End With
        'm_Excel.Cursor = Excel.XlMousePointer.xlDefault
    End Sub
    'Dim rowsTotal, colsTotal As Short
    'Dim I, j, iC As Short
    '    System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
    'Dim xlApp As New Excel.Application
    '    Try
    'Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
    'Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
    '        xlApp.Visible = True

    '        rowsTotal = dgw.RowCount
    '        colsTotal = dgw.Columns.Count - 1
    '        With excelWorksheet
    '            .Cells.Select()
    '            .Cells.Delete()
    '            For iC = 0 To colsTotal
    '                .Cells(1, iC + 1).Value = dgw.Columns(iC).HeaderText
    '            Next
    '            For I = 0 To rowsTotal - 1
    '                For j = 0 To colsTotal
    '                    .Cells(I + 2, j + 1).value = dgw.Rows(I).Cells(j).Value
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
    ''RELEASE ALLOACTED RESOURCES
    '        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    '        xlApp = Nothing
    '    End Try
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Dim excelApp As New Excel.Application()
    '    Dim excelBook As Excel.Workbook = excelApp.Workbooks.Add
    '    Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
    '    excelApp.Visible = True

    '    With excelWorksheet
    '        .Name = "RELACION DE CONTACTOS EN AGENDA"
    '        .Tab.ColorIndex = 24

    '        Dim fechaconsulta As Date
    '        fechaconsulta = Today

    '        Dim I, FILAS As Integer
    '        Dim J As Integer
    '        Dim FECHAINICIAL As Date
    '        FECHAINICIAL = Today.Date
    '        FILAS = D_TABLE.Rows.Count
    '        J = 0
    '        J = J + 3
    '        'COLOCAMOS LOS TITULOS
    '        .Range("A" & J.ToString).Value = "REPORTE DE SELECCION DE AGENDA"
    '        .Range("A" & J.ToString).Font.Bold = True
    '        .Range("A" & J.ToString).Font.Size = "13"
    '        J = J + 2
    '        .Range("A" & J.ToString).Value = "FECHA DE CONSULTA"
    '        .Range("A" & J.ToString).Font.Bold = True
    '        .Range("A" & J.ToString).Font.Size = "10"
    '        .Range("B" & J.ToString).Value = fechaconsulta
    '        .Range("B" & J.ToString).NumberFormat = "dd-mmm-aa"
    '        .Range("B" & J.ToString).Font.Size = "10"
    '        .Range("B" & J.ToString).Font.Bold = True
    '        J = J + 2
    '        .Range("A" & J.ToString).Value = "                   NOMBRE"
    '        .Range("A" & J.ToString).Font.Bold = True
    '        .Range("A" & J.ToString).ColumnWidth = 30
    '        .Range("B" & J.ToString).Value = "            GUIA"
    '        .Range("B" & J.ToString).Font.Bold = True
    '        .Range("B" & J.ToString).ColumnWidth = 15
    '        .Range("C" & J.ToString).Value = "     TEL. CELULAR"
    '        .Range("C" & J.ToString).Font.Bold = True
    '        .Range("C" & J.ToString).ColumnWidth = 15
    '        .Range("D" & J.ToString).Value = "TEL. PARTICULAR"
    '        .Range("D" & J.ToString).Font.Bold = True
    '        .Range("D" & J.ToString).ColumnWidth = 15
    '        .Range("E" & J.ToString).Value = "     TEL. OFICINA"
    '        .Range("E" & J.ToString).Font.Bold = True
    '        .Range("E" & J.ToString).ColumnWidth = 15
    '        .Range("F" & J.ToString).Value = "            DOMICILIO"
    '        .Range("F" & J.ToString).Font.Bold = True
    '        .Range("F" & J.ToString).ColumnWidth = 20
    '        .Range("G" & J.ToString).Value = "                  E-MAIL"
    '        .Range("G" & J.ToString).Font.Bold = True
    '        .Range("G" & J.ToString).ColumnWidth = 25
    '        .Range("H" & J.ToString).Value = "UBICACION DE IMAGEN"
    '        .Range("H" & J.ToString).Font.Bold = True
    '        J = J + 1
    '        For I = 0 To FILAS - 1
    '            .Range("A" & J.ToString).Value = Grid.Item(I, 0).ToString
    '            .Range("B" & J.ToString).Value = Grid.Item(I, 1).ToString
    '            .Range("C" & J.ToString).Value = Grid.Item(I, 2).ToString
    '            .Range("D" & J.ToString).Value = Grid.Item(I, 3).ToString
    '            .Range("E" & J.ToString).Value = Grid.Item(I, 4).ToString
    '            .Range("F" & J.ToString).Value = Grid.Item(I, 5).ToString
    '            .Range("G" & J.ToString).Value = Grid.Item(I, 6).ToString
    '            .Range("H" & J.ToString).Value = Grid.Item(I, 7).ToString
    '            J = J + 1
    '        Next
    '    End With
    'End Sub
    Sub leer_excel()
        '    Friend ExcelGlobal_definst As New Microsoft.Office.Interop.Excel.Global

        'Private Sub Form_Load()
        '    OpenFileDialog1.ShowDialog()
        '    'Creado Por IRWIN MORALES Ingeniero en Computación
        '    'Hay que referenciar la libreria de excel que esta en COM
        '    'Variable de tipo Aplicación de Excel
        '    Dim objExcel As Microsoft.Office.Interop.Excel.Application
        '    'Una variable de tipo Libro de Excel
        '    Dim xLibro As Microsoft.Office.Interop.Excel.Workbook
        '    'Una variable de tipo Hoja de Excel
        '    Dim xHoja As Microsoft.Office.Interop.Excel.Worksheet
        '    'Una variable Col para las columnas y Fila para las filas
        '    Dim Col As Integer
        '    Dim Fila As Integer

        '    'creamos un nuevo objeto excel
        '    objExcel = New Microsoft.Office.Interop.Excel.Application

        '    'Usamos el método open para abrir el archivo que está en el directorio del programa llamado archivo.xls
        '    'xLibro = objExcel.Workbooks.Open(My.Application.Info.DirectoryPath & "\archivo.xlsx")
        '    'xLibro = objExcel.Workbooks.Open("c:\...\archivo.xlsx")
        '    'Ó podemos ponerlo con el diálogo de abrir un archivo como hice en este caso
        '    xLibro = objExcel.Workbooks.Open(OpenFileDialog1.FileName.ToString)
        '    'Se debe tomar el nombre de la hoja que se desea leer
        '    xHoja = objExcel.Worksheets("Hoja1")

        '    'Se puede hacer el Excel Visible con:
        '    'objExcel.Visible = True

        '    '    Hacemos referencia al libro
        '    With xLibro

        '        '    Hacemos referencia a la Hoja
        '        With xHoja

        '            'Recorremos la fila 1 hasta la 5
        '            For Fila = 1 To 5
        '                'Recorremos la columna 1 hasta la 5
        '                For Col = 1 To 5
        '                    'Agregamos el valor de la fila que corresponde al valor de la columna a nuestro combo box
        '                    ComboBox1.Items.Add(.Cells(Fila, Col).Value)
        '                Next
        '            Next
        '        End With
        '    End With
        '    MsgBox("Archivo leido, revisa los datos en el combo box")
        '    'Se cierra el libro de excel
        '    xLibro.Close(SaveChanges:=False)
        '    objExcel.Quit()

        '    'Eliminamos los objetos si ya no los usamos
        '    objExcel = Nothing
        '    xLibro = Nothing
        '    xHoja = Nothing

        'End Sub
    End Sub
    Sub New(ByVal libro As String, ByVal hoja As String, ByVal dtg As DataGridView)
        Me.libro = libro
        Me.hoja = hoja
        Me.dtg = dtg
        Dim cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                           "Data Source=" & Me.libro & ";" & _
                           "Extended Properties=""Excel 8.0;HDR=YES"""
        Try
            '-------------------------------------------------------------
            '-------------------- cadena de conexión---------------------
            '*************************************************************
            Dim cn As New OleDbConnection(cs)

            'If Not System.IO.File.Exists(Me.libro) Then
            '    MsgBox("No se encontró el Libro: " & _
            '            Me.libro, MsgBoxStyle.Critical, _
            '            "Ruta inválida")
            '    Exit Sub
            'End If
            '------------------------------------------------------------
            '------------- se conecta con la hoja  ---------------------
            '**************************************************************
            Dim da As New OleDbDataAdapter("Select * From [" & Me.hoja & "$]", cn)
            da.Fill(ds)
            With Me.dtg
                .DataSource = ds.Tables(0)
                '---------------------------------------------------------
                '--------- DefaultCellStyle: formato currency  ----------- 
                '---------para los encabezados 1,2 y 3 del DataGrid ------
                '**********************************************************
                '.Columns(1).DefaultCellStyle.Format = "c"
                '.Columns(2).DefaultCellStyle.Format = "c"
                '.Columns(3).DefaultCellStyle.Format = "c"
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Function getexcel()
        Return ds
    End Function
End Class
