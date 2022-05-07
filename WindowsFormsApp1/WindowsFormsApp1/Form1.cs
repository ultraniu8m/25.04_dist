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
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            checkedListBox1.SelectedIndexChanged += CheckedListBox1_SelectedIndexChanged;
            List<Phone> phones = new List<Phone>
        {
            new Phone { Id=11, Name="Samsung Galaxy Ace 2", Year=2012},
            new Phone { Id=12, Name="Samsung Galaxy S4", Year=2013},
            new Phone { Id=13, Name="iPhone 6", Year=2014},
            new Phone { Id=14, Name="Microsoft Lumia 435", Year=2015},
            new Phone { Id=15, Name="Xiaomi Mi 5", Year=2015}
        };
            comboBox2.DataSource = phones;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id";
            domainUpDown1.TextChanged += domainUpDown1_SelectedItemChanged;   
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBox1.SelectedItem.ToString();
            MessageBox.Show(selectedState);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            MessageBox.Show(domainUpDown1.Text);
        }
    }
    class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
    }
}
