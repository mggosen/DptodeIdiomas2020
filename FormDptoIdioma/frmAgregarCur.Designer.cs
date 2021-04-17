namespace FormDptoIdioma
{
    partial class frmAgregarCur
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
            this.gbCurso = new System.Windows.Forms.GroupBox();
            this.rbConvenio = new System.Windows.Forms.RadioButton();
            this.rbPropio = new System.Windows.Forms.RadioButton();
            this.txtNomCurso = new System.Windows.Forms.TextBox();
            this.mskID = new System.Windows.Forms.MaskedTextBox();
            this.gbPropio = new System.Windows.Forms.GroupBox();
            this.mskHora = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProfesor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbConv = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbInsti = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.gbCurso.SuspendLayout();
            this.gbPropio.SuspendLayout();
            this.gbConv.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCurso
            // 
            this.gbCurso.Controls.Add(this.rbConvenio);
            this.gbCurso.Controls.Add(this.rbPropio);
            this.gbCurso.Location = new System.Drawing.Point(124, 33);
            this.gbCurso.Name = "gbCurso";
            this.gbCurso.Size = new System.Drawing.Size(263, 65);
            this.gbCurso.TabIndex = 0;
            this.gbCurso.TabStop = false;
            this.gbCurso.Text = "Cursos";
            // 
            // rbConvenio
            // 
            this.rbConvenio.AutoSize = true;
            this.rbConvenio.Location = new System.Drawing.Point(157, 25);
            this.rbConvenio.Name = "rbConvenio";
            this.rbConvenio.Size = new System.Drawing.Size(100, 17);
            this.rbConvenio.TabIndex = 1;
            this.rbConvenio.TabStop = true;
            this.rbConvenio.Text = "Curso Convenio";
            this.rbConvenio.UseVisualStyleBackColor = true;
            this.rbConvenio.CheckedChanged += new System.EventHandler(this.rbConvenio_CheckedChanged);
            // 
            // rbPropio
            // 
            this.rbPropio.AutoSize = true;
            this.rbPropio.Location = new System.Drawing.Point(23, 25);
            this.rbPropio.Name = "rbPropio";
            this.rbPropio.Size = new System.Drawing.Size(85, 17);
            this.rbPropio.TabIndex = 0;
            this.rbPropio.TabStop = true;
            this.rbPropio.Text = "Curso Propio";
            this.rbPropio.UseVisualStyleBackColor = true;
            this.rbPropio.CheckedChanged += new System.EventHandler(this.rbPropio_CheckedChanged);
            // 
            // txtNomCurso
            // 
            this.txtNomCurso.Location = new System.Drawing.Point(61, 166);
            this.txtNomCurso.Name = "txtNomCurso";
            this.txtNomCurso.Size = new System.Drawing.Size(134, 20);
            this.txtNomCurso.TabIndex = 1;
            // 
            // mskID
            // 
            this.mskID.Location = new System.Drawing.Point(322, 166);
            this.mskID.Mask = "09999999";
            this.mskID.Name = "mskID";
            this.mskID.Size = new System.Drawing.Size(132, 20);
            this.mskID.TabIndex = 2;
            // 
            // gbPropio
            // 
            this.gbPropio.Controls.Add(this.mskHora);
            this.gbPropio.Controls.Add(this.label4);
            this.gbPropio.Controls.Add(this.txtAula);
            this.gbPropio.Controls.Add(this.label3);
            this.gbPropio.Controls.Add(this.cbProfesor);
            this.gbPropio.Location = new System.Drawing.Point(27, 192);
            this.gbPropio.Name = "gbPropio";
            this.gbPropio.Size = new System.Drawing.Size(455, 76);
            this.gbPropio.TabIndex = 3;
            this.gbPropio.TabStop = false;
            this.gbPropio.Text = "Curso Propio";
            // 
            // mskHora
            // 
            this.mskHora.Location = new System.Drawing.Point(312, 49);
            this.mskHora.Mask = "00:00";
            this.mskHora.Name = "mskHora";
            this.mskHora.Size = new System.Drawing.Size(115, 20);
            this.mskHora.TabIndex = 4;
            this.mskHora.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Aula";
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(176, 49);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(88, 20);
            this.txtAula.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Profesor";
            // 
            // cbProfesor
            // 
            this.cbProfesor.FormattingEnabled = true;
            this.cbProfesor.Location = new System.Drawing.Point(6, 49);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(134, 21);
            this.cbProfesor.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID Curso";
            // 
            // gbConv
            // 
            this.gbConv.Controls.Add(this.label5);
            this.gbConv.Controls.Add(this.cbInsti);
            this.gbConv.Location = new System.Drawing.Point(27, 289);
            this.gbConv.Name = "gbConv";
            this.gbConv.Size = new System.Drawing.Size(455, 67);
            this.gbConv.TabIndex = 6;
            this.gbConv.TabStop = false;
            this.gbConv.Text = "Curso Convenio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Instituto";
            // 
            // cbInsti
            // 
            this.cbInsti.FormattingEnabled = true;
            this.cbInsti.Location = new System.Drawing.Point(83, 28);
            this.cbInsti.Name = "cbInsti";
            this.cbInsti.Size = new System.Drawing.Size(224, 21);
            this.cbInsti.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.Location = new System.Drawing.Point(124, 376);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(121, 33);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar Curso";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVolver.Location = new System.Drawing.Point(684, 394);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(81, 30);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelar.Location = new System.Drawing.Point(282, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 31);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Liberation Mono", 20.25F);
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Location = new System.Drawing.Point(491, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cursos D.I 2020";
            // 
            // frmAgregarCur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gbConv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbPropio);
            this.Controls.Add(this.mskID);
            this.Controls.Add(this.txtNomCurso);
            this.Controls.Add(this.gbCurso);
            this.Name = "frmAgregarCur";
            this.Text = "Añadir Curso";
            this.Load += new System.EventHandler(this.frmAgregarCur_Load);
            this.gbCurso.ResumeLayout(false);
            this.gbCurso.PerformLayout();
            this.gbPropio.ResumeLayout(false);
            this.gbPropio.PerformLayout();
            this.gbConv.ResumeLayout(false);
            this.gbConv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCurso;
        private System.Windows.Forms.RadioButton rbConvenio;
        private System.Windows.Forms.RadioButton rbPropio;
        private System.Windows.Forms.TextBox txtNomCurso;
        private System.Windows.Forms.MaskedTextBox mskID;
        private System.Windows.Forms.GroupBox gbPropio;
        private System.Windows.Forms.MaskedTextBox mskHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbConv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbInsti;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label6;
    }
}