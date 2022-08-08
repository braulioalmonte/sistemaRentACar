using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace rentCarSTP.Backend
{
    internal class datosTiposDeVehiculos
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=rentCarTP;Integrated Security=True");
        SqlCommand comando;

        //Agregar
        public void agregarTipoDeVehiculo(string descripcion, string estado)
        {
            
            try
            {

                con.Open();
                string lineaComando = $"insert into tiposDeVehiculos values('{descripcion}', '{estado}');";
                comando = new SqlCommand(lineaComando, con);
                comando.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Datos Duplicados, Revise el registro");
                return;
            }
            
        }

        //Editar
        public void editarTipoDeVehiculo(int id, string descripcion, string estado)
        {
            try
            {
                con.Open();

                string lineaComando = $"update tiposDeVehiculos set descripcionTipoDeVehiculos = '{descripcion}', estadoTipoDeVehiculos = '{estado}' where idTipoVehiculo = '{id}';";
                comando = new SqlCommand(lineaComando, con);
                comando.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Datos Duplicados, Revise el registro");
                return;
            }
           
        }

        //Eliminar
        public void eliminarTipoVehiculo(int id)
        {
            try
            {
                con.Open();

                string lineaComando = $"delete from tiposDeVehiculos where idTipoVehiculo = '{id}';";
                comando = new SqlCommand(lineaComando, con);
                comando.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("No puede borrar este dato porque está presente en otra tabla");
                return;
            }
            
        }

        //Buscar
        public DataTable buscarTipoVehiculo(string descripcion)
        {
            con.Open();
            string lineacomando = $"select idTipoVehiculo as ID, descripcionTipoDeVehiculos as Descripción, estadoTipoDeVehiculos as Estado from tiposDeVehiculos where descripcionTipoDeVehiculos like '%{descripcion}%';";
            comando = new SqlCommand(lineacomando, con);
            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;
        }

        public DataTable fillGrid()
        {
            con.Close();
            con.Open();
            string lineacomando = $"select idTipoVehiculo as ID, descripcionTipoDeVehiculos as Descripción, estadoTipoDeVehiculos as Estado from tiposDeVehiculos;";
            comando = new SqlCommand(lineacomando, con);
            comando.ExecuteNonQuery();

            SqlDataAdapter data = new SqlDataAdapter(comando);

            DataTable table = new DataTable();

            data.Fill(table);

            con.Close();

            return table;
        }

    }
}
