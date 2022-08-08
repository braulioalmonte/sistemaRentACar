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
using ClosedXML;
using ClosedXML.Excel;

namespace rentCarSTP.Frondend
{
    public partial class dashboardUI : Form
    {
        datosClientes datosClientes = new datosClientes();
        datosEmpleados datosEmpleados = new datosEmpleados();
        datosInspeccion datosInspeccion = new datosInspeccion();
        datosMarcas datosMarcas  = new datosMarcas();
        datosModelos datosModelos = new datosModelos();
        datosRentaDevolucion datosRentaDevolucion = new datosRentaDevolucion();
        datosTiposDeCombustible datosTiposDeCombustible = new datosTiposDeCombustible();
        datosTiposDeVehiculos datosTiposDeVehiculos = new datosTiposDeVehiculos();
        datosVehiculos datosVehiculos = new datosVehiculos();


        public dashboardUI(string nombreUsuario)
        {
            InitializeComponent();
            labelUsuario.Text = "Bienvenido\n" + nombreUsuario;
            
        }

        private void btnTiposDeVehiculos_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            { 
                if (Application.OpenForms[i].Name != "frmLogin")
                {
                    if (Application.OpenForms[i].Name != "dashboardUI")
                    {
                        if (Application.OpenForms[i].Name != "TiposDeVehiculosUI")
                        {
                            Application.OpenForms[i].Close();
                        }
                    }
                }
                    

            }
            //Esta funcion evita que se abra mas de una ventana del mismo tipo
            TiposDeVehiculosUI tiposDeVehiculos = new TiposDeVehiculosUI();
            int formcount = Application.OpenForms.OfType<TiposDeVehiculosUI>().Count();
            if (formcount < 1)
            {
                tiposDeVehiculos.Show();
            }

            tiposDeVehiculos.StartPosition = FormStartPosition.Manual;
            tiposDeVehiculos.Location = new Point(395, 230);
        }

        private void btnTipoDeCombustible_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frmLogin")
                {
                    if (Application.OpenForms[i].Name != "dashboardUI")
                    {
                        if (Application.OpenForms[i].Name != "TiposDeCombustibleUI")
                        {
                            Application.OpenForms[i].Close();
                        }
                    }
                }
            }
            //Esta funcion evita que se abra mas de una ventana del mismo tipo
            TiposDeCombustibleUI tiposDeCombustible = new TiposDeCombustibleUI();
            int libroscount = Application.OpenForms.OfType<TiposDeVehiculosUI>().Count();
            if (libroscount < 1)
            {
                tiposDeCombustible.Show();
            }

            tiposDeCombustible.StartPosition = FormStartPosition.Manual;
            tiposDeCombustible.Location = new Point(395, 230);
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frmLogin")
                {
                    if (Application.OpenForms[i].Name != "dashboardUI")
                    {
                        if (Application.OpenForms[i].Name != "marcasUI")
                        {
                            Application.OpenForms[i].Close();
                        }
                    }
                }
            }
            //Esta funcion evita que se abra mas de una ventana del mismo tipo
            marcasUI marcas = new marcasUI();
            int libroscount = Application.OpenForms.OfType<TiposDeVehiculosUI>().Count();
            if (libroscount < 1)
            {
                marcas.Show();
            }

            marcas.StartPosition = FormStartPosition.Manual;
            marcas.Location = new Point(395, 230);
        }

        private void btnModelos_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frmLogin")
                {
                    if (Application.OpenForms[i].Name != "dashboardUI")
                    {
                        if (Application.OpenForms[i].Name != "modelosUI")
                        {
                            Application.OpenForms[i].Close();
                        }
                    }
                }
            }
            //Esta funcion evita que se abra mas de una ventana del mismo tipo
            modelosUI modelos = new modelosUI();
            int libroscount = Application.OpenForms.OfType<TiposDeVehiculosUI>().Count();
            if (libroscount < 1)
            {
                modelos.Show();
            }

            modelos.StartPosition = FormStartPosition.Manual;
            modelos.Location = new Point(395, 230);
        }


        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frmLogin")
                {
                    if (Application.OpenForms[i].Name != "dashboardUI")
                    {
                        if (Application.OpenForms[i].Name != "VehiculosUI")
                        {
                            Application.OpenForms[i].Close();
                        }
                    }
                }
            }
            //Esta funcion evita que se abra mas de una ventana del mismo tipo
            VehiculosUI vehiculos = new VehiculosUI();
            int libroscount = Application.OpenForms.OfType<TiposDeVehiculosUI>().Count();
            if (libroscount < 1)
            {
                vehiculos.Show();
            }

            vehiculos.StartPosition = FormStartPosition.Manual;
            vehiculos.Location = new Point(395, 230);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frmLogin")
                {
                    if (Application.OpenForms[i].Name != "dashboardUI")
                    {
                        if (Application.OpenForms[i].Name != "clientesUI")
                        {
                            Application.OpenForms[i].Close();
                        }
                    }
                }
            }
            //Esta funcion evita que se abra mas de una ventana del mismo tipo
            clientesUI clientes = new clientesUI();
            int libroscount = Application.OpenForms.OfType<TiposDeVehiculosUI>().Count();
            if (libroscount < 1)
            {
                clientes.Show();
            }

            clientes.StartPosition = FormStartPosition.Manual;
            clientes.Location = new Point(395, 230);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frmLogin")
                {
                    if (Application.OpenForms[i].Name != "dashboardUI")
                    {
                        if (Application.OpenForms[i].Name != "empleadosUI")
                        {
                            Application.OpenForms[i].Close();
                        }
                    }
                }
            }
            //Esta funcion evita que se abra mas de una ventana del mismo tipo
            empleadosUI empleados = new empleadosUI();
            int libroscount = Application.OpenForms.OfType<TiposDeVehiculosUI>().Count();
            if (libroscount < 1)
            {
                empleados.Show();
            }

            empleados.StartPosition = FormStartPosition.Manual;
            empleados.Location = new Point(395, 230);
        }

        private void btnInspeccion_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frmLogin")
                {
                    if (Application.OpenForms[i].Name != "dashboardUI")
                    {
                        if (Application.OpenForms[i].Name != "inspeccionUI")
                        {
                            Application.OpenForms[i].Close();
                        }
                    }
                }
            }
            //Esta funcion evita que se abra mas de una ventana del mismo tipo
            inspeccionUI inspeccion = new inspeccionUI();
            int libroscount = Application.OpenForms.OfType<TiposDeVehiculosUI>().Count();
            if (libroscount < 1)
            {
                inspeccion.Show();
            }

            inspeccion.StartPosition = FormStartPosition.Manual;
            inspeccion.Location = new Point(370, 93);
        }

        private void btnRentaDevolucion_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "frmLogin")
                {
                    if (Application.OpenForms[i].Name != "dashboardUI")
                    {
                        if (Application.OpenForms[i].Name != "rentaDevolucionUI")
                        {
                            Application.OpenForms[i].Close();
                        }
                    }
                }
            }
            //Esta funcion evita que se abra mas de una ventana del mismo tipo
            rentaDevolucionUI rentaDevolucion = new rentaDevolucionUI();
            int libroscount = Application.OpenForms.OfType<TiposDeVehiculosUI>().Count();
            if (libroscount < 1)
            {
                rentaDevolucion.Show();
            }

            rentaDevolucion.StartPosition = FormStartPosition.Manual;
            rentaDevolucion.Location = new Point(395, 230);
        }

        private void dashboardUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            XLWorkbook wb = new XLWorkbook();
            DataTable clientes = datosClientes.fillGrid();
            DataTable empleados = datosEmpleados.fillGrid();
            DataTable inspeccion = datosInspeccion.fillGrid();
            DataTable marcas = datosMarcas.fillGrid();
            DataTable modelos = datosModelos.fillGrid();
            DataTable rentaDevolucion = datosRentaDevolucion.fillGrid();
            DataTable tiposCombustibles = datosTiposDeCombustible.fillGrid();
            DataTable tiposVehiculos = datosTiposDeVehiculos.fillGrid();
            DataTable vehiculos = datosVehiculos.fillGrid();

            
            wb.Worksheets.Add(clientes, "Clientes");
            wb.Worksheets.Add(empleados, "Empleados");
            wb.Worksheets.Add(inspeccion, "Inspecciones");
            wb.Worksheets.Add(marcas, "Marcas");
            wb.Worksheets.Add(modelos, "Modelos");
            wb.Worksheets.Add(rentaDevolucion, "RentaDevolucion");
            wb.Worksheets.Add(tiposCombustibles, "Tipos de Combustibles");
            wb.Worksheets.Add(tiposVehiculos, "Tipos de Vehiculos");
            wb.Worksheets.Add(vehiculos, "Vehiculos");

            var saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel files|*.xlsx",
                Title = "Save an Excel File"
            };

            saveFileDialog.ShowDialog();

            if (!String.IsNullOrWhiteSpace(saveFileDialog.FileName))
                wb.SaveAs(saveFileDialog.FileName);
        }
    }
}
