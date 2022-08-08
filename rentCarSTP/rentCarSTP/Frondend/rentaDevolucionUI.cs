using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rentCarSTP.Backend;
using System.Data.SqlClient;
using ClosedXML;
using ClosedXML.Excel;

namespace rentCarSTP.Frondend
{
    public partial class rentaDevolucionUI : Form
    {

        int noRentaDevolucion, cantidadDeDias, montoXDia;
        string empleado, vehiculo, cliente, fechaRenta, fechaDevolucion, comentario, estado;
        datosRentaDevolucion datosRentaDevolucion = new datosRentaDevolucion();
        datosVehiculos datosVehiculos = new datosVehiculos();

        public rentaDevolucionUI()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
            clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            fillgrid();
            clear();

        }

        private void rentaDevolucionUI_Load(object sender, EventArgs e)
        {
            fillgrid();
            cargarOpciones();
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
                dateRenta.Value = Convert.ToDateTime(dataRentaDevolucion.SelectedRows[0].Cells[1].Value);
                dateDevolucion.Value = Convert.ToDateTime(dataRentaDevolucion.SelectedRows[0].Cells[2].Value);
                
                txtMontoXDia.Text = dataRentaDevolucion.SelectedRows[0].Cells[3].Value + string.Empty;
                txtCantidadDias.Text = dataRentaDevolucion.SelectedRows[0].Cells[4].Value + string.Empty;
                comboEmpleado.Text = dataRentaDevolucion.SelectedRows[0].Cells[5].Value + string.Empty;
                comboVehiculo.Text = dataRentaDevolucion.SelectedRows[0].Cells[6].Value + string.Empty;
                comboCliente.Text = dataRentaDevolucion.SelectedRows[0].Cells[7].Value + string.Empty;
                rTxtComentario.Text = dataRentaDevolucion.SelectedRows[0].Cells[8].Value + string.Empty;
                estado = dataRentaDevolucion.SelectedRows[0].Cells[9].Value + string.Empty;
                if (estado == "Devuelto")
                {
                    checkEstado.Checked = true;
                }
                else
                {
                    checkEstado.Checked = false;
                }
            
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Hubo un error: " + ex.Message);
            //    throw;
            //}
            


        }

        //Agregar
        public void agregar()
        {
            fechaRenta = dateRenta.Value.ToString("yyyy-MM-dd");
            fechaDevolucion = dateDevolucion.Value.ToString("yyyy-MM-dd");
            cantidadDeDias = calcularDias(fechaRenta, fechaDevolucion);
            montoXDia = int.Parse(txtMontoXDia.Text);
            try
            {
                montoXDia = int.Parse(txtMontoXDia.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El valor no es un numero");
                return;
            }
            if (montoXDia < 0)
            {
                MessageBox.Show("Revisar Monto");
            }
            else
            {
                montoXDia = int.Parse(txtMontoXDia.Text);
            }
            empleado = comboEmpleado.Text;
            vehiculo = comboVehiculo.Text;
            cliente = comboCliente.Text;
            comentario = rTxtComentario.Text;
            estado = chckEstado(checkEstado.Checked);

            datosRentaDevolucion.agregarRentaDevolucion(fechaRenta, fechaDevolucion, montoXDia, cantidadDeDias, empleado, vehiculo, cliente, comentario, estado);
            MessageBox.Show("Registro Agregado");
            clear();
            fillgrid();
        }

        private void dateDevolucion_ValueChanged(object sender, EventArgs e)
        {
            verificarFecha();
        }

        private void dateRenta_ValueChanged(object sender, EventArgs e)
        {

            verificarFecha();
        }

        public void verificarFecha()
        {
            cantidadDeDias = calcularDias(fechaRenta, fechaDevolucion);
            if (cantidadDeDias < 0)
            {
                MessageBox.Show("Revisar Fecha");
                dateRenta.Value = DateTime.Today;
                dateDevolucion.Value = DateTime.Today;
            }
            else
            {
                txtCantidadDias.Text = cantidadDeDias.ToString();
            }
        }

        

        //Buscar
        public void buscar()
        {
            cliente = comboCliente.Text;
            vehiculo = comboVehiculo.Text;
            empleado = comboEmpleado.Text;

            dataRentaDevolucion.DataSource = datosRentaDevolucion.buscarRentaDevolucion(empleado, vehiculo, cliente);
        }

        //Borrar
        public void borrar()
        {
            DataGridViewCell cell = dataRentaDevolucion.SelectedCells[0] as DataGridViewCell;
            noRentaDevolucion = (int)cell.Value; ;

            datosRentaDevolucion.eliminarRentaDevolucion(noRentaDevolucion);

            MessageBox.Show("Registro Borrado");
            clear();
            fillgrid();

        }

        //Editar
        public void editar()
        {
            DataGridViewCell cell = dataRentaDevolucion.SelectedCells[0] as DataGridViewCell;
            noRentaDevolucion = (int)cell.Value;

            fechaRenta = dateRenta.Value.ToString("yyyy-MM-dd");
            fechaDevolucion = dateDevolucion.Value.ToString("yyyy-MM-dd");
            cantidadDeDias = calcularDias(fechaRenta, fechaDevolucion);
            try
            {
                montoXDia = int.Parse(txtMontoXDia.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El valor no es un número");
                return;
            }

            if (montoXDia < 0)
            {
                MessageBox.Show("Revisar Monto");
            }
            else
            {
                montoXDia = int.Parse(txtMontoXDia.Text);
            }
            empleado = comboEmpleado.Text;
            vehiculo = comboVehiculo.Text;
            cliente = comboCliente.Text;
            comentario = rTxtComentario.Text;
            estado = chckEstado(checkEstado.Checked);

            datosRentaDevolucion.editarRentaDevolucion(noRentaDevolucion, fechaRenta, fechaDevolucion, montoXDia, cantidadDeDias, empleado, vehiculo, cliente, comentario, estado);

            MessageBox.Show("Registro Editado");
            clear();
            fillgrid();
        }


        public int calcularDias(string fechaRenta, string fechaDevolucion)
        {
            DateTime fechaRentaa = dateRenta.Value;
            DateTime fechaDevolucionn = dateDevolucion.Value;
            TimeSpan cantidadDeDiass = new TimeSpan(fechaDevolucionn.Ticks - fechaRentaa.Ticks);
            cantidadDeDiass.ToString(@"dd");
            string resultado = string.Format(@"{0}",
                cantidadDeDiass.Days);
            int resultadoReal = int.Parse(resultado) + 1;

            return resultadoReal;
        }


        public void fillgrid()
        {
            dataRentaDevolucion.DataSource = datosRentaDevolucion.fillGrid();
        }

        public void clear()
        {
            foreach (Control tool in Controls)
            {
                if (tool is TextBox)
                {
                    tool.Text = "";
                }

                if (tool is CheckBox)
                {
                    ((CheckBox)tool).Checked = false;
                }

            }
        }

        public string chckEstado(bool estado)
        {
            if (estado == true)
            {
                return "Devuelto";
            }

            else
            {
                return "Rentado";
            }
        }

        //Cargar Opciones para los ComboBoxes
        public void cargarOpciones()
        {
            string con = $"Data Source=.\\SQLEXPRESS;Initial Catalog=rentCarTP;Integrated Security=True";

            string comandoVehiculos = "select s.descripcionVehiculo from inspeccion e JOIN vehiculos s on e.vehiculoInspeccion = s.idVehiculo and e.estadoInspeccion = 'Despachable';";
            SqlConnection conn = new SqlConnection(con);
            SqlDataAdapter adaptVehiculos = new SqlDataAdapter(comandoVehiculos, conn);

            DataTable vehiculos = new DataTable();
            adaptVehiculos.Fill(vehiculos);
            comboVehiculo.DisplayMember = "descripcionVehiculo";
            comboVehiculo.DataSource = vehiculos;

            string comandoCliente = "select nombreCliente from clientes where estadoCliente = 'Verificado';";
            SqlDataAdapter adaptCliente = new SqlDataAdapter(comandoCliente, conn);

            DataTable clientes = new DataTable();
            adaptCliente.Fill(clientes);
            comboCliente.DisplayMember = "nombreCliente";
            comboCliente.DataSource = clientes;

            string comandoEmpleado = "select nombreEmpleado from empleados where estadoEmpleado = 'Verificado';";
            SqlDataAdapter adaptEmpleados = new SqlDataAdapter(comandoEmpleado, conn);

            DataTable empleados = new DataTable();
            adaptEmpleados.Fill(empleados);
            comboEmpleado.DisplayMember = "nombreEmpleado";
            comboEmpleado.DataSource = empleados;

        }

    }
}
