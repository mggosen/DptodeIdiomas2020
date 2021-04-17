namespace FormDptoIdioma
{
    partial class frmConsultasP
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
            this.lstPersonas = new System.Windows.Forms.ListBox();
            this.rbProfesor = new System.Windows.Forms.RadioButton();
            this.rbAlumnos = new System.Windows.Forms.RadioButton();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.bntVolver = new System.Windows.Forms.Button();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.gpPersonas = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskDNI = new System.Windows.Forms.MaskedTextBox();
            this.gpBuscar = new System.Windows.Forms.GroupBox();
            this.gpEliminar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskeliminar = new System.Windows.Forms.MaskedTextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gpPersonas.SuspendLayout();
            this.gpBuscar.SuspendLayout();
            this.gpEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPersonas
            // 
            this.lstPersonas.FormattingEnabled = true;
            this.lstPersonas.Location = new System.Drawing.Point(12, 116);
            this.lstPersonas.Name = "lstPersonas";
            this.lstPersonas.Size = new System.Drawing.Size(549, 121);
            this.lstPersonas.TabIndex = 0;
            // 
            // rbProfesor
            // 
            this.rbProfesor.AutoSize = true;
            this.rbProfesor.Checked = true;
            this.rbProfesor.Location = new System.Drawing.Point(28, 33);
            this.rbProfesor.Name = "rbProfesor";
            this.rbProfesor.Size = new System.Drawing.Size(75, 17);
            this.rbProfesor.TabIndex = 1;
            this.rbProfesor.TabStop = true;
            this.rbProfesor.Text = "Profesores";
            this.rbProfesor.UseVisualStyleBackColor = true;
            this.rbProfesor.CheckedChanged += new System.EventHandler(this.rbProfesor_CheckedChanged);
            // 
            // rbAlumnos
            // 
            this.rbAlumnos.AutoSize = true;
            this.rbAlumnos.Location = new System.Drawing.Point(141, 33);
            this.rbAlumnos.Name = "rbAlumnos";
            this.rbAlumnos.Size = new System.Drawing.Size(65, 17);
            this.rbAlumnos.TabIndex = 2;
            this.rbAlumnos.Text = "Alumnos";
            this.rbAlumnos.UseVisualStyleBackColor = true;
            this.rbAlumnos.CheckedChanged += new System.EventHandler(this.rbAlumnos_CheckedChanged);
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAplicar.ForeColor = System.Drawing.Color.Black;
            this.btnAplicar.Location = new System.Drawing.Point(615, 253);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(75, 28);
            this.btnAplicar.TabIndex = 4;
            this.btnAplicar.Text = "Buscar";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // bntVolver
            // 
            this.bntVolver.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bntVolver.Location = new System.Drawing.Point(671, 353);
            this.bntVolver.Name = "bntVolver";
            this.bntVolver.Size = new System.Drawing.Size(92, 32);
            this.bntVolver.TabIndex = 5;
            this.bntVolver.Text = "Volver";
            this.bntVolver.UseVisualStyleBackColor = false;
            this.bntVolver.Click += new System.EventHandler(this.bntVolver_Click);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(255, 33);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 6;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // gpPersonas
            // 
            this.gpPersonas.Controls.Add(this.rbTodos);
            this.gpPersonas.Controls.Add(this.rbAlumnos);
            this.gpPersonas.Controls.Add(this.rbProfesor);
            this.gpPersonas.Location = new System.Drawing.Point(12, 27);
            this.gpPersonas.Name = "gpPersonas";
            this.gpPersonas.Size = new System.Drawing.Size(337, 81);
            this.gpPersonas.TabIndex = 7;
            this.gpPersonas.TabStop = false;
            this.gpPersonas.Text = "Consultar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "DNI Persona";
            // 
            // mskDNI
            // 
            this.mskDNI.Location = new System.Drawing.Point(102, 42);
            this.mskDNI.Mask = "09999999";
            this.mskDNI.Name = "mskDNI";
            this.mskDNI.Size = new System.Drawing.Size(133, 20);
            this.mskDNI.TabIndex = 9;
            // 
            // gpBuscar
            // 
            this.gpBuscar.Controls.Add(this.mskDNI);
            this.gpBuscar.Controls.Add(this.label1);
            this.gpBuscar.Location = new System.Drawing.Point(21, 253);
            this.gpBuscar.Name = "gpBuscar";
            this.gpBuscar.Size = new System.Drawing.Size(240, 78);
            this.gpBuscar.TabIndex = 10;
            this.gpBuscar.TabStop = false;
            this.gpBuscar.Text = "Buscar Persona";
            // 
            // gpEliminar
            // 
            this.gpEliminar.Controls.Add(this.label2);
            this.gpEliminar.Controls.Add(this.mskeliminar);
            this.gpEliminar.Location = new System.Drawing.Point(329, 246);
            this.gpEliminar.Name = "gpEliminar";
            this.gpEliminar.Size = new System.Drawing.Size(245, 85);
            this.gpEliminar.TabIndex = 11;
            this.gpEliminar.TabStop = false;
            this.gpEliminar.Text = "Eliminar Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI Persona";
            // 
            // mskeliminar
            // 
            this.mskeliminar.Location = new System.Drawing.Point(104, 49);
            this.mskeliminar.Mask = "09999999";
            this.mskeliminar.Name = "mskeliminar";
            this.mskeliminar.Size = new System.Drawing.Size(122, 20);
            this.mskeliminar.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEliminar.Location = new System.Drawing.Point(615, 285);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Liberation Mono", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Location = new System.Drawing.Point(526, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "Consulta Persona";
            // 
            // frmConsultasP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.gpEliminar);
            this.Controls.Add(this.gpBuscar);
            this.Controls.Add(this.gpPersonas);
            this.Controls.Add(this.bntVolver);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.lstPersonas);
            this.Name = "frmConsultasP";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.frmConsultasP_Load);
            this.gpPersonas.ResumeLayout(false);
            this.gpPersonas.PerformLayout();
            this.gpBuscar.ResumeLayout(false);
            this.gpBuscar.PerformLayout();
            this.gpEliminar.ResumeLayout(false);
            this.gpEliminar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPersonas;
        private System.Windows.Forms.RadioButton rbProfesor;
        private System.Windows.Forms.RadioButton rbAlumnos;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button bntVolver;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.GroupBox gpPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskDNI;
        private System.Windows.Forms.GroupBox gpBuscar;
        private System.Windows.Forms.GroupBox gpEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskeliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
    }
}