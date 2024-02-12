using DominioModelo.Entidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UI.Windows.Controladores;
using UI.Windows.VistaModelo;

namespace UI.Windows.Formularios
{

    public partial class FormAnimales : Form
    {
        AnimalesControlador animalestaControlador;
        AnimalesVistaModelo animalesVistaModelo;
        DueñoControlador dueñocontrolador;
        EspecieControlador especiecontrolador;
        RazaControlador razacontrolador;
        SexoControlador sexocontrolador;
        List<DueñoDescripcionAnimal> listarAnimales;
        public FormAnimales()
        {
            InitializeComponent();
            animalesVistaModelo = new AnimalesVistaModelo();
            animalestaControlador = new AnimalesControlador();
            dueñocontrolador = new DueñoControlador();
            especiecontrolador = new EspecieControlador();
            razacontrolador = new RazaControlador();
            sexocontrolador = new SexoControlador();
        }
        private void InsertarAnimal()

        {

            if (animalestaControlador.InsertarAnimal(animalesVistaModelo))
            {
                MessageBox.Show("Mascota insertada correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al insertar Mascota.");
            }
        }

        private void ModificarAnimales()

        {

            if (animalestaControlador.ModificarAnimales(animalesVistaModelo))
            {
                MessageBox.Show("Mascota Modificada correctamente.");
            }
            else
            {
                MessageBox.Show("Error: Al Modificar Mascota.");
            }
        }
        private void FormAnimales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'veterinaria_FinalDataSet.Animales' Puede moverla o quitarla según sea necesario.

            ListarDueños();
            ListarEspecies(); 
            ListarRaza();
            ListarSexo();
            Listar();


        }
        private void Guardar_Especialista_Click(object sender, EventArgs e)
        {
            animalesVistaModelo.ID_Dueño_Cedula = (string)Dueño_AnimalCB.SelectedValue;
            animalesVistaModelo.Nombre = Nombre_AnimalTXT.Text;
            animalesVistaModelo.Fecha_Nacimiento = DateTime.Parse(Fecha_Animal_TXT.Text);
            animalesVistaModelo.ID_Especie = (int)Especie_AnimalCB.SelectedValue;
            animalesVistaModelo.ID_Raza = (int)Raza_AnimalCB.SelectedValue;
            animalesVistaModelo.ID_Sexo = (int?)Sexo_AnimalCB.SelectedValue;
            animalesVistaModelo.Est_Animal = 1;
            Limpiar();
            InsertarAnimal();
            datagridMascotas.Rows.Clear();
            Listar();

        }
        public void Listar()
        {
            listarAnimales = (List<DueñoDescripcionAnimal>)animalestaControlador.ListarAnimalesActivos();
            foreach (DueñoDescripcionAnimal item in listarAnimales)
            {
                datagridMascotas.Rows.Add(new object[] {"",item.id_Animal,item.nombre_dueño,item.nombre_mascota,item.fecha_nacimiento,
                    item.especie,item.raza, item.sexo});
            }

        }

        public void Limpiar()
        {
            Fecha_Animal_TXT.Text = "";
            Especie_AnimalCB.Text = "";
            Nombre_AnimalTXT.Text = "";
            idAnimal.Text = "";
        }
        private void ListarDueños()
        {
            Dueño_AnimalCB.DataSource = dueñocontrolador.ListarDueñoActivos();
            Dueño_AnimalCB.DisplayMember = "Nombre_Dueño";
            Dueño_AnimalCB.ValueMember = "ID_Dueño_Cedula";
        }
        private void ListarEspecies()
        {

            Especie_AnimalCB.DataSource = especiecontrolador.ListarEspecieActivos();
            Especie_AnimalCB.DisplayMember = "Nom_Especie";
            Especie_AnimalCB.ValueMember = "ID_Especie";
        }
        private void ListarRaza()
        {

         Raza_AnimalCB.DataSource = razacontrolador.ListarRazaActivos();
         Raza_AnimalCB.DisplayMember = "Nombre_Raza";
         Raza_AnimalCB.ValueMember = "ID_Raza";
        }
        private void ListarSexo()
        {
            Sexo_AnimalCB.DataSource = sexocontrolador.ListarSexoActivos();
            Sexo_AnimalCB.DisplayMember = "Sexo1";
            Sexo_AnimalCB.ValueMember = "ID_Sexo";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idAnimal.Text))
            {
                MessageBox.Show("El Id del cliente no fue encontrado");
                return;
            }
            animalesVistaModelo.ID_Animal = int.Parse(idAnimal.Text);
            animalesVistaModelo.ID_Dueño_Cedula = (string)Dueño_AnimalCB.SelectedValue;
            animalesVistaModelo.Nombre = Nombre_AnimalTXT.Text;
            animalesVistaModelo.Fecha_Nacimiento = DateTime.Parse(Fecha_Animal_TXT.Text);
            animalesVistaModelo.ID_Especie = (int)Especie_AnimalCB.SelectedValue;
            animalesVistaModelo.ID_Raza = (int)Raza_AnimalCB.SelectedValue;
            animalesVistaModelo.ID_Sexo = (int?)Sexo_AnimalCB.SelectedValue;
            animalesVistaModelo.Est_Animal = 1;
            Limpiar();
            ModificarAnimales();
            datagridMascotas.Rows.Clear();
            Listar();
        }
        



        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idAnimal.Text))
            {
                MessageBox.Show("El Id del cliente no fue encontrado");
                return;
            }

            var eliminacionRaza = animalestaControlador.EliminarAnimal(int.Parse(idAnimal.Text));
            if (eliminacionRaza)
            {
                MessageBox.Show("Animal eliminado correctamente");

            }
            else
            {
                MessageBox.Show("Error: Al elimnar Animal");
            }
            datagridMascotas.Rows.Clear();
            Limpiar();
            Listar();
        }

        private void datagridMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (datagridMascotas.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    idAnimal.Text = datagridMascotas.Rows[indice].Cells["id_animal"].Value.ToString();
                    if (int.TryParse(datagridMascotas.Rows[indice].Cells["dueño"].Value?.ToString(), out int dueñoMascota))
                    {
                        Dueño_AnimalCB.SelectedValue = dueñoMascota;
                    }
                    Nombre_AnimalTXT.Text = datagridMascotas.Rows[indice].Cells["nombre_mascota"].Value.ToString();
                    Fecha_Animal_TXT.Text = datagridMascotas.Rows[indice].Cells["fecha_nacimiento"].Value.ToString();
                    if (int.TryParse(datagridMascotas.Rows[indice].Cells["especie"].Value?.ToString(), out int especie))
                    {
                        Especie_AnimalCB.SelectedValue = especie;
                    }
                    if (int.TryParse(datagridMascotas.Rows[indice].Cells["raza"].Value?.ToString(), out int raza))
                    {
                        Raza_AnimalCB.SelectedValue = raza;
                    }
                    if (int.TryParse(datagridMascotas.Rows[indice].Cells["genero"].Value?.ToString(), out int sexo))
                    {
                        Sexo_AnimalCB.SelectedValue = sexo;
                    }    
                }
            }
        }

        private void datagridMascotas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var imgWidth = Properties.Resources.check_circle_solid_24.Width;
                var imgHeight = Properties.Resources.check_circle_solid_24.Height;
                var imgX = e.CellBounds.Left + (e.CellBounds.Width - imgWidth) / 2;
                var imgY = e.CellBounds.Top + (e.CellBounds.Height - imgHeight) / 2;

                e.Graphics.DrawImage(Properties.Resources.check_circle_solid_24, new Rectangle(imgX, imgY, imgWidth, imgHeight));
                e.Handled = true;
            }
        }
    }
}
