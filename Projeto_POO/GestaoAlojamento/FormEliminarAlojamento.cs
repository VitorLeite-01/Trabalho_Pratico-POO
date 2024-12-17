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
    public partial class FormEliminarAlojamento : Form
    {
        #region Properties
        private FormPrincipal mainForm;
        private AlojamentoService alojamentoService;
        #endregion

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância do formulário de eliminação de alojamento.
        /// </summary>
        /// <param name="mainForm">Referência ao formulário principal.</param>
        public FormEliminarAlojamento(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            alojamentoService = new AlojamentoService();
            CarregarListaAlojamentos();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Carrega a lista de alojamentos disponíveis na ComboBox.
        /// </summary>
        private void CarregarListaAlojamentos()
        {
            var listaFormatada = alojamentoService.CarregarListaFormatada();
            comboBoxAlojamentos.Items.Clear();
            comboBoxAlojamentos.Items.AddRange(listaFormatada.ToArray());

            if (listaFormatada.Count == 0)
            {
                MessageBox.Show("Não há alojamentos para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        #endregion

        #region Eventos
        private void FormEliminarAlojamento_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Evento acionado ao clicar no botão Eliminar.
        /// Elimina o alojamento selecionado.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAlojamentos.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecione um alojamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int alojamentoId = int.Parse(comboBoxAlojamentos.SelectedItem.ToString().Split('|')[0].Trim());

                var confirmacao = MessageBox.Show("Tem certeza de que deseja eliminar o alojamento selecionado?",
                                                  "Confirmação",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    if (alojamentoService.EliminarAlojamento(alojamentoId))
                    {
                        MessageBox.Show("Alojamento eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        comboBoxAlojamentos.SelectedIndex = -1;
                        CarregarListaAlojamentos();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao eliminar alojamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao eliminar alojamento: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Evento acionado ao clicar no botão Voltar.
        /// Retorna ao menu de alojamentos.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuAlojamentos formMenuAlojamentos = new FormMenuAlojamentos(mainForm);
            mainForm.AbrirFormNoPanel(formMenuAlojamentos);
        }
        #endregion
    }
}
