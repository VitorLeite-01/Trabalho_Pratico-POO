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
        public FormListarClientes(List<Cliente> clientes)
        {
            InitializeComponent();
            CarregarDados(clientes);
        }

        private void CarregarDados(List<Cliente> clientes)
        {
            dataGridViewClientes.DataSource = clientes;
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
