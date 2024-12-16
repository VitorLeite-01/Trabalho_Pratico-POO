namespace GestaoAlojamento
{
    partial class FormCriarReserva
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
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBoxCliente = new ComboBox();
            dateCheckin = new DateTimePicker();
            dateCheckout = new DateTimePicker();
            buttonAvancar = new Button();
            buttonVoltar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 66);
            panel1.TabIndex = 6;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 170);
            label1.Name = "label1";
            label1.Size = new Size(87, 36);
            label1.TabIndex = 7;
            label1.Text = "Cliente";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(221, 330);
            label4.Name = "label4";
            label4.Size = new Size(160, 36);
            label4.TabIndex = 9;
            label4.Text = "Data Check-in";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(221, 490);
            label5.Name = "label5";
            label5.Size = new Size(175, 36);
            label5.TabIndex = 10;
            label5.Text = "Data Check-out";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(447, 170);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(348, 28);
            comboBoxCliente.TabIndex = 11;
            // 
            // dateCheckin
            // 
            dateCheckin.Location = new Point(447, 330);
            dateCheckin.Name = "dateCheckin";
            dateCheckin.Size = new Size(348, 27);
            dateCheckin.TabIndex = 13;
            // 
            // dateCheckout
            // 
            dateCheckout.Location = new Point(447, 490);
            dateCheckout.Name = "dateCheckout";
            dateCheckout.Size = new Size(348, 27);
            dateCheckout.TabIndex = 14;
            // 
            // buttonAvancar
            // 
            buttonAvancar.BackColor = Color.LimeGreen;
            buttonAvancar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAvancar.ForeColor = SystemColors.ControlText;
            buttonAvancar.Location = new Point(625, 650);
            buttonAvancar.Name = "buttonAvancar";
            buttonAvancar.Size = new Size(172, 53);
            buttonAvancar.TabIndex = 15;
            buttonAvancar.Text = "Avançar";
            buttonAvancar.UseVisualStyleBackColor = false;
            buttonAvancar.Click += buttonAvancar_Click;
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.LimeGreen;
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
            // FormCriarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(buttonVoltar);
            Controls.Add(buttonAvancar);
            Controls.Add(dateCheckout);
            Controls.Add(dateCheckin);
            Controls.Add(comboBoxCliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCriarReserva";
            Text = "Criar Reserva";
            Load += FormCriarReserva_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBoxCliente;
        private ComboBox comboBoxAlojamento;
        private DateTimePicker dateCheckin;
        private DateTimePicker dateCheckout;
        private Button buttonAvancar;
        private Button buttonVoltar;
    }
}