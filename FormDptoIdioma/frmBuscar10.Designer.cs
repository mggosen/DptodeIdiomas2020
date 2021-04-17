namespace FormDptoIdioma
{
    partial class frmBuscar10
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lstListar = new System.Windows.Forms.ListBox();
            this.rbAlumnos = new System.Windows.Forms.RadioButton();
            this.rbProfesor = new System.Windows.Forms.RadioButton();
            this.rbCursos = new System.Windows.Forms.RadioButton();
            this.gpBuscar = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gpBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(347, 132);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(175, 20);
            this.txtBuscar.TabIndex = 0;
            // 
            // lstListar
            // 
            this.lstListar.FormattingEnabled = true;
            this.lstListar.Location = new System.Drawing.Point(25, 195);
            this.lstListar.Name = "lstListar";
            this.lstListar.Size = new System.Drawing.Size(605, 121);
            this.lstListar.TabIndex = 2;
            // 
            // rbAlumnos
            // 
            this.rbAlumnos.AutoSize = true;
            this.rbAlumnos.Location = new System.Drawing.Point(16, 35);
            this.rbAlumnos.Name = "rbAlumnos";
            this.rbAlumnos.Size = new System.Drawing.Size(65, 17);
            this.rbAlumnos.TabIndex = 3;
            this.rbAlumnos.TabStop = true;
            this.rbAlumnos.Text = "Alumnos";
            this.rbAlumnos.UseVisualStyleBackColor = true;
            // 
            // rbProfesor
            // 
            this.rbProfesor.AutoSize = true;
            this.rbProfesor.Location = new System.Drawing.Point(103, 35);
            this.rbProfesor.Name = "rbProfesor";
            this.rbProfesor.Size = new System.Drawing.Size(75, 17);
            this.rbProfesor.TabIndex = 3;
            this.rbProfesor.TabStop = true;
            this.rbProfesor.Text = "Profesores";
            this.rbProfesor.UseVisualStyleBackColor = true;
            // 
            // rbCursos
            // 
            this.rbCursos.AutoSize = true;
            this.rbCursos.Location = new System.Drawing.Point(201, 35);
            this.rbCursos.Name = "rbCursos";
            this.rbCursos.Size = new System.Drawing.Size(57, 17);
            this.rbCursos.TabIndex = 3;
            this.rbCursos.TabStop = true;
            this.rbCursos.Text = "Cursos";
            this.rbCursos.UseVisualStyleBackColor = true;
            // 
            // gpBuscar
            // 
            this.gpBuscar.Controls.Add(this.rbAlumnos);
            this.gpBuscar.Controls.Add(this.rbCursos);
            this.gpBuscar.Controls.Add(this.rbProfesor);
            this.gpBuscar.Location = new System.Drawing.Point(25, 84);
            this.gpBuscar.Name = "gpBuscar";
            this.gpBuscar.Size = new System.Drawing.Size(286, 68);
            this.gpBuscar.TabIndex = 4;
            this.gpBuscar.TabStop = false;
            this.gpBuscar.Text = "Buscar por:";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnVolver.Location = new System.Drawing.Point(696, 351);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(81, 39);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Liberation Mono", 20.25F);
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(234, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar y Recuperar ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscar.Location = new System.Drawing.Point(528, 125);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(107, 33);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmBuscar10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.gpBuscar);
            this.Controls.Add(this.lstListar);
            this.Controls.Add(this.txtBuscar);
            this.Name = "frmBuscar10";
            this.Text = "Buscar Persona";
            this.gpBuscar.ResumeLayout(false);
            this.gpBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ListBox lstListar;
        private System.Windows.Forms.RadioButton rbAlumnos;
        private System.Windows.Forms.RadioButton rbProfesor;
        private System.Windows.Forms.RadioButton rbCursos;
        private System.Windows.Forms.GroupBox gpBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
    }
}