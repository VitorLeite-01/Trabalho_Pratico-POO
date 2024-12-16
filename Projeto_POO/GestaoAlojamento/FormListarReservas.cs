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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservas"></param>
        public FormListarReservas(List<Reserva> reservas)
        {
            InitializeComponent();
            CarregarDados(reservas);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reservas"></param>
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
        private void dataGridViewReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuReserva formMenuReserva = new FormMenuReserva((FormPrincipal)this.ParentForm);
            ((FormPrincipal)this.ParentForm).AbrirFormNoPanel(formMenuReserva);
        }
    }
}
