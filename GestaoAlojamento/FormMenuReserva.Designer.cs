namespace GestaoAlojamento
{
    partial class FormMenuReserva
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
            buttonCriarReserva = new Button();
            buttonEditarReserva = new Button();
            buttonEliminarReserva = new Button();
            buttonListarReserva = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonCriarReserva
            // 
            buttonCriarReserva.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCriarReserva.Location = new Point(415, 160);
            buttonCriarReserva.Name = "buttonCriarReserva";
            buttonCriarReserva.Size = new Size(220, 46);
            buttonCriarReserva.TabIndex = 1;
            buttonCriarReserva.Text = "Criar Reserva";
            buttonCriarReserva.UseVisualStyleBackColor = true;
            buttonCriarReserva.Click += buttonCriarReserva_Click;
            // 
            // buttonEditarReserva
            // 
            buttonEditarReserva.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEditarReserva.Location = new Point(415, 320);
            buttonEditarReserva.Name = "buttonEditarReserva";
            buttonEditarReserva.Size = new Size(220, 46);
            buttonEditarReserva.TabIndex = 2;
            buttonEditarReserva.Text = "Editar Reserva";
            buttonEditarReserva.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarReserva
            // 
            buttonEliminarReserva.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEliminarReserva.Location = new Point(415, 480);
            buttonEliminarReserva.Name = "buttonEliminarReserva";
            buttonEliminarReserva.Size = new Size(220, 46);
            buttonEliminarReserva.TabIndex = 3;
            buttonEliminarReserva.Text = "Eliminar Reserva";
            buttonEliminarReserva.UseVisualStyleBackColor = true;
            // 
            // buttonListarReserva
            // 
            buttonListarReserva.Font = new Font("Franklin Gothic Medium Cond", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonListarReserva.Location = new Point(415, 640);
            buttonListarReserva.Name = "buttonListarReserva";
            buttonListarReserva.Size = new Size(220, 46);
            buttonListarReserva.TabIndex = 4;
            buttonListarReserva.Text = "Listar Reserva";
            buttonListarReserva.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Franklin Gothic Medium Cond", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 34);
            label1.Name = "label1";
            label1.Size = new Size(421, 47);
            label1.TabIndex = 0;
            label1.Text = "Escolha a opção pretendida";
            label1.Click += label1_Click;
            // 
            // FormMenuReserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1051, 753);
            Controls.Add(label1);
            Controls.Add(buttonListarReserva);
            Controls.Add(buttonEliminarReserva);
            Controls.Add(buttonEditarReserva);
            Controls.Add(buttonCriarReserva);
            Name = "FormMenuReserva";
            Text = "Menu Reserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonCriarReserva;
        private Button buttonEditarReserva;
        private Button buttonEliminarReserva;
        private Button buttonListarReserva;
        private Label label1;
    }
}