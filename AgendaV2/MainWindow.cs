using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaV2
{
    public partial class MainWindow : Form
    {
        List<Person> persons = new List<Person>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            Person p = new Person("Alex", "0745332601", "alex.patruta@gmail.com");
            Person pe = new Person("Florin");
            persons.Add(p);
            persons.Add(pe);

            dataGridView1.DataSource = persons;
        }
    }
}
