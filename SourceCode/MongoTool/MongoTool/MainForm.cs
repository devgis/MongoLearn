using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MongoTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        List<string> systables = new List<string> { "startup_log", "system.indexes" };

        private void LoadConfig()
        {
            tbConStr1.Text = System.Configuration.ConfigurationManager.AppSettings["Mongo1"];
            tbConStr2.Text = System.Configuration.ConfigurationManager.AppSettings["Mongo2"];

            tbDBName1.Text = System.Configuration.ConfigurationManager.AppSettings["DBName1"];
            tbDBName2.Text = System.Configuration.ConfigurationManager.AppSettings["DBName2"];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadConfig();
        }

        private bool TestDBCon(string conStr, string DBNAMe)
        {
            try
            {
                var client = new MongoClient(conStr);
                var database = client.GetServer().GetDatabase(DBNAMe);

                var list =database.GetCollectionNames();
                if(list!=null&&list.Count()>0)
                {
                    return true;
                }
            }
            catch(Exception ex)
            {
                Loger.WriteLog(ex);
            }
            return false;
        }

        private void GetDocuments(string conStr, string DBName)
        {
            if (TestDBCon(conStr, DBName))
            {
                try
                {
                    dgvDocuments.Rows.Clear();
                    var client = new MongoClient(conStr);
                    var database = client.GetServer().GetDatabase(DBName);

                    var list = database.GetCollectionNames();
                    foreach(string docname in list)
                    {
                        if (!systables.Contains(docname)) //過濾系統表
                        {
                            int index = dgvDocuments.Rows.Add();
                            (dgvDocuments.Rows[index].Cells["CSelect"] as DataGridViewCheckBoxCell).Value = true;
                            dgvDocuments.Rows[index].Cells["CDocumentName"].Value = docname;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Loger.WriteLog(ex);
                }
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
                try
                {
                    if ((bool)(row.Cells["CSelect"] as DataGridViewCheckBoxCell).Value == true)
                    {
                        list.Add(row.Cells["CDocumentName"].Value.ToString());
                    }
                }
                catch
                { }
               
            }
            return list;
        }

        private void SyncDocuments(string conStr1,string conStr2,string DBName1, string DBName2, List<string> DocNames)
        {
            if (DocNames == null || DocNames.Count <= 0)
            {
                MessageHelper.ShowError("無需同步！");
                return;
            }
            var client1 = new MongoClient(conStr1);
            var client2 = new MongoClient(conStr2);
            var database1 = client1.GetServer().GetDatabase(DBName1);
            var database2 = client1.GetServer().GetDatabase(DBName2);

            foreach (string DocName in DocNames)
            {
                ShowLog("開始同步文檔" + DocName);
                var collects1 = database1.GetCollection(DocName);
                var collects2 = database2.GetCollection(DocName);
                var items = collects1.FindAll().ToList();
                foreach (var item in items)
                {
                    try
                    {
                        collects2.Insert(item);
                    }
                    catch (Exception ex)
                    {
                        ShowLog("同步數據錯誤:" + ex+" {"+ item.ToString()+ "}");
                    }
                }
            }

            ShowLog("同步完成！");

        }

        public void ShowLog(string content, bool writelog = true)
        {
            if (writelog)
            {
                Loger.WriteLog(content);
            }
            tbLogs.Invoke((EventHandler)(delegate
            {
                if (tbLogs.Text.Length >= 65535)
                {
                    tbLogs.Clear();
                }
                tbLogs.Text += (DateTime.Now.ToString("HH:mm:ss") + ":" + content + "\r\n"); //yyyy-MM-dd 

                //滚动到底部
                tbLogs.Select(tbLogs.Text.Length, 0);
                tbLogs.ScrollToCaret();

            }));
        }

        private void btTest1_Click(object sender, EventArgs e)
        {
            if (TestDBCon(tbConStr1.Text, tbDBName1.Text))
            {
                MessageHelper.ShowInfo("鏈接成功！");
            }
            else
            {
                MessageHelper.ShowError("鏈接失敗！");
            }
        }

        private void btTest2_Click(object sender, EventArgs e)
        {
            if (TestDBCon(tbConStr2.Text, tbDBName2.Text))
            {
                MessageHelper.ShowInfo("鏈接成功！");
            }
            else
            {
                MessageHelper.ShowError("鏈接失敗！");
            }
        }

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDocuments.Rows)
            {
                (row.Cells["CSelect"] as DataGridViewCheckBoxCell).Value = true;
            }
        }

        private void btDisselectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvDocuments.Rows)
            {
                (row.Cells["CSelect"] as DataGridViewCheckBoxCell).Value = false;
            }
        }


        private void btReadDocs_Click(object sender, EventArgs e)
        {
            try
            {
                GetDocuments(tbConStr1.Text, tbDBName1.Text);
            }
            catch(Exception ex)
            {
                MessageHelper.ShowError("讀取錯誤：" + ex.Message);
            }
        }

        private void btSync_Click(object sender, EventArgs e)
        {
            if (MessageHelper.ShowQuestion("系統將耗費較長時間進行同步，同步過程中請勿關閉程序或者斷開網絡，確定開始同步？"))
            {
                ThreadPool.QueueUserWorkItem(o => {
                    EnabledButtons(false);
                    try
                    {
                        SyncDocuments(tbConStr1.Text, tbConStr2.Text, tbDBName1.Text, tbDBName2.Text, GetDocuments());
                    }
                    catch (Exception ex)
                    {
                        MessageHelper.ShowError("讀取錯誤：" + ex.Message);
                    }
                    EnabledButtons(true);
                });
            }
        }

        private void EnabledButtons(bool enabled)
        {
            this.Invoke((EventHandler)(delegate
            {
                btTest1.Enabled = enabled;
                btTest2.Enabled = enabled;
                btReadDocs.Enabled = enabled;
                btSync.Enabled = enabled;
                btDisselectAll.Enabled = enabled;
                btSelectAll.Enabled = enabled;

            }));
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageHelper.ShowQuestion("如果同步中關閉程序可能導致同步異常，確定退出程序？"))
            {
                //Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
