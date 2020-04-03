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
    public partial class VentanaPrincipal : Form
    {

        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 0;//el pokemon que estamos viendo
        public VentanaPrincipal()
        {
            InitializeComponent();
            dataGridView1.DataSource = miConexion.getTodosPokes();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }
        private Image ConvierteBlobAImagen(byte[] img) 
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
          
        }
       

        private void boton_izq_Click(object sender, EventArgs e)
        {
            idActual--;
            if(idActual<= 0)
            {
                idActual = 0;
            }
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombre.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = ConvierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void boton_dcha_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 151)
            {
                idActual = 151;
            }
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombre.Text = misPokemons.Rows[0]["nombre"].ToString();
            pictureBox1.Image = ConvierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            pictureBox1.Image = ConvierteBlobAImagen((byte[])dataGridView1.Rows[e.RowIndex].Cells["imagen"].Value);

        
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            String nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            String id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            MessageBox.Show(miConexion.actualizapokemon(id, nombre));
        }
    }
}
