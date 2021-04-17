namespace FormDptoIdioma
{
    partial class frmMenuDpto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuDpto));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.carrerasUnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCarreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.institutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirInstitutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDpto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.carrerasUnsToolStripMenuItem,
            this.institutoToolStripMenuItem,
            this.busquedaToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personaToolStripMenuItem
            // 
            this.personaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirPersonaToolStripMenuItem,
            this.consultasToolStripMenuItem1});
            this.personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            this.personaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.personaToolStripMenuItem.Text = "Persona";
            this.personaToolStripMenuItem.Click += new System.EventHandler(this.personaToolStripMenuItem_Click);
            // 
            // añadirPersonaToolStripMenuItem
            // 
            this.añadirPersonaToolStripMenuItem.Name = "añadirPersonaToolStripMenuItem";
            this.añadirPersonaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.añadirPersonaToolStripMenuItem.Text = "Añadir Persona";
            this.añadirPersonaToolStripMenuItem.Click += new System.EventHandler(this.añadirPersonaToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem1
            // 
            this.consultasToolStripMenuItem1.Name = "consultasToolStripMenuItem1";
            this.consultasToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.consultasToolStripMenuItem1.Text = "Consultas";
            this.consultasToolStripMenuItem1.Click += new System.EventHandler(this.consultasToolStripMenuItem1_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirCursoToolStripMenuItem,
            this.añadirAlumnoToolStripMenuItem,
            this.consultasToolStripMenuItem2});
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.cursosToolStripMenuItem.Text = "Curso";
            // 
            // añadirCursoToolStripMenuItem
            // 
            this.añadirCursoToolStripMenuItem.Name = "añadirCursoToolStripMenuItem";
            this.añadirCursoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.añadirCursoToolStripMenuItem.Text = "Añadir Curso";
            this.añadirCursoToolStripMenuItem.Click += new System.EventHandler(this.añadirCursoToolStripMenuItem_Click);
            // 
            // añadirAlumnoToolStripMenuItem
            // 
            this.añadirAlumnoToolStripMenuItem.Name = "añadirAlumnoToolStripMenuItem";
            this.añadirAlumnoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.añadirAlumnoToolStripMenuItem.Text = "Añadir Alumno";
            this.añadirAlumnoToolStripMenuItem.Click += new System.EventHandler(this.añadirAlumnoToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem2
            // 
            this.consultasToolStripMenuItem2.Name = "consultasToolStripMenuItem2";
            this.consultasToolStripMenuItem2.Size = new System.Drawing.Size(155, 22);
            this.consultasToolStripMenuItem2.Text = "Consultas ";
            this.consultasToolStripMenuItem2.Click += new System.EventHandler(this.consultasToolStripMenuItem2_Click);
            // 
            // carrerasUnsToolStripMenuItem
            // 
            this.carrerasUnsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCarreraToolStripMenuItem});
            this.carrerasUnsToolStripMenuItem.Name = "carrerasUnsToolStripMenuItem";
            this.carrerasUnsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.carrerasUnsToolStripMenuItem.Text = "Carreras Uns";
            // 
            // agregarCarreraToolStripMenuItem
            // 
            this.agregarCarreraToolStripMenuItem.Name = "agregarCarreraToolStripMenuItem";
            this.agregarCarreraToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.agregarCarreraToolStripMenuItem.Text = "Agregar Carrera";
            this.agregarCarreraToolStripMenuItem.Click += new System.EventHandler(this.agregarCarreraToolStripMenuItem_Click);
            // 
            // institutoToolStripMenuItem
            // 
            this.institutoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirInstitutoToolStripMenuItem});
            this.institutoToolStripMenuItem.Name = "institutoToolStripMenuItem";
            this.institutoToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.institutoToolStripMenuItem.Text = "Instituto";
            // 
            // añadirInstitutoToolStripMenuItem
            // 
            this.añadirInstitutoToolStripMenuItem.Name = "añadirInstitutoToolStripMenuItem";
            this.añadirInstitutoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.añadirInstitutoToolStripMenuItem.Text = "Añadir Instituto";
            this.añadirInstitutoToolStripMenuItem.Click += new System.EventHandler(this.añadirInstitutoToolStripMenuItem_Click);
            // 
            // busquedaToolStripMenuItem
            // 
            this.busquedaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaToolStripMenuItem1});
            this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.busquedaToolStripMenuItem.Text = "Busqueda ";
            // 
            // personaToolStripMenuItem1
            // 
            this.personaToolStripMenuItem1.Name = "personaToolStripMenuItem1";
            this.personaToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.personaToolStripMenuItem1.Text = "Consultar";
            this.personaToolStripMenuItem1.Click += new System.EventHandler(this.personaToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(22, 20);
            this.consultasToolStripMenuItem.Text = " ";
            // 
            // btnDpto
            // 
            this.btnDpto.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDpto.Font = new System.Drawing.Font("Rubik", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDpto.Location = new System.Drawing.Point(356, 106);
            this.btnDpto.Name = "btnDpto";
            this.btnDpto.Size = new System.Drawing.Size(108, 61);
            this.btnDpto.TabIndex = 4;
            this.btnDpto.Text = "DEPARTAMENTO DE IDIOMAS \r\nCOMERCIO UNS 2020\r\n\r\n";
            this.btnDpto.UseVisualStyleBackColor = false;
            this.btnDpto.Click += new System.EventHandler(this.btnDpto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(331, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuDpto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDpto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuDpto";
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenuDpto_FormClosing);
            this.Load += new System.EventHandler(this.frmMenuDpto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnDpto;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carrerasUnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarCarreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem institutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirInstitutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

