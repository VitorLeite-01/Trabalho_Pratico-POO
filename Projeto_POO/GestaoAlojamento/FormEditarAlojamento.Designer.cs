namespace GestaoAlojamento
{
    partial class FormEditarAlojamento
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
            label3 = new Label();
            comboBoxAlojamentos = new ComboBox();
            buttonEditar = new Button();
            buttonVoltar = new Button();
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
            panel1.TabIndex = 0;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(286, 161);
            label3.Name = "label3";
            label3.Size = new Size(497, 38);
            label3.TabIndex = 3;
            label3.Text = "Selecione o alojamento que pretende editar";
            // 
            // comboBoxAlojamentos
            // 
            comboBoxAlojamentos.FormattingEnabled = true;
            comboBoxAlojamentos.Location = new Point(312, 243);
            comboBoxAlojamentos.Name = "comboBoxAlojamentos";
            comboBoxAlojamentos.Size = new Size(445, 28);
            comboBoxAlojamentos.TabIndex = 4;
            comboBoxAlojamentos.SelectedIndexChanged += comboBoxAlojamentos_SelectedIndexChanged;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.SandyBrown;
            buttonEditar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditar.ForeColor = SystemColors.ControlText;
            buttonEditar.Location = new Point(625, 650);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(172, 53);
            buttonEditar.TabIndex = 15;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.SandyBrown;
            buttonVoltar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltar.ForeColor = SystemColors.ControlText;
            buttonVoltar.Location = new Point(289, 650);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(172, 53);
            buttonVoltar.TabIndex = 16;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // FormEditarAlojamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(buttonVoltar);
            Controls.Add(buttonEditar);
            Controls.Add(comboBoxAlojamentos);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarAlojamento";
            Text = "Editar Alojamento";
            Load += FormEditarAlojamento_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxAlojamentos;
        private Button buttonEditar;
        private Button buttonVoltar;
    }
}