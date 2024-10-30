namespace GestaoAlojamento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panelTitulo = new Panel();
            label1 = new Label();
            buttonFechar = new Button();
            panelMenu = new Panel();
            buttonCheckIn = new Button();
            buttonReservas = new Button();
            buttonAlojamentos = new Button();
            buttonClientes = new Button();
            panelConteudo = new Panel();
            panelTitulo.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.SteelBlue;
            panelTitulo.Controls.Add(label1);
            panelTitulo.Controls.Add(buttonFechar);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1049, 84);
            panelTitulo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Heavy", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(27, 19);
            label1.Name = "label1";
            label1.Size = new Size(576, 39);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Gestão de Alojamentos";
            // 
            // buttonFechar
            // 
            buttonFechar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFechar.FlatAppearance.BorderColor = Color.White;
            buttonFechar.FlatAppearance.BorderSize = 0;
            buttonFechar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            buttonFechar.FlatAppearance.MouseOverBackColor = Color.Red;
            buttonFechar.FlatStyle = FlatStyle.Flat;
            buttonFechar.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonFechar.ForeColor = SystemColors.Control;
            buttonFechar.Location = new Point(975, 19);
            buttonFechar.Name = "buttonFechar";
            buttonFechar.Size = new Size(45, 45);
            buttonFechar.TabIndex = 0;
            buttonFechar.Text = "X";
            buttonFechar.UseVisualStyleBackColor = true;
            buttonFechar.Click += buttonFechar_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(37, 46, 59);
            panelMenu.Controls.Add(buttonCheckIn);
            panelMenu.Controls.Add(buttonReservas);
            panelMenu.Controls.Add(buttonAlojamentos);
            panelMenu.Controls.Add(buttonClientes);
            panelMenu.Location = new Point(0, 83);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(228, 652);
            panelMenu.TabIndex = 1;
            // 
            // buttonCheckIn
            // 
            buttonCheckIn.FlatAppearance.BorderColor = Color.White;
            buttonCheckIn.FlatAppearance.BorderSize = 0;
            buttonCheckIn.FlatAppearance.MouseDownBackColor = Color.White;
            buttonCheckIn.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            buttonCheckIn.FlatStyle = FlatStyle.Flat;
            buttonCheckIn.Font = new Font("Franklin Gothic Demi", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonCheckIn.ForeColor = Color.White;
            buttonCheckIn.Location = new Point(3, 535);
            buttonCheckIn.Name = "buttonCheckIn";
            buttonCheckIn.Size = new Size(222, 50);
            buttonCheckIn.TabIndex = 3;
            buttonCheckIn.Text = "Check-In";
            buttonCheckIn.UseVisualStyleBackColor = true;
            // 
            // buttonReservas
            // 
            buttonReservas.FlatAppearance.BorderColor = Color.White;
            buttonReservas.FlatAppearance.BorderSize = 0;
            buttonReservas.FlatAppearance.MouseDownBackColor = Color.White;
            buttonReservas.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            buttonReservas.FlatStyle = FlatStyle.Flat;
            buttonReservas.Font = new Font("Franklin Gothic Demi", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonReservas.ForeColor = Color.White;
            buttonReservas.Location = new Point(3, 376);
            buttonReservas.Name = "buttonReservas";
            buttonReservas.Size = new Size(222, 50);
            buttonReservas.TabIndex = 2;
            buttonReservas.Text = "Reservas";
            buttonReservas.UseVisualStyleBackColor = true;
            // 
            // buttonAlojamentos
            // 
            buttonAlojamentos.FlatAppearance.BorderColor = Color.White;
            buttonAlojamentos.FlatAppearance.BorderSize = 0;
            buttonAlojamentos.FlatAppearance.MouseDownBackColor = Color.White;
            buttonAlojamentos.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            buttonAlojamentos.FlatStyle = FlatStyle.Flat;
            buttonAlojamentos.Font = new Font("Franklin Gothic Demi", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAlojamentos.ForeColor = Color.White;
            buttonAlojamentos.Location = new Point(3, 204);
            buttonAlojamentos.Name = "buttonAlojamentos";
            buttonAlojamentos.Size = new Size(222, 50);
            buttonAlojamentos.TabIndex = 1;
            buttonAlojamentos.Text = "Alojamentos";
            buttonAlojamentos.UseVisualStyleBackColor = true;
            buttonAlojamentos.Click += buttonAlojamentos_Click;
            // 
            // buttonClientes
            // 
            buttonClientes.FlatAppearance.BorderColor = Color.White;
            buttonClientes.FlatAppearance.BorderSize = 0;
            buttonClientes.FlatAppearance.MouseDownBackColor = Color.White;
            buttonClientes.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            buttonClientes.FlatStyle = FlatStyle.Flat;
            buttonClientes.Font = new Font("Franklin Gothic Demi", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClientes.ForeColor = Color.White;
            buttonClientes.Location = new Point(3, 67);
            buttonClientes.Name = "buttonClientes";
            buttonClientes.Size = new Size(222, 50);
            buttonClientes.TabIndex = 0;
            buttonClientes.Text = "Clientes";
            buttonClientes.UseVisualStyleBackColor = true;
            buttonClientes.Click += buttonClientes_Click;
            // 
            // panelConteudo
            // 
            panelConteudo.BackColor = Color.White;
            panelConteudo.BackgroundImage = (Image)resources.GetObject("panelConteudo.BackgroundImage");
            panelConteudo.BackgroundImageLayout = ImageLayout.Center;
            panelConteudo.Location = new Point(234, 90);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(803, 633);
            panelConteudo.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 735);
            Controls.Add(panelConteudo);
            Controls.Add(panelMenu);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += Form1_Load;
            panelTitulo.ResumeLayout(false);
            panelTitulo.PerformLayout();
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitulo;
        private Button buttonFechar;
        private Label label1;
        private Panel panelMenu;
        private Button buttonClientes;
        private Button buttonCheckIn;
        private Button buttonReservas;
        private Button buttonAlojamentos;
        private Panel panelConteudo;
    }
}
