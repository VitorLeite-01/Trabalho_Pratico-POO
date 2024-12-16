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
        private FormPrincipal mainForm;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        public FormMenuReserva(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCriarReserva_Click(object sender, EventArgs e)
        {
            FormCriarReserva formCriarReservas = new FormCriarReserva(mainForm);
            mainForm.AbrirFormNoPanel(formCriarReservas);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditarReserva_Click(object sender, EventArgs e)
        {
            FormEditarReserva formEditarReserva = new FormEditarReserva(mainForm);
            mainForm.AbrirFormNoPanel(formEditarReserva);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminarReserva_Click(object sender, EventArgs e)
        {
            FormEliminarReserva formEliminarReserva = new FormEliminarReserva(mainForm);
            mainForm.AbrirFormNoPanel(formEliminarReserva);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonListarReserva_Click(object sender, EventArgs e)
        {
            List<Reserva> reservas = mainForm.CarregarReservas();

            FormListarReservas formListarReservas = new FormListarReservas(reservas);
            mainForm.AbrirFormNoPanel(formListarReservas);
        }

        private void FormMenuReserva_Load(object sender, EventArgs e)
        {

        }
    }
}
