Public Class ClassNumLetra
    '#Region "funciones para el metodo mas simple"


    '    '*******************************************
    '    ' Convierte un número  del 1 al 9 en texto. *
    '    '*******************************************
    '    Dim Pointer1 As Integer = 0
    '    Dim Pointer2 As Integer = 0
    '    Function GetDigit(ByVal Digit)
    '        Select Case Val(Digit)
    '            Case 1 : GetDigit = "Un"
    '            Case 2 : GetDigit = "Dos"
    '            Case 3 : GetDigit = "Tres"
    '            Case 4 : GetDigit = "Cuatro"
    '            Case 5 : GetDigit = "Cinco"
    '            Case 6 : GetDigit = "Seis"
    '            Case 7 : GetDigit = "Siete"
    '            Case 8 : GetDigit = "Ocho"
    '            Case 9 : GetDigit = "Nueve"
    '            Case Else : GetDigit = ""
    '        End Select
    '    End Function

    '    '*********************************************
    '    ' Convierte números de 10 a 99 a texto. *
    '    '*********************************************
    '    Function GetTens(ByVal TensText)
    '        Dim Result As String

    '        Result = ""           'anula el valor temporal de la funcion
    '        If Val(Microsoft.VisualBasic.Left(TensText, 1)) = 1 Then   ' si el valor esta entre 10-19
    '            Select Case Val(TensText)
    '                Case 10 : Result = "Diez"
    '                Case 11 : Result = "Once"
    '                Case 12 : Result = "Doce"
    '                Case 13 : Result = "Trece"
    '                Case 14 : Result = "Catorce"
    '                Case 15 : Result = "Quince"
    '                Case 16 : Result = "Dieciseis"
    '                Case 17 : Result = "Diecisiete"
    '                Case 18 : Result = "Dieciocho"
    '                Case 19 : Result = "Diecinueve"
    '                Case Else
    '            End Select
    '        Else    ' Si el valor esta entre 20-99
    '            Select Case Val(Microsoft.VisualBasic.Left(TensText, 1))
    '                Case 2 : Result = "Veinte "
    '                Case 3 : Result = "Treinta "
    '                Case 4 : Result = "Cuarenta "
    '                Case 5 : Result = "Cincuenta "
    '                Case 6 : Result = "Sesenta "
    '                Case 7 : Result = "Setenta "
    '                Case 8 : Result = "Ochenta "
    '                Case 9 : Result = "Noventa "
    '                Case Else
    '            End Select
    '            Result = Result & GetDigit _
    '       (Microsoft.VisualBasic.Right(TensText, 1))  'Retrae el lugar
    '        End If
    '        GetTens = Result
    '    End Function
    '    '*******************************************
    '    ' Convierte los números de 100-999 a texto *
    '    '*******************************************
    '    Function GetHundreds(ByVal MyNumber)
    '        Dim Result As String
    '        Dim Quinien As String
    '        Dim Quinien2 As String

    '        If Val(MyNumber) = 0 Then Exit Function
    '        MyNumber = Microsoft.VisualBasic.Right("000" & MyNumber, 3)

    '        'Converte el lugar de las centenas
    '        Quinien2 = " Cientos "
    '        If Mid(MyNumber, 1, 1) <> "0" Then
    '            Quinien = GetDigit(Mid(MyNumber, 1, 1))
    '            If Quinien = "Cinco" Then
    '                Quinien = "Quinientos "
    '                Quinien2 = ""
    '            End If
    '            If Quinien = "Uno" Then
    '                Quinien = ""
    '                Quinien2 = "Ciento "
    '            End If
    '            If Quinien = "Nueve" Then
    '                Quinien = "Nove"
    '                Quinien2 = "cientos "
    '            End If
    '            If Quinien = "Siete" Then
    '                Quinien = "Sete"
    '                Quinien2 = "cientos "
    '            End If
    '            Result = Quinien & Quinien2 ' aca le agrega al numero la palabra
    '        End If

    '        'Convierte el lugar de los miles
    '        If Mid(MyNumber, 2, 1) <> "0" Then
    '            Quinien = GetTens(Mid(MyNumber, 2))
    '            If Pointer1 = 0 Then
    '                Pointer1 = 1
    '                Quinien = Replace(Quinien, " ", " y ")
    '            End If

    '            Result = Result & Quinien
    '        Else
    '            Quinien = GetDigit(Mid(MyNumber, 3))
    '            Result = Result & Quinien
    '        End If

    '        GetHundreds = Result
    '    End Function
    '    '****************
    '    ' Function Principal *
    '    '****************
    '    Function SpellNumber(ByVal MyNumber)
    '        Dim OtroNumero As String = MyNumber
    '        Dim Dolares, Centavos, Temp As String
    '        Dim DecimalPlace, Count

    '        Dim Place(9) As String
    '        Place(2) = " Mil "
    '        Place(3) = " Millones "
    '        Place(4) = " Billones "
    '        Place(5) = " Trillones "

    '        ' String representa la cantidad
    '        MyNumber = Trim(Str(MyNumber))

    '        ' el lugar de la posicion decimal ) si ninguno
    '        DecimalPlace = InStr(MyNumber, ".")

    '        'Convierte Centavos and set MyNumber a la cantidad en dolares
    '        If DecimalPlace > 0 Then
    '            OtroNumero = Microsoft.VisualBasic.Left(MyNumber, DecimalPlace - 1)
    '            Centavos = GetTens(Microsoft.VisualBasic.Left(Mid(MyNumber, DecimalPlace + 1) & "00", 2))
    '            MyNumber = Trim(Microsoft.VisualBasic.Left(MyNumber, DecimalPlace - 1))
    '        Else
    '            OtroNumero = MyNumber
    '        End If

    '        Dim enta, hacer As String
    '        Dim BuscaEspacio As Integer
    '        enta = CStr(MyNumber)
    '        hacer = ""
    '        If enta.Length = 2 And (Microsoft.VisualBasic.Right(enta, 1) = "0") Then
    '            hacer = "cero"
    '        End If

    '        Count = 1
    '        Do While MyNumber <> ""
    '            Temp = GetHundreds(Microsoft.VisualBasic.Right(MyNumber, 3))
    '            If Temp <> "" Then Dolares = Temp & Place(Count) & Dolares
    '            If Len(MyNumber) > 3 Then
    '                If Len(OtroNumero) = 4 And Microsoft.VisualBasic.Left(OtroNumero, 1) = "1" Then
    '                    Pointer2 = 1
    '                End If
    '                MyNumber = Microsoft.VisualBasic.Left(MyNumber, Len(MyNumber) - 3)
    '            Else
    '                MyNumber = ""
    '            End If
    '            Count = Count + 1
    '        Loop

    '        If Pointer2 = 1 Then
    '            Dolares = Microsoft.VisualBasic.Right(Dolares, Len(Dolares) - 3)
    '        End If

    '        If hacer = "cero" Then
    '            BuscaEspacio = InStr(Dolares, " ")
    '            Dolares = Microsoft.VisualBasic.Left(Dolares, BuscaEspacio - 1)
    '        End If


    '        Select Case Dolares
    '            Case ""
    '                Dolares = "Ningún Dólar"
    '            Case "One"
    '                Dolares = "Un Dólar"
    '                MsgBox("sopas")
    '            Case Else
    '                Dolares = Dolares & " Dólares"
    '        End Select


    '        Centavos = Replace(Centavos, " ", " y ")
    '        Select Case Centavos
    '            Case ""
    '                Centavos = " y Ningún Centavo"
    '            Case Else
    '                Centavos = " con " & Centavos & " Centavos"
    '        End Select

    '        SpellNumber = Dolares & Centavos
    '    End Function
    '#End Region
    Public Function Num2Text(ByVal value As Double) As String
        Select Case value
            Case 0 : Num2Text = "CERO"
            Case 1 : Num2Text = "UN"
            Case 2 : Num2Text = "DOS"
            Case 3 : Num2Text = "TRES"
            Case 4 : Num2Text = "CUATRO"
            Case 5 : Num2Text = "CINCO"
            Case 6 : Num2Text = "SEIS"
            Case 7 : Num2Text = "SIETE"
            Case 8 : Num2Text = "OCHO"
            Case 9 : Num2Text = "NUEVE"
            Case 10 : Num2Text = "DIEZ"
            Case 11 : Num2Text = "ONCE"
            Case 12 : Num2Text = "DOCE"
            Case 13 : Num2Text = "TRECE"
            Case 14 : Num2Text = "CATORCE"
            Case 15 : Num2Text = "QUINCE"
            Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
            Case 20 : Num2Text = "VEINTE"
            Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
            Case 30 : Num2Text = "TREINTA"
            Case 40 : Num2Text = "CUARENTA"
            Case 50 : Num2Text = "CINCUENTA"
            Case 60 : Num2Text = "SESENTA"
            Case 70 : Num2Text = "SETENTA"
            Case 80 : Num2Text = "OCHENTA"
            Case 90 : Num2Text = "NOVENTA"
            Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
            Case 100 : Num2Text = "CIEN"
            Case Is < 200 : Num2Text = "CIENTO" & Num2Text(value - 100)
            Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
            Case 500 : Num2Text = "QUINIENTOS"
            Case 700 : Num2Text = "SETECIENTOS"
            Case 900 : Num2Text = "NOVECIENTOS"
            Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
            Case 1000 : Num2Text = "MIL"
            Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
            Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
            Case 1000000 : Num2Text = "UN MILLON"
            Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
            Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES "
                If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : Num2Text = "UN BILLON"
            Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select

    End Function
End Class
