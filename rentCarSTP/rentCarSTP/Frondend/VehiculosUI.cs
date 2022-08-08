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
    public partial class VehiculosUI : Form
    {

        int idVehiculo;
        string descripcionVehiculo, noChasis, noMotor, noPlaca, tipoVehiculo, marcaVehiculo, modeloVehiculo, tipoDeCombustibleVehiculo, estadoVehiculo;
        datosVehiculos datosVehiculos = new datosVehiculos();

        public VehiculosUI()
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

        private void VehiculosUI_Load(object sender, EventArgs e)
        {
            fillgrid();
            cargarOpciones();
        }

        //Agregar
        public void agregar()
        {
            descripcionVehiculo = txtDesc.Text;
            noChasis = txtChasis.Text;
            noMotor = txtMotor.Text;
            noPlaca = txtPlaca.Text;
            tipoVehiculo = comboTipoVehiculo.Text;
            marcaVehiculo = comboMarca.Text;
            modeloVehiculo = comboModelo.Text;
            tipoDeCombustibleVehiculo = comboTipoDeCombustible.Text;
            estadoVehiculo = chckEstado(checkEstado.Checked);

            datosVehiculos.agregarVehiculo(descripcionVehiculo, noChasis, noMotor, noPlaca, tipoVehiculo, marcaVehiculo, modeloVehiculo, tipoDeCombustibleVehiculo, estadoVehiculo);
            MessageBox.Show("Vehiculo Agregado");
            clear();
            fillgrid();
        }

        private void dataVehiculos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDesc.Text = dataVehiculos.SelectedRows[0].Cells[1].Value + string.Empty;
            txtChasis.Text = dataVehiculos.SelectedRows[0].Cells[2].Value + string.Empty;
            txtMotor.Text = dataVehiculos.SelectedRows[0].Cells[3].Value + string.Empty;
            txtPlaca.Text = dataVehiculos.SelectedRows[0].Cells[4].Value + string.Empty;
            comboTipoVehiculo.Text = dataVehiculos.SelectedRows[0].Cells[5].Value + string.Empty;
            comboMarca.Text = dataVehiculos.SelectedRows[0].Cells[6].Value + string.Empty;
            comboModelo.Text = dataVehiculos.SelectedRows[0].Cells[7].Value + string.Empty;
            comboTipoDeCombustible.Text = dataVehiculos.SelectedRows[0].Cells[8].Value + string.Empty;
            estadoVehiculo = dataVehiculos.SelectedRows[0].Cells[9].Value + string.Empty;
            if (estadoVehiculo == "Disponible")
            {
                checkEstado.Checked = true;
            }
            else
            {
                checkEstado.Checked = false;
            }
        }


        //Buscar
        public void buscar()
        {
            descripcionVehiculo = txtDesc.Text;
            noChasis = txtChasis.Text;
            noMotor = txtMotor.Text;
            noPlaca = txtPlaca.Text;

            if (txtDesc.Text == "")
            {
                descripcionVehiculo = ".";
            }

            else
            {
                descripcionVehiculo = txtDesc.Text;
            }

            if (txtChasis.Text == "")
            {
                noChasis = ".";
            }

            else
            {
                noChasis = txtChasis.Text;
            }

            if (txtMotor.Text == "")
            {
                noMotor = ".";
            }

            else
            {
                noMotor = txtMotor.Text;
            }

            if (txtPlaca.Text == "")
            {
                noPlaca = ".";
            }

            else
            {
                noPlaca = txtPlaca.Text;
            }

            tipoVehiculo = comboTipoVehiculo.Text;
            marcaVehiculo = comboMarca.Text;
            modeloVehiculo = comboModelo.Text;
            tipoDeCombustibleVehiculo = comboTipoDeCombustible.Text;
            estadoVehiculo = chckEstado(checkEstado.Checked);

            dataVehiculos.DataSource = datosVehiculos.buscarVehiculo(descripcionVehiculo, noChasis, noMotor, noPlaca, tipoVehiculo, marcaVehiculo, modeloVehiculo, tipoDeCombustibleVehiculo, estadoVehiculo);
        }

        //Borrar
        public void borrar()
        {
            DataGridViewCell cell = dataVehiculos.SelectedCells[0] as DataGridViewCell;
            idVehiculo = (int)cell.Value; ;

            datosVehiculos.eliminarVehiculo(idVehiculo);

            MessageBox.Show("Vehiculo Borrado");
            clear();
            fillgrid();

        }

        //Editar
        public void editar()
        {
            DataGridViewCell cell = dataVehiculos.SelectedCells[0] as DataGridViewCell;
            idVehiculo = (int)cell.Value;

            descripcionVehiculo = txtDesc.Text;
            noChasis = txtChasis.Text;
            noMotor = txtMotor.Text;
            noPlaca = txtPlaca.Text;
            tipoVehiculo = comboTipoVehiculo.Text;
            marcaVehiculo = comboMarca.Text;
            modeloVehiculo = comboModelo.Text;
            tipoDeCombustibleVehiculo = comboTipoDeCombustible.Text;
            estadoVehiculo = chckEstado(checkEstado.Checked);

            datosVehiculos.editarVehiculo(idVehiculo, descripcionVehiculo, noChasis, noMotor, noPlaca, tipoVehiculo, marcaVehiculo, modeloVehiculo, tipoDeCombustibleVehiculo, estadoVehiculo);

            MessageBox.Show("Vehiculo Editado");
            clear();
            fillgrid();
        }

        public string chckEstado(bool estado)
        {
            if (estado == true)
            {
                return "Disponible";
            }

            else
            {
                return "No Disponible";
            }
        }

        public void fillgrid()
        {
            dataVehiculos.DataSource = datosVehiculos.fillGrid();
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

            }

            checkEstado.Checked = false;
        }

        //Cargar Opciones para los ComboBoxes
        public void cargarOpciones()
        {
            string con = $"Data Source=.\\SQLEXPRESS;Initial Catalog=rentCarTP;Integrated Security=True";

            string comandoMarcas = "select descripcionMarca from marcas where estadoMarca = 'Disponible';";
            SqlConnection conn = new SqlConnection(con);
            SqlDataAdapter adaptMarcas = new SqlDataAdapter(comandoMarcas, conn);

            DataTable marcas = new DataTable();
            adaptMarcas.Fill(marcas);
            comboMarca.DisplayMember = "descripcionMarca";

            comboMarca.DataSource = marcas;

            string comandoTipoDeVehiculo = "select descripcionTipoDeVehiculos from tiposDeVehiculos where estadoTipoDeVehiculos = 'Disponible';";
            SqlDataAdapter adaptTipoDeVehiculo = new SqlDataAdapter(comandoTipoDeVehiculo, conn);

            DataTable tipoDeVehiculo = new DataTable();
            adaptTipoDeVehiculo.Fill(tipoDeVehiculo);
            comboTipoVehiculo.DisplayMember = "descripcionTipoDeVehiculos";

            comboTipoVehiculo.DataSource = tipoDeVehiculo;

            string comandoModelo = "select descripcionModelo from modelos where estadoModelo = 'Disponible';";
            SqlDataAdapter adaptModelo = new SqlDataAdapter(comandoModelo, conn);

            DataTable modelo = new DataTable();
            adaptModelo.Fill(modelo);
            comboModelo.DisplayMember = "descripcionModelo";

            comboModelo.DataSource = modelo;

            string comandoTipoDeCombustible = "select descripcionTipoDeCombustible from tiposDeCombustible where estadoTipoDeCombustible = 'Disponible';";
            SqlDataAdapter adaptTipoDeCombustible = new SqlDataAdapter(comandoTipoDeCombustible, conn);

            DataTable tipoDeCombustible = new DataTable();
            adaptTipoDeCombustible.Fill(tipoDeCombustible);
            comboTipoDeCombustible.DisplayMember = "descripcionTipoDeCombustible";

            comboTipoDeCombustible.DataSource = tipoDeCombustible;
        }

    }
}
