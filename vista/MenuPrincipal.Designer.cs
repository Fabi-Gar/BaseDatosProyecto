namespace BaseDatosProyecto
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.btnSolicitarServicio = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(115)))));
            this.BarraSuperior.Controls.Add(this.btnRestaurar);
            this.BarraSuperior.Controls.Add(this.btnMinimizar);
            this.BarraSuperior.Controls.Add(this.btnMaximizar);
            this.BarraSuperior.Controls.Add(this.btnSalir);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(1300, 38);
            this.BarraSuperior.TabIndex = 0;
            this.BarraSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1210, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1241, 7);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1272, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 25);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 0;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuVertical.Controls.Add(this.btnSolicitarServicio);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 38);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(220, 612);
            this.MenuVertical.TabIndex = 1;
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(220, 38);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(1080, 612);
            this.PanelCentral.TabIndex = 2;
            // 
            // btnSolicitarServicio
            // 
            this.btnSolicitarServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolicitarServicio.FlatAppearance.BorderSize = 0;
            this.btnSolicitarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(115)))));
            this.btnSolicitarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolicitarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolicitarServicio.ForeColor = System.Drawing.Color.White;
            this.btnSolicitarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnSolicitarServicio.Image")));
            this.btnSolicitarServicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSolicitarServicio.Location = new System.Drawing.Point(0, 83);
            this.btnSolicitarServicio.Name = "btnSolicitarServicio";
            this.btnSolicitarServicio.Size = new System.Drawing.Size(220, 61);
            this.btnSolicitarServicio.TabIndex = 0;
            this.btnSolicitarServicio.Text = "      Solicitar Servicio";
            this.btnSolicitarServicio.UseVisualStyleBackColor = true;
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(1241, 7);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.BarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox btnSalir;
        public System.Windows.Forms.PictureBox btnMinimizar;
        public System.Windows.Forms.PictureBox btnMaximizar;
        public System.Windows.Forms.Panel BarraSuperior;
        public System.Windows.Forms.Panel MenuVertical;
        public System.Windows.Forms.Panel PanelCentral;
        public System.Windows.Forms.Button btnSolicitarServicio;
        public System.Windows.Forms.PictureBox btnRestaurar;
    }
}

