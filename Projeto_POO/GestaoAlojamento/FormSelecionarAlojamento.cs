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
    public partial class FormSelecionarAlojamento : Form
    {
        private FormPrincipal mainForm;
        private Cliente cliente;
        private DateTime dataCheckIn;
        private DateTime dataCheckOut;
        private AlojamentoService alojamentoService;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        /// <param name="cliente"></param>
        /// <param name="dataCheckIn"></param>
        /// <param name="dataCheckOut"></param>
        public FormSelecionarAlojamento(FormPrincipal mainForm, Cliente cliente, DateTime dataCheckIn, DateTime dataCheckOut)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.cliente = cliente;
            this.dataCheckIn = dataCheckIn;
            this.dataCheckOut = dataCheckOut;
            alojamentoService = new AlojamentoService();

           
            comboBoxCategoriaFiltro.DataSource = Enum.GetValues(typeof(CategoriaAlojamento));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
           
            if (comboBoxCategoriaFiltro.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma categoria.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var categoriaSelecionada = (CategoriaAlojamento)comboBoxCategoriaFiltro.SelectedItem;

            try
            {
                
                var alojamentosFiltrados = alojamentoService.AlojamentosDisponiveis(dataCheckIn, dataCheckOut)
                    .Where(a => a.Categoria == categoriaSelecionada)
                    .ToList();

                if (!alojamentosFiltrados.Any())
                {
                    MessageBox.Show("Não há alojamentos disponivies para a categoria selecionada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

               
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
                    HeaderText = "Categoria"
                });
                dataGridViewAlojamentos.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "PrecoPorNoite",
                    HeaderText = "Preço por noite"
                });

                dataGridViewAlojamentos.DataSource = alojamentosFiltrados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao pesquisar alojamentos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormCriarReserva formCriarReservas = new FormCriarReserva(mainForm);
            mainForm.AbrirFormNoPanel(formCriarReservas);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReservar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlojamentos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione um alojamento para realizar a reserva.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var alojamentoSelecionado = (Alojamento)dataGridViewAlojamentos.SelectedRows[0].DataBoundItem;

            var novaReserva = new Reserva
            {
                Cliente = cliente,
                Alojamento = alojamentoSelecionado,
                DataCheckIn = dataCheckIn,
                DataCheckOut = dataCheckOut
            };

            try
            {
                ReservaService reservaService = new ReservaService();

                
                reservaService.GuardarReserva(novaReserva);

                
                alojamentoService.AtualizarEstadoAlojamento(alojamentoSelecionado.Id, EstadoAlojamento.Pendente);

                MessageBox.Show("Reserva criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                FormCriarReserva formCriarReserva = new FormCriarReserva(mainForm);
                mainForm.AbrirFormNoPanel(formCriarReserva);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao realizar a reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSelecionarAlojamento_Load(object sender, EventArgs e)
        {

        }
    }
}
