namespace FormDptoIdioma
{
    partial class frmAgregarAlu
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.gpAñadir = new System.Windows.Forms.GroupBox();
            this.cbLU = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lstAlumnoencurso = new System.Windows.Forms.ListBox();
            this.gpAñadir.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Mono", 20.6F);
            this.label1.Location = new System.Drawing.Point(231, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscripcion Curso 2020";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Curso";
            // 
            // cbCursos
            // 
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.Location = new System.Drawing.Point(11, 94);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(184, 21);
            this.cbCursos.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.Location = new System.Drawing.Point(80, 376);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 31);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVolver.Location = new System.Drawing.Point(660, 357);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 24);
            this.btnVolver.TabIndex = 9;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelar.Location = new System.Drawing.Point(204, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 31);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "LU";
            // 
            // gpAñadir
            // 
            this.gpAñadir.Controls.Add(this.cbLU);
            this.gpAñadir.Controls.Add(this.btnConfirmar);
            this.gpAñadir.Controls.Add(this.label5);
            this.gpAñadir.Controls.Add(this.cbCursos);
            this.gpAñadir.Controls.Add(this.label3);
            this.gpAñadir.Location = new System.Drawing.Point(12, 96);
            this.gpAñadir.Name = "gpAñadir";
            this.gpAñadir.Size = new System.Drawing.Size(384, 128);
            this.gpAñadir.TabIndex = 15;
            this.gpAñadir.TabStop = false;
            this.gpAñadir.Text = "Agregar Alumno";
            // 
            // cbLU
            // 
            this.cbLU.FormattingEnabled = true;
            this.cbLU.Location = new System.Drawing.Point(11, 46);
            this.cbLU.Name = "cbLU";
            this.cbLU.Size = new System.Drawing.Size(109, 21);
            this.cbLU.TabIndex = 17;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnConfirmar.Location = new System.Drawing.Point(272, 87);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(92, 28);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lstAlumnoencurso
            // 
            this.lstAlumnoencurso.FormattingEnabled = true;
            this.lstAlumnoencurso.Location = new System.Drawing.Point(2, 247);
            this.lstAlumnoencurso.Name = "lstAlumnoencurso";
            this.lstAlumnoencurso.Size = new System.Drawing.Size(742, 95);
            this.lstAlumnoencurso.TabIndex = 16;
            // 
            // frmAgregarAlu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstAlumnoencurso);
            this.Controls.Add(this.gpAñadir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarAlu";
            this.Text = "Añadir Alumno a Curso";
            this.Load += new System.EventHandler(this.frmAgregarAlu_Load);
            this.gpAñadir.ResumeLayout(false);
            this.gpAñadir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gpAñadir;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ListBox lstAlumnoencurso;
        private System.Windows.Forms.ComboBox cbLU;
    }
}