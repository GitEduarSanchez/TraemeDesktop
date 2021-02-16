Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class ClassCrud
    'Inherits ClassCnn
    Dim cnn As MySqlConnection
    Dim dt As DataTable
    Dim cmd As MySqlCommand
    Dim r As MySqlDataReader
    Dim da As MySqlDataAdapter
    Dim query As String
    Dim t As TextBox
    Sub New(ByVal t As TextBox)
        Try
            Me.t = t
            Dim cnn As MySqlConnection
            ' My.Computer.FileSystem.CurrentDirectory 'ruta de carpeta debug 
            cnn = New MySqlConnection("server=localhost;user id=root;password=;database=gestion_calificaciones")
            cnn.Open()
            query = "select email from  vista_estudiante where email = '" & Me.t.Text & "';"
            cmd = New MySqlCommand(query, cnn)
            Me.r = cmd.ExecuteReader
            If Me.r.Read Then
                Me.t.Text = Me.r(0)
            End If
            cnn.Close()
            r.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Function getaut()
        Return Me.t
    End Function

    'Public Function Insertar(ByVal fol As Integer, ByVal exp As String, ByVal clie As String, ByVal dom As String, ByVal ciu As String, ByVal rfc As String, ByVal can As Decimal, ByVal con As String, ByVal mpag As String, ByVal fech As String, ByVal ema As String) As Boolean
    '    Dim inserto As Boolean = False
    '    Try
    '        ObjCon.Conectar()
    '        ObjCon.CrearComando("INSERT INTO Factura VALUES(?fol, ?exp, ?clie, ?dom, ?ciu, ?rfc, ?can, ?con, ?mpag, ?fech, ?ema)")
    '        ObjCon.AsignarParametro("?fol", MySqlDbType.Int32, fol)
    '        ObjCon.AsignarParametro("?exp", MySqlDbType.VarChar, exp)
    '        ObjCon.AsignarParametro("?clie", MySqlDbType.VarChar, clie)
    '        ObjCon.AsignarParametro("?dom", MySqlDbType.VarChar, dom)
    '        ObjCon.AsignarParametro("?ciu", MySqlDbType.VarChar, ciu)
    '        ObjCon.AsignarParametro("?rfc", MySqlDbType.VarChar, rfc)
    '        ObjCon.AsignarParametro("?can", MySqlDbType.Decimal, can)
    '        ObjCon.AsignarParametro("?con", MySqlDbType.VarChar, con)
    '        ObjCon.AsignarParametro("?mpag", MySqlDbType.VarChar, mpag)
    '        ObjCon.AsignarParametro("?fech", MySqlDbType.DateTime, fech)
    '        ObjCon.AsignarParametro("?ema", MySqlDbType.VarChar, ema)
    '        If ObjCon.EjecutarConsulta() > 0 Then
    '            inserto = True
    '        Else
    '            inserto = False
    '        End If
    '        ObjCon.Desconectar()
    '    Catch mierror As MySqlException
    '        inserto = False
    '    End Try
    '    Return inserto
    'End Function

    ''funcion para listar los usuarios
    'Public Sub Listar(ByVal fol As TextBox, ByVal exp As ComboBox, ByVal clie As TextBox, ByVal dom As TextBox, ByVal ciu As TextBox, ByVal rfc As TextBox, ByVal can As TextBox, ByVal con As ComboBox, ByVal mpag As ComboBox, ByVal fech As DateTimePicker, ByVal ema As TextBox, ByVal usua As Label)
    '    Try
    '        ObjCon.ds = New DataSet
    '        ObjCon.Conectar()
    '        ObjCon.da = New MySqlDataAdapter("SELECT * FROM Factura", ObjCon.con)
    '        ObjCon.da.Fill(ObjCon.ds, "Factura")
    '        Cargar(fol, exp, clie, dom, ciu, rfc, can, con, mpag, fech, ema, usua)
    '        ObjCon.Desconectar()
    '    Catch mierror As MySqlException
    '        MessageBox.Show("Error de Conexión a la Base de Datos: " & mierror.Message)
    '    End Try
    'End Sub

    'Public Sub Cargar(ByVal fol As TextBox, ByVal exp As ComboBox, ByVal clie As TextBox, ByVal dom As TextBox, ByVal ciu As TextBox, ByVal rfc As TextBox, ByVal can As TextBox, ByVal con As ComboBox, ByVal mpag As ComboBox, ByVal fech As DateTimePicker, ByVal ema As TextBox, ByVal fac As Label)
    '    If ObjCon.ds.Tables("Factura").Rows.Count > 0 Then
    '        ObjCon.odatarow = ObjCon.ds.Tables("Factura").Rows(ObjCon.iposfilaactual)
    '        fol.Text = ObjCon.odatarow("Folio")
    '        exp.Text = ObjCon.odatarow("Expedidor")
    '        clie.Text = ObjCon.odatarow("Cliente")
    '        dom.Text = ObjCon.odatarow("Domicilio")
    '        ciu.Text = ObjCon.odatarow("Ciudad")
    '        rfc.Text = ObjCon.odatarow("RFC")
    '        can.Text = ObjCon.odatarow("Cantidad")
    '        con.Text = ObjCon.odatarow("Concepto")
    '        mpag.Text = ObjCon.odatarow("MetodoPago")
    '        fech.Text = ObjCon.odatarow("Fecha")
    '        ema.Text = ObjCon.odatarow("email")
    '        fac.Text = "Factura " & ObjCon.iposfilaactual + 1 & " de " & ObjCon.ds.Tables("Factura").Rows.Count
    '    Else
    '        fac.Text = "Factura " & ObjCon.iposfilaactual & " de " & ObjCon.ds.Tables("Factura").Rows.Count
    '    End If
    'End Sub

    'Public Sub Primero(ByVal fol As TextBox, ByVal exp As ComboBox, ByVal clie As TextBox, ByVal dom As TextBox, ByVal ciu As TextBox, ByVal rfc As TextBox, ByVal can As TextBox, ByVal con As ComboBox, ByVal mpag As ComboBox, ByVal fech As DateTimePicker, ByVal ema As TextBox, ByVal fac As Label)
    '    If ObjCon.ds.Tables("Factura").Rows.Count > 0 Then
    '        ObjCon.iposfilaactual = 0
    '        Cargar(fol, exp, clie, dom, ciu, rfc, can, con, mpag, fech, ema, fac)
    '    End If
    'End Sub

    'Public Sub Anterior(ByVal fol As TextBox, ByVal exp As ComboBox, ByVal clie As TextBox, ByVal dom As TextBox, ByVal ciu As TextBox, ByVal rfc As TextBox, ByVal can As TextBox, ByVal con As ComboBox, ByVal mpag As ComboBox, ByVal fech As DateTimePicker, ByVal ema As TextBox, ByVal fac As Label)
    '    If ObjCon.ds.Tables("Factura").Rows.Count > 0 Then
    '        If ObjCon.iposfilaactual <> 0 Then
    '            ObjCon.iposfilaactual -= 1
    '            Cargar(fol, exp, clie, dom, ciu, rfc, can, con, mpag, fech, ema, fac)
    '        End If
    '    End If
    'End Sub

    'Public Sub Siguiente(ByVal fol As TextBox, ByVal exp As ComboBox, ByVal clie As TextBox, ByVal dom As TextBox, ByVal ciu As TextBox, ByVal rfc As TextBox, ByVal can As TextBox, ByVal con As ComboBox, ByVal mpag As ComboBox, ByVal fech As DateTimePicker, ByVal ema As TextBox, ByVal fac As Label)
    '    If ObjCon.ds.Tables("Factura").Rows.Count > 0 Then
    '        If ObjCon.iposfilaactual <> (ObjCon.ds.Tables("Factura").Rows.Count - 1) Then
    '            ObjCon.iposfilaactual += 1
    '            Cargar(fol, exp, clie, dom, ciu, rfc, can, con, mpag, fech, ema, fac)
    '        End If
    '    End If
    'End Sub

    'Public Sub Ultimo(ByVal fol As TextBox, ByVal exp As ComboBox, ByVal clie As TextBox, ByVal dom As TextBox, ByVal ciu As TextBox, ByVal rfc As TextBox, ByVal can As TextBox, ByVal con As ComboBox, ByVal mpag As ComboBox, ByVal fech As DateTimePicker, ByVal ema As TextBox, ByVal fac As Label)
    '    If ObjCon.ds.Tables("Factura").Rows.Count > 0 Then
    '        ObjCon.iposfilaactual = (ObjCon.ds.Tables("Factura").Rows.Count - 1)
    '        Cargar(fol, exp, clie, dom, ciu, rfc, can, con, mpag, fech, ema, fac)
    '    End If
    'End Sub

    'Public Function Filtro(ByVal factu As String) As DataTable
    '    ObjCon.Conectar()
    '    ObjCon.CrearComando("SELECT * FROM Factura WHERE Folio = ?fol")
    '    ObjCon.AsignarParametro("?fol", MySqlDbType.VarChar, factu)
    '    Filtro = ObjCon.EjecutarDataTable()
    '    ObjCon.Desconectar()
    'End Function

    'Public Function CargarFolio() As Integer
    '    ObjCon.Conectar()
    '    ObjCon.CrearComando("SELECT Folio FROM Factura")
    '    ObjCon.dr = ObjCon.EjecutarReader()
    '    If ObjCon.dr.Read() Then
    '        While ObjCon.dr.Read()
    '            CargarFolio = ObjCon.dr.GetInt32(0)
    '        End While
    '    Else
    '        CargarFolio = 0
    '    End If
    '    ObjCon.dr.Close()
    '    ObjCon.Desconectar()
    '    CargarFolio += 1
    'End Function
End Class
