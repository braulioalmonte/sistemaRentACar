using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace rentCarSTP.Backend
{
    internal class datosRentaDevolucion
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=rentCarTP;Integrated Security=True");
        SqlCommand comando;

        //Agregar
        public void agregarRentaDevolucion(string fechaRenta, string fechaDevolucion, int montoPorDia, int cantidadDias, string empleado, string vehiculo, string cliente, string comentario, string estado)
        {
            try
            {
                con.Open();

                string lineaComando = $"insert into rentaDevolucion values('{fechaRenta}', '{fechaDevolucion}', {montoPorDia}, {cantidadDias}, (select idEmpleado from empleados where nombreEmpleado = '{empleado}'), (select idVehiculo from vehiculos where descripcionVehiculo = '{vehiculo}'), (select idCliente from clientes where nombreCliente  = '{cliente}'), '{comentario}', '{estado}');";
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
        public void editarRentaDevolucion(int id, string fechaRenta, string fechaDevolucion, int montoPorDia, int cantidadDias, string empleado, string vehiculo, string cliente, string comentario, string estado)
        {
            try
            {
                con.Open();

                string lineaComando = $"update rentaDevolucion set fechaRenta ='{fechaRenta}', fechaDevolucion ='{fechaDevolucion}', montoPorDia = {montoPorDia}, cantidadDeDias = {cantidadDias}, empleadoRD = (select idEmpleado from empleados where nombreEmpleado = '{empleado}'), vehiculoRD = (select idVehiculo from vehiculos where descripcionVehiculo = '{vehiculo}'), clienteRD = (select idCliente from clientes where nombreCliente  = '{cliente}'),  comentario = '{comentario}', estado = '{estado}' where noREnta = {id};";
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
        public void eliminarRentaDevolucion(int id)
        {
            try
            {
                con.Open();

                string lineaComando = $"delete from rentaDevolucion where noREnta = {id};";
                comando = new SqlCommand(lineaComando, con);
                comando.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error", ex.Message);
                throw;
            }

        }

        //Buscar
        public DataTable buscarRentaDevolucion(string empleado, string vehiculo, string cliente)
        {
            con.Open();
            string lineacomando = $"Select e.noREnta as 'No. Renta', e.fechaRenta as 'Fecha Renta', e.fechaDevolucion 'Fecha Devolucion', e.montoPorDia as 'Monto X Día', e.cantidadDeDias as 'Cantidad de días', S.nombreEmpleado as Empleado, a.descripcionVehiculo as Vehiculo, b.nombreCliente as Cliente, e.comentario as Comentario, e.estado as Estado From rentaDevolucion e JOIN empleados s on e.empleadoRD = idEmpleado JOIN vehiculos a on e.vehiculoRD = idVehiculo JOIN clientes b on e.clienteRD = idCliente and (nombreEmpleado = '{empleado}' or descripcionVehiculo  = '{vehiculo}' or nombreCliente =  '{cliente}');";
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
            string lineacomando = $"Select e.noREnta as 'No. Renta', e.fechaRenta as 'Fecha Renta', e.fechaDevolucion 'Fecha Devolucion', e.montoPorDia as 'Monto X Día', e.cantidadDeDias as 'Cantidad de días', S.nombreEmpleado as Empleado, a.descripcionVehiculo as Vehiculo, b.nombreCliente as Cliente, e.comentario as Comentario, e.estado as Estado From rentaDevolucion e JOIN empleados s on e.empleadoRD = idEmpleado JOIN vehiculos a on e.vehiculoRD = idVehiculo JOIN clientes b on e.clienteRD = idCliente;";
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
