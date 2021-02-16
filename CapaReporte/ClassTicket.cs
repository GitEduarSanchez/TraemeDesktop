using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibPrintTicket;
using System.Data;
using System.Windows.Forms;

namespace CapaReporte
{
  public  class ClassTicket
    {
        public bool imprimir()
        {

            try
            {
                
                DataTable dt = new DataTable();
                Ticket ticket = new Ticket();
               // ticket.HeaderImage = picturebox.image;//Por ejemplo
                ticket.AddHeaderLine("Vallesar sas");
                ticket.AddHeaderLine("Centro de trabajo:");
                ticket.AddHeaderLine("Macondo");
                ticket.AddHeaderLine("Cucuta , Norte de santander");
                ticket.AddHeaderLine("Direccion");

                ticket.AddSubHeaderLine("Ticket # 1");
                ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

                ticket.AddItem("1", "producto", "1200");
                //foreach (var item in collection)
                //{
                //    ticket.AddItem("1", "producto", "1200");
                //}
                //foreach (p in dt)
                //{

                //    ticket.AddItem(p.Cant, p.Name, p.Price);

                //}
                ticket.AddTotal("SUBTOTAL", "12.00");
                ticket.AddTotal("IVA", "0");
                ticket.AddTotal("TOTAL", "24");
                ticket.AddTotal("", "");
                ticket.AddTotal("RECIBIDO", "0");
                ticket.AddTotal("CAMBIO", "0");
                ticket.AddTotal("", "");

                ticket.AddFooterLine("Gracias por tu compra");

                //ticket.PrintTicket("EPSON TM-T88III Receipt"); //Nombre de la impresora de tickets
                //ticket.PrintTicket("THERMAL Receipt Printer");
                ticket.PrintTicket("THERMAL Receipt Printer");
                
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
