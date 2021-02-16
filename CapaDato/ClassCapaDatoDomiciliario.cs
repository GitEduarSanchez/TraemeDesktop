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
    public class ClassCapaDatoDomiciliario : CapaDatos.ClassConexion
    {

        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlConnection cnn;
        MySqlParameter p;

        public bool insert_domiciliario(ClassCapaEntidadDomiciliario domiciliario)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_domiciliario_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_nombre", MySqlDbType.VarChar);
                p.Value = domiciliario.getnombre;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_apellido", MySqlDbType.VarChar);
                p.Value = domiciliario.getapellido;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_documento", MySqlDbType.VarChar);
                p.Value = domiciliario.getdocumento;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_foto", MySqlDbType.VarChar);
                p.Value = domiciliario.getfoto;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idstado", MySqlDbType.Int64);
                p.Value = domiciliario.getidstado;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_fecha_cambio", MySqlDbType.Date);
                p.Value = domiciliario.getfechacambio;
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

        public bool update_domiciliario(ClassCapaEntidadDomiciliario domiciliario)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_domiciliario_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_iddomiciliario", MySqlDbType.Int64);
                p.Value = domiciliario.getiddomiciliario ;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_nombre", MySqlDbType.VarChar);
                p.Value = domiciliario.getnombre;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_apellido", MySqlDbType.VarChar);
                p.Value = domiciliario.getapellido;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_documento", MySqlDbType.VarChar);
                p.Value = domiciliario.getdocumento;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_foto", MySqlDbType.VarChar);
                p.Value = domiciliario.getfoto;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idstado", MySqlDbType.Int64);
                p.Value = domiciliario.getidstado;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_fecha_cambio", MySqlDbType.Date);
                p.Value = domiciliario.getfechacambio;
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

        public bool delete_domiciliario(ClassCapaEntidadDomiciliario domiciliario)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_domiciliario_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_iddomiciliario", MySqlDbType.Int64);
                p.Value = domiciliario.getiddomiciliario;
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
                da = new MySqlDataAdapter("sp_listar_domiciliario", cnn);
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
