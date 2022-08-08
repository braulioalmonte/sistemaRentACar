using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace rentCarSTP.Backend
{
    internal class datosEmpleados
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=rentCarTP;Integrated Security=True");
        SqlCommand comando;

        //Agregar
        public void agregarEmpleado(string nombre, string cedula, string tanda, int porcientoComicion, string fechaIngresoEmpleado, string estadoEmpleado)
        {
            try
            {
                con.Open();

                string lineaComando = $"insert into empleados values('{nombre}', '{cedula}', '{tanda}', {porcientoComicion}, '{fechaIngresoEmpleado}', '{estadoEmpleado}');";

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
        public void editarEmpleado(int id, string nombre, string cedula, string tanda, int porcientoComicion, string fechaIngresoEmpleado, string estadoEmpleado)
        {
            try
            {
                con.Open();

                string lineaComando = $"update empleados set nombreEmpleado = '{nombre}', cedulaEmpleado= '{cedula}', tandaEmpleado = '{tanda}' , porcientoComisionEmpleado = {porcientoComicion}, fechaIngresoEmpleado = '{fechaIngresoEmpleado}', estadoEmpleado =  '{estadoEmpleado}' where idEmpleado = {id};";
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
        public void eliminarEmpleado(int id)
        {
            try
            {
                con.Open();

                string lineaComando = $"delete from empleados where idEmpleado = '{id}';";
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
        public DataTable buscarEmpleado(string nombre, string cedula, string tanda)
        {
            con.Open();
            string lineacomando = $"select idEmpleado as ID, nombreEmpleado as Nombre, cedulaEmpleado as Cedula, tandaEmpleado as Tanda, porcientoComisionEmpleado as 'Porciendo Comision', fechaIngresoEmpleado as Fecha, estadoEmpleado as Estado from empleados where nombreEmpleado = '{nombre}' or cedulaEmpleado = '{cedula}' or tandaEmpleado = '{tanda}';";
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
            string lineacomando = $"select idEmpleado as ID, nombreEmpleado as Nombre, cedulaEmpleado as Cedula, tandaEmpleado as Tanda, porcientoComisionEmpleado as 'Porciendo Comision', fechaIngresoEmpleado as Fecha, estadoEmpleado as Estado from empleados;";
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
