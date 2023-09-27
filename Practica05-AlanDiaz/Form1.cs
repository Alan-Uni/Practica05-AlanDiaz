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

namespace Practica05_AlanDiaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            } else if (rbtn_Mujer.Checked)
            {
                genero = "Mujer";
            }
            string datos = $"Nombres:{nombres}\r\nTelefono: {telefono} \r\nEstatura: {estatura} cm\r\nEdad: {edad} años\r\nGénero: {genero}";

            string rutaArchivo = "C:/Users/aland/Documents/datos.txt";

            bool archivoExiste = File.Exists(rutaArchivo);

            using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
            {
                if (archivoExiste)
                {
                    writer.WriteLine();
                }
                writer.WriteLine(datos);

            }
            MessageBox.Show("Datos guardados con exito: \n\n" + datos, "informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
