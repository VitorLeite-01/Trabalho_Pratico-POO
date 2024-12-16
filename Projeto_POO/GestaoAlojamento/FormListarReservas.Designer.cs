namespace GestaoAlojamento
{
    partial class FormListarReservas
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
            dataGridViewReservas = new DataGridView();
            buttonVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservas).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewReservas
            // 
            dataGridViewReservas.BackgroundColor = SystemColors.Control;
            dataGridViewReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservas.Location = new Point(0, 0);
            dataGridViewReservas.Name = "dataGridViewReservas";
            dataGridViewReservas.RowHeadersWidth = 51;
            dataGridViewReservas.Size = new Size(1069, 650);
            dataGridViewReservas.TabIndex = 0;
            dataGridViewReservas.CellContentClick += dataGridViewReservas_CellContentClick;
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.LimeGreen;
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
            // FormListarReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(buttonVoltar);
            Controls.Add(dataGridViewReservas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormListarReservas";
            Text = "Listar Reservas";
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewReservas;
        private Button buttonVoltar;
    }
}