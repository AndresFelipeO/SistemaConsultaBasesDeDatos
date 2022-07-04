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
    public partial class FormConsulta : Form
    {
        ClsPortatil portatil = new ClsPortatil();
        public FormConsulta()
        {
            InitializeComponent();
        }

        private void btnConsultarB_Click(object sender, EventArgs e)
        {
            int nit=0;
            try
            {
                nit = int.Parse(txtbNitEmpB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error! datos inconrrectos", "Mesaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
            DataSet dsResultado = new DataSet();
            dsResultado = portatil.ConsultarPortatil(nit);
            
            dtGrdTablas.DataSource = dsResultado;
            dtGrdTablas.DataMember = "ResultadoDatos";
        }

        private void btnSalirConsul_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
