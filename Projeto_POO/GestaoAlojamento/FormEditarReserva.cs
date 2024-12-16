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
        private FormPrincipal mainForm;
        private ReservaService reservaService;
        private List<Reserva> reservas;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        public FormEditarReserva(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            reservaService = new ReservaService();
            CarregarReservas();
        }
        /// <summary>
        /// 
        /// </summary>
        private void CarregarReservas()
        {
            reservas = reservaService.CarregarReservas();

            comboBoxReservas.DataSource = reservas;
            comboBoxReservas.DisplayMember = "DescricaoCompleta";
            comboBoxReservas.ValueMember = "Id";
        }
        private void FormEditarReserva_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuReserva formMenuReservas = new FormMenuReserva(mainForm);
            mainForm.AbrirFormNoPanel(formMenuReservas);
        }
    }
}
