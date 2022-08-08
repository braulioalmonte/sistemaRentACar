namespace rentCarSTP.Frondend
{
    partial class TiposDeCombustibleUI
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
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.dataTiposDeCombustibles = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTiposDeCombustibles)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 94);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 110);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 94);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 210);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 94);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 310);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(94, 94);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(112, 35);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(125, 27);
            this.txtDesc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estado";
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(112, 110);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(103, 24);
            this.checkEstado.TabIndex = 7;
            this.checkEstado.Text = "Disponible";
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // dataTiposDeCombustibles
            // 
            this.dataTiposDeCombustibles.AllowUserToAddRows = false;
            this.dataTiposDeCombustibles.AllowUserToDeleteRows = false;
            this.dataTiposDeCombustibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTiposDeCombustibles.Location = new System.Drawing.Point(290, 12);
            this.dataTiposDeCombustibles.Name = "dataTiposDeCombustibles";
            this.dataTiposDeCombustibles.ReadOnly = true;
            this.dataTiposDeCombustibles.RowHeadersWidth = 51;
            this.dataTiposDeCombustibles.RowTemplate.Height = 29;
            this.dataTiposDeCombustibles.Size = new System.Drawing.Size(667, 426);
            this.dataTiposDeCombustibles.TabIndex = 8;
            this.dataTiposDeCombustibles.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataTiposDeCombustibles_RowHeaderMouseClick);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(12, 410);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(94, 29);
            this.btnRefrescar.TabIndex = 9;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // TiposDeCombustibleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dataTiposDeCombustibles);
            this.Controls.Add(this.checkEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "TiposDeCombustibleUI";
            this.Text = "Tipos de Combustible";
            this.Load += new System.EventHandler(this.TiposDeCombustibleUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTiposDeCombustibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBuscar;
        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnEditar;
        private TextBox txtDesc;
        private Label label1;
        private Label label2;
        private CheckBox checkEstado;
        private DataGridView dataTiposDeCombustibles;
        private Button btnRefrescar;
    }
}