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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientes"></param>
        public FormListarClientes(List<Cliente> clientes)
        {
            InitializeComponent();
            CarregarDados(clientes);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="clientes"></param>
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

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuClientes formMenuClientes = new FormMenuClientes((FormPrincipal)this.ParentForm);
            ((FormPrincipal)this.ParentForm).AbrirFormNoPanel(formMenuClientes);
        }
    }
}
