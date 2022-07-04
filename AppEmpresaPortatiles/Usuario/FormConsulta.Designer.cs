namespace AppEmpresaPortatiles.Usuario
{
    partial class FormConsulta
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
            this.lblConsPort = new System.Windows.Forms.Label();
            this.lblNitEmp = new System.Windows.Forms.Label();
            this.txtbNitEmpB = new System.Windows.Forms.TextBox();
            this.btnConsultarB = new System.Windows.Forms.Button();
            this.dtGrdTablas = new System.Windows.Forms.DataGridView();
            this.btnSalirConsul = new System.Windows.Forms.Button();
            this.lblTitLogoPort = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.pnlBoardPortatiles = new System.Windows.Forms.Panel();
            this.ptbLogoPortB = new System.Windows.Forms.PictureBox();
            this.pnlConcultar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdTablas)).BeginInit();
            this.pnlBoardPortatiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogoPortB)).BeginInit();
            this.pnlConcultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConsPort
            // 
            this.lblConsPort.AutoSize = true;
            this.lblConsPort.BackColor = System.Drawing.Color.Transparent;
            this.lblConsPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblConsPort.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsPort.ForeColor = System.Drawing.Color.White;
            this.lblConsPort.Location = new System.Drawing.Point(0, 0);
            this.lblConsPort.Name = "lblConsPort";
            this.lblConsPort.Padding = new System.Windows.Forms.Padding(32, 20, 0, 12);
            this.lblConsPort.Size = new System.Drawing.Size(227, 55);
            this.lblConsPort.TabIndex = 1;
            this.lblConsPort.Text = "Consultar Portatiles";
            // 
            // lblNitEmp
            // 
            this.lblNitEmp.AutoSize = true;
            this.lblNitEmp.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNitEmp.Location = new System.Drawing.Point(116, 65);
            this.lblNitEmp.Name = "lblNitEmp";
            this.lblNitEmp.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lblNitEmp.Size = new System.Drawing.Size(129, 48);
            this.lblNitEmp.TabIndex = 2;
            this.lblNitEmp.Text = "Nit de la empresa";
            // 
            // txtbNitEmpB
            // 
            this.txtbNitEmpB.Location = new System.Drawing.Point(251, 79);
            this.txtbNitEmpB.Name = "txtbNitEmpB";
            this.txtbNitEmpB.Size = new System.Drawing.Size(100, 20);
            this.txtbNitEmpB.TabIndex = 3;
            // 
            // btnConsultarB
            // 
            this.btnConsultarB.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarB.Location = new System.Drawing.Point(267, 116);
            this.btnConsultarB.Name = "btnConsultarB";
            this.btnConsultarB.Size = new System.Drawing.Size(84, 23);
            this.btnConsultarB.TabIndex = 4;
            this.btnConsultarB.Text = "Consultar";
            this.btnConsultarB.UseVisualStyleBackColor = true;
            this.btnConsultarB.Click += new System.EventHandler(this.btnConsultarB_Click);
            // 
            // dtGrdTablas
            // 
            this.dtGrdTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdTablas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtGrdTablas.Location = new System.Drawing.Point(15, 145);
            this.dtGrdTablas.Name = "dtGrdTablas";
            this.dtGrdTablas.Size = new System.Drawing.Size(626, 229);
            this.dtGrdTablas.TabIndex = 5;
            // 
            // btnSalirConsul
            // 
            this.btnSalirConsul.BackColor = System.Drawing.Color.Transparent;
            this.btnSalirConsul.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSalirConsul.FlatAppearance.BorderSize = 0;
            this.btnSalirConsul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.btnSalirConsul.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirConsul.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirConsul.ForeColor = System.Drawing.Color.White;
            this.btnSalirConsul.Location = new System.Drawing.Point(0, 0);
            this.btnSalirConsul.Name = "btnSalirConsul";
            this.btnSalirConsul.Size = new System.Drawing.Size(36, 61);
            this.btnSalirConsul.TabIndex = 21;
            this.btnSalirConsul.Text = "<";
            this.btnSalirConsul.UseVisualStyleBackColor = false;
            this.btnSalirConsul.Click += new System.EventHandler(this.btnSalirConsul_Click);
            // 
            // lblTitLogoPort
            // 
            this.lblTitLogoPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitLogoPort.AutoSize = true;
            this.lblTitLogoPort.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitLogoPort.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblTitLogoPort.Location = new System.Drawing.Point(115, 3);
            this.lblTitLogoPort.Name = "lblTitLogoPort";
            this.lblTitLogoPort.Size = new System.Drawing.Size(62, 23);
            this.lblTitLogoPort.TabIndex = 23;
            this.lblTitLogoPort.Text = "Datos";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(116, 29);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(154, 36);
            this.lblInfo.TabIndex = 24;
            this.lblInfo.Text = "Buscar los portatiles \r\nde una empresa.";
            // 
            // pnlBoardPortatiles
            // 
            this.pnlBoardPortatiles.BackColor = System.Drawing.Color.LightSeaGreen;
            this.pnlBoardPortatiles.Controls.Add(this.btnSalirConsul);
            this.pnlBoardPortatiles.Controls.Add(this.lblConsPort);
            this.pnlBoardPortatiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBoardPortatiles.Location = new System.Drawing.Point(0, 0);
            this.pnlBoardPortatiles.Name = "pnlBoardPortatiles";
            this.pnlBoardPortatiles.Size = new System.Drawing.Size(656, 61);
            this.pnlBoardPortatiles.TabIndex = 27;
            // 
            // ptbLogoPortB
            // 
            this.ptbLogoPortB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbLogoPortB.Image = global::AppEmpresaPortatiles.Properties.Resources.document_search_magnifying_glass_icon_187063;
            this.ptbLogoPortB.Location = new System.Drawing.Point(18, 29);
            this.ptbLogoPortB.Name = "ptbLogoPortB";
            this.ptbLogoPortB.Size = new System.Drawing.Size(99, 110);
            this.ptbLogoPortB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogoPortB.TabIndex = 22;
            this.ptbLogoPortB.TabStop = false;
            // 
            // pnlConcultar
            // 
            this.pnlConcultar.Controls.Add(this.btnConsultarB);
            this.pnlConcultar.Controls.Add(this.txtbNitEmpB);
            this.pnlConcultar.Controls.Add(this.dtGrdTablas);
            this.pnlConcultar.Controls.Add(this.ptbLogoPortB);
            this.pnlConcultar.Controls.Add(this.lblTitLogoPort);
            this.pnlConcultar.Controls.Add(this.lblInfo);
            this.pnlConcultar.Controls.Add(this.lblNitEmp);
            this.pnlConcultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConcultar.Location = new System.Drawing.Point(0, 61);
            this.pnlConcultar.Name = "pnlConcultar";
            this.pnlConcultar.Padding = new System.Windows.Forms.Padding(15);
            this.pnlConcultar.Size = new System.Drawing.Size(656, 389);
            this.pnlConcultar.TabIndex = 28;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(656, 450);
            this.Controls.Add(this.pnlConcultar);
            this.Controls.Add(this.pnlBoardPortatiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsulta";
            this.Text = "FormConsuta";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdTablas)).EndInit();
            this.pnlBoardPortatiles.ResumeLayout(false);
            this.pnlBoardPortatiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogoPortB)).EndInit();
            this.pnlConcultar.ResumeLayout(false);
            this.pnlConcultar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConsPort;
        private System.Windows.Forms.Label lblNitEmp;
        private System.Windows.Forms.TextBox txtbNitEmpB;
        private System.Windows.Forms.Button btnConsultarB;
        private System.Windows.Forms.DataGridView dtGrdTablas;
        private System.Windows.Forms.Button btnSalirConsul;
        private System.Windows.Forms.PictureBox ptbLogoPortB;
        private System.Windows.Forms.Label lblTitLogoPort;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel pnlBoardPortatiles;
        private System.Windows.Forms.Panel pnlConcultar;
    }
}