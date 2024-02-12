namespace UI.Windows.Formularios
{
    partial class FormServicios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Guardar_Servicio = new System.Windows.Forms.Button();
            this.dtgServicios = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Des_Serviciotxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Nom_Serviciotxt = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // Guardar_Servicio
            // 
            this.Guardar_Servicio.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.Guardar_Servicio.Location = new System.Drawing.Point(172, 80);
            this.Guardar_Servicio.Name = "Guardar_Servicio";
            this.Guardar_Servicio.Size = new System.Drawing.Size(136, 28);
            this.Guardar_Servicio.TabIndex = 27;
            this.Guardar_Servicio.Text = "Guardar";
            this.Guardar_Servicio.UseVisualStyleBackColor = true;
            this.Guardar_Servicio.Click += new System.EventHandler(this.Guardar_Especialista_Click);
            // 
            // dtgServicios
            // 
            this.dtgServicios.AllowUserToAddRows = false;
            this.dtgServicios.AllowUserToDeleteRows = false;
            this.dtgServicios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgServicios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgServicios.ColumnHeadersHeight = 38;
            this.dtgServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id_servicio,
            this.nombre,
            this.descripcion});
            this.dtgServicios.Location = new System.Drawing.Point(13, 135);
            this.dtgServicios.Name = "dtgServicios";
            this.dtgServicios.ReadOnly = true;
            this.dtgServicios.RowHeadersWidth = 62;
            this.dtgServicios.Size = new System.Drawing.Size(750, 329);
            this.dtgServicios.TabIndex = 26;
            this.dtgServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dtgServicios.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgServicios_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnSeleccionar.FillWeight = 25.38071F;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 35;
            // 
            // id_servicio
            // 
            this.id_servicio.HeaderText = "ID";
            this.id_servicio.Name = "id_servicio";
            this.id_servicio.ReadOnly = true;
            this.id_servicio.Visible = false;
            // 
            // nombre
            // 
            this.nombre.FillWeight = 118.6548F;
            this.nombre.HeaderText = "Nombre Servicio";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripcion Servicio";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.label2.Location = new System.Drawing.Point(376, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Descripción";
            // 
            // Des_Serviciotxt
            // 
            this.Des_Serviciotxt.Location = new System.Drawing.Point(455, 41);
            this.Des_Serviciotxt.Name = "Des_Serviciotxt";
            this.Des_Serviciotxt.Size = new System.Drawing.Size(276, 20);
            this.Des_Serviciotxt.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre Servicio";
            // 
            // Nom_Serviciotxt
            // 
            this.Nom_Serviciotxt.Location = new System.Drawing.Point(151, 41);
            this.Nom_Serviciotxt.Name = "Nom_Serviciotxt";
            this.Nom_Serviciotxt.Size = new System.Drawing.Size(197, 20);
            this.Nom_Serviciotxt.TabIndex = 14;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.btnBorrar.Location = new System.Drawing.Point(509, 80);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(136, 28);
            this.btnBorrar.TabIndex = 68;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.btnModificar.Location = new System.Drawing.Point(342, 80);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 28);
            this.btnModificar.TabIndex = 67;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(49, 88);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(26, 20);
            this.txtId.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F);
            this.label3.Location = new System.Drawing.Point(13, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(750, 119);
            this.label3.TabIndex = 70;
            this.label3.Text = "Servicios";
            // 
            // FormServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(775, 476);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.Guardar_Servicio);
            this.Controls.Add(this.dtgServicios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Des_Serviciotxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nom_Serviciotxt);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormServicios";
            this.Text = "FormServicios";
            this.Load += new System.EventHandler(this.FormServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgServicios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar_Servicio;
        private System.Windows.Forms.DataGridView dtgServicios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Des_Serviciotxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nom_Serviciotxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreS;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionS;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
    }
}