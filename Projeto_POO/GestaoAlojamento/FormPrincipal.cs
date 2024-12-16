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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="formFilho"></param>
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
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <returns></returns>
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelConteudo_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClientes_Click(object sender, EventArgs e)
        {
            FormMenuClientes formMenuClientes = new FormMenuClientes(this);
            AbrirFormNoPanel(formMenuClientes);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAlojamentos_Click(object sender, EventArgs e)
        {
            FormMenuAlojamentos formMenuAlojamentos = new FormMenuAlojamentos(this);
            AbrirFormNoPanel(formMenuAlojamentos);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelConteudo_Paint_1(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReservas_Click(object sender, EventArgs e)
        {
            FormMenuReserva formMenuReserva = new FormMenuReserva(this);
            AbrirFormNoPanel(formMenuReserva);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            FormCheckIn formCheckIn = new FormCheckIn();
            AbrirFormNoPanel(formCheckIn);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            FormCheckOut formCheckOut = new FormCheckOut(this);
            AbrirFormNoPanel(formCheckOut);
        }
    }
}
