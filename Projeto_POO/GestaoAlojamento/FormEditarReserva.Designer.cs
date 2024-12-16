namespace GestaoAlojamento
{
    partial class FormEditarReserva
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
            comboBoxReservas = new ComboBox();
            buttonEditar = new Button();
            buttonVoltar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 66);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LimeGreen;
            label1.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(408, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 47);
            label1.TabIndex = 0;
            label1.Text = "Editar Reserva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(309, 161);
            label2.Name = "label2";
            label2.Size = new Size(450, 38);
            label2.TabIndex = 7;
            label2.Text = "Selecione a reserva que pretende editar";
            // 
            // comboBoxReservas
            // 
            comboBoxReservas.FormattingEnabled = true;
            comboBoxReservas.Location = new Point(179, 243);
            comboBoxReservas.Name = "comboBoxReservas";
            comboBoxReservas.Size = new Size(711, 28);
            comboBoxReservas.TabIndex = 8;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.LimeGreen;
            buttonEditar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditar.ForeColor = SystemColors.ControlText;
            buttonEditar.Location = new Point(625, 650);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(172, 53);
            buttonEditar.TabIndex = 16;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.LimeGreen;
            buttonVoltar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltar.ForeColor = SystemColors.ControlText;
            buttonVoltar.Location = new Point(289, 650);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(172, 53);
            buttonVoltar.TabIndex = 15;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // FormEditarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(buttonEditar);
            Controls.Add(buttonVoltar);
            Controls.Add(comboBoxReservas);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarReserva";
            Text = "Editar Reserva";
            Load += FormEditarReserva_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxReservas;
        private Button buttonEditar;
        private Button buttonVoltar;
    }
}