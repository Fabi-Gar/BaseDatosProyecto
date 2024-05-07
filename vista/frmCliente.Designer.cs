namespace BaseDatosProyecto.vista
{
    partial class frmCliente
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            this.BarraSuperior.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1674, 9);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Location = new System.Drawing.Point(1592, 9);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Location = new System.Drawing.Point(1633, 9);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BarraSuperior.Size = new System.Drawing.Size(1712, 47);
            // 
            // MenuVertical
            // 
            this.MenuVertical.Controls.Add(this.label1);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MenuVertical.Size = new System.Drawing.Size(293, 705);
            this.MenuVertical.Controls.SetChildIndex(this.btnSolicitarServicio, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnEstadoServicio, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnServicios, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnSoluciones, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnNuevoUsuario, 0);
            this.MenuVertical.Controls.SetChildIndex(this.label1, 0);
            // 
            // PanelCentral
            // 
            this.PanelCentral.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.PanelCentral.Size = new System.Drawing.Size(1419, 705);
            // 
            // btnSolicitarServicio
            // 
            this.btnSolicitarServicio.FlatAppearance.BorderSize = 0;
            this.btnSolicitarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(115)))));
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(1034, 9);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // btnEstadoServicio
            // 
            this.btnEstadoServicio.FlatAppearance.BorderSize = 0;
            this.btnEstadoServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(115)))));
            // 
            // btnSoluciones
            // 
            this.btnSoluciones.Enabled = false;
            this.btnSoluciones.FlatAppearance.BorderSize = 0;
            this.btnSoluciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(115)))));
            this.btnSoluciones.Visible = false;
            // 
            // btnServicios
            // 
            this.btnServicios.Enabled = false;
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(115)))));
            this.btnServicios.Text = "Mis Servicios";
            this.btnServicios.Visible = false;
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.Enabled = false;
            this.btnNuevoUsuario.FlatAppearance.BorderSize = 0;
            this.btnNuevoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(115)))));
            this.btnNuevoUsuario.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario";
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1712, 752);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            this.BarraSuperior.ResumeLayout(false);
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
    }
}