﻿namespace UI.screens
{
    partial class VerEmpleados
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
            button1 = new Button();
            dataEmpleados = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataEmpleados).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(92, 366);
            button1.Name = "button1";
            button1.Size = new Size(112, 23);
            button1.TabIndex = 0;
            button1.Text = "CONSULTAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ClickBtnConsultar;
            // 
            // dataEmpleados
            // 
            dataEmpleados.AllowUserToDeleteRows = false;
            dataEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataEmpleados.Location = new Point(78, 57);
            dataEmpleados.Name = "dataEmpleados";
            dataEmpleados.ReadOnly = true;
            dataEmpleados.RowTemplate.Height = 25;
            dataEmpleados.Size = new Size(659, 266);
            dataEmpleados.TabIndex = 1;
            // 
            // VerEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataEmpleados);
            Controls.Add(button1);
            Name = "VerEmpleados";
            Text = "VerEmpleados";
            Load += VerEmpleados_Load;
            ((System.ComponentModel.ISupportInitialize)dataEmpleados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataEmpleados;
    }
}