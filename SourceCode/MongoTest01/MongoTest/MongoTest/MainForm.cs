using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;

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

            string names = string.Join("\r\n", database.GetCollectionNames());
            MessageBox.Show(names);

            var collects =database.GetCollection("Customer");

            var collects2 = database.GetCollection("Customer2");
            var list=collects.FindAll().ToList();
            
            foreach (var item in list)
            { collects2.Insert(item); }

            MessageBox.Show("Done!");


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
