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
        private FormPrincipal mainForm; // referenciar o Form1 para que o FormMenuClientes chame o metodo AbrirFormNoPanel
        public FormMenuClientes(FormPrincipal form1)
        {
            InitializeComponent();
            mainForm = form1;  //declarar que o mainForm é o form1
        }


        private void FormMenuClientes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCriarCliente_Click(object sender, EventArgs e)
        {
            FormCriarCliente formCriarCliente = new FormCriarCliente(mainForm);
            mainForm.AbrirFormNoPanel(formCriarCliente);
        }

        private void buttonListarCliente_Click(object sender, EventArgs e)
        {
            // Obtém a lista de clientes carregada no FormPrincipal
            List<Cliente> clientes = mainForm.CarregarClientes();

            // Cria e abre o FormListarClientes, passando a lista de clientes
            FormListarClientes formListarClientes = new FormListarClientes(clientes);
            mainForm.AbrirFormNoPanel(formListarClientes);
        }
    }
}
