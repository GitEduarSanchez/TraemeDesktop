Public Class ClassIP
    Function EsIP(ByVal Wip As String) As Boolean
        'Las variables comenzaran por "W" para diferenciarlas de cualquiera en el programa principal 
        Dim wcont, wPtos As Byte      '--- Para contar los puntos, deben ser 3 y hacer el ciclo

        '-----< Se verifica no contenga letras (mejor validar la entrada en el TextBox del Form) >-----

        '------ Se verifica tenga el tamaño de una IP correcta
        If Len(Wip) < 7 Or Len(Wip) > 15 Then
            EsIP = False '--- No tiene el tamaño apropiado para una IP
        Else
            '----- Se verifica tenga los "4 pares" correctos (que contenga 3 puntos)
            wPtos = Len(Wip) - Len(Replace(Wip, ".", "")) '--- para "contar" los puntos
            If wPtos = 3 Then
                '----- Se verifica que cada par esté entre [0..255]
                Dim wNewIP() As String = Split(Wip, ".")  '--- Arreglo donde se guardan los pares
                For i = 0 To wPtos
                    If (wNewIP(i) > -1) And (wNewIP(i) < 256) Then
                        wcont = wcont + 1
                    End If
                Next
                If wcont = 4 Then
                    EsIP = True  '--- Los pares estan correctos
                Else
                    EsIP = False '--- Alguno de los pares está errado
                End If
            Else
                EsIP = False     '--- No hay la cantidad de puntos (3) para una direccion IP
            End If
        End If
        '----- Se devuelve resultado de la funcion
        Return EsIP
    End Function
End Class

