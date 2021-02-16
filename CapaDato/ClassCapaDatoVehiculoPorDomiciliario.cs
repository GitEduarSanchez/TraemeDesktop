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
    public class ClassCapaDatoVehiculoPorDomiciliario : CapaDatos.ClassConexion
    {

        DataTable dt;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        MySqlConnection cnn;
        MySqlParameter p;


        public bool insert_vehiculo_por_domiciliario(ClassCapaEntidadVehiculoPorDomiciliario vehiculoD)
        {
            try
            {
                cnn = conectar();
                cmd = new MySqlCommand("sp_vehiculo_por_domiciliario_in", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idvehiculo", MySqlDbType.Int64);
                p.Value = vehiculoD.getidvehiculo;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_iddomiciliario", MySqlDbType.Int64);
                p.Value = vehiculoD.getidvehiculo;
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

        public bool update_vehiculo_por_domiciliario(ClassCapaEntidadVehiculoPorDomiciliario vehiculoD)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_vehiculo_por_domiciliario_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idvehiculo_por_domiciliari", MySqlDbType.Int64);
                p.Value = vehiculoD.getidvehiculo;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_idvehiculo", MySqlDbType.Int64);
                p.Value = vehiculoD.getidvehiculo;
                p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p);

                p = new MySqlParameter("?_iddomiciliario", MySqlDbType.Int64);
                p.Value = vehiculoD.getidvehiculo;
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


        public bool delete_vehiculo_por_domiciliario(ClassCapaEntidadVehiculoPorDomiciliario vehiculoD)
        {
            try
            {

                cnn = conectar();
                cmd = new MySqlCommand("sp_vehiculo_por_domiciliario_up", cnn);
                cmd.CommandType = CommandType.StoredProcedure;

                p = new MySqlParameter("?_idvehiculo_por_domiciliari", MySqlDbType.Int64);
                p.Value = vehiculoD.getidvehiculo;
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
                da = new MySqlDataAdapter("sp_listar_vehiculo_domiciliario", cnn);
                dt = new DataTable();
                da.Fill(dt);
                return this.dt;
            }
            catch (Exception ex)
            {
                return this.dt;
                throw;
            }
        }
    }
}
