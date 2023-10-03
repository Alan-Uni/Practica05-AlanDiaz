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
using System.Text.RegularExpressions;

namespace Practica05_AlanDiaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Agregar controladores de eventos Textchanged a los campos

            txt_Edad.TextChanged += ValidarEdad;
            txt_Estatura.TextChanged += ValidarEstatura;
            txt_Telefono.TextChanged += ValidarTelefono;
            txt_Nombre.TextChanged += ValidarNombre;
            txt_Apellidos.TextChanged += ValidarApellidos;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string nombres = txt_Nombre.Text;
            string apellidos = txt_Apellidos.Text;
            string edad = txt_Edad.Text;
            string estatura = txt_Estatura.Text;
            string telefono = txt_Telefono.Text;

            string genero = "";
            if (rbtn_Hombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbtn_Mujer.Checked)
            {
                genero = "Mujer";
            }
            //validar formato correcto
            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsEnteroValidoDe100Digitos(telefono) && EsTextoValido(nombres) && EsTextoValido(apellidos))
            {




                string datos = $"Nombres:{nombres}\r\nApellidos:{apellidos}\r\nTelefono: {telefono} \r\nEstatura: {estatura} cm\r\nEdad: {edad} años\r\nGénero: {genero}\r\n";

                string rutaArchivo = "C:/Users/aland/Documents/datos.txt";

                bool archivoExiste = File.Exists(rutaArchivo);

                if (archivoExiste == false)
                {
                    File.WriteAllText(rutaArchivo, datos);

                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                    {
                        if (archivoExiste)
                        {
                            writer.WriteLine();
                        }
                        writer.WriteLine(datos);

                    }
                }

                MessageBox.Show("Datos guardados con exito: \n\n" + datos, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }else
            {
                MessageBox.Show("Por favor, ingrese los datos validos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }
        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }
        private bool EsEnteroValidoDe100Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado);
        }
        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"[a-zA-Z\s]+$");//solo letras y espacios
        }
        private void ValidarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsEnteroValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese una edad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }
        private void ValidarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese una estatura valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }

        }
        private void ValidarTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text;
            //eliminar espacios en blanco y guiones si fuera a ser necesario

            if (input.Length > 10)
            {
                if (!EsEnteroValidoDe100Digitos(input))
                {
                    MessageBox.Show("Por favor, ingrese un telefono valido valido de 10 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }else if (!EsEnteroValidoDe100Digitos(input))
            {
                MessageBox.Show("Por favor, ingrese un telefono valido valido de 10 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        
        private void ValidarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre valido(solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarApellidos(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese apellidos validos(solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            txt_Apellidos.Clear();
            txt_Estatura.Clear();
            txt_Telefono.Clear();
            txt_Edad.Clear();
            rbtn_Hombre.Checked = false;
            rbtn_Mujer.Checked = false;

        }
    }
}
