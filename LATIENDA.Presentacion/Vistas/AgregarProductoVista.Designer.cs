
namespace LATIENDA.Presentacion.Vistas
{
    partial class AgregarProductoVista
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
            this.tituloLabel = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.codigoText = new System.Windows.Forms.TextBox();
            this.bsProducto = new System.Windows.Forms.BindingSource(this.components);
            this.costoText = new System.Windows.Forms.TextBox();
            this.ivaText = new System.Windows.Forms.TextBox();
            this.costoIVAText = new System.Windows.Forms.TextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.ivaLabel = new System.Windows.Forms.Label();
            this.precioIVALabel = new System.Windows.Forms.Label();
            this.gananciaLabel = new System.Windows.Forms.Label();
            this.precioFinalLabel = new System.Windows.Forms.Label();
            this.existenciaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRubro = new System.Windows.Forms.ComboBox();
            this.bsRubro = new System.Windows.Forms.BindingSource(this.components);
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.bsMarca = new System.Windows.Forms.BindingSource(this.components);
            this.margendeGananciaText = new System.Windows.Forms.TextBox();
            this.netoGravadoText = new System.Windows.Forms.TextBox();
            this.preciodeVentaText = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTipodeTalle = new System.Windows.Forms.ComboBox();
            this.bsTipodeTalle = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMarca)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipodeTalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(354, 9);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(225, 25);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "NUEVO PRODUCTO";
            // 
            // codigoLabel
            // 
            this.codigoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(12, 69);
            this.codigoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(43, 13);
            this.codigoLabel.TabIndex = 1;
            this.codigoLabel.Text = "Código:";
            this.codigoLabel.Click += new System.EventHandler(this.codigoLabel_Click);
            // 
            // codigoText
            // 
            this.codigoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Codigo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.codigoText.Location = new System.Drawing.Point(127, 66);
            this.codigoText.Margin = new System.Windows.Forms.Padding(2);
            this.codigoText.Name = "codigoText";
            this.codigoText.Size = new System.Drawing.Size(336, 20);
            this.codigoText.TabIndex = 0;
            this.codigoText.TextChanged += new System.EventHandler(this.codigoText_TextChanged);
            // 
            // bsProducto
            // 
            this.bsProducto.DataSource = typeof(LATIENDA.Dominio.Entidades.Producto);
            // 
            // costoText
            // 
            this.costoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costoText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Costo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.costoText.Location = new System.Drawing.Point(127, 133);
            this.costoText.Margin = new System.Windows.Forms.Padding(2);
            this.costoText.Name = "costoText";
            this.costoText.Size = new System.Drawing.Size(337, 20);
            this.costoText.TabIndex = 2;
            // 
            // ivaText
            // 
            this.ivaText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ivaText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "PorcentajeIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N1"));
            this.ivaText.Location = new System.Drawing.Point(127, 166);
            this.ivaText.Margin = new System.Windows.Forms.Padding(2);
            this.ivaText.Name = "ivaText";
            this.ivaText.ReadOnly = true;
            this.ivaText.Size = new System.Drawing.Size(194, 20);
            this.ivaText.TabIndex = 3;
            this.ivaText.TextChanged += new System.EventHandler(this.ivaText_TextChanged);
            // 
            // costoIVAText
            // 
            this.costoIVAText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costoIVAText.BackColor = System.Drawing.SystemColors.Info;
            this.costoIVAText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "CostoConIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C0"));
            this.costoIVAText.Location = new System.Drawing.Point(127, 265);
            this.costoIVAText.Margin = new System.Windows.Forms.Padding(2);
            this.costoIVAText.Name = "costoIVAText";
            this.costoIVAText.ReadOnly = true;
            this.costoIVAText.Size = new System.Drawing.Size(385, 20);
            this.costoIVAText.TabIndex = 6;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(12, 105);
            this.descripcionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(66, 13);
            this.descripcionLabel.TabIndex = 9;
            this.descripcionLabel.Text = "Descripcion:";
            // 
            // baseLabel
            // 
            this.baseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(12, 140);
            this.baseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(37, 13);
            this.baseLabel.TabIndex = 10;
            this.baseLabel.Text = "Costo:";
            // 
            // ivaLabel
            // 
            this.ivaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ivaLabel.AutoSize = true;
            this.ivaLabel.Location = new System.Drawing.Point(12, 173);
            this.ivaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ivaLabel.Name = "ivaLabel";
            this.ivaLabel.Size = new System.Drawing.Size(96, 13);
            this.ivaLabel.TabIndex = 11;
            this.ivaLabel.Text = "Porcentaje de IVA:";
            // 
            // precioIVALabel
            // 
            this.precioIVALabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precioIVALabel.AutoSize = true;
            this.precioIVALabel.Location = new System.Drawing.Point(12, 206);
            this.precioIVALabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.precioIVALabel.Name = "precioIVALabel";
            this.precioIVALabel.Size = new System.Drawing.Size(110, 13);
            this.precioIVALabel.TabIndex = 12;
            this.precioIVALabel.Text = "Margen de Ganancia:";
            // 
            // gananciaLabel
            // 
            this.gananciaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gananciaLabel.AutoSize = true;
            this.gananciaLabel.Location = new System.Drawing.Point(12, 241);
            this.gananciaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gananciaLabel.Name = "gananciaLabel";
            this.gananciaLabel.Size = new System.Drawing.Size(77, 13);
            this.gananciaLabel.TabIndex = 13;
            this.gananciaLabel.Text = "Neto Gravado:";
            // 
            // precioFinalLabel
            // 
            this.precioFinalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precioFinalLabel.AutoSize = true;
            this.precioFinalLabel.Location = new System.Drawing.Point(13, 272);
            this.precioFinalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.precioFinalLabel.Name = "precioFinalLabel";
            this.precioFinalLabel.Size = new System.Drawing.Size(78, 13);
            this.precioFinalLabel.TabIndex = 14;
            this.precioFinalLabel.Text = "Costo con IVA:";
            this.precioFinalLabel.Click += new System.EventHandler(this.precioFinalLabel_Click);
            // 
            // existenciaLabel
            // 
            this.existenciaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.existenciaLabel.AutoSize = true;
            this.existenciaLabel.Location = new System.Drawing.Point(13, 305);
            this.existenciaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.existenciaLabel.Name = "existenciaLabel";
            this.existenciaLabel.Size = new System.Drawing.Size(86, 13);
            this.existenciaLabel.TabIndex = 16;
            this.existenciaLabel.Text = "Precio de Venta:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 202);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 362);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Rubro:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 362);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Marca:";
            // 
            // cbRubro
            // 
            this.cbRubro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Rubro", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cbRubro.DataSource = this.bsRubro;
            this.cbRubro.DisplayMember = "Descripcion";
            this.cbRubro.FormattingEnabled = true;
            this.cbRubro.Location = new System.Drawing.Point(127, 354);
            this.cbRubro.Name = "cbRubro";
            this.cbRubro.Size = new System.Drawing.Size(195, 21);
            this.cbRubro.TabIndex = 21;
            this.cbRubro.ValueMember = "ID";
            this.cbRubro.SelectedIndexChanged += new System.EventHandler(this.cbRubro_SelectedIndexChanged);
            // 
            // bsRubro
            // 
            this.bsRubro.DataSource = typeof(LATIENDA.Dominio.Entidades.Rubro);
            // 
            // cbMarca
            // 
            this.cbMarca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Marca", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cbMarca.DataSource = this.bsMarca;
            this.cbMarca.DisplayMember = "Descripcion";
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(411, 354);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(214, 21);
            this.cbMarca.TabIndex = 22;
            this.cbMarca.ValueMember = "ID";
            // 
            // bsMarca
            // 
            this.bsMarca.DataSource = typeof(LATIENDA.Dominio.Entidades.Marca);
            // 
            // margendeGananciaText
            // 
            this.margendeGananciaText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "MargendeGanancia", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N2"));
            this.margendeGananciaText.Location = new System.Drawing.Point(127, 199);
            this.margendeGananciaText.Name = "margendeGananciaText";
            this.margendeGananciaText.Size = new System.Drawing.Size(91, 20);
            this.margendeGananciaText.TabIndex = 24;
            // 
            // netoGravadoText
            // 
            this.netoGravadoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.netoGravadoText.BackColor = System.Drawing.SystemColors.Info;
            this.netoGravadoText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "NetoGravado", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C0"));
            this.netoGravadoText.Location = new System.Drawing.Point(127, 234);
            this.netoGravadoText.Margin = new System.Windows.Forms.Padding(2);
            this.netoGravadoText.Name = "netoGravadoText";
            this.netoGravadoText.ReadOnly = true;
            this.netoGravadoText.Size = new System.Drawing.Size(385, 20);
            this.netoGravadoText.TabIndex = 25;
            // 
            // preciodeVentaText
            // 
            this.preciodeVentaText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preciodeVentaText.BackColor = System.Drawing.SystemColors.Info;
            this.preciodeVentaText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "PreciodeVenta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "C0"));
            this.preciodeVentaText.Location = new System.Drawing.Point(126, 298);
            this.preciodeVentaText.Margin = new System.Windows.Forms.Padding(2);
            this.preciodeVentaText.Name = "preciodeVentaText";
            this.preciodeVentaText.ReadOnly = true;
            this.preciodeVentaText.Size = new System.Drawing.Size(386, 20);
            this.preciodeVentaText.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Controls.Add(this.cbTipodeTalle);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtDescripcion);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.codigoText);
            this.panel3.Controls.Add(this.codigoLabel);
            this.panel3.Controls.Add(this.preciodeVentaText);
            this.panel3.Controls.Add(this.costoText);
            this.panel3.Controls.Add(this.netoGravadoText);
            this.panel3.Controls.Add(this.ivaText);
            this.panel3.Controls.Add(this.margendeGananciaText);
            this.panel3.Controls.Add(this.costoIVAText);
            this.panel3.Controls.Add(this.descripcionLabel);
            this.panel3.Controls.Add(this.cbMarca);
            this.panel3.Controls.Add(this.baseLabel);
            this.panel3.Controls.Add(this.cbRubro);
            this.panel3.Controls.Add(this.ivaLabel);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.precioIVALabel);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.gananciaLabel);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.precioFinalLabel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.existenciaLabel);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(904, 487);
            this.panel3.TabIndex = 29;
            // 
            // cbTipodeTalle
            // 
            this.cbTipodeTalle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Rubro", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cbTipodeTalle.DataSource = this.bsTipodeTalle;
            this.cbTipodeTalle.DisplayMember = "Descriptiontipodetalle";
            this.cbTipodeTalle.FormattingEnabled = true;
            this.cbTipodeTalle.Location = new System.Drawing.Point(785, 354);
            this.cbTipodeTalle.Name = "cbTipodeTalle";
            this.cbTipodeTalle.Size = new System.Drawing.Size(85, 21);
            this.cbTipodeTalle.TabIndex = 30;
            this.cbTipodeTalle.ValueMember = "ID";
            // 
            // bsTipodeTalle
            // 
            this.bsTipodeTalle.DataSource = typeof(LATIENDA.Dominio.Entidades.TipodeTalle);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(686, 362);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tipo de Talle:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Descripcion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDescripcion.Location = new System.Drawing.Point(127, 98);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(498, 20);
            this.txtDescripcion.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LATIENDA.Presentacion.Properties.Resources.mitienda_SINFONDO;
            this.pictureBox1.InitialImage = global::LATIENDA.Presentacion.Properties.Resources.mitienda;
            this.pictureBox1.Location = new System.Drawing.Point(645, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.tituloLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 42);
            this.panel2.TabIndex = 30;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.DodgerBlue;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 20;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.Location = new System.Drawing.Point(863, 9);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(29, 23);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 79);
            this.panel1.TabIndex = 31;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.iconButton1.IconColor = System.Drawing.Color.Honeydew;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 60;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(706, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(195, 71);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "CONFIRMAR";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // AgregarProductoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(904, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarProductoVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGREGAR PRODUCTO";
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMarca)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipodeTalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox codigoText;
        private System.Windows.Forms.TextBox costoText;
        private System.Windows.Forms.TextBox ivaText;
        private System.Windows.Forms.TextBox costoIVAText;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label ivaLabel;
        private System.Windows.Forms.Label precioIVALabel;
        private System.Windows.Forms.Label gananciaLabel;
        private System.Windows.Forms.Label precioFinalLabel;
        private System.Windows.Forms.Label existenciaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRubro;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.BindingSource bsRubro;
        private System.Windows.Forms.BindingSource bsMarca;
        private System.Windows.Forms.BindingSource bsProducto;
        private System.Windows.Forms.TextBox margendeGananciaText;
        private System.Windows.Forms.TextBox netoGravadoText;
        private System.Windows.Forms.TextBox preciodeVentaText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbTipodeTalle;
        private System.Windows.Forms.BindingSource bsTipodeTalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}