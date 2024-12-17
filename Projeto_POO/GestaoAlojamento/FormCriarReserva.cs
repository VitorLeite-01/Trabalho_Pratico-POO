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
        #region Properties
        private FormPrincipal mainForm;
        private AlojamentoService alojamentoService;
        private ClienteService clienteService;
        private ReservaService reservaService;
        #endregion

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância do formulário para criar reservas.
        /// </summary>
        /// <param name="mainForm">Formulário principal da aplicação.</param>
        public FormCriarReserva(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

           
            alojamentoService = new AlojamentoService();
            clienteService = new ClienteService();
            reservaService = new ReservaService();

            
            PreencherClientes();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Preenche o combobox com a lista de clientes registados.
        /// </summary>
        private void PreencherClientes()
        {
            var clientes = clienteService.CarregarClientes();
            comboBoxCliente.DataSource = clientes;
            comboBoxCliente.DisplayMember = "InfoCompleta"; 
            comboBoxCliente.ValueMember = "Id";   
        }
        
        private void FormCriarReserva_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Valida os dados inseridos e avança para o formulário de seleção de alojamento.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
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
        /// Retorna ao menu principal das reservas.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuReserva formMenuReservas = new FormMenuReserva(mainForm);
            mainForm.AbrirFormNoPanel(formMenuReservas);
        }
        #endregion
    }
}
