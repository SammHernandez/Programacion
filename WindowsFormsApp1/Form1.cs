using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Automovil> listaAutomoviles = new List<Automovil>();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Automovil a1 = new Automovil();
            a1.Matricula = matricul.Text;   
            a1.Marca = Marca.Text;
            a1.Modelo = Modelo.Text;
            a1.Año = Convert.ToInt32(Año.Text);
            a1.Cantidadpuertas = Convert.ToInt32(CantidadPuertas.Text);
            a1.Tipocompustible = TipoCombustible.Text;

            ListViewItem items = new ListViewItem();
            a1.Matricula = matricul.Text;
            items.Text = a1.Marca;
            items.SubItems.Add(a1.Modelo);
            items.SubItems.Add(a1.Cantidadpuertas.ToString());
            items.SubItems.Add(a1.Año.ToString());
            items.SubItems.Add(a1.Tipocompustible);

            listView1.Items.Add(items);
            listaAutomoviles.Add(a1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listaAutomoviles.Count; i++)
            {
                MessageBox.Show(listaAutomoviles[i].MostrarInformacion(), "Información", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);

                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < listaAutomoviles.Count; i++)
            {
                if( matricul.Text == listaAutomoviles[i].Matricula)
                {
                    Modelo.Text = listaAutomoviles[i].Modelo;
                    Marca.Text = listaAutomoviles[i].Marca;
                    Año.Text = listaAutomoviles[i].Año.ToString();
                    CantidadPuertas.Text = listaAutomoviles[i].Cantidadpuertas.ToString();
                    TipoCombustible.Text = listaAutomoviles[i].Tipocompustible;
                
                
                
                }

            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
