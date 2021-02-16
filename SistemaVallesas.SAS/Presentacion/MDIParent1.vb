Imports System.Windows.Forms
Imports CapaNegocio
'Imports Conectar_a_un_Puerto_COM
'Imports System.Data.SQLite
Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        'cerrar()
        'frm_emp_bascula.MdiParent = Me

    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        'Dim OpenFileDialog As New OpenFileDialog
        'OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        'OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        'If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
        '    Dim FileName As String = OpenFileDialog.FileName
        '    ' TODO: agregue código aquí para abrir el archivo.
        'End If
        'cerrar()
        'frm_anticipo.MdiParent = Me
        'frm_anticipo.Show()
        'Dim f As New Conectar_a_un_Puerto_COM.Form1
        'f.Show()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.

    End Sub
    Sub cerrar()
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub
    Private m_ChildFormNumber As Integer

    Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'For i As Integer = 0 To 6
        '    MainMenuStrip.Items(i).Enabled = False
        'Next
        'MainMenuStrip.Items(3).Enabled = True
        'MainMenuStrip.Items(6).Enabled = True
        cerrar()
        'frm_despacho.MdiParent = Me
        'frm_despacho.Show()
        'If tipousuario = 1 Then
        '    'Me.FileMenu.Enabled = True
        '    'MessageBox.Show("admin")
        'Else
        '    'Me.FileMenu.Enabled = False
        'End If
        'cerrar()
        'frm_panel.MdiParent = Me
        'frm_panel.Show()

    End Sub
    Private Sub AgregarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'cerrar()
        'frm_cargo.MdiParent = Me  frm_cargo.Show()

    End Sub

    Private Sub EditMenu_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'cerrar()
        'frm_ingreso_datos.MdiParent = Me
        'frm_ingreso_datos.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs)
        'frm_consulta_nomina.ShowDialog()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cerrar()
       
    End Sub

    Private Sub AltaDeProductoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cerrar()
       
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cerrar()
       
    End Sub

    Private Sub BackupToolStripMenuItem_Click(sender As Object, e As EventArgs)
        backup()
    End Sub
    Public Sub backup()
        Process.Start("C:\wamp64\bin\mysql\mysql5.7.19\bin\mysqldump", "--user=vallesar --password=1091658551edwar20 --host=192.168.0.115   mina_ -r " & ":Backup\Backup_" & Now.Day & "_" & Now.Month & "_" & Now.Year & ".sql")
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'cerrar()
       
    End Sub

    Private Sub ToolsMenu_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim f As New CapaDatos.frm_config
        f.ShowDialog()
    End Sub
    Private Sub BackupToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Dim backup As New CapaNegocio.ClassBacuk()
        backup.backup()

    End Sub

    Private Sub BackupToolStripMenuItem_Click_2(sender As Object, e As EventArgs)
        Dim b As New CapaNegocio.ClassBacuk
        b.backup()
    End Sub

    Private Sub RestaurarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim b As New CapaNegocio.ClassBacuk
        b.restaurar()
    End Sub

    Private Sub AlimentacionToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    

    

    Private Sub FileMenu_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub InformePorDestinoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cerrar()

    End Sub

    Private Sub VehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    

   
    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cerrar()
        frm_productos.MdiParent = Me
        frm_productos.Show()

    End Sub

    Private Sub POSToolStripMenuItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub AgregarToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        cerrar()
        frm_cliente.MdiParent = Me
        frm_cliente.Show()

    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cerrar()
        'frm_informe_de_ventas.MdiParent = Me
        'frm_informe_de_ventas.Show()

    End Sub

    Private Sub InformesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CiudadesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cerrar()
        'frm_informe_ciudades.MdiParent = Me
        'frm_informe_ciudades.Show()

    End Sub

    Private Sub EDTToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cerrar()
        'frm_despacho.MdiParent = Me
        'frm_despacho.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        'Dim iva As New frm_informe_iva
        'Dim rpt As New informe_iva
        'iva.CrystalReportViewer1.ReportSource = rpt
        'iva.WindowState = FormWindowState.Maximized
        'iva.MdiParent = Me
        'iva.Show()

    End Sub

    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cerrar()

    End Sub

    Private Sub GestionarToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cerrar()

    End Sub

    Private Sub ListadoDeLicenciasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        cerrar()

    End Sub

    Private Sub AliadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AliadosToolStripMenuItem.Click
        cerrar()
        frm_aliados.MdiParent = Me
        frm_aliados.WindowState = FormWindowState.Maximized
        frm_aliados.Show()
    End Sub

    Private Sub VehiculoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehiculoToolStripMenuItem.Click
        cerrar()
        frm_vehiculo.MdiParent = Me
        frm_vehiculo.Show()
    End Sub
End Class
