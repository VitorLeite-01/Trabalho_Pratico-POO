namespace GestaoAlojamento
{
    partial class FormEliminarAlojamento
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
            buttonVoltar = new Button();
            buttonEliminar = new Button();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            comboBoxAlojamentos = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.SandyBrown;
            buttonVoltar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltar.ForeColor = SystemColors.ControlText;
            buttonVoltar.Location = new Point(289, 650);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(172, 53);
            buttonVoltar.TabIndex = 21;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.SandyBrown;
            buttonEliminar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEliminar.ForeColor = SystemColors.ControlText;
            buttonEliminar.Location = new Point(625, 650);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(172, 53);
            buttonEliminar.TabIndex = 20;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(272, 161);
            label3.Name = "label3";
            label3.Size = new Size(524, 38);
            label3.TabIndex = 18;
            label3.Text = "Selecione o alojamento que pretende eliminar";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SandyBrown;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 66);
            panel1.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(365, 10);
            label1.Name = "label1";
            label1.Size = new Size(314, 47);
            label1.TabIndex = 3;
            label1.Text = "Eliminar Alojamento";
            // 
            // comboBoxAlojamentos
            // 
            comboBoxAlojamentos.FormattingEnabled = true;
            comboBoxAlojamentos.Location = new Point(312, 243);
            comboBoxAlojamentos.Name = "comboBoxAlojamentos";
            comboBoxAlojamentos.Size = new Size(445, 28);
            comboBoxAlojamentos.TabIndex = 22;
            // 
            // FormEliminarAlojamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(comboBoxAlojamentos);
            Controls.Add(buttonVoltar);
            Controls.Add(buttonEliminar);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEliminarAlojamento";
            Text = "Eliminar Alojamento";
            Load += FormEliminarAlojamento_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVoltar;
        private Button buttonEliminar;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private ComboBox comboBoxAlojamentos;
    }
}