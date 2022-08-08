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

namespace rentCarSTP.Frondend
{
    public partial class inspeccionUI : Form
    {
        int idInspeccion;
        string tieneRayaduras, cantidadCombustible, tieneGomaRepuesta, tieneGato, tieneRoturasCristal, estadoGomas, ETC, fechaInspeccion, vehiculo, cliente, empleado, estado;
        datosInspeccion datosInspeccion = new datosInspeccion();
        public inspeccionUI()
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
        }

        private void btnBorrar_Click(object sender, EventArgs e)
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

        private void inspeccionUI_Load(object sender, EventArgs e)
        {
            comboCombustible.Items.Add("Tanque Lleno");
            comboCombustible.Items.Add("1/2");
            comboCombustible.Items.Add("1/4");
            comboCombustible.Items.Add("Tanque Vacio");

            comboCliente.Items.Add("");
            comboEmpleado.Items.Add("");
            comboVehiculo.Items.Add("");
            cargarOpciones();
            fillgrid();
        }

        private void dataInspeccion_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            comboVehiculo.Text = dataInspeccion.SelectedRows[0].Cells[1].Value + string.Empty;
            comboCliente.Text = dataInspeccion.SelectedRows[0].Cells[2].Value + string.Empty;
            comboEmpleado.Text = dataInspeccion.SelectedRows[0].Cells[4].Value + string.Empty;
            estadoGomas = dataInspeccion.SelectedRows[0].Cells[5].Value + string.Empty;
            if(estadoGomas == "Todas están en buen estado")
            {
                checkGomaIZQDEL.Checked = true;
                checkGomaIZQTRAS.Checked = true;
                checkGomaDERDEL.Checked = true;
                checkGomaDERTRAS.Checked = true;

            }
            else
            {
                checkGomaIZQDEL.Checked = false;
                checkGomaIZQTRAS.Checked = false;
                checkGomaDERDEL.Checked = false;
                checkGomaDERTRAS.Checked = false;
            }

            ETC = dataInspeccion.SelectedRows[0].Cells[6].Value + string.Empty;
            if (ETC == "Si")
            {
                checkETC.Checked = true;
            }
            else
            {
                checkETC.Checked = false;
            }

            fechaInspeccion = dataInspeccion.SelectedRows[0].Cells[7].Value + string.Empty;
            tieneRayaduras = dataInspeccion.SelectedRows[0].Cells[8].Value + string.Empty;
            if(tieneRayaduras == "Si")
            {
                checkRayaduras.Checked = true;
            }
            else
            {
                checkRayaduras.Checked = false;
            }
            comboCombustible.Text = dataInspeccion.SelectedRows[0].Cells[9].Value + string.Empty;
            tieneGomaRepuesta = dataInspeccion.SelectedRows[0].Cells[10].Value + string.Empty;
            if(tieneGomaRepuesta == "Si")
            {
                checkGomaRepuesta.Checked = true;
            }
            else
            {
                checkGomaRepuesta.Checked = false;
            }
            tieneGato = dataInspeccion.SelectedRows[0].Cells[11].Value + string.Empty;
            if(tieneGato == "Si")
            {
                checkGato.Checked = true;
            }
            else
            {
                checkGato.Checked = false;
            }

            tieneRoturasCristal = dataInspeccion.SelectedRows[0].Cells[12].Value + string.Empty;
            if(tieneRoturasCristal == "Si")
            {
                checkCrsitalRoto.Checked = true;
            }
            else
            {
                checkCrsitalRoto.Checked = false;
            }

            estado = dataInspeccion.SelectedRows[0].Cells[13].Value + string.Empty;
            if(estado == "Despachable")
            {
                checkEstado.Checked = true; 
            }
            else
            {
                checkEstado.Checked = false;
            }
            
        }

        //Agregar
        public void agregar()
        {
            vehiculo = comboVehiculo.Text;
            cliente = comboCliente.Text;
            tieneRayaduras = chckEstado(checkRayaduras.Checked);
            cantidadCombustible = comboCombustible.Text;
            tieneGomaRepuesta = chckEstado(checkGomaRepuesta.Checked);
            tieneGato = chckEstado(checkGato.Checked);
            tieneRoturasCristal = chckEstado(checkCrsitalRoto.Checked);
            estadoGomas = checkGomas(checkGomaIZQDEL.Checked, checkGomaIZQTRAS.Checked, checkGomaDERDEL.Checked, checkGomaDERTRAS.Checked);
            ETC = chckEstado(checkETC.Checked);
            fechaInspeccion = dateInspeccion.Value.ToString("yyyy-MM-dd");
            empleado = comboEmpleado.Text;
            estado = checkDespacho(checkEstado.Checked);

            datosInspeccion.agregarInspeccion(tieneRayaduras, cantidadCombustible, tieneGomaRepuesta, tieneGato, tieneRoturasCristal, estadoGomas, ETC, fechaInspeccion, vehiculo, cliente, empleado, estado);
            MessageBox.Show("Inspeccion Agregada");
            clear();
            fillgrid();
        }


        //Buscar
        public void buscar()
        {
            cliente = comboCliente.Text;
            vehiculo = comboVehiculo.Text;
            empleado = comboEmpleado.Text;

            if (comboCliente.Text == "")
            {
                cliente = ".";
            }

            else
            {
                cliente = comboCliente.Text;
            }

            if (comboVehiculo.Text == "")
            {
                vehiculo = ".";
            }

            else
            {
                vehiculo = comboVehiculo.Text;
            }

            if (comboEmpleado.Text == "")
            {
                empleado = ".";
            }

            else
            {
                empleado = comboEmpleado.Text;
            }

            dataInspeccion.DataSource = datosInspeccion.buscarInspeccion(vehiculo, cliente, empleado);
        }

        //Borrar
        public void borrar()
        {
            DataGridViewCell cell = dataInspeccion.SelectedCells[0] as DataGridViewCell;
            idInspeccion = (int)cell.Value; ;

            datosInspeccion.eliminarInspeccion(idInspeccion);

            MessageBox.Show("Inspeccion Borrado");
            clear();
            fillgrid();

        }

        //Editar
        public void editar()
        {
            DataGridViewCell cell = dataInspeccion.SelectedCells[0] as DataGridViewCell;
            idInspeccion = (int)cell.Value;

            vehiculo = comboVehiculo.Text;
            cliente = comboCliente.Text;
            tieneRayaduras = chckEstado(checkRayaduras.Checked);
            cantidadCombustible = comboCombustible.Text;
            tieneGomaRepuesta = chckEstado(checkGomaRepuesta.Checked);
            tieneGato = chckEstado(checkGato.Checked);
            tieneRoturasCristal = chckEstado(checkCrsitalRoto.Checked);
            estadoGomas = checkGomas(checkGomaIZQDEL.Checked, checkGomaIZQTRAS.Checked, checkGomaDERDEL.Checked, checkGomaDERTRAS.Checked);
            ETC = chckEstado(checkETC.Checked);
            fechaInspeccion = dateInspeccion.Value.ToString("yyyy-MM-dd");
            empleado = comboEmpleado.Text;
            estado = checkDespacho(checkEstado.Checked);

            datosInspeccion.editarInspeccion(idInspeccion ,tieneRayaduras, cantidadCombustible, tieneGomaRepuesta, tieneGato, tieneRoturasCristal, estadoGomas, ETC, fechaInspeccion, vehiculo, cliente, empleado, estado);

            MessageBox.Show("Inspeccion Editada");
            clear();
            fillgrid();
        }

        public string chckEstado(bool estado)
        {
            if (estado == true)
            {
                return "Si";
            }

            else
            {
                return "No";
            }
        }

        public string checkDespacho(bool estado)
        {
            if(estado == true)
            {
                return "Despachable";
            }
            else
            {
                return "No Despachable";
            }
        }

        public void fillgrid()
        {
            dataInspeccion.DataSource = datosInspeccion.fillGrid();
        }

        private void modelosUI_Load(object sender, EventArgs e)
        {
            fillgrid();
            cargarOpciones();
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

            checkEstado.Checked = false;
        }

        //Cargar Opciones para los ComboBoxes
        public void cargarOpciones()
        {
            string con = $"Data Source=.\\SQLEXPRESS;Initial Catalog=rentCarTP;Integrated Security=True";

            string comandoVehiculos = "select descripcionVehiculo from vehiculos where estadoVehiculo = 'Disponible';";
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
;
        }

        public string checkGomas(bool IZQDEL, bool IZQTRAS, bool DERDEL, bool DERTRAS)
        {
            if (IZQDEL == true && IZQTRAS == true && DERDEL == true && DERTRAS == true)
            {
                return "Todas están en buen estado";
            }

            else
            {
                return "Faltan gomas por revisar";
            }
        }

    }
}
