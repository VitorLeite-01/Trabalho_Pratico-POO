namespace GestaoAlojamento
{
    partial class FormMenuAlojamentos
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
            buttonCriarAlojamento = new Button();
            buttonEditarAlojamento = new Button();
            buttonEliminarAlojamento = new Button();
            buttonListarAlojamento = new Button();
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
            // 
            // buttonCriarAlojamento
            // 
            buttonCriarAlojamento.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCriarAlojamento.Location = new Point(415, 160);
            buttonCriarAlojamento.Name = "buttonCriarAlojamento";
            buttonCriarAlojamento.Size = new Size(220, 46);
            buttonCriarAlojamento.TabIndex = 1;
            buttonCriarAlojamento.Text = "Criar Alojamento";
            buttonCriarAlojamento.UseVisualStyleBackColor = true;
            // 
            // buttonEditarAlojamento
            // 
            buttonEditarAlojamento.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditarAlojamento.Location = new Point(415, 320);
            buttonEditarAlojamento.Name = "buttonEditarAlojamento";
            buttonEditarAlojamento.Size = new Size(220, 46);
            buttonEditarAlojamento.TabIndex = 2;
            buttonEditarAlojamento.Text = "Editar Alojamento";
            buttonEditarAlojamento.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarAlojamento
            // 
            buttonEliminarAlojamento.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEliminarAlojamento.Location = new Point(415, 480);
            buttonEliminarAlojamento.Name = "buttonEliminarAlojamento";
            buttonEliminarAlojamento.Size = new Size(220, 46);
            buttonEliminarAlojamento.TabIndex = 3;
            buttonEliminarAlojamento.Text = "Eliminar Alojamento";
            buttonEliminarAlojamento.UseVisualStyleBackColor = true;
            // 
            // buttonListarAlojamento
            // 
            buttonListarAlojamento.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonListarAlojamento.Location = new Point(415, 640);
            buttonListarAlojamento.Name = "buttonListarAlojamento";
            buttonListarAlojamento.Size = new Size(220, 46);
            buttonListarAlojamento.TabIndex = 4;
            buttonListarAlojamento.Text = "Listar Alojamento";
            buttonListarAlojamento.UseVisualStyleBackColor = true;
            // 
            // FormMenuAlojamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 753);
            Controls.Add(buttonListarAlojamento);
            Controls.Add(buttonEliminarAlojamento);
            Controls.Add(buttonEditarAlojamento);
            Controls.Add(buttonCriarAlojamento);
            Controls.Add(label1);
            Name = "FormMenuAlojamentos";
            Text = "Menu Alojamentos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonCriarAlojamento;
        private Button buttonEditarAlojamento;
        private Button buttonEliminarAlojamento;
        private Button buttonListarAlojamento;
    }
}