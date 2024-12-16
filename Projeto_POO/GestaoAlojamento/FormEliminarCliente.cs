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
    public partial class FormEliminarCliente : Form
    {
        private FormPrincipal mainForm;
        private ClienteService clienteService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        public FormEliminarCliente(FormPrincipal mainForm)
        {
            InitializeComponent();
            clienteService = new ClienteService();
            CarregarListaClientes(); 
            this.mainForm = mainForm;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CarregarListaClientes()
        {
            var listaFormatada = clienteService.CarregarListaFormatada();

            if (listaFormatada.Any())
            {
                comboBoxClientes.Items.Clear();
                comboBoxClientes.Items.AddRange(listaFormatada.ToArray());
            }
            else
            {
                MessageBox.Show("Não existem clientes para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormEliminarCliente_Load(object sender, EventArgs e)
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
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxClientes.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecione um cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int clienteId = int.Parse(comboBoxClientes.SelectedItem.ToString().Split('-')[0].Trim());

                var confirmacao = MessageBox.Show("Tem certeza de que deseja eliminar o cliente selecionado?",
                                                  "Confirmação",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    if (clienteService.EliminarCliente(clienteId))
                    {
                        MessageBox.Show("Cliente eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        comboBoxClientes.SelectedIndex = -1;
                        CarregarListaClientes();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao eliminar cliente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao eliminar cliente: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
