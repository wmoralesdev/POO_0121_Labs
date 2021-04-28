using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiApp
{
    public partial class Form1 : Form
    {
        // Todos los eventos son de tipo delegate
        // void Nombre(object sender, EventArgs e) -> EventArgs puede ser polimorfico
        private List<string> names;
        public Form1()
        {
            names = new List<string>
            {
                "Walter",
                "Mariana",
                "Victor",
                "Eddy",
                "Lourdes",
                "Mauricio",
                "Brandon",
                "Marcelo",
                "Alex"
            };

            InitializeComponent();
            
            cmb_names.DataSource = names;
        }

        private void btn_show_MouseEnter(object sender, EventArgs e)
        {
            btn_show.BackColor = Color.Blue;
            btn_show.Width += 20;
        }

        private void btn_show_MouseLeave(object sender, EventArgs e)
        {
            btn_show.BackColor = Color.IndianRed;
            btn_show.Width -= 20;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            names.RemoveAll(name => IsVowel(name[name.Length - 1]));
            cmb_names.DataSource = null;
            cmb_names.DataSource = names;
        }

        private bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}