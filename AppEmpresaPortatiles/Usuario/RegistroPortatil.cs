﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEmpresaPortatiles.accesoDatos;
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
        }

        private void brnRegPortatil_Click(object sender, EventArgs e)
        {
            int serial, capacidad,resp;
            string marca, fechaEnsamblado,tipoDisco;
            try
            {
                serial = int.Parse(txtbPortSerial.Text);
                capacidad = int.Parse(txtbCapDisco.Text);
                marca = cbbPortMarca.SelectedItem.ToString();
                fechaEnsamblado = dateFechEnsPort.Text;
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
            resp = portatil.IngresarPortatil(serial,marca,capacidad,tipoDisco,fechaEnsamblado);
            if (resp > 0)
            {
                MessageBox.Show("Portatil registrado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbPortSerial.Clear();
                txtbCapDisco.Clear();
            }
            else
                MessageBox.Show("Portatil no registrado", "Mesaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnRegEmpPort_Click(object sender, EventArgs e)
        {
            int serial, nit, resp;
            try
            {
                serial = int.Parse(txtbSerPortR.Text);
                nit = int.Parse(txtNitEmpR.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error! datos inconrrectos", "Mesaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            resp = portatil.RegistrarPortEmp(serial,nit);
            if (resp > 0)
            {
                MessageBox.Show("Portatil guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbSerPortR.Clear();
                txtNitEmpR.Clear();
            }
            else
                MessageBox.Show("Portatil no ingresado", "Mesaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
