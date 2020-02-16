namespace DEVSIS_ENERGISUR
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rUCDeProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.razónSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correoElectrónicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.númeroDeTeléfonoConvencionalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.númeroDeTélefonoCelularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDelProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.códigoDelProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cédulaCiudadaníaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreDeCiudadaníaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarOrdenDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarOrdenDeCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaDeIncioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.númeroDeOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaDeExpediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaDeEmisiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.botonSalir = new System.Windows.Forms.Button();
            this.cambiarEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proveedoresToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.compToolStripMenuItem,
            this.facturaToolStripMenuItem,
            this.administraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProveedorToolStripMenuItem,
            this.consultarProveedorToolStripMenuItem,
            this.eliminarProveedorToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // ingresarProveedorToolStripMenuItem
            // 
            this.ingresarProveedorToolStripMenuItem.Name = "ingresarProveedorToolStripMenuItem";
            this.ingresarProveedorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ingresarProveedorToolStripMenuItem.Text = "Ingresar proveedor";
            this.ingresarProveedorToolStripMenuItem.Click += new System.EventHandler(this.ingresarProveedorToolStripMenuItem_Click);
            // 
            // consultarProveedorToolStripMenuItem
            // 
            this.consultarProveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rUCDeProveedorToolStripMenuItem,
            this.razónSocialToolStripMenuItem,
            this.correoElectrónicoToolStripMenuItem,
            this.númeroDeTeléfonoConvencionalToolStripMenuItem,
            this.númeroDeTélefonoCelularToolStripMenuItem});
            this.consultarProveedorToolStripMenuItem.Name = "consultarProveedorToolStripMenuItem";
            this.consultarProveedorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.consultarProveedorToolStripMenuItem.Text = "Consultar proveedor";
            // 
            // rUCDeProveedorToolStripMenuItem
            // 
            this.rUCDeProveedorToolStripMenuItem.Name = "rUCDeProveedorToolStripMenuItem";
            this.rUCDeProveedorToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.rUCDeProveedorToolStripMenuItem.Text = "RUC de proveedor";
            this.rUCDeProveedorToolStripMenuItem.Click += new System.EventHandler(this.rUCDeProveedorToolStripMenuItem_Click);
            // 
            // razónSocialToolStripMenuItem
            // 
            this.razónSocialToolStripMenuItem.Name = "razónSocialToolStripMenuItem";
            this.razónSocialToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.razónSocialToolStripMenuItem.Text = "Razón social";
            this.razónSocialToolStripMenuItem.Click += new System.EventHandler(this.razónSocialToolStripMenuItem_Click);
            // 
            // correoElectrónicoToolStripMenuItem
            // 
            this.correoElectrónicoToolStripMenuItem.Name = "correoElectrónicoToolStripMenuItem";
            this.correoElectrónicoToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.correoElectrónicoToolStripMenuItem.Text = "Correo electrónico";
            this.correoElectrónicoToolStripMenuItem.Click += new System.EventHandler(this.correoElectrónicoToolStripMenuItem_Click);
            // 
            // númeroDeTeléfonoConvencionalToolStripMenuItem
            // 
            this.númeroDeTeléfonoConvencionalToolStripMenuItem.Name = "númeroDeTeléfonoConvencionalToolStripMenuItem";
            this.númeroDeTeléfonoConvencionalToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.númeroDeTeléfonoConvencionalToolStripMenuItem.Text = "Número de teléfono convencional";
            this.númeroDeTeléfonoConvencionalToolStripMenuItem.Click += new System.EventHandler(this.númeroDeTeléfonoConvencionalToolStripMenuItem_Click);
            // 
            // númeroDeTélefonoCelularToolStripMenuItem
            // 
            this.númeroDeTélefonoCelularToolStripMenuItem.Name = "númeroDeTélefonoCelularToolStripMenuItem";
            this.númeroDeTélefonoCelularToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
            this.númeroDeTélefonoCelularToolStripMenuItem.Text = "Número de télefono celular";
            this.númeroDeTélefonoCelularToolStripMenuItem.Click += new System.EventHandler(this.númeroDeTélefonoCelularToolStripMenuItem_Click);
            // 
            // eliminarProveedorToolStripMenuItem
            // 
            this.eliminarProveedorToolStripMenuItem.Name = "eliminarProveedorToolStripMenuItem";
            this.eliminarProveedorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.eliminarProveedorToolStripMenuItem.Text = "Eliminar proveedor";
            this.eliminarProveedorToolStripMenuItem.Click += new System.EventHandler(this.eliminarProveedorToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarProductoToolStripMenuItem,
            this.actualizarProductoToolStripMenuItem,
            this.consultarProductoToolStripMenuItem,
            this.eliminarProductoToolStripMenuItem});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // ingresarProductoToolStripMenuItem
            // 
            this.ingresarProductoToolStripMenuItem.Name = "ingresarProductoToolStripMenuItem";
            this.ingresarProductoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.ingresarProductoToolStripMenuItem.Text = "Ingresar producto";
            this.ingresarProductoToolStripMenuItem.Click += new System.EventHandler(this.ingresarProductoToolStripMenuItem_Click);
            // 
            // actualizarProductoToolStripMenuItem
            // 
            this.actualizarProductoToolStripMenuItem.Name = "actualizarProductoToolStripMenuItem";
            this.actualizarProductoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.actualizarProductoToolStripMenuItem.Text = "Actualizar producto";
            this.actualizarProductoToolStripMenuItem.Click += new System.EventHandler(this.actualizarProductoToolStripMenuItem_Click);
            // 
            // consultarProductoToolStripMenuItem
            // 
            this.consultarProductoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreDelProductoToolStripMenuItem,
            this.códigoDelProductoToolStripMenuItem});
            this.consultarProductoToolStripMenuItem.Name = "consultarProductoToolStripMenuItem";
            this.consultarProductoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.consultarProductoToolStripMenuItem.Text = "Consultar producto";
            // 
            // nombreDelProductoToolStripMenuItem
            // 
            this.nombreDelProductoToolStripMenuItem.Name = "nombreDelProductoToolStripMenuItem";
            this.nombreDelProductoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.nombreDelProductoToolStripMenuItem.Text = "Nombre del producto";
            this.nombreDelProductoToolStripMenuItem.Click += new System.EventHandler(this.nombreDelProductoToolStripMenuItem_Click);
            // 
            // códigoDelProductoToolStripMenuItem
            // 
            this.códigoDelProductoToolStripMenuItem.Name = "códigoDelProductoToolStripMenuItem";
            this.códigoDelProductoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.códigoDelProductoToolStripMenuItem.Text = "Código del producto";
            this.códigoDelProductoToolStripMenuItem.Click += new System.EventHandler(this.códigoDelProductoToolStripMenuItem_Click);
            // 
            // eliminarProductoToolStripMenuItem
            // 
            this.eliminarProductoToolStripMenuItem.Name = "eliminarProductoToolStripMenuItem";
            this.eliminarProductoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.eliminarProductoToolStripMenuItem.Text = "Eliminar producto";
            this.eliminarProductoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProductoToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarClienteToolStripMenuItem,
            this.actualizarClienteToolStripMenuItem,
            this.consultarClienteToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // ingresarClienteToolStripMenuItem
            // 
            this.ingresarClienteToolStripMenuItem.Name = "ingresarClienteToolStripMenuItem";
            this.ingresarClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ingresarClienteToolStripMenuItem.Text = "Ingresar cliente";
            this.ingresarClienteToolStripMenuItem.Click += new System.EventHandler(this.ingresarClienteToolStripMenuItem_Click);
            // 
            // actualizarClienteToolStripMenuItem
            // 
            this.actualizarClienteToolStripMenuItem.Name = "actualizarClienteToolStripMenuItem";
            this.actualizarClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.actualizarClienteToolStripMenuItem.Text = "Actualizar cliente";
            this.actualizarClienteToolStripMenuItem.Click += new System.EventHandler(this.actualizarClienteToolStripMenuItem_Click);
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cédulaCiudadaníaToolStripMenuItem,
            this.nombreDeCiudadaníaToolStripMenuItem});
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.consultarClienteToolStripMenuItem.Text = "Consultar cliente";
            // 
            // cédulaCiudadaníaToolStripMenuItem
            // 
            this.cédulaCiudadaníaToolStripMenuItem.Name = "cédulaCiudadaníaToolStripMenuItem";
            this.cédulaCiudadaníaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.cédulaCiudadaníaToolStripMenuItem.Text = "Cédula de ciudadanía";
            this.cédulaCiudadaníaToolStripMenuItem.Click += new System.EventHandler(this.cédulaCiudadaníaToolStripMenuItem_Click);
            // 
            // nombreDeCiudadaníaToolStripMenuItem
            // 
            this.nombreDeCiudadaníaToolStripMenuItem.Name = "nombreDeCiudadaníaToolStripMenuItem";
            this.nombreDeCiudadaníaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.nombreDeCiudadaníaToolStripMenuItem.Text = "Nombre de ciudadanía";
            this.nombreDeCiudadaníaToolStripMenuItem.Click += new System.EventHandler(this.nombreDeCiudadaníaToolStripMenuItem_Click);
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.eliminarClienteToolStripMenuItem.Text = "Eliminar cliente";
            this.eliminarClienteToolStripMenuItem.Click += new System.EventHandler(this.eliminarClienteToolStripMenuItem_Click);
            // 
            // compToolStripMenuItem
            // 
            this.compToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarOrdenDeCompraToolStripMenuItem,
            this.consultarOrdenDeCompraToolStripMenuItem,
            this.cambiarEstadoToolStripMenuItem});
            this.compToolStripMenuItem.Name = "compToolStripMenuItem";
            this.compToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.compToolStripMenuItem.Text = "Orden de Compra";
            // 
            // generarOrdenDeCompraToolStripMenuItem
            // 
            this.generarOrdenDeCompraToolStripMenuItem.Name = "generarOrdenDeCompraToolStripMenuItem";
            this.generarOrdenDeCompraToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.generarOrdenDeCompraToolStripMenuItem.Text = "Generar orden de compra";
            this.generarOrdenDeCompraToolStripMenuItem.Click += new System.EventHandler(this.generarOrdenDeCompraToolStripMenuItem_Click);
            // 
            // consultarOrdenDeCompraToolStripMenuItem
            // 
            this.consultarOrdenDeCompraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechaDeIncioToolStripMenuItem,
            this.númeroDeOrdenToolStripMenuItem,
            this.fechaDeExpediciónToolStripMenuItem});
            this.consultarOrdenDeCompraToolStripMenuItem.Name = "consultarOrdenDeCompraToolStripMenuItem";
            this.consultarOrdenDeCompraToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.consultarOrdenDeCompraToolStripMenuItem.Text = "Consultar orden de compra";
            // 
            // fechaDeIncioToolStripMenuItem
            // 
            this.fechaDeIncioToolStripMenuItem.Name = "fechaDeIncioToolStripMenuItem";
            this.fechaDeIncioToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.fechaDeIncioToolStripMenuItem.Text = "Fecha de incio";
            this.fechaDeIncioToolStripMenuItem.Click += new System.EventHandler(this.fechaDeIncioToolStripMenuItem_Click);
            // 
            // númeroDeOrdenToolStripMenuItem
            // 
            this.númeroDeOrdenToolStripMenuItem.Name = "númeroDeOrdenToolStripMenuItem";
            this.númeroDeOrdenToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.númeroDeOrdenToolStripMenuItem.Text = "Número de orden";
            this.númeroDeOrdenToolStripMenuItem.Click += new System.EventHandler(this.númeroDeOrdenToolStripMenuItem_Click);
            // 
            // fechaDeExpediciónToolStripMenuItem
            // 
            this.fechaDeExpediciónToolStripMenuItem.Name = "fechaDeExpediciónToolStripMenuItem";
            this.fechaDeExpediciónToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.fechaDeExpediciónToolStripMenuItem.Text = "Fecha de expedición";
            this.fechaDeExpediciónToolStripMenuItem.Click += new System.EventHandler(this.fechaDeExpediciónToolStripMenuItem_Click);
            // 
            // facturaToolStripMenuItem
            // 
            this.facturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarFacturaToolStripMenuItem,
            this.consultarFacturaToolStripMenuItem});
            this.facturaToolStripMenuItem.Name = "facturaToolStripMenuItem";
            this.facturaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.facturaToolStripMenuItem.Text = "Factura";
            // 
            // generarFacturaToolStripMenuItem
            // 
            this.generarFacturaToolStripMenuItem.Name = "generarFacturaToolStripMenuItem";
            this.generarFacturaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.generarFacturaToolStripMenuItem.Text = "Generar factura";
            this.generarFacturaToolStripMenuItem.Click += new System.EventHandler(this.generarFacturaToolStripMenuItem_Click);
            // 
            // consultarFacturaToolStripMenuItem
            // 
            this.consultarFacturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechaDeEmisiónToolStripMenuItem});
            this.consultarFacturaToolStripMenuItem.Name = "consultarFacturaToolStripMenuItem";
            this.consultarFacturaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.consultarFacturaToolStripMenuItem.Text = "Consultar factura";
            // 
            // fechaDeEmisiónToolStripMenuItem
            // 
            this.fechaDeEmisiónToolStripMenuItem.Name = "fechaDeEmisiónToolStripMenuItem";
            this.fechaDeEmisiónToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.fechaDeEmisiónToolStripMenuItem.Text = "Fecha de emisión";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuariosToolStripMenuItem,
            this.eliminarUsuariosToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // crearUsuariosToolStripMenuItem
            // 
            this.crearUsuariosToolStripMenuItem.Name = "crearUsuariosToolStripMenuItem";
            this.crearUsuariosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.crearUsuariosToolStripMenuItem.Text = "Crear usuarios";
            this.crearUsuariosToolStripMenuItem.Click += new System.EventHandler(this.crearUsuariosToolStripMenuItem_Click);
            // 
            // eliminarUsuariosToolStripMenuItem
            // 
            this.eliminarUsuariosToolStripMenuItem.Name = "eliminarUsuariosToolStripMenuItem";
            this.eliminarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.eliminarUsuariosToolStripMenuItem.Text = "Eliminar usuarios";
            this.eliminarUsuariosToolStripMenuItem.Click += new System.EventHandler(this.eliminarUsuariosToolStripMenuItem_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(21, 155);
            this.botonSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(130, 19);
            this.botonSalir.TabIndex = 2;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // cambiarEstadoToolStripMenuItem
            // 
            this.cambiarEstadoToolStripMenuItem.Name = "cambiarEstadoToolStripMenuItem";
            this.cambiarEstadoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.cambiarEstadoToolStripMenuItem.Text = "Cambiar Estado";
            this.cambiarEstadoToolStripMenuItem.Click += new System.EventHandler(this.cambiarEstadoToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 187);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarOrdenDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDelProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem códigoDelProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cédulaCiudadaníaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreDeCiudadaníaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rUCDeProveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaDeEmisiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarOrdenDeCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaDeIncioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem númeroDeTeléfonoConvencionalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correoElectrónicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem razónSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem númeroDeOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaDeExpediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem númeroDeTélefonoCelularToolStripMenuItem;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.ToolStripMenuItem cambiarEstadoToolStripMenuItem;
    }
}