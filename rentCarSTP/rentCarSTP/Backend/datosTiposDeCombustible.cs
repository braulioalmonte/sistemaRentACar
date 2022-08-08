using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace rentCarSTP.Backend
{
    internal class datosTiposDeCombustible
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=rentCarTP;Integrated Security=True");
        SqlCommand comando;

        //Agregar
        public void agregarTipoDeCombustible(string descripcion, string estado)
        {
            try
            {
                con.Open();

                string lineaComando = $"insert into tiposDeCombustible values('{descripcion}', '{estado}');";
                comando = new SqlCommand(lineaComando, con);
                comando.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Datos Duplicados, Revisar Registro");
                return;
            }
            
        }

        //Editar
        public void editarTipoDeCombustible(int id, string descripcion, string estado)
        {
            try
            {
                con.Open();

                string lineaComando = $"update tiposDeCombustible set descripcionTipoDeCombustible = '{descripcion}', estadoTipoDeCombustible = '{estado}' where idTipoDeCombustible = '{id}';";
                comando = new SqlCommand(lineaComando, con);
                comando.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Datos Duplicados, Revisar Registro");
                return;
            }
            
        }

        //Eliminar
        public void eliminarTipoCombustible(int id)
        {
            try
            {
                con.Open();

                string lineaComando = $"delete from tiposDeCombustible where idTipoDeCombustible = '{id}';";
                comando = new SqlCommand(lineaComando, con);
                comando.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No puede borrar este dato porque está presente en otra tabla");
                return;
            }
            
        }

        //Buscar
        public DataTable buscarTipoCombustible(string descripcion)
        {
            con.Open();
            string lineacomando = $"select idTipoDeCombustible as ID, descripcionTipoDeCombustible as Descripción, estadoTipoDeCombustible as Estado from tiposDeCombustible where descripcionTipoDeCombustible like '%{descripcion}%';";
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
            string lineacomando = $"select idTipoDeCombustible as ID, descripcionTipoDeCombustible as Descripción, estadoTipoDeCombustible as Estado from tiposDeCombustible;";
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
