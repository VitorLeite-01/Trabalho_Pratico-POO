﻿namespace GestaoAlojamento
{
    partial class FormListarClientes
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
            dataGridViewClientes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewClientes.BackgroundColor = SystemColors.Control;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Location = new Point(0, 0);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 51;
            dataGridViewClientes.Size = new Size(1051, 754);
            dataGridViewClientes.TabIndex = 0;
            dataGridViewClientes.CellContentClick += dataGridViewClientes_CellContentClick;
            // 
            // FormListarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 754);
            Controls.Add(dataGridViewClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormListarClientes";
            Text = "FormListarClientes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewClientes;
    }
}