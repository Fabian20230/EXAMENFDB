using EXAMENFDB.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAMENFDB
{
    public partial class Form1 : Form
    {
        private mascotas patitas;

        public Form1()
        {
            InitializeComponent();
            patitas = new mascotas();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = patitas.leerpersonajes();

        }

        private void buttoncrear_Click(object sender, EventArgs e)
        {
            string nombre = textBoxnombre.Text;
            DateTime fecha_nacimiento = DateTime.Now;
            string raza = textBoxraza.Text;
            string color = textBoxcolor.Text;
            string condicion = textBoxcondicion.Text;
            string sexo = textBoxsexo.Text;

            if  (string.IsNullOrEmpty(nombre) ||
            string.IsNullOrEmpty(color) || string.IsNullOrEmpty(condicion) ||
            string.IsNullOrEmpty(raza) || string.IsNullOrEmpty(sexo))
            {
                MessageBox.Show("ERROR: Todos los campos deben estar llenos.");
                return;
            }

            int respuesta = patitas.CrearPersonaje(nombre, fecha_nacimiento, raza, color, condicion, sexo);
            if (respuesta > 0)
            {
                MessageBox.Show("SE CREO CORRECTAMENTE");
                dataGridView1.DataSource = patitas.leerpersonajes();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void buttonactualizar_Click(object sender, EventArgs e)
        {
            string id = textBoxid.Text;
            string nombre = textBoxnombre.Text;
            DateTime fecha_nacimiento = dateTimePicker.Value;
            string color = textBoxcolor.Text;
            string condicion = textBoxcondicion.Text;
            string raza = textBoxraza.Text;
            string sexo = textBoxsexo.Text;


            //correccion si los campos estan vacios
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nombre) ||
    string.IsNullOrEmpty(color) || string.IsNullOrEmpty(condicion) ||
    string.IsNullOrEmpty(raza) || string.IsNullOrEmpty(sexo))
            {
                MessageBox.Show("ERROR: Todos los campos deben estar llenos.");
                return; 
            }


            int respuesta = patitas.ActualizarPersonaje( id , nombre, fecha_nacimiento, raza, color, condicion , sexo);
            if (respuesta > 0)
            {
                MessageBox.Show("SE ACTUALIZÓ");
                dataGridView1.DataSource = patitas.leerpersonajes();
            }
            else
            {
                MessageBox.Show("ERROR");
            }

        }

        private void buttonborrar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxid.Text);
            int eliminar = patitas.Borrarpersonaje(id);
            if (eliminar > 0)
            {
                MessageBox.Show("SE ELIMINO CORRECTAMENTE");
                textBoxid.Clear();
                textBoxnombre.Clear();
                textBoxraza.Clear();
                textBoxcolor.Clear();
                textBoxcondicion.Clear();
                textBoxsexo.Clear();
                dataGridView1.DataSource = patitas.leerpersonajes();
            }
            else
            {
                MessageBox.Show("NO SE ELIMINO");

            }
        }


        private void BuscarPorId()
        {
            int idPersonajeBuscar = int.Parse(textBoxid.Text);
            DataTable personajeEncontrado = patitas.Buscar(idPersonajeBuscar);

            
            if (personajeEncontrado.Rows.Count > 0)
            {
                string nombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string raza = personajeEncontrado.Rows[0]["raza"].ToString();
                string condicion = personajeEncontrado.Rows[0]["condicion"].ToString();
                DateTime fecha_nacimiento = (DateTime)personajeEncontrado.Rows[0]["fecha_nacimiento"];
                string color = personajeEncontrado.Rows[0]["color"].ToString();
                string sexo = personajeEncontrado.Rows[0]["sexo"].ToString();


                textBoxnombre.Text = nombre;
                textBoxraza.Text = raza;
                dateTimePicker.Value = fecha_nacimiento;
                textBoxcondicion.Text = condicion;
                textBoxcolor.Text = color;
                textBoxsexo.Text = sexo;

            }
            else
            {
                MessageBox.Show("NO EXISTE");
            }
        }
        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            BuscarPorId();
        }

        private void textBoxraza_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
