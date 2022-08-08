using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace rentCarSTP.Backend
{
    internal class datosClientes
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=rentCarTP;Integrated Security=True");
        SqlCommand comando;

        //Agregar
        public void agregarCliente(string nombre, string cedula, string noTarjetaCR, int limiteCredito, string tipoPersona, string estado)
        {
            try
            {
                con.Open();

                string lineaComando = $"insert into clientes values ('{nombre}', '{cedula}', '{noTarjetaCR}', '{limiteCredito}', '{tipoPersona}', '{estado}');";
                comando = new SqlCommand(lineaComando, con);
                comando.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error: Datos Duplicados o Valor No Permitido, Revisar Registro");
                return;
            }
           
        }

        //Editar
        public void editarCliente(int id, string nombre, string cedula, string noTarjetaCR, int limiteCredito, string tipoPersona, string estado)
        {
            try
            {
                con.Open();

                string lineaComando = $"update clientes set nombreCliente = '{nombre}' , cedulaCliente =  '{cedula}', noTarjetaCR = '{noTarjetaCR}', tipoDePersona = '{tipoPersona}', estadoCliente = '{estado}' where idCliente = {id};";
                comando = new SqlCommand(lineaComando, con);
                comando.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Error: Datos Duplicados o Valor No Permitido, Revisar Registro");
                return;
            }
            
        }

        //Eliminar
        public void eliminarCliente(int id)
        {
            try
            {
                con.Open();

                string lineaComando = $"delete from clientes where idCliente = '{id}';";
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
        public DataTable buscarCliente(string nombre, string cedula)
        {
            con.Open();
            string lineacomando = $"select idCliente as ID, nombreCliente as Nombre, cedulaCliente as Cedula, noTarjetaCR as NoTarjetaCR, limiteDeCredito, tipoDePersona, estadoCliente as Estado from clientes where nombreCliente like '%{nombre}%' or cedulaCliente like '%{cedula}%';";
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
            string lineacomando = $"select idCliente as ID, nombreCliente as Nombre, cedulaCliente as Cedula, noTarjetaCR as NoTarjetaCR, limiteDeCredito, tipoDePersona, estadoCliente as Estado from clientes;";
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
