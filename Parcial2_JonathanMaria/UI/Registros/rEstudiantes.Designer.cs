namespace Parcial2_JonathanMaria.UI.Registros
{
    partial class rEstudiantes
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
            this.components = new System.ComponentModel.Container();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.FechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.EstudianteIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaDeIngreso = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Balance = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BalanceTextBox = new System.Windows.Forms.TextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Location = new System.Drawing.Point(318, 49);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 0;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // FechaIngresoDateTimePicker
            // 
            this.FechaIngresoDateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechaIngresoDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIngresoDateTimePicker.Location = new System.Drawing.Point(168, 110);
            this.FechaIngresoDateTimePicker.Name = "FechaIngresoDateTimePicker";
            this.FechaIngresoDateTimePicker.Size = new System.Drawing.Size(120, 22);
            this.FechaIngresoDateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Estudinte Id";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.Location = new System.Drawing.Point(168, 77);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(120, 22);
            this.NombreTextBox.TabIndex = 3;
            // 
            // EstudianteIdNumericUpDown
            // 
            this.EstudianteIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstudianteIdNumericUpDown.Location = new System.Drawing.Point(161, 47);
            this.EstudianteIdNumericUpDown.Name = "EstudianteIdNumericUpDown";
            this.EstudianteIdNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.EstudianteIdNumericUpDown.TabIndex = 4;
            // 
            // FechaDeIngreso
            // 
            this.FechaDeIngreso.AutoSize = true;
            this.FechaDeIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeIngreso.Location = new System.Drawing.Point(12, 110);
            this.FechaDeIngreso.Name = "FechaDeIngreso";
            this.FechaDeIngreso.Size = new System.Drawing.Size(129, 16);
            this.FechaDeIngreso.TabIndex = 6;
            this.FechaDeIngreso.Text = "Fecha de ingreso";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(12, 80);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(63, 16);
            this.Nombre.TabIndex = 7;
            this.Nombre.Text = "Nombre";
            // 
            // Balance
            // 
            this.Balance.AutoSize = true;
            this.Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.Location = new System.Drawing.Point(12, 200);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(65, 16);
            this.Balance.TabIndex = 8;
            this.Balance.Text = "Balance";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(318, 268);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 9;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(152, 268);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 10;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Location = new System.Drawing.Point(19, 268);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 11;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BalanceTextBox
            // 
            this.BalanceTextBox.Enabled = false;
            this.BalanceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceTextBox.Location = new System.Drawing.Point(152, 164);
            this.BalanceTextBox.Name = "BalanceTextBox";
            this.BalanceTextBox.Size = new System.Drawing.Size(120, 22);
            this.BalanceTextBox.TabIndex = 12;
            this.BalanceTextBox.Text = "0";
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 322);
            this.Controls.Add(this.BalanceTextBox);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.Balance);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.FechaDeIngreso);
            this.Controls.Add(this.EstudianteIdNumericUpDown);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechaIngresoDateTimePicker);
            this.Controls.Add(this.BuscarButton);
            this.Name = "rEstudiantes";
            this.Text = "rEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.DateTimePicker FechaIngresoDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.NumericUpDown EstudianteIdNumericUpDown;
        private System.Windows.Forms.Label FechaDeIngreso;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Balance;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox BalanceTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}