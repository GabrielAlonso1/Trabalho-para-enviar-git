﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtDataNascimento.Text = "";
            txtTelefone.Text = "";
            rdoFeminino.Text = "";
            rdoMasculino.Text = "";
            rdoCarro.Text = "";
            rdoMoto.Text = "";
            cmbEstado.SelectedIndex = -1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String nome = txtNome.Text;
            String sobrenome = txtSobrenome.Text;
            String telefone = txtTelefone.Text;
            String DataNascimento = txtDataNascimento.Text;
            String Masculino = rdoMasculino.Text;
            String Feminino = rdoFeminino.Text;
            String Carro = rdoCarro.Text;
            String Moto = rdoMoto.Text;
            String Estado = cmbEstado.GetItemText(cmbEstado.SelectedItem);
        }
    }
}
