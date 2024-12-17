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
    public partial class FormListarClientes : Form
    {
        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância do formulário e carrega os dados dos clientes fornecidos.
        /// </summary>
        /// <param name="clientes">Lista dos clientes a apresentar.</param>
        public FormListarClientes(List<Cliente> clientes)
        {
            InitializeComponent();
            CarregarDados(clientes);
        }
        #endregion

        #region Métodos 
        /// <summary>
        /// Carrega os dados dos clientes no controlo DataGridView.
        /// </summary>
        /// <param name="clientes">Lista dos clientes a serem exibidos.</param>
        private void CarregarDados(List<Cliente> clientes)
        {
            dataGridViewClientes.AutoGenerateColumns = false;
            dataGridViewClientes.Columns.Clear();
            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome"
            });
            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataNascimento",
                HeaderText = "Data de nascimento"
            });
            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Telefone",
                HeaderText = "Contacto Telefónico"
            });
            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email"
            });
            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id"
            });
            dataGridViewClientes.DataSource = clientes;
        }
        #endregion

        #region Eventos
        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Voltar", retornando ao menu principal de clientes.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuClientes formMenuClientes = new FormMenuClientes((FormPrincipal)this.ParentForm);
            ((FormPrincipal)this.ParentForm).AbrirFormNoPanel(formMenuClientes);
        }
    }
    #endregion
}
