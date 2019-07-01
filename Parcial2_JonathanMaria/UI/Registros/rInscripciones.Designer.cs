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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rInscripciones));
            this.FechaDeInscripcion = new System.Windows.Forms.Label();
            this.InscripcionIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.InscripcionId = new System.Windows.Forms.Label();
            this.FechaDeInscripcionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Creditos = new System.Windows.Forms.Label();
            this.CreditosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EstudianteId = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.EstudianteIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecioDeLosCreditos = new System.Windows.Forms.Label();
            this.PrecioCreditosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AsignaturaIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Valor = new System.Windows.Forms.Label();
            this.PrecioTextBox = new System.Windows.Forms.TextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EstudianteGroupBox = new System.Windows.Forms.GroupBox();
            this.RegistroEstudiantesButton = new System.Windows.Forms.Button();
            this.ConsultaEstudiantesButton = new System.Windows.Forms.Button();
            this.CargarEstudianteButton = new System.Windows.Forms.Button();
            this.AsignaturasGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RegistroAsignaturasButton = new System.Windows.Forms.Button();
            this.ConsultarAsignaturasButton = new System.Windows.Forms.Button();
            this.RemoverAsignaturaButton = new System.Windows.Forms.Button();
            this.CargarAsignaturaButton = new System.Windows.Forms.Button();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditosNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioCreditosNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.EstudianteGroupBox.SuspendLayout();
            this.AsignaturasGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FechaDeInscripcion
            // 
            this.FechaDeInscripcion.AutoSize = true;
            this.FechaDeInscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeInscripcion.Location = new System.Drawing.Point(15, 65);
            this.FechaDeInscripcion.Name = "FechaDeInscripcion";
            this.FechaDeInscripcion.Size = new System.Drawing.Size(147, 16);
            this.FechaDeInscripcion.TabIndex = 10;
            this.FechaDeInscripcion.Text = "Fecha de inscipcion";
            // 
            // InscripcionIdNumericUpDown
            // 
            this.InscripcionIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InscripcionIdNumericUpDown.Location = new System.Drawing.Point(173, 30);
            this.InscripcionIdNumericUpDown.Name = "InscripcionIdNumericUpDown";
            this.InscripcionIdNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.InscripcionIdNumericUpDown.TabIndex = 9;
            // 
            // InscripcionId
            // 
            this.InscripcionId.AutoSize = true;
            this.InscripcionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InscripcionId.Location = new System.Drawing.Point(15, 30);
            this.InscripcionId.Name = "InscripcionId";
            this.InscripcionId.Size = new System.Drawing.Size(100, 16);
            this.InscripcionId.TabIndex = 8;
            this.InscripcionId.Text = "Id Inscripcion";
            // 
            // FechaDeInscripcionDateTimePicker
            // 
            this.FechaDeInscripcionDateTimePicker.CustomFormat = "dd/MM/yy";
            this.FechaDeInscripcionDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaDeInscripcionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDeInscripcionDateTimePicker.Location = new System.Drawing.Point(173, 65);
            this.FechaDeInscripcionDateTimePicker.Name = "FechaDeInscripcionDateTimePicker";
            this.FechaDeInscripcionDateTimePicker.Size = new System.Drawing.Size(120, 22);
            this.FechaDeInscripcionDateTimePicker.TabIndex = 7;
            // 
            // DetalleDataGridView
            // 
            this.DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalleDataGridView.Location = new System.Drawing.Point(13, 139);
            this.DetalleDataGridView.Name = "DetalleDataGridView";
            this.DetalleDataGridView.Size = new System.Drawing.Size(507, 110);
            this.DetalleDataGridView.TabIndex = 16;
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Enabled = false;
            this.ValorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorTextBox.Location = new System.Drawing.Point(420, 255);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.Size = new System.Drawing.Size(100, 22);
            this.ValorTextBox.TabIndex = 17;
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Enabled = false;
            this.DescripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripcionTextBox.Location = new System.Drawing.Point(120, 111);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(180, 22);
            this.DescripcionTextBox.TabIndex = 24;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(10, 113);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(91, 16);
            this.Descripcion.TabIndex = 25;
            this.Descripcion.Text = "Descripcion";
            // 
            // Creditos
            // 
            this.Creditos.AutoSize = true;
            this.Creditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creditos.Location = new System.Drawing.Point(315, 78);
            this.Creditos.Name = "Creditos";
            this.Creditos.Size = new System.Drawing.Size(66, 16);
            this.Creditos.TabIndex = 27;
            this.Creditos.Text = "Creditos";
            // 
            // CreditosNumericUpDown
            // 
            this.CreditosNumericUpDown.Enabled = false;
            this.CreditosNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditosNumericUpDown.Location = new System.Drawing.Point(420, 75);
            this.CreditosNumericUpDown.Name = "CreditosNumericUpDown";
            this.CreditosNumericUpDown.Size = new System.Drawing.Size(58, 22);
            this.CreditosNumericUpDown.TabIndex = 36;
            this.CreditosNumericUpDown.ValueChanged += new System.EventHandler(this.CreditosNumericUpDown_ValueChanged);
            // 
            // EstudianteId
            // 
            this.EstudianteId.AutoSize = true;
            this.EstudianteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstudianteId.Location = new System.Drawing.Point(10, 25);
            this.EstudianteId.Name = "EstudianteId";
            this.EstudianteId.Size = new System.Drawing.Size(98, 16);
            this.EstudianteId.TabIndex = 38;
            this.EstudianteId.Text = "Id Estudiante";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(10, 60);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(63, 16);
            this.Nombre.TabIndex = 40;
            this.Nombre.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Enabled = false;
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTextBox.Location = new System.Drawing.Point(120, 60);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(180, 22);
            this.NombreTextBox.TabIndex = 39;
            // 
            // EstudianteIdNumericUpDown
            // 
            this.EstudianteIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstudianteIdNumericUpDown.Location = new System.Drawing.Point(120, 25);
            this.EstudianteIdNumericUpDown.Name = "EstudianteIdNumericUpDown";
            this.EstudianteIdNumericUpDown.Size = new System.Drawing.Size(60, 22);
            this.EstudianteIdNumericUpDown.TabIndex = 41;
            // 
            // PrecioDeLosCreditos
            // 
            this.PrecioDeLosCreditos.AutoSize = true;
            this.PrecioDeLosCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioDeLosCreditos.Location = new System.Drawing.Point(15, 215);
            this.PrecioDeLosCreditos.Name = "PrecioDeLosCreditos";
            this.PrecioDeLosCreditos.Size = new System.Drawing.Size(160, 16);
            this.PrecioDeLosCreditos.TabIndex = 42;
            this.PrecioDeLosCreditos.Text = "Precio de los creditos";
            // 
            // PrecioCreditosNumericUpDown
            // 
            this.PrecioCreditosNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioCreditosNumericUpDown.Location = new System.Drawing.Point(190, 213);
            this.PrecioCreditosNumericUpDown.Name = "PrecioCreditosNumericUpDown";
            this.PrecioCreditosNumericUpDown.Size = new System.Drawing.Size(57, 22);
            this.PrecioCreditosNumericUpDown.TabIndex = 43;
            this.PrecioCreditosNumericUpDown.ValueChanged += new System.EventHandler(this.PrecioCreditosNumericUpDown_ValueChanged);
            // 
            // AsignaturaIdNumericUpDown
            // 
            this.AsignaturaIdNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsignaturaIdNumericUpDown.Location = new System.Drawing.Point(120, 78);
            this.AsignaturaIdNumericUpDown.Name = "AsignaturaIdNumericUpDown";
            this.AsignaturaIdNumericUpDown.Size = new System.Drawing.Size(60, 22);
            this.AsignaturaIdNumericUpDown.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 44;
            this.label1.Text = "Id Asignatura";
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor.Location = new System.Drawing.Point(315, 113);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(97, 16);
            this.Valor.TabIndex = 47;
            this.Valor.Text = "Precio (RD$)";
            // 
            // PrecioTextBox
            // 
            this.PrecioTextBox.Enabled = false;
            this.PrecioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioTextBox.Location = new System.Drawing.Point(420, 111);
            this.PrecioTextBox.Name = "PrecioTextBox";
            this.PrecioTextBox.Size = new System.Drawing.Size(58, 22);
            this.PrecioTextBox.TabIndex = 46;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // EstudianteGroupBox
            // 
            this.EstudianteGroupBox.Controls.Add(this.RegistroEstudiantesButton);
            this.EstudianteGroupBox.Controls.Add(this.ConsultaEstudiantesButton);
            this.EstudianteGroupBox.Controls.Add(this.EstudianteIdNumericUpDown);
            this.EstudianteGroupBox.Controls.Add(this.EstudianteId);
            this.EstudianteGroupBox.Controls.Add(this.CargarEstudianteButton);
            this.EstudianteGroupBox.Controls.Add(this.Nombre);
            this.EstudianteGroupBox.Controls.Add(this.NombreTextBox);
            this.EstudianteGroupBox.Location = new System.Drawing.Point(15, 100);
            this.EstudianteGroupBox.Name = "EstudianteGroupBox";
            this.EstudianteGroupBox.Size = new System.Drawing.Size(550, 100);
            this.EstudianteGroupBox.TabIndex = 56;
            this.EstudianteGroupBox.TabStop = false;
            // 
            // RegistroEstudiantesButton
            // 
            this.RegistroEstudiantesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistroEstudiantesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistroEstudiantesButton.Location = new System.Drawing.Point(330, 58);
            this.RegistroEstudiantesButton.Name = "RegistroEstudiantesButton";
            this.RegistroEstudiantesButton.Size = new System.Drawing.Size(205, 30);
            this.RegistroEstudiantesButton.TabIndex = 52;
            this.RegistroEstudiantesButton.Text = "Registro de Estudiantes";
            this.RegistroEstudiantesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistroEstudiantesButton.UseVisualStyleBackColor = true;
            this.RegistroEstudiantesButton.Click += new System.EventHandler(this.RegistroEstudiantesButton_Click);
            // 
            // ConsultaEstudiantesButton
            // 
            this.ConsultaEstudiantesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultaEstudiantesButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultaEstudiantesButton.Location = new System.Drawing.Point(330, 20);
            this.ConsultaEstudiantesButton.Name = "ConsultaEstudiantesButton";
            this.ConsultaEstudiantesButton.Size = new System.Drawing.Size(205, 30);
            this.ConsultaEstudiantesButton.TabIndex = 51;
            this.ConsultaEstudiantesButton.Text = "    Consultar Estudiantes";
            this.ConsultaEstudiantesButton.UseVisualStyleBackColor = true;
            this.ConsultaEstudiantesButton.Click += new System.EventHandler(this.ConsultaEstudiantesButton_Click);
            // 
            // CargarEstudianteButton
            // 
            this.CargarEstudianteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarEstudianteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CargarEstudianteButton.Location = new System.Drawing.Point(210, 20);
            this.CargarEstudianteButton.Name = "CargarEstudianteButton";
            this.CargarEstudianteButton.Size = new System.Drawing.Size(90, 30);
            this.CargarEstudianteButton.TabIndex = 53;
            this.CargarEstudianteButton.Text = "Cargar";
            this.CargarEstudianteButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CargarEstudianteButton.UseVisualStyleBackColor = true;
            this.CargarEstudianteButton.Click += new System.EventHandler(this.CargarEstudianteButton_Click);
            // 
            // AsignaturasGroupBox
            // 
            this.AsignaturasGroupBox.Controls.Add(this.label2);
            this.AsignaturasGroupBox.Controls.Add(this.label1);
            this.AsignaturasGroupBox.Controls.Add(this.DetalleDataGridView);
            this.AsignaturasGroupBox.Controls.Add(this.RegistroAsignaturasButton);
            this.AsignaturasGroupBox.Controls.Add(this.ValorTextBox);
            this.AsignaturasGroupBox.Controls.Add(this.ConsultarAsignaturasButton);
            this.AsignaturasGroupBox.Controls.Add(this.RemoverAsignaturaButton);
            this.AsignaturasGroupBox.Controls.Add(this.CargarAsignaturaButton);
            this.AsignaturasGroupBox.Controls.Add(this.DescripcionTextBox);
            this.AsignaturasGroupBox.Controls.Add(this.Valor);
            this.AsignaturasGroupBox.Controls.Add(this.Descripcion);
            this.AsignaturasGroupBox.Controls.Add(this.PrecioTextBox);
            this.AsignaturasGroupBox.Controls.Add(this.Creditos);
            this.AsignaturasGroupBox.Controls.Add(this.AsignaturaIdNumericUpDown);
            this.AsignaturasGroupBox.Controls.Add(this.AgregarButton);
            this.AsignaturasGroupBox.Controls.Add(this.CreditosNumericUpDown);
            this.AsignaturasGroupBox.Location = new System.Drawing.Point(15, 241);
            this.AsignaturasGroupBox.Name = "AsignaturasGroupBox";
            this.AsignaturasGroupBox.Size = new System.Drawing.Size(550, 290);
            this.AsignaturasGroupBox.TabIndex = 57;
            this.AsignaturasGroupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Valor (RD$)";
            // 
            // RegistroAsignaturasButton
            // 
            this.RegistroAsignaturasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistroAsignaturasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RegistroAsignaturasButton.Location = new System.Drawing.Point(295, 25);
            this.RegistroAsignaturasButton.Name = "RegistroAsignaturasButton";
            this.RegistroAsignaturasButton.Size = new System.Drawing.Size(205, 30);
            this.RegistroAsignaturasButton.TabIndex = 50;
            this.RegistroAsignaturasButton.Text = "Registro de Asignaturas";
            this.RegistroAsignaturasButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RegistroAsignaturasButton.UseVisualStyleBackColor = true;
            this.RegistroAsignaturasButton.Click += new System.EventHandler(this.RegistroAsignaturasButton_Click);
            // 
            // ConsultarAsignaturasButton
            // 
            this.ConsultarAsignaturasButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsultarAsignaturasButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ConsultarAsignaturasButton.Location = new System.Drawing.Point(25, 25);
            this.ConsultarAsignaturasButton.Name = "ConsultarAsignaturasButton";
            this.ConsultarAsignaturasButton.Size = new System.Drawing.Size(205, 30);
            this.ConsultarAsignaturasButton.TabIndex = 49;
            this.ConsultarAsignaturasButton.Text = "    Consultar asignaturas";
            this.ConsultarAsignaturasButton.UseVisualStyleBackColor = true;
            this.ConsultarAsignaturasButton.Click += new System.EventHandler(this.ConsultarAsignaturasButton_Click);
            // 
            // RemoverAsignaturaButton
            // 
            this.RemoverAsignaturaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoverAsignaturaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverAsignaturaButton.Location = new System.Drawing.Point(15, 255);
            this.RemoverAsignaturaButton.Name = "RemoverAsignaturaButton";
            this.RemoverAsignaturaButton.Size = new System.Drawing.Size(180, 30);
            this.RemoverAsignaturaButton.TabIndex = 22;
            this.RemoverAsignaturaButton.Text = "Remover Asignatura";
            this.RemoverAsignaturaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverAsignaturaButton.UseVisualStyleBackColor = true;
            this.RemoverAsignaturaButton.Click += new System.EventHandler(this.RemoverAsignaturaButton_Click);
            // 
            // CargarAsignaturaButton
            // 
            this.CargarAsignaturaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CargarAsignaturaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CargarAsignaturaButton.Location = new System.Drawing.Point(210, 73);
            this.CargarAsignaturaButton.Name = "CargarAsignaturaButton";
            this.CargarAsignaturaButton.Size = new System.Drawing.Size(90, 30);
            this.CargarAsignaturaButton.TabIndex = 48;
            this.CargarAsignaturaButton.Text = "Cargar";
            this.CargarAsignaturaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CargarAsignaturaButton.UseVisualStyleBackColor = true;
            this.CargarAsignaturaButton.Click += new System.EventHandler(this.CargarAsignaturaButton_Click);
            // 
            // AgregarButton
            // 
            this.AgregarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarButton.Location = new System.Drawing.Point(490, 85);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(45, 40);
            this.AgregarButton.TabIndex = 33;
            this.AgregarButton.UseVisualStyleBackColor = true;
            this.AgregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(50, 550);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(100, 30);
            this.NuevoButton.TabIndex = 15;
            this.NuevoButton.Text = "      Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(240, 550);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(100, 30);
            this.GuardarButton.TabIndex = 14;
            this.GuardarButton.Text = "     Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(435, 550);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(100, 30);
            this.EliminarButton.TabIndex = 13;
            this.EliminarButton.Text = "      Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(326, 41);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(90, 40);
            this.BuscarButton.TabIndex = 12;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // rInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 589);
            this.Controls.Add(this.AsignaturasGroupBox);
            this.Controls.Add(this.EstudianteGroupBox);
            this.Controls.Add(this.PrecioCreditosNumericUpDown);
            this.Controls.Add(this.PrecioDeLosCreditos);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.FechaDeInscripcion);
            this.Controls.Add(this.InscripcionIdNumericUpDown);
            this.Controls.Add(this.InscripcionId);
            this.Controls.Add(this.FechaDeInscripcionDateTimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rInscripciones";
            this.Text = "Registro de Inscripciones";
            ((System.ComponentModel.ISupportInitialize)(this.InscripcionIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CreditosNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudianteIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioCreditosNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AsignaturaIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.EstudianteGroupBox.ResumeLayout(false);
            this.EstudianteGroupBox.PerformLayout();
            this.AsignaturasGroupBox.ResumeLayout(false);
            this.AsignaturasGroupBox.PerformLayout();
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
        private System.Windows.Forms.Button RemoverAsignaturaButton;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Creditos;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.NumericUpDown CreditosNumericUpDown;
        private System.Windows.Forms.Label EstudianteId;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.NumericUpDown EstudianteIdNumericUpDown;
        private System.Windows.Forms.Label PrecioDeLosCreditos;
        private System.Windows.Forms.NumericUpDown PrecioCreditosNumericUpDown;
        private System.Windows.Forms.NumericUpDown AsignaturaIdNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.TextBox PrecioTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.Button CargarAsignaturaButton;
        private System.Windows.Forms.Button RegistroAsignaturasButton;
        private System.Windows.Forms.Button ConsultarAsignaturasButton;
        private System.Windows.Forms.Button RegistroEstudiantesButton;
        private System.Windows.Forms.Button ConsultaEstudiantesButton;
        private System.Windows.Forms.Button CargarEstudianteButton;
        private System.Windows.Forms.GroupBox EstudianteGroupBox;
        private System.Windows.Forms.GroupBox AsignaturasGroupBox;
        private System.Windows.Forms.Label label2;
    }
}