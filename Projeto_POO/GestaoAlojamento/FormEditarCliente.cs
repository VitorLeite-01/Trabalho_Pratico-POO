using FuncoesDLL;
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
    public partial class FormEditarCliente : Form
    {
        #region Properties
        private FormPrincipal mainForm;
        private ClienteService clienteService;
        #endregion

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância do formulário de edição de clientes.
        /// </summary>
        /// <param name="mainForm">Formulário principal da aplicação.</param>
        /// <param name="ClienteId">Identificador do cliente.</param>
        public FormEditarCliente(FormPrincipal mainForm, int ClienteId)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            clienteService = new ClienteService();
            CarregarListaClientes();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Carrega a lista de clienstes no comboBox.
        /// </summary>
        private void CarregarListaClientes()
        {
            var listaFormatada = clienteService.CarregarListaFormatada();
            comboBoxClientes.Items.Clear();
            comboBoxClientes.Items.AddRange(listaFormatada.ToArray());

            if (listaFormatada.Count == 0)
            {
                MessageBox.Show("Não há clientes para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        #endregion

        #region Eventos
        private void FormEditarCliente_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Fecha o formulário atual e volta ao menu principal de clientes.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuClientes formMenuClientes = new FormMenuClientes(mainForm);
            mainForm.AbrirFormNoPanel(formMenuClientes);
        }
        /// <summary>
        /// Permite a edição de detalhes do cliente selecionado.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selecionado = comboBoxClientes.SelectedItem.ToString();
            int clienteId = int.Parse(selecionado.Split('|')[0].Trim());

            
            var cliente = clienteService.CarregarClientes().FirstOrDefault(c => c.Id == clienteId);
            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormEditarClienteDetalhes formEditarClienteDetalhes = new FormEditarClienteDetalhes(cliente, clienteService, this, mainForm);
            mainForm.AbrirFormNoPanel(formEditarClienteDetalhes);
        }
        #endregion
    }
}
