using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class Homes : Form
    {
        public Homes()
        {
            InitializeComponent();
            countDogs();
            countCats();
            countBirds();
            countFood();
            Finance();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-3879ECGQ;Initial Catalog=PetShop;Integrated Security=True");

        private void countDogs()
        {
            string dog = "Dog";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"Select count(*) from ProductTbl Where Prcat='" + dog + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DogsLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void countCats()
        {
            string cat = "Cat";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"Select count(*) from ProductTbl Where Prcat='" + cat + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CatsLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void countFood()
        {
            string Food = "Food";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"Select count(*) from ProductTbl Where Prcat='" + Food + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            FoodLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void countBirds()
        {
            string bird = "Bird";
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"Select count(*) from ProductTbl Where Prcat='" + bird + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            BirdsLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void Finance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"Select Sum(Amt) from BillTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            FinancelLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Homes Obj = new Homes();
            Obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Homes Obj = new Homes();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Homes Obj = new Homes();
            Obj.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Products Obj = new Products();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Products Obj = new Products();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Products Obj = new Products();
            Obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customers Obj = new Customers();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Customers Obj = new Customers();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Customers Obj = new Customers();
            Obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Billings Obj = new Billings();
            Obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Billings Obj = new Billings();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Billings Obj = new Billings();
            Obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
