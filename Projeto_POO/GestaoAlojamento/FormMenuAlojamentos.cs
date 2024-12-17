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
        #region Properties
        private FormPrincipal mainForm;
        #endregion

        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância do formulário do menu de alojamentos.
        /// </summary>
        /// <param name="mainForm">Referência ao formulário principal.</param>
        public FormMenuAlojamentos(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        #endregion

        #region Eventos
        /// <summary>
        /// Evento acionado ao clicar no botão "Criar Alojamento". Abre o formulário para criação de um novo alojamento.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonCriarAlojamento_Click(object sender, EventArgs e)
        {
            FormCriarAlojamento formCriarAlojamento = new FormCriarAlojamento(mainForm);
            mainForm.AbrirFormNoPanel(formCriarAlojamento);
        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Editar Alojamento". Abre o formulário para edição de um alojamento.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonEditarAlojamento_Click(object sender, EventArgs e)
        {
            FormEditarAlojamento formEditarAlojamento = new FormEditarAlojamento(mainForm, 0);
            mainForm.AbrirFormNoPanel(formEditarAlojamento);
        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Eliminar Alojamento". Abre o formulário para eliminação de alojamentos.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonEliminarAlojamento_Click(object sender, EventArgs e)
        {
            FormEliminarAlojamento formEliminarAlojamento = new FormEliminarAlojamento(mainForm);
            mainForm.AbrirFormNoPanel(formEliminarAlojamento);
        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Listar Alojamentos". Exibe o formulário com a lista de todos os alojamentos.
        /// </summary>
        /// <param name="sender">Fonte do evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonListarAlojamento_Click(object sender, EventArgs e)
        {
            List<Alojamento> alojamentos = mainForm.CarregarAlojamentos();

            FormListarAlojamentos formListarAlojamentos = new FormListarAlojamentos(alojamentos);
            mainForm.AbrirFormNoPanel(formListarAlojamentos);
        }

        private void FormMenuAlojamentos_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
