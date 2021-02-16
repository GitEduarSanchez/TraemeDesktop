using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CapaDato;
using System.Data;
using System.Windows.Forms;


namespace CapaDato
{
    public class ClassCapaDatoDomicilio: CapaDatos.ClassConexion
    {

        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlConnection cnn;
        MySqlParameter p;

        public bool insert_domicilio(ClassCapaEntidadDomicilio domicilio)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_domicilio_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_fecha", MySqlDbType.Date);
                p.Value = domicilio.getfecha;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idcliente", MySqlDbType.Int64);
                p.Value = domicilio.getidcliente;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_iddomiciliario", MySqlDbType.Int64);
                p.Value = domicilio.getiddomiciliario;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_nota", MySqlDbType.VarChar);
                p.Value = domicilio.getnota;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_tarifa", MySqlDbType.Double);
                p.Value = domicilio.gettarifa;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                dr = cmd.ExecuteReader();
                dr.Close();
                cnn.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }

        public bool update_domicilio(ClassCapaEntidadDomicilio domicilio)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_domicilio_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_iddomicilio", MySqlDbType.Int64);
                p.Value = domicilio.getiddomicilio;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_fecha", MySqlDbType.Date);
                p.Value = domicilio.getfecha;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idcliente", MySqlDbType.Int64);
                p.Value = domicilio.getidcliente;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_iddomiciliario", MySqlDbType.Int64);
                p.Value = domicilio.getiddomiciliario;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_nota", MySqlDbType.VarChar);
                p.Value = domicilio.getnota;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_tarifa", MySqlDbType.Double);
                p.Value = domicilio.gettarifa;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                dr = cmd.ExecuteReader();
                dr.Close();
                cnn.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }

        public bool delete_domicilio(ClassCapaEntidadDomicilio domicilio)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_domicilio_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_iddomicilio", MySqlDbType.Int64);
                p.Value = domicilio.getiddomicilio;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                dr = cmd.ExecuteReader();
                dr.Close();
                cnn.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }


        public DataTable Listar()
        {
            try
            {
                cnn = conectar();
                da = new MySqlDataAdapter("sp_listar_domicilio", cnn);
                dt = new DataTable();
                da.Fill(dt);
                return this.dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return this.dt;
                throw;
            }
        }

    }
}
