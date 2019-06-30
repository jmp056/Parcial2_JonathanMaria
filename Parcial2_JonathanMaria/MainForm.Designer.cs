namespace Parcial2_JonathanMaria
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAsignatuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeInscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarAsignaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarEstudianteToolStripMenuItem,
            this.registrarAsignatuToolStripMenuItem,
            this.registroDeInscripcionesToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // registrarEstudianteToolStripMenuItem
            // 
            this.registrarEstudianteToolStripMenuItem.Name = "registrarEstudianteToolStripMenuItem";
            this.registrarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.registrarEstudianteToolStripMenuItem.Text = "Registro de Estudiantes";
            this.registrarEstudianteToolStripMenuItem.Click += new System.EventHandler(this.RegistrarEstudianteToolStripMenuItem_Click);
            // 
            // registrarAsignatuToolStripMenuItem
            // 
            this.registrarAsignatuToolStripMenuItem.Name = "registrarAsignatuToolStripMenuItem";
            this.registrarAsignatuToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.registrarAsignatuToolStripMenuItem.Text = "Registro de Asignaturas";
            this.registrarAsignatuToolStripMenuItem.Click += new System.EventHandler(this.RegistrarAsignatuToolStripMenuItem_Click);
            // 
            // registroDeInscripcionesToolStripMenuItem
            // 
            this.registroDeInscripcionesToolStripMenuItem.Name = "registroDeInscripcionesToolStripMenuItem";
            this.registroDeInscripcionesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.registroDeInscripcionesToolStripMenuItem.Text = "Registro de Inscripciones";
            this.registroDeInscripcionesToolStripMenuItem.Click += new System.EventHandler(this.RegistroDeInscripcionesToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarAsignaturasToolStripMenuItem,
            this.consultarEstudiantesToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultarAsignaturasToolStripMenuItem
            // 
            this.consultarAsignaturasToolStripMenuItem.Name = "consultarAsignaturasToolStripMenuItem";
            this.consultarAsignaturasToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.consultarAsignaturasToolStripMenuItem.Text = "Consultar Asignaturas";
            this.consultarAsignaturasToolStripMenuItem.Click += new System.EventHandler(this.ConsultarAsignaturasToolStripMenuItem_Click);
            // 
            // consultarEstudiantesToolStripMenuItem
            // 
            this.consultarEstudiantesToolStripMenuItem.Name = "consultarEstudiantesToolStripMenuItem";
            this.consultarEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.consultarEstudiantesToolStripMenuItem.Text = "Consultar Estudiantes";
            this.consultarEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.ConsultarEstudiantesToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAsignatuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeInscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarAsignaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarEstudiantesToolStripMenuItem;
    }
}

