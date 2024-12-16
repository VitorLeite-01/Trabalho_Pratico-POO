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
using Newtonsoft.Json;

namespace GestaoAlojamento
{
    public partial class FormEditarAlojamentoDetalhes : Form
    {
        private Alojamento alojamento;
        private AlojamentoService alojamentoService;
        private FormEditarAlojamento formEditarAlojamento;
        private FormPrincipal mainForm;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="alojamento"></param>
        /// <param name="alojamentoService"></param>
        /// <param name="formEditarAlojamento"></param>
        /// <param name="mainForm"></param>
        public FormEditarAlojamentoDetalhes(Alojamento alojamento, AlojamentoService alojamentoService, FormEditarAlojamento formEditarAlojamento, FormPrincipal mainForm)
        {
            InitializeComponent();
            this.alojamento = alojamento;
            this.alojamentoService = alojamentoService;
            this.formEditarAlojamento = formEditarAlojamento;
            this.mainForm = mainForm;
            PreencherDados();
        }
        /// <summary>
        /// 
        /// </summary>
        private void PreencherDados()
        {
            comboBoxEstado.DataSource = Enum.GetValues(typeof(EstadoAlojamento));
            comboBoxCategoria.DataSource = Enum.GetValues(typeof(CategoriaAlojamento));

            textBoxNr.Text = alojamento.NumeroAlojamento.ToString();
            comboBoxCategoria.SelectedItem = alojamento.Categoria;
            textBoxPreco.Text = alojamento.PrecoPorNoite.ToString("F2");
            comboBoxEstado.SelectedItem = alojamento.Estado;
        }

        private void FormEditarAlojamentoDetalhes_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            alojamento.NumeroAlojamento = int.Parse(textBoxNr.Text.Trim());
            alojamento.Categoria = (CategoriaAlojamento)comboBoxCategoria.SelectedItem; 
            alojamento.PrecoPorNoite = decimal.Parse(textBoxPreco.Text.Trim());
            alojamento.Estado = (EstadoAlojamento)comboBoxEstado.SelectedItem;

            if (!alojamentoService.CamposPreenchidos(alojamento))
            {
                MessageBox.Show("Preencha todos os campos corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var alojamentos = alojamentoService.CarregarAlojamentos();
            var alojamentoExistente = alojamentos.FirstOrDefault(a => a.Id == alojamento.Id);

            if (alojamentoExistente != null)
            {
                alojamentoExistente.NumeroAlojamento = alojamento.NumeroAlojamento;
                alojamentoExistente.Categoria = alojamento.Categoria;
                alojamentoExistente.PrecoPorNoite = alojamento.PrecoPorNoite;
                alojamentoExistente.Estado = alojamento.Estado;

                try
                {
                    string json = JsonConvert.SerializeObject(alojamentos, Formatting.Indented);
                    File.WriteAllText(alojamentoService.caminhoArquivo, json);
                    MessageBox.Show("Alojamento atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    FormMenuAlojamentos formMenuAlojamentos = new FormMenuAlojamentos(mainForm);
                    mainForm.AbrirFormNoPanel(formMenuAlojamentos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            mainForm.AbrirFormNoPanel(formEditarAlojamento);
        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
