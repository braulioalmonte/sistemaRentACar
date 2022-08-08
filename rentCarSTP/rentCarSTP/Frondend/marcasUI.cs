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

namespace rentCarSTP.Frondend
{
    public partial class marcasUI : Form
    {
        int idMarca;
        string descripcionMarca, estadoMarca;
        datosMarcas datosMarcas = new datosMarcas();

        public marcasUI()
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
        }

        private void marcasUI_Load(object sender, EventArgs e)
        {
            fillgrid();
        }


        //Agregar
        public void agregar()
        {
            descripcionMarca = txtDesc.Text;

            estadoMarca = chckEstado(checkEstado.Checked);

            datosMarcas.agregarMarca(descripcionMarca, estadoMarca);
            MessageBox.Show("Marca Agregada");
            clear();
            fillgrid();
        }

        //Buscar
        public void buscar()
        {
            descripcionMarca = txtDesc.Text;
            dataMarca.DataSource = datosMarcas.buscarMarca(descripcionMarca);
        }

        //Borrar
        public void borrar()
        {
            DataGridViewCell cell = dataMarca.SelectedCells[0] as DataGridViewCell;
            idMarca = (int)cell.Value; ;

            datosMarcas.eliminarMarca(idMarca);

            MessageBox.Show("Marca Borrada");
            clear();
            fillgrid();

        }

        //Editar
        public void editar()
        {
            DataGridViewCell cell = dataMarca.SelectedCells[0] as DataGridViewCell;
            idMarca = (int)cell.Value;

            descripcionMarca = txtDesc.Text;

            estadoMarca = chckEstado(checkEstado.Checked);

            datosMarcas.editarMarca(idMarca, descripcionMarca, estadoMarca);

            MessageBox.Show("Marca Editada");
            clear();
            fillgrid();
        }

        public void fillgrid()
        {
            dataMarca.DataSource = datosMarcas.fillGrid();
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

        private void dataMarca_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDesc.Text = dataMarca.SelectedRows[0].Cells[1].Value + string.Empty;
            estadoMarca = dataMarca.SelectedRows[0].Cells[2].Value + string.Empty;
            if (estadoMarca == "Disponible")
            {
                checkEstado.Checked = true;
            }
            else
            {
                checkEstado.Checked = false;
            }
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


    }
}
