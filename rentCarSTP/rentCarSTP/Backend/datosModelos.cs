using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace rentCarSTP.Backend
{
    internal class datosModelos
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=rentCarTP;Integrated Security=True");
        SqlCommand comando;

        //Agregar
        public void agregarModelo(string marca, string descripcion, string estado)
        {
            try
            {
                con.Open();

                string lineaComando = $"insert into modelos values((SELECT idMarca from marcas WHERE descripcionMarca='{marca}'), '{descripcion}', '{estado}');";
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
        public void editarModelo(int id, string marca, string descripcion, string estado)
        {
            try
            {
                con.Open();

                string lineaComando = $"update modelos set marcaModelo = (SELECT idMarca from marcas WHERE descripcionMarca='{marca}'), descripcionModelo = '{descripcion}', estadoModelo = '{estado}' where idModelo = {id};";
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
        public void eliminarModelo(int id)
        {
            try
            {
                con.Open();

                string lineaComando = $"delete from modelos where idModelo = {id};";
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
        public DataTable buscarModelo(string descripcionModelo, string descripcionMarca)
        {
            con.Open();
            string lineacomando = $"Select e.idModelo as ID, e.descripcionModelo as Modelo, S.descripcionMarca as Marca, e.estadoModelo as Estado From modelos e JOIN marcas s on e.marcaModelo = idMarca and (descripcionModelo like '%{descripcionModelo}%' or descripcionMarca like '%{descripcionMarca}%');";
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
            string lineacomando = $"Select e.idModelo as ID, e.descripcionModelo as Modelo, S.descripcionMarca as Marca, e.estadoModelo as Estado From modelos e JOIN marcas s on e.marcaModelo = idMarca;";
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
