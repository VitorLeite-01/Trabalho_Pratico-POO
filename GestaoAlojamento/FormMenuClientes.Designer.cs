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
            buttonNovoCliente = new Button();
            buttonEditarCliente = new Button();
            buttonEliminarCliente = new Button();
            buttonListarCliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 34);
            label1.Name = "label1";
            label1.Size = new Size(421, 47);
            label1.TabIndex = 0;
            label1.Text = "Escolha a opção pretendida";
            label1.Click += label1_Click;
            // 
            // buttonNovoCliente
            // 
            buttonNovoCliente.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonNovoCliente.Location = new Point(415, 160);
            buttonNovoCliente.Name = "buttonNovoCliente";
            buttonNovoCliente.Size = new Size(220, 46);
            buttonNovoCliente.TabIndex = 1;
            buttonNovoCliente.Text = "Criar Cliente";
            buttonNovoCliente.UseVisualStyleBackColor = true;
            // 
            // buttonEditarCliente
            // 
            buttonEditarCliente.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditarCliente.Location = new Point(415, 320);
            buttonEditarCliente.Name = "buttonEditarCliente";
            buttonEditarCliente.Size = new Size(220, 46);
            buttonEditarCliente.TabIndex = 2;
            buttonEditarCliente.Text = "Editar Cliente";
            buttonEditarCliente.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarCliente
            // 
            buttonEliminarCliente.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEliminarCliente.Location = new Point(415, 480);
            buttonEliminarCliente.Name = "buttonEliminarCliente";
            buttonEliminarCliente.Size = new Size(220, 46);
            buttonEliminarCliente.TabIndex = 3;
            buttonEliminarCliente.Text = "Eliminar Cliente";
            buttonEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // buttonListarCliente
            // 
            buttonListarCliente.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonListarCliente.Location = new Point(415, 640);
            buttonListarCliente.Name = "buttonListarCliente";
            buttonListarCliente.Size = new Size(220, 46);
            buttonListarCliente.TabIndex = 4;
            buttonListarCliente.Text = "Listar Cliente";
            buttonListarCliente.UseVisualStyleBackColor = true;
            // 
            // FormMenuClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1051, 753);
            Controls.Add(buttonListarCliente);
            Controls.Add(buttonEliminarCliente);
            Controls.Add(buttonEditarCliente);
            Controls.Add(buttonNovoCliente);
            Controls.Add(label1);
            Name = "FormMenuClientes";
            Text = "Menu Clientes";
            TransparencyKey = Color.Black;
            Load += FormMenuClientes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonNovoCliente;
        private Button buttonEditarCliente;
        private Button buttonEliminarCliente;
        private Button buttonListarCliente;
    }
}