namespace GestaoAlojamento
{
    partial class FormSelecionarAlojamento
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
            panel1 = new Panel();
            label2 = new Label();
            buttonPesquisar = new Button();
            comboBoxCategoriaFiltro = new ComboBox();
            dataGridViewAlojamentos = new DataGridView();
            label1 = new Label();
            buttonVoltar = new Button();
            buttonReservar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlojamentos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 66);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LimeGreen;
            label2.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(416, 10);
            label2.Name = "label2";
            label2.Size = new Size(213, 47);
            label2.TabIndex = 1;
            label2.Text = "Criar Reserva";
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(836, 135);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(94, 29);
            buttonPesquisar.TabIndex = 9;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // comboBoxCategoriaFiltro
            // 
            comboBoxCategoriaFiltro.FormattingEnabled = true;
            comboBoxCategoriaFiltro.Location = new Point(296, 135);
            comboBoxCategoriaFiltro.Name = "comboBoxCategoriaFiltro";
            comboBoxCategoriaFiltro.Size = new Size(476, 28);
            comboBoxCategoriaFiltro.TabIndex = 10;
            // 
            // dataGridViewAlojamentos
            // 
            dataGridViewAlojamentos.BackgroundColor = SystemColors.Control;
            dataGridViewAlojamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlojamentos.Location = new Point(257, 230);
            dataGridViewAlojamentos.Name = "dataGridViewAlojamentos";
            dataGridViewAlojamentos.RowHeadersWidth = 51;
            dataGridViewAlojamentos.Size = new Size(554, 357);
            dataGridViewAlojamentos.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 135);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 13;
            label1.Text = "Escolha uma categoria :";
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.LimeGreen;
            buttonVoltar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltar.ForeColor = SystemColors.ControlText;
            buttonVoltar.Location = new Point(289, 650);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(172, 53);
            buttonVoltar.TabIndex = 18;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // buttonReservar
            // 
            buttonReservar.BackColor = Color.LimeGreen;
            buttonReservar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReservar.ForeColor = SystemColors.ControlText;
            buttonReservar.Location = new Point(625, 650);
            buttonReservar.Name = "buttonReservar";
            buttonReservar.Size = new Size(172, 53);
            buttonReservar.TabIndex = 17;
            buttonReservar.Text = "Reservar";
            buttonReservar.UseVisualStyleBackColor = false;
            buttonReservar.Click += buttonReservar_Click;
            // 
            // FormSelecionarAlojamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(buttonVoltar);
            Controls.Add(buttonReservar);
            Controls.Add(label1);
            Controls.Add(dataGridViewAlojamentos);
            Controls.Add(comboBoxCategoriaFiltro);
            Controls.Add(buttonPesquisar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSelecionarAlojamento";
            Text = "Selecionar Alojamento";
            Load += FormSelecionarAlojamento_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlojamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button buttonPesquisar;
        private ComboBox comboBoxCategoriaFiltro;
        private DataGridView dataGridViewAlojamentos;
        private Label label1;
        private Button buttonVoltar;
        private Button buttonReservar;
    }
}