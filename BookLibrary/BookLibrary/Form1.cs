using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookLibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ANKIT;Initial Catalog=study;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO books(TITLE, AUTHOR, ISBN, PRICE) VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')",con);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            MessageBox.Show("Data Added to Database");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ANKIT;Initial Catalog=study;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE from books where (TITLE ='" + textBox5.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox5.Text = "";
            MessageBox.Show("Data has been deleted from database");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=ANKIT;Initial Catalog=study;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE books SET AUTHOR ='" + textBox7.Text + "',ISBN='" + textBox8.Text + "',PRICE ='" + textBox9.Text + "' where TITLE = '" + textBox6.Text + "'", con);
            cmd.ExecuteNonQuery();
            con.Close();

            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            MessageBox.Show("Data Updated to Database");
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studyDataSet1);

        }

        private void booksBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studyDataSet1);

        }

        private void booksBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studyDataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studyDataSet1.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.studyDataSet1.books);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
           
        }
    }
}
