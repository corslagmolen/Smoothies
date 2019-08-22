using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smoothies
{
    public partial class Form1 : Form
    {
        string[] ingredienten = { "Appel", "Peer", "Aardbei", "Komkommer", "Yoghurt", "Meloen" };
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            opmaakLivIngredienten();
            filLivIngredienten();
        }
        private void filLivIngredienten()
        {
            livIngredienten.Items.Clear();
            foreach (var ingredient in ingredienten)
            {
                ListViewItem livIngredientenItem = new ListViewItem(ingredient);
                livIngredienten.Items.Add(livIngredientenItem);
            }
        }
        private void opmaakLivIngredienten()
        {
            livIngredienten.View = View.Details;
            livIngredienten.OwnerDraw = true;
            ColumnHeader headerIngredienten = livIngredienten.Columns.Add("Ingredienten", -2);


        }

        private void LivIngredienten_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            Font headerFont = new Font("Microsoft sans Serif", 10, FontStyle.Bold);
            e.Graphics.FillRectangle(Brushes.Turquoise, e.Bounds);
            e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.Black, e.Bounds, stringFormat);
        }
    }
}
