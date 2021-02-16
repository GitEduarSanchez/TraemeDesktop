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
    public class ClassCapaDatoVehiculo : CapaDatos.ClassConexion
    {


        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlConnection cnn;
        MySqlParameter p;

        public bool insert_vehiculo(ClassCapaEntidadVehiculo vehiculo)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_vehiculo_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_placa", MySqlDbType.VarChar);
                p.Value = vehiculo.getplaca;
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

        public bool update_vehiculo(ClassCapaEntidadVehiculo vehiculo)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_vehiculo_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idvehiculo", MySqlDbType.Int64);
                p.Value = vehiculo.getidvehiculo;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_placa", MySqlDbType.VarChar);
                p.Value = vehiculo.getplaca;
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

        public bool delete_vehiculo(ClassCapaEntidadVehiculo vehiculo)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_vehiculo_del", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idvehiculo", MySqlDbType.Int64);
                p.Value = vehiculo.getidvehiculo;
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
                da = new MySqlDataAdapter("sp_listar_vehiculo", cnn);
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
