using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace rentCarSTP.Backend
{
    internal class datosInspeccion
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=rentCarTP;Integrated Security=True");
        SqlCommand comando;

        //Agregar
        public void agregarInspeccion(string tieneRayaduras, string cantidadCombustible, string tieneGomaRepuesta, string tieneGato, string tieneRayadurasCristal, string estadoGomas, string ETC, string fechaInspeccion, string vehiculo, string cliente, string empleado, string estado)
        {
            con.Open();

            string lineaComando = $"insert into inspeccion values ('{tieneRayaduras}', '{cantidadCombustible}', '{tieneGomaRepuesta}', '{tieneGato}', '{tieneRayadurasCristal}', '{estadoGomas}', '{ETC}', '{fechaInspeccion}', (select idVehiculo from vehiculos where descripcionVehiculo = '{vehiculo}'), (select idCliente from clientes where nombreCliente  = '{cliente}'),(select idEmpleado from empleados where nombreEmpleado = '{empleado}'), '{estado}');";
            comando = new SqlCommand(lineaComando, con);
            comando.ExecuteNonQuery();

            con.Close();
        }

        //Editar
        public void editarInspeccion(int id, string tieneRayaduras, string cantidadCombustible, string tieneGomaRepuesta, string tieneGato, string tieneRayadurasCristal, string estadoGomas, string ETC, string fechaInspeccion, string vehiculo, string cliente, string empleado, string estado)
        {
            con.Open();

            string lineaComando = $"update inspeccion set tieneRayaduras = '{tieneRayaduras}' , cantidadCombustible = '{cantidadCombustible}' , tieneGomaRepuesta = '{tieneGomaRepuesta}' , tieneGato = '{tieneGato}',  tieneReturasCristal = '{tieneRayadurasCristal}' , estadoGomas = '{estadoGomas}', etcInspeccion = '{ETC}' , fechaInspeccion = '{fechaInspeccion}', vehiculoInspeccion = (select idVehiculo from vehiculos where descripcionVehiculo = '{vehiculo}'), clienteInspeccion = (select idCliente from clientes where nombreCliente  = '{cliente}'), empleadoInspeccion = (select idEmpleado from empleados where nombreEmpleado = '{empleado}'), estadoInspeccion = '{estado}' where idTransaccion = {id};";
            comando = new SqlCommand(lineaComando, con);
            comando.ExecuteNonQuery();

            con.Close();
        }

        //Eliminar
        public void eliminarInspeccion(int id)
        {
            try
            {
                con.Open();

                string lineaComando = $"delete from inspeccion where idTransaccion = {id};";
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
        public DataTable buscarInspeccion(string vehiculo, string cliente, string empleado)
        {
            con.Open();
            string lineacomando = $"Select e.idTransaccion as ID, s.descripcionVehiculo as Vehiculo , a.nombreCliente as Cliente, a.cedulaCliente as Cedula, b.nombreEmpleado as Empleado, e.estadoGomas as 'Estado Gomas', e.etcInspeccion as ETC, e.fechaInspeccion as Fecha, e.tieneRayaduras as Rayaduras, e.cantidadCombustible as Combustible, e.tieneGomaRepuesta as 'Goma Repuesto', e.tieneGato as Gato, e.tieneReturasCristal as 'Roturas Cristal', e.estadoInspeccion as Estado From inspeccion e JOIN vehiculos s on e.vehiculoInspeccion = idVehiculo JOIN clientes a on e.clienteInspeccion = idCliente JOIN empleados b on e.empleadoInspeccion = idEmpleado and (descripcionVehiculo like '%{vehiculo}%' or nombreCliente = '{cliente}' or nombreEmpleado  = '{empleado}');";
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
            string lineacomando = $"Select e.idTransaccion as ID, s.descripcionVehiculo as Vehiculo , a.nombreCliente as Cliente, a.cedulaCliente as Cedula, b.nombreEmpleado as Empleado, e.estadoGomas as 'Estado Gomas', e.etcInspeccion as ETC, e.fechaInspeccion as Fecha, e.tieneRayaduras as Rayaduras, e.cantidadCombustible as Combustible, e.tieneGomaRepuesta as 'Goma Repuesto', e.tieneGato as Gato, e.tieneReturasCristal as 'Roturas Cristal', e.estadoInspeccion as Estado From inspeccion e JOIN vehiculos s on e.vehiculoInspeccion = idVehiculo JOIN clientes a on e.clienteInspeccion = idCliente JOIN empleados b on e.empleadoInspeccion = idEmpleado;";
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
