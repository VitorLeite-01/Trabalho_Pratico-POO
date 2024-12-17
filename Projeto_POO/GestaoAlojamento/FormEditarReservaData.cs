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
        #region Properties
        private FormPrincipal mainForm;
        private AlojamentoService alojamentoService;
        private Reserva reserva;
        #endregion

        #region Constructors
        /// <summary>
        ///  Inicializa uma nova instância do formulário de edição da data da reserva.
        /// </summary>
        /// <param name="mainForm">Referência ao formulário principal.</param>
        /// <param name="reservaSelecionada">Reserva selecionada para edição.</param>
        public FormEditarReservaData(FormPrincipal mainForm, Reserva reservaSelecionada)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            reserva = reservaSelecionada;

            dateCheckin.Value = reserva.DataCheckIn;
            dateCheckout.Value = reserva.DataCheckOut;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Evento acionado ao pressionar o botão Avancar.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
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
        /// Evento acionado ao pressionar o botão Voltar.
        /// Retorna para o formulário anterior.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormEditarReserva formEditarReserva = new FormEditarReserva(mainForm);
            mainForm.AbrirFormNoPanel(formEditarReserva);
        }

        private void FormEditarReservaData_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
