namespace UI.screens
{
    partial class CrearEmpleado
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
            dniInput = new TextBox();
            label1 = new Label();
            apellidoInput = new TextBox();
            nameLabel = new Label();
            nameInput = new TextBox();
            apeLabel = new Label();
            fechaNac = new DateTimePicker();
            fechaIngreso = new DateTimePicker();
            labelNac = new Label();
            labelIngreso = new Label();
            btnCrearEmpleado = new Button();
            dataGridEmpleado = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleado).BeginInit();
            SuspendLayout();
            // 
            // dniInput
            // 
            dniInput.BorderStyle = BorderStyle.FixedSingle;
            dniInput.Location = new Point(104, 85);
            dniInput.Name = "dniInput";
            dniInput.Size = new Size(181, 23);
            dniInput.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(104, 61);
            label1.Name = "label1";
            label1.Size = new Size(44, 21);
            label1.TabIndex = 1;
            label1.Text = "DNI:";
            // 
            // apellidoInput
            // 
            apellidoInput.BorderStyle = BorderStyle.FixedSingle;
            apellidoInput.Location = new Point(104, 225);
            apellidoInput.Name = "apellidoInput";
            apellidoInput.Size = new Size(181, 23);
            apellidoInput.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(104, 132);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(83, 21);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "NOMBRE:";
            // 
            // nameInput
            // 
            nameInput.BorderStyle = BorderStyle.FixedSingle;
            nameInput.Location = new Point(104, 156);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(181, 23);
            nameInput.TabIndex = 4;
            // 
            // apeLabel
            // 
            apeLabel.AutoSize = true;
            apeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            apeLabel.Location = new Point(104, 201);
            apeLabel.Name = "apeLabel";
            apeLabel.RightToLeft = RightToLeft.No;
            apeLabel.Size = new Size(89, 21);
            apeLabel.TabIndex = 5;
            apeLabel.Text = "APELLIDO:";
            // 
            // fechaNac
            // 
            fechaNac.Location = new Point(370, 85);
            fechaNac.Name = "fechaNac";
            fechaNac.Size = new Size(200, 23);
            fechaNac.TabIndex = 6;
            // 
            // fechaIngreso
            // 
            fechaIngreso.Location = new Point(370, 156);
            fechaIngreso.Name = "fechaIngreso";
            fechaIngreso.Size = new Size(200, 23);
            fechaIngreso.TabIndex = 7;
            // 
            // labelNac
            // 
            labelNac.AutoSize = true;
            labelNac.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNac.Location = new Point(370, 61);
            labelNac.Name = "labelNac";
            labelNac.Size = new Size(169, 21);
            labelNac.TabIndex = 8;
            labelNac.Text = "FECHA NACIMIENTO:";
            // 
            // labelIngreso
            // 
            labelIngreso.AutoSize = true;
            labelIngreso.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelIngreso.Location = new Point(370, 132);
            labelIngreso.Name = "labelIngreso";
            labelIngreso.Size = new Size(137, 21);
            labelIngreso.TabIndex = 9;
            labelIngreso.Text = "FECHA INGRESO:";
            // 
            // btnCrearEmpleado
            // 
            btnCrearEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearEmpleado.Location = new Point(370, 225);
            btnCrearEmpleado.Name = "btnCrearEmpleado";
            btnCrearEmpleado.Size = new Size(159, 23);
            btnCrearEmpleado.TabIndex = 10;
            btnCrearEmpleado.Text = "CREAR EMPLEADO";
            btnCrearEmpleado.UseVisualStyleBackColor = true;
            btnCrearEmpleado.Click += ClickBtnCrearEmpleado;
            // 
            // dataGridEmpleado
            // 
            dataGridEmpleado.AllowUserToAddRows = false;
            dataGridEmpleado.AllowUserToDeleteRows = false;
            dataGridEmpleado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmpleado.Location = new Point(65, 300);
            dataGridEmpleado.Name = "dataGridEmpleado";
            dataGridEmpleado.ReadOnly = true;
            dataGridEmpleado.RowTemplate.Height = 25;
            dataGridEmpleado.Size = new Size(573, 105);
            dataGridEmpleado.TabIndex = 11;
            // 
            // CrearEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridEmpleado);
            Controls.Add(btnCrearEmpleado);
            Controls.Add(labelIngreso);
            Controls.Add(labelNac);
            Controls.Add(fechaIngreso);
            Controls.Add(fechaNac);
            Controls.Add(apeLabel);
            Controls.Add(nameInput);
            Controls.Add(nameLabel);
            Controls.Add(apellidoInput);
            Controls.Add(label1);
            Controls.Add(dniInput);
            Name = "CrearEmpleado";
            Text = "CrearEmpleado";
            ((System.ComponentModel.ISupportInitialize)dataGridEmpleado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dniInput;
        private Label label1;
        private TextBox apellidoInput;
        private Label nameLabel;
        private TextBox nameInput;
        private Label apeLabel;
        private DateTimePicker fechaNac;
        private DateTimePicker fechaIngreso;
        private Label labelNac;
        private Label labelIngreso;
        private Button btnCrearEmpleado;
        private DataGridView dataGridEmpleado;
    }
}