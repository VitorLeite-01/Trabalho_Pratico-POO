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
    public partial class FormEditarReservaData : Form
    {
        private FormPrincipal mainForm;
        private AlojamentoService alojamentoService;
        private Reserva reserva;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="reservaSelecionada"></param>
        public FormEditarReservaData(FormPrincipal mainForm, Reserva reservaSelecionada)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            reserva = reservaSelecionada;

            dateCheckin.Value = reserva.DataCheckIn;
            dateCheckout.Value = reserva.DataCheckOut;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAvancar_Click(object sender, EventArgs e)
        {
            if (dateCheckout.Value <= dateCheckin.Value)
            {
                MessageBox.Show("A data de check-out deve ser posterior à data de check-in.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            reserva.DataCheckIn = dateCheckin.Value;
            reserva.DataCheckOut = dateCheckout.Value;

            FormEditarReservaAlojamento formEditarReservaAlojamento = new FormEditarReservaAlojamento(mainForm, reserva, reserva.DataCheckIn, reserva.DataCheckOut);
            mainForm.AbrirFormNoPanel(formEditarReservaAlojamento);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormEditarReserva formEditarReserva = new FormEditarReserva(mainForm);
            mainForm.AbrirFormNoPanel(formEditarReserva);
        }

        private void FormEditarReservaData_Load(object sender, EventArgs e)
        {

        }
    }
}
