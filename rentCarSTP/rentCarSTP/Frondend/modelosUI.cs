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
    public partial class modelosUI : Form
    {
        int idModelo;
        string marcaModelo, descripcionModelo, descripcionMarca, estadoModelo;
        datosModelos datosModelos = new datosModelos();

        public modelosUI()
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

        //Agregar
        public void agregar()
        {
            marcaModelo = comboMarca.Text;
            descripcionModelo = txtDesc.Text;
            estadoModelo = chckEstado(checkEstado.Checked);

            datosModelos.agregarModelo(marcaModelo, descripcionModelo, estadoModelo);
            MessageBox.Show("Modelo Agregado");
            clear();
            fillgrid();
        }

        //Buscar
        public void buscar()
        {
            descripcionModelo = txtDesc.Text;

            if(txtDesc.Text == "")
            {
                descripcionModelo = ".";
            }

            else
            {
                descripcionModelo = txtDesc.Text;
            }
            descripcionMarca = comboMarca.Text;
            dataModelos.DataSource = datosModelos.buscarModelo(descripcionModelo, descripcionMarca);
        }

        //Borrar
        public void borrar()
        {
            DataGridViewCell cell = dataModelos.SelectedCells[0] as DataGridViewCell;
            idModelo = idModelo = (int)cell.Value; ;

            datosModelos.eliminarModelo(idModelo);

            MessageBox.Show("Modelo Borrado");
            clear();
            fillgrid();

        }

        //Editar
        public void editar()
        {
            DataGridViewCell cell = dataModelos.SelectedCells[0] as DataGridViewCell;
            idModelo = (int)cell.Value;

            descripcionMarca = comboMarca.Text;
            descripcionModelo = txtDesc.Text;
            estadoModelo = chckEstado(checkEstado.Checked);

            datosModelos.editarModelo(idModelo, descripcionMarca, descripcionModelo, estadoModelo);

            MessageBox.Show("Modelo Editado");
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
            dataModelos.DataSource = datosModelos.fillGrid();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            fillgrid();
            clear();
        }

        private void dataModelos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDesc.Text = dataModelos.SelectedRows[0].Cells[1].Value + string.Empty;
            comboMarca.Text = dataModelos.SelectedRows[0].Cells[2].Value + string.Empty;
            estadoModelo = dataModelos.SelectedRows[0].Cells[3].Value + string.Empty;
            if (estadoModelo == "Disponible")
            {
                checkEstado.Checked = true;
            }
            else
            {
                checkEstado.Checked = false;
            }
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

            
        }
    }
}
