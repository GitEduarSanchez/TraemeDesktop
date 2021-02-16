Imports LibPrintTicket
Imports System.Windows.Forms
Public Class ClassImpresion
    Public Sub imprimirTicket()
        Dim ticket As New Ticket
        ticket.AddHeaderLine("Vallesar sas")
        ticket.AddHeaderLine("Centro de trabajo:")
        ticket.AddHeaderLine("Macondo")
        ticket.AddHeaderLine("Cucuta , Norte de santander")
        ticket.AddHeaderLine("Direccion")
        ticket.AddSubHeaderLine("Ticket # 1")
        ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString())

            ticket.AddItem("1", "producto", "1200")
            ticket.AddTotal("SUBTOTAL", "12.00")
            ticket.AddTotal("IVA", "0")
            ticket.AddTotal("TOTAL", "24")
            ticket.AddTotal("", "")
            ticket.AddTotal("RECIBIDO", "0")
            ticket.AddTotal("CAMBIO", "0")
            ticket.AddTotal("", "")
            ticket.AddFooterLine("Gracias por tu compra")
            ticket.PrintTicket("THERMAL Receipt Printer")

    End Sub
End Class
