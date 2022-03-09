
namespace LATIENDA.Presentacion.Vistas
{
    partial class ComprobanteVista
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbCliente = new System.Windows.Forms.Label();
            this.lbEmisor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTipodeFactura = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVADinero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.bsProducto = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbVuelto = new System.Windows.Forms.Label();
            this.lbPago = new System.Windows.Forms.Label();
            this.lbTipodeCambio = new System.Windows.Forms.Label();
            this.lbMoneda = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotales = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbBase = new System.Windows.Forms.Label();
            this.lbIVA = new System.Windows.Forms.Label();
            this.lbPorcentualIVA = new System.Windows.Forms.Label();
            this.lbImporte = new System.Windows.Forms.Label();
            this.lb8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbNumero);
            this.panel1.Controls.Add(this.lbFecha);
            this.panel1.Controls.Add(this.lbCliente);
            this.panel1.Controls.Add(this.lbEmisor);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbTipodeFactura);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 109);
            this.panel1.TabIndex = 0;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumero.Location = new System.Drawing.Point(679, 4);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(21, 20);
            this.lbNumero.TabIndex = 10;
            this.lbNumero.Text = "N";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(600, 72);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(20, 20);
            this.lbFecha.TabIndex = 9;
            this.lbFecha.Text = "F";
            // 
            // lbCliente
            // 
            this.lbCliente.AutoSize = true;
            this.lbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCliente.Location = new System.Drawing.Point(213, 70);
            this.lbCliente.Name = "lbCliente";
            this.lbCliente.Size = new System.Drawing.Size(31, 20);
            this.lbCliente.TabIndex = 8;
            this.lbCliente.Text = "CL";
            // 
            // lbEmisor
            // 
            this.lbEmisor.AutoSize = true;
            this.lbEmisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmisor.Location = new System.Drawing.Point(213, 4);
            this.lbEmisor.Name = "lbEmisor";
            this.lbEmisor.Size = new System.Drawing.Size(35, 20);
            this.lbEmisor.TabIndex = 7;
            this.lbEmisor.Text = "EM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LATIENDA.Presentacion.Properties.Resources.mitienda_SINFONDO;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "FECHA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(549, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PTO VENTA/NUMERO:";
            // 
            // lbTipodeFactura
            // 
            this.lbTipodeFactura.AutoSize = true;
            this.lbTipodeFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipodeFactura.Location = new System.Drawing.Point(445, 4);
            this.lbTipodeFactura.Name = "lbTipodeFactura";
            this.lbTipodeFactura.Size = new System.Drawing.Size(30, 20);
            this.lbTipodeFactura.TabIndex = 3;
            this.lbTipodeFactura.Text = "TF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TIPO DE FACTURA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CLIENTE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMISOR:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(1, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 194);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Productos,
            this.Neto,
            this.IVA,
            this.IVADinero,
            this.Totales});
            this.dataGridView1.Location = new System.Drawing.Point(130, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 164);
            this.dataGridView1.TabIndex = 3;
            // 
            // Productos
            // 
            this.Productos.HeaderText = "Producto";
            this.Productos.Name = "Productos";
            // 
            // Neto
            // 
            this.Neto.HeaderText = "$Neto";
            this.Neto.Name = "Neto";
            // 
            // IVA
            // 
            this.IVA.HeaderText = "%IVA";
            this.IVA.Name = "IVA";
            // 
            // IVADinero
            // 
            this.IVADinero.HeaderText = "$IVA";
            this.IVADinero.Name = "IVADinero";
            // 
            // Totales
            // 
            this.Totales.HeaderText = "$Totales";
            this.Totales.Name = "Totales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Detalle:";
            // 
            // bsProducto
            // 
            this.bsProducto.DataSource = typeof(LATIENDA.Dominio.Entidades.Producto);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.lb8);
            this.panel3.Controls.Add(this.lbImporte);
            this.panel3.Controls.Add(this.lbPorcentualIVA);
            this.panel3.Controls.Add(this.lbIVA);
            this.panel3.Controls.Add(this.lbBase);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lbVuelto);
            this.panel3.Controls.Add(this.lbPago);
            this.panel3.Controls.Add(this.lbTipodeCambio);
            this.panel3.Controls.Add(this.lbMoneda);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lb1);
            this.panel3.Controls.Add(this.lbTotal);
            this.panel3.Controls.Add(this.lbTotales);
            this.panel3.Location = new System.Drawing.Point(1, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 194);
            this.panel3.TabIndex = 2;
            // 
            // lbVuelto
            // 
            this.lbVuelto.AutoSize = true;
            this.lbVuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVuelto.Location = new System.Drawing.Point(323, 153);
            this.lbVuelto.Name = "lbVuelto";
            this.lbVuelto.Size = new System.Drawing.Size(49, 20);
            this.lbVuelto.TabIndex = 19;
            this.lbVuelto.Text = "$$$$";
            // 
            // lbPago
            // 
            this.lbPago.AutoSize = true;
            this.lbPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPago.Location = new System.Drawing.Point(227, 153);
            this.lbPago.Name = "lbPago";
            this.lbPago.Size = new System.Drawing.Size(49, 20);
            this.lbPago.TabIndex = 18;
            this.lbPago.Text = "$$$$";
            // 
            // lbTipodeCambio
            // 
            this.lbTipodeCambio.AutoSize = true;
            this.lbTipodeCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipodeCambio.Location = new System.Drawing.Point(708, 55);
            this.lbTipodeCambio.Name = "lbTipodeCambio";
            this.lbTipodeCambio.Size = new System.Drawing.Size(31, 20);
            this.lbTipodeCambio.TabIndex = 17;
            this.lbTipodeCambio.Text = "TC";
            // 
            // lbMoneda
            // 
            this.lbMoneda.AutoSize = true;
            this.lbMoneda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMoneda.Location = new System.Drawing.Point(693, 13);
            this.lbMoneda.Name = "lbMoneda";
            this.lbMoneda.Size = new System.Drawing.Size(23, 20);
            this.lbMoneda.TabIndex = 11;
            this.lbMoneda.Text = "M";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(627, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "TipodeCambio";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(627, 18);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(46, 13);
            this.lb1.TabIndex = 15;
            this.lb1.Text = "Moneda";
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(124, 153);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(49, 20);
            this.lbTotal.TabIndex = 11;
            this.lbTotal.Text = "$$$$";
            // 
            // lbTotales
            // 
            this.lbTotales.AutoSize = true;
            this.lbTotales.Location = new System.Drawing.Point(4, 158);
            this.lbTotales.Name = "lbTotales";
            this.lbTotales.Size = new System.Drawing.Size(42, 13);
            this.lbTotales.TabIndex = 0;
            this.lbTotales.Text = "Totales";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(1, 542);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(713, 542);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tributos";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Base Imponible";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(127, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Base";
            // 
            // lbBase
            // 
            this.lbBase.AutoSize = true;
            this.lbBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBase.Location = new System.Drawing.Point(126, 35);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(49, 20);
            this.lbBase.TabIndex = 23;
            this.lbBase.Text = "$$$$";
            // 
            // lbIVA
            // 
            this.lbIVA.AutoSize = true;
            this.lbIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIVA.Location = new System.Drawing.Point(227, 35);
            this.lbIVA.Name = "lbIVA";
            this.lbIVA.Size = new System.Drawing.Size(49, 20);
            this.lbIVA.TabIndex = 24;
            this.lbIVA.Text = "$$$$";
            this.lbIVA.Click += new System.EventHandler(this.label12_Click);
            // 
            // lbPorcentualIVA
            // 
            this.lbPorcentualIVA.AutoSize = true;
            this.lbPorcentualIVA.Location = new System.Drawing.Point(228, 13);
            this.lbPorcentualIVA.Name = "lbPorcentualIVA";
            this.lbPorcentualIVA.Size = new System.Drawing.Size(15, 13);
            this.lbPorcentualIVA.TabIndex = 25;
            this.lbPorcentualIVA.Text = "%";
            // 
            // lbImporte
            // 
            this.lbImporte.AutoSize = true;
            this.lbImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImporte.Location = new System.Drawing.Point(323, 35);
            this.lbImporte.Name = "lbImporte";
            this.lbImporte.Size = new System.Drawing.Size(49, 20);
            this.lbImporte.TabIndex = 26;
            this.lbImporte.Text = "$$$$";
            // 
            // lb8
            // 
            this.lb8.AutoSize = true;
            this.lb8.Location = new System.Drawing.Point(324, 13);
            this.lb8.Name = "lb8";
            this.lb8.Size = new System.Drawing.Size(42, 13);
            this.lb8.TabIndex = 27;
            this.lb8.Text = "Importe";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(127, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(228, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Pago";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(324, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Vuelto";
            // 
            // ComprobanteVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 577);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ComprobanteVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPROBANTE";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbCliente;
        private System.Windows.Forms.Label lbEmisor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTipodeFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVADinero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totales;
        private System.Windows.Forms.BindingSource bsProducto;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTotales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbTipodeCambio;
        private System.Windows.Forms.Label lbMoneda;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lbPago;
        private System.Windows.Forms.Label lbVuelto;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbPorcentualIVA;
        private System.Windows.Forms.Label lbIVA;
        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb8;
        private System.Windows.Forms.Label lbImporte;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
    }
}