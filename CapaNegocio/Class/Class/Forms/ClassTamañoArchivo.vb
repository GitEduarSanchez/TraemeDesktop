Public Class ClassTamañoArchivo
    Private Sub obtenerTamanoFicheros()
        'Dim tamanoFicheros As Double
        'Dim i As Integer

        ''Obtenemos el tamaño de los ficheros adjuntos seleccionados
        'For i = 0 To lsAdjuntos.Items.Count - 1
        '    tamanoFicheros = tamanoFicheros + tamanoFichero(lsAdjuntos.Items(i))
        'Next

        ''Mostrar en Kilobytes si es menor de un megabyte
        'If tamanoFicheros < 1048576 Then
        '    tamanoFicheros = tamanoFicheros / 1024
        '    lInfoAdjuntos.Text = "Tamaño de los adjuntos seleccionados: " &
        '        FormatNumber(tamanoFicheros, 2) + " KB"
        'Else
        '    tamanoFicheros = tamanoFicheros / 1024 / 1024
        '    lInfoAdjuntos.Text = "Tamaño de los adjuntos seleccionados: " &
        '        FormatNumber(tamanoFicheros, 1) + " MB"
        'End If
    End Sub
    'eliminar un item de las listas
    '*************************************
    'If lsAdjuntos.SelectedIndex <> -1 Then
    '      lsAdjuntos.Items.RemoveAt(lsAdjuntos.SelectedIndex)
    '      obtenerTamanoFicheros()
    '  End If
    'eliminar todos los item
    ' *************************
    ' lsAdjuntos.Items.Clear()
    'cargar varios adjuntos
    '***********************+
    'Dim fichero As String

    '    If dlFicheros.ShowDialog Then
    '        For i = 0 To dlFicheros.FileNames.Count - 1
    '            fichero = dlFicheros.FileNames(i).ToString
    '            If Not comprobarDuplicadoListBox(fichero, lsAdjuntos) Then
    '                lsAdjuntos.Items.Add(fichero)
    '            End If
    '        Next
    '        obtenerTamanoFicheros()
    '    End If
End Class
