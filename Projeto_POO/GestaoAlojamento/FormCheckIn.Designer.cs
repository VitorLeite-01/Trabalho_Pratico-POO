namespace GestaoAlojamento
{
    partial class FormCheckIn
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
            buttonEfetuarCheckIn = new Button();
            comboBoxReservas = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumPurple;
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
            label1.Location = new Point(448, 10);
            label1.Name = "label1";
            label1.Size = new Size(149, 47);
            label1.TabIndex = 1;
            label1.Text = "Check-in";
            // 
            // buttonEfetuarCheckIn
            // 
            buttonEfetuarCheckIn.BackColor = Color.MediumPurple;
            buttonEfetuarCheckIn.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEfetuarCheckIn.Location = new Point(393, 650);
            buttonEfetuarCheckIn.Name = "buttonEfetuarCheckIn";
            buttonEfetuarCheckIn.Size = new Size(282, 41);
            buttonEfetuarCheckIn.TabIndex = 2;
            buttonEfetuarCheckIn.Text = "Efetuar Check-in";
            buttonEfetuarCheckIn.UseVisualStyleBackColor = false;
            buttonEfetuarCheckIn.Click += buttonEfetuarCheckIn_Click;
            // 
            // comboBoxReservas
            // 
            comboBoxReservas.FormattingEnabled = true;
            comboBoxReservas.Location = new Point(190, 174);
            comboBoxReservas.Name = "comboBoxReservas";
            comboBoxReservas.Size = new Size(726, 28);
            comboBoxReservas.TabIndex = 5;
            // 
            // FormCheckIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(comboBoxReservas);
            Controls.Add(buttonEfetuarCheckIn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCheckIn";
            Text = "Check-In";
            Load += FormCheckIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button buttonEfetuarCheckIn;
        private ComboBox comboBoxReservas;
    }
}