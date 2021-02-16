Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports System
Imports System.IO
Imports System.Threading
Imports System.Management
Imports System.Text.RegularExpressions
Public Class ClassSql
    Dim conexion As MySqlConnection = New MySqlConnection("server=127.0.0.1; database=ejemplo; uid=root; pwd=;")
    Sub agregar_datagrid()
        Dim agregar As MySqlCommand = New MySqlCommand("INSERT INTO datos VALUES(?clave, ?nombre, ?apellido)", conexion)
        conexion.Open()
        Dim fila As DataGridViewRow = New DataGridViewRow()
        Try
            'For Each fila In DataGridView1.Rows
            '    agregar.Parameters.Clear()
            '    agregar.Parameters.Add("?clave", MySqlDbType.Int16).Value = Convert.ToString(fila.Cells("Column1").Value)
            '    agregar.Parameters.Add("?nombre", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column2").Value)
            '    agregar.Parameters.Add("?apellido", MySqlDbType.VarChar).Value = Convert.ToString(fila.Cells("Column3").Value)
            '    agregar.ExecuteNonQuery()
            'Next
        Catch ex As Exception
            MessageBox.Show("Datos agregados")
        End Try
    End Sub

    'SMS Functions
    'Public Function ModemsConnected() As String
    '    Dim modems As String = ""
    '    Try
    '        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_POTSModem")

    '        For Each queryObject As ManagementObject In searcher.Get()
    '            If queryObject("Status") = "OK" Then
    '                modems = modems & (queryObject("AttachedTo") & " - " & queryObject("Description") & "***")
    '            End If
    '        Next
    '    Catch ex As Exception
    '        MsgBox("An error occured while querying for WMI data: ", MsgBoxStyle.Critical, "Error")
    '        Return ""
    '    End Try
    '    Return modems
    'End Function
End Class

