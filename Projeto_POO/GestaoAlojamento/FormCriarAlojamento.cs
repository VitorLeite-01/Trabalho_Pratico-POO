using FuncoesDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using GestaoAlojamentoDLL;

namespace GestaoAlojamento
{
    public partial class FormCriarAlojamento : Form
    {
        private FormPrincipal mainForm;
        private AlojamentoService alojamentoService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        public FormCriarAlojamento(FormPrincipal mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            alojamentoService = new AlojamentoService();
            comboBoxEstado.DataSource = Enum.GetValues(typeof(EstadoAlojamento));
            comboBoxEstado.SelectedItem = EstadoAlojamento.Disponivel;
            comboBoxCategoria.DataSource = Enum.GetValues(typeof(CategoriaAlojamento));
            comboBoxCategoria.SelectedItem = CategoriaAlojamento.Single_Room_Standard;
        }

        private void FormCriarAlojamento_Load(object sender, EventArgs e)
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
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            var novoAlojamento = new Alojamento
            {
                NumeroAlojamento = int.Parse(textBoxNr.Text),
                Categoria = (CategoriaAlojamento)comboBoxCategoria.SelectedItem,
                PrecoPorNoite = decimal.Parse(textBoxPreco.Text),
                Estado = (EstadoAlojamento)comboBoxEstado.SelectedItem
            };

            if (alojamentoService.NumeroAlojamentoExiste(novoAlojamento.NumeroAlojamento))
            {
                MessageBox.Show("Já existe um alojamento com este número. Por favor, escolha outro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!alojamentoService.CamposPreenchidos(novoAlojamento))
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (alojamentoService.GuardarAlojamento(novoAlojamento))
            {
                MessageBox.Show($"Alojamento registado com sucesso! ID do Alojamento: {novoAlojamento.Id}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxNr.Clear();
                comboBoxCategoria.SelectedIndex = -1;
                textBoxPreco.Clear();
            }
            else
            {
                MessageBox.Show("Erro ao guardar alojamento.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
