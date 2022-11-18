﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Dominio;

namespace Presentacionn
{
    public partial class frmAltaEspacio : Form
    {
        public frmAltaEspacio()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtNombre.Text.Length < 16 && mtxtNumero.Text != "")
            {

                int token = 1;
            eEspacio unE = new eEspacio();
            unE.nombreEspacio = txtNombre.Text;
            unE.numeroEspacio = Convert.ToInt32(mtxtNumero.Text);
            dEspacio d = new dEspacio();
            //int token = d.altaEspacio(unE);
            if (token == 0)
            {
                MessageBox.Show("Se agrego el espacio");
            }else { MessageBox.Show("No se agrego el espacio"); }

            }else { MessageBox.Show("Hay errores con los datos ingresados"); }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}