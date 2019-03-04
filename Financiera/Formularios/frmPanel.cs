﻿using System;
using System.Windows.Forms;

namespace Financiera
{
    public partial class frmPanel : Form
    {
        public frmPanel()
        {
            InitializeComponent();
        }
       
        private void BtnInteresSimple_Click(object sender, EventArgs e)
        {
            var InteresSimple = new Formularios.Simple.frmInteres.Form();
            InteresSimple.Show();
        }

        private void BtnDescuentos_Click(object sender, EventArgs e)
        {
            var Descuento = new Formularios.Simple.frmDescuentoBancario.Form();
            Descuento.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Esta Seguro que desea salir ?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void btnMontoSimple_Click(object sender, EventArgs e)
        {
            var montosimple = new Formularios.Simple.frmMontoSimple.fromMontoSimple();
            montosimple.Show();
        }

        private void btnInteresCompuesto_Click(object sender, EventArgs e)
        {
            var interesCompuesto = new Formularios.Simple.frmInteres.Form();
            interesCompuesto.Show();
        }
    }
}
