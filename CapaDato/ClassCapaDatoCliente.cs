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
    public class ClassCapaDatoCliente : CapaDatos.ClassConexion
    {



        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlConnection cnn;
        MySqlParameter p;


        public bool insert_cliente(ClassCapaEntidadCliente cliente)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_cliente_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_nombre", MySqlDbType.VarChar);
                p.Value = cliente.getnombre;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_barrio", MySqlDbType.VarChar);
                p.Value = cliente.getbarrio;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_telefono", MySqlDbType.VarChar);
                p.Value = cliente.gettelefono;
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

        public bool update_cliente(ClassCapaEntidadCliente cliente)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_cliente_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idcliente", MySqlDbType.Int64);
                p.Value = cliente.getidcliente;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_nombre", MySqlDbType.VarChar);
                p.Value = cliente.getnombre;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_barrio", MySqlDbType.VarChar);
                p.Value = cliente.getbarrio;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_telefono", MySqlDbType.VarChar);
                p.Value = cliente.gettelefono;
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

        public bool delete_cliente(ClassCapaEntidadCliente cliente)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_cliente_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idcliente", MySqlDbType.Int64);
                p.Value = cliente.getidcliente;
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
                da = new MySqlDataAdapter("sp_listar_cliente", cnn);
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
