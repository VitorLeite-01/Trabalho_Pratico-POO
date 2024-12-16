using FuncoesDLL;
using GestaoAlojamentoDLL;
using Newtonsoft.Json;
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
    public partial class FormEditarClienteDetalhes : Form
    {
        private Cliente cliente;
        private ClienteService clienteService;
        private FormEditarCliente formEditarCliente; 
        private FormPrincipal mainForm;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="clienteService"></param>
        /// <param name="formEditarCliente"></param>
        /// <param name="mainForm"></param>
        public FormEditarClienteDetalhes(Cliente cliente, ClienteService clienteService, FormEditarCliente formEditarCliente, FormPrincipal mainForm)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.clienteService = clienteService;
            this.formEditarCliente = formEditarCliente; 
            this.mainForm = mainForm;
            PreencherDados();
        }
        /// <summary>
        /// 
        /// </summary>
        private void PreencherDados()
        {
            textBoxNome.Text = cliente.Nome;
            textBoxEmail.Text = cliente.Email;
            textBoxTelefone.Text = cliente.Telefone;
            dateTimeNascimento.Value = cliente.DataNascimento;
        }

        private void FormEditarClienteDetalhes_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            cliente.Nome = textBoxNome.Text.Trim();
            cliente.Email = textBoxEmail.Text.Trim();
            cliente.Telefone = textBoxTelefone.Text.Trim();
            cliente.DataNascimento = dateTimeNascimento.Value;

            if (!clienteService.CamposPreenchidos(cliente))
            {
                MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clienteService.IsValidEmail(cliente.Email))
            {
                MessageBox.Show("Email inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clienteService.IdadeMinima(cliente.DataNascimento))
            {
                MessageBox.Show("O cliente deve ter pelo menos 18 anos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var clientes = clienteService.CarregarClientes();
            var clienteExistente = clientes.FirstOrDefault(c => c.Id == cliente.Id);

            if (clienteExistente != null)
            {
                clienteExistente.Nome = cliente.Nome;
                clienteExistente.Email = cliente.Email;
                clienteExistente.Telefone = cliente.Telefone;
                clienteExistente.DataNascimento = cliente.DataNascimento;

                try
                {
                    string json = JsonConvert.SerializeObject(clientes, Formatting.Indented);
                    File.WriteAllText(clienteService.caminhoArquivo, json);
                    MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Retorna ao menu
                    FormMenuClientes formMenuClientes = new FormMenuClientes(mainForm);
                    mainForm.AbrirFormNoPanel(formMenuClientes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            mainForm.AbrirFormNoPanel(formEditarCliente);
        }
    }
}

