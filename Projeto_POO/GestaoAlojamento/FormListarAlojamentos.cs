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
    public partial class FormListarAlojamentos : Form
    {
        #region Constructors
        /// <summary>
        /// Inicializa uma nova instância do formulário e carrega os dados dos alojamentos fornecidos.
        /// </summary>
        /// <param name="alojamentos">Lista de alojamentos a apresentar.</param>
        public FormListarAlojamentos(List<Alojamento> alojamentos)
        {
            InitializeComponent();
            CarregarDados(alojamentos);
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Carrega os dados dos alojamentos no controlo DataGridView.
        /// </summary>
        /// <param name="alojamentos">Lista dos alojamentos a serem exibidos.</param>
        private void CarregarDados(List<Alojamento> alojamentos)
        {
            dataGridViewAlojamentos.AutoGenerateColumns = false;
            dataGridViewAlojamentos.Columns.Clear();
            dataGridViewAlojamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "NumeroAlojamento",
                HeaderText = "Número do Alojamento"
            });
            dataGridViewAlojamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Categoria",
                HeaderText = "Categoria do Alojamento"
            });
            dataGridViewAlojamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "PrecoPorNoite",
                HeaderText = "Preço por noite (€)"
            });
            dataGridViewAlojamentos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id"
            });
            dataGridViewAlojamentos.DataSource = alojamentos;
        }
        #endregion

        #region Eventos
        private void dataGridViewAlojamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Evento acionado ao clicar no botão "Voltar", retornando ao menu principal de alojamentos.
        /// </summary>
        /// <param name="sender">Objeto que acionou o evento.</param>
        /// <param name="e">Dados do evento.</param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuAlojamentos formMenuAlojamentos = new FormMenuAlojamentos((FormPrincipal)this.ParentForm);
            ((FormPrincipal)this.ParentForm).AbrirFormNoPanel(formMenuAlojamentos);
        }
        #endregion
    }
}
