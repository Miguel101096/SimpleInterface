﻿using System;
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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void crearUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CrearUsuario().Show();
        }

        private void eliminarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarUsuario().Show();
        }

        private void ingresarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IngresarProducto().Show();
        }

        private void actualizarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActualizarProducto().Show();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarProducto().Show();
        }

        private void ingresarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IngresarCliente().Show();
        }

        private void actualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ActualizarCliente().Show();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarCliente().Show();
        }

        private void ingresarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new IngresarProveedor().Show();
            this.Visible = false;
        }

        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EliminarProveedor().Show();
        }

        private void nombreDelProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarNombreProducto().Show();
        }

        private void códigoDelProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarCodigoProducto().Show();
        }

        private void rUCDeProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarRucProveedor().Show();
        }

        private void cédulaCiudadaníaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarCedulaCliente().Show();
        }

        private void nombreDeCiudadaníaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarNombreCliente().Show();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GenerarFactura().Show();
        }

        private void generarOrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GenerarOrdenCompra().Show();
        }

        private void númeroDeTeléfonoConvencionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarTelefonoConvProveedor().Show();
        }

        private void razónSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarRazonSocialProveedor().Show();
        }

        private void correoElectrónicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarCorreoProveedor().Show();
        }

        private void fechaDeIncioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarFechaFinOrdenCompra().Show();
        }

        private void númeroDeOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarNumeroOrdenCompra().Show();
        }

        private void fechaDeExpediciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarFechaInicioOrdenCompra().Show();
        }

        private void númeroDeTélefonoCelularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ConsultarTelefonoCelularProveedor().Show();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
