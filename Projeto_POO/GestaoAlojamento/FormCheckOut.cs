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
    /// <summary>
    /// 
    /// </summary>
    public partial class FormCheckOut : Form
    {
        private FormPrincipal mainForm;
        private ReservaService reservaService;
        private AlojamentoService alojamentoService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        public FormCheckOut(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            reservaService = new ReservaService();
            alojamentoService = new AlojamentoService();
            CarregarReservasAtivas();
        }
        /// <summary>
        /// 
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
        /// <summary>
        /// 
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
                    this.Close();
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

        private void FormCheckOut_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
    }
}
