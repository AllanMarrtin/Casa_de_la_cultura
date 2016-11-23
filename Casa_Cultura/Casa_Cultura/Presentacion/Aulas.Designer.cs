namespace Casa_Cultura.Presentacion
{
    partial class Aulas
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
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha_nac = new System.Windows.Forms.Label();
            this.mat_imp = new System.Windows.Forms.Label();
            this.nom_al = new System.Windows.Forms.Label();
            this.matricula_al = new System.Windows.Forms.Label();
            this.clave_grupo = new System.Windows.Forms.TextBox();
            this.no_aula = new System.Windows.Forms.TextBox();
            this.materia_imp = new System.Windows.Forms.TextBox();
            this.horario = new System.Windows.Forms.TextBox();
            this.profesor = new System.Windows.Forms.TextBox();
            this.no_alumnos = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.agregar = new System.Windows.Forms.ToolStripMenuItem();
            this.modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.buscar = new System.Windows.Forms.ToolStripMenuItem();
            this.ver = new System.Windows.Forms.ToolStripMenuItem();
            this.irAPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabladatos = new System.Windows.Forms.DataGridView();
            this.txtBus = new System.Windows.Forms.TextBox();
            this.lblBus = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabladatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Profesor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "No. Alumnos:";
            // 
            // fecha_nac
            // 
            this.fecha_nac.AutoSize = true;
            this.fecha_nac.Location = new System.Drawing.Point(13, 193);
            this.fecha_nac.Name = "fecha_nac";
            this.fecha_nac.Size = new System.Drawing.Size(44, 13);
            this.fecha_nac.TabIndex = 27;
            this.fecha_nac.Text = "Horario:";
            // 
            // mat_imp
            // 
            this.mat_imp.AutoSize = true;
            this.mat_imp.Location = new System.Drawing.Point(13, 152);
            this.mat_imp.Name = "mat_imp";
            this.mat_imp.Size = new System.Drawing.Size(90, 13);
            this.mat_imp.TabIndex = 26;
            this.mat_imp.Text = "Materia impartida:";
            // 
            // nom_al
            // 
            this.nom_al.AutoSize = true;
            this.nom_al.Location = new System.Drawing.Point(13, 112);
            this.nom_al.Name = "nom_al";
            this.nom_al.Size = new System.Drawing.Size(51, 13);
            this.nom_al.TabIndex = 25;
            this.nom_al.Text = "No. Aula:";
            // 
            // matricula_al
            // 
            this.matricula_al.AutoSize = true;
            this.matricula_al.Location = new System.Drawing.Point(13, 70);
            this.matricula_al.Name = "matricula_al";
            this.matricula_al.Size = new System.Drawing.Size(84, 13);
            this.matricula_al.TabIndex = 24;
            this.matricula_al.Text = "Clave del grupo:";
            // 
            // clave_grupo
            // 
            this.clave_grupo.Location = new System.Drawing.Point(137, 70);
            this.clave_grupo.Name = "clave_grupo";
            this.clave_grupo.Size = new System.Drawing.Size(100, 20);
            this.clave_grupo.TabIndex = 30;
            // 
            // no_aula
            // 
            this.no_aula.Location = new System.Drawing.Point(137, 109);
            this.no_aula.Name = "no_aula";
            this.no_aula.Size = new System.Drawing.Size(100, 20);
            this.no_aula.TabIndex = 31;
            // 
            // materia_imp
            // 
            this.materia_imp.Location = new System.Drawing.Point(137, 152);
            this.materia_imp.Name = "materia_imp";
            this.materia_imp.Size = new System.Drawing.Size(100, 20);
            this.materia_imp.TabIndex = 32;
            // 
            // horario
            // 
            this.horario.Location = new System.Drawing.Point(137, 193);
            this.horario.Name = "horario";
            this.horario.Size = new System.Drawing.Size(100, 20);
            this.horario.TabIndex = 33;
            // 
            // profesor
            // 
            this.profesor.Location = new System.Drawing.Point(137, 236);
            this.profesor.Name = "profesor";
            this.profesor.Size = new System.Drawing.Size(100, 20);
            this.profesor.TabIndex = 34;
            // 
            // no_alumnos
            // 
            this.no_alumnos.Location = new System.Drawing.Point(137, 272);
            this.no_alumnos.Name = "no_alumnos";
            this.no_alumnos.Size = new System.Drawing.Size(100, 20);
            this.no_alumnos.TabIndex = 35;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregar,
            this.modificar,
            this.eliminar,
            this.buscar,
            this.ver,
            this.irAPrincipalToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(916, 24);
            this.menuStrip2.TabIndex = 60;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // agregar
            // 
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(61, 20);
            this.agregar.Text = "Agregar";
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // modificar
            // 
            this.modificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.cancelarToolStripMenuItem});
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(70, 20);
            this.modificar.Text = "Modificar";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // cancelarToolStripMenuItem
            // 
            this.cancelarToolStripMenuItem.Name = "cancelarToolStripMenuItem";
            this.cancelarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.cancelarToolStripMenuItem.Text = "Cancelar";
            // 
            // eliminar
            // 
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(62, 20);
            this.eliminar.Text = "Eliminar";
            // 
            // buscar
            // 
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(54, 20);
            this.buscar.Text = "Buscar";
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // ver
            // 
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(35, 20);
            this.ver.Text = "Ver";
            // 
            // irAPrincipalToolStripMenuItem
            // 
            this.irAPrincipalToolStripMenuItem.Name = "irAPrincipalToolStripMenuItem";
            this.irAPrincipalToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.irAPrincipalToolStripMenuItem.Text = "Ir a Principal";
            this.irAPrincipalToolStripMenuItem.Click += new System.EventHandler(this.irAPrincipalToolStripMenuItem_Click);
            // 
            // tabladatos
            // 
            this.tabladatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabladatos.Location = new System.Drawing.Point(253, 53);
            this.tabladatos.Name = "tabladatos";
            this.tabladatos.ReadOnly = true;
            this.tabladatos.Size = new System.Drawing.Size(639, 259);
            this.tabladatos.TabIndex = 61;
            this.tabladatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabladatos_CellContentClick);
            // 
            // txtBus
            // 
            this.txtBus.Location = new System.Drawing.Point(149, 364);
            this.txtBus.Name = "txtBus";
            this.txtBus.Size = new System.Drawing.Size(100, 20);
            this.txtBus.TabIndex = 62;
            // 
            // lblBus
            // 
            this.lblBus.AutoSize = true;
            this.lblBus.Location = new System.Drawing.Point(100, 364);
            this.lblBus.Name = "lblBus";
            this.lblBus.Size = new System.Drawing.Size(43, 13);
            this.lblBus.TabIndex = 63;
            this.lblBus.Text = "Buscar:";
            // 
            // Aulas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 408);
            this.Controls.Add(this.lblBus);
            this.Controls.Add(this.txtBus);
            this.Controls.Add(this.tabladatos);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.no_alumnos);
            this.Controls.Add(this.profesor);
            this.Controls.Add(this.horario);
            this.Controls.Add(this.materia_imp);
            this.Controls.Add(this.no_aula);
            this.Controls.Add(this.clave_grupo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha_nac);
            this.Controls.Add(this.mat_imp);
            this.Controls.Add(this.nom_al);
            this.Controls.Add(this.matricula_al);
            this.Name = "Aulas";
            this.Text = "Aulas";
            this.Load += new System.EventHandler(this.Aulas_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabladatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fecha_nac;
        private System.Windows.Forms.Label mat_imp;
        private System.Windows.Forms.Label nom_al;
        private System.Windows.Forms.Label matricula_al;
        private System.Windows.Forms.TextBox clave_grupo;
        private System.Windows.Forms.TextBox no_aula;
        private System.Windows.Forms.TextBox materia_imp;
        private System.Windows.Forms.TextBox horario;
        private System.Windows.Forms.TextBox profesor;
        private System.Windows.Forms.TextBox no_alumnos;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem agregar;
        private System.Windows.Forms.ToolStripMenuItem modificar;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminar;
        private System.Windows.Forms.ToolStripMenuItem buscar;
        private System.Windows.Forms.ToolStripMenuItem ver;
        private System.Windows.Forms.ToolStripMenuItem irAPrincipalToolStripMenuItem;
        public System.Windows.Forms.DataGridView tabladatos;
        private System.Windows.Forms.TextBox txtBus;
        private System.Windows.Forms.Label lblBus;
    }
}