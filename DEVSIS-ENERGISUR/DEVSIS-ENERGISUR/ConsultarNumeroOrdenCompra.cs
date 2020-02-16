﻿using DEVSIS_ENERGISUR.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEVSIS_ENERGISUR
{
    public partial class ConsultarNumeroOrdenCompra : Form
    {
        private consultarordencompra coc = new consultarordencompra();
        public ConsultarNumeroOrdenCompra()
        {
            InitializeComponent();
        }

        private void botonRegresar_Click(object sender, EventArgs e)
        {
            new MenuPrincipal().Show();
            this.Visible = false;
        }
        public void cargarTabla()
        {
            try
            {
                this.dataGridView1.DataSource = this.coc.consultarproductosdetalle(text_Numero_orden.Text.ToString());               
            }
            catch (Exception error)
            {
                MessageBox.Show("La orden de compra no se encuentra registrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void llenardatos()
        {
            try
            {
                DataTable DT = this.coc.consultardatosorden(text_Numero_orden.Text.ToString());                   
                this.textBoxNombreProveedor.Text = DT.Rows[0].ItemArray[0].ToString();
                this.textBoxestado.Text = DT.Rows[0].ItemArray[1].ToString();
                this.textBoxfecha.Text = DT.Rows[0].ItemArray[2].ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("La orden de compra no se encuentra registrada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void botonConsultar_Click(object sender, EventArgs e)
        {
            llenardatos();
            cargarTabla();
        }
    }
}

