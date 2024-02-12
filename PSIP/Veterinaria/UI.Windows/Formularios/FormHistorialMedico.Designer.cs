namespace UI.Windows.Formularios
{
    partial class FormHistorialMedico
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
            this.dtgHistorial = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_historial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DueñoCB = new System.Windows.Forms.ComboBox();
            this.MascotaCB = new System.Windows.Forms.ComboBox();
            this.Fecha_HistoriaTXT = new System.Windows.Forms.TextBox();
            this.DiagnosticoTXT = new System.Windows.Forms.TextBox();
            this.TratamientoTXT = new System.Windows.Forms.TextBox();
            this.ObservacionesTXT = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.idAnimal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Guardar_Especialista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgHistorial
            // 
            this.dtgHistorial.AllowUserToAddRows = false;
            this.dtgHistorial.AllowUserToDeleteRows = false;
            this.dtgHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHistorial.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgHistorial.ColumnHeadersHeight = 30;
            this.dtgHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id_historial,
            this.dueño,
            this.mascota,
            this.fecha,
            this.diagnostico,
            this.tratamiento,
            this.observacion});
            this.dtgHistorial.Location = new System.Drawing.Point(12, 304);
            this.dtgHistorial.Name = "dtgHistorial";
            this.dtgHistorial.ReadOnly = true;
            this.dtgHistorial.RowHeadersWidth = 62;
            this.dtgHistorial.Size = new System.Drawing.Size(751, 160);
            this.dtgHistorial.TabIndex = 40;
            this.dtgHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dtgHistorial.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dtgHistorial_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnSeleccionar.FillWeight = 45.68528F;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            this.btnSeleccionar.Width = 35;
            // 
            // id_historial
            // 
            this.id_historial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_historial.FillWeight = 106.7893F;
            this.id_historial.HeaderText = "ID";
            this.id_historial.Name = "id_historial";
            this.id_historial.ReadOnly = true;
            this.id_historial.Visible = false;
            this.id_historial.Width = 35;
            // 
            // dueño
            // 
            this.dueño.HeaderText = "Dueño";
            this.dueño.Name = "dueño";
            this.dueño.ReadOnly = true;
            // 
            // mascota
            // 
            this.mascota.HeaderText = "Mascota";
            this.mascota.Name = "mascota";
            this.mascota.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // diagnostico
            // 
            this.diagnostico.HeaderText = "Diagnostico";
            this.diagnostico.Name = "diagnostico";
            this.diagnostico.ReadOnly = true;
            this.diagnostico.Visible = false;
            // 
            // tratamiento
            // 
            this.tratamiento.HeaderText = "Tratamiento";
            this.tratamiento.Name = "tratamiento";
            this.tratamiento.ReadOnly = true;
            this.tratamiento.Visible = false;
            // 
            // observacion
            // 
            this.observacion.HeaderText = "Observacion";
            this.observacion.Name = "observacion";
            this.observacion.ReadOnly = true;
            this.observacion.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.label6.Location = new System.Drawing.Point(21, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 39;
            this.label6.Text = "Observaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.label5.Location = new System.Drawing.Point(21, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tratamiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.label4.Location = new System.Drawing.Point(21, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Diagnostico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.label3.Location = new System.Drawing.Point(373, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.label2.Location = new System.Drawing.Point(104, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mascota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.label1.Location = new System.Drawing.Point(104, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Dueño";
            // 
            // DueñoCB
            // 
            this.DueñoCB.FormattingEnabled = true;
            this.DueñoCB.Location = new System.Drawing.Point(162, 19);
            this.DueñoCB.Name = "DueñoCB";
            this.DueñoCB.Size = new System.Drawing.Size(170, 21);
            this.DueñoCB.TabIndex = 42;
            // 
            // MascotaCB
            // 
            this.MascotaCB.FormattingEnabled = true;
            this.MascotaCB.Location = new System.Drawing.Point(162, 54);
            this.MascotaCB.Name = "MascotaCB";
            this.MascotaCB.Size = new System.Drawing.Size(170, 21);
            this.MascotaCB.TabIndex = 43;
            // 
            // Fecha_HistoriaTXT
            // 
            this.Fecha_HistoriaTXT.Location = new System.Drawing.Point(417, 20);
            this.Fecha_HistoriaTXT.Name = "Fecha_HistoriaTXT";
            this.Fecha_HistoriaTXT.Size = new System.Drawing.Size(170, 20);
            this.Fecha_HistoriaTXT.TabIndex = 44;
            // 
            // DiagnosticoTXT
            // 
            this.DiagnosticoTXT.Location = new System.Drawing.Point(24, 91);
            this.DiagnosticoTXT.Multiline = true;
            this.DiagnosticoTXT.Name = "DiagnosticoTXT";
            this.DiagnosticoTXT.Size = new System.Drawing.Size(708, 53);
            this.DiagnosticoTXT.TabIndex = 45;
            // 
            // TratamientoTXT
            // 
            this.TratamientoTXT.Location = new System.Drawing.Point(24, 165);
            this.TratamientoTXT.Multiline = true;
            this.TratamientoTXT.Name = "TratamientoTXT";
            this.TratamientoTXT.Size = new System.Drawing.Size(708, 56);
            this.TratamientoTXT.TabIndex = 46;
            // 
            // ObservacionesTXT
            // 
            this.ObservacionesTXT.Location = new System.Drawing.Point(24, 243);
            this.ObservacionesTXT.Multiline = true;
            this.ObservacionesTXT.Name = "ObservacionesTXT";
            this.ObservacionesTXT.Size = new System.Drawing.Size(708, 45);
            this.ObservacionesTXT.TabIndex = 47;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.btnBorrar.Location = new System.Drawing.Point(497, 52);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(90, 25);
            this.btnBorrar.TabIndex = 68;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.btnModificar.Location = new System.Drawing.Point(392, 52);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 25);
            this.btnModificar.TabIndex = 67;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // idAnimal
            // 
            this.idAnimal.Location = new System.Drawing.Point(24, 43);
            this.idAnimal.Name = "idAnimal";
            this.idAnimal.Size = new System.Drawing.Size(26, 20);
            this.idAnimal.TabIndex = 69;
            this.idAnimal.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(751, 287);
            this.label7.TabIndex = 70;
            this.label7.Text = "Historal";
            // 
            // Guardar_Especialista
            // 
            this.Guardar_Especialista.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.Guardar_Especialista.Image = global::UI.Windows.Properties.Resources.clipboard_regular_24;
            this.Guardar_Especialista.Location = new System.Drawing.Point(612, 16);
            this.Guardar_Especialista.Name = "Guardar_Especialista";
            this.Guardar_Especialista.Size = new System.Drawing.Size(120, 56);
            this.Guardar_Especialista.TabIndex = 41;
            this.Guardar_Especialista.Text = "Guardar";
            this.Guardar_Especialista.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardar_Especialista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Guardar_Especialista.UseVisualStyleBackColor = true;
            this.Guardar_Especialista.Click += new System.EventHandler(this.Guardar_Especialista_Click);
            // 
            // FormHistorialMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(775, 476);
            this.Controls.Add(this.idAnimal);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.ObservacionesTXT);
            this.Controls.Add(this.TratamientoTXT);
            this.Controls.Add(this.DiagnosticoTXT);
            this.Controls.Add(this.Fecha_HistoriaTXT);
            this.Controls.Add(this.MascotaCB);
            this.Controls.Add(this.DueñoCB);
            this.Controls.Add(this.Guardar_Especialista);
            this.Controls.Add(this.dtgHistorial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHistorialMedico";
            this.Text = "FormHistorialMedico";
            this.Load += new System.EventHandler(this.FormHistorialMedico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Guardar_Especialista;
        private System.Windows.Forms.DataGridView dtgHistorial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DueñoCB;
        private System.Windows.Forms.ComboBox MascotaCB;
        private System.Windows.Forms.TextBox Fecha_HistoriaTXT;
        private System.Windows.Forms.TextBox DiagnosticoTXT;
        private System.Windows.Forms.TextBox TratamientoTXT;
        private System.Windows.Forms.TextBox ObservacionesTXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHistorialD;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosticoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn tratamientoD;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionesD;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDueñoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDAnimalD;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox idAnimal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_historial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
    }
}