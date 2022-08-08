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
    public partial class clientesUI : Form
    {
        int idCliente, limiteCredito;
        string nombre, cedula, noTarjetaCR, tipoDePersona, estado;
        datosClientes datosClientes = new datosClientes();

        public clientesUI()
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

        //Agregar
        public void agregar()
        {
            cedula = txtCedula.Text;
            validaCedula(cedula);
            if (validaCedula(cedula) == true)
            {
                cedula = txtCedula.Text;
                nombre = txtNombre.Text;
                tipoDePersona = comboTipoDePersona.Text;
                noTarjetaCR = txtTarjetaCredito.Text;

                try
                {
                    limiteCredito = int.Parse(txtLimiteCredito.Text);
                    if (limiteCredito < 0)
                    {
                        MessageBox.Show("Monto no puede ser negativo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error con los datos " + ex.Message);
                    return;
                }

                estado = chckEstado(checkEstado.Checked);

                datosClientes.agregarCliente(nombre, cedula, noTarjetaCR, limiteCredito, tipoDePersona, estado);
                MessageBox.Show("Cliente Agregado");
                clear();
                fillgrid();
            }

            else
            {
                MessageBox.Show("Cédula Inválida");
            }
            
        }

        //Buscar
        public void buscar()
        {
            if(txtNombre.Text == "")
            {
                nombre = ".";
            }
            else
            {
                nombre = txtNombre.Text;
            }

            if (txtCedula.Text == "")
            {
                cedula = ".";
            }

            else
            {
                cedula = txtNombre.Text;
            }

            dataClientes.DataSource = datosClientes.buscarCliente(nombre, cedula);
        }

        private void clientesUI_Load(object sender, EventArgs e)
        {
            comboTipoDePersona.Items.Add("Fisica");
            comboTipoDePersona.Items.Add("Juridica");
            fillgrid();
        }

        //Borrar
        public void borrar()
        {
            DataGridViewCell cell = dataClientes.SelectedCells[0] as DataGridViewCell;
            idCliente = (int)cell.Value; ;

            datosClientes.eliminarCliente(idCliente);

            MessageBox.Show("Cliente Borrado");
            clear();
            fillgrid();

        }


        private void dataClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNombre.Text = dataClientes.SelectedRows[0].Cells[1].Value + string.Empty;
            txtCedula.Text = dataClientes.SelectedRows[0].Cells[2].Value + string.Empty;
            txtTarjetaCredito.Text = dataClientes.SelectedRows[0].Cells[3].Value + string.Empty;
            txtLimiteCredito.Text = dataClientes.SelectedRows[0].Cells[4].Value + string.Empty;
            comboTipoDePersona.Text = dataClientes.SelectedRows[0].Cells[5].Value + string.Empty;
            estado = dataClientes.SelectedRows[0].Cells[6].Value + string.Empty;
            if (estado == "Verificado")
            {
                checkEstado.Checked = true;
            }
            else
            {
                checkEstado.Checked = false;
            }
        }

        //Editar
        public void editar()
        {
            DataGridViewCell cell = dataClientes.SelectedCells[0] as DataGridViewCell;
            idCliente = (int)cell.Value;

            cedula = txtCedula.Text;
            validaCedula(cedula);
            if (validaCedula(cedula) == true)
            {
                cedula = txtCedula.Text;
                nombre = txtNombre.Text;
                tipoDePersona = comboTipoDePersona.Text;
                noTarjetaCR = txtTarjetaCredito.Text;

                try
                {
                    limiteCredito = int.Parse(txtLimiteCredito.Text);
                    if (limiteCredito < 0)
                    {
                        MessageBox.Show("Monto no puede ser negativo");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error con los datos " + ex.Message);
                    return;
                }

                estado = chckEstado(checkEstado.Checked);

                datosClientes.editarCliente(idCliente, nombre, cedula, noTarjetaCR, limiteCredito, tipoDePersona, estado);
                MessageBox.Show("Cliente Editado");
                clear();
                fillgrid();
            }

            else
            {
                MessageBox.Show("Cedula Invalida");
            }
        }

        public string chckEstado(bool estado)
        {
            if (estado == true)
            {
                return "Verificado";
            }

            else
            {
                return "No Verificado";
            }
        }

        public void fillgrid()
        {
            dataClientes.DataSource = datosClientes.fillGrid();
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

        public static bool validaCedula(string pCedula)

        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }

    }
}
