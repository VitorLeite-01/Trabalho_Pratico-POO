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
    public partial class FormCheckIn : Form
    {
        #region Properties
        private ReservaService reservaService;
        private AlojamentoService alojamentoService;
        private Reserva reservaSelecionada;
        #endregion
        #region Constructors
        /// <summary>
        /// Inicializa o formulário de check-in e carrega as reservas pendentes.
        /// </summary>
        public FormCheckIn()
        {
            InitializeComponent();
            reservaService = new ReservaService();
            alojamentoService = new AlojamentoService();
            CarregarReservasPendentes(); 
        }
        #endregion

        #region Métodos 
        /// <summary>
        /// Carrega todas as reservas com estado "Pendente" e preenche o ComboBox para seleção.
        /// Caso não existam reservas pendentes, o formulário é fechado.
        /// </summary>
        private void CarregarReservasPendentes()
        {
            var reservasPendentes = reservaService.CarregarReservas()
                                                  .Where(r => r.Estado == EstadoReserva.Pendente)
                                                  .Select(r => $"ID: {r.Id} | Cliente: {r.Cliente.Nome} | Quarto: {r.Alojamento.NumeroAlojamento} | Check-in: {r.DataCheckIn:dd/MM/yyyy} | Check-out: {r.DataCheckOut:dd/MM/yyyy}")
                                                  .ToList();

            if (reservasPendentes.Any())
            {
                comboBoxReservas.Items.Clear();
                comboBoxReservas.Items.AddRange(reservasPendentes.ToArray());
            }
            else
            {
                MessageBox.Show("Não há reservas pendentes para check-in.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
        #endregion
        #region Eventos
        private void FormCheckIn_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Evento disparado quando o botão "Efetuar Check-In" é clicado.
        /// Atualiza o estado do alojamento e reserva selecionada para indicar o check-in.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonEfetuarCheckIn_Click(object sender, EventArgs e)
        {
            if (comboBoxReservas.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma reserva.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedItem = comboBoxReservas.SelectedItem.ToString();
            string idString = selectedItem.Split('|')[0]
                                          .Replace("ID:", "") 
                                          .Trim();

            int reservaId = int.Parse(idString);

            reservaSelecionada = reservaService.CarregarReservas().FirstOrDefault(r => r.Id == reservaId);
            if (reservaSelecionada == null)
            {
                MessageBox.Show("Erro ao carregar a reserva. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var alojamento = reservaSelecionada.Alojamento;
            alojamento.Estado = EstadoAlojamento.Ocupado;
            alojamentoService.AtualizarAlojamento(alojamento);

            reservaSelecionada.Estado = EstadoReserva.Ativa;
            reservaService.AtualizarReserva(reservaSelecionada);

            MessageBox.Show("Check-In efetuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            comboBoxReservas.SelectedIndex = -1;
        }
        #endregion

    }
}

