namespace GestaoAlojamento
{
    partial class FormEditarReservaAlojamento
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
            buttonCancelar = new Button();
            buttonConfirmar = new Button();
            label1 = new Label();
            dataGridViewAlojamentos = new DataGridView();
            comboBoxCategorias = new ComboBox();
            buttonPesquisar = new Button();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlojamentos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.LimeGreen;
            buttonCancelar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancelar.ForeColor = SystemColors.ControlText;
            buttonCancelar.Location = new Point(289, 650);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(172, 53);
            buttonCancelar.TabIndex = 25;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonConfirmar
            // 
            buttonConfirmar.BackColor = Color.LimeGreen;
            buttonConfirmar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonConfirmar.ForeColor = SystemColors.ControlText;
            buttonConfirmar.Location = new Point(625, 650);
            buttonConfirmar.Name = "buttonConfirmar";
            buttonConfirmar.Size = new Size(172, 53);
            buttonConfirmar.TabIndex = 24;
            buttonConfirmar.Text = "Confirmar";
            buttonConfirmar.UseVisualStyleBackColor = false;
            buttonConfirmar.Click += buttonConfirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(71, 135);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 23;
            label1.Text = "Escolha uma categoria :";
            // 
            // dataGridViewAlojamentos
            // 
            dataGridViewAlojamentos.BackgroundColor = SystemColors.Control;
            dataGridViewAlojamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlojamentos.Location = new Point(257, 230);
            dataGridViewAlojamentos.Name = "dataGridViewAlojamentos";
            dataGridViewAlojamentos.RowHeadersWidth = 51;
            dataGridViewAlojamentos.Size = new Size(554, 357);
            dataGridViewAlojamentos.TabIndex = 22;
            // 
            // comboBoxCategorias
            // 
            comboBoxCategorias.FormattingEnabled = true;
            comboBoxCategorias.Location = new Point(296, 135);
            comboBoxCategorias.Name = "comboBoxCategorias";
            comboBoxCategorias.Size = new Size(476, 28);
            comboBoxCategorias.TabIndex = 21;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(836, 135);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(94, 29);
            buttonPesquisar.TabIndex = 20;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 66);
            panel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LimeGreen;
            label2.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(408, 10);
            label2.Name = "label2";
            label2.Size = new Size(229, 47);
            label2.TabIndex = 1;
            label2.Text = "Editar Reserva";
            // 
            // FormEditarReservaAlojamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonConfirmar);
            Controls.Add(label1);
            Controls.Add(dataGridViewAlojamentos);
            Controls.Add(comboBoxCategorias);
            Controls.Add(buttonPesquisar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarReservaAlojamento";
            Text = "Editar Reserva Alojamentocs";
            Load += FormEditarReservaAlojamentocs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlojamentos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonConfirmar;
        private Label label1;
        private DataGridView dataGridViewAlojamentos;
        private ComboBox comboBoxCategorias;
        private Button buttonPesquisar;
        private Panel panel1;
        private Label label2;
    }
}