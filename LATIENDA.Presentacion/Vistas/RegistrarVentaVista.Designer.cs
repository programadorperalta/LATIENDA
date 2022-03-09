
namespace LATIENDA.Presentacion.Vistas
{
    partial class RegistrarVentaVista
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
            this.txtCondicionTributaria = new System.Windows.Forms.TextBox();
            this.bsCliente = new System.Windows.Forms.BindingSource(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bsLineadeVenta = new System.Windows.Forms.BindingSource(this.components);
            this.label23 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtTalle = new System.Windows.Forms.TextBox();
            this.txtPreciodeVenta = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.bsPago = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bsTipodePago = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bsStock = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNumeroVenta = new System.Windows.Forms.TextBox();
            this.bsVenta = new System.Windows.Forms.BindingSource(this.components);
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLineadeVenta)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipodePago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStock)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.txtCondicionTributaria);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtDomicilio);
            this.panel1.Controls.Add(this.txtNombreCliente);
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.Controls.Add(this.txtCUIT);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 129);
            this.panel1.TabIndex = 2;
            // 
            // txtCondicionTributaria
            // 
            this.txtCondicionTributaria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "CondicionTributaria", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtCondicionTributaria.Location = new System.Drawing.Point(589, 90);
            this.txtCondicionTributaria.Name = "txtCondicionTributaria";
            this.txtCondicionTributaria.ReadOnly = true;
            this.txtCondicionTributaria.Size = new System.Drawing.Size(284, 20);
            this.txtCondicionTributaria.TabIndex = 13;
            // 
            // bsCliente
            // 
            this.bsCliente.DataSource = typeof(LATIENDA.Dominio.Entidades.Cliente);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(479, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Condicion Tributaria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Domicilio:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(479, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Nombre:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "Domicilio", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtDomicilio.Location = new System.Drawing.Point(589, 55);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(284, 20);
            this.txtDomicilio.TabIndex = 8;
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCliente, "Nombre", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNombreCliente.Location = new System.Drawing.Point(589, 21);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(284, 20);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(270, 52);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCUIT
            // 
            this.txtCUIT.Location = new System.Drawing.Point(72, 55);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(175, 20);
            this.txtCUIT.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "CUIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar Cliente";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.txtMarca);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.txtDescripcion);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.txtTalle);
            this.panel2.Controls.Add(this.txtPreciodeVenta);
            this.panel2.Controls.Add(this.txtColor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnBuscarProducto);
            this.panel2.Controls.Add(this.txtCodigoProducto);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 150);
            this.panel2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLineadeVenta, "Cantidad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(567, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 21;
            // 
            // bsLineadeVenta
            // 
            this.bsLineadeVenta.DataSource = typeof(LATIENDA.Dominio.Entidades.LineadeVenta);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(465, 111);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 20;
            this.label23.Text = "Cantidad: ";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(880, 79);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.ReadOnly = true;
            this.txtMarca.Size = new System.Drawing.Size(161, 20);
            this.txtMarca.TabIndex = 19;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(770, 86);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(40, 13);
            this.label22.TabIndex = 18;
            this.label22.Text = "Marca:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(880, 53);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(161, 20);
            this.txtCantidad.TabIndex = 17;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(770, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 13);
            this.label21.TabIndex = 16;
            this.label21.Text = "Cantidad Disponible:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(880, 27);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(161, 20);
            this.txtDescripcion.TabIndex = 15;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(770, 34);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 14;
            this.label20.Text = "Descripcion:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(465, 86);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 13;
            this.label19.Text = "Talle:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(465, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 12;
            this.label18.Text = "Color:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(465, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 11;
            this.label17.Text = "Precio de venta:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(653, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "AGREGAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtTalle
            // 
            this.txtTalle.Location = new System.Drawing.Point(567, 79);
            this.txtTalle.Name = "txtTalle";
            this.txtTalle.ReadOnly = true;
            this.txtTalle.Size = new System.Drawing.Size(161, 20);
            this.txtTalle.TabIndex = 9;
            // 
            // txtPreciodeVenta
            // 
            this.txtPreciodeVenta.Location = new System.Drawing.Point(567, 27);
            this.txtPreciodeVenta.Name = "txtPreciodeVenta";
            this.txtPreciodeVenta.ReadOnly = true;
            this.txtPreciodeVenta.Size = new System.Drawing.Size(161, 20);
            this.txtPreciodeVenta.TabIndex = 8;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(567, 53);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(161, 20);
            this.txtColor.TabIndex = 5;
            this.txtColor.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(717, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Informacion del producto";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(270, 55);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(72, 57);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(175, 20);
            this.txtCodigoProducto.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Buscar Producto";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(0, 327);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 177);
            this.panel3.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(423, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Quitar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "$";
            // 
            // txtTotal
            // 
            this.txtTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPago, "MontoAPagar", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtTotal.Location = new System.Drawing.Point(93, 145);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(250, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // bsPago
            // 
            this.bsPago.DataSource = typeof(LATIENDA.Dominio.Entidades.Pago);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Subtotal,
            this.Stock});
            this.dataGridView1.Location = new System.Drawing.Point(16, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 101);
            this.dataGridView1.TabIndex = 1;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Linea de Venta";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.textBox9);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(525, 327);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(555, 177);
            this.panel4.TabIndex = 14;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(113, 109);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(18, 20);
            this.label25.TabIndex = 14;
            this.label25.Text = "$";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPago, "Vuelto", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(137, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(161, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(16, 116);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(71, 13);
            this.label24.TabIndex = 12;
            this.label24.Text = "SU VUELTO:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(113, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "$";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPago, "TipodePago", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.comboBox1.DataSource = this.bsTipodePago;
            this.comboBox1.DisplayMember = "Descripcion";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(176, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "ID";
            // 
            // bsTipodePago
            // 
            this.bsTipodePago.DataSource = typeof(LATIENDA.Dominio.Entidades.TipodePago);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Generar Comprobante";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPago, "MontoRecibido", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox9.Location = new System.Drawing.Point(137, 83);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(161, 20);
            this.textBox9.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Pago en efectivo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(154, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Seleccione el metodo de pago:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(224, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Pago y generacion de comprobante";
            // 
            // bsStock
            // 
            this.bsStock.DataSource = typeof(LATIENDA.Dominio.Entidades.Stock);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel5.Controls.Add(this.txtNumeroVenta);
            this.panel5.Controls.Add(this.iconButton2);
            this.panel5.Controls.Add(this.tituloLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1080, 42);
            this.panel5.TabIndex = 31;
            // 
            // txtNumeroVenta
            // 
            this.txtNumeroVenta.BackColor = System.Drawing.SystemColors.Info;
            this.txtNumeroVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroVenta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVenta, "Numero", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNumeroVenta.Location = new System.Drawing.Point(589, 10);
            this.txtNumeroVenta.Name = "txtNumeroVenta";
            this.txtNumeroVenta.Size = new System.Drawing.Size(211, 20);
            this.txtNumeroVenta.TabIndex = 6;
            this.txtNumeroVenta.Text = "Nro";
            // 
            // bsVenta
            // 
            this.bsVenta.DataSource = typeof(LATIENDA.Dominio.Entidades.Venta);
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
            this.iconButton2.Location = new System.Drawing.Point(1039, 13);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(29, 23);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // tituloLabel
            // 
            this.tituloLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.Location = new System.Drawing.Point(442, 9);
            this.tituloLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(87, 25);
            this.tituloLabel.TabIndex = 0;
            this.tituloLabel.Text = "VENTA";
            // 
            // RegistrarVentaVista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1080, 509);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarVentaVista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarVentaVista";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCliente)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLineadeVenta)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTipodePago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStock)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtTalle;
        private System.Windows.Forms.TextBox txtPreciodeVenta;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtCondicionTributaria;
        private System.Windows.Forms.BindingSource bsCliente;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource bsStock;
        private System.Windows.Forms.BindingSource bsLineadeVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.BindingSource bsTipodePago;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.TextBox txtNumeroVenta;
        private System.Windows.Forms.BindingSource bsVenta;
        private System.Windows.Forms.BindingSource bsPago;
    }
}