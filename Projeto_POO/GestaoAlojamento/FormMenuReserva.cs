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
    public partial class FormMenuReserva : Form
    {
        #region Properties
        private FormPrincipal mainForm;
        #endregion

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância do formulário do menu de reservas.
        /// </summary>
        /// <param name="mainForm">Referência ao formulário principal.</param>
        public FormMenuReserva(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        #endregion

        #region Eventos 
        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Criar Reserva". Abre o formulário para a criação de uma nova reserva.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonCriarReserva_Click(object sender, EventArgs e)
        {
            FormCriarReserva formCriarReservas = new FormCriarReserva(mainForm);
            mainForm.AbrirFormNoPanel(formCriarReservas);
        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Editar Reserva". Abre o formulário para editar os dados de uma reserva.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonEditarReserva_Click(object sender, EventArgs e)
        {
            FormEditarReserva formEditarReserva = new FormEditarReserva(mainForm);
            mainForm.AbrirFormNoPanel(formEditarReserva);
        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Eliminar Reserva". Abre o formulário para eliminar uma reserva.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonEliminarReserva_Click(object sender, EventArgs e)
        {
            FormEliminarReserva formEliminarReserva = new FormEliminarReserva(mainForm);
            mainForm.AbrirFormNoPanel(formEliminarReserva);
        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Listar Reserva". Exibe o formulário com a lista de todas as reservas.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonListarReserva_Click(object sender, EventArgs e)
        {
            List<Reserva> reservas = mainForm.CarregarReservas();

            FormListarReservas formListarReservas = new FormListarReservas(reservas);
            mainForm.AbrirFormNoPanel(formListarReservas);
        }

        private void FormMenuReserva_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
