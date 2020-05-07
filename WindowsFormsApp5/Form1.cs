using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n = Convert.ToString(input.Text);
            if (n == "ж")
                output.Text= Convert.ToString("Женские имена: Мария, Виолетта, Юлия, Алина, Ирина");
            else if (n == "м") output.Text = Convert.ToString("Мужские имена: Денис, Михаил, Никита, Богдан, Дмитрий");
            else output.Text = Convert.ToString("Некорректный ввод данных");

        }
    }
}
