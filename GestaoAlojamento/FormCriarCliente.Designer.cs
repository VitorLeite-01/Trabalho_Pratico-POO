namespace GestaoAlojamento
{
    partial class FormCriarCliente
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
            labelNome = new Label();
            labelTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxNome = new TextBox();
            textBoxEmail = new TextBox();
            textBoxTelefone = new TextBox();
            dateTimeNascimento = new DateTimePicker();
            panel1 = new Panel();
            buttonGuardar = new Button();
            buttonVoltar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(176, 130);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(76, 36);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Franklin Gothic Medium Cond", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTitulo.Location = new Point(448, 11);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(186, 43);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Criar Cliente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(176, 390);
            label1.Name = "label1";
            label1.Size = new Size(73, 36);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(176, 520);
            label2.Name = "label2";
            label2.Size = new Size(101, 36);
            label2.TabIndex = 3;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(176, 260);
            label3.Name = "label3";
            label3.Size = new Size(223, 36);
            label3.TabIndex = 4;
            label3.Text = "Data de Nascimento";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(440, 137);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(443, 27);
            textBoxNome.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(440, 397);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(443, 27);
            textBoxEmail.TabIndex = 6;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(440, 527);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(443, 27);
            textBoxTelefone.TabIndex = 7;
            // 
            // dateTimeNascimento
            // 
            dateTimeNascimento.Location = new Point(440, 265);
            dateTimeNascimento.Name = "dateTimeNascimento";
            dateTimeNascimento.Size = new Size(443, 27);
            dateTimeNascimento.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(labelTitulo);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 66);
            panel1.TabIndex = 9;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = SystemColors.GradientActiveCaption;
            buttonGuardar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGuardar.ForeColor = SystemColors.ControlText;
            buttonGuardar.Location = new Point(625, 650);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(172, 53);
            buttonGuardar.TabIndex = 10;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = SystemColors.GradientActiveCaption;
            buttonVoltar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltar.ForeColor = SystemColors.ControlText;
            buttonVoltar.Location = new Point(289, 650);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(172, 53);
            buttonVoltar.TabIndex = 11;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // FormCriarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(buttonVoltar);
            Controls.Add(buttonGuardar);
            Controls.Add(panel1);
            Controls.Add(dateTimeNascimento);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNome);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelNome);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCriarCliente";
            Text = "Criar Cliente";
            Load += FormCriarCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelTitulo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxNome;
        private TextBox textBoxEmail;
        private TextBox textBoxTelefone;
        private DateTimePicker dateTimeNascimento;
        private Panel panel1;
        private Button buttonGuardar;
        private Button buttonVoltar;
    }
}