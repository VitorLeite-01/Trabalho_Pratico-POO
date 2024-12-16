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
    public partial class FormMenuAlojamentos : Form
    {
        private FormPrincipal mainForm;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        public FormMenuAlojamentos(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCriarAlojamento_Click(object sender, EventArgs e)
        {
            FormCriarAlojamento formCriarAlojamento = new FormCriarAlojamento(mainForm);
            mainForm.AbrirFormNoPanel(formCriarAlojamento);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditarAlojamento_Click(object sender, EventArgs e)
        {
            FormEditarAlojamento formEditarAlojamento = new FormEditarAlojamento(mainForm, 0);
            mainForm.AbrirFormNoPanel(formEditarAlojamento);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminarAlojamento_Click(object sender, EventArgs e)
        {
            FormEliminarAlojamento formEliminarAlojamento = new FormEliminarAlojamento(mainForm);
            mainForm.AbrirFormNoPanel(formEliminarAlojamento);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonListarAlojamento_Click(object sender, EventArgs e)
        {
            List<Alojamento> alojamentos = mainForm.CarregarAlojamentos();

            FormListarAlojamentos formListarAlojamentos = new FormListarAlojamentos(alojamentos);
            mainForm.AbrirFormNoPanel(formListarAlojamentos);
        }

        private void FormMenuAlojamentos_Load(object sender, EventArgs e)
        {

        }
    }
}
