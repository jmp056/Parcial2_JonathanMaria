namespace Parcial2_JonathanMaria.UI.Consultas
{
    partial class cEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cEstudiantes));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ConsultarButton = new System.Windows.Forms.Button();
            this.ConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.CriterioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrarComboBox = new System.Windows.Forms.ComboBox();
            this.FiltrarFechaCheckBox = new System.Windows.Forms.CheckBox();
            this.FiltroFechaTroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).BeginInit();
            this.FiltroFechaTroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Hasta";
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.CustomFormat = "dd/MM/yy";
            this.DesdeDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(75, 52);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(110, 22);
            this.DesdeDateTimePicker.TabIndex = 22;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.CustomFormat = "dd/MM/yy";
            this.HastaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(75, 87);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(110, 22);
            this.HastaDateTimePicker.TabIndex = 21;
            // 
            // ConsultarButton
            // 
            this.ConsultarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarButton.Image = global::Parcial2_JonathanMaria.Properties.Resources.BotonConsultarEstudiantes;
            this.ConsultarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultarButton.Location = new System.Drawing.Point(455, 53);
            this.ConsultarButton.Name = "ConsultarButton";
            this.ConsultarButton.Size = new System.Drawing.Size(110, 30);
            this.ConsultarButton.TabIndex = 20;
            this.ConsultarButton.Text = "     Consultar";
            this.ConsultarButton.UseVisualStyleBackColor = true;
            this.ConsultarButton.Click += new System.EventHandler(this.ConsultarButton_Click);
            // 
            // ConsultaDataGridView
            // 
            this.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultaDataGridView.Location = new System.Drawing.Point(15, 145);
            this.ConsultaDataGridView.Name = "ConsultaDataGridView";
            this.ConsultaDataGridView.Size = new System.Drawing.Size(550, 150);
            this.ConsultaDataGridView.TabIndex = 19;
            // 
            // CriterioTextBox
            // 
            this.CriterioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CriterioTextBox.Location = new System.Drawing.Point(95, 87);
            this.CriterioTextBox.Name = "CriterioTextBox";
            this.CriterioTextBox.Size = new System.Drawing.Size(120, 22);
            this.CriterioTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Filtro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Criterio";
            // 
            // FiltrarComboBox
            // 
            this.FiltrarComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarComboBox.FormattingEnabled = true;
            this.FiltrarComboBox.Items.AddRange(new object[] {
            "Todo",
            "Id",
            "Nombre"});
            this.FiltrarComboBox.Location = new System.Drawing.Point(95, 37);
            this.FiltrarComboBox.Name = "FiltrarComboBox";
            this.FiltrarComboBox.Size = new System.Drawing.Size(119, 24);
            this.FiltrarComboBox.TabIndex = 15;
            this.FiltrarComboBox.Text = "Seleccione";
            // 
            // FiltrarFechaCheckBox
            // 
            this.FiltrarFechaCheckBox.AutoSize = true;
            this.FiltrarFechaCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiltrarFechaCheckBox.Location = new System.Drawing.Point(10, 20);
            this.FiltrarFechaCheckBox.Name = "FiltrarFechaCheckBox";
            this.FiltrarFechaCheckBox.Size = new System.Drawing.Size(187, 20);
            this.FiltrarFechaCheckBox.TabIndex = 25;
            this.FiltrarFechaCheckBox.Text = "Añadir el filtro de fecha";
            this.FiltrarFechaCheckBox.UseVisualStyleBackColor = true;
            // 
            // FiltroFechaTroupBox
            // 
            this.FiltroFechaTroupBox.Controls.Add(this.label4);
            this.FiltroFechaTroupBox.Controls.Add(this.FiltrarFechaCheckBox);
            this.FiltroFechaTroupBox.Controls.Add(this.HastaDateTimePicker);
            this.FiltroFechaTroupBox.Controls.Add(this.DesdeDateTimePicker);
            this.FiltroFechaTroupBox.Controls.Add(this.label3);
            this.FiltroFechaTroupBox.Location = new System.Drawing.Point(235, 5);
            this.FiltroFechaTroupBox.Name = "FiltroFechaTroupBox";
            this.FiltroFechaTroupBox.Size = new System.Drawing.Size(203, 126);
            this.FiltroFechaTroupBox.TabIndex = 26;
            this.FiltroFechaTroupBox.TabStop = false;
            // 
            // cEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 308);
            this.Controls.Add(this.FiltroFechaTroupBox);
            this.Controls.Add(this.ConsultarButton);
            this.Controls.Add(this.ConsultaDataGridView);
            this.Controls.Add(this.CriterioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FiltrarComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cEstudiantes";
            this.Text = "Consulta de Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultaDataGridView)).EndInit();
            this.FiltroFechaTroupBox.ResumeLayout(false);
            this.FiltroFechaTroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.Button ConsultarButton;
        private System.Windows.Forms.DataGridView ConsultaDataGridView;
        private System.Windows.Forms.TextBox CriterioTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltrarComboBox;
        private System.Windows.Forms.CheckBox FiltrarFechaCheckBox;
        private System.Windows.Forms.GroupBox FiltroFechaTroupBox;
    }
}