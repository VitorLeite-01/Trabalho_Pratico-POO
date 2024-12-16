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
        private ReservaService reservaService;
        private AlojamentoService alojamentoService;
        private Reserva reservaSelecionada;
        /// <summary>
        /// 
        /// </summary>
        public FormCheckIn()
        {
            InitializeComponent();
            reservaService = new ReservaService();
            alojamentoService = new AlojamentoService();
            CarregarReservasPendentes(); 
        }
        /// <summary>
        /// 
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


        private void FormCheckIn_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
    }
}

