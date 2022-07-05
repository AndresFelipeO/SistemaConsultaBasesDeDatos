using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEmpresaPortatiles.Logica;

namespace AppEmpresaPortatiles.Usuario
{
    public partial class RegistroEmpresa : Form
    {
        ClsEmpresa empresa = new ClsEmpresa();
        public RegistroEmpresa()
        {
            InitializeComponent();
            ConsultarEmpresa();
        }

        private void btnRegistrarEmp_Click(object sender, EventArgs e)
        {
            int nit=0,resp;
            string nombreEmp="", fechCreacion="";
            try
            {
                nit = int.Parse(txtbNitEmp.Text);
                nombreEmp = txtbNombreEmp.Text;
                fechCreacion = dateFechCreEmp.Text;
            }
            catch(Exception )
            {
                MessageBox.Show("Error! datos inconrrectos", "Mesaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            resp =empresa.IngresarEmpresa(nit, nombreEmp, fechCreacion);
            if (resp == -1)
            {
                MessageBox.Show("Empresa registrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbNitEmp.Clear();
                txtbNombreEmp.Clear();
            }else
                MessageBox.Show("Empresa no registrada", "Mesaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSalirEmp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            ConsultarEmpresa();
        }
        private void ConsultarEmpresa()
        {
            //creamos un dataset
            DataSet ds = new DataSet();
            ds = empresa.obtEmpresas();
            dtGrdEmpresas.DataSource = ds;
            dtGrdEmpresas.DataMember = "DTObjetos";
        }
    }
}
