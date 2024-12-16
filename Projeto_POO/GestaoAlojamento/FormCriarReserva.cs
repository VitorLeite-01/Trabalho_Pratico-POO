using FuncoesDLL;
using GestaoAlojamentoDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoAlojamento
{
    public partial class FormCriarReserva : Form
    {
        private FormPrincipal mainForm;
        private AlojamentoService alojamentoService;
        private ClienteService clienteService;
        private ReservaService reservaService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        public FormCriarReserva(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

           
            alojamentoService = new AlojamentoService();
            clienteService = new ClienteService();
            reservaService = new ReservaService();

            
            PreencherClientes();
        }
        /// <summary>
        /// 
        /// </summary>
        private void PreencherClientes()
        {
            var clientes = clienteService.CarregarClientes();
            comboBoxCliente.DataSource = clientes;
            comboBoxCliente.DisplayMember = "InfoCompleta"; 
            comboBoxCliente.ValueMember = "Id";   
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCriarReserva_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAvancar_Click(object sender, EventArgs e)
        {
            if (!DateTime.TryParse(dateCheckin.Text, out DateTime dataCheckIn) ||
             !DateTime.TryParse(dateCheckout.Text, out DateTime dataCheckOut))
            {
                MessageBox.Show("Por favor, insira datas válidas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataCheckIn >= dataCheckOut)
            {
                MessageBox.Show("A data de check-out deve ser posterior à de check-in.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var clienteSelecionado = (Cliente)comboBoxCliente.SelectedItem;
            if (clienteSelecionado == null)
            {
                MessageBox.Show("Por favor, selecione um cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            FormSelecionarAlojamento formSelecionarAlojamento = new FormSelecionarAlojamento(mainForm, clienteSelecionado, dataCheckIn, dataCheckOut);
            mainForm.AbrirFormNoPanel(formSelecionarAlojamento);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuReserva formMenuReservas = new FormMenuReserva(mainForm);
            mainForm.AbrirFormNoPanel(formMenuReservas);
        }
    }
}
