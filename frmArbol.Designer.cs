namespace pryPOO
{
    partial class frmArbol
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmbEliminar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.txtTramite = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTramite = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnInOrdenDes = new System.Windows.Forms.RadioButton();
            this.rbnPostOrden = new System.Windows.Forms.RadioButton();
            this.rbnPreOrden = new System.Windows.Forms.RadioButton();
            this.rbnInOrdenAsc = new System.Windows.Forms.RadioButton();
            this.cmdEquilibrar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdEliminar);
            this.groupBox3.Controls.Add(this.cmbEliminar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(408, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 119);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar elemento";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(47, 84);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 2;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEliminar.FormattingEnabled = true;
            this.cmbEliminar.Location = new System.Drawing.Point(74, 41);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(83, 21);
            this.cmbEliminar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdAgregar);
            this.groupBox2.Controls.Add(this.txtTramite);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.lblTramite);
            this.groupBox2.Controls.Add(this.lblCodigo);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Location = new System.Drawing.Point(184, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 159);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nuevo elemento";
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(60, 125);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(129, 28);
            this.cmdAgregar.TabIndex = 6;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
            // 
            // txtTramite
            // 
            this.txtTramite.Location = new System.Drawing.Point(76, 87);
            this.txtTramite.Name = "txtTramite";
            this.txtTramite.Size = new System.Drawing.Size(100, 20);
            this.txtTramite.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(76, 19);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblTramite
            // 
            this.lblTramite.AutoSize = true;
            this.lblTramite.Location = new System.Drawing.Point(14, 94);
            this.lblTramite.Name = "lblTramite";
            this.lblTramite.Size = new System.Drawing.Size(42, 13);
            this.lblTramite.TabIndex = 2;
            this.lblTramite.Text = "Tramite";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(14, 26);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 1;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(14, 60);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvGrilla.Location = new System.Drawing.Point(211, 187);
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.Size = new System.Drawing.Size(360, 165);
            this.dgvGrilla.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tramite";
            this.Column3.Name = "Column3";
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(12, 12);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(155, 159);
            this.treeView.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnInOrdenDes);
            this.groupBox1.Controls.Add(this.rbnPostOrden);
            this.groupBox1.Controls.Add(this.rbnPreOrden);
            this.groupBox1.Controls.Add(this.rbnInOrdenAsc);
            this.groupBox1.Location = new System.Drawing.Point(12, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 165);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orden";
            // 
            // rbnInOrdenDes
            // 
            this.rbnInOrdenDes.AutoSize = true;
            this.rbnInOrdenDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbnInOrdenDes.Location = new System.Drawing.Point(23, 46);
            this.rbnInOrdenDes.Name = "rbnInOrdenDes";
            this.rbnInOrdenDes.Size = new System.Drawing.Size(170, 21);
            this.rbnInOrdenDes.TabIndex = 3;
            this.rbnInOrdenDes.TabStop = true;
            this.rbnInOrdenDes.Text = "In-Orden Descendente";
            this.rbnInOrdenDes.UseVisualStyleBackColor = true;
            this.rbnInOrdenDes.CheckedChanged += new System.EventHandler(this.rbnInOrdenDes_CheckedChanged);
            // 
            // rbnPostOrden
            // 
            this.rbnPostOrden.AutoSize = true;
            this.rbnPostOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbnPostOrden.Location = new System.Drawing.Point(23, 100);
            this.rbnPostOrden.Name = "rbnPostOrden";
            this.rbnPostOrden.Size = new System.Drawing.Size(99, 21);
            this.rbnPostOrden.TabIndex = 2;
            this.rbnPostOrden.TabStop = true;
            this.rbnPostOrden.Text = "Post-Orden";
            this.rbnPostOrden.UseVisualStyleBackColor = true;
            this.rbnPostOrden.CheckedChanged += new System.EventHandler(this.rbnPostOrden_CheckedChanged);
            // 
            // rbnPreOrden
            // 
            this.rbnPreOrden.AutoSize = true;
            this.rbnPreOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbnPreOrden.Location = new System.Drawing.Point(23, 73);
            this.rbnPreOrden.Name = "rbnPreOrden";
            this.rbnPreOrden.Size = new System.Drawing.Size(93, 21);
            this.rbnPreOrden.TabIndex = 1;
            this.rbnPreOrden.TabStop = true;
            this.rbnPreOrden.Text = "Pre-Orden";
            this.rbnPreOrden.UseVisualStyleBackColor = true;
            this.rbnPreOrden.CheckedChanged += new System.EventHandler(this.rbnPreOrden_CheckedChanged);
            // 
            // rbnInOrdenAsc
            // 
            this.rbnInOrdenAsc.AutoSize = true;
            this.rbnInOrdenAsc.Checked = true;
            this.rbnInOrdenAsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbnInOrdenAsc.Location = new System.Drawing.Point(23, 19);
            this.rbnInOrdenAsc.Name = "rbnInOrdenAsc";
            this.rbnInOrdenAsc.Size = new System.Drawing.Size(161, 21);
            this.rbnInOrdenAsc.TabIndex = 0;
            this.rbnInOrdenAsc.TabStop = true;
            this.rbnInOrdenAsc.Text = "In-Orden Ascendente";
            this.rbnInOrdenAsc.UseVisualStyleBackColor = true;
            this.rbnInOrdenAsc.CheckedChanged += new System.EventHandler(this.rbnInOrdenAsc_CheckedChanged);
            // 
            // cmdEquilibrar
            // 
            this.cmdEquilibrar.Location = new System.Drawing.Point(408, 137);
            this.cmdEquilibrar.Name = "cmdEquilibrar";
            this.cmdEquilibrar.Size = new System.Drawing.Size(162, 34);
            this.cmdEquilibrar.TabIndex = 15;
            this.cmdEquilibrar.Text = "Equilibrar";
            this.cmdEquilibrar.UseVisualStyleBackColor = true;
            this.cmdEquilibrar.Click += new System.EventHandler(this.cmdEquilibrar_Click);
            // 
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 391);
            this.Controls.Add(this.cmdEquilibrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmArbol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arbol";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.ComboBox cmbEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.TextBox txtTramite;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTramite;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnPostOrden;
        private System.Windows.Forms.RadioButton rbnPreOrden;
        private System.Windows.Forms.RadioButton rbnInOrdenAsc;
        private System.Windows.Forms.Button cmdEquilibrar;
        private System.Windows.Forms.RadioButton rbnInOrdenDes;
    }
}