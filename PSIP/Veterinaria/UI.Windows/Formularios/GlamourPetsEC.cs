﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UI.Windows.Formularios
{
    public partial class GlamourPetsEC : Form
    {
        public GlamourPetsEC()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }

        private void btnreportclientes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible=false;
            abrirforms(new FormCita());
        }

        private void btnreportmascotas_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            abrirforms(new FormHistorialMedico());
        }

        private void btnreportservicios_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
            abrirforms(new v());
        }
        private void abrirforms (object formhijo)
        {
            if(this.PanelContenedor.Controls.Count>0)
                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            //this.Anchor = AnchorStyles.None;
            this.PanelContenedor.Tag = fh;
            fh.Show();
        }


        private void Btnmascotas_Click(object sender, EventArgs e)
        {
            abrirforms(new FormAnimales());
        }

        private void Btnservicios_Click(object sender, EventArgs e)
        {
            abrirforms(new FormServicios());
        }

        private void btnespecies_Click(object sender, EventArgs e)
        {
            abrirforms(new FormEspec());
        }

        private void btnrazas_Click(object sender, EventArgs e)
        {
            abrirforms(new Raza());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            abrirforms(new FormDueño());
        }
    }
}
