using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            
        }
        private XElement LoadData(string xmlDataFile)
        {
            XDocument XTree = new XDocument();
            return XTree;
        }
    }
}
