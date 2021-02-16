using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using CapaDato;

namespace CapaDato
{
    public class ClassCapaDatoActivacion : CapaDatos.ClassConexion
    {


        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlConnection cnn;
        MySqlParameter p;


        public bool insert_activacion(ClassCapaEntidadActivacion activacion)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_activacion_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;
                
                p = new MySqlParameter("?_fecha", MySqlDbType.Date);
                p.Value = activacion.getfecha;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idaliado", MySqlDbType.Int64);
                p.Value = activacion.getaliado;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_iddomiciliario", MySqlDbType.Int64);
                p.Value = activacion.getiddomiciliario;
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

        public bool update_activacion(ClassCapaEntidadActivacion activacion)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_activacion_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idactivacion", MySqlDbType.Int64);
                p.Value = activacion.getidactivacion;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_fecha", MySqlDbType.Date);
                p.Value = activacion.getfecha;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idaliado", MySqlDbType.Int64);
                p.Value = activacion.getaliado;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_iddomiciliario", MySqlDbType.Int64);
                p.Value = activacion.getiddomiciliario;
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

        public bool delete_activacion(ClassCapaEntidadActivacion activacion)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_activacion_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idactivacion", MySqlDbType.Int64);
                p.Value = activacion.getidactivacion;
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
                da = new MySqlDataAdapter("sp_listar_activacion", cnn);
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
