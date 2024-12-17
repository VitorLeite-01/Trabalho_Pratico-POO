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
using Newtonsoft.Json;
using GestaoAlojamentoDLL;

namespace GestaoAlojamento
{
    public partial class FormCriarAlojamento : Form
    {
        #region Properties
        private FormPrincipal mainForm;
        private AlojamentoService alojamentoService;
        #endregion

        #region Constructors
        /// <summary>
        /// Construtor do formulário para a criação de alojamentos.
        /// </summary>
        /// <param name="mainForm">Instância do formulário principal da aplicação.</param>
        public FormCriarAlojamento(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            alojamentoService = new AlojamentoService();
            comboBoxEstado.DataSource = Enum.GetValues(typeof(EstadoAlojamento));
            comboBoxEstado.SelectedItem = EstadoAlojamento.Disponivel;
            comboBoxCategoria.DataSource = Enum.GetValues(typeof(CategoriaAlojamento));
            comboBoxCategoria.SelectedItem = CategoriaAlojamento.Single_Room_Standard;
        }
        #endregion

        #region Eventos
        private void FormCriarAlojamento_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Voltar". Retorna ao menu de alojamentos.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuAlojamentos formMenuAlojamentos = new FormMenuAlojamentos(mainForm);
            mainForm.AbrirFormNoPanel(formMenuAlojamentos);
        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Guardar". Valida os dados e regista um novo alojamento.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            var novoAlojamento = new Alojamento
            {
                NumeroAlojamento = int.Parse(textBoxNr.Text),
                Categoria = (CategoriaAlojamento)comboBoxCategoria.SelectedItem,
                PrecoPorNoite = decimal.Parse(textBoxPreco.Text),
                Estado = (EstadoAlojamento)comboBoxEstado.SelectedItem
            };

            if (alojamentoService.NumeroAlojamentoExiste(novoAlojamento.NumeroAlojamento))
            {
                MessageBox.Show("Já existe um alojamento com este número. Por favor, escolha outro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!alojamentoService.CamposPreenchidos(novoAlojamento))
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (alojamentoService.GuardarAlojamento(novoAlojamento))
            {
                MessageBox.Show($"Alojamento registado com sucesso! ID do Alojamento: {novoAlojamento.Id}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxNr.Clear();
                comboBoxCategoria.SelectedIndex = -1;
                textBoxPreco.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao guardar alojamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
