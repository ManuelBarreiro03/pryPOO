namespace pryPOO
{
    partial class frmDeuda
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
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.grbAcciones = new System.Windows.Forms.GroupBox();
            this.cmdPagar = new System.Windows.Forms.Button();
            this.cmdComprar = new System.Windows.Forms.Button();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.grbDatos.SuspendLayout();
            this.grbAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.lblDeuda);
            this.grbDatos.Controls.Add(this.lblNombre);
            this.grbDatos.Controls.Add(this.lblCodigo);
            this.grbDatos.Location = new System.Drawing.Point(12, 12);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(351, 169);
            this.grbDatos.TabIndex = 0;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos del Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(30, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Deuda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(30, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblDeuda.Location = new System.Drawing.Point(174, 97);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(50, 17);
            this.lblDeuda.TabIndex = 2;
            this.lblDeuda.Text = "Deuda";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblNombre.Location = new System.Drawing.Point(174, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblCodigo.Location = new System.Drawing.Point(174, 27);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 17);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo";
            // 
            // grbAcciones
            // 
            this.grbAcciones.Controls.Add(this.cmdPagar);
            this.grbAcciones.Controls.Add(this.cmdComprar);
            this.grbAcciones.Controls.Add(this.txtImporte);
            this.grbAcciones.Controls.Add(this.lblImporte);
            this.grbAcciones.Location = new System.Drawing.Point(12, 180);
            this.grbAcciones.Name = "grbAcciones";
            this.grbAcciones.Size = new System.Drawing.Size(351, 151);
            this.grbAcciones.TabIndex = 1;
            this.grbAcciones.TabStop = false;
            this.grbAcciones.Text = "Acciones del cliente";
            // 
            // cmdPagar
            // 
            this.cmdPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmdPagar.Location = new System.Drawing.Point(201, 113);
            this.cmdPagar.Name = "cmdPagar";
            this.cmdPagar.Size = new System.Drawing.Size(99, 32);
            this.cmdPagar.TabIndex = 3;
            this.cmdPagar.Text = "Pagar";
            this.cmdPagar.UseVisualStyleBackColor = true;
            this.cmdPagar.Click += new System.EventHandler(this.cmdPagar_Click);
            // 
            // cmdComprar
            // 
            this.cmdComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cmdComprar.Location = new System.Drawing.Point(51, 113);
            this.cmdComprar.Name = "cmdComprar";
            this.cmdComprar.Size = new System.Drawing.Size(99, 32);
            this.cmdComprar.TabIndex = 2;
            this.cmdComprar.Text = "Comprar";
            this.cmdComprar.UseVisualStyleBackColor = true;
            this.cmdComprar.Click += new System.EventHandler(this.cmdComprar_Click);
            // 
            // txtImporte
            // 
            this.txtImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtImporte.Location = new System.Drawing.Point(177, 50);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(123, 23);
            this.txtImporte.TabIndex = 1;
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lblImporte.Location = new System.Drawing.Point(48, 53);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(55, 17);
            this.lblImporte.TabIndex = 0;
            this.lblImporte.Text = "Importe";
            // 
            // frmDeuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 349);
            this.Controls.Add(this.grbAcciones);
            this.Controls.Add(this.grbDatos);
            this.Name = "frmDeuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deuda De Cliente";
            this.Load += new System.EventHandler(this.frmDeuda_Load);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbAcciones.ResumeLayout(false);
            this.grbAcciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox grbAcciones;
        private System.Windows.Forms.Button cmdPagar;
        private System.Windows.Forms.Button cmdComprar;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

