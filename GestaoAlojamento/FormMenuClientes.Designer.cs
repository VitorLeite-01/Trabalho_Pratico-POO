namespace GestaoAlojamento
{
    partial class FormMenuClientes
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
            label1 = new Label();
            buttonCriarCliente = new Button();
            buttonEditarCliente = new Button();
            buttonEliminarCliente = new Button();
            buttonListarCliente = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(418, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 47);
            label1.TabIndex = 0;
            label1.Text = "Menu Clientes";
            label1.Click += label1_Click;
            // 
            // buttonCriarCliente
            // 
            buttonCriarCliente.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCriarCliente.Location = new Point(424, 160);
            buttonCriarCliente.Name = "buttonCriarCliente";
            buttonCriarCliente.Size = new Size(220, 46);
            buttonCriarCliente.TabIndex = 1;
            buttonCriarCliente.Text = "Criar Cliente";
            buttonCriarCliente.UseVisualStyleBackColor = true;
            buttonCriarCliente.Click += buttonCriarCliente_Click;
            // 
            // buttonEditarCliente
            // 
            buttonEditarCliente.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditarCliente.Location = new Point(424, 320);
            buttonEditarCliente.Name = "buttonEditarCliente";
            buttonEditarCliente.Size = new Size(220, 46);
            buttonEditarCliente.TabIndex = 2;
            buttonEditarCliente.Text = "Editar Cliente";
            buttonEditarCliente.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarCliente
            // 
            buttonEliminarCliente.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEliminarCliente.Location = new Point(424, 480);
            buttonEliminarCliente.Name = "buttonEliminarCliente";
            buttonEliminarCliente.Size = new Size(220, 46);
            buttonEliminarCliente.TabIndex = 3;
            buttonEliminarCliente.Text = "Eliminar Cliente";
            buttonEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // buttonListarCliente
            // 
            buttonListarCliente.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonListarCliente.Location = new Point(424, 640);
            buttonListarCliente.Name = "buttonListarCliente";
            buttonListarCliente.Size = new Size(220, 46);
            buttonListarCliente.TabIndex = 4;
            buttonListarCliente.Text = "Listar Cliente";
            buttonListarCliente.UseVisualStyleBackColor = true;
            buttonListarCliente.Click += buttonListarCliente_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1045, 66);
            panel1.TabIndex = 5;
            // 
            // FormMenuClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1069, 801);
            Controls.Add(panel1);
            Controls.Add(buttonListarCliente);
            Controls.Add(buttonEliminarCliente);
            Controls.Add(buttonEditarCliente);
            Controls.Add(buttonCriarCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenuClientes";
            Text = "Menu Clientes";
            TransparencyKey = Color.Black;
            Load += FormMenuClientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonCriarCliente;
        private Button buttonEditarCliente;
        private Button buttonEliminarCliente;
        private Button buttonListarCliente;
        private Panel panel1;
    }
}