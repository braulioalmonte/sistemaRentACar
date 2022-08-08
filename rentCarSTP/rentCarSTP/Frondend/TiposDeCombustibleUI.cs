using System;
using System.Collections.Generic;
using System.ComponentModel;
using rentCarSTP.Backend;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace rentCarSTP.Frondend
{
    public partial class TiposDeCombustibleUI : Form
    {
        int idTipoDeCombustible;
        string descripcionTipoDeCombustible, estadoTipoDeCombustible;
        datosTiposDeCombustible datosTipoDeCombustible = new datosTiposDeCombustible();

        public TiposDeCombustibleUI()
        {
            InitializeComponent();
        }

        private void TiposDeCombustibleUI_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        //Botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        //Botón Borrar
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            borrar();
        }

        //Botón Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        //Botón Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }

        //Botón Refrescar
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            fillgrid();
        }

        //Agregar
        public void agregar()
        {
            descripcionTipoDeCombustible = txtDesc.Text;

            estadoTipoDeCombustible = chckEstado(checkEstado.Checked);

            datosTipoDeCombustible.agregarTipoDeCombustible(descripcionTipoDeCombustible, estadoTipoDeCombustible);
            MessageBox.Show("Tipo de Combustible Agregado");
            clear();
            fillgrid();
        }

        //Buscar
        public void buscar()
        {
            descripcionTipoDeCombustible = txtDesc.Text;
            dataTiposDeCombustibles.DataSource = datosTipoDeCombustible.buscarTipoCombustible(descripcionTipoDeCombustible);
        }

        //Borrar
        public void borrar()
        {
            DataGridViewCell cell = dataTiposDeCombustibles.SelectedCells[0] as DataGridViewCell;
            idTipoDeCombustible = (int)cell.Value; ;

            datosTipoDeCombustible.eliminarTipoCombustible(idTipoDeCombustible);

            MessageBox.Show("Tipo de Combustible Borrado");
            clear();
            fillgrid();

        }

        //Editar
        public void editar()
        {
            DataGridViewCell cell = dataTiposDeCombustibles.SelectedCells[0] as DataGridViewCell;
            idTipoDeCombustible = (int)cell.Value;

            descripcionTipoDeCombustible = txtDesc.Text;

            estadoTipoDeCombustible = chckEstado(checkEstado.Checked);

            datosTipoDeCombustible.editarTipoDeCombustible(idTipoDeCombustible, descripcionTipoDeCombustible, estadoTipoDeCombustible);

            MessageBox.Show("Tipo de Combustible Editado");
            clear();
            fillgrid();
        }

        public void fillgrid()
        {
            dataTiposDeCombustibles.DataSource = datosTipoDeCombustible.fillGrid();
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

        private void dataTiposDeCombustibles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDesc.Text = dataTiposDeCombustibles.SelectedRows[0].Cells[1].Value + string.Empty;
            estadoTipoDeCombustible = dataTiposDeCombustibles.SelectedRows[0].Cells[2].Value + string.Empty;
            if (estadoTipoDeCombustible == "Disponible")
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
