Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class ClassTxt
    Private lector As Stream
    Private ofp As OpenFileDialog
    Private lista As TextBox
    Sub New(ByVal ofp As OpenFileDialog, ByVal lista As TextBox)
        Me.lector = lector
        Me.ofp = ofp
        Me.lista = lista
        With Me.ofp
            .CheckFileExists = True
            .CheckPathExists = True
            .DefaultExt = "text"
            .Multiselect = False
            .FileName = String.Empty
            .Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
            .Title = "seleciona un archivo de texto"
            If .ShowDialog = DialogResult.OK Then
                Dim obj As New System.IO.StreamReader(.FileName, System.Text.Encoding.Default)
                Me.lista.Text = obj.ReadToEnd
            End If
        End With
    End Sub
    Function getlector()
        Return Me.lista.Text
    End Function
End Class
