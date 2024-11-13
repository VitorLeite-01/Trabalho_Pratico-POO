using GestaoAlojamentoDLL;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace GestaoAlojamento
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        public void AbrirFormNoPanel(Form formFilho)
        {
            // Limpa qualquer controlo existente dentro do panel
            if (panelConteudo.Controls.Count > 0)
                panelConteudo.Controls.RemoveAt(0);

            // Define o form como filho do panel
            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;

            // Adiciona o form ao panel
            panelConteudo.Controls.Add(formFilho);
            panelConteudo.Tag = formFilho;

            // Exibe o form
            formFilho.BringToFront();
            formFilho.Show();
        }
        public List<Cliente> CarregarClientes()
        {
            string caminhoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "clientes.json");

            if (File.Exists(caminhoArquivo))
            {
                string json = File.ReadAllText(caminhoArquivo);
                return JsonConvert.DeserializeObject<List<Cliente>>(json) ?? new List<Cliente>();
            }
            return new List<Cliente>();
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
            FormMenuClientes formMenuClientes = new FormMenuClientes(this);
            AbrirFormNoPanel(formMenuClientes);
        }

        private void buttonAlojamentos_Click(object sender, EventArgs e)
        {
            FormMenuAlojamentos formMenuAlojamentos = new FormMenuAlojamentos();
            AbrirFormNoPanel(formMenuAlojamentos);
        }

        private void panelConteudo_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void buttonReservas_Click(object sender, EventArgs e)
        {
            FormMenuReserva formMenuReserva = new FormMenuReserva();
            AbrirFormNoPanel(formMenuReserva);
        }
    }
}
