namespace GestaoAlojamento
{
    partial class FormEditarClienteDetalhes
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
            buttonGuardar = new Button();
            buttonCancelar = new Button();
            labelNome = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            textBoxNome = new TextBox();
            dateTimeNascimento = new DateTimePicker();
            textBoxEmail = new TextBox();
            textBoxTelefone = new TextBox();
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
            // buttonGuardar
            // 
            buttonGuardar.BackColor = SystemColors.GradientActiveCaption;
            buttonGuardar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonGuardar.ForeColor = SystemColors.ControlText;
            buttonGuardar.Location = new Point(625, 650);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(172, 53);
            buttonGuardar.TabIndex = 16;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = SystemColors.GradientActiveCaption;
            buttonCancelar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCancelar.ForeColor = SystemColors.ControlText;
            buttonCancelar.Location = new Point(289, 650);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(172, 53);
            buttonCancelar.TabIndex = 17;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNome.Location = new Point(176, 130);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(76, 36);
            labelNome.TabIndex = 18;
            labelNome.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(176, 260);
            label3.Name = "label3";
            label3.Size = new Size(223, 36);
            label3.TabIndex = 19;
            label3.Text = "Data de Nascimento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(176, 390);
            label2.Name = "label2";
            label2.Size = new Size(73, 36);
            label2.TabIndex = 20;
            label2.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(176, 520);
            label4.Name = "label4";
            label4.Size = new Size(101, 36);
            label4.TabIndex = 21;
            label4.Text = "Telefone";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(440, 137);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(443, 27);
            textBoxNome.TabIndex = 22;
            // 
            // dateTimeNascimento
            // 
            dateTimeNascimento.Location = new Point(440, 265);
            dateTimeNascimento.Name = "dateTimeNascimento";
            dateTimeNascimento.Size = new Size(443, 27);
            dateTimeNascimento.TabIndex = 23;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(440, 397);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(443, 27);
            textBoxEmail.TabIndex = 24;
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(440, 527);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(443, 27);
            textBoxTelefone.TabIndex = 25;
            // 
            // FormEditarClienteDetalhes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxEmail);
            Controls.Add(dateTimeNascimento);
            Controls.Add(textBoxNome);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(labelNome);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarClienteDetalhes";
            Text = "FormEditarClienteDetalhes";
            Load += FormEditarClienteDetalhes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button buttonGuardar;
        private Button buttonCancelar;
        private Label labelNome;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox textBoxNome;
        private DateTimePicker dateTimeNascimento;
        private TextBox textBoxEmail;
        private TextBox textBoxTelefone;
    }
}