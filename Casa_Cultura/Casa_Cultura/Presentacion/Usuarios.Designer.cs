namespace Casa_Cultura.Presentacion
{
    partial class clsUsuarios
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
            this.tabladatos = new System.Windows.Forms.DataGridView();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.cajaImagen = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboUsuario = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verUsuariiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuarios = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBusUsuario = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.tabladatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaImagen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabladatos
            // 
            this.tabladatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabladatos.Location = new System.Drawing.Point(26, 266);
            this.tabladatos.Name = "tabladatos";
            this.tabladatos.Size = new System.Drawing.Size(817, 247);
            this.tabladatos.TabIndex = 0;
            this.tabladatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabladatos_CellContentClick);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(376, 221);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(108, 23);
            this.btnExaminar.TabIndex = 58;
            this.btnExaminar.Text = "Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar1);
            // 
            // cajaImagen
            // 
            this.cajaImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cajaImagen.Location = new System.Drawing.Point(338, 47);
            this.cajaImagen.Name = "cajaImagen";
            this.cajaImagen.Size = new System.Drawing.Size(175, 158);
            this.cajaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cajaImagen.TabIndex = 57;
            this.cajaImagen.TabStop = false;
            this.cajaImagen.Click += new System.EventHandler(this.cajaImagen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Contraseña:";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(123, 167);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(144, 20);
            this.txtpass.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Tipo de Usuario:";
            // 
            // comboUsuario
            // 
            this.comboUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUsuario.FormattingEnabled = true;
            this.comboUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Invitado"});
            this.comboUsuario.Location = new System.Drawing.Point(123, 64);
            this.comboUsuario.Name = "comboUsuario";
            this.comboUsuario.Size = new System.Drawing.Size(144, 21);
            this.comboUsuario.TabIndex = 51;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.verUsuariiosToolStripMenuItem,
            this.irAPrincipalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.cancelarToolStripMenuItem});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            this.cancelarToolStripMenuItem.Click += new System.EventHandler(this.cancelarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // verUsuariiosToolStripMenuItem
            // 
            this.verUsuariiosToolStripMenuItem.Name = "verUsuariiosToolStripMenuItem";
            this.verUsuariiosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.verUsuariiosToolStripMenuItem.Text = "Ver Usuarios";
            this.verUsuariiosToolStripMenuItem.Click += new System.EventHandler(this.verUsuariiosToolStripMenuItem_Click);
            // 
            // irAPrincipalToolStripMenuItem
            // 
            this.irAPrincipalToolStripMenuItem.Name = "irAPrincipalToolStripMenuItem";
            this.irAPrincipalToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.irAPrincipalToolStripMenuItem.Text = "Ir a Principal";
            this.irAPrincipalToolStripMenuItem.Click += new System.EventHandler(this.irAPrincipalToolStripMenuItem_Click);
            // 
            // txtUsuarios
            // 
            this.txtUsuarios.Location = new System.Drawing.Point(123, 118);
            this.txtUsuarios.Name = "txtUsuarios";
            this.txtUsuarios.Size = new System.Drawing.Size(144, 20);
            this.txtUsuarios.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(562, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Buscar Usuario:";
            // 
            // txtBusUsuario
            // 
            this.txtBusUsuario.Location = new System.Drawing.Point(650, 118);
            this.txtBusUsuario.Name = "txtBusUsuario";
            this.txtBusUsuario.Size = new System.Drawing.Size(144, 20);
            this.txtBusUsuario.TabIndex = 60;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // clsUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 522);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBusUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.cajaImagen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboUsuario);
            this.Controls.Add(this.tabladatos);
            this.Name = "clsUsuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.clsUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabladatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaImagen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExaminar;
        public System.Windows.Forms.PictureBox cajaImagen;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verUsuariiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAPrincipalToolStripMenuItem;
        public System.Windows.Forms.TextBox txtUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtBusUsuario;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.DataGridView tabladatos;
    }
}