﻿using System;
using System.Windows.Forms;
using Financiera.Entidades.Compuesto;

namespace Financiera.Formularios
{
    public partial class TotalPeriodos_B : UserControl
    {
        public TotalPeriodos_B()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal monto = txtMonto.Value;
            decimal capital = txtCapital.Value;
            decimal tasaEfectiva = txtTasaEfectiva.Value;
            txtResultado.Value = Interes.CalcularTotalPeriodos(monto, capital, tasaEfectiva);
            panelResultado.Visible = true;
        }
    }
}
