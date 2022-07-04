using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEmpresaPortatiles.Usuario;

namespace AppEmpresaPortatiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PersonalizarDisenio();
        }

        private void PersonalizarDisenio()
        {
            pnlSubRegistrar.Visible = false;

        }
        private void OcultarSubMenu()
        {
            if (pnlSubRegistrar.Visible == true)
                pnlSubRegistrar.Visible = false;
        }
        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnRegistar_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(pnlSubRegistrar);
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            //codigo
            AbrirHijoFormulario(new RegistroEmpresa());
            OcultarSubMenu();
        }

        private void btnPortatil_Click(object sender, EventArgs e)
        {
            //codigo
            AbrirHijoFormulario(new RegistroPortatil());
            OcultarSubMenu();
        }
        private Form activateFrom = null;
        private void AbrirHijoFormulario(Form childForm)
        {
            if (activateFrom != null)
                activateFrom.Close();
            activateFrom = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlFormularioHijo.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            AbrirHijoFormulario(new FormConsulta());
            OcultarSubMenu();
        }
    }
}
