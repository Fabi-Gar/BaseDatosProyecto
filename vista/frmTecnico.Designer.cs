namespace BaseDatosProyecto.vista
{
    partial class frmTecnico
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
            // MenuVertical
            // 
            this.MenuVertical.Controls.Add(this.label1);
            this.MenuVertical.Controls.SetChildIndex(this.label1, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnSolicitarServicio, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnEstadoServicio, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnServicios, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnActualizar, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnSoluciones, 0);
            this.MenuVertical.Controls.SetChildIndex(this.btnNuevoUsuario, 0);
            // 
            // btnSolicitarServicio
            // 
            this.btnSolicitarServicio.Enabled = false;
            this.btnSolicitarServicio.FlatAppearance.BorderSize = 0;
            this.btnSolicitarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(115)))));
            this.btnSolicitarServicio.Location = new System.Drawing.Point(0, 498);
            this.btnSolicitarServicio.Visible = false;
            // 
            // btnEstadoServicio
            // 
            this.btnEstadoServicio.Enabled = false;
            this.btnEstadoServicio.FlatAppearance.BorderSize = 0;
            this.btnEstadoServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(115)))));
            this.btnEstadoServicio.Location = new System.Drawing.Point(3, 489);
            this.btnEstadoServicio.Visible = false;
            // 
            // button3
            // 
            this.btnSoluciones.FlatAppearance.BorderSize = 0;
            this.btnSoluciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(115)))));
            this.btnSoluciones.Location = new System.Drawing.Point(0, 324);
            // 
            // button2
            // 
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(115)))));
            this.btnActualizar.Location = new System.Drawing.Point(0, 257);
            // 
            // button1
            // 
            this.btnServicios.FlatAppearance.BorderSize = 0;
            this.btnServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(115)))));
            this.btnServicios.Location = new System.Drawing.Point(0, 190);
            // 
            // button4
            // 
            this.btnNuevoUsuario.Enabled = false;
            this.btnNuevoUsuario.FlatAppearance.BorderSize = 0;
            this.btnNuevoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(115)))));
            this.btnNuevoUsuario.Location = new System.Drawing.Point(0, 489);
            this.btnNuevoUsuario.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tecnico";
            // 
            // frmTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Name = "frmTecnico";
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