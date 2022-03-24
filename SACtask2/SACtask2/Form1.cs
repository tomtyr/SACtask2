using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SACtask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();

                float total = 0f; ;

                foreach (string line in lines)
                {

                    List<string> fields = line.Split(',').ToList();
                    float profit;
                    string salePrice = fields[5];
                    float purchasedPrice = float.Parse(fields[4]);

                    if (float.TryParse(salePrice, out float _saleprice))
                    {
                        profit = _saleprice - purchasedPrice;
                    }
                    else
                    {
                        profit = purchasedPrice * -1;
                    }
                    total += profit;
                    fields.Add(profit.ToString());
                    table.Rows.Add(fields.ToArray());

                }
                table.Rows.Add();
                int rowCount = table.Rows.Count;
                table.Rows[rowCount - 1].Cells[5].Value = "Total";
                table.Rows[rowCount - 1].Cells[6].Value = $"${total.ToString()}";









            }
        }
    }
}
