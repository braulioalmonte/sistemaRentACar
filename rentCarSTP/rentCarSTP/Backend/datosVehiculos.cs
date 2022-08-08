using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace rentCarSTP.Backend
{
    internal class datosVehiculos
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=rentCarTP;Integrated Security=True");
        SqlCommand comando;

        //Agregar
        public void agregarVehiculo(string descripcion, string noChasis, string noMotor, string noPlaca, string tipoDeVehiculo, string marcaVehiculo, string modeloVehiculo, string tipoCombustible, string estado)
        {
            try
            {
                con.Open();

                string lineaComando = $"insert into vehiculos values('{descripcion}', '{noChasis}','{noMotor}', '{noPlaca}', (SELECT idTipoVehiculo from tiposDeVehiculos WHERE descripcionTipoDeVehiculos='{tipoDeVehiculo}'), (SELECT idMarca from marcas where descripcionMarca ='{marcaVehiculo}'), (SELECT idModelo from modelos where descripcionModelo ='{modeloVehiculo}'), (SELECT idTipoDeCombustible from tiposDeCombustible where descripcionTipoDeCombustible ='{tipoCombustible}'), '{estado}');";
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
        public void editarVehiculo(int id, string descripcion, string noChasis, string noMotor, string noPlaca, string tipoDeVehiculo, string marcaVehiculo, string modeloVehiculo, string tipoCombustible, string estado)
        {
            try
            {
                con.Open();

                string lineaComando = $"update vehiculos set descripcionVehiculo = '{descripcion}' , noChasis = '{noChasis}', noMotor = '{noMotor}', noPlaca = '{noPlaca}', tipoVehiculo  = (SELECT idTipoVehiculo from tiposDeVehiculos WHERE descripcionTipoDeVehiculos = '{tipoDeVehiculo}'), marcaVehiculo = (SELECT idMarca from marcas WHERE descripcionMarca='{marcaVehiculo}'), modeloVehiculo =(SELECT idModelo from modelos WHERE descripcionModelo='{modeloVehiculo}') , tipoCombustibleVehiculo = (SELECT idTipoDeCombustible from tiposDeCombustible WHERE descripcionTipoDeCombustible='{tipoCombustible}'), estadoVehiculo = '{estado}' where idVehiculo = {id};";
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
        public void eliminarVehiculo(int id)
        {
            try
            {
                con.Open();

                string lineaComando = $"delete from vehiculos where idVehiculo = {id};";
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
        public DataTable buscarVehiculo(string descripcion, string noChasis, string noMotor, string noPlaca, string tipoDeVehiculo, string marcaVehiculo, string modeloVehiculo, string tipoCombustible, string estado)
        {
            con.Open();
            string lineacomando = $"Select e.idVehiculo as ID, e.descripcionVehiculo as Descripción, e.noChasis, e.noMotor, e.noPlaca, S.descripcionTipoDeVehiculos as TipoDeVehiculo, c.descripcionMarca as Marca, a.descripcionModelo as Modelo,b.descripcionTipoDeCombustible as TipoDeCombustible, e.estadoVehiculo as Estado From vehiculos e JOIN tiposDeVehiculos s on e.tipoVehiculo = idTipoVehiculo JOIN modelos a on e.modeloVehiculo = idModelo JOIN tiposDeCombustible b on e.tipoCombustibleVehiculo = idTipoDeCombustible JOIN marcas c on e.marcaVehiculo = idMarca and (descripcionVehiculo like '%{descripcion}%' or noChasis like '%{noChasis}%' or noMotor like '%{noMotor}%' or noPlaca like '%{noPlaca}%' or tipoCombustibleVehiculo like '%{tipoDeVehiculo}%' or marcaVehiculo like '%Kia%' or modeloVehiculo like '%{modeloVehiculo}%' or tipoCombustibleVehiculo like '%{tipoCombustible}%' or estadoVehiculo like '%{estado}%');";
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
            string lineacomando = $"Select e.idVehiculo as ID, e.descripcionVehiculo as Descripción, e.noChasis, e.noMotor, e.noPlaca, S.descripcionTipoDeVehiculos as TipoDeVehiculo, c.descripcionMarca as Marca, a.descripcionModelo as Modelo,b.descripcionTipoDeCombustible as TipoDeCombustible, e.estadoVehiculo as Estado From vehiculos e JOIN tiposDeVehiculos s on e.tipoVehiculo = idTipoVehiculo JOIN modelos a on e.modeloVehiculo = idModelo JOIN tiposDeCombustible b on e.tipoCombustibleVehiculo = idTipoDeCombustible JOIN marcas c on e.marcaVehiculo = idMarca;";
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
