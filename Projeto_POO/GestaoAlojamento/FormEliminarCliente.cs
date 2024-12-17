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
    public partial class FormEliminarCliente : Form
    {
        #region Properties
        private FormPrincipal mainForm;
        private ClienteService clienteService;
        #endregion

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância do formulário de eliminação de cliente.
        /// </summary>
        /// <param name="mainForm">Referência ao formulário principal.</param>
        public FormEliminarCliente(FormPrincipal mainForm)
        {
            InitializeComponent();
            clienteService = new ClienteService();
            CarregarListaClientes(); 
            this.mainForm = mainForm;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Carrega a lista de clientes disponíveis na ComboBox.
        /// </summary>
        private void CarregarListaClientes()
        {
            var listaFormatada = clienteService.CarregarListaFormatada();

            if (listaFormatada.Any())
            {
                comboBoxClientes.Items.Clear();
                comboBoxClientes.Items.AddRange(listaFormatada.ToArray());
            }
            else
            {
                MessageBox.Show("Não existem clientes para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        #endregion

        #region Eventos
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEliminarCliente_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Evento acionado ao clicar no botão Voltar.
        /// Retorna ao menu de clientes.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuClientes formMenuClientes = new FormMenuClientes(mainForm);
            mainForm.AbrirFormNoPanel(formMenuClientes);
        }
        /// <summary>
        /// Evento acionado ao clicar no botão Eliminar.
        /// Elimina o cliente selecionado.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxClientes.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecione um cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int clienteId = int.Parse(comboBoxClientes.SelectedItem.ToString().Split('|')[0].Trim());

                var confirmacao = MessageBox.Show("Tem certeza de que deseja eliminar o cliente selecionado?",
                                                  "Confirmação",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    if (clienteService.EliminarCliente(clienteId))
                    {
                        MessageBox.Show("Cliente eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        comboBoxClientes.SelectedIndex = -1;
                        CarregarListaClientes();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao eliminar cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao eliminar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
