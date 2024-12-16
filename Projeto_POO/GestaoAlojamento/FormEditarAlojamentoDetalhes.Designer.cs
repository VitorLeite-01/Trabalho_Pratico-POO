namespace GestaoAlojamento
{
    partial class FormEditarAlojamentoDetalhes
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
            comboBoxEstado = new ComboBox();
            textBoxPreco = new TextBox();
            textBoxNr = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            comboBoxCategoria = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 66);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(394, 9);
            label2.Name = "label2";
            label2.Size = new Size(280, 47);
            label2.TabIndex = 2;
            label2.Text = "Editar Alojamento";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(512, 520);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(266, 28);
            comboBoxEstado.TabIndex = 16;
            comboBoxEstado.SelectedIndexChanged += comboBoxEstado_SelectedIndexChanged;
            // 
            // textBoxPreco
            // 
            textBoxPreco.Location = new Point(512, 390);
            textBoxPreco.Name = "textBoxPreco";
            textBoxPreco.Size = new Size(266, 27);
            textBoxPreco.TabIndex = 15;
            // 
            // textBoxNr
            // 
            textBoxNr.Location = new Point(512, 130);
            textBoxNr.Name = "textBoxNr";
            textBoxNr.Size = new Size(266, 27);
            textBoxNr.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(160, 520);
            label5.Name = "label5";
            label5.Size = new Size(86, 36);
            label5.TabIndex = 12;
            label5.Text = "Estado";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(160, 390);
            label4.Name = "label4";
            label4.Size = new Size(205, 36);
            label4.TabIndex = 11;
            label4.Text = "Preço por Noite (€)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(160, 260);
            label3.Name = "label3";
            label3.Size = new Size(115, 36);
            label3.TabIndex = 10;
            label3.Text = "Categoria";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(160, 130);
            label1.Name = "label1";
            label1.Size = new Size(251, 36);
            label1.TabIndex = 9;
            label1.Text = "Número do Alojamento";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.SandyBrown;
            buttonCancelar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancelar.ForeColor = SystemColors.ControlText;
            buttonCancelar.Location = new Point(289, 650);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(172, 53);
            buttonCancelar.TabIndex = 18;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.SandyBrown;
            buttonGuardar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGuardar.ForeColor = SystemColors.ControlText;
            buttonGuardar.Location = new Point(625, 650);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(172, 53);
            buttonGuardar.TabIndex = 17;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // comboBoxCategoria
            // 
            comboBoxCategoria.FormattingEnabled = true;
            comboBoxCategoria.Location = new Point(512, 260);
            comboBoxCategoria.Name = "comboBoxCategoria";
            comboBoxCategoria.Size = new Size(266, 28);
            comboBoxCategoria.TabIndex = 19;
            // 
            // FormEditarAlojamentoDetalhes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(comboBoxCategoria);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(comboBoxEstado);
            Controls.Add(textBoxPreco);
            Controls.Add(textBoxNr);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarAlojamentoDetalhes";
            Text = "Editar Alojamento Detalhes";
            Load += FormEditarAlojamentoDetalhes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private ComboBox comboBoxEstado;
        private TextBox textBoxPreco;
        private TextBox textBoxNr;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button buttonCancelar;
        private Button buttonGuardar;
        private ComboBox comboBoxCategoria;
    }
}