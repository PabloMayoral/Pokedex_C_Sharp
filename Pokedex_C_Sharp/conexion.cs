using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pokedex_C_Sharp
{
    class Conexion
    {
        public MySqlConnection conexion;

        public Conexion()
        {
            conexion = new MySqlConnection("Server = 127.0.0.1; Database = listapokemons; Uid = root; Pwd=;Port = 3306");
        }

        public DataTable getPokemonPorId(int id)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM pokemon where id ='" + id + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public DataTable getTodosPokes()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("SELECT id,nombre FROM pokemon", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public String actualizapokemon(String id, String dato)
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta = new MySqlCommand("UPDATE pokemon set nombre = '"+dato+"' WHERE id='"+id+ "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                String mensaje;
                if (resultado.RecordsAffected == 1) 
                {
                    mensaje = "Actualizado correctamente";
                }
                else 
                {
                    mensaje = "Error al actualizar el nombre del pokemon";
                }
                conexion.Close();
                return mensaje;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public String getPokemonPorNombre(String nombre)
        {

            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT id FROM pokemon WHERE LOWER(nombre) ='" + nombre + "'", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons.Rows[0]["id"].ToString();

            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
        public DataTable getTodos()
        {
            try
            {
                conexion.Open();
                MySqlCommand consulta =
                    new MySqlCommand("SELECT id AS ID, nombre AS Nombre, CONCAT(altura, ' m') AS Altura, CONCAT(peso,' kg') AS Peso, " +
                    "especie AS Especie, habitat AS Habitat, CONCAT(tipo1, ' ',tipo2) AS Tipo, habilidad AS Habilidad, descripcion AS Descripcion, imagen AS Miniatura FROM pokemon", conexion);
                MySqlDataReader resultado = consulta.ExecuteReader();
                DataTable pokemons = new DataTable();
                pokemons.Load(resultado);
                conexion.Close();
                return pokemons;
            }
            catch (MySqlException e)
            {
                throw e;
            }
        }
    }
}