﻿using FuncoesDLL;
using GestaoAlojamentoDLL;
using Newtonsoft.Json;
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
    public partial class FormEliminarReserva : Form
    {
        private FormPrincipal mainForm;
        private ReservaService reservaService;
        private List<Reserva> reservas;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainForm"></param>
        public FormEliminarReserva(FormPrincipal mainForm)
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
            try
            {
                reservas = reservaService.CarregarReservas();

                if (!reservas.Any())
                {
                    MessageBox.Show("Não há reservas disponíveis para eliminar.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboBoxReservas.Enabled = false;
                    buttonEliminar.Enabled = false;
                    return;
                }

                comboBoxReservas.DataSource = null;
                comboBoxReservas.DataSource = reservas;
                comboBoxReservas.DisplayMember = "DescricaoCompleta"; // Propriedade de exibição personalizada
                comboBoxReservas.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar reservas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormEliminarReserva_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxReservas.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, selecione uma reserva para eliminar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var reservaSelecionada = (Reserva)comboBoxReservas.SelectedItem;

                var confirmacao = MessageBox.Show("Tem certeza de que deseja eliminar a reserva selecionada?",
                                                  "Confirmação",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    reservaService.EliminarReserva(reservaSelecionada.Id);

                    MessageBox.Show("Reserva eliminada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregarReservas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao eliminar a reserva: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVoltar_Click(object sender, EventArgs e)
        {
            FormMenuReserva formMenuReserva = new FormMenuReserva(mainForm);
            mainForm.AbrirFormNoPanel(formMenuReserva);
        }
    }
}
