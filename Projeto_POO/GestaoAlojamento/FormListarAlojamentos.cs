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
        public FormListarAlojamentos(List<Alojamento> alojamentos)
        {
            InitializeComponent();
            CarregarDados(alojamentos);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="alojamentos"></param>
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
        private void dataGridViewAlojamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuAlojamentos formMenuAlojamentos = new FormMenuAlojamentos((FormPrincipal)this.ParentForm);
            ((FormPrincipal)this.ParentForm).AbrirFormNoPanel(formMenuAlojamentos);
        }
    }
}
