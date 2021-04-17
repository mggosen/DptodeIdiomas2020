namespace FormDptoIdioma
{
    partial class frmAgregarP
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
            this.gbPersonas = new System.Windows.Forms.GroupBox();
            this.rbProfesor = new System.Windows.Forms.RadioButton();
            this.rbAlumno = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTuni = new System.Windows.Forms.TextBox();
            this.mskTxtFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbAlu = new System.Windows.Forms.GroupBox();
            this.lblfecha = new System.Windows.Forms.Label();
            this.mskTxtLu = new System.Windows.Forms.MaskedTextBox();
            this.lblLu = new System.Windows.Forms.Label();
            this.gbProfesor = new System.Windows.Forms.GroupBox();
            this.mskTxtNroLegajo = new System.Windows.Forms.MaskedTextBox();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.mskTxtDNI = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPersonas.SuspendLayout();
            this.gbAlu.SuspendLayout();
            this.gbProfesor.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPersonas
            // 
            this.gbPersonas.Controls.Add(this.rbProfesor);
            this.gbPersonas.Controls.Add(this.rbAlumno);
            this.gbPersonas.Location = new System.Drawing.Point(197, 85);
            this.gbPersonas.Name = "gbPersonas";
            this.gbPersonas.Size = new System.Drawing.Size(366, 60);
            this.gbPersonas.TabIndex = 0;
            this.gbPersonas.TabStop = false;
            this.gbPersonas.Text = "Seleccione..";
            // 
            // rbProfesor
            // 
            this.rbProfesor.AutoSize = true;
            this.rbProfesor.Location = new System.Drawing.Point(227, 31);
            this.rbProfesor.Name = "rbProfesor";
            this.rbProfesor.Size = new System.Drawing.Size(64, 17);
            this.rbProfesor.TabIndex = 1;
            this.rbProfesor.TabStop = true;
            this.rbProfesor.Text = "Profesor";
            this.rbProfesor.UseVisualStyleBackColor = true;
            // 
            // rbAlumno
            // 
            this.rbAlumno.AutoSize = true;
            this.rbAlumno.Checked = true;
            this.rbAlumno.Location = new System.Drawing.Point(88, 31);
            this.rbAlumno.Name = "rbAlumno";
            this.rbAlumno.Size = new System.Drawing.Size(60, 17);
            this.rbAlumno.TabIndex = 0;
            this.rbAlumno.TabStop = true;
            this.rbAlumno.Text = "Alumno";
            this.rbAlumno.UseVisualStyleBackColor = true;
            this.rbAlumno.CheckedChanged += new System.EventHandler(this.rbAlumno_CheckedChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.Location = new System.Drawing.Point(427, 371);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 47);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar al Sistema";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVolver.Location = new System.Drawing.Point(686, 381);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(77, 37);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReset.Location = new System.Drawing.Point(531, 371);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(76, 47);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Cancelar";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(153, 172);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(193, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(454, 168);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(454, 218);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtTuni
            // 
            this.txtTuni.Location = new System.Drawing.Point(340, 19);
            this.txtTuni.Name = "txtTuni";
            this.txtTuni.Size = new System.Drawing.Size(161, 20);
            this.txtTuni.TabIndex = 11;
            // 
            // mskTxtFecha
            // 
            this.mskTxtFecha.Location = new System.Drawing.Point(348, 19);
            this.mskTxtFecha.Mask = "00/00/0000";
            this.mskTxtFecha.Name = "mskTxtFecha";
            this.mskTxtFecha.Size = new System.Drawing.Size(153, 20);
            this.mskTxtFecha.TabIndex = 12;
            this.mskTxtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(87, 175);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(52, 13);
            this.lblNom.TabIndex = 14;
            this.lblNom.Text = "Nombres:";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(396, 172);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(52, 13);
            this.lblApe.TabIndex = 15;
            this.lblApe.Text = "Apellidos:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(110, 225);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 17;
            this.lblDni.Text = "DNI:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(396, 221);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email:";
            // 
            // gbAlu
            // 
            this.gbAlu.Controls.Add(this.lblfecha);
            this.gbAlu.Controls.Add(this.mskTxtLu);
            this.gbAlu.Controls.Add(this.lblLu);
            this.gbAlu.Controls.Add(this.mskTxtFecha);
            this.gbAlu.Location = new System.Drawing.Point(126, 252);
            this.gbAlu.Name = "gbAlu";
            this.gbAlu.Size = new System.Drawing.Size(520, 53);
            this.gbAlu.TabIndex = 19;
            this.gbAlu.TabStop = false;
            this.gbAlu.Text = "Datos Alumno";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(247, 26);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(95, 13);
            this.lblfecha.TabIndex = 20;
            this.lblfecha.Text = "Año de Inscripcion";
            // 
            // mskTxtLu
            // 
            this.mskTxtLu.Location = new System.Drawing.Point(51, 23);
            this.mskTxtLu.Mask = "999999";
            this.mskTxtLu.Name = "mskTxtLu";
            this.mskTxtLu.Size = new System.Drawing.Size(120, 20);
            this.mskTxtLu.TabIndex = 22;
            // 
            // lblLu
            // 
            this.lblLu.AutoSize = true;
            this.lblLu.Location = new System.Drawing.Point(24, 26);
            this.lblLu.Name = "lblLu";
            this.lblLu.Size = new System.Drawing.Size(21, 13);
            this.lblLu.TabIndex = 20;
            this.lblLu.Text = "LU";
            // 
            // gbProfesor
            // 
            this.gbProfesor.Controls.Add(this.mskTxtNroLegajo);
            this.gbProfesor.Controls.Add(this.lblLegajo);
            this.gbProfesor.Controls.Add(this.lbltitulo);
            this.gbProfesor.Controls.Add(this.txtTuni);
            this.gbProfesor.Location = new System.Drawing.Point(126, 311);
            this.gbProfesor.Name = "gbProfesor";
            this.gbProfesor.Size = new System.Drawing.Size(520, 54);
            this.gbProfesor.TabIndex = 20;
            this.gbProfesor.TabStop = false;
            this.gbProfesor.Text = "Datos Profesor";
            // 
            // mskTxtNroLegajo
            // 
            this.mskTxtNroLegajo.Location = new System.Drawing.Point(71, 19);
            this.mskTxtNroLegajo.Mask = "9999";
            this.mskTxtNroLegajo.Name = "mskTxtNroLegajo";
            this.mskTxtNroLegajo.Size = new System.Drawing.Size(130, 20);
            this.mskTxtNroLegajo.TabIndex = 23;
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(6, 22);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(59, 13);
            this.lblLegajo.TabIndex = 12;
            this.lblLegajo.Text = "Nro Legajo";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(243, 22);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(94, 13);
            this.lbltitulo.TabIndex = 12;
            this.lbltitulo.Text = "Titulo Universitario";
            // 
            // mskTxtDNI
            // 
            this.mskTxtDNI.Location = new System.Drawing.Point(162, 218);
            this.mskTxtDNI.Mask = "09999999";
            this.mskTxtDNI.Name = "mskTxtDNI";
            this.mskTxtDNI.Size = new System.Drawing.Size(171, 20);
            this.mskTxtDNI.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Mono", 18.25F);
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(296, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Añadir Persona";
            // 
            // frmAgregarP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskTxtDNI);
            this.Controls.Add(this.gbProfesor);
            this.Controls.Add(this.gbAlu);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApe);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbPersonas);
            this.Name = "frmAgregarP";
            this.Text = "Añadir ";
            this.Load += new System.EventHandler(this.frmAgregarP_Load);
            this.gbPersonas.ResumeLayout(false);
            this.gbPersonas.PerformLayout();
            this.gbAlu.ResumeLayout(false);
            this.gbAlu.PerformLayout();
            this.gbProfesor.ResumeLayout(false);
            this.gbProfesor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPersonas;
        private System.Windows.Forms.RadioButton rbProfesor;
        private System.Windows.Forms.RadioButton rbAlumno;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTuni;
        private System.Windows.Forms.MaskedTextBox mskTxtFecha;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gbAlu;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblLu;
        private System.Windows.Forms.GroupBox gbProfesor;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.MaskedTextBox mskTxtLu;
        private System.Windows.Forms.MaskedTextBox mskTxtNroLegajo;
        private System.Windows.Forms.MaskedTextBox mskTxtDNI;
        private System.Windows.Forms.Label label1;
    }
}