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
    public partial class empleadosUI : Form
    {
        int idEmpleado, porcientoComision;
        string nombre, cedula, tanda, fechaIngreso, estado;
        datosEmpleados datosEmpleados = new datosEmpleados();

        public empleadosUI()
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
            //fechaIngreso = dateIngreso.Value.ToString("yyyy-MM-dd");
            //MessageBox.Show(fechaIngreso);
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
                tanda = comboTanda.Text;
                fechaIngreso = dateIngreso.Value.ToString("yyyy-MM-dd");

                try
                {
                    porcientoComision = int.Parse(txtComision.Text);

                    if (porcientoComision < 0)
                    {
                        MessageBox.Show("Monto no puede ser negativo");
                    }
                    else
                    {
                        porcientoComision = int.Parse(txtComision.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error con los datos " + ex.Message);
                    return;
                }

                estado = chckEstado(checkEstado.Checked);

                datosEmpleados.agregarEmpleado(nombre, cedula, tanda, porcientoComision, fechaIngreso, estado);
                MessageBox.Show("Empleado Agregado");
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
            if (txtNombre.Text == "")
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
                cedula = txtCedula.Text;
            }

            if(comboTanda.Text == "")
            {
                tanda = ".";
            }

            else
            {
               tanda=comboTanda.Text;
            }

            dataEmpleados.DataSource = datosEmpleados.buscarEmpleado(nombre, cedula, tanda);
        }

        private void clientesUI_Load(object sender, EventArgs e)
        {
            comboTanda.Items.Add("Mañana");
            comboTanda.Items.Add("Tarde");
            comboTanda.Items.Add("Noche");
            fillgrid();
        }

        //Borrar
        public void borrar()
        {
            DataGridViewCell cell = dataEmpleados.SelectedCells[0] as DataGridViewCell;
            idEmpleado = (int)cell.Value; ;

            datosEmpleados.eliminarEmpleado(idEmpleado);

            MessageBox.Show("Cliente Borrado");
            clear();
            fillgrid();

        }


        private void dataClientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNombre.Text = dataEmpleados.SelectedRows[0].Cells[1].Value + string.Empty;
            txtCedula.Text = dataEmpleados.SelectedRows[0].Cells[2].Value + string.Empty;
            comboTanda.Text = dataEmpleados.SelectedRows[0].Cells[3].Value + string.Empty;
            txtComision.Text = dataEmpleados.SelectedRows[0].Cells[4].Value + string.Empty;
            dateIngreso.Text = dataEmpleados.SelectedRows[0].Cells[5].Value + string.Empty;
            estado = dataEmpleados.SelectedRows[0].Cells[6].Value + string.Empty;

            if (estado == "Verificado")
            {
                checkEstado.Checked = true;
            }
            else
            {
                checkEstado.Checked = false;
            }
        }

        private void empleadosUI_Load(object sender, EventArgs e)
        {
            fillgrid();
            comboTanda.Items.Add("Mañana");
            comboTanda.Items.Add("Tarde");
            comboTanda.Items.Add("Noche");
            comboTanda.Items.Add("");
        }

        private void dataEmpleados_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtNombre.Text = dataEmpleados.SelectedRows[0].Cells[1].Value + string.Empty;
            txtCedula.Text = dataEmpleados.SelectedRows[0].Cells[2].Value + string.Empty;
            comboTanda.Text = dataEmpleados.SelectedRows[0].Cells[3].Value + string.Empty;
            txtComision.Text = dataEmpleados.SelectedRows[0].Cells[4].Value + string.Empty;
            dateIngreso.Text = dataEmpleados.SelectedRows[0].Cells[5].Value + string.Empty;
            estado = dataEmpleados.SelectedRows[0].Cells[6].Value + string.Empty;
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
            DataGridViewCell cell = dataEmpleados.SelectedCells[0] as DataGridViewCell;
            idEmpleado = (int)cell.Value;

            cedula = txtCedula.Text;
            validaCedula(cedula);
            if (validaCedula(cedula) == true)
            {
                cedula = txtCedula.Text;
                nombre = txtNombre.Text;
                tanda = comboTanda.Text;
                fechaIngreso = dateIngreso.Value.ToString("yyyy-MM-dd");
                try
                {
                    porcientoComision = int.Parse(txtComision.Text);
                    if (porcientoComision < 0)
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

                datosEmpleados.editarEmpleado(idEmpleado, nombre, cedula, tanda, porcientoComision, fechaIngreso, estado);
                MessageBox.Show("Empleado Editado");
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
            dataEmpleados.DataSource = datosEmpleados.fillGrid();
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
