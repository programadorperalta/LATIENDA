
namespace LATIENDA.Presentacion.Vistas
{
    partial class ModificarProductoVista
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbTipodeTalle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.bsProducto = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.codigoText = new System.Windows.Forms.TextBox();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.preciodeVentaText = new System.Windows.Forms.TextBox();
            this.costoText = new System.Windows.Forms.TextBox();
            this.netoGravadoText = new System.Windows.Forms.TextBox();
            this.ivaText = new System.Windows.Forms.TextBox();
            this.margendeGananciaText = new System.Windows.Forms.TextBox();
            this.costoIVAText = new System.Windows.Forms.TextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.baseLabel = new System.Windows.Forms.Label();
            this.cbRubro = new System.Windows.Forms.ComboBox();
            this.bsRubro = new System.Windows.Forms.BindingSource(this.components);
            this.ivaLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.precioIVALabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gananciaLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.precioFinalLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.existenciaLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.confirmarBoton = new System.Windows.Forms.Button();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.bsMarca = new System.Windows.Forms.BindingSource(this.components);
            this.bsTipodeTalle = new System.Windows.Forms.BindingSource(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipodeTalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
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
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 368);
            this.panel3.TabIndex = 35;
            // 
            // cbTipodeTalle
            // 
            this.cbTipodeTalle.DataSource = this.bsTipodeTalle;
            this.cbTipodeTalle.DisplayMember = "Descriptiontipodetalle";
            this.cbTipodeTalle.FormattingEnabled = true;
            this.cbTipodeTalle.Location = new System.Drawing.Point(654, 306);
            this.cbTipodeTalle.Name = "cbTipodeTalle";
            this.cbTipodeTalle.Size = new System.Drawing.Size(136, 21);
            this.cbTipodeTalle.TabIndex = 30;
            this.cbTipodeTalle.ValueMember = "ID";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 314);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tipo de Talle:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Descripcion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDescripcion.Location = new System.Drawing.Point(128, 53);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(414, 20);
            this.txtDescripcion.TabIndex = 28;
            // 
            // bsProducto
            // 
            this.bsProducto.DataSource = typeof(LATIENDA.Dominio.Entidades.Producto);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LATIENDA.Presentacion.Properties.Resources.mitienda_SINFONDO;
            this.pictureBox1.InitialImage = global::LATIENDA.Presentacion.Properties.Resources.mitienda;
            this.pictureBox1.Location = new System.Drawing.Point(551, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // codigoText
            // 
            this.codigoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Codigo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.codigoText.Location = new System.Drawing.Point(128, 21);
            this.codigoText.Margin = new System.Windows.Forms.Padding(2);
            this.codigoText.Name = "codigoText";
            this.codigoText.ReadOnly = true;
            this.codigoText.Size = new System.Drawing.Size(233, 20);
            this.codigoText.TabIndex = 0;
            // 
            // codigoLabel
            // 
            this.codigoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(13, 24);
            this.codigoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(43, 13);
            this.codigoLabel.TabIndex = 1;
            this.codigoLabel.Text = "Código:";
            // 
            // preciodeVentaText
            // 
            this.preciodeVentaText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preciodeVentaText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.preciodeVentaText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "PreciodeVenta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.preciodeVentaText.Location = new System.Drawing.Point(127, 253);
            this.preciodeVentaText.Margin = new System.Windows.Forms.Padding(2);
            this.preciodeVentaText.Name = "preciodeVentaText";
            this.preciodeVentaText.ReadOnly = true;
            this.preciodeVentaText.Size = new System.Drawing.Size(283, 20);
            this.preciodeVentaText.TabIndex = 26;
            // 
            // costoText
            // 
            this.costoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costoText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Costo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.costoText.Location = new System.Drawing.Point(128, 88);
            this.costoText.Margin = new System.Windows.Forms.Padding(2);
            this.costoText.Name = "costoText";
            this.costoText.Size = new System.Drawing.Size(234, 20);
            this.costoText.TabIndex = 2;
            // 
            // netoGravadoText
            // 
            this.netoGravadoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.netoGravadoText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.netoGravadoText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "NetoGravado", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.netoGravadoText.Location = new System.Drawing.Point(128, 189);
            this.netoGravadoText.Margin = new System.Windows.Forms.Padding(2);
            this.netoGravadoText.Name = "netoGravadoText";
            this.netoGravadoText.ReadOnly = true;
            this.netoGravadoText.Size = new System.Drawing.Size(282, 20);
            this.netoGravadoText.TabIndex = 25;
            // 
            // ivaText
            // 
            this.ivaText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ivaText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "PorcentajeIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ivaText.Location = new System.Drawing.Point(128, 121);
            this.ivaText.Margin = new System.Windows.Forms.Padding(2);
            this.ivaText.Name = "ivaText";
            this.ivaText.ReadOnly = true;
            this.ivaText.Size = new System.Drawing.Size(91, 20);
            this.ivaText.TabIndex = 3;
            // 
            // margendeGananciaText
            // 
            this.margendeGananciaText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "MargendeGanancia", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.margendeGananciaText.Location = new System.Drawing.Point(128, 154);
            this.margendeGananciaText.Name = "margendeGananciaText";
            this.margendeGananciaText.Size = new System.Drawing.Size(91, 20);
            this.margendeGananciaText.TabIndex = 24;
            // 
            // costoIVAText
            // 
            this.costoIVAText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.costoIVAText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.costoIVAText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "CostoConIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.costoIVAText.Location = new System.Drawing.Point(128, 220);
            this.costoIVAText.Margin = new System.Windows.Forms.Padding(2);
            this.costoIVAText.Name = "costoIVAText";
            this.costoIVAText.ReadOnly = true;
            this.costoIVAText.Size = new System.Drawing.Size(282, 20);
            this.costoIVAText.TabIndex = 6;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(13, 60);
            this.descripcionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descripcionLabel.Name = "descripcionLabel";
            this.descripcionLabel.Size = new System.Drawing.Size(66, 13);
            this.descripcionLabel.TabIndex = 9;
            this.descripcionLabel.Text = "Descripcion:";
            // 
            // cbMarca
            // 
            this.cbMarca.DataSource = this.bsMarca;
            this.cbMarca.DisplayMember = "Descripcion";
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(382, 306);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(136, 21);
            this.cbMarca.TabIndex = 22;
            this.cbMarca.ValueMember = "ID";
            // 
            // baseLabel
            // 
            this.baseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseLabel.AutoSize = true;
            this.baseLabel.Location = new System.Drawing.Point(13, 95);
            this.baseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baseLabel.Name = "baseLabel";
            this.baseLabel.Size = new System.Drawing.Size(37, 13);
            this.baseLabel.TabIndex = 10;
            this.baseLabel.Text = "Costo:";
            // 
            // cbRubro
            // 
            this.cbRubro.DataSource = this.bsRubro;
            this.cbRubro.DisplayMember = "Descripcion";
            this.cbRubro.FormattingEnabled = true;
            this.cbRubro.Location = new System.Drawing.Point(127, 306);
            this.cbRubro.Name = "cbRubro";
            this.cbRubro.Size = new System.Drawing.Size(136, 21);
            this.cbRubro.TabIndex = 21;
            this.cbRubro.ValueMember = "ID";
            // 
            // bsRubro
            // 
            this.bsRubro.DataSource = typeof(LATIENDA.Dominio.Entidades.Rubro);
            // 
            // ivaLabel
            // 
            this.ivaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ivaLabel.AutoSize = true;
            this.ivaLabel.Location = new System.Drawing.Point(13, 128);
            this.ivaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ivaLabel.Name = "ivaLabel";
            this.ivaLabel.Size = new System.Drawing.Size(96, 13);
            this.ivaLabel.TabIndex = 11;
            this.ivaLabel.Text = "Porcentaje de IVA:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 314);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Marca:";
            // 
            // precioIVALabel
            // 
            this.precioIVALabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precioIVALabel.AutoSize = true;
            this.precioIVALabel.Location = new System.Drawing.Point(13, 161);
            this.precioIVALabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.precioIVALabel.Name = "precioIVALabel";
            this.precioIVALabel.Size = new System.Drawing.Size(110, 13);
            this.precioIVALabel.TabIndex = 12;
            this.precioIVALabel.Text = "Margen de Ganancia:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Rubro:";
            // 
            // gananciaLabel
            // 
            this.gananciaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gananciaLabel.AutoSize = true;
            this.gananciaLabel.Location = new System.Drawing.Point(13, 196);
            this.gananciaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gananciaLabel.Name = "gananciaLabel";
            this.gananciaLabel.Size = new System.Drawing.Size(77, 13);
            this.gananciaLabel.TabIndex = 13;
            this.gananciaLabel.Text = "Neto Gravado:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "%";
            // 
            // precioFinalLabel
            // 
            this.precioFinalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precioFinalLabel.AutoSize = true;
            this.precioFinalLabel.Location = new System.Drawing.Point(14, 227);
            this.precioFinalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.precioFinalLabel.Name = "precioFinalLabel";
            this.precioFinalLabel.Size = new System.Drawing.Size(78, 13);
            this.precioFinalLabel.TabIndex = 14;
            this.precioFinalLabel.Text = "Costo con IVA:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "%";
            // 
            // existenciaLabel
            // 
            this.existenciaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.existenciaLabel.AutoSize = true;
            this.existenciaLabel.Location = new System.Drawing.Point(14, 260);
            this.existenciaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.existenciaLabel.Name = "existenciaLabel";
            this.existenciaLabel.Size = new System.Drawing.Size(86, 13);
            this.existenciaLabel.TabIndex = 16;
            this.existenciaLabel.Text = "Precio de Venta:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 10);
            this.panel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 10);
            this.panel1.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(614, 451);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 32);
            this.button1.TabIndex = 32;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirmarBoton
            // 
            this.confirmarBoton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmarBoton.Location = new System.Drawing.Point(717, 451);
            this.confirmarBoton.Margin = new System.Windows.Forms.Padding(2);
            this.confirmarBoton.Name = "confirmarBoton";
            this.confirmarBoton.Size = new System.Drawing.Size(73, 32);
            this.confirmarBoton.TabIndex = 31;
            this.confirmarBoton.Text = "Confirmar";
            this.confirmarBoton.UseVisualStyleBackColor = true;
            this.confirmarBoton.Click += new System.EventHandler(this.confirmarBoton_Click_1);
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(323, 9);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(183, 17);
            this.tituloLabel.TabIndex = 30;
            this.tituloLabel.Text = "MODIFICAR PRODUCTO";
            // 
            // bsMarca
            // 
            this.bsMarca.DataSource = typeof(LATIENDA.Dominio.Entidades.Marca);
            // 
            // bsTipodeTalle
            // 
            this.bsTipodeTalle.DataSource = typeof(LATIENDA.Dominio.Entidades.TipodeTalle);
            // 
            // ModificarProductoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(802, 494);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmarBoton);
            this.Controls.Add(this.tituloLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarProductoVista";
            this.Text = "ModificarVista";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipodeTalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbTipodeTalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.BindingSource bsProducto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox codigoText;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox preciodeVentaText;
        private System.Windows.Forms.TextBox costoText;
        private System.Windows.Forms.TextBox netoGravadoText;
        private System.Windows.Forms.TextBox ivaText;
        private System.Windows.Forms.TextBox margendeGananciaText;
        private System.Windows.Forms.TextBox costoIVAText;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.ComboBox cbRubro;
        private System.Windows.Forms.BindingSource bsRubro;
        private System.Windows.Forms.Label ivaLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label precioIVALabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label gananciaLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label precioFinalLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label existenciaLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button confirmarBoton;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.BindingSource bsMarca;
        private System.Windows.Forms.BindingSource bsTipodeTalle;
    }
}