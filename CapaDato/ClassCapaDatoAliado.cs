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
    public class ClassCapaDatoAliado : CapaDatos.ClassConexion
    {
        


        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlConnection cnn;
        MySqlParameter p;


        public bool insert_aliado(ClassCapaEntidadAliado aliado)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_aliado_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_nombre", MySqlDbType.VarChar);
                p.Value = aliado.getnombre;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_telefono", MySqlDbType.VarChar);
                p.Value = aliado.gettelefono;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_direccion", MySqlDbType.VarChar);
                p.Value = aliado.gettelefono;
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

        public bool update_aliado(ClassCapaEntidadAliado aliado)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_aliado_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idaliado", MySqlDbType.Int64);
                p.Value = aliado.getidaliado;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_nombre", MySqlDbType.VarChar);
                p.Value = aliado.getnombre;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_telefono", MySqlDbType.VarChar);
                p.Value = aliado.gettelefono;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_direccion", MySqlDbType.VarChar);
                p.Value = aliado.gettelefono;
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

        public bool delete_aliado(ClassCapaEntidadAliado aliado)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_aliado_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idaliado", MySqlDbType.Int64);
                p.Value = aliado.getidaliado;
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
                da = new MySqlDataAdapter("sp_listar_aliado", cnn);
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
