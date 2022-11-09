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
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Add_product_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Продукт", nameTextBox.Text, priceTextBox.Text, countryTextBox.Text, producingDateTextBox.Text);
        }

        private void Add_book_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Книга", nameTextBox.Text, priceTextBox.Text, countryTextBox.Text, producingDateTextBox.Text);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
        }

        private void DeleteCommodity_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }
    }
}
