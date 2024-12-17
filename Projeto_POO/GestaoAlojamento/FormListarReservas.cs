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
    public partial class FormListarReservas : Form
    {
        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância do formulário e carrega os dados das reservas fornecidas.
        /// </summary>
        /// <param name="reservas">Lista de reservas a apresentar.</param>
        public FormListarReservas(List<Reserva> reservas)
        {
            InitializeComponent();
            CarregarDados(reservas);
        }
        #endregion

        #region Métodos 
        /// <summary>
        /// Carrega os dados formatados das reservas no controlo DataGridView.
        /// </summary>
        /// <param name="reservas">Lista de reservas a serem exibidas.</param>
        private void CarregarDados(List<Reserva> reservas)
        {
            var dadosParaExibicao = reservas.Select(r => new
            {
                Cliente = r.Cliente.Nome,
                Alojamento = r.Alojamento.NumeroAlojamento,
                DataCheckIn = r.DataCheckIn.ToString("dd/MM/yyyy"),
                DataCheckOut = r.DataCheckOut.ToString("dd/MM/yyyy"),
                Estado = r.Estado.ToString(),
                Id = r.Id
            }).ToList();
            
            dataGridViewReservas.AutoGenerateColumns = false;
            dataGridViewReservas.Columns.Clear();
            
            dataGridViewReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cliente",
                HeaderText = "Cliente"
            });
            dataGridViewReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Alojamento",
                HeaderText = "Alojamento"
            });
            dataGridViewReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataCheckIn",
                HeaderText = "Data de Check-in"
            });
            dataGridViewReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DataCheckOut",
                HeaderText = "Data de Check-out"
            });
            dataGridViewReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Estado",
                HeaderText = "Estado"
            });
            dataGridViewReservas.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id"
            });
           
            dataGridViewReservas.DataSource = dadosParaExibicao;
        }
        #endregion

        #region Eventos
        private void dataGridViewReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Voltar", retornando ao menu principal de reservas.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuReserva formMenuReserva = new FormMenuReserva((FormPrincipal)this.ParentForm);
            ((FormPrincipal)this.ParentForm).AbrirFormNoPanel(formMenuReserva);
        }
        #endregion
    }
}
