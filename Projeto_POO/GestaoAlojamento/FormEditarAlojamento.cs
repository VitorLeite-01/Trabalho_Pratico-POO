using FuncoesDLL;
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
    public partial class FormEditarAlojamento : Form
    {
        #region Properties
        private FormPrincipal mainForm;
        private AlojamentoService alojamentoService;
        #endregion

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância do formulário de edição de alojamentos.
        /// </summary>
        /// <param name="mainForm">Formulário principal da aplicação.</param>
        /// <param name="AlojamentoId">Identificador do alojamento.</param>
        public FormEditarAlojamento(FormPrincipal mainForm, int AlojamentoId)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            alojamentoService = new AlojamentoService();
            CarregarListaAlojamentos();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Carrega a lista de alojamentos no comboBox.
        /// </summary>
        private void CarregarListaAlojamentos()
        {
            var listaFormatada = alojamentoService.CarregarListaFormatada();
            comboBoxAlojamentos.Items.Clear();
            comboBoxAlojamentos.Items.AddRange(listaFormatada.ToArray());

            if (listaFormatada.Count == 0)
            {
                MessageBox.Show("Não há alojamentos para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        #endregion

        #region Eventos
        private void FormEditarAlojamento_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Fecha o formulário atual e volta ao menu principal de alojamentos.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuAlojamentos formMenuAlojamentos = new FormMenuAlojamentos(mainForm);
            mainForm.AbrirFormNoPanel(formMenuAlojamentos);
        }
        /// <summary>
        /// Permite a edição de detalhes do alojamento selecionado.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (comboBoxAlojamentos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um alojamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selecionado = comboBoxAlojamentos.SelectedItem.ToString();
            int alojamentoId = int.Parse(selecionado.Split('|')[0].Trim());

            var alojamento = alojamentoService.CarregarAlojamentos().FirstOrDefault(a => a.Id == alojamentoId);
            if (alojamento == null)
            {
                MessageBox.Show("Alojamento não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormEditarAlojamentoDetalhes formEditarAlojamentoDetalhes = new FormEditarAlojamentoDetalhes(alojamento, alojamentoService, this, mainForm);
            mainForm.AbrirFormNoPanel(formEditarAlojamentoDetalhes);
        }

        private void comboBoxAlojamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
