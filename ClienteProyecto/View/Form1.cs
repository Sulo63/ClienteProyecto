﻿using System;
using System.Windows.Forms;
using ClienteProyecto.View;

namespace ClienteProyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new AdicionarPaqueteForm().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la ventana de adicionar: {ex.Message}");
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new EliminarPaqueteForm().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la ventana de eliminar: {ex.Message}");
            }
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new ListarPaquetesForm().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la ventana de listar: {ex.Message}");
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new BuscarPaqueteForm().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la ventana de buscar: {ex.Message}");
            }
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new ActualizarPaqueteForm().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la ventana de actualizar: {ex.Message}");
            }
        }

        // Asegúrate de que tienes un formulario AcercaDe o elimina este método si no lo tienes
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new AcercaDe().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la ventana de 'Acerca de': {ex.Message}");
            }
        }
    }
}