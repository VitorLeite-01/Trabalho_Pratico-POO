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
    public partial class FormCheckOut : Form
    {
        #region Properties
        private FormPrincipal mainForm;
        private ReservaService reservaService;
        private AlojamentoService alojamentoService;
        #endregion

        #region Constructors
        /// <summary>
        /// Construtor do formulário de Check-Out. Inicializa os serviços e carrega as reservas ativas.
        /// </summary>
        /// <param name="mainForm">Formulário principal da aplicação.</param>
        public FormCheckOut(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            reservaService = new ReservaService();
            alojamentoService = new AlojamentoService();
            CarregarReservasAtivas();
        }
        #endregion

        #region Classes Internas
        /// <summary>
        /// Representa um item da ComboBox contendo texto a apresentar e valor associado.
        /// </summary>
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        #endregion

        #region Métodos 
        /// <summary>
        /// Carrega todas as reservas com alojamentos ocupados (ativas) e apresenta na ComboBox.
        /// </summary>
        private void CarregarReservasAtivas()
        {
            try
            {
                var reservasAtivas = reservaService.CarregarReservas()
                    .Where(r => r.Alojamento.Estado == EstadoAlojamento.Ocupado)
                    .ToList();

                if (!reservasAtivas.Any())
                {
                    MessageBox.Show("Nenhuma reserva ativa encontrada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                comboBoxReservas.Items.Clear();
                foreach (var reserva in reservasAtivas)
                {
                    comboBoxReservas.Items.Add(new ComboBoxItem
                    {
                        Text = $"Cliente: {reserva.Cliente.Nome} | Alojamento: {reserva.Alojamento.NumeroAlojamento} | Check-In: {reserva.DataCheckIn:dd/MM/yyyy} | Check-Out: {reserva.DataCheckOut:dd/MM/yyyy}",
                        Value = reserva
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar reservas ativas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Eventos
        private void FormCheckOut_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Evento disparado ao clicar no botão de efetuar Check-Out. Finaliza a reserva ativa selecionada.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void buttonEfetuarCheckOut_Click(object sender, EventArgs e)
        {
            if (comboBoxReservas.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma reserva para finalizar o check-out.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var comboBoxItem = (ComboBoxItem)comboBoxReservas.SelectedItem;
                var reservaSelecionada = (Reserva)comboBoxItem.Value;

                TimeSpan duracaoEstadia = reservaSelecionada.DataCheckOut - reservaSelecionada.DataCheckIn;
                int numeroNoites = duracaoEstadia.Days;
                decimal precoTotal = numeroNoites * reservaSelecionada.Alojamento.PrecoPorNoite;

                DialogResult result = MessageBox.Show(
                    $"Cliente: {reservaSelecionada.Cliente.Nome}\n" +
                    $"Alojamento: {reservaSelecionada.Alojamento.NumeroAlojamento}\n" +
                    $"Data de Check-In: {reservaSelecionada.DataCheckIn:dd/MM/yyyy}\n" +
                    $"Data de Check-Out: {reservaSelecionada.DataCheckOut:dd/MM/yyyy}\n" +
                    $"Total de Noites: {numeroNoites}\n" +
                    $"Preço Total: {precoTotal:C}",
                    "Finalizar Check-Out", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    alojamentoService.AtualizarEstadoAlojamento(reservaSelecionada.Alojamento.Id, EstadoAlojamento.Disponivel);

                    reservaSelecionada.Estado = EstadoReserva.Concluida;
                    reservaService.AtualizarReserva(reservaSelecionada);
                    MessageBox.Show("Check-Out finalizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxReservas.SelectedIndex = -1;
                    CarregarReservasAtivas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao finalizar o check-out: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
