using GestaoAlojamentoDLL;
using Newtonsoft.Json;
using System;
using System.Windows.Forms;

namespace GestaoAlojamento
{
    public partial class FormPrincipal : Form
    {
        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância do formulário principal.
        /// </summary>
        public FormPrincipal()
        {
            InitializeComponent();
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Abre um formulário filho no painel principal da aplicação.
        /// </summary>
        /// <param name="formFilho">Formulário a ser aberto.</param>
        public void AbrirFormNoPanel(Form formFilho)
        {
            if (panelConteudo.Controls.Count > 0)
                panelConteudo.Controls.RemoveAt(0);

            formFilho.TopLevel = false;
            formFilho.FormBorderStyle = FormBorderStyle.None;
            formFilho.Dock = DockStyle.Fill;

            panelConteudo.Controls.Add(formFilho);
            panelConteudo.Tag = formFilho;

            formFilho.BringToFront();
            formFilho.Show();
        }
        /// <summary>
        /// Carrega os clientes a partir de um ficheiro JSON.
        /// </summary>
        /// <returns>Lista de clientes carregados.</returns>
        public List<Cliente> CarregarClientes()
        {
            string pastaDados = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dados");
            string caminhoArquivo = Path.Combine(pastaDados, "clientes.json");

            if (File.Exists(caminhoArquivo))
            {
                string json = File.ReadAllText(caminhoArquivo);
                return JsonConvert.DeserializeObject<List<Cliente>>(json) ?? new List<Cliente>();
            }
            return new List<Cliente>();
        }
        /// <summary>
        /// Carrega os alojamentos a partir de um ficheiro JSON.
        /// </summary>
        /// <returns>Lista de alojamentos carregados.</returns>
        public List<Alojamento> CarregarAlojamentos()
        {
            string pastaDados = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dados");
            string caminhoArquivo = Path.Combine(pastaDados, "alojamentos.json");

            if (File.Exists(caminhoArquivo))
            {
                string json = File.ReadAllText(caminhoArquivo);
                return JsonConvert.DeserializeObject<List<Alojamento>>(json) ?? new List<Alojamento>();
            }
            return new List<Alojamento>();
        }
        /// <summary>
        /// Carrega as reservas a partir de um ficheiro JSON.
        /// </summary>
        /// <returns>Lista de reservas carregadas.</returns>
        public List<Reserva> CarregarReservas()
        {
            string pastaDados = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Dados");
            string caminhoArquivo = Path.Combine(pastaDados, "reservas.json");

            if (File.Exists(caminhoArquivo))
            {
                string json = File.ReadAllText(caminhoArquivo);
                return JsonConvert.DeserializeObject<List<Reserva>>(json) ?? new List<Reserva>();
            }
            return new List<Reserva>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Fecha a aplicação.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Abre o menu de gestão de clientes.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            FormMenuClientes formMenuClientes = new FormMenuClientes(this);
            AbrirFormNoPanel(formMenuClientes);
        }
        /// <summary>
        /// Abre o menu de gestão de alojamentos.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonAlojamentos_Click(object sender, EventArgs e)
        {
            FormMenuAlojamentos formMenuAlojamentos = new FormMenuAlojamentos(this);
            AbrirFormNoPanel(formMenuAlojamentos);
        }
        private void panelConteudo_Paint_1(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Abre o menu de gestão de reservas.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonReservas_Click(object sender, EventArgs e)
        {
            FormMenuReserva formMenuReserva = new FormMenuReserva(this);
            AbrirFormNoPanel(formMenuReserva);
        }
        /// <summary>
        /// Abre o formulário de Check-In.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            FormCheckIn formCheckIn = new FormCheckIn();
            AbrirFormNoPanel(formCheckIn);
        }
        /// <summary>
        /// Abre o formulário de Check-Out.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            FormCheckOut formCheckOut = new FormCheckOut(this);
            AbrirFormNoPanel(formCheckOut);
        }
        #endregion
    }
}
