using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestaoAlojamento;
using GestaoAlojamentoDLL;
using static System.Windows.Forms.DataFormats;

namespace GestaoAlojamento
{
    public partial class FormMenuClientes : Form
    {
        #region Properties
        private FormPrincipal mainForm;
        #endregion

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância do formulário do menu de clientes.
        /// </summary>
        /// <param name="mainForm">Referência ao formulário principal.</param>
        public FormMenuClientes(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;  
        }
        #endregion

        #region Eventos 

        private void FormMenuClientes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Criar Cliente". Abre o formulário para a criação de um novo cliente.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonCriarCliente_Click(object sender, EventArgs e)
        {
            FormCriarCliente formCriarCliente = new FormCriarCliente(mainForm);
            mainForm.AbrirFormNoPanel(formCriarCliente);
        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Listar Cliente". Exibe o formulário com a lista de todos os clientes.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonListarCliente_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = mainForm.CarregarClientes();

            FormListarClientes formListarClientes = new FormListarClientes(clientes);
            mainForm.AbrirFormNoPanel(formListarClientes);
        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Editar Cliente". Abre o formulário para editar os dados de um cliente.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            FormEditarCliente formEditarCliente = new FormEditarCliente(mainForm, 0);
                mainForm.AbrirFormNoPanel(formEditarCliente);
        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Eliminar Cliente". Abre o formulário para eliminar um cliente.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            FormEliminarCliente formEliminarCliente = new FormEliminarCliente(mainForm);
            mainForm.AbrirFormNoPanel(formEliminarCliente);
        }
        #endregion
    }
}
