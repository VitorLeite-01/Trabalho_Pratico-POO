using GestaoAlojamentoDLL;
using FuncoesDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GestaoAlojamento
{
    public partial class FormCriarCliente : Form
    {
        private FormPrincipal mainForm;
        private ClienteService clienteService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        public FormCriarCliente(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            clienteService = new ClienteService(); // Instancia o ClienteService
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            var novoCliente = new Cliente
            {
                Nome = textBoxNome.Text,
                DataNascimento = dateTimeNascimento.Value,
                Telefone = textBoxTelefone.Text,
                Email = textBoxEmail.Text
            };

            if (!clienteService.CamposPreenchidos(novoCliente))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!clienteService.IdadeMinima(novoCliente.DataNascimento))
            {
                MessageBox.Show("O cliente deve ter pelo menos 18 anos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!clienteService.IsValidEmail(novoCliente.Email))
            {
                MessageBox.Show("O email inserido não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (clienteService.GuardarCliente(novoCliente))
            {
                MessageBox.Show($"Cliente registado com sucesso! ID do Cliente: {novoCliente.Id}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxNome.Clear();
                textBoxEmail.Clear();
                textBoxTelefone.Clear();
                dateTimeNascimento.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Erro ao guardar cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormCriarCliente_Load(object sender, EventArgs e)
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
    }
}
