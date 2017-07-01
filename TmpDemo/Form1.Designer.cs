using System.Windows.Forms;
namespace TmpDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.chartTabPage = new System.Windows.Forms.TabPage();
			this.panel2 = new System.Windows.Forms.Panel();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.filterTabPage = new System.Windows.Forms.TabPage();
			this.panel4 = new System.Windows.Forms.Panel();
			this.enableTmpFilter = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.maxPicker = new System.Windows.Forms.NumericUpDown();
			this.minPicker = new System.Windows.Forms.NumericUpDown();
			this.devLabel = new System.Windows.Forms.Label();
			this.devFilter = new System.Windows.Forms.ComboBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.tabControl1.SuspendLayout();
			this.chartTabPage.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.filterTabPage.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxPicker)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minPicker)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.chartTabPage);
			this.tabControl1.Controls.Add(this.filterTabPage);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(734, 461);
			this.tabControl1.TabIndex = 4;
			this.tabControl1.Tag = "";
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// chartTabPage
			// 
			this.chartTabPage.BackColor = System.Drawing.Color.LightGray;
			this.chartTabPage.Controls.Add(this.panel2);
			this.chartTabPage.Controls.Add(this.panel1);
			this.chartTabPage.Location = new System.Drawing.Point(4, 22);
			this.chartTabPage.Name = "chartTabPage";
			this.chartTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.chartTabPage.Size = new System.Drawing.Size(726, 435);
			this.chartTabPage.TabIndex = 0;
			this.chartTabPage.Text = "图形";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.checkedListBox1);
			this.panel2.Location = new System.Drawing.Point(530, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(193, 429);
			this.panel2.TabIndex = 1;
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(189, 425);
			this.checkedListBox1.TabIndex = 0;
			this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
			this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.checkedListBox1_SelectedValueChanged);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.chart1);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(523, 429);
			this.panel1.TabIndex = 0;
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(0, 0);
			this.chart1.Name = "chart1";
			this.chart1.Size = new System.Drawing.Size(519, 425);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// filterTabPage
			// 
			this.filterTabPage.BackColor = System.Drawing.Color.LightGray;
			this.filterTabPage.Controls.Add(this.panel4);
			this.filterTabPage.Controls.Add(this.panel3);
			this.filterTabPage.Location = new System.Drawing.Point(4, 22);
			this.filterTabPage.Name = "filterTabPage";
			this.filterTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.filterTabPage.Size = new System.Drawing.Size(726, 435);
			this.filterTabPage.TabIndex = 1;
			this.filterTabPage.Text = "筛选";
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel4.Controls.Add(this.enableTmpFilter);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.maxPicker);
			this.panel4.Controls.Add(this.minPicker);
			this.panel4.Controls.Add(this.devLabel);
			this.panel4.Controls.Add(this.devFilter);
			this.panel4.Location = new System.Drawing.Point(530, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(193, 429);
			this.panel4.TabIndex = 1;
			// 
			// enableTmpFilter
			// 
			this.enableTmpFilter.AutoSize = true;
			this.enableTmpFilter.Location = new System.Drawing.Point(41, 196);
			this.enableTmpFilter.Name = "enableTmpFilter";
			this.enableTmpFilter.Size = new System.Drawing.Size(96, 16);
			this.enableTmpFilter.TabIndex = 7;
			this.enableTmpFilter.Text = "温度筛选(℃)";
			this.enableTmpFilter.UseVisualStyleBackColor = true;
			this.enableTmpFilter.CheckedChanged += new System.EventHandler(this.enableTmpFilter_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 293);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 6;
			this.label3.Text = "最高温";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 228);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "最低温";
			// 
			// maxPicker
			// 
			this.maxPicker.Location = new System.Drawing.Point(37, 308);
			this.maxPicker.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.maxPicker.Name = "maxPicker";
			this.maxPicker.Size = new System.Drawing.Size(120, 21);
			this.maxPicker.TabIndex = 4;
			this.maxPicker.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
			this.maxPicker.ValueChanged += new System.EventHandler(this.maxPicker_ValueChanged);
			// 
			// minPicker
			// 
			this.minPicker.Location = new System.Drawing.Point(37, 243);
			this.minPicker.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.minPicker.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
			this.minPicker.Name = "minPicker";
			this.minPicker.Size = new System.Drawing.Size(120, 21);
			this.minPicker.TabIndex = 3;
			this.minPicker.Value = new decimal(new int[] {
            2,
            0,
            0,
            -2147483648});
			this.minPicker.ValueChanged += new System.EventHandler(this.minPicker_ValueChanged);
			// 
			// devLabel
			// 
			this.devLabel.AutoSize = true;
			this.devLabel.Location = new System.Drawing.Point(66, 47);
			this.devLabel.Name = "devLabel";
			this.devLabel.Size = new System.Drawing.Size(53, 12);
			this.devLabel.TabIndex = 1;
			this.devLabel.Text = "筛选节点";
			// 
			// devFilter
			// 
			this.devFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.devFilter.FormattingEnabled = true;
			this.devFilter.Items.AddRange(new object[] {
            "所有"});
			this.devFilter.Location = new System.Drawing.Point(37, 74);
			this.devFilter.Name = "devFilter";
			this.devFilter.Size = new System.Drawing.Size(121, 20);
			this.devFilter.TabIndex = 0;
			this.devFilter.SelectedIndexChanged += new System.EventHandler(this.devFilter_SelectedIndexChanged);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel3.Controls.Add(this.listView1);
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(523, 429);
			this.panel3.TabIndex = 0;
			// 
			// listView1
			// 
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(519, 425);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 461);
			this.Controls.Add(this.tabControl1);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "温度监测模块";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl1.ResumeLayout(false);
			this.chartTabPage.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.filterTabPage.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.maxPicker)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minPicker)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage chartTabPage;
        private System.Windows.Forms.TabPage filterTabPage;
        private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox devFilter;
        private System.Windows.Forms.Label devLabel;
        private Label label3;
        private Label label2;
        private NumericUpDown maxPicker;
        private NumericUpDown minPicker;
        private CheckBox enableTmpFilter;
        private CheckedListBox checkedListBox1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

    }
}

