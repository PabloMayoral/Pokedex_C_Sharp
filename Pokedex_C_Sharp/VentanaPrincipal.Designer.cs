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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boton_izq = new System.Windows.Forms.Button();
            this.boton_dcha = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(67, 152);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.nombre.Location = new System.Drawing.Point(364, 126);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(183, 45);
            this.nombre.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pokedex_C_Sharp.Properties.Resources.WhatsApp_Image_2020_03_27_at_19_10_22;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(595, 368);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(591, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(304, 368);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 405);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button boton_izq;
        private System.Windows.Forms.Button boton_dcha;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

