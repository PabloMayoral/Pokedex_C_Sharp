namespace Pokedex_C_Sharp
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.boton_izq = new System.Windows.Forms.Button();
            this.boton_dcha = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.Label();
            this.tipo2 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.especie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // boton_izq
            // 
            this.boton_izq.Location = new System.Drawing.Point(181, 302);
            this.boton_izq.Name = "boton_izq";
            this.boton_izq.Size = new System.Drawing.Size(20, 24);
            this.boton_izq.TabIndex = 1;
            this.boton_izq.Text = "<";
            this.boton_izq.UseVisualStyleBackColor = true;
            this.boton_izq.Click += new System.EventHandler(this.boton_izq_Click);
            // 
            // boton_dcha
            // 
            this.boton_dcha.Location = new System.Drawing.Point(226, 302);
            this.boton_dcha.Name = "boton_dcha";
            this.boton_dcha.Size = new System.Drawing.Size(18, 24);
            this.boton_dcha.TabIndex = 2;
            this.boton_dcha.Text = ">";
            this.boton_dcha.UseVisualStyleBackColor = true;
            this.boton_dcha.Click += new System.EventHandler(this.boton_dcha_Click);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(396, 128);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(91, 45);
            this.nombre.TabIndex = 3;
            this.nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(68, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Pokedex_C_Sharp.Properties.Resources.WhatsApp_Image_2020_03_27_at_19_10_22;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(595, 367);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(488, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(367, 128);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(32, 45);
            this.Id.TabIndex = 6;
            this.Id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipo
            // 
            this.tipo.Location = new System.Drawing.Point(483, 128);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(64, 25);
            this.tipo.TabIndex = 7;
            // 
            // tipo2
            // 
            this.tipo2.Location = new System.Drawing.Point(483, 153);
            this.tipo2.Name = "tipo2";
            this.tipo2.Size = new System.Drawing.Size(64, 20);
            this.tipo2.TabIndex = 8;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(362, 189);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(185, 44);
            this.descripcion.TabIndex = 9;
            // 
            // peso
            // 
            this.peso.Location = new System.Drawing.Point(365, 268);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(44, 23);
            this.peso.TabIndex = 10;
            this.peso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(405, 268);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(37, 23);
            this.altura.TabIndex = 11;
            this.altura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // especie
            // 
            this.especie.Location = new System.Drawing.Point(92, 312);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(59, 23);
            this.especie.TabIndex = 12;
            this.especie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 367);
            this.Controls.Add(this.especie);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.tipo2);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.boton_dcha);
            this.Controls.Add(this.boton_izq);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.Text = "Pokedex";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button boton_izq;
        private System.Windows.Forms.Button boton_dcha;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Label tipo2;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Label especie;
    }
}

