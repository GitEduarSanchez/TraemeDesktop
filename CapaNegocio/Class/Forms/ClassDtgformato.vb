Imports System.Windows.Forms
Imports System.Data
Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class ClassDtgformato
    'Dim e As DataGridViewCellFormattingEventArgs
    Sub New(ByVal dtg As DataGridView, ByVal columna As String, ByVal condicion As String, ByVal e As DataGridViewCellFormattingEventArgs)
        Try
            With dtg
                Dim colum As String
                '----------------------------------------------------------------------------
                '-----------------Indica de cual columna deseo dar formato de celda---------
                '****************************************************************************
                If .Columns(e.ColumnIndex).Name.Equals(columna) Then
                    '---------------Captura el valor de la celda-------- 
                    '****************************************************
                    colum = (.Rows(e.RowIndex).Cells(e.ColumnIndex).Value)
                    '--------------Verificar si es estado es Activo entonces asignare forecolor verder de lo contrario sera rojo.
                    '------------------------------------------------------------------------------------------------------------
                    If colum = condicion Then
                        e.CellStyle.BackColor = Color.Aquamarine
                    Else
                        e.CellStyle.BackColor = Color.White
                    End If
                End If
            End With
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "error al dar formato",
             MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Sub New(ByVal dtg As DataGridView, ByVal columna As String)
        Try
            With dtg
                .Columns(columna).DefaultCellStyle.Format = "##,##0.00"
            End With
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "error al dar formato",
             MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
