

Public Class frm_negocio
    Inherits System.Web.UI.Page
    Dim obj_entidad_negocio As New CapaDato.Entidad.E_Negocio
    Dim obj_dato_negocio As New CapaDato.D_Negocio

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objcargarcliente As New CapaNegocio.ClassPolimorfismoSearch(Me.DropDownList1, "razon_social", "negocio", True)
        'Dim dtg As New CapaNegocio.ClassConsultarDtg(GridView1, "*", "negocio")
        'GridView1.DataSource = dtg.getdtg
    End Sub

    Sub insert()
        obj_entidad_negocio.getRazon_Social = Convert.ToString(Me.txt_razon.Text)
        obj_entidad_negocio.getNit = Convert.ToString(Me.txt_ciudad.Text)
        obj_entidad_negocio.getCiudad = Convert.ToString(Me.txt_ciudad.Text)
        If obj_dato_negocio.insert_negocio(obj_entidad_negocio) Then
            MsgBox("ok")
        Else
            MsgBox("no")
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insert()
    End Sub
End Class