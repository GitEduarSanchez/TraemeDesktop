Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data
Public Class ClassPdf
    Private ruta As TextBox
    Private lectura As TextBox
    Private msg As MsgBoxResult
    Private autor As TextBox
    Private creador As TextBox
    Private palabra As TextBox
    Private asunto As TextBox
    Private titulo As TextBox
    Private fecha As Date
    Private grid1 As DataGridView
    Private doc As Document
    Sub New(ByVal ruta As TextBox, ByVal lectura As TextBox)
        Try
        Me.ruta = ruta
            Me.lectura = lectura
            '---------------------------------------------------
            '--------Creamos el objeto documento PDF------------
            '***************************************************
        Dim documentoPDF As New Document
        PdfWriter.GetInstance(documentoPDF,
            New FileStream(Me.ruta.Text, FileMode.Create))
        documentoPDF.Open()
        '----------------------------------------------------------
        'Escribimos el texto en el objeto documento PDF
        '**************************************************
        documentoPDF.Add(New Paragraph(Me.lectura.Text,
              FontFactory.GetFont(FontFactory.TIMES, 11,
                  iTextSharp.text.Font.NORMAL)))
            documentoPDF.Close()
            Me.lectura.Text = String.Empty
        'If System.IO.File.Exists(Me.ruta.Text) Then
            Me.msg = MsgBox("Archivo Creado con exito", MsgBoxStyle.Information, "okey")
            'End If
        Catch ex As Exception
            MsgBox("Cambie el nombre del archivo por favor", MsgBoxStyle.Information, "okey")
        End Try
    End Sub
    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView.  
        Dim datatable As New PdfPTable(grid1.ColumnCount)
        'Dim font As iTextSharp.text.pdf.BaseFont
        'font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL).BaseFont



        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize()
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 50
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF.  
        Dim encabezado As New Paragraph("Reporte", New Font("Tahoma", 20, Font.BOLD))
        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Reporte Ejemplo: " + Now.Date(), New Font("Tahoma", 14, Font.BOLD))
        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To grid1.ColumnCount - 1

            datatable.AddCell(grid1.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        For i As Integer = 0 To grid1.Rows.Count - 2
            For j As Integer = 0 To grid1.Columns.Count - 1
                datatable.AddCell((grid1(j, i).Value).ToString)
            Next
            datatable.CompleteRow()
        Next
        'da 2 tab entre columnas
        datatable.AddCell("")
        datatable.AddCell("")
        'imprime resultados
        datatable.AddCell(grid1(2, 6).Value)
        datatable.AddCell(grid1(3, 6).Value)
        datatable.CompleteRow()

        'Se agrega etiquetas
        Dim texto2 As New Phrase("DEBAJO DE LA GRID 1: " + Now.Date(), New Font("Tahoma", 14, Font.BOLD))
        Dim texto3 As New Phrase("DEBAJO DE LA GRID 2: " + Now.Date(), New Font("Tahoma", 14, Font.BOLD))
        Dim texto4 As New Phrase("DEBAJO DE LA GRID 1: " + Now.Date(), New Font("Tahoma", 14, Font.BOLD))
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
        document.Add(texto2)
        document.Add(New Paragraph(" ")) 'Salto de linea
        document.Add(texto3)

        ' Intentar generar el documento.
        Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
        ' Path que guarda el reporte en el escritorio de windows (Desktop).
        Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte.pdf"
        Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
        PdfWriter.GetInstance(doc, file)
        doc.Open()
        ExportarDatosPDF(doc)
        doc.Close()
        Process.Start(filename)

    End Sub
    Public Function GetColumnasSize() As Single()
        Dim values As Single() = New Single(grid1.ColumnCount - 1) {}
        For i As Integer = 0 To grid1.ColumnCount - 1
            values(i) = CSng(grid1.Columns(i).Width)
        Next
        Return values
    End Function

    'Private Sub BtnPdf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPdf.Click
    '    Try
    '        ' Intentar generar el documento.
    '        Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
    '        ' Path que guarda el reporte en el escritorio de windows (Desktop).
    '        Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Reporte.pdf"
    '        Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
    '        PdfWriter.GetInstance(doc, file)
    '        doc.Open()
    '        ExportarDatosPDF(doc)
    '        doc.Close()
    '        Process.Start(filename)
    '    Catch ex As Exception
    '        'Si el intento es fallido, mostrar MsgBox.
    '        MessageBox.Show("No se puede generar el documento PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    '*******************************************
    'convertir PDF a Binario
    Public Function PDF_Bytes(ByVal Path As String) As Byte()
        Dim sPath As String
        sPath = Path
        Dim Ruta As New FileStream(sPath, FileMode.Open, FileAccess.Read)
        Dim Binario(CInt(Ruta.Length)) As Byte
        Ruta.Read(Binario, 0, CInt(Ruta.Length))
        Ruta.Close()
        Return Binario
    End Function
    Public Sub prc_ConvertFileToBinary()
        Dim strPath As String
        strPath = "C:\Dibujo.pdf"
        Dim ruta As New FileStream(strPath, FileMode.Open, FileAccess.Read)
        Dim binario(ruta.Length) As Byte
        ruta.Read(binario, 0, ruta.Length) 'Leo el archivo y lo convierto a binario
        ruta.Close() 'Cierro el FileStream

    End Sub


End Class
