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
        private FormPrincipal mainForm;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        public FormMenuClientes(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;  
        }


        private void FormMenuClientes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCriarCliente_Click(object sender, EventArgs e)
        {
            FormCriarCliente formCriarCliente = new FormCriarCliente(mainForm);
            mainForm.AbrirFormNoPanel(formCriarCliente);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonListarCliente_Click(object sender, EventArgs e)
        {
            List<Cliente> clientes = mainForm.CarregarClientes();

            FormListarClientes formListarClientes = new FormListarClientes(clientes);
            mainForm.AbrirFormNoPanel(formListarClientes);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditarCliente_Click(object sender, EventArgs e)
        {
            FormEditarCliente formEditarCliente = new FormEditarCliente(mainForm, 0);
                mainForm.AbrirFormNoPanel(formEditarCliente);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminarCliente_Click(object sender, EventArgs e)
        {
            FormEliminarCliente formEliminarCliente = new FormEliminarCliente(mainForm);
            mainForm.AbrirFormNoPanel(formEliminarCliente);
        }
    }
}
