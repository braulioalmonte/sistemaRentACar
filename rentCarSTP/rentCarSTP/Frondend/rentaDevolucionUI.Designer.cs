namespace rentCarSTP.Frondend
{
    partial class rentaDevolucionUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboEmpleado = new System.Windows.Forms.ComboBox();
            this.comboVehiculo = new System.Windows.Forms.ComboBox();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.dateRenta = new System.Windows.Forms.DateTimePicker();
            this.dateDevolucion = new System.Windows.Forms.DateTimePicker();
            this.txtMontoXDia = new System.Windows.Forms.TextBox();
            this.rTxtComentario = new System.Windows.Forms.RichTextBox();
            this.dataRentaDevolucion = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.txtCantidadDias = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataRentaDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 94);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 108);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 94);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(12, 204);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(94, 94);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 300);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 94);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vehiculo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(112, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(112, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Renta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(112, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Devolución";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(112, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Monto Por Día";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(112, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Comentario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(113, 618);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Estado";
            // 
            // comboEmpleado
            // 
            this.comboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmpleado.FormattingEnabled = true;
            this.comboEmpleado.Location = new System.Drawing.Point(112, 35);
            this.comboEmpleado.Name = "comboEmpleado";
            this.comboEmpleado.Size = new System.Drawing.Size(151, 28);
            this.comboEmpleado.TabIndex = 13;
            // 
            // comboVehiculo
            // 
            this.comboVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVehiculo.FormattingEnabled = true;
            this.comboVehiculo.Location = new System.Drawing.Point(112, 100);
            this.comboVehiculo.Name = "comboVehiculo";
            this.comboVehiculo.Size = new System.Drawing.Size(151, 28);
            this.comboVehiculo.TabIndex = 14;
            // 
            // comboCliente
            // 
            this.comboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(112, 165);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(151, 28);
            this.comboCliente.TabIndex = 15;
            // 
            // dateRenta
            // 
            this.dateRenta.Location = new System.Drawing.Point(112, 230);
            this.dateRenta.Name = "dateRenta";
            this.dateRenta.Size = new System.Drawing.Size(250, 27);
            this.dateRenta.TabIndex = 16;
            this.dateRenta.ValueChanged += new System.EventHandler(this.dateRenta_ValueChanged);
            // 
            // dateDevolucion
            // 
            this.dateDevolucion.Location = new System.Drawing.Point(112, 295);
            this.dateDevolucion.Name = "dateDevolucion";
            this.dateDevolucion.Size = new System.Drawing.Size(250, 27);
            this.dateDevolucion.TabIndex = 17;
            this.dateDevolucion.ValueChanged += new System.EventHandler(this.dateDevolucion_ValueChanged);
            // 
            // txtMontoXDia
            // 
            this.txtMontoXDia.Location = new System.Drawing.Point(113, 360);
            this.txtMontoXDia.Name = "txtMontoXDia";
            this.txtMontoXDia.Size = new System.Drawing.Size(125, 27);
            this.txtMontoXDia.TabIndex = 18;
            // 
            // rTxtComentario
            // 
            this.rTxtComentario.Location = new System.Drawing.Point(113, 481);
            this.rTxtComentario.Name = "rTxtComentario";
            this.rTxtComentario.Size = new System.Drawing.Size(239, 120);
            this.rTxtComentario.TabIndex = 19;
            this.rTxtComentario.Text = "";
            // 
            // dataRentaDevolucion
            // 
            this.dataRentaDevolucion.AllowUserToAddRows = false;
            this.dataRentaDevolucion.AllowUserToDeleteRows = false;
            this.dataRentaDevolucion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataRentaDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRentaDevolucion.Location = new System.Drawing.Point(368, 5);
            this.dataRentaDevolucion.Name = "dataRentaDevolucion";
            this.dataRentaDevolucion.ReadOnly = true;
            this.dataRentaDevolucion.RowHeadersWidth = 51;
            this.dataRentaDevolucion.RowTemplate.Height = 29;
            this.dataRentaDevolucion.Size = new System.Drawing.Size(1067, 673);
            this.dataRentaDevolucion.TabIndex = 21;
            this.dataRentaDevolucion.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(12, 400);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(94, 29);
            this.btnRefrescar.TabIndex = 22;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Location = new System.Drawing.Point(114, 423);
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.ReadOnly = true;
            this.txtCantidadDias.Size = new System.Drawing.Size(125, 27);
            this.txtCantidadDias.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(113, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Cantidad Días";
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(112, 641);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(91, 24);
            this.checkEstado.TabIndex = 27;
            this.checkEstado.Text = "Devuelto";
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // rentaDevolucionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 690);
            this.Controls.Add(this.checkEstado);
            this.Controls.Add(this.txtCantidadDias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dataRentaDevolucion);
            this.Controls.Add(this.rTxtComentario);
            this.Controls.Add(this.txtMontoXDia);
            this.Controls.Add(this.dateDevolucion);
            this.Controls.Add(this.dateRenta);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.comboVehiculo);
            this.Controls.Add(this.comboEmpleado);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "rentaDevolucionUI";
            this.Text = "Renta/Devolución";
            this.Load += new System.EventHandler(this.rentaDevolucionUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRentaDevolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnEditar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label9;
        private ComboBox comboEmpleado;
        private ComboBox comboVehiculo;
        private ComboBox comboCliente;
        private DateTimePicker dateRenta;
        private DateTimePicker dateDevolucion;
        private TextBox txtMontoXDia;
        private RichTextBox rTxtComentario;
        private DataGridView dataRentaDevolucion;
        private Button btnRefrescar;
        private TextBox txtCantidadDias;
        private Label label7;
        private CheckBox checkEstado;
    }
}