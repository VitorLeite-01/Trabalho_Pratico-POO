namespace GestaoAlojamento
{
    partial class FormEditarCliente
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
            label1 = new Label();
            label2 = new Label();
            comboBoxClientes = new ComboBox();
            buttonVoltar = new Button();
            buttonEditar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 66);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(426, 9);
            label1.Name = "label1";
            label1.Size = new Size(217, 47);
            label1.TabIndex = 1;
            label1.Text = "Editar Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(312, 161);
            label2.Name = "label2";
            label2.Size = new Size(445, 38);
            label2.TabIndex = 1;
            label2.Text = "Selecione o cliente que pretende editar";
            label2.Click += label2_Click;
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(312, 243);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(445, 28);
            comboBoxClientes.TabIndex = 2;
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = SystemColors.GradientActiveCaption;
            buttonVoltar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltar.ForeColor = SystemColors.ControlText;
            buttonVoltar.Location = new Point(289, 650);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(172, 53);
            buttonVoltar.TabIndex = 13;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = SystemColors.GradientActiveCaption;
            buttonEditar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditar.ForeColor = SystemColors.ControlText;
            buttonEditar.Location = new Point(625, 650);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(172, 53);
            buttonEditar.TabIndex = 14;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // FormEditarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(buttonEditar);
            Controls.Add(buttonVoltar);
            Controls.Add(comboBoxClientes);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarCliente";
            Text = "FormEditarCliente";
            Load += FormEditarCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxClientes;
        private Button buttonVoltar;
        private Button buttonEditar;
    }
}