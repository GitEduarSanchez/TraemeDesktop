Imports System.Windows.Forms

Public Class ClassSoloNumeros
    Dim SoloNumero As String = ""
    Sub New(sender As TextBox, e As KeyPressEventArgs)
        Dim cadena As String = sender.Text
        'creamos un array con los datos que querramos permitir
        Dim filtro As String = "1234567890"
        'solo permite agregar el menos al principio
        If Len(cadena) = 0 Then
            filtro += "-"
        End If
        'solo deja agregar el pundo despues que haya un numero
        If Len(cadena) > 0 Then
            filtro += "."
        End If
        'validamos que la tecla presionada este en el array
        For Each Caracter In filtro
            If e.KeyChar = Caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next
        'permite la tecla retroceso
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
        'validamos que solo haya solo un punto
        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        Else
        End If
        'validamos que no coloque mas de un cero a al izquierda
        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = String.Empty
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = String.Empty
        End If
    End Sub
    Sub New(sender As TextBox, e As KeyPressEventArgs, ByVal x As String)
        Dim y As String = x
        Dim cadena As String = sender.Text
        'creamos un array con los datos que querramos permitir
        Dim filtro As String = "1234567890"
        'solo permite agregar el menos al principio
        'If Len(cadena) = 0 Then
        '    filtro += "-"
        'End If
        'solo deja agregar el pundo despues que haya un numero
        'If Len(cadena) > 0 Then
        '    filtro += "."
        'End If
        'validamos que la tecla presionada este en el array
        For Each Caracter In filtro
            If e.KeyChar = Caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next
        'permite la tecla retroceso
        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If
        ''validamos maximo 10 digitos
        'If Len(cadena) > 10 Then
        '    MsgBox("solo puedes escribir 10 digitos", MsgBoxStyle.Information, "rectifica")
        'End If
        'validamos que solo haya solo un punto
        'If e.KeyChar = "." And Not cadena.IndexOf(".") Then
        '    e.Handled = True
        'Else
        'End If
        'validamos que no coloque mas de un cero a al izquierda
        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = String.Empty
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            sender.Text = String.Empty
        End If
    End Sub
    'Sub New(sender As TextBox, e As KeyPressEventArgs, ByVal x As String)
    '    Dim y As String = x
    '    Dim cadena As String = sender.Text
    '    'creamos un array con los datos que querramos permitir
    '    Dim filtro As String = "ab"
    '    'solo permite agregar el menos al principio
    '    'If Len(cadena) = 0 Then
    '    '    filtro += "-"
    '    'End If
    '    'solo deja agregar el pundo despues que haya un numero
    '    'If Len(cadena) > 0 Then
    '    '    filtro += "."
    '    'End If
    '    'validamos que la tecla presionada este en el array
    '    For Each Caracter In filtro
    '        If e.KeyChar = Caracter Then
    '            e.Handled = False
    '            Exit For
    '        Else
    '            e.Handled = True
    '        End If
    '    Next
    '    'permite la tecla retroceso
    '    If Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    End If
    '    ''validamos maximo 10 digitos
    '    If Len(cadena) > 10 Then
    '        MsgBox("solo puedes escribir 10 digitos", MsgBoxStyle.Information, "rectifica")
    '    End If
    '    'validamos que solo haya solo un punto
    '    'If e.KeyChar = "." And Not cadena.IndexOf(".") Then
    '    '    e.Handled = True
    '    'Else
    '    'End If
    '    'validamos que no coloque mas de un cero a al izquierda
    '    If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
    '        sender.Text = String.Empty
    '    ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
    '        sender.Text = String.Empty
    '    End If
    'End Sub
    'Creamos una función publica que se encargue de extraer solo números
    Public Function SoloNumeros(ByVal strCadena As String) As Object
        Dim SoloNumero As String = ""
        Dim index As Integer
        For index = 1 To Len(strCadena)
            If (Mid$(strCadena, index, 1) Like "#") _
                Or Mid$(strCadena, index, 1) = "-" Then
                SoloNumero = SoloNumero & Mid$(strCadena, index, 1)
            End If
        Next
        Return SoloNumero
    End Function
End Class
