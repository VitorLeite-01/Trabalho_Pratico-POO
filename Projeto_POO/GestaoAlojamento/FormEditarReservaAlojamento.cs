using FuncoesDLL;
using GestaoAlojamentoDLL;
using Newtonsoft.Json;
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
    public partial class FormEditarReservaAlojamento : Form
    {
        #region Properties
        private FormPrincipal mainForm;
        private Reserva reserva;
        private AlojamentoService alojamentoService;
        private List<Alojamento> alojamentosDisponiveis;
        private DateTime dataCheckIn;
        private DateTime dataCheckOut;
        #endregion

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância do formulário de edição da reserva de alojamento.
        /// </summary>
        /// <param name="mainForm">Referência ao formulário principal.</param>
        /// <param name="reservaSelecionada">Reserva selecionada para edição.</param>
        /// <param name="dataCheckIn">Data de check-in.</param>
        /// <param name="dataCheckOut">Data de check-out.</param>
        public FormEditarReservaAlojamento(FormPrincipal mainForm, Reserva reservaSelecionada, DateTime dataCheckIn, DateTime dataCheckOut)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            reserva = reservaSelecionada;
            alojamentoService = new AlojamentoService();
            this.dataCheckIn = dataCheckIn;
            this.dataCheckOut = dataCheckOut;

            comboBoxCategorias.DataSource = Enum.GetValues(typeof(CategoriaAlojamento));
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Configura o DataGridView com a lista de alojamentos disponíveis.
        /// </summary>
        /// <param name="alojamentos">Lista de alojamentos disponíveis.</param>
        private void ConfigurarDataGridView(List<Alojamento> alojamentos)
        {
            dataGridViewAlojamentos.AutoGenerateColumns = false;
            dataGridViewAlojamentos.Columns.Clear();
            dataGridViewAlojamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NumeroAlojamento",
                DataPropertyName = "NumeroAlojamento",
                HeaderText = "Número do Alojamento"
            });
            dataGridViewAlojamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Categoria",
                HeaderText = "Categoria"
            });
            dataGridViewAlojamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrecoPorNoite",
                HeaderText = "Preço por noite"
            });
            dataGridViewAlojamentos.DataSource = alojamentos;
        }
        #endregion

        #region Eventos
        private void FormEditarReservaAlojamentocs_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Evento acionado ao pressionar o botão Pesquisar.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            if (comboBoxCategorias.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma categoria.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var categoriaSelecionada = (CategoriaAlojamento)comboBoxCategorias.SelectedItem;

            alojamentosDisponiveis = alojamentoService.FiltrarAlojamentosDisponiveis(dataCheckIn, dataCheckOut, categoriaSelecionada);

            if (!alojamentosDisponiveis.Any())
            {
                MessageBox.Show("Nenhum alojamento disponível para o período e categoria selecionados.",
                                "Sem Resultados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            ConfigurarDataGridView(alojamentosDisponiveis);
        }

        /// <summary>
        /// Evento acionado ao pressionar o botão Confirmar.
        /// Atualiza os dados da reserva.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAlojamentos.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Por favor, selecione um alojamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var linhaSelecionada = dataGridViewAlojamentos.SelectedRows[0];
                int numeroAlojamento = Convert.ToInt32(linhaSelecionada.Cells["NumeroAlojamento"].Value);

                var alojamentoSelecionado = alojamentoService.CarregarAlojamentos()
                    .FirstOrDefault(a => a.NumeroAlojamento == numeroAlojamento);

                if (alojamentoSelecionado == null)
                {
                    MessageBox.Show("Erro ao encontrar o alojamento selecionado. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var alojamentoAnterior = reserva.Alojamento;
                if (alojamentoAnterior != null && alojamentoAnterior.Id != alojamentoSelecionado.Id)
                {
                    alojamentoAnterior.Estado = EstadoAlojamento.Disponivel;
                    alojamentoService.AtualizarAlojamento(alojamentoAnterior);
                }

                alojamentoSelecionado.Estado = EstadoAlojamento.Pendente;
                alojamentoService.AtualizarAlojamento(alojamentoSelecionado);

                reserva.Alojamento = alojamentoSelecionado;
                reserva.DataCheckIn = dataCheckIn;
                reserva.DataCheckOut = dataCheckOut;

                var reservaService = new ReservaService();
                var reservas = reservaService.CarregarReservas();
                var reservaExistente = reservas.FirstOrDefault(r => r.Id == reserva.Id);

                if (reservaExistente != null)
                {
                    reservas.Remove(reservaExistente);
                    reservas.Add(reserva);
                    File.WriteAllText(reservaService.caminhoArquivoReservas, JsonConvert.SerializeObject(reservas, Formatting.Indented));
                }

                MessageBox.Show("Reserva atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormEditarReserva formEditarReserva = new FormEditarReserva(mainForm);
                mainForm.AbrirFormNoPanel(formEditarReserva);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao atualizar a reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// Evento acionado ao pressionar o botão Cancelar.
        /// Retorna para o formulário anterior.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            FormEditarReservaData formEditarReservaData = new FormEditarReservaData(mainForm, reserva);
            mainForm.AbrirFormNoPanel(formEditarReservaData);
        }
    }
    #endregion
}
