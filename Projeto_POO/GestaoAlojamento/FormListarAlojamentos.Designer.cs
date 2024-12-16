namespace GestaoAlojamento
{
    partial class FormListarAlojamentos
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
            dataGridViewAlojamentos = new DataGridView();
            buttonVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlojamentos).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewAlojamentos
            // 
            dataGridViewAlojamentos.BackgroundColor = SystemColors.Control;
            dataGridViewAlojamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlojamentos.Location = new Point(0, 0);
            dataGridViewAlojamentos.Name = "dataGridViewAlojamentos";
            dataGridViewAlojamentos.RowHeadersWidth = 51;
            dataGridViewAlojamentos.Size = new Size(1069, 650);
            dataGridViewAlojamentos.TabIndex = 0;
            dataGridViewAlojamentos.CellContentClick += dataGridViewAlojamentos_CellContentClick;
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.SandyBrown;
            buttonVoltar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltar.ForeColor = SystemColors.ControlText;
            buttonVoltar.Location = new Point(448, 700);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(172, 53);
            buttonVoltar.TabIndex = 13;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // FormListarAlojamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(buttonVoltar);
            Controls.Add(dataGridViewAlojamentos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormListarAlojamentos";
            Text = "Listar Alojamentos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlojamentos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewAlojamentos;
        private Button buttonVoltar;
    }
}