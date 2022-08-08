namespace rentCarSTP.Frondend
{
    partial class marcasUI
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.dataMarca = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 112);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 94);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 212);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(94, 94);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 94);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // dataMarca
            // 
            this.dataMarca.AllowUserToAddRows = false;
            this.dataMarca.AllowUserToDeleteRows = false;
            this.dataMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMarca.Location = new System.Drawing.Point(317, 12);
            this.dataMarca.Name = "dataMarca";
            this.dataMarca.ReadOnly = true;
            this.dataMarca.RowHeadersWidth = 51;
            this.dataMarca.RowTemplate.Height = 29;
            this.dataMarca.Size = new System.Drawing.Size(698, 426);
            this.dataMarca.TabIndex = 4;
            this.dataMarca.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataMarca_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descripción";
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Location = new System.Drawing.Point(112, 109);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(103, 24);
            this.checkEstado.TabIndex = 6;
            this.checkEstado.Text = "Disponible";
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Estado";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(112, 46);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(200, 27);
            this.txtDesc.TabIndex = 8;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(12, 412);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(94, 29);
            this.btnRefrescar.TabIndex = 9;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // marcasUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 450);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataMarca);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "marcasUI";
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.marcasUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAgregar;
        private Button btnBorrar;
        private Button btnBuscar;
        private Button btnEditar;
        private DataGridView dataMarca;
        private Label label1;
        private CheckBox checkEstado;
        private Label label2;
        private TextBox txtDesc;
        private Button btnRefrescar;
    }
}