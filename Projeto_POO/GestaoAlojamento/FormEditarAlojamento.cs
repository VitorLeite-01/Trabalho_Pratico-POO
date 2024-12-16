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
    public partial class FormEditarAlojamento : Form
    {
        private FormPrincipal mainForm;
        private AlojamentoService alojamentoService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="AlojamentoId"></param>
        public FormEditarAlojamento(FormPrincipal mainForm, int AlojamentoId)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            alojamentoService = new AlojamentoService();
            CarregarListaAlojamentos();
        }
        /// <summary>
        /// 
        /// </summary>
        private void CarregarListaAlojamentos()
        {
            var listaFormatada = alojamentoService.CarregarListaFormatada();
            comboBoxAlojamentos.Items.Clear();
            comboBoxAlojamentos.Items.AddRange(listaFormatada.ToArray());

            if (listaFormatada.Count == 0)
            {
                MessageBox.Show("Não há alojamentos para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void FormEditarAlojamento_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuAlojamentos formMenuAlojamentos = new FormMenuAlojamentos(mainForm);
            mainForm.AbrirFormNoPanel(formMenuAlojamentos);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (comboBoxAlojamentos.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um alojamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selecionado = comboBoxAlojamentos.SelectedItem.ToString();
            int alojamentoId = int.Parse(selecionado.Split('-')[0].Trim());

            var alojamento = alojamentoService.CarregarAlojamentos().FirstOrDefault(a => a.Id == alojamentoId);
            if (alojamento == null)
            {
                MessageBox.Show("Alojamento não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormEditarAlojamentoDetalhes formEditarAlojamentoDetalhes = new FormEditarAlojamentoDetalhes(alojamento, alojamentoService, this, mainForm);
            mainForm.AbrirFormNoPanel(formEditarAlojamentoDetalhes);
        }

        private void comboBoxAlojamentos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
