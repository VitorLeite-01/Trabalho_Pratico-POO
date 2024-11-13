using GestaoAlojamentoDLL;
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
        public FormCriarCliente(FormPrincipal form1)
        {
            InitializeComponent();
            mainForm = form1;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // Verifica se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(textBoxNome.Text) ||
                dateTimeNascimento.Value == DateTime.MinValue ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxTelefone.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Validação de idade mínima (18 anos)
            DateTime dataNascimento = dateTimeNascimento.Value;
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (dataNascimento > DateTime.Now.AddYears(-idade)) idade--;

            if (idade < 18)
            {
                MessageBox.Show("O cliente deve ter pelo menos 18 anos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Verifica se o email é válido
            if (!IsValidEmail(textBoxEmail.Text))
            {
                MessageBox.Show("O email inserido não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cria o cliente se as validações forem atendidas
            var novoCliente = new Cliente
            {
               // Id = Guid.NewGuid().ToString(), // Usa Guid para um ID único
                Nome = textBoxNome.Text,
                DataNascimento = dateTimeNascimento.Value,
                Telefone = textBoxTelefone.Text,
                Email = textBoxEmail.Text
            };

            // Caminho do arquivo JSON
            string caminhoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "clientes.json");

            // Lista para armazenar clientes
            List<Cliente> listaClientes;

            // Lê o arquivo JSON se existir
            if (File.Exists(caminhoArquivo))
            {
                // Carrega a lista de clientes existente
                string jsonExistente = File.ReadAllText(caminhoArquivo);
                listaClientes = JsonConvert.DeserializeObject<List<Cliente>>(jsonExistente) ?? new List<Cliente>();
            }
            else
            {
                listaClientes = new List<Cliente>();
            }

            // Adiciona o novo cliente à lista
            listaClientes.Add(novoCliente);

            // Converte a lista de clientes para JSON e salva no arquivo
            string jsonAtualizado = JsonConvert.SerializeObject(listaClientes, Formatting.Indented);
            File.WriteAllText(caminhoArquivo, jsonAtualizado);

            MessageBox.Show($"Cliente registado com sucesso! ID do Cliente: {novoCliente.Id}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Limpar os campos após guardar
            textBoxNome.Clear();
            textBoxEmail.Clear();
            textBoxTelefone.Clear();
            dateTimeNascimento.Value = DateTime.Now;

        }

        // Método para validar o formato do email
        private bool IsValidEmail(string email)
        {
            // Padrão básico de regex para validar email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    

        private void FormCriarCliente_Load(object sender, EventArgs e)
        {

        }

        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuClientes formMenuClientes = new FormMenuClientes(mainForm);
            mainForm.AbrirFormNoPanel(formMenuClientes);
        }
    }
}
