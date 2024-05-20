namespace pryPOO
{
    partial class frmTablasBDD
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdJuntar = new System.Windows.Forms.Button();
            this.cmdSelectMulti = new System.Windows.Forms.Button();
            this.cmdSelectSimple = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmsWhereConvo = new System.Windows.Forms.Button();
            this.cmdWhereMulti = new System.Windows.Forms.Button();
            this.cmdWhereSimple = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdDiferencia = new System.Windows.Forms.Button();
            this.cmdInterseccion = new System.Windows.Forms.Button();
            this.cmdUnion = new System.Windows.Forms.Button();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdJuntar);
            this.groupBox1.Controls.Add(this.cmdSelectMulti);
            this.groupBox1.Controls.Add(this.cmdSelectSimple);
            this.groupBox1.Location = new System.Drawing.Point(12, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proyeccion - SELECT";
            // 
            // cmdJuntar
            // 
            this.cmdJuntar.Location = new System.Drawing.Point(6, 92);
            this.cmdJuntar.Name = "cmdJuntar";
            this.cmdJuntar.Size = new System.Drawing.Size(143, 28);
            this.cmdJuntar.TabIndex = 2;
            this.cmdJuntar.Text = "Juntar";
            this.cmdJuntar.UseVisualStyleBackColor = true;
            this.cmdJuntar.Click += new System.EventHandler(this.cmdJuntar_Click);
            // 
            // cmdSelectMulti
            // 
            this.cmdSelectMulti.Location = new System.Drawing.Point(6, 58);
            this.cmdSelectMulti.Name = "cmdSelectMulti";
            this.cmdSelectMulti.Size = new System.Drawing.Size(143, 28);
            this.cmdSelectMulti.TabIndex = 1;
            this.cmdSelectMulti.Text = "Proyeccion Multiatributo";
            this.cmdSelectMulti.UseVisualStyleBackColor = true;
            this.cmdSelectMulti.Click += new System.EventHandler(this.cmdSelectMulti_Click);
            // 
            // cmdSelectSimple
            // 
            this.cmdSelectSimple.Location = new System.Drawing.Point(6, 24);
            this.cmdSelectSimple.Name = "cmdSelectSimple";
            this.cmdSelectSimple.Size = new System.Drawing.Size(143, 28);
            this.cmdSelectSimple.TabIndex = 0;
            this.cmdSelectSimple.Text = "Proyeccion Simple";
            this.cmdSelectSimple.UseVisualStyleBackColor = true;
            this.cmdSelectSimple.Click += new System.EventHandler(this.cmdSelectSimple_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmsWhereConvo);
            this.groupBox2.Controls.Add(this.cmdWhereMulti);
            this.groupBox2.Controls.Add(this.cmdWhereSimple);
            this.groupBox2.Location = new System.Drawing.Point(174, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Seleccion WHERE";
            // 
            // cmsWhereConvo
            // 
            this.cmsWhereConvo.Location = new System.Drawing.Point(6, 92);
            this.cmsWhereConvo.Name = "cmsWhereConvo";
            this.cmsWhereConvo.Size = new System.Drawing.Size(143, 28);
            this.cmsWhereConvo.TabIndex = 2;
            this.cmsWhereConvo.Text = "Seleccion por Convolucion";
            this.cmsWhereConvo.UseVisualStyleBackColor = true;
            this.cmsWhereConvo.Click += new System.EventHandler(this.cmsWhereConvo_Click);
            // 
            // cmdWhereMulti
            // 
            this.cmdWhereMulti.Location = new System.Drawing.Point(6, 58);
            this.cmdWhereMulti.Name = "cmdWhereMulti";
            this.cmdWhereMulti.Size = new System.Drawing.Size(143, 28);
            this.cmdWhereMulti.TabIndex = 1;
            this.cmdWhereMulti.Text = "Seleccion Multiatributo";
            this.cmdWhereMulti.UseVisualStyleBackColor = true;
            this.cmdWhereMulti.Click += new System.EventHandler(this.cmdWhereMulti_Click);
            // 
            // cmdWhereSimple
            // 
            this.cmdWhereSimple.Location = new System.Drawing.Point(6, 24);
            this.cmdWhereSimple.Name = "cmdWhereSimple";
            this.cmdWhereSimple.Size = new System.Drawing.Size(143, 28);
            this.cmdWhereSimple.TabIndex = 0;
            this.cmdWhereSimple.Text = "Seleccion Simple";
            this.cmdWhereSimple.UseVisualStyleBackColor = true;
            this.cmdWhereSimple.Click += new System.EventHandler(this.cmdWhereSimple_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdDiferencia);
            this.groupBox3.Controls.Add(this.cmdInterseccion);
            this.groupBox3.Controls.Add(this.cmdUnion);
            this.groupBox3.Location = new System.Drawing.Point(336, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 132);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Algrebraicas";
            // 
            // cmdDiferencia
            // 
            this.cmdDiferencia.Location = new System.Drawing.Point(6, 92);
            this.cmdDiferencia.Name = "cmdDiferencia";
            this.cmdDiferencia.Size = new System.Drawing.Size(143, 28);
            this.cmdDiferencia.TabIndex = 2;
            this.cmdDiferencia.Text = "Diferencia";
            this.cmdDiferencia.UseVisualStyleBackColor = true;
            this.cmdDiferencia.Click += new System.EventHandler(this.cmdDiferencia_Click);
            // 
            // cmdInterseccion
            // 
            this.cmdInterseccion.Location = new System.Drawing.Point(6, 58);
            this.cmdInterseccion.Name = "cmdInterseccion";
            this.cmdInterseccion.Size = new System.Drawing.Size(143, 28);
            this.cmdInterseccion.TabIndex = 1;
            this.cmdInterseccion.Text = "Interseccion";
            this.cmdInterseccion.UseVisualStyleBackColor = true;
            this.cmdInterseccion.Click += new System.EventHandler(this.cmdInterseccion_Click);
            // 
            // cmdUnion
            // 
            this.cmdUnion.Location = new System.Drawing.Point(6, 24);
            this.cmdUnion.Name = "cmdUnion";
            this.cmdUnion.Size = new System.Drawing.Size(143, 28);
            this.cmdUnion.TabIndex = 0;
            this.cmdUnion.Text = "Union";
            this.cmdUnion.UseVisualStyleBackColor = true;
            this.cmdUnion.Click += new System.EventHandler(this.cmdUnion_Click);
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Location = new System.Drawing.Point(12, 12);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(479, 288);
            this.dgvGrilla.TabIndex = 3;
            // 
            // frmTablasBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 450);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTablasBDD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tablas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.Button cmdJuntar;
        private System.Windows.Forms.Button cmdSelectMulti;
        private System.Windows.Forms.Button cmdSelectSimple;
        private System.Windows.Forms.Button cmsWhereConvo;
        private System.Windows.Forms.Button cmdWhereMulti;
        private System.Windows.Forms.Button cmdWhereSimple;
        private System.Windows.Forms.Button cmdDiferencia;
        private System.Windows.Forms.Button cmdInterseccion;
        private System.Windows.Forms.Button cmdUnion;
    }
}