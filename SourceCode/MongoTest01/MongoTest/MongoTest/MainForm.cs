using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoRepository;

namespace MongoTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string con = "mongodb://127.0.0.1:27017/local";
        string dbname = "local";
        private void btText_Click(object sender, EventArgs e)
        {

            var client = new MongoClient(con);
            var database = client.GetServer().GetDatabase(dbname);
            var collects =database.GetCollection("Customer");
            var list=collects.FindAll().ToList();

            //var repo = new MongoRepository<Customer>();

            //// adding new entity
            //var newCustomer = new Customer
            //{
            //    FirstName = "Steve",
            //    LastName = "Cornell"
            //};

            //repo.Add(newCustomer);

            //// searching
            ////var result = repo.Where(c => c.FirstName == "Steve");
            ////var result = repo.Where(c => c.FirstName.Contains("Steve"));
            //var result = repo.Where(c => c.FirstName.StartsWith("Steve"));


            //MessageBox.Show(result.Count<Customer>().ToString());

            //// updating 
            //newCustomer.LastName = "Castle";
            //repo.Update(newCustomer);

            //dataGridView1.DataSource = result.ToList<Customer>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
