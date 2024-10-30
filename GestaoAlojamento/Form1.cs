using System;
using System.Windows.Forms;

namespace GestaoAlojamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void AbrirFormNoPanel(Form formFilho)
        {
            // Limpa qualquer controle existente dentro do panel
            if (panelConteudo.Controls.Count > 0)
                panelConteudo.Controls.RemoveAt(0);

            // Define o form como filho do panel
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.Sizable; 
            formFilho.Dock = DockStyle.Fill;

            // Adiciona o form ao panel
            panelConteudo.Controls.Add(formFilho);
            panelConteudo.Tag = formFilho;

            // Exibe o form
            formFilho.BringToFront();
            formFilho.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            FormMenuClientes formMenuClientes = new FormMenuClientes();
            AbrirFormNoPanel(formMenuClientes);
        }

        private void buttonAlojamentos_Click(object sender, EventArgs e)
        {
            FormMenuAlojamentos formMenuAlojamentos = new FormMenuAlojamentos();
            AbrirFormNoPanel(formMenuAlojamentos);
        }
    }
}
