Imports System.Windows.Forms
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class ClassBacuk
    'C:\Users\vallesar\Desktop\Backup
    'C:\wamp64\bin\mysql\mysql5.7.19\bin

    Public Sub backup()
        Process.Start("C:\wamp64\bin\mysql\mysql5.7.19\bin\mysqldump", "--user=root --password= --host=localhost   prueba -r " & "C:\Users\vallesar\Desktop\Backup\Backup_" & Now.Day & "_" & Now.Month & "_" & Now.Year & ".sql")
    End Sub
    Public Sub restaurar()
        Process.Start("C:\wamp64\bin\mysql\mysql5.7.19\bin\mysql", "--user=root --password= --host=localhost   prueba_ -r " & "C:\Users\vallesar\Desktop\Backup\Backup_20_3_2018.sql")
    End Sub

End Class
