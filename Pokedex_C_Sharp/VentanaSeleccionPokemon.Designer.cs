namespace Pokedex_C_Sharp
{
    partial class Busacdor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busacdor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buscaId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buscaNombre = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.id = new System.Windows.Forms.Label();
            this.especie = new System.Windows.Forms.Label();
            this.tipo1 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.peso = new System.Windows.Forms.Label();
            this.movimiento4 = new System.Windows.Forms.Label();
            this.habilidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(293, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(483, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buscaId
            // 
            this.buscaId.Location = new System.Drawing.Point(275, 0);
            this.buscaId.Multiline = true;
            this.buscaId.Name = "buscaId";
            this.buscaId.Size = new System.Drawing.Size(141, 42);
            this.buscaId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "buscar por id";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "buscar por nombre";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buscaNombre
            // 
            this.buscaNombre.Location = new System.Drawing.Point(565, 0);
            this.buscaNombre.Multiline = true;
            this.buscaNombre.Name = "buscaNombre";
            this.buscaNombre.Size = new System.Drawing.Size(131, 42);
            this.buscaNombre.TabIndex = 6;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(62, 252);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(74, 23);
            this.nombre.TabIndex = 9;
            this.nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(26, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Pokedex_C_Sharp.Properties.Resources.fondopokedexcsharp;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(800, 450);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(12, 252);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(44, 23);
            this.id.TabIndex = 11;
            this.id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // especie
            // 
            this.especie.Location = new System.Drawing.Point(12, 317);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(94, 23);
            this.especie.TabIndex = 12;
            this.especie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipo1
            // 
            this.tipo1.Location = new System.Drawing.Point(142, 252);
            this.tipo1.Name = "tipo1";
            this.tipo1.Size = new System.Drawing.Size(108, 23);
            this.tipo1.TabIndex = 14;
            this.tipo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(12, 349);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(238, 57);
            this.descripcion.TabIndex = 16;
            this.descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(192, 284);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(58, 23);
            this.altura.TabIndex = 17;
            this.altura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // peso
            // 
            this.peso.Location = new System.Drawing.Point(128, 284);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(58, 23);
            this.peso.TabIndex = 18;
            this.peso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // movimiento4
            // 
            this.movimiento4.Location = new System.Drawing.Point(128, 317);
            this.movimiento4.Name = "movimiento4";
            this.movimiento4.Size = new System.Drawing.Size(122, 23);
            this.movimiento4.TabIndex = 19;
            this.movimiento4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // habilidad
            // 
            this.habilidad.Location = new System.Drawing.Point(15, 284);
            this.habilidad.Name = "habilidad";
            this.habilidad.Size = new System.Drawing.Size(107, 23);
            this.habilidad.TabIndex = 22;
            this.habilidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Busacdor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.habilidad);
            this.Controls.Add(this.movimiento4);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.tipo1);
            this.Controls.Add(this.especie);
            this.Controls.Add(this.id);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buscaNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscaId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Busacdor";
            this.Text = "Busacdor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox buscaId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox buscaNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label tipo1;
        private System.Windows.Forms.Label descripcion;
        private System.Windows.Forms.Label altura;
        private System.Windows.Forms.Label peso;
        private System.Windows.Forms.Label movimiento4;
        private System.Windows.Forms.Label habilidad;
    }
}