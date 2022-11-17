﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Entidades;

namespace Presentacionn
{
    public partial class frmListadoPrestamo : Form
    {
        public frmListadoPrestamo()
        {
            InitializeComponent();
        }

        string tuHermana;
        string prioridad;

        private void cbxListadosPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                if (cbxTipo.SelectedIndex == 0)
                {

                    dPrestamo unDP = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDP.listarPrestamo();

                    cbxFecha.Visible = true;
                    cbxFechaEquipo.Visible = false;
                    cbxFechaEspacio.Visible = false;
                    cbxFechaEspontaneo.Visible = false;

                    cbxEstado.Visible = true;
                    cbxEstadoEquipo.Visible = false;
                    cbxEstadoEspacio.Visible = false;
                    cbxEstadoEspontaneo.Visible = false;

                    cbxPrioridad.Visible = true;
                    cbxPrioridadEquipo.Visible = false;
                    cbxPrioridadEspacio.Visible = false;
                    cbxPrioridadEspontaneo.Visible = false;

                }

                if (cbxTipo.SelectedIndex == 1)
                {

                    dPrestamoEquipo unDP = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unDP.listarPrestamoDeEquipo();

                    cbxFecha.Visible = false;
                    cbxFechaEquipo.Visible = true;
                    cbxFechaEspacio.Visible = false;
                    cbxFechaEspontaneo.Visible = false;

                    cbxEstado.Visible = false;
                    cbxEstadoEquipo.Visible = true;
                    cbxEstadoEspacio.Visible = false;
                    cbxEstadoEspontaneo.Visible = false;

                    cbxPrioridad.Visible = false;
                    cbxPrioridadEquipo.Visible = true;
                    cbxPrioridadEspacio.Visible = false;
                    cbxPrioridadEspontaneo.Visible = false;

                }

                if (cbxTipo.SelectedIndex == 3)
                {

                    dPrestamoEspacio unDP = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDP.listarPrestamoDeEspacio();

                    cbxFecha.Visible = false;
                    cbxFechaEquipo.Visible = false;
                    cbxFechaEspacio.Visible = true;
                    cbxFechaEspontaneo.Visible = false;

                    cbxEstado.Visible = false;
                    cbxEstadoEquipo.Visible = false;
                    cbxEstadoEspacio.Visible = true;
                    cbxEstadoEspontaneo.Visible = false;

                    cbxPrioridad.Visible = false;
                    cbxPrioridadEquipo.Visible = false;
                    cbxPrioridadEspacio.Visible = true;
                    cbxPrioridadEspontaneo.Visible = false;

                }

                if (cbxTipo.SelectedIndex == 2)
                {

                    dPrestamoExpontaneo unDP = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDP.listarPrestamoEspontaneo();

                    cbxFecha.Visible = false;
                    cbxFechaEquipo.Visible = false;
                    cbxFechaEspacio.Visible = false;
                    cbxFechaEspontaneo.Visible = true;

                    cbxEstado.Visible = false;
                    cbxEstadoEquipo.Visible = false;
                    cbxEstadoEspacio.Visible = false;
                    cbxEstadoEspontaneo.Visible = true;

                    cbxPrioridad.Visible = false;
                    cbxPrioridadEquipo.Visible = false;
                    cbxPrioridadEspacio.Visible = false;
                    cbxPrioridadEspontaneo.Visible = true;

                }
            } catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
            }
            

        private void frmListadoPrestamo_Load(object sender, EventArgs e)
        {
            dPrestamo unDP = new dPrestamo();
            dgvListadoEquipo.DataSource = unDP.listarPrestamo();

            cbxFecha.Visible = true;
            cbxFechaEquipo.Visible = false;
            cbxFechaEspacio.Visible = false;
            cbxFechaEspontaneo.Visible = false;

            cbxEstado.Visible = true;
            cbxEstadoEquipo.Visible = false;
            cbxEstadoEspacio.Visible = false;
            cbxEstadoEspontaneo.Visible = false;

            cbxPrioridad.Visible = true;
            cbxPrioridadEquipo.Visible = false;
            cbxPrioridadEspacio.Visible = false;
            cbxPrioridadEspontaneo.Visible = false;

        }

        private void cbxFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxFecha.Text == "De mas antiguo a mas reciente")
                {

                    dPrestamo unDPF = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaAR();


                    /*Armado Levantado Cancelado Devuelto En progreso*/
                    if (cbxEstado.Text == "Armado")
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unDPFE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstado.Text == "Levantado")
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unDPFE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstado.Text == "Cancelado")
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unDPFE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstado.Text == "Devuelto")
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unDPFE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstado.Text == "En Progreso")
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unDPFE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                }

                if (cbxFecha.Text == "De mas reciente a mas antiguo")
                {

                    dPrestamo unDPF = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaRA();

                    if (cbxEstado.Text == "Armado")
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unDPFE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstado.Text == "Levantado")
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unDPFE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstado.Text == "Cancelado")
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unDPFE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstado.Text == "Devuelto")
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unDPFE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstado.Text == "En Progreso")
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unDPFE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                }

            }
            catch (Exception error)
            { 

               MessageBox.Show(error.Message);

            }
        }

        private void cbxEstadoEspacio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cbxEstadoEspacio.SelectedIndex == 0)
                {
                    tuHermana = cbxEstadoEspacio.Text;
                    dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstadoEspacio.SelectedIndex == 1)
                {
                    tuHermana = cbxEstadoEspacio.Text;
                    dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstadoEspacio.SelectedIndex == 2)
                {
                    tuHermana = cbxEstadoEspacio.Text;
                    dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstadoEspacio.SelectedIndex == 3)
                {
                    tuHermana = cbxEstadoEspacio.Text;
                    dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstadoEspacio.SelectedIndex == 4)
                {
                    tuHermana = cbxEstadoEspacio.Text;
                    dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxFechaEspacio.Text == "De mas antiguo a mas reciente")
                {

                    dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                }

                if (cbxFechaEspacio.Text == "De mas reciente a mas antiguo")
                {

                    dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                }

                if (cbxPrioridadEspacio.Text == "De menor a mayor")
                {

                    prioridad = "ASC";
                    dPrestamoEspacio unDPP = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridadE(tuHermana, prioridad);
                }
                if (cbxPrioridadEspacio.Text == "De mayor a menor")
                {

                    prioridad = "DESC";
                    dPrestamoEspacio unDPP = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                }

            }
           catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
        }

        private void cbxEstadoEspontaneo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                if (cbxEstadoEspontaneo.SelectedIndex == 0)
                {
                    tuHermana = cbxEstadoEspontaneo.Text;
                    dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstadoEspontaneo.SelectedIndex == 1)
                {
                    tuHermana = cbxEstadoEspontaneo.Text;
                    dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstadoEspontaneo.SelectedIndex == 2)
                {
                    tuHermana = cbxEstadoEspontaneo.Text;
                    dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstadoEspontaneo.SelectedIndex == 3)
                {
                    tuHermana = cbxEstadoEspontaneo.Text;
                    dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstadoEspontaneo.SelectedIndex == 4)
                {
                    tuHermana = cbxEstadoEspontaneo.Text;
                    dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxFechaEspontaneo.Text == "De mas antiguo a mas reciente")
                {

                    dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                }

                if (cbxFechaEspontaneo.Text == "De mas reciente a mas antiguo")
                {

                    dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                }

                if (cbxPrioridadEspontaneo.Text == "De menor a mayor")
                {

                    prioridad = "ASC";
                    dPrestamoExpontaneo unDPP = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridadE(tuHermana, prioridad);
                }
                if (cbxPrioridadEspontaneo.Text == "De mayor a menor")
                {

                    prioridad = "DESC";
                    dPrestamoExpontaneo unDPP = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
        }

        private void cbxEstadoEquipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                if (cbxEstadoEquipo.SelectedIndex == 0)
                {
                    tuHermana = cbxEstadoEquipo.Text;
                    dPrestamoEquipo unPEE = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstadoEquipo.SelectedIndex == 1)
                {
                    tuHermana = cbxEstadoEquipo.Text;
                    dPrestamoEquipo unPEE = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstadoEquipo.SelectedIndex == 2)
                {
                    tuHermana = cbxEstadoEquipo.Text;
                    dPrestamoEquipo unPEE = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstadoEquipo.SelectedIndex == 3)
                {
                    tuHermana = cbxEstadoEquipo.Text;
                    dPrestamoEquipo unPEE = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstadoEquipo.SelectedIndex == 4)
                {
                    tuHermana = cbxEstadoEquipo.Text;
                    dPrestamoEquipo unPEE = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxFechaEquipo.Text == "De mas antiguo a mas reciente")
                {

                    dPrestamoEquipo unDPFE = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                }

                if (cbxFechaEquipo.Text == "De mas reciente a mas antiguo")
                {

                    dPrestamoEquipo unDPFE = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                }

                if (cbxPrioridadEquipo.Text == "De menor a mayor")
                {

                    prioridad = "ASC";
                    dPrestamoEquipo unDPP = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridadE(tuHermana, prioridad);
                }
                if (cbxPrioridadEquipo.Text == "De mayor a menor")
                {

                    prioridad = "DESC";
                    dPrestamoEquipo unDPP = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
        }

        private void cbxEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {

                if (cbxEstado.SelectedIndex == 0)
                {

                    tuHermana = cbxEstado.Text;
                    dPrestamo unPEE = new dPrestamo();
                    dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstado.SelectedIndex == 1)
                {
                    tuHermana = cbxEstado.Text;
                    dPrestamo unPEE = new dPrestamo();
                    dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstado.SelectedIndex == 2)
                {
                    tuHermana = cbxEstado.Text;
                    dPrestamo unPEE = new dPrestamo();
                    dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstado.SelectedIndex == 3)
                {
                    tuHermana = cbxEstado.Text;
                    dPrestamo unPEE = new dPrestamo();
                    dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxEstado.SelectedIndex == 4)
                {
                    tuHermana = cbxEstado.Text;
                    dPrestamo unPEE = new dPrestamo();
                    dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorEstado(tuHermana);

                }

                if (cbxFecha.Text == "De mas antiguo a mas reciente")
                {

                    dPrestamo unDPFE = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                }

                if (cbxFecha.Text == "De mas reciente a mas antiguo")
                {

                    dPrestamo unDPFE = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                }

                if (cbxPrioridad.Text == "De menor a mayor")
                {

                    prioridad = "ASC";
                    dPrestamo unDPP = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridadE(tuHermana, prioridad);
                }
                if (cbxPrioridad.Text == "De mayor a menor")
                {

                    prioridad = "DESC";
                    dPrestamo unDPP = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                }

            }
            catch (Exception error)
            {

               MessageBox.Show(error.Message);

            }
        }

        private void cbxFechaEquipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cbxFechaEquipo.Text == "De mas antiguo a mas reciente")
                {

                    dPrestamoEquipo unDPF = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaAR();

                    if (cbxEstadoEquipo.Text == "Armado")
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unDPFE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstadoEquipo.Text == "Levantado")
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unDPFE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstadoEquipo.Text == "Cancelado")
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unDPFE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstadoEquipo.Text == "Devuelto")
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unDPFE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstadoEquipo.Text == "En Progreso")
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unDPFE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }
                }

                if (cbxFechaEquipo.Text == "De mas reciente a mas antiguo")
                {

                    dPrestamoEquipo unDPF = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaRA();

                    if (cbxEstadoEquipo.Text == "Armado")
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unDPFE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstadoEquipo.Text == "Levantado")
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unDPFE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstadoEquipo.Text == "Cancelado")
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unDPFE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstadoEquipo.Text == "Devuelto")
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unDPFE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstadoEquipo.Text == "En Progreso")
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unDPFE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
        }

        private void cbxFechaEspontaneo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cbxFechaEspontaneo.Text == "De mas antiguo a mas reciente")
                {

                    dPrestamoExpontaneo unDPF = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaAR();

                    if (cbxEstadoEspontaneo.Text == "Armado")
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstadoEspontaneo.Text == "Levantado")
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstadoEspontaneo.Text == "Cancelado")
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstadoEspontaneo.Text == "Devuelto")
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstadoEspontaneo.Text == "En Progreso")
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                }

                if (cbxFechaEspontaneo.Text == "De mas reciente a mas antiguo")
                {

                    dPrestamoExpontaneo unDPF = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaRA();


                    if (cbxEstadoEspontaneo.Text == "Armado")
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstadoEspontaneo.Text == "Levantado")
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstadoEspontaneo.Text == "Cancelado")
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstadoEspontaneo.Text == "Devuelto")
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstadoEspontaneo.Text == "En Progreso")
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unDPFE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }
                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
        }

        private void cbxFechaEspacio_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cbxFechaEspacio.Text == "De mas antiguo a mas reciente")
                {

                    dPrestamoEspacio unDPF = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaAR();

                    if (cbxEstadoEspacio.Text == "Armado")
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstadoEspacio.Text == "Levantado")
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstadoEspacio.Text == "Cancelado")
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstadoEspacio.Text == "Devuelto")
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                    if (cbxEstadoEspacio.Text == "En Progreso")
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaARE(tuHermana);

                    }

                }

                if (cbxFechaEspacio.Text == "De mas reciente a mas antiguo")
                {

                    dPrestamoEspacio unDPF = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDPF.listarPrestamoPorFechaRA();


                    if (cbxEstadoEspacio.Text == "Armado")
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstadoEspacio.Text == "Levantado")
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstadoEspacio.Text == "Cancelado")
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstadoEspacio.Text == "Devuelto")
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }

                    if (cbxEstadoEspacio.Text == "En Progreso")
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unDPFE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unDPFE.listarPrestamoPorFechaRAE(tuHermana);

                    }
                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
        }

        private void cbxPrioridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cbxPrioridad.Text == "De menor a mayor")
                {

                    prioridad = "ASC";
                    dPrestamo unDPP = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridad(prioridad);

                    if (cbxEstado.SelectedIndex == 0)
                    {

                        tuHermana = cbxEstado.Text;
                        dPrestamo unPEE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstado.SelectedIndex == 1)
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unPEE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstado.SelectedIndex == 2)
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unPEE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstado.SelectedIndex == 3)
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unPEE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstado.SelectedIndex == 4)
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unPEE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }
                }

                if (cbxPrioridad.Text == "De mayor a menor")
                {

                    prioridad = "DESC";
                    dPrestamo unDPP = new dPrestamo();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridad(prioridad);

                    if (cbxEstado.SelectedIndex == 0)
                    {

                        tuHermana = cbxEstado.Text;
                        dPrestamo unPEE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstado.SelectedIndex == 1)
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unPEE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstado.SelectedIndex == 2)
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unPEE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstado.SelectedIndex == 3)
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unPEE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstado.SelectedIndex == 4)
                    {
                        tuHermana = cbxEstado.Text;
                        dPrestamo unPEE = new dPrestamo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }
                }

            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
        }

        private void cbxPrioridadEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cbxPrioridadEquipo.Text == "De menor a mayor")
                {

                    prioridad = "ASC";
                    dPrestamoEquipo unDPP = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridad(prioridad);

                    if (cbxEstadoEquipo.SelectedIndex == 0)
                    {

                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unPEE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEquipo.SelectedIndex == 1)
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unPEE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEquipo.SelectedIndex == 2)
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unPEE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEquipo.SelectedIndex == 3)
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unPEE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEquipo.SelectedIndex == 4)
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unPEE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }
                }

                if (cbxPrioridadEquipo.Text == "De mayor a menor")
                {

                    prioridad = "DESC";
                    dPrestamoEquipo unDPP = new dPrestamoEquipo();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridad(prioridad);

                    if (cbxEstadoEquipo.SelectedIndex == 0)
                    {

                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unPEE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEquipo.SelectedIndex == 1)
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unPEE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEquipo.SelectedIndex == 2)
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unPEE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEquipo.SelectedIndex == 3)
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unPEE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEquipo.SelectedIndex == 4)
                    {
                        tuHermana = cbxEstadoEquipo.Text;
                        dPrestamoEquipo unPEE = new dPrestamoEquipo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
        }

        private void cbxPrioridadEspontaneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (cbxPrioridadEspontaneo.Text == "De menor a mayor")
                {

                    prioridad = "ASC";
                    dPrestamoExpontaneo unDPP = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridad(prioridad);

                    if (cbxEstadoEspontaneo.SelectedIndex == 0)
                    {

                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unPEE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspontaneo.SelectedIndex == 1)
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unPEE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspontaneo.SelectedIndex == 2)
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unPEE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspontaneo.SelectedIndex == 3)
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unPEE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspontaneo.SelectedIndex == 4)
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unPEE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }
                }

                if (cbxPrioridadEspontaneo.Text == "De mayor a menor")
                {

                    prioridad = "DESC";
                    dPrestamoExpontaneo unDPP = new dPrestamoExpontaneo();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridad(prioridad);

                    if (cbxEstadoEspontaneo.SelectedIndex == 0)
                    {

                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unPEE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspontaneo.SelectedIndex == 1)
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unPEE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspontaneo.SelectedIndex == 2)
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unPEE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspontaneo.SelectedIndex == 3)
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unPEE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspontaneo.SelectedIndex == 4)
                    {
                        tuHermana = cbxEstadoEspontaneo.Text;
                        dPrestamoExpontaneo unPEE = new dPrestamoExpontaneo();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }
        }

        private void cbxPrioridadEspacio_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

                if (cbxPrioridadEspacio.Text == "De menor a mayor")
                {

                    prioridad = "ASC";
                    dPrestamoEspacio unDPP = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridad(prioridad);

                    if (cbxEstadoEspacio.SelectedIndex == 0)
                    {

                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unPEE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspacio.SelectedIndex == 1)
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unPEE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspacio.SelectedIndex == 2)
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unPEE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspacio.SelectedIndex == 3)
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unPEE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspacio.SelectedIndex == 4)
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unPEE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }
                }

                if (cbxPrioridadEspacio.Text == "De mayor a menor")
                {

                    prioridad = "DESC";
                    dPrestamoEspacio unDPP = new dPrestamoEspacio();
                    dgvListadoEquipo.DataSource = unDPP.listarPrestamoPorPrioridad(prioridad);

                    if (cbxEstadoEspacio.SelectedIndex == 0)
                    {

                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unPEE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspacio.SelectedIndex == 1)
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unPEE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspacio.SelectedIndex == 2)
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unPEE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspacio.SelectedIndex == 3)
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unPEE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }

                    if (cbxEstadoEspacio.SelectedIndex == 4)
                    {
                        tuHermana = cbxEstadoEspacio.Text;
                        dPrestamoEspacio unPEE = new dPrestamoEspacio();
                        dgvListadoEquipo.DataSource = unPEE.listarPrestamoPorPrioridadE(tuHermana, prioridad);

                    }
                }
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Message);

            }

        }
    }
}
        
