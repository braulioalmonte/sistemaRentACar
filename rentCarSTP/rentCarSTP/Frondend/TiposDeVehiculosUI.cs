using rentCarSTP.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace rentCarSTP.Frondend
{
    public partial class TiposDeVehiculosUI : Form
    {
        int idTipoDeVehiculo;
        string descripcionTipoDeVehiculo, estadoTipoDeVehiculo;
        datosTiposDeVehiculos datosTipoDeVehiculos = new datosTiposDeVehiculos();

        public TiposDeVehiculosUI()
        {
            InitializeComponent();
        }

        private void TiposDeVehiculosUI_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        //Botón Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscar();
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

        //Botón Agregar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        //Agregar
        public void agregar()
        {
            descripcionTipoDeVehiculo = txtDesc.Text;

            estadoTipoDeVehiculo = chckEstado(checkEstado.Checked);

            datosTipoDeVehiculos.agregarTipoDeVehiculo(descripcionTipoDeVehiculo, estadoTipoDeVehiculo);
            MessageBox.Show("Tipo de Vehiculo Agregado");
            clear();
            fillgrid();
        }

        //Buscar
        public void buscar()
        {
            descripcionTipoDeVehiculo = txtDesc.Text;
            dataTiposDeVehiculos.DataSource = datosTipoDeVehiculos.buscarTipoVehiculo(descripcionTipoDeVehiculo);
        }

        //Borrar
        public void borrar()
        {
            DataGridViewCell cell = dataTiposDeVehiculos.SelectedCells[0] as DataGridViewCell;
            idTipoDeVehiculo = idTipoDeVehiculo = (int)cell.Value; ;

            datosTipoDeVehiculos.eliminarTipoVehiculo(idTipoDeVehiculo);

            MessageBox.Show("Tipo de Vehiculo Borrado");
            clear();
            fillgrid();

        }

        //Editar
        public void editar()
        {
            DataGridViewCell cell = dataTiposDeVehiculos.SelectedCells[0] as DataGridViewCell;
            idTipoDeVehiculo = (int)cell.Value;

            descripcionTipoDeVehiculo = txtDesc.Text;

            estadoTipoDeVehiculo = chckEstado(checkEstado.Checked);

            datosTipoDeVehiculos.editarTipoDeVehiculo(idTipoDeVehiculo, descripcionTipoDeVehiculo, estadoTipoDeVehiculo);

            MessageBox.Show("Tipo de Vehiculo Editado");
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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            fillgrid();
        }

        public void fillgrid()
        {
            dataTiposDeVehiculos.DataSource = datosTipoDeVehiculos.fillGrid();
        }

        private void dataTiposDeVehiculos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtDesc.Text = dataTiposDeVehiculos.SelectedRows[0].Cells[1].Value + string.Empty;
            estadoTipoDeVehiculo = dataTiposDeVehiculos.SelectedRows[0].Cells[2].Value + string.Empty;
            if (estadoTipoDeVehiculo == "Disponible")
            {
                checkEstado.Checked = true;
            }
            else
            {
                checkEstado.Checked = false;
            }
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
    }
}
