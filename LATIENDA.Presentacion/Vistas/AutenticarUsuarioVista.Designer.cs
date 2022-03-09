
namespace LATIENDA.Presentacion.Vistas
{
    partial class AutenticarUsuario
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombredeUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.bsSesion = new System.Windows.Forms.BindingSource(this.components);
            this.bsUsuario = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 330);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LATIENDA.Presentacion.Properties.Resources.mitienda_SINFONDO;
            this.pictureBox1.Location = new System.Drawing.Point(12, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(301, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(498, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "ACCEDER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombredeUsuario
            // 
            this.txtNombredeUsuario.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNombredeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombredeUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "NombredeUsuario", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNombredeUsuario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombredeUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombredeUsuario.Location = new System.Drawing.Point(368, 106);
            this.txtNombredeUsuario.Name = "txtNombredeUsuario";
            this.txtNombredeUsuario.Size = new System.Drawing.Size(400, 19);
            this.txtNombredeUsuario.TabIndex = 0;
            this.txtNombredeUsuario.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(365, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "_______________________________________________________________";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(533, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 30);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "LOGIN";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSesion, "FechayHora", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.Location = new System.Drawing.Point(266, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 19);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "DateTime";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "Clave", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtContraseña.Location = new System.Drawing.Point(368, 168);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(371, 19);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(365, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "_______________________________________________________________";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Location = new System.Drawing.Point(821, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 40);
            this.panel1.TabIndex = 13;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 20;
            this.iconButton1.Location = new System.Drawing.Point(0, 8);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(36, 23);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // bsSesion
            // 
            this.bsSesion.DataSource = typeof(LATIENDA.Infraestructura.Transversal.Sesion);
            // 
            // bsUsuario
            // 
            this.bsUsuario.DataSource = typeof(LATIENDA.Dominio.Entidades.Usuario);
            // 
            // AutenticarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(867, 330);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNombredeUsuario);
            this.Controls.Add(this.txtContraseña);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutenticarUsuario";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutenticarUsuarioVista";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombredeUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bsUsuario;
        private System.Windows.Forms.BindingSource bsSesion;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}