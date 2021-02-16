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
    public class ClassCapaDatoTurno : CapaDatos.ClassConexion
    {

        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlConnection cnn;
        MySqlParameter p;

        public bool insert_turno(ClassCapaEntidadTurno turno)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_turno_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_fecha", MySqlDbType.Date);
                p.Value = turno.getfecha;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_iddomiciliario", MySqlDbType.Int64);
                p.Value = turno.getiddomiciliario;
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

        public bool update_turno(ClassCapaEntidadTurno turno)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_turno_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idturno", MySqlDbType.Int64);
                p.Value = turno.getidturno;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_fecha", MySqlDbType.Date);
                p.Value = turno.getfecha;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_iddomiciliario", MySqlDbType.Int64);
                p.Value = turno.getiddomiciliario;
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

        public bool delete_turno(ClassCapaEntidadTurno turno)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_turno_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idturno", MySqlDbType.Int64);
                p.Value = turno.getidturno;
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
                da = new MySqlDataAdapter("sp_listar_turno", cnn);
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
