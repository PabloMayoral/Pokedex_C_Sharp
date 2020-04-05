using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex_C_Sharp
{
    public partial class Busacdor : Form
    {

        //public int idSeleccionado;
        Conexion miConexion = new Conexion();
        private Image ConvierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }
        public Busacdor()
        {
            InitializeComponent();
             dataGridView1.DataSource = miConexion.getTodos();
             dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
             dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VentanaPrincipal v = new VentanaPrincipal();
                v.idActual = int.Parse(buscaId.Text);
                v.infoPokemons();
                v.Show();
                buscaId.Text = "";//Dejamos el buscador de ID vacío
            }
            catch (Exception ex)
            {//Si el id no es valido salta un aviso
                MessageBox.Show("ID no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buscaId.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                VentanaPrincipal v = new VentanaPrincipal();
                v.idActual = int.Parse(miConexion.getPokemonPorNombre(buscaNombre.Text.ToLower()));
                v.infoPokemons();
                v.Show();
                buscaNombre.Text = "";//vacíamos la búsqueda
            }
            catch (Exception ex)
            {//Si el nombre no es valido salta un aviso
                MessageBox.Show("Nombre no encontrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buscaNombre.Text = "";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            VentanaPrincipal v = new VentanaPrincipal();
            nombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            id.Text = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            tipo1.Text = dataGridView1.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
            especie.Text = dataGridView1.Rows[e.RowIndex].Cells["especie"].Value.ToString();
            habilidad.Text = dataGridView1.Rows[e.RowIndex].Cells["habilidad"].Value.ToString();
            peso.Text = dataGridView1.Rows[e.RowIndex].Cells["peso"].Value.ToString();
            altura.Text = dataGridView1.Rows[e.RowIndex].Cells["altura"].Value.ToString();
            descripcion.Text = dataGridView1.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
            movimiento4.Text = dataGridView1.Rows[e.RowIndex].Cells["habitat"].Value.ToString();
            pictureBox1.Image = ConvierteBlobAImagen((byte[])dataGridView1.Rows[e.RowIndex].Cells["miniatura"].Value);
        }
    }
}