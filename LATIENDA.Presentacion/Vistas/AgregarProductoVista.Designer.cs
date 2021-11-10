
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
            this.descripcionText = new System.Windows.Forms.TextBox();
            this.precioBaseText = new System.Windows.Forms.TextBox();
            this.ivaText = new System.Windows.Forms.TextBox();
            this.precioIVAText = new System.Windows.Forms.TextBox();
            this.gananciaText = new System.Windows.Forms.TextBox();
            this.precioFinalText = new System.Windows.Forms.TextBox();
            this.descripcionLabel = new System.Windows.Forms.Label();
            this.baseLabel = new System.Windows.Forms.Label();
            this.ivaLabel = new System.Windows.Forms.Label();
            this.precioIVALabel = new System.Windows.Forms.Label();
            this.gananciaLabel = new System.Windows.Forms.Label();
            this.precioFinalLabel = new System.Windows.Forms.Label();
            this.confirmarBoton = new System.Windows.Forms.Button();
            this.existenciaText = new System.Windows.Forms.TextBox();
            this.existenciaLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bsRubro = new System.Windows.Forms.BindingSource(this.components);
            this.bsMarca = new System.Windows.Forms.BindingSource(this.components);
            this.cbRubro = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRubro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMarca)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(175, 9);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(154, 17);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "NUEVO PRODUCTO";
            // 
            // codigoLabel
            // 
            this.codigoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(43, 110);
            this.codigoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(43, 13);
            this.codigoLabel.TabIndex = 1;
            this.codigoLabel.Text = "Código:";
            // 
            // codigoText
            // 
            this.codigoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codigoText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Codigo", true));
            this.codigoText.Location = new System.Drawing.Point(157, 107);
            this.codigoText.Margin = new System.Windows.Forms.Padding(2);
            this.codigoText.Name = "codigoText";
            this.codigoText.Size = new System.Drawing.Size(246, 20);
            this.codigoText.TabIndex = 0;
            this.codigoText.TextChanged += new System.EventHandler(this.codigoText_TextChanged);
            // 
            // bsProducto
            // 
            this.bsProducto.DataSource = typeof(LATIENDA.Dominio.Entidades.Producto);
            // 
            // descripcionText
            // 
            this.descripcionText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Descripcion", true));
            this.descripcionText.Location = new System.Drawing.Point(157, 131);
            this.descripcionText.Margin = new System.Windows.Forms.Padding(2);
            this.descripcionText.Name = "descripcionText";
            this.descripcionText.Size = new System.Drawing.Size(246, 20);
            this.descripcionText.TabIndex = 1;
            // 
            // precioBaseText
            // 
            this.precioBaseText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precioBaseText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Costo", true));
            this.precioBaseText.Location = new System.Drawing.Point(157, 153);
            this.precioBaseText.Margin = new System.Windows.Forms.Padding(2);
            this.precioBaseText.Name = "precioBaseText";
            this.precioBaseText.Size = new System.Drawing.Size(246, 20);
            this.precioBaseText.TabIndex = 2;
            // 
            // ivaText
            // 
            this.ivaText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ivaText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "PorcentajeIva", true));
            this.ivaText.Location = new System.Drawing.Point(157, 177);
            this.ivaText.Margin = new System.Windows.Forms.Padding(2);
            this.ivaText.Name = "ivaText";
            this.ivaText.Size = new System.Drawing.Size(246, 20);
            this.ivaText.TabIndex = 3;
            this.ivaText.TextChanged += new System.EventHandler(this.ivaText_TextChanged);
            // 
            // precioIVAText
            // 
            this.precioIVAText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precioIVAText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "MargendeGanancia", true));
            this.precioIVAText.Location = new System.Drawing.Point(157, 200);
            this.precioIVAText.Margin = new System.Windows.Forms.Padding(2);
            this.precioIVAText.Name = "precioIVAText";
            this.precioIVAText.Size = new System.Drawing.Size(246, 20);
            this.precioIVAText.TabIndex = 4;
            this.precioIVAText.TextChanged += new System.EventHandler(this.precioIVAText_TextChanged);
            // 
            // gananciaText
            // 
            this.gananciaText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gananciaText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "NetoGravado", true));
            this.gananciaText.Location = new System.Drawing.Point(157, 223);
            this.gananciaText.Margin = new System.Windows.Forms.Padding(2);
            this.gananciaText.Name = "gananciaText";
            this.gananciaText.Size = new System.Drawing.Size(246, 20);
            this.gananciaText.TabIndex = 5;
            this.gananciaText.TextChanged += new System.EventHandler(this.gananciaText_TextChanged);
            // 
            // precioFinalText
            // 
            this.precioFinalText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.precioFinalText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "CostoConIva", true));
            this.precioFinalText.Location = new System.Drawing.Point(157, 245);
            this.precioFinalText.Margin = new System.Windows.Forms.Padding(2);
            this.precioFinalText.Name = "precioFinalText";
            this.precioFinalText.Size = new System.Drawing.Size(246, 20);
            this.precioFinalText.TabIndex = 6;
            // 
            // descripcionLabel
            // 
            this.descripcionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descripcionLabel.AutoSize = true;
            this.descripcionLabel.Location = new System.Drawing.Point(43, 131);
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
            this.baseLabel.Location = new System.Drawing.Point(43, 156);
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
            this.ivaLabel.Location = new System.Drawing.Point(43, 180);
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
            this.precioIVALabel.Location = new System.Drawing.Point(43, 203);
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
            this.gananciaLabel.Location = new System.Drawing.Point(43, 225);
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
            this.precioFinalLabel.Location = new System.Drawing.Point(43, 248);
            this.precioFinalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.precioFinalLabel.Name = "precioFinalLabel";
            this.precioFinalLabel.Size = new System.Drawing.Size(78, 13);
            this.precioFinalLabel.TabIndex = 14;
            this.precioFinalLabel.Text = "Costo con IVA:";
            // 
            // confirmarBoton
            // 
            this.confirmarBoton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmarBoton.Location = new System.Drawing.Point(386, 308);
            this.confirmarBoton.Margin = new System.Windows.Forms.Padding(2);
            this.confirmarBoton.Name = "confirmarBoton";
            this.confirmarBoton.Size = new System.Drawing.Size(73, 32);
            this.confirmarBoton.TabIndex = 7;
            this.confirmarBoton.Text = "Confirmar";
            this.confirmarBoton.UseVisualStyleBackColor = true;
            this.confirmarBoton.Click += new System.EventHandler(this.confirmarBoton_Click);
            // 
            // existenciaText
            // 
            this.existenciaText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.existenciaText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "PreciodeVenta", true));
            this.existenciaText.Location = new System.Drawing.Point(157, 269);
            this.existenciaText.Margin = new System.Windows.Forms.Padding(2);
            this.existenciaText.Name = "existenciaText";
            this.existenciaText.Size = new System.Drawing.Size(246, 20);
            this.existenciaText.TabIndex = 15;
            this.existenciaText.TextChanged += new System.EventHandler(this.existenciaText_TextChanged);
            // 
            // existenciaLabel
            // 
            this.existenciaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.existenciaLabel.AutoSize = true;
            this.existenciaLabel.Location = new System.Drawing.Point(43, 269);
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
            this.label1.Location = new System.Drawing.Point(407, 181);
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
            this.label2.Location = new System.Drawing.Point(407, 207);
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
            this.label3.Location = new System.Drawing.Point(43, 54);
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
            this.label4.Location = new System.Drawing.Point(43, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Marca:";
            // 
            // bsRubro
            // 
            this.bsRubro.DataSource = typeof(LATIENDA.Dominio.Entidades.Rubro);
            // 
            // bsMarca
            // 
            this.bsMarca.DataSource = typeof(LATIENDA.Dominio.Entidades.Marca);
            // 
            // cbRubro
            // 
            this.cbRubro.DataSource = this.bsRubro;
            this.cbRubro.DisplayMember = "Descripcion";
            this.cbRubro.FormattingEnabled = true;
            this.cbRubro.Location = new System.Drawing.Point(192, 46);
            this.cbRubro.Name = "cbRubro";
            this.cbRubro.Size = new System.Drawing.Size(121, 21);
            this.cbRubro.TabIndex = 21;
            this.cbRubro.ValueMember = "Numero";
            this.cbRubro.SelectedIndexChanged += new System.EventHandler(this.cbRubro_SelectedIndexChanged);
            // 
            // cbMarca
            // 
            this.cbMarca.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProducto, "MarcaID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cbMarca.DataSource = this.bsMarca;
            this.cbMarca.DisplayMember = "Descripcion";
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Location = new System.Drawing.Point(192, 78);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(121, 21);
            this.cbMarca.TabIndex = 22;
            this.cbMarca.ValueMember = "Numero";
            // 
            // AgregarProductoVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(489, 360);
            this.Controls.Add(this.cbMarca);
            this.Controls.Add(this.cbRubro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.existenciaLabel);
            this.Controls.Add(this.existenciaText);
            this.Controls.Add(this.confirmarBoton);
            this.Controls.Add(this.precioFinalLabel);
            this.Controls.Add(this.gananciaLabel);
            this.Controls.Add(this.precioIVALabel);
            this.Controls.Add(this.ivaLabel);
            this.Controls.Add(this.baseLabel);
            this.Controls.Add(this.descripcionLabel);
            this.Controls.Add(this.precioFinalText);
            this.Controls.Add(this.gananciaText);
            this.Controls.Add(this.precioIVAText);
            this.Controls.Add(this.ivaText);
            this.Controls.Add(this.precioBaseText);
            this.Controls.Add(this.descripcionText);
            this.Controls.Add(this.codigoText);
            this.Controls.Add(this.codigoLabel);
            this.Controls.Add(this.tituloLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarProductoVista";
            this.Text = "AGREGAR PRODUCTO";
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRubro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.TextBox codigoText;
        private System.Windows.Forms.TextBox descripcionText;
        private System.Windows.Forms.TextBox precioBaseText;
        private System.Windows.Forms.TextBox ivaText;
        private System.Windows.Forms.TextBox precioIVAText;
        private System.Windows.Forms.TextBox gananciaText;
        private System.Windows.Forms.TextBox precioFinalText;
        private System.Windows.Forms.Label descripcionLabel;
        private System.Windows.Forms.Label baseLabel;
        private System.Windows.Forms.Label ivaLabel;
        private System.Windows.Forms.Label precioIVALabel;
        private System.Windows.Forms.Label gananciaLabel;
        private System.Windows.Forms.Label precioFinalLabel;
        private System.Windows.Forms.Button confirmarBoton;
        public System.Windows.Forms.BindingSource bsProducto;
        private System.Windows.Forms.TextBox existenciaText;
        private System.Windows.Forms.Label existenciaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bsMarca;
        private System.Windows.Forms.BindingSource bsRubro;
        private System.Windows.Forms.ComboBox cbRubro;
        private System.Windows.Forms.ComboBox cbMarca;
    }
}