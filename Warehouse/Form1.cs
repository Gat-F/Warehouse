using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem("Pen");
            lvi.SubItems.Add("1$");
            lvi.SubItems.Add("789456123");
            listView1.Items.Add(lvi);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return; 
            listView1.SelectedItems[0].Remove();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
