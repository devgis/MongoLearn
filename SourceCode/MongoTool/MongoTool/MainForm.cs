using MongoDB.Driver;
using System;
using System.Collections.Generic;
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

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private bool TestDBCon(string conStr, string DBNAMe)
        {
            try
            {
                var client = new MongoClient(con);
                var database = client.GetServer().GetDatabase(dbname);

                var list =database.GetCollectionNames();
                if(list!=null&&list.Count()>0)
                {
                    return true;
                }
            }
            catch(Exception ex)
            { }
            return false;
        }

        private void GetDocuments(string conStr, string DBNAMe)
        {
            if (TestDBCon(conStr, DBNAMe))
            {
                try
                {
                    var client = new MongoClient(con);
                    var database = client.GetServer().GetDatabase(dbname);

                    var list = database.GetCollectionNames();
                    foreach(string docname in list)
                    {
                        int index=dgvDocuments.Rows.Add();
                        (dgvDocuments.Rows[index].Cells["CSelect"] as DataGridViewCheckBoxCell).Value=true;
                        dgvDocuments.Rows[index].Cells["CDocumentName"].Value = docname;
                    }
                }
                catch (Exception ex)
                { }
            }
            else
            {
                MessageBox.Show("鏈接數據庫失敗,請檢查數據庫！");
            }
            
        }

        private List<string> GetDocuments()
        {
            List<string> list = new List<string>();
            foreach (DataGridViewRow row in dgvDocuments.Rows)
            {
               if ((row.Cells["CSelect"] as DataGridViewCheckBoxCell).Value == (row.Cells["CSelect"] as DataGridViewCheckBoxCell).TrueValue)
                {
                    list.Add(row.Cells["CDocumentName"].Value.ToString());
                }
            }
            return list;
        }

        private void SyncDocuments(string conStr1,string conStr2,string DBName1, string DBName2, List<string> DocNames)
        {
            var client1 = new MongoClient(conStr1);
            var client2 = new MongoClient(conStr2);
            var database1 = client1.GetServer().GetDatabase(DBName1);
            var database2 = client1.GetServer().GetDatabase(DBName2);

            foreach (string DocName in DocNames)
            {
                var collects1 = database1.GetCollection(DocName);
                var collects2 = database2.GetCollection(DocName);
                var items = collects1.FindAll().ToList();
                foreach (var item in items)
                {
                    collects2.Insert(item); 
                }
            }
            

            MessageBox.Show("Done!");

        }
    }
}
