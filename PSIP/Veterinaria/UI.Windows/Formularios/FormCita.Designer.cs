namespace UI.Windows.Formularios
{
    partial class FormCita
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MascotaCB = new System.Windows.Forms.ComboBox();
            this.DueñoCB = new System.Windows.Forms.ComboBox();
            this.Guardar_Especialista = new System.Windows.Forms.Button();
            this.citaBindingSource = new System.Windows.Forms.BindingSource(this.components);

            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServicioCB = new System.Windows.Forms.ComboBox();
            this.EspecialistaCB = new System.Windows.Forms.ComboBox();
            this.Fecha_CitaTXT = new System.Windows.Forms.TextBox();
            this.HORATXT = new System.Windows.Forms.TextBox();

            this.idAnimal = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnselec = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IDCitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCita = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDAnimal1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEspecialistaC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDServicioD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingSource)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // MascotaCB
            // 
            this.MascotaCB.FormattingEnabled = true;
            this.MascotaCB.Location = new System.Drawing.Point(97, 39);
            this.MascotaCB.Name = "MascotaCB";
            this.MascotaCB.Size = new System.Drawing.Size(170, 21);
            this.MascotaCB.TabIndex = 57;
            this.MascotaCB.SelectedIndexChanged += new System.EventHandler(this.MascotaCB_SelectedIndexChanged);
            // 
            // DueñoCB
            // 
            this.DueñoCB.FormattingEnabled = true;
            this.DueñoCB.Location = new System.Drawing.Point(97, 12);
            this.DueñoCB.Name = "DueñoCB";
            this.DueñoCB.Size = new System.Drawing.Size(170, 21);
            this.DueñoCB.TabIndex = 56;
            this.DueñoCB.SelectedIndexChanged += new System.EventHandler(this.DueñoCB_SelectedIndexChanged);
            // 
            // Guardar_Especialista
            // 
            this.Guardar_Especialista.Location = new System.Drawing.Point(22, 183);
            this.Guardar_Especialista.Name = "Guardar_Especialista";
            this.Guardar_Especialista.Size = new System.Drawing.Size(245, 28);
            this.Guardar_Especialista.TabIndex = 55;
            this.Guardar_Especialista.Text = "Guardar";
            this.Guardar_Especialista.UseVisualStyleBackColor = true;
            this.Guardar_Especialista.Click += new System.EventHandler(this.Guardar_Especialista_Click);
            // 
            // citaBindingSource
            // 
            this.citaBindingSource.DataMember = "Cita";

            // 
            // veterinaria_FinalDataSet2
            // 

            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "Hora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Especialista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Servicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mascota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Dueño";
            // 
            // ServicioCB
            // 
            this.ServicioCB.FormattingEnabled = true;
            this.ServicioCB.Location = new System.Drawing.Point(97, 67);
            this.ServicioCB.Name = "ServicioCB";
            this.ServicioCB.Size = new System.Drawing.Size(170, 21);
            this.ServicioCB.TabIndex = 58;
            this.ServicioCB.SelectedIndexChanged += new System.EventHandler(this.ServicioCB_SelectedIndexChanged);
            // 
            // EspecialistaCB
            // 
            this.EspecialistaCB.FormattingEnabled = true;
            this.EspecialistaCB.Location = new System.Drawing.Point(97, 94);
            this.EspecialistaCB.Name = "EspecialistaCB";
            this.EspecialistaCB.Size = new System.Drawing.Size(170, 21);
            this.EspecialistaCB.TabIndex = 59;
            this.EspecialistaCB.SelectedIndexChanged += new System.EventHandler(this.EspecialistaCB_SelectedIndexChanged);
            // 
            // Fecha_CitaTXT
            // 
            this.Fecha_CitaTXT.Location = new System.Drawing.Point(97, 121);
            this.Fecha_CitaTXT.Name = "Fecha_CitaTXT";
            this.Fecha_CitaTXT.Size = new System.Drawing.Size(170, 20);
            this.Fecha_CitaTXT.TabIndex = 60;
            // 
            // HORATXT
            // 
            this.HORATXT.Location = new System.Drawing.Point(97, 147);
            this.HORATXT.Name = "HORATXT";
            this.HORATXT.Size = new System.Drawing.Size(170, 20);
            this.HORATXT.TabIndex = 61;
            this.HORATXT.TextChanged += new System.EventHandler(this.HORATXT_TextChanged);
            // 
            // citaTableAdapter
            // 

            // 
            // idAnimal
            // 
            this.idAnimal.Location = new System.Drawing.Point(55, 145);
            this.idAnimal.Name = "idAnimal";
            this.idAnimal.Size = new System.Drawing.Size(42, 20);
            this.idAnimal.TabIndex = 64;
            this.idAnimal.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 42;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnselec,
            this.IDCitas,
            this.fechaCita,
            this.iDAnimal1,
            this.iDEspecialistaC,
            this.iDServicioD,
            this.fechaHora,
            this.iDDueño,
            this.EstadoC});
            this.dataGridView1.DataSource = this.citaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(282, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(425, 267);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnselec
            // 
            this.btnselec.FillWeight = 40.60914F;
            this.btnselec.HeaderText = "";
            this.btnselec.Name = "btnselec";
            this.btnselec.ReadOnly = true;
            // 
            // IDCitas
            // 
            this.IDCitas.DataPropertyName = "ID_Citas";
            this.IDCitas.FillWeight = 108.4844F;
            this.IDCitas.HeaderText = "ID Cita";
            this.IDCitas.Name = "IDCitas";
            this.IDCitas.ReadOnly = true;
            // 
            // fechaCita
            // 
            this.fechaCita.DataPropertyName = "Fecha_Cita";
            this.fechaCita.FillWeight = 108.4844F;
            this.fechaCita.HeaderText = "Fecha Cita";
            this.fechaCita.Name = "fechaCita";
            this.fechaCita.ReadOnly = true;
            // 
            // iDAnimal1
            // 
            this.iDAnimal1.DataPropertyName = "ID_Animal";
            this.iDAnimal1.FillWeight = 108.4844F;
            this.iDAnimal1.HeaderText = "ID Animal";
            this.iDAnimal1.Name = "iDAnimal1";
            this.iDAnimal1.ReadOnly = true;
            // 
            // iDEspecialistaC
            // 
            this.iDEspecialistaC.DataPropertyName = "ID_Especialista_Cedula";
            this.iDEspecialistaC.FillWeight = 108.4844F;
            this.iDEspecialistaC.HeaderText = "ID Especialista Cedula";
            this.iDEspecialistaC.Name = "iDEspecialistaC";
            this.iDEspecialistaC.ReadOnly = true;
            // 
            // iDServicioD
            // 
            this.iDServicioD.DataPropertyName = "ID_Servicio";
            this.iDServicioD.FillWeight = 108.4844F;
            this.iDServicioD.HeaderText = "ID Servicio";
            this.iDServicioD.Name = "iDServicioD";
            this.iDServicioD.ReadOnly = true;
            // 
            // fechaHora
            // 
            this.fechaHora.DataPropertyName = "Fecha_Hora";
            this.fechaHora.FillWeight = 108.4844F;
            this.fechaHora.HeaderText = "Fecha Hora";
            this.fechaHora.Name = "fechaHora";
            this.fechaHora.ReadOnly = true;
            // 
            // iDDueño
            // 
            this.iDDueño.DataPropertyName = "ID_Dueño_Cedula";
            this.iDDueño.FillWeight = 108.4844F;
            this.iDDueño.HeaderText = "Dueño Cedula";
            this.iDDueño.Name = "iDDueño";
            this.iDDueño.ReadOnly = true;
            // 
            // EstadoC
            // 
            this.EstadoC.DataPropertyName = "Est_Cita";
            this.EstadoC.HeaderText = "Estado Cita";
            this.EstadoC.Name = "EstadoC";
            this.EstadoC.ReadOnly = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(22, 217);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(245, 28);
            this.btnModificar.TabIndex = 65;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(22, 251);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(245, 28);
            this.btnBorrar.TabIndex = 66;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // FormCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(719, 290);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.idAnimal);
            this.Controls.Add(this.HORATXT);
            this.Controls.Add(this.Fecha_CitaTXT);
            this.Controls.Add(this.EspecialistaCB);
            this.Controls.Add(this.ServicioCB);
            this.Controls.Add(this.MascotaCB);
            this.Controls.Add(this.DueñoCB);
            this.Controls.Add(this.Guardar_Especialista);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCita";
            this.Text = "FormCita";
            this.Load += new System.EventHandler(this.FormCita_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citaBindingSource)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox MascotaCB;
        private System.Windows.Forms.ComboBox DueñoCB;
        private System.Windows.Forms.Button Guardar_Especialista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ServicioCB;
        private System.Windows.Forms.ComboBox EspecialistaCB;
        private System.Windows.Forms.TextBox Fecha_CitaTXT;
        private System.Windows.Forms.TextBox HORATXT;

        private System.Windows.Forms.BindingSource citaBindingSource;

        private System.Windows.Forms.TextBox idAnimal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn btnselec;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCita;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAnimal1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEspecialistaC;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDServicioD;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoC;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
    }
}