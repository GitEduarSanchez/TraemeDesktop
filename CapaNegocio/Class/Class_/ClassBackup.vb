Imports MySql.Data.MySqlClient
Imports System.IO
Public Class ClassBackup
    Dim cnn As MySqlConnection
    Dim dt As DataTable
    Dim cmd As MySqlCommand
    Dim r As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim query As String
    Sub backup()

        'respaldar.DefaultExt = "sql"
        'Dim pathmysql As String
        'Dim comando As String
        'pathmysql = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\MYSQL AB\MYSQL SERVER 5.6", "Location", 0)
        'If pathmysql = Nothing Then
        '    MsgBox("Mysql no se encuentra en su equipo, selecciona la carpeta donde esta ubicado")
        '    carpeta.ShowDialog()
        '    pathmysql = carpeta.SelectedPath
        'End If
        'respaldar.Filter = "File MYSQL(*.sql)|*.sql"
        'If respaldar.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    Try

        '        comando = pathmysql & "\bin\mysqldump --user=root --password=root --databases sistemacobro -r  """ & respaldar.FileName & """"
        '        Shell(comando, AppWinStyle.MinimizedFocus, True)
        '    Catch ex As Exception
        '        MsgBox("Ocurrio un error al respaldar", MsgBoxStyle.Critical, "Information")
        '    End Try
        'End If            v_nombre_respaldo = "BACKUP_" & Now.Day & "_" & Now.Month & "_" & Now.Year & ".bak"
        '' ****************
        ''Dim respaldo As String = "BACKUP_" & Now.Day & "_" & Now.Month & "_" & Now.Year & ".sql"
        ''Dim cnn As MySqlConnection
        ''cnn = New MySqlConnection("server=localhost;user id=root;password=;database=gestion_calificaciones")
        ''cnn.Open()
        ''Dim v_ruta_destino As String = "D:\Backup\"
        ''Dim cmd As New MySqlCommand("BACKUP DATABASE gestion_calificaciones TO DISK = '" & v_ruta_destino & respaldo & "'", cnn)
        ''cmd.ExecuteNonQuery()
        ''cnn.Close()
        'Backup.sql
        Process.Start("C:\wamp\bin\mysql\mysql5.7.14\bin\mysqldump.exe", "--user=root --password= --host=localhost  --databases gestion_calificaciones -r " & "D:Backup\Backup_" & Now.Day & "_" & Now.Month & "_" & Now.Year & ".sql")
    End Sub
    Sub restaurar()
        'abrir.DefaultExt = "sql"
        'Dim pathmysql As String
        'Dim comando As String
        'Dim arg As String
        'abrir.Filter = "File MYSQL (*.sql)|*.sql"
        'pathmysql = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\MYSQL AB\MYSQL SERVER 5.6", "Location", 0)
        'If pathmysql = Nothing Then
        '    MsgBox("MYSQL no se encuentra en tu equipo, selecciona tu carpeta de donde esta ubicado")
        '    carpeta.ShowDialog()
        '    pathmysql = carpeta.SelectedPath
        'End If

        'If abrir.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    comando = pathmysql & "\bin\MySQL.exe"
        '    comando.Replace("\\", "\")
        '    arg = "--user=root --password=root --host=localhost --database sistemacobro  <" & Chr(34) & abrir.FileName & Chr(34)
        '    Dim proceso As New Process
        '    proceso.StartInfo.FileName = "cmd.exe"
        '    proceso.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        '    proceso.StartInfo.UseShellExecute = False
        '    proceso.StartInfo.RedirectStandardOutput = True
        '    proceso.StartInfo.RedirectStandardInput = True
        '    proceso.StartInfo.CreateNoWindow = True
        '    proceso.Start()

        '    Dim escribeconsola As StreamWriter = proceso.StandardInput
        '    Dim leer As StreamReader = proceso.StandardOutput
        '    escribeconsola.WriteLine(comando & arg)
        '    escribeconsola.Close()
        '    proceso.WaitForExit()
        '    proceso.Close()
        'End If
    End Sub
    Sub ayuda()
        'Cursor = Cursors.WaitCursor
        'Help.ShowHelp(Me, Application.StartupPath & "\Sistema de Cobranza-Guia de Usuario.chm")
        'Cursor = Cursors.Default
    End Sub

End Class
