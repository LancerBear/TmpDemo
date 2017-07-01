using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TmpDemo
{
    public partial class Form1 : Form
    {
        private List<DataEntity> curList = null;
        private float listViewMin = -2;
        private float listViewMax = 40;

        private void InitListView( List<DataEntity> dataList)
        {
            listView1.Clear();
            listView1.Columns.Add("数据编号", 120, HorizontalAlignment.Left);
            listView1.Columns.Add("添加时间", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("温度数据(℃)", 145, HorizontalAlignment.Left);
            listView1.Columns.Add("节点编号", 100   , HorizontalAlignment.Left);
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.BeginUpdate();
            foreach (DataEntity d in dataList)
            {
                if (1 == d.getValid() && true == d.shown)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = d.getID().ToString();
                    lvi.SubItems.Add(d.getAddTime());
                    lvi.SubItems.Add(d.getTemperature().ToString());
                    lvi.SubItems.Add(d.getDevID());
                    listView1.Items.Add(lvi);
                }
            }
            listView1.EndUpdate();
        }

        private void updateListView(List<DataEntity> list)
        {
			foreach (DataEntity d in Program.dataList)
			{
				if (d.getTemperature() < listViewMin || d.getTemperature() > listViewMax)
				{
					d.shown = false;
				}
				else
				{
					d.shown = true;
				}
			}
			foreach(List<DataEntity> l in Program.devList)
			{
				foreach(DataEntity d in l)
				{
					if (d.getTemperature() < listViewMin || d.getTemperature() > listViewMax)
					{
						d.shown = false;
					}
					else
					{
						d.shown = true;
					}
				}
			}
            InitListView(list);
        }

        public Form1() 
        {
            InitializeComponent();
            ConneDB connDB = new ConneDB();
            Program.dataList = connDB.getList();
            int max = 0;
            foreach (DataEntity d in Program.dataList)
            {
                if (int.Parse(d.getDevID()) > max)
                {
                    max = int.Parse(d.getDevID());
                }
            }
            Program.devNum = max;
            //MessageBox.Show(Program.devNum.ToString());
            for (int i = 0; i < Program.devNum; i++)
            {
                List<DataEntity> list = new List<DataEntity>();
                Program.devList.Add(list);
            }

            foreach (DataEntity d in Program.dataList)
            {
                string devID = d.getDevID();
                int dev = int.Parse(devID);
                Console.WriteLine(dev);
                Program.devList.ElementAt(dev - 1).Add(d);
            }

            for (int i = 1; i <= Program.devNum; i++)
            {
                string str = i.ToString();
                devFilter.Items.Add(str);
            }
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Program.dataList == null)
                MessageBox.Show("数据集为空！");
            else
            {
                InitListView(Program.dataList);
            }
            devFilter.SelectedIndex = 0;
            minPicker.Enabled = false;
            maxPicker.Enabled = false;
            for (int i = 0; i < Program.devNum; i++)
            {
				int j = i + 1;
                checkedListBox1.Items.Add("节点" + j);
				checkedListBox1.SetItemChecked(i,true);
				chart1.Series.Add("节点" + j);
				chart1.Series[i].ChartType = SeriesChartType.Spline;
            }
			for(int i = 0; i < Program.devNum; i++)
			{
				foreach(DataEntity d in Program.devList[i])
				{
					chart1.Series[i].Points.AddY(d.getTemperature());
				}
				chart1.Series[i].BorderWidth = 4;
				chart1.Series[i].MarkerBorderWidth = 4;
				chart1.Series[i].MarkerStyle = MarkerStyle.Triangle;
			}
			chart1.ChartAreas[0].AxisY.IsStartedFromZero = false;
			
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(tabControl1.SelectedIndex)
            {
                case 0:
                    //MessageBox.Show("page 1");
                    break;
                case 1:
                    //MessageBox.Show("Page2");
                    break;
                default:
                    break;
            }
        }

        private void devFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(devFilter.Text)
            {
                case "所有":
                    InitListView(Program.dataList);
                    curList = Program.dataList;
                    break;
                default:
                    InitListView(Program.devList.ElementAt(int.Parse(devFilter.Text) - 1));
                    curList = Program.devList.ElementAt(int.Parse(devFilter.Text) - 1);
                    break;
            }

        }

        private void minPicker_ValueChanged(object sender, EventArgs e)
        {
			float temp = (float)minPicker.Value;
			if (temp > listViewMax)
			{
				MessageBox.Show("最低温数值必须不大于最高温！");
				minPicker.Value = -2;
			}
			else
			{
				listViewMin = (float)minPicker.Value;
				updateListView(curList);
			}
        }

        private void maxPicker_ValueChanged(object sender, EventArgs e)
        {
			float temp = (float)maxPicker.Value;
			if (temp < listViewMin)
			{
				MessageBox.Show("最高温数值必须不小于最低温！");
				maxPicker.Value = 40;
			}
			else
			{
				listViewMax = (float)maxPicker.Value;
				updateListView(curList);
			}
        }

        private void enableTmpFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (enableTmpFilter.Checked == true)
            {
                minPicker.Enabled = true;
                maxPicker.Enabled = true;
                updateListView(curList);
            }
            else
            {
                minPicker.Enabled = false;
                maxPicker.Enabled = false;
                foreach(DataEntity d in curList)
                {
                    d.shown = true;
                }
                InitListView(curList);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			//for (int i = 0; i < Program.devNum; i++)
			//{
			//	if (checkedListBox1.GetItemChecked(i) == true)
			//	{
			//		chart1.Series[i].Enabled = true;
			//		Console.WriteLine(i.ToString() + " enable");
			//	}
			//	else
			//	{
			//		chart1.Series[i].Enabled = false;
			//		Console.WriteLine(i.ToString() + " disable");
			//	}
			//}
        }

		private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < Program.devNum; i++)
			{
				if (checkedListBox1.GetItemChecked(i) == true)
				{
					chart1.Series[i].Enabled = true;
					Console.WriteLine(i.ToString() + " enable");
				}
				else
				{
					chart1.Series[i].Enabled = false;
					Console.WriteLine(i.ToString() + " disable");
				}
			}
		}

    }
}
