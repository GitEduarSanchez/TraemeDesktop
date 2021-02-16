Imports System.Collections
Imports System.IO
Imports System
Imports System.Drawing.Printing   'permite cargar las impresoras del sistema
Imports System.Windows.Forms


Public Class ClassCorrespondencia
    Private cob As ComboBox
    Sub New(ByVal carpeta As String, ByVal archivo As String)
        ' Directory  
        If Directory.Exists("c:\windows") Then
            MsgBox("La carpeta existe", MsgBoxStyle.Information)
        Else
            MsgBox("No existe", MsgBoxStyle.Information)
        End If

        If File.Exists("c:\windows\explorer.exe") Then
            MsgBox("Existe", MsgBoxStyle.Information)
        Else
            MsgBox("No existe", MsgBoxStyle.Information)
        End If
    End Sub
    'Sub New()
    '    Try
    '-------------------------------------------------
    '---------- Configuración del FolderBrowserDialog 
    '*************************************************
    'With FolderBrowserDialog1
    '    '-------------------
    '    '----resetea--------
    '    '*******************
    '    .Reset()
    '    .Description = " Seleccionar una carpeta "
    '    '----------------------------------
    '    '----- Path " Mis documentos " ---- 
    '    '**********************************
    '    .SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    '    '----------------------------------------------------------------
    '    '-------- deshabilita el botón " crear nueva carpeta " ------- 
    '    '****************************************************************
    '    .ShowNewFolderButton = False
    '    '------------------------------------------------------------------
    '    '------.RootFolder = Environment.SpecialFolder.Desktop ------------ 
    '    '------.RootFolder = Environment.SpecialFolder.StartMenu ---------- 
    '    '******************************************************************
    '    Dim ret As DialogResult = .ShowDialog
    '    If ret = Windows.Forms.DialogResult.OK Then
    '        Dim nFiles As ObjectModel.ReadOnlyCollection(Of String)
    '        nFiles = My.Computer.FileSystem.GetFiles(.SelectedPath)
    '        MsgBox("Total de archivos: " & CStr(nFiles.Count), _
    '                                MsgBoxStyle.Information)
    '    End If
    '    .Dispose()
    'End With
    '    Catch oe As Exception
    '        MsgBox(oe.Message, MsgBoxStyle.Critical)
    '    End Try

    'End Sub
    Sub New(ByVal cob As ComboBox)
        Dim pd As New PrintDocument
        Dim Impresoras As String
        Me.cob = cob
        '------------------------------------
        '----------- Default printer---------
        '*************************************
        Dim s_Default_Printer As String = pd.PrinterSettings.PrinterName
        '-------------------------------------------------------
        '-------- recorre las impresoras instaladas----------- 
        '********************************************************
        For Each Impresoras In PrinterSettings.InstalledPrinters
            Me.cob.Items.Add(Impresoras.ToString)
        Next
        ' selecciona la impresora predeterminada  
        Me.cob.Text = s_Default_Printer
    End Sub
    Public Function getprint()
        Return Me.cob
    End Function
    'Sub New()
    '    Try
    '        ' Configuración del FolderBrowserDialog  
    '        With FolderBrowserDialog1
    '            .RootFolder = Environment.SpecialFolder.StartMenu
    '            Dim ret As DialogResult = .ShowDialog ' abre el diálogo  
    '            ' si se presionó el botón aceptar ...  
    '            If ret = Windows.Forms.DialogResult.OK Then
    '                MsgBox("Path : " & .SelectedPath, MsgBoxStyle.Information)
    '            End If
    '            .Dispose()
    '        End With
    '    Catch oe As Exception
    '        MsgBox(oe.Message, MsgBoxStyle.Critical)
    '    End Try
    'End Sub
    Sub New(ByVal f As Form)
        '---------------------------------------------------------------------------
        '-------- recorrer todos los controles del formulario indicado  ------------
        '***************************************************************************
        For Each c As Control In f.Controls
            If TypeOf c Is TextBox Then
                c.Text = String.Empty
            End If
            If TypeOf c Is ComboBox Then
                c.Text = String.Empty
            End If
            If TypeOf c Is PictureBox Then
                c.BackgroundImage = Nothing
            End If
        Next
    End Sub
End Class
