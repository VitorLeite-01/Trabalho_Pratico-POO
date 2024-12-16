namespace GestaoAlojamento
{
    partial class FormCheckOut
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
            buttonEfetuarCheckOut = new Button();
            comboBoxReservas = new ComboBox();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonEfetuarCheckOut
            // 
            buttonEfetuarCheckOut.BackColor = Color.IndianRed;
            buttonEfetuarCheckOut.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEfetuarCheckOut.Location = new Point(393, 650);
            buttonEfetuarCheckOut.Name = "buttonEfetuarCheckOut";
            buttonEfetuarCheckOut.Size = new Size(282, 41);
            buttonEfetuarCheckOut.TabIndex = 5;
            buttonEfetuarCheckOut.Text = "Efetuar Check-out";
            buttonEfetuarCheckOut.UseVisualStyleBackColor = false;
            buttonEfetuarCheckOut.Click += buttonEfetuarCheckOut_Click;
            // 
            // comboBoxReservas
            // 
            comboBoxReservas.FormattingEnabled = true;
            comboBoxReservas.Location = new Point(190, 174);
            comboBoxReservas.Name = "comboBoxReservas";
            comboBoxReservas.Size = new Size(726, 28);
            comboBoxReservas.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 66);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(438, 10);
            label1.Name = "label1";
            label1.Size = new Size(169, 47);
            label1.TabIndex = 1;
            label1.Text = "Check-out";
            // 
            // FormCheckOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(buttonEfetuarCheckOut);
            Controls.Add(comboBoxReservas);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCheckOut";
            Text = "Check-Out";
            Load += FormCheckOut_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEfetuarCheckOut;
        private ComboBox comboBoxReservas;
        private Panel panel1;
        private Label label1;
    }
}