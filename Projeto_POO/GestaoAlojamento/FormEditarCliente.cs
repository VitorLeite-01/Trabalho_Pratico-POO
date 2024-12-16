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
        private FormPrincipal mainForm;
        private ClienteService clienteService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="ClienteId"></param>
        public FormEditarCliente(FormPrincipal mainForm, int ClienteId)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            clienteService = new ClienteService();
            CarregarListaClientes();
        }
        /// <summary>
        /// 
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


        private void FormEditarCliente_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuClientes formMenuClientes = new FormMenuClientes(mainForm);
            mainForm.AbrirFormNoPanel(formMenuClientes);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (comboBoxClientes.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selecionado = comboBoxClientes.SelectedItem.ToString();
            int clienteId = int.Parse(selecionado.Split('-')[0].Trim());

            
            var cliente = clienteService.CarregarClientes().FirstOrDefault(c => c.Id == clienteId);
            if (cliente == null)
            {
                MessageBox.Show("Cliente não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormEditarClienteDetalhes formEditarClienteDetalhes = new FormEditarClienteDetalhes(cliente, clienteService, this, mainForm);
            mainForm.AbrirFormNoPanel(formEditarClienteDetalhes);
        }
    }
}
