using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace rentCarSTP.Backend
{
    internal class datosMarcas
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=rentCarTP;Integrated Security=True");
        SqlCommand comando;

        //Agregar
        public void agregarMarca(string descripcion, string estado)
        {
            try
            {
                con.Open();

                string lineaComando = $"insert into marcas values('{descripcion}', '{estado}');";
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
        public void editarMarca(int id, string descripcion, string estado)
        {
            try
            {
                con.Open();

                string lineaComando = $"update marcas set descripcionMarca = '{descripcion}', estadoMarca = '{estado}' where idMarca = '{id}';";
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
        public void eliminarMarca(int id)
        {
            try
            {
                con.Open();

                string lineaComando = $"delete from marcas where idMarca = '{id}';";
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
        public DataTable buscarMarca(string descripcion)
        {
            con.Open();
            string lineacomando = $"select idMarca as ID, descripcionMarca as Descripción, estadoMarca as Estado from marcas where descripcionMarca like '%{descripcion}%';";
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
            string lineacomando = $"select idMarca as ID, descripcionMarca as Descripción, estadoMarca as Estado from marcas;";
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
