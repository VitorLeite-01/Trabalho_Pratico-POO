namespace GestaoAlojamento
{
    partial class FormEliminarCliente
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
            label3 = new Label();
            comboBoxClientes = new ComboBox();
            buttonVoltar = new Button();
            buttonEliminar = new Button();
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
            label1.Location = new Point(409, 9);
            label1.Name = "label1";
            label1.Size = new Size(251, 47);
            label1.TabIndex = 2;
            label1.Text = "Eliminar Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(298, 200);
            label3.Name = "label3";
            label3.Size = new Size(472, 38);
            label3.TabIndex = 2;
            label3.Text = "Selecione o cliente que pretende eliminar";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(298, 305);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(472, 28);
            comboBoxClientes.TabIndex = 3;
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = SystemColors.GradientActiveCaption;
            buttonVoltar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVoltar.ForeColor = SystemColors.ControlText;
            buttonVoltar.Location = new Point(289, 650);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(172, 53);
            buttonVoltar.TabIndex = 12;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = SystemColors.GradientActiveCaption;
            buttonEliminar.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEliminar.ForeColor = SystemColors.ControlText;
            buttonEliminar.Location = new Point(625, 650);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(172, 53);
            buttonEliminar.TabIndex = 13;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // FormEliminarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 801);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonVoltar);
            Controls.Add(comboBoxClientes);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEliminarCliente";
            Text = "Eliminar Cliente";
            Load += FormEliminarCliente_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private ComboBox comboBoxClientes;
        private Button buttonVoltar;
        private Button buttonEliminar;
    }
}