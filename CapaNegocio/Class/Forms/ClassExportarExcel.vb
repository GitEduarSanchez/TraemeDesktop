'Imports Microsoft.Office.Interop.Excel
'agregar la referencia excel objets. 12.0   
'**********************************************************
'Imports Microsoft.Office.Interop.Excel.ApplicationClass
'Imports Microsoft.Office.Interop
'Imports System.Data.OleDb
'Imports System.IO
'Imports System.Data
'Imports System.Windows.Forms


'Public Class ClassExportarExcel
'    Private libro As String
'    Private hoja As String
'    Private dtg As DataGridView
'    Dim ds As New DataSet
'    'Private Shared exp As Class_exportar_excel = Nothing
'    Sub New(ByVal ElGrid As DataGridView)
'        Dim exApp As New Microsoft.Office.Interop.Excel.Application
'        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
'        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
'        Try
'            '-----------------------------------------------------------------------
'            '-------------Añadimos el Libro al programa, y la hoja al libro  -------
'            '***********************************************************************
'            exLibro = exApp.Workbooks.Add
'            exHoja = exLibro.Worksheets.Add()
'            '------------------------------------------------------------------------
'            '----------------- ¿Cuantas columnas y cuantas filas?--------------------
'            '*************************************************************************
'            Dim NCol As Integer = ElGrid.ColumnCount
'            Dim NRow As Integer = ElGrid.RowCount
'            '------------------------------------------------------------------------------------
'            '-------------Aqui recorremos todas las filas, y por cada fila todas las columnas ---
'            '*************************************************************************************
'            '-------------y vamos escribiendo.  -------------------------------------------------
'            '------------------------------------------------------------------------------------
'            For i As Integer = 1 To NCol
'                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
'            Next
'            For Fila As Integer = 0 To NRow - 1
'                For Col As Integer = 0 To NCol - 1
'                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Item(Col, Fila).Value
'                Next
'            Next
'            '---------------------------------------------------------------------------------
'            '-------------Titulo en negrita, Alineado al centro y que el tamaño de la columna
'            '-------------se ajuste al texto    ----------------------------------------------
'            '*********************************************************************************
'            exHoja.Rows.Item(1).Font.Bold = 1
'            exHoja.Rows.Item(1).HorizontalAlignment = 3
'            exHoja.Columns.AutoFit()
'            'Aplicación visible
'            '**********************
'            exApp.Application.Visible = True
'            exHoja = Nothing
'            exLibro = Nothing
'            exApp = Nothing
'        Catch ex As Exception
'            MessageBox.Show(ex.Message, "error al exportar a excel", MessageBoxButtons.OK, MessageBoxIcon.Information)

'        End Try
'    End Sub
'End Class
