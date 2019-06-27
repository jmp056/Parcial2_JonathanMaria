namespace Parcial2_JonathanMaria.UI.Registros
{
    partial class rInscripciones
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
            this.FechaDeInscripcion = new System.Windows.Forms.Label();
            this.InscripcionIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InscripcionId = new System.Windows.Forms.Label();
            this.FechaDeInscripcionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EstudianteIdTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.RemoverAsignaturaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaDeInscripcion
            // 
            this.FechaDeInscripcion.AutoSize = true;
            this.FechaDeInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeInscripcion.Location = new System.Drawing.Point(59, 104);
            this.FechaDeInscripcion.Name = "FechaDeInscripcion";
            this.FechaDeInscripcion.Size = new System.Drawing.Size(147, 16);
            this.FechaDeInscripcion.TabIndex = 10;
            this.FechaDeInscripcion.Text = "Fecha de inscipcion";
            // 
            // InscripcionIdNumericUpDown
            // 
            this.InscripcionIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InscripcionIdNumericUpDown.Location = new System.Drawing.Point(215, 56);
            this.InscripcionIdNumericUpDown.Name = "InscripcionIdNumericUpDown";
            this.InscripcionIdNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.InscripcionIdNumericUpDown.TabIndex = 9;
            // 
            // InscripcionId
            // 
            this.InscripcionId.AutoSize = true;
            this.InscripcionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InscripcionId.Location = new System.Drawing.Point(59, 58);
            this.InscripcionId.Name = "InscripcionId";
            this.InscripcionId.Size = new System.Drawing.Size(100, 16);
            this.InscripcionId.TabIndex = 8;
            this.InscripcionId.Text = "Inscripcion Id";
            // 
            // FechaDeInscripcionDateTimePicker
            // 
            this.FechaDeInscripcionDateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechaDeInscripcionDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeInscripcionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDeInscripcionDateTimePicker.Location = new System.Drawing.Point(215, 104);
            this.FechaDeInscripcionDateTimePicker.Name = "FechaDeInscripcionDateTimePicker";
            this.FechaDeInscripcionDateTimePicker.Size = new System.Drawing.Size(120, 22);
            this.FechaDeInscripcionDateTimePicker.TabIndex = 7;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Location = new System.Drawing.Point(199, 384);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 15;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(332, 384);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 14;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(498, 384);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 13;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Location = new System.Drawing.Point(433, 78);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 12;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(21, 195);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(587, 150);
            this.DetalleDataGridView.TabIndex = 16;
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTextBox.Location = new System.Drawing.Point(489, 351);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.Size = new System.Drawing.Size(100, 22);
            this.ValorTextBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Estudiante Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nombre";
            // 
            // EstudianteIdTextBox
            // 
            this.EstudianteIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstudianteIdTextBox.Location = new System.Drawing.Point(163, 150);
            this.EstudianteIdTextBox.Name = "EstudianteIdTextBox";
            this.EstudianteIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.EstudianteIdTextBox.TabIndex = 20;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.Location = new System.Drawing.Point(363, 153);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(100, 22);
            this.NombreTextBox.TabIndex = 21;
            // 
            // RemoverAsignaturaButton
            // 
            this.RemoverAsignaturaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverAsignaturaButton.Location = new System.Drawing.Point(21, 350);
            this.RemoverAsignaturaButton.Name = "RemoverAsignaturaButton";
            this.RemoverAsignaturaButton.Size = new System.Drawing.Size(169, 29);
            this.RemoverAsignaturaButton.TabIndex = 22;
            this.RemoverAsignaturaButton.Text = "Remover Asignatura";
            this.RemoverAsignaturaButton.UseVisualStyleBackColor = true;
            // 
            // rInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RemoverAsignaturaButton);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.EstudianteIdTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValorTextBox);
            this.Controls.Add(this.DetalleDataGridView);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.FechaDeInscripcion);
            this.Controls.Add(this.InscripcionIdNumericUpDown);
            this.Controls.Add(this.InscripcionId);
            this.Controls.Add(this.FechaDeInscripcionDateTimePicker);
            this.Name = "rInscripciones";
            this.Text = "rInscripciones";
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FechaDeInscripcion;
        private System.Windows.Forms.NumericUpDown InscripcionIdNumericUpDown;
        private System.Windows.Forms.Label InscripcionId;
        private System.Windows.Forms.DateTimePicker FechaDeInscripcionDateTimePicker;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DataGridView DetalleDataGridView;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EstudianteIdTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Button RemoverAsignaturaButton;
    }
}