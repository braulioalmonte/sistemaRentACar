namespace rentCarSTP.Frondend
{
    partial class empleadosUI
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.dateIngreso = new System.Windows.Forms.DateTimePicker();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.dataEmpleados = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.comboTanda = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleados)).BeginInit();
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
            this.btnAgregar.Location = new System.Drawing.Point(12, 112);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 94);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 212);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 94);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 312);
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
            this.label1.Location = new System.Drawing.Point(121, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(121, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cédula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(121, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tanda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(121, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Porciento Comisión";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(121, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha Ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(121, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Estado";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(121, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 27);
            this.txtNombre.TabIndex = 10;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(121, 98);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(125, 27);
            this.txtCedula.TabIndex = 11;
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(121, 224);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(125, 27);
            this.txtComision.TabIndex = 13;
            // 
            // dateIngreso
            // 
            this.dateIngreso.CustomFormat = "";
            this.dateIngreso.Location = new System.Drawing.Point(121, 287);
            this.dateIngreso.Name = "dateIngreso";
            this.dateIngreso.Size = new System.Drawing.Size(250, 27);
            this.dateIngreso.TabIndex = 14;
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(121, 348);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(103, 24);
            this.checkEstado.TabIndex = 15;
            this.checkEstado.Text = "Disponible";
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // dataEmpleados
            // 
            this.dataEmpleados.AllowUserToAddRows = false;
            this.dataEmpleados.AllowUserToDeleteRows = false;
            this.dataEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEmpleados.Location = new System.Drawing.Point(394, 12);
            this.dataEmpleados.Name = "dataEmpleados";
            this.dataEmpleados.ReadOnly = true;
            this.dataEmpleados.RowHeadersWidth = 51;
            this.dataEmpleados.RowTemplate.Height = 29;
            this.dataEmpleados.Size = new System.Drawing.Size(1001, 426);
            this.dataEmpleados.TabIndex = 16;
            this.dataEmpleados.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataEmpleados_RowHeaderMouseClick);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(12, 412);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(94, 29);
            this.btnRefrescar.TabIndex = 17;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // comboTanda
            // 
            this.comboTanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTanda.FormattingEnabled = true;
            this.comboTanda.Location = new System.Drawing.Point(121, 161);
            this.comboTanda.Name = "comboTanda";
            this.comboTanda.Size = new System.Drawing.Size(151, 28);
            this.comboTanda.TabIndex = 18;
            // 
            // empleadosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 450);
            this.Controls.Add(this.comboTanda);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dataEmpleados);
            this.Controls.Add(this.checkEstado);
            this.Controls.Add(this.dateIngreso);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombre);
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
            this.Name = "empleadosUI";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.empleadosUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEmpleados)).EndInit();
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
        private TextBox txtNombre;
        private TextBox txtCedula;
        private TextBox txtComision;
        private DateTimePicker dateIngreso;
        private CheckBox checkEstado;
        private DataGridView dataEmpleados;
        private Button btnRefrescar;
        private ComboBox comboTanda;
    }
}