namespace UI.Windows.Formularios
{
    partial class FormAnimales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Guardar_Especialista = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Fecha_Animal_TXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nombre_AnimalTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dueño_AnimalCB = new System.Windows.Forms.ComboBox();
            this.Especie_AnimalCB = new System.Windows.Forms.ComboBox();
            this.Raza_AnimalCB = new System.Windows.Forms.ComboBox();
            this.Sexo_AnimalCB = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.datagridMascotas = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_animal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_mascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_nacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAnimal = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridMascotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Guardar_Especialista
            // 
            this.Guardar_Especialista.Location = new System.Drawing.Point(12, 312);
            this.Guardar_Especialista.Name = "Guardar_Especialista";
            this.Guardar_Especialista.Size = new System.Drawing.Size(245, 28);
            this.Guardar_Especialista.TabIndex = 27;
            this.Guardar_Especialista.Text = "Guardar";
            this.Guardar_Especialista.UseVisualStyleBackColor = true;
            this.Guardar_Especialista.Click += new System.EventHandler(this.Guardar_Especialista_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.label6.Location = new System.Drawing.Point(16, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.label5.Location = new System.Drawing.Point(16, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Raza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.label4.Location = new System.Drawing.Point(16, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Especie";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.label3.Location = new System.Drawing.Point(16, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 38);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // Fecha_Animal_TXT
            // 
            this.Fecha_Animal_TXT.Location = new System.Drawing.Point(121, 181);
            this.Fecha_Animal_TXT.Name = "Fecha_Animal_TXT";
            this.Fecha_Animal_TXT.Size = new System.Drawing.Size(136, 20);
            this.Fecha_Animal_TXT.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.label2.Location = new System.Drawing.Point(16, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre Mascota";
            // 
            // Nombre_AnimalTXT
            // 
            this.Nombre_AnimalTXT.Location = new System.Drawing.Point(121, 155);
            this.Nombre_AnimalTXT.Name = "Nombre_AnimalTXT";
            this.Nombre_AnimalTXT.Size = new System.Drawing.Size(136, 20);
            this.Nombre_AnimalTXT.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 6.75F);
            this.label1.Location = new System.Drawing.Point(16, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dueño";
            // 
            // Dueño_AnimalCB
            // 
            this.Dueño_AnimalCB.FormattingEnabled = true;
            this.Dueño_AnimalCB.Location = new System.Drawing.Point(121, 125);
            this.Dueño_AnimalCB.Name = "Dueño_AnimalCB";
            this.Dueño_AnimalCB.Size = new System.Drawing.Size(136, 21);
            this.Dueño_AnimalCB.TabIndex = 28;
            // 
            // Especie_AnimalCB
            // 
            this.Especie_AnimalCB.FormattingEnabled = true;
            this.Especie_AnimalCB.Location = new System.Drawing.Point(121, 210);
            this.Especie_AnimalCB.Name = "Especie_AnimalCB";
            this.Especie_AnimalCB.Size = new System.Drawing.Size(136, 21);
            this.Especie_AnimalCB.TabIndex = 29;
            // 
            // Raza_AnimalCB
            // 
            this.Raza_AnimalCB.FormattingEnabled = true;
            this.Raza_AnimalCB.Location = new System.Drawing.Point(121, 240);
            this.Raza_AnimalCB.Name = "Raza_AnimalCB";
            this.Raza_AnimalCB.Size = new System.Drawing.Size(136, 21);
            this.Raza_AnimalCB.TabIndex = 30;
            // 
            // Sexo_AnimalCB
            // 
            this.Sexo_AnimalCB.FormattingEnabled = true;
            this.Sexo_AnimalCB.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.Sexo_AnimalCB.Location = new System.Drawing.Point(121, 271);
            this.Sexo_AnimalCB.Name = "Sexo_AnimalCB";
            this.Sexo_AnimalCB.Size = new System.Drawing.Size(136, 21);
            this.Sexo_AnimalCB.TabIndex = 31;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(12, 357);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(245, 28);
            this.btnModificar.TabIndex = 32;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // datagridMascotas
            // 
            this.datagridMascotas.AllowUserToAddRows = false;
            this.datagridMascotas.AllowUserToDeleteRows = false;
            this.datagridMascotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridMascotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridMascotas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.datagridMascotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridMascotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridMascotas.ColumnHeadersHeight = 43;
            this.datagridMascotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionar,
            this.id_animal,
            this.dueño,
            this.nombre_mascota,
            this.fecha_nacimiento,
            this.especie,
            this.raza,
            this.genero});
            this.datagridMascotas.Location = new System.Drawing.Point(269, 11);
            this.datagridMascotas.MultiSelect = false;
            this.datagridMascotas.Name = "datagridMascotas";
            this.datagridMascotas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridMascotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridMascotas.Size = new System.Drawing.Size(494, 453);
            this.datagridMascotas.TabIndex = 36;
            this.datagridMascotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridMascotas_CellContentClick);
            this.datagridMascotas.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.datagridMascotas_CellPainting);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btnSeleccionar.FillWeight = 53.20785F;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccionar.HeaderText = "";
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.ReadOnly = true;
            // 
            // id_animal
            // 
            this.id_animal.HeaderText = "Id_Animal";
            this.id_animal.Name = "id_animal";
            this.id_animal.ReadOnly = true;
            this.id_animal.Visible = false;
            // 
            // dueño
            // 
            this.dueño.FillWeight = 97.0551F;
            this.dueño.HeaderText = "Dueño";
            this.dueño.Name = "dueño";
            this.dueño.ReadOnly = true;
            // 
            // nombre_mascota
            // 
            this.nombre_mascota.FillWeight = 97.0551F;
            this.nombre_mascota.HeaderText = "Nombre Mascota";
            this.nombre_mascota.Name = "nombre_mascota";
            this.nombre_mascota.ReadOnly = true;
            // 
            // fecha_nacimiento
            // 
            this.fecha_nacimiento.FillWeight = 116.339F;
            this.fecha_nacimiento.HeaderText = "Fecha Nacimiento";
            this.fecha_nacimiento.Name = "fecha_nacimiento";
            this.fecha_nacimiento.ReadOnly = true;
            // 
            // especie
            // 
            this.especie.FillWeight = 97.0551F;
            this.especie.HeaderText = "Especie";
            this.especie.Name = "especie";
            this.especie.ReadOnly = true;
            // 
            // raza
            // 
            this.raza.FillWeight = 97.0551F;
            this.raza.HeaderText = "Raza";
            this.raza.Name = "raza";
            this.raza.ReadOnly = true;
            // 
            // genero
            // 
            this.genero.FillWeight = 97.0551F;
            this.genero.HeaderText = "Sexo";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            // 
            // idAnimal
            // 
            this.idAnimal.Location = new System.Drawing.Point(12, 434);
            this.idAnimal.Name = "idAnimal";
            this.idAnimal.Size = new System.Drawing.Size(25, 20);
            this.idAnimal.TabIndex = 37;
            this.idAnimal.Visible = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(12, 400);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(245, 28);
            this.btnBorrar.TabIndex = 38;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 453);
            this.label7.TabIndex = 39;
            this.label7.Text = "Detalle Mascota";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(80, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // FormAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(775, 476);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.idAnimal);
            this.Controls.Add(this.datagridMascotas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.Sexo_AnimalCB);
            this.Controls.Add(this.Raza_AnimalCB);
            this.Controls.Add(this.Especie_AnimalCB);
            this.Controls.Add(this.Dueño_AnimalCB);
            this.Controls.Add(this.Guardar_Especialista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Fecha_Animal_TXT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre_AnimalTXT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAnimales";
            this.Text = "FormAnimales";
            this.Load += new System.EventHandler(this.FormAnimales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridMascotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guardar_Especialista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fecha_Animal_TXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nombre_AnimalTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Dueño_AnimalCB;
        private System.Windows.Forms.ComboBox Especie_AnimalCB;
        private System.Windows.Forms.ComboBox Raza_AnimalCB;
        private System.Windows.Forms.ComboBox Sexo_AnimalCB;

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView datagridMascotas;
        private System.Windows.Forms.TextBox idAnimal;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAnimal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRaza;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn estAnimal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_animal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_mascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_nacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn raza;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
    }
}