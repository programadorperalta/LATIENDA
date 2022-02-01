
namespace LATIENDA.Presentacion.Vistas
{
    partial class AgregarStockVista
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.existenciaLabel = new System.Windows.Forms.Label();
            this.txtPreciodeVenta = new System.Windows.Forms.TextBox();
            this.bsProducto = new System.Windows.Forms.BindingSource(this.components);
            this.precioFinalLabel = new System.Windows.Forms.Label();
            this.gananciaLabel = new System.Windows.Forms.Label();
            this.precioIVALabel = new System.Windows.Forms.Label();
            this.ivaLabel = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.txtCostoIva = new System.Windows.Forms.TextBox();
            this.txtNetoGravado = new System.Windows.Forms.TextBox();
            this.txtMargendeganancia = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.codigoText = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTalle = new System.Windows.Forms.ComboBox();
            this.bsStock = new System.Windows.Forms.BindingSource(this.components);
            this.bsTalle = new System.Windows.Forms.BindingSource(this.components);
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.bsColor = new System.Windows.Forms.BindingSource(this.components);
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTipodeTalle = new System.Windows.Forms.TextBox();
            this.lbTipodeTalle = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsColor)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del Producto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.Info;
            this.txtCodigo.Location = new System.Drawing.Point(344, 45);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(200, 20);
            this.txtCodigo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(370, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "AGREGAR STOCK";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "%";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "%";
            // 
            // existenciaLabel
            // 
            this.existenciaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.existenciaLabel.AutoSize = true;
            this.existenciaLabel.Location = new System.Drawing.Point(8, 362);
            this.existenciaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.existenciaLabel.Name = "existenciaLabel";
            this.existenciaLabel.Size = new System.Drawing.Size(86, 13);
            this.existenciaLabel.TabIndex = 34;
            this.existenciaLabel.Text = "Precio de Venta:";
            // 
            // txtPreciodeVenta
            // 
            this.txtPreciodeVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPreciodeVenta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "PreciodeVenta", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtPreciodeVenta.Location = new System.Drawing.Point(122, 355);
            this.txtPreciodeVenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtPreciodeVenta.Name = "txtPreciodeVenta";
            this.txtPreciodeVenta.ReadOnly = true;
            this.txtPreciodeVenta.Size = new System.Drawing.Size(259, 20);
            this.txtPreciodeVenta.TabIndex = 33;
            // 
            // bsProducto
            // 
            this.bsProducto.DataSource = typeof(LATIENDA.Dominio.Entidades.Producto);
            // 
            // precioFinalLabel
            // 
            this.precioFinalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precioFinalLabel.AutoSize = true;
            this.precioFinalLabel.Location = new System.Drawing.Point(8, 338);
            this.precioFinalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.precioFinalLabel.Name = "precioFinalLabel";
            this.precioFinalLabel.Size = new System.Drawing.Size(78, 13);
            this.precioFinalLabel.TabIndex = 32;
            this.precioFinalLabel.Text = "Costo con IVA:";
            // 
            // gananciaLabel
            // 
            this.gananciaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gananciaLabel.AutoSize = true;
            this.gananciaLabel.Location = new System.Drawing.Point(8, 316);
            this.gananciaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gananciaLabel.Name = "gananciaLabel";
            this.gananciaLabel.Size = new System.Drawing.Size(77, 13);
            this.gananciaLabel.TabIndex = 31;
            this.gananciaLabel.Text = "Neto Gravado:";
            // 
            // precioIVALabel
            // 
            this.precioIVALabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precioIVALabel.AutoSize = true;
            this.precioIVALabel.Location = new System.Drawing.Point(8, 293);
            this.precioIVALabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.precioIVALabel.Name = "precioIVALabel";
            this.precioIVALabel.Size = new System.Drawing.Size(110, 13);
            this.precioIVALabel.TabIndex = 30;
            this.precioIVALabel.Text = "Margen de Ganancia:";
            // 
            // ivaLabel
            // 
            this.ivaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ivaLabel.AutoSize = true;
            this.ivaLabel.Location = new System.Drawing.Point(8, 266);
            this.ivaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ivaLabel.Name = "ivaLabel";
            this.ivaLabel.Size = new System.Drawing.Size(96, 13);
            this.ivaLabel.TabIndex = 29;
            this.ivaLabel.Text = "Porcentaje de IVA:";
            // 
            // baseLabel
            // 
            this.baseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(8, 242);
            this.baseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(37, 13);
            this.baseLabel.TabIndex = 28;
            this.baseLabel.Text = "Costo:";
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(8, 217);
            this.descripcionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(66, 13);
            this.descripcionLabel.TabIndex = 27;
            this.descripcionLabel.Text = "Descripcion:";
            // 
            // txtCostoIva
            // 
            this.txtCostoIva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCostoIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "CostoConIva", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtCostoIva.Location = new System.Drawing.Point(122, 331);
            this.txtCostoIva.Margin = new System.Windows.Forms.Padding(2);
            this.txtCostoIva.Name = "txtCostoIva";
            this.txtCostoIva.ReadOnly = true;
            this.txtCostoIva.Size = new System.Drawing.Size(259, 20);
            this.txtCostoIva.TabIndex = 26;
            // 
            // txtNetoGravado
            // 
            this.txtNetoGravado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNetoGravado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "NetoGravado", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtNetoGravado.Location = new System.Drawing.Point(122, 309);
            this.txtNetoGravado.Margin = new System.Windows.Forms.Padding(2);
            this.txtNetoGravado.Name = "txtNetoGravado";
            this.txtNetoGravado.ReadOnly = true;
            this.txtNetoGravado.Size = new System.Drawing.Size(259, 20);
            this.txtNetoGravado.TabIndex = 25;
            // 
            // txtMargendeganancia
            // 
            this.txtMargendeganancia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMargendeganancia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "MargendeGanancia", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtMargendeganancia.Location = new System.Drawing.Point(122, 286);
            this.txtMargendeganancia.Margin = new System.Windows.Forms.Padding(2);
            this.txtMargendeganancia.Name = "txtMargendeganancia";
            this.txtMargendeganancia.ReadOnly = true;
            this.txtMargendeganancia.Size = new System.Drawing.Size(259, 20);
            this.txtMargendeganancia.TabIndex = 24;
            // 
            // txtIva
            // 
            this.txtIva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "PorcentajeIva", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtIva.Location = new System.Drawing.Point(122, 263);
            this.txtIva.Margin = new System.Windows.Forms.Padding(2);
            this.txtIva.Name = "txtIva";
            this.txtIva.ReadOnly = true;
            this.txtIva.Size = new System.Drawing.Size(259, 20);
            this.txtIva.TabIndex = 23;
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCosto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Costo", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtCosto.Location = new System.Drawing.Point(122, 239);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(2);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.ReadOnly = true;
            this.txtCosto.Size = new System.Drawing.Size(259, 20);
            this.txtCosto.TabIndex = 22;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Descripcion", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtDescripcion.Location = new System.Drawing.Point(122, 217);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(259, 20);
            this.txtDescripcion.TabIndex = 21;
            // 
            // codigoText
            // 
            this.codigoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Codigo", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.codigoText.Location = new System.Drawing.Point(122, 193);
            this.codigoText.Margin = new System.Windows.Forms.Padding(2);
            this.codigoText.Name = "codigoText";
            this.codigoText.ReadOnly = true;
            this.codigoText.Size = new System.Drawing.Size(259, 20);
            this.codigoText.TabIndex = 19;
            // 
            // codigoLabel
            // 
            this.codigoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(8, 196);
            this.codigoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(43, 13);
            this.codigoLabel.TabIndex = 20;
            this.codigoLabel.Text = "Código:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 145);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Rubro:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 286);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Talle:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(662, 286);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Color:";
            // 
            // cbTalle
            // 
            this.cbTalle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStock, "Talle", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cbTalle.DataSource = this.bsTalle;
            this.cbTalle.DisplayMember = "Descripcion";
            this.cbTalle.FormattingEnabled = true;
            this.cbTalle.Location = new System.Drawing.Point(484, 278);
            this.cbTalle.Name = "cbTalle";
            this.cbTalle.Size = new System.Drawing.Size(121, 21);
            this.cbTalle.TabIndex = 43;
            this.cbTalle.ValueMember = "ID";
            // 
            // bsStock
            // 
            this.bsStock.DataSource = typeof(LATIENDA.Dominio.Entidades.Stock);
            // 
            // bsTalle
            // 
            this.bsTalle.DataSource = typeof(LATIENDA.Dominio.Entidades.Talle);
            // 
            // cbColor
            // 
            this.cbColor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStock, "Color", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cbColor.DataSource = this.bsColor;
            this.cbColor.DisplayMember = "Descripcion";
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(701, 278);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 21);
            this.cbColor.TabIndex = 44;
            this.cbColor.ValueMember = "ID";
            // 
            // bsColor
            // 
            this.bsColor.DataSource = typeof(LATIENDA.Dominio.Entidades.Color);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(690, 401);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 23);
            this.btnAgregar.TabIndex = 45;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(1, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(833, 10);
            this.panel4.TabIndex = 46;
            // 
            // txtRubro
            // 
            this.txtRubro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Rubro", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtRubro.Location = new System.Drawing.Point(122, 139);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.ReadOnly = true;
            this.txtRubro.Size = new System.Drawing.Size(196, 20);
            this.txtRubro.TabIndex = 47;
            // 
            // txtMarca
            // 
            this.txtMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Marca", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtMarca.Location = new System.Drawing.Point(122, 165);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(196, 20);
            this.txtMarca.TabIndex = 48;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(596, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 49;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 24);
            this.label9.TabIndex = 50;
            this.label9.Text = "CANTIDAD: ";
            // 
            // txtCantidad
            // 
            this.txtCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsStock, "Cantidad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCantidad.Location = new System.Drawing.Point(124, 23);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(239, 20);
            this.txtCantidad.TabIndex = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Location = new System.Drawing.Point(449, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 81);
            this.panel1.TabIndex = 52;
            // 
            // txtTipodeTalle
            // 
            this.txtTipodeTalle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "TipodeTalle", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtTipodeTalle.Location = new System.Drawing.Point(122, 381);
            this.txtTipodeTalle.Name = "txtTipodeTalle";
            this.txtTipodeTalle.ReadOnly = true;
            this.txtTipodeTalle.Size = new System.Drawing.Size(259, 20);
            this.txtTipodeTalle.TabIndex = 53;
            // 
            // lbTipodeTalle
            // 
            this.lbTipodeTalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTipodeTalle.AutoSize = true;
            this.lbTipodeTalle.Location = new System.Drawing.Point(8, 388);
            this.lbTipodeTalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTipodeTalle.Name = "lbTipodeTalle";
            this.lbTipodeTalle.Size = new System.Drawing.Size(72, 13);
            this.lbTipodeTalle.TabIndex = 54;
            this.lbTipodeTalle.Text = "Tipo de Talle:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 316);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "$";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(103, 338);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "$";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(103, 362);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 57;
            this.label12.Text = "$";
            // 
            // AgregarStockVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(834, 436);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbTipodeTalle);
            this.Controls.Add(this.txtTipodeTalle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtRubro);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.cbTalle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.existenciaLabel);
            this.Controls.Add(this.txtPreciodeVenta);
            this.Controls.Add(this.precioFinalLabel);
            this.Controls.Add(this.gananciaLabel);
            this.Controls.Add(this.precioIVALabel);
            this.Controls.Add(this.ivaLabel);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.txtCostoIva);
            this.Controls.Add(this.txtNetoGravado);
            this.Controls.Add(this.txtMargendeganancia);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.codigoText);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AgregarStockVista";
            this.Text = "AgregarStock";
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsColor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label existenciaLabel;
        private System.Windows.Forms.TextBox txtPreciodeVenta;
        private System.Windows.Forms.Label precioFinalLabel;
        private System.Windows.Forms.Label gananciaLabel;
        private System.Windows.Forms.Label precioIVALabel;
        private System.Windows.Forms.Label ivaLabel;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.TextBox txtCostoIva;
        private System.Windows.Forms.TextBox txtNetoGravado;
        private System.Windows.Forms.TextBox txtMargendeganancia;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox codigoText;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTalle;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.BindingSource bsTalle;
        private System.Windows.Forms.BindingSource bsColor;
        private System.Windows.Forms.BindingSource bsProducto;
        private System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTipodeTalle;
        private System.Windows.Forms.Label lbTipodeTalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource bsStock;
    }
}