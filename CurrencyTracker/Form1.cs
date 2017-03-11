using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;
using System.Threading;

namespace CurrencyTracker
{
    public partial class Form1 : Form
    {
        private Api api;
        private DatabaseModule db;

        private String DataSource;

        public Form1()
        {
            InitializeComponent();

            api = new Api();

            DataSource = Properties.Settings.Default.Database1ConnectionString;

            db = new DatabaseModule(DataSource);
            db.TableName = "india";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the view to show details.
            listView1.View = View.Details;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.None;

            PopulateList();
            GetAverage();
            label_status.Text = "";
            label_average.Text = "";
        }

        private void ListAdd(String id, String value, String date)
        {

            ListViewItem item1 = new ListViewItem(id, 0);
            item1.SubItems.Add(value);
            item1.SubItems.Add(date);

            listView1.Items.AddRange(new ListViewItem[] { item1 });
        }

        private void btn_fetch_rupee_value_Click(object sender, EventArgs e)
        {
            Boolean status = false;
            float rupee = api.GetCurrencyBackground();

            if (rupee > 0)
            {
                status = db.AddData("rupee, date", new String[] { "" + rupee, "" + api.GetDateTime() });
            }

            if (status)
            {
                label_status.Text = "Done! " + DateTime.Now.ToString();
            }
            else
            {
                label_status.Text = "Error Updating currency " + DateTime.Now.ToString();
            }
            GetAverage();
        }

        private void btn_list_values_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            PopulateList();
            GetAverage();
        }

        /// <summary>
        /// Gets currency average
        /// </summary>
        private void GetAverage()
        {
            String text = "Average Currency:- ";
            String avg = api.AverageCurrency(db.GetCurrencyList()).ToString();
            label_average.Text = text + avg;
        }

        private void PopulateList()
        {
            String query = "SELECT * FROM " + db.TableName + " ORDER BY date DESC";

            using (SqlCeConnection c = new SqlCeConnection(DataSource))
            {
                c.Open();

                using (SqlCeCommand cmd = new SqlCeCommand(query, c))
                {
                    using (SqlCeDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String id = "" + reader.GetInt32(0);
                            String rupee = "" + reader.GetValue(1);
                            String dateTime = "" + reader.GetDateTime(2);

                            ListAdd(id, rupee, dateTime);
                        }
                        reader.Close();
                    }
                }

                c.Close();
            }
        }

        private void btn_write_to_file_Click(object sender, EventArgs e)
        {
            StringBuilder b = new StringBuilder();

            String query = "SELECT * FROM "+db.TableName;

            using (SqlCeConnection c = new SqlCeConnection(DataSource))
            {
                c.Open();

                using (SqlCeCommand cmd = new SqlCeCommand(query, c))
                {
                    using (SqlCeDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            b.AppendLine(""+reader.GetValue(1));
                        }
                        reader.Close();
                    }
                }

                c.Close();
            }

            api.FileWrite("currencyList", b.ToString());
        }

        private void btn_one_day_avg_Click(object sender, EventArgs e)
        {
            List<DateTime> dt = new List<DateTime>();

            

            label_average.Text = "One Day Avg: ";
        }


    }
}
