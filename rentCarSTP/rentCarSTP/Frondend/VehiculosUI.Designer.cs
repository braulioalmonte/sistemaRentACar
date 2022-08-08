namespace rentCarSTP.Frondend
{
    partial class VehiculosUI
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtChasis = new System.Windows.Forms.TextBox();
            this.txtMotor = new System.Windows.Forms.TextBox();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.comboTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.comboTipoDeCombustible = new System.Windows.Forms.ComboBox();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.dataVehiculos = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 9);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 94);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 109);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 94);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 209);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 94);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 309);
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
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "No. Chasis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(112, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "No. Motor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(112, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "No. Placa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(112, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de Vehiculo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(112, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Modelo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(112, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tipo de Combustible";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(112, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Marca";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(112, 505);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Estado";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(112, 32);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(151, 27);
            this.txtDesc.TabIndex = 13;
            // 
            // txtChasis
            // 
            this.txtChasis.Location = new System.Drawing.Point(112, 94);
            this.txtChasis.Name = "txtChasis";
            this.txtChasis.Size = new System.Drawing.Size(151, 27);
            this.txtChasis.TabIndex = 14;
            // 
            // txtMotor
            // 
            this.txtMotor.Location = new System.Drawing.Point(112, 156);
            this.txtMotor.Name = "txtMotor";
            this.txtMotor.Size = new System.Drawing.Size(151, 27);
            this.txtMotor.TabIndex = 15;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(112, 218);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(151, 27);
            this.txtPlaca.TabIndex = 16;
            // 
            // comboTipoVehiculo
            // 
            this.comboTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoVehiculo.FormattingEnabled = true;
            this.comboTipoVehiculo.Location = new System.Drawing.Point(112, 280);
            this.comboTipoVehiculo.Name = "comboTipoVehiculo";
            this.comboTipoVehiculo.Size = new System.Drawing.Size(151, 28);
            this.comboTipoVehiculo.TabIndex = 17;
            // 
            // comboMarca
            // 
            this.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(112, 343);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(151, 28);
            this.comboMarca.TabIndex = 18;
            // 
            // comboModelo
            // 
            this.comboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(112, 404);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(151, 28);
            this.comboModelo.TabIndex = 19;
            // 
            // comboTipoDeCombustible
            // 
            this.comboTipoDeCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoDeCombustible.FormattingEnabled = true;
            this.comboTipoDeCombustible.Location = new System.Drawing.Point(112, 466);
            this.comboTipoDeCombustible.Name = "comboTipoDeCombustible";
            this.comboTipoDeCombustible.Size = new System.Drawing.Size(151, 28);
            this.comboTipoDeCombustible.TabIndex = 20;
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(112, 537);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(103, 24);
            this.checkEstado.TabIndex = 21;
            this.checkEstado.Text = "Disponible";
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // dataVehiculos
            // 
            this.dataVehiculos.AllowUserToAddRows = false;
            this.dataVehiculos.AllowUserToDeleteRows = false;
            this.dataVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVehiculos.Location = new System.Drawing.Point(269, 12);
            this.dataVehiculos.Name = "dataVehiculos";
            this.dataVehiculos.ReadOnly = true;
            this.dataVehiculos.RowHeadersWidth = 51;
            this.dataVehiculos.RowTemplate.Height = 29;
            this.dataVehiculos.Size = new System.Drawing.Size(1058, 558);
            this.dataVehiculos.TabIndex = 22;
            this.dataVehiculos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataVehiculos_RowHeaderMouseClick);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(12, 409);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(94, 29);
            this.btnRefrescar.TabIndex = 23;
            this.btnRefrescar.Text = "Refresar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // VehiculosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1339, 582);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dataVehiculos);
            this.Controls.Add(this.checkEstado);
            this.Controls.Add(this.comboTipoDeCombustible);
            this.Controls.Add(this.comboModelo);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.comboTipoVehiculo);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.txtMotor);
            this.Controls.Add(this.txtChasis);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "VehiculosUI";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.VehiculosUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnEditar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtDesc;
        private TextBox txtChasis;
        private TextBox txtMotor;
        private TextBox txtPlaca;
        private ComboBox comboTipoVehiculo;
        private ComboBox comboMarca;
        private ComboBox comboModelo;
        private ComboBox comboTipoDeCombustible;
        private CheckBox checkEstado;
        private DataGridView dataVehiculos;
        private Button btnRefrescar;
    }
}