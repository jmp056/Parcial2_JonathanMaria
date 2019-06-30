namespace Parcial2_JonathanMaria.UI.Registros
{
    partial class rAsignaturas
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
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.CreditosLabel = new System.Windows.Forms.Label();
            this.AsignaturaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.AsignaturaIdLabel = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.CreditosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditosNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Location = new System.Drawing.Point(40, 247);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 23);
            this.NuevoButton.TabIndex = 23;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Location = new System.Drawing.Point(173, 247);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 23);
            this.GuardarButton.TabIndex = 22;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(339, 247);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 23);
            this.EliminarButton.TabIndex = 21;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreLabel.Location = new System.Drawing.Point(33, 59);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(63, 16);
            this.NombreLabel.TabIndex = 19;
            this.NombreLabel.Text = "Nombre";
            // 
            // CreditosLabel
            // 
            this.CreditosLabel.AutoSize = true;
            this.CreditosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditosLabel.Location = new System.Drawing.Point(33, 89);
            this.CreditosLabel.Name = "CreditosLabel";
            this.CreditosLabel.Size = new System.Drawing.Size(66, 16);
            this.CreditosLabel.TabIndex = 18;
            this.CreditosLabel.Text = "Creditos";
            // 
            // AsignaturaIdNumericUpDown
            // 
            this.AsignaturaIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsignaturaIdNumericUpDown.Location = new System.Drawing.Point(182, 26);
            this.AsignaturaIdNumericUpDown.Name = "AsignaturaIdNumericUpDown";
            this.AsignaturaIdNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.AsignaturaIdNumericUpDown.TabIndex = 17;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(189, 56);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(120, 22);
            this.DescripcionTextBox.TabIndex = 16;
            // 
            // AsignaturaIdLabel
            // 
            this.AsignaturaIdLabel.AutoSize = true;
            this.AsignaturaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsignaturaIdLabel.Location = new System.Drawing.Point(26, 28);
            this.AsignaturaIdLabel.Name = "AsignaturaIdLabel";
            this.AsignaturaIdLabel.Size = new System.Drawing.Size(99, 16);
            this.AsignaturaIdLabel.TabIndex = 15;
            this.AsignaturaIdLabel.Text = "Asignatura Id";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.Location = new System.Drawing.Point(339, 28);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 13;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // CreditosNumericUpDown
            // 
            this.CreditosNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditosNumericUpDown.Location = new System.Drawing.Point(173, 89);
            this.CreditosNumericUpDown.Name = "CreditosNumericUpDown";
            this.CreditosNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.CreditosNumericUpDown.TabIndex = 24;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rAsignaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 302);
            this.Controls.Add(this.CreditosNumericUpDown);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.CreditosLabel);
            this.Controls.Add(this.AsignaturaIdNumericUpDown);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.AsignaturaIdLabel);
            this.Controls.Add(this.BuscarButton);
            this.Name = "rAsignaturas";
            this.Text = "rAsignaturas";
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditosNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label CreditosLabel;
        private System.Windows.Forms.NumericUpDown AsignaturaIdNumericUpDown;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label AsignaturaIdLabel;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.NumericUpDown CreditosNumericUpDown;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}