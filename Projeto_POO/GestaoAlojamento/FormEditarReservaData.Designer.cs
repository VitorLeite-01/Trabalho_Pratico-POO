namespace GestaoAlojamento
{
    partial class FormEditarReservaData
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
            dateCheckout = new DateTimePicker();
            dateCheckin = new DateTimePicker();
            label5 = new Label();
            label4 = new Label();
            buttonAvancar = new Button();
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
            panel1.TabIndex = 7;
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
            // dateCheckout
            // 
            dateCheckout.Location = new Point(473, 430);
            dateCheckout.Name = "dateCheckout";
            dateCheckout.Size = new Size(348, 27);
            dateCheckout.TabIndex = 22;
            // 
            // dateCheckin
            // 
            dateCheckin.Location = new Point(473, 230);
            dateCheckin.Name = "dateCheckin";
            dateCheckin.Size = new Size(348, 27);
            dateCheckin.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(247, 430);
            label5.Name = "label5";
            label5.Size = new Size(175, 36);
            label5.TabIndex = 20;
            label5.Text = "Data Check-out";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(247, 230);
            label4.Name = "label4";
            label4.Size = new Size(160, 36);
            label4.TabIndex = 19;
            label4.Text = "Data Check-in";
            // 
            // buttonAvancar
            // 
            buttonAvancar.BackColor = Color.LimeGreen;
            buttonAvancar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAvancar.ForeColor = SystemColors.ControlText;
            buttonAvancar.Location = new Point(625, 650);
            buttonAvancar.Name = "buttonAvancar";
            buttonAvancar.Size = new Size(172, 53);
            buttonAvancar.TabIndex = 24;
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
            buttonVoltar.TabIndex = 23;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // FormEditarReservaData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(buttonAvancar);
            Controls.Add(buttonVoltar);
            Controls.Add(dateCheckout);
            Controls.Add(dateCheckin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEditarReservaData";
            Text = "Editar Reserva Data";
            Load += FormEditarReservaData_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DateTimePicker dateCheckout;
        private DateTimePicker dateCheckin;
        private Label label5;
        private Label label4;
        private Button buttonAvancar;
        private Button buttonVoltar;
    }
}