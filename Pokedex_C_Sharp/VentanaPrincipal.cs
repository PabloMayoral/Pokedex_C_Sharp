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
       
       public int idActual = 1;//el pokemon que estamos viendo
        public VentanaPrincipal()
        {
            InitializeComponent();
          

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
            infoPokemons();
        }

        private void boton_dcha_Click(object sender, EventArgs e)
        {
            idActual++;
            if (idActual >= 151)
            {
                idActual = 151;
            }
            infoPokemons();
        }
        public void infoPokemons()
        {
            misPokemons = miConexion.getPokemonPorId(idActual);
            nombre.Text = misPokemons.Rows[0]["nombre"].ToString();//Ponemos el nombre
            pictureBox1.Image = ConvierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);//Ponemos la imagen
            //Ponemos el ID
            if (idActual < 10)
            {
                Id.Text = "Nº: 00" + idActual;

            }
            else if (idActual < 100)
            {
                Id.Text = "Nº: 0" + idActual;
            }
            else
            {
                Id.Text = "Nº: " + idActual;
            }
          
            tipo.Text = misPokemons.Rows[0]["tipo1"].ToString();
            tipo2.Text = misPokemons.Rows[0]["tipo2"].ToString();
            descripcion.Text = misPokemons.Rows[0]["descripcion"].ToString();
            peso.Text = misPokemons.Rows[0]["peso"].ToString() + " kg";
            altura.Text = misPokemons.Rows[0]["altura"].ToString() + " m";
            especie.Text = misPokemons.Rows[0]["especie"].ToString();
            pictureBox1.Image = ConvierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           //nombre.Text = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
           //pictureBox1.Image = ConvierteBlobAImagen((byte[])dataGridView1.Rows[e.RowIndex].Cells["imagen"].Value); 

        
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          //  String nombre = dataGridView1.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            //String id = dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            //MessageBox.Show(miConexion.actualizapokemon(id, nombre));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaSeleccionPokemon eligepokemon = new VentanaSeleccionPokemon();
            eligepokemon.ShowDialog();
           // idActual = eligepokemon.idSeleccionado;
            // MessageBox.Show(eligepokemon.idSeleccionado.ToString());

            //misPokemons = miConexion.getPokemonPorId(idActual);
            //nombre.Text = misPokemons.Rows[0]["nombre"].ToString();
            //pictureBox1.Image = ConvierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
        }
    }
}
