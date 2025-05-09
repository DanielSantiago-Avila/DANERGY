using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejemplo1CONTA
{
    public partial class Form1 : Form
    {
        private SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        int contadorCampos = 1; // Para dar nombre y posición a los nuevos campos

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //TextBox nuevoCampo = new TextBox();

            //// Configurar propiedades del nuevo TextBox
            //nuevoCampo.Name = "txtCampo" + contadorCampos;
            //nuevoCampo.Width = 200;
            //nuevoCampo.Top = contadorCampos * 30; // Posiciona verticalmente
            //nuevoCampo.Left = 10;

            //// Agregar al panel
            //flowLayoutPanel1.Controls.Add(nuevoCampo);

            //contadorCampos++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string connectionString = "Server=DESKTOP-C2CRO3R\\SQLEXPRESS;Database=PF_CONTA;Trusted_Connection=True;";
            //connection = new SqlConnection(connectionString);

            //try
            //{
            //    connection.Open();
            //    MessageBox.Show("Conexión exitosa a la base de datos.");
            //    // Aquí puedes ejecutar tus comandos SQL si deseas
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error al conectar: " + ex.Message);
            //}
            //finally
            //{
            //    connection.Close();
            //}
        }
    }
}
