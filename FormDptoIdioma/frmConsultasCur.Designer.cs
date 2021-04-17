namespace FormDptoIdioma
{
    partial class frmConsultasCur
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
            this.rbPropio = new System.Windows.Forms.RadioButton();
            this.rbConvenio = new System.Windows.Forms.RadioButton();
            this.lstCursos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProfe = new System.Windows.Forms.Button();
            this.btnInsti = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gpCursos = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.gbPropio = new System.Windows.Forms.GroupBox();
            this.cbProfesor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbConv = new System.Windows.Forms.GroupBox();
            this.cbIDInsti = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlu = new System.Windows.Forms.Button();
            this.gbAlumno = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbNroLu = new System.Windows.Forms.ComboBox();
            this.gpCursos.SuspendLayout();
            this.gbPropio.SuspendLayout();
            this.gbConv.SuspendLayout();
            this.gbAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbPropio
            // 
            this.rbPropio.AutoSize = true;
            this.rbPropio.Location = new System.Drawing.Point(20, 34);
            this.rbPropio.Name = "rbPropio";
            this.rbPropio.Size = new System.Drawing.Size(55, 17);
            this.rbPropio.TabIndex = 0;
            this.rbPropio.Text = "Propio";
            this.rbPropio.UseVisualStyleBackColor = true;
            this.rbPropio.CheckedChanged += new System.EventHandler(this.rbPropio_CheckedChanged);
            // 
            // rbConvenio
            // 
            this.rbConvenio.AutoSize = true;
            this.rbConvenio.Location = new System.Drawing.Point(223, 34);
            this.rbConvenio.Name = "rbConvenio";
            this.rbConvenio.Size = new System.Drawing.Size(70, 17);
            this.rbConvenio.TabIndex = 1;
            this.rbConvenio.Text = "Convenio";
            this.rbConvenio.UseVisualStyleBackColor = true;
            this.rbConvenio.CheckedChanged += new System.EventHandler(this.rbConvenio_CheckedChanged);
            // 
            // lstCursos
            // 
            this.lstCursos.FormattingEnabled = true;
            this.lstCursos.Location = new System.Drawing.Point(117, 286);
            this.lstCursos.Name = "lstCursos";
            this.lstCursos.Size = new System.Drawing.Size(527, 95);
            this.lstCursos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Liberation Mono", 20.25F);
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(201, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Consultas Cursos D.I 2020";
            // 
            // btnProfe
            // 
            this.btnProfe.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProfe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProfe.Location = new System.Drawing.Point(41, 68);
            this.btnProfe.Name = "btnProfe";
            this.btnProfe.Size = new System.Drawing.Size(105, 29);
            this.btnProfe.TabIndex = 5;
            this.btnProfe.Text = "Consulta Profesor";
            this.btnProfe.UseVisualStyleBackColor = false;
            this.btnProfe.Click += new System.EventHandler(this.btnProfe_Click);
            // 
            // btnInsti
            // 
            this.btnInsti.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnInsti.Location = new System.Drawing.Point(33, 68);
            this.btnInsti.Name = "btnInsti";
            this.btnInsti.Size = new System.Drawing.Size(105, 29);
            this.btnInsti.TabIndex = 6;
            this.btnInsti.Text = "Consulta Instituto";
            this.btnInsti.UseVisualStyleBackColor = false;
            this.btnInsti.Click += new System.EventHandler(this.btnInsti_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVolver.Location = new System.Drawing.Point(702, 348);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(86, 33);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gpCursos
            // 
            this.gpCursos.Controls.Add(this.rbTodos);
            this.gpCursos.Controls.Add(this.rbConvenio);
            this.gpCursos.Controls.Add(this.rbPropio);
            this.gpCursos.Location = new System.Drawing.Point(107, 93);
            this.gpCursos.Name = "gpCursos";
            this.gpCursos.Size = new System.Drawing.Size(537, 66);
            this.gpCursos.TabIndex = 11;
            this.gpCursos.TabStop = false;
            this.gpCursos.Text = "Cursos";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(450, 34);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 15;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // gbPropio
            // 
            this.gbPropio.Controls.Add(this.cbProfesor);
            this.gbPropio.Controls.Add(this.label2);
            this.gbPropio.Controls.Add(this.btnProfe);
            this.gbPropio.Location = new System.Drawing.Point(107, 171);
            this.gbPropio.Name = "gbPropio";
            this.gbPropio.Size = new System.Drawing.Size(164, 109);
            this.gbPropio.TabIndex = 12;
            this.gbPropio.TabStop = false;
            this.gbPropio.Text = "Curso Propio";
            // 
            // cbProfesor
            // 
            this.cbProfesor.FormattingEnabled = true;
            this.cbProfesor.Location = new System.Drawing.Point(41, 42);
            this.cbProfesor.Name = "cbProfesor";
            this.cbProfesor.Size = new System.Drawing.Size(104, 21);
            this.cbProfesor.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "N° LEGAJO";
            // 
            // gbConv
            // 
            this.gbConv.Controls.Add(this.cbIDInsti);
            this.gbConv.Controls.Add(this.label3);
            this.gbConv.Controls.Add(this.btnInsti);
            this.gbConv.Location = new System.Drawing.Point(301, 165);
            this.gbConv.Name = "gbConv";
            this.gbConv.Size = new System.Drawing.Size(164, 109);
            this.gbConv.TabIndex = 13;
            this.gbConv.TabStop = false;
            this.gbConv.Text = "Curso por Convenio";
            // 
            // cbIDInsti
            // 
            this.cbIDInsti.FormattingEnabled = true;
            this.cbIDInsti.Location = new System.Drawing.Point(14, 42);
            this.cbIDInsti.Name = "cbIDInsti";
            this.cbIDInsti.Size = new System.Drawing.Size(133, 21);
            this.cbIDInsti.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID Instituto";
            // 
            // btnAlu
            // 
            this.btnAlu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAlu.Location = new System.Drawing.Point(16, 77);
            this.btnAlu.Name = "btnAlu";
            this.btnAlu.Size = new System.Drawing.Size(106, 26);
            this.btnAlu.TabIndex = 14;
            this.btnAlu.Text = "Consulta Alumno";
            this.btnAlu.UseVisualStyleBackColor = false;
            this.btnAlu.Click += new System.EventHandler(this.btnAlu_Click);
            // 
            // gbAlumno
            // 
            this.gbAlumno.Controls.Add(this.label4);
            this.gbAlumno.Controls.Add(this.cbNroLu);
            this.gbAlumno.Controls.Add(this.btnAlu);
            this.gbAlumno.Location = new System.Drawing.Point(492, 165);
            this.gbAlumno.Name = "gbAlumno";
            this.gbAlumno.Size = new System.Drawing.Size(142, 109);
            this.gbAlumno.TabIndex = 15;
            this.gbAlumno.TabStop = false;
            this.gbAlumno.Text = "Alumnos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "N° LU";
            // 
            // cbNroLu
            // 
            this.cbNroLu.FormattingEnabled = true;
            this.cbNroLu.Location = new System.Drawing.Point(16, 50);
            this.cbNroLu.Name = "cbNroLu";
            this.cbNroLu.Size = new System.Drawing.Size(103, 21);
            this.cbNroLu.TabIndex = 16;
            // 
            // frmConsultasCur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbAlumno);
            this.Controls.Add(this.gbConv);
            this.Controls.Add(this.gbPropio);
            this.Controls.Add(this.gpCursos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCursos);
            this.Name = "frmConsultasCur";
            this.Text = "Consultar Cursos";
            this.Load += new System.EventHandler(this.frmConsultasCur_Load);
            this.gpCursos.ResumeLayout(false);
            this.gpCursos.PerformLayout();
            this.gbPropio.ResumeLayout(false);
            this.gbPropio.PerformLayout();
            this.gbConv.ResumeLayout(false);
            this.gbConv.PerformLayout();
            this.gbAlumno.ResumeLayout(false);
            this.gbAlumno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPropio;
        private System.Windows.Forms.RadioButton rbConvenio;
        private System.Windows.Forms.ListBox lstCursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProfe;
        private System.Windows.Forms.Button btnInsti;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gpCursos;
        private System.Windows.Forms.GroupBox gbPropio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbConv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProfesor;
        private System.Windows.Forms.ComboBox cbIDInsti;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.Button btnAlu;
        private System.Windows.Forms.GroupBox gbAlumno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbNroLu;
    }
}