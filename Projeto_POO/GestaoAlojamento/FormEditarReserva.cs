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
    public partial class FormEditarReserva : Form
    {
        #region Properties
        private FormPrincipal mainForm;
        private ReservaService reservaService;
        private List<Reserva> reservas;
        #endregion

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância do formulário de edição de reservas.
        /// </summary>
        /// <param name="mainForm">Formulário principal da aplicação.</param>
        public FormEditarReserva(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            reservaService = new ReservaService();
            CarregarReservas();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Carrega a lista de reservas no comboBox.
        /// </summary>
        private void CarregarReservas()
        {
            reservas = reservaService.CarregarReservas();

            comboBoxReservas.DataSource = reservas;
            comboBoxReservas.DisplayMember = "DescricaoCompleta";
            comboBoxReservas.ValueMember = "Id";
        }
        #endregion

        #region Eventos
        private void FormEditarReserva_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Permite a edição de detalhes da reserva selecionada.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (comboBoxReservas.SelectedItem is Reserva reservaSelecionada)
            {
                FormEditarReservaData formEditarReservaData = new FormEditarReservaData(mainForm, reservaSelecionada);
                mainForm.AbrirFormNoPanel(formEditarReservaData);
            }
            else
            {
                MessageBox.Show("Selecione uma reserva para editar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Fecha o formulário atual e volta ao menu principal de reservas.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuReserva formMenuReservas = new FormMenuReserva(mainForm);
            mainForm.AbrirFormNoPanel(formMenuReservas);
        }
        #endregion
    }
}
