namespace GestaoAlojamento
{
    partial class FormEliminarReserva
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
            buttonEliminar = new Button();
            buttonVoltar = new Button();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            comboBoxReservas = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.LimeGreen;
            buttonEliminar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEliminar.ForeColor = SystemColors.ControlText;
            buttonEliminar.Location = new Point(625, 650);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(172, 53);
            buttonEliminar.TabIndex = 21;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.LimeGreen;
            buttonVoltar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltar.ForeColor = SystemColors.ControlText;
            buttonVoltar.Location = new Point(289, 650);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(172, 53);
            buttonVoltar.TabIndex = 20;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(296, 161);
            label2.Name = "label2";
            label2.Size = new Size(477, 38);
            label2.TabIndex = 18;
            label2.Text = "Selecione a reserva que pretende eliminar";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LimeGreen;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 66);
            panel1.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LimeGreen;
            label3.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(391, 10);
            label3.Name = "label3";
            label3.Size = new Size(263, 47);
            label3.TabIndex = 1;
            label3.Text = "Eliminar Reserva";
            // 
            // comboBoxReservas
            // 
            comboBoxReservas.FormattingEnabled = true;
            comboBoxReservas.Location = new Point(179, 243);
            comboBoxReservas.Name = "comboBoxReservas";
            comboBoxReservas.Size = new Size(711, 28);
            comboBoxReservas.TabIndex = 19;
            // 
            // FormEliminarReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonVoltar);
            Controls.Add(comboBoxReservas);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEliminarReserva";
            Text = "Eliminar Reserva";
            Load += FormEliminarReserva_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEliminar;
        private Button buttonVoltar;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private ComboBox comboBoxReservas;
    }
}