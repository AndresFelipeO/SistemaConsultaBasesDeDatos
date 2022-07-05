using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEmpresaPortatiles.Datos;
using AppEmpresaPortatiles.Logica;
using System.Data;

namespace AppEmpresaPortatiles.Usuario
{
    public partial class RegistroPortatil : Form
    {
        ClsPortatil portatil = new ClsPortatil();        
        public RegistroPortatil()
        {
            InitializeComponent();
            ConsultarPortatil();
        }

        private void brnRegPortatil_Click(object sender, EventArgs e)
        {
            int serial, nit,resp; 
            float capacidad,capRam;
            string marca, fechaEnsamblado,tipoDisco;
            try
            {
                serial = int.Parse(txtbPortSerial.Text);
                capacidad = float.Parse(txtbCapDisco.Text);
                capRam = float.Parse(txtRam.Text);
                marca = cbbPortMarca.SelectedItem.ToString();
                fechaEnsamblado = dateFechEnsPort.Text;
                nit = int.Parse(txtNitEmpR.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error! datos inconrrectos", "Mesaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (rdbTipoDuro.Checked)
                tipoDisco = "Duro";
            else
                tipoDisco = "Solido";
            resp = portatil.IngresarPortatil(serial,marca,capacidad,tipoDisco,capRam,fechaEnsamblado,nit);
            if (resp == -1)
            {
                MessageBox.Show("Portatil registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbPortSerial.Clear();
                txtbCapDisco.Clear();
                txtRam.Clear();
                txtNitEmpR.Clear();
            }
            else
                MessageBox.Show("Portatil no registrado", "Mesaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegEmpPort_Click(object sender, EventArgs e)
        {
            int serial, nit, resp;
            try
            {
                //serial = int.Parse(txtbSerPortR.Text);
                nit = int.Parse(txtNitEmpR.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error! datos inconrrectos", "Mesaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //resp = portatil.RegistrarPortEmp(serial,nit);
           }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void ConsultarPortatil()
        {
            //creamos un dataset
            DataSet ds = new DataSet();
            ds = portatil.obtPortatil();
            dtGridPortatil.DataSource = ds;
            dtGridPortatil.DataMember = "DTObjetos";
        }

        private void btnRefPort_Click(object sender, EventArgs e)
        {
            ConsultarPortatil();
        }
    }
}
