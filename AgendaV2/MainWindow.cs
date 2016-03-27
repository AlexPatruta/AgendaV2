using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void nameInput_Leave(object sender, EventArgs e)
        {
            if (!isValid(nameInput.Text.ToString().ToLower()))
            {
                nameErrorDisplay.ForeColor = Color.Red;
                nameErrorDisplay.Text = "Please input a valid name.";
            }
            else
            {
                nameErrorDisplay.ForeColor = Color.Green;
                nameErrorDisplay.Text = "OK";
            }
        }

        private static bool isValid(string nameInput)
        {
            return (nameInput != "" && isAlphaNumeric(nameInput)) ? true : false;
        }

        private static bool isAlphaNumeric(string strToCheck)
        {
            Regex rg = new Regex(@"[\p{L}\p{N}_]");
            return rg.IsMatch(strToCheck);  
        }
    }
}
