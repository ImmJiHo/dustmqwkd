
namespace mysql
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.vath1_ct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Main_tm = new System.Windows.Forms.Timer(this.components);
            this.test_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BathSolution1_lb = new System.Windows.Forms.Label();
            this.Bath2_ct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BathSolution2_lb = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BathSolution3_lb = new System.Windows.Forms.Label();
            this.BathPoroduct1_lb = new System.Windows.Forms.Label();
            this.BathPoroduct2_lb = new System.Windows.Forms.Label();
            this.BathPoroduct3_lb = new System.Windows.Forms.Label();
            this.Bath2_tm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vath1_ct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bath2_ct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // vath1_ct
            // 
            chartArea1.Name = "ChartArea1";
            this.vath1_ct.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.vath1_ct.Legends.Add(legend1);
            this.vath1_ct.Location = new System.Drawing.Point(47, 65);
            this.vath1_ct.Name = "vath1_ct";
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 50;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.LabelBackColor = System.Drawing.Color.Transparent;
            series1.LabelBorderColor = System.Drawing.Color.WhiteSmoke;
            series1.LabelBorderWidth = 10;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.vath1_ct.Series.Add(series1);
            this.vath1_ct.Size = new System.Drawing.Size(456, 366);
            this.vath1_ct.TabIndex = 0;
            this.vath1_ct.Text = "chart1";
            // 
            // Main_tm
            // 
            this.Main_tm.Tick += new System.EventHandler(this.Main_tm_Tick);
            // 
            // test_tb
            // 
            this.test_tb.Location = new System.Drawing.Point(47, 23);
            this.test_tb.Name = "test_tb";
            this.test_tb.Size = new System.Drawing.Size(335, 25);
            this.test_tb.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(388, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BathSolution1_lb
            // 
            this.BathSolution1_lb.AutoSize = true;
            this.BathSolution1_lb.BackColor = System.Drawing.Color.Transparent;
            this.BathSolution1_lb.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BathSolution1_lb.Location = new System.Drawing.Point(240, 206);
            this.BathSolution1_lb.Name = "BathSolution1_lb";
            this.BathSolution1_lb.Size = new System.Drawing.Size(70, 28);
            this.BathSolution1_lb.TabIndex = 3;
            this.BathSolution1_lb.Text = "용액";
            // 
            // Bath2_ct
            // 
            chartArea2.Name = "ChartArea1";
            this.Bath2_ct.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.Bath2_ct.Legends.Add(legend2);
            this.Bath2_ct.Location = new System.Drawing.Point(546, 65);
            this.Bath2_ct.Name = "Bath2_ct";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Bath2_ct.Series.Add(series2);
            this.Bath2_ct.Size = new System.Drawing.Size(456, 366);
            this.Bath2_ct.TabIndex = 4;
            this.Bath2_ct.Text = "chart1";
            // 
            // BathSolution2_lb
            // 
            this.BathSolution2_lb.AutoSize = true;
            this.BathSolution2_lb.BackColor = System.Drawing.Color.Transparent;
            this.BathSolution2_lb.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BathSolution2_lb.Location = new System.Drawing.Point(743, 206);
            this.BathSolution2_lb.Name = "BathSolution2_lb";
            this.BathSolution2_lb.Size = new System.Drawing.Size(70, 28);
            this.BathSolution2_lb.TabIndex = 5;
            this.BathSolution2_lb.Text = "용액";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(1064, 65);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(456, 366);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // BathSolution3_lb
            // 
            this.BathSolution3_lb.AutoSize = true;
            this.BathSolution3_lb.BackColor = System.Drawing.Color.Transparent;
            this.BathSolution3_lb.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BathSolution3_lb.Location = new System.Drawing.Point(1258, 206);
            this.BathSolution3_lb.Name = "BathSolution3_lb";
            this.BathSolution3_lb.Size = new System.Drawing.Size(70, 28);
            this.BathSolution3_lb.TabIndex = 7;
            this.BathSolution3_lb.Text = "용액";
            // 
            // BathPoroduct1_lb
            // 
            this.BathPoroduct1_lb.AutoSize = true;
            this.BathPoroduct1_lb.BackColor = System.Drawing.Color.Transparent;
            this.BathPoroduct1_lb.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BathPoroduct1_lb.Location = new System.Drawing.Point(240, 261);
            this.BathPoroduct1_lb.Name = "BathPoroduct1_lb";
            this.BathPoroduct1_lb.Size = new System.Drawing.Size(70, 28);
            this.BathPoroduct1_lb.TabIndex = 8;
            this.BathPoroduct1_lb.Text = "제품";
            // 
            // BathPoroduct2_lb
            // 
            this.BathPoroduct2_lb.AutoSize = true;
            this.BathPoroduct2_lb.BackColor = System.Drawing.Color.Transparent;
            this.BathPoroduct2_lb.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BathPoroduct2_lb.Location = new System.Drawing.Point(743, 261);
            this.BathPoroduct2_lb.Name = "BathPoroduct2_lb";
            this.BathPoroduct2_lb.Size = new System.Drawing.Size(70, 28);
            this.BathPoroduct2_lb.TabIndex = 9;
            this.BathPoroduct2_lb.Text = "제품";
            // 
            // BathPoroduct3_lb
            // 
            this.BathPoroduct3_lb.AutoSize = true;
            this.BathPoroduct3_lb.BackColor = System.Drawing.Color.Transparent;
            this.BathPoroduct3_lb.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BathPoroduct3_lb.Location = new System.Drawing.Point(1258, 261);
            this.BathPoroduct3_lb.Name = "BathPoroduct3_lb";
            this.BathPoroduct3_lb.Size = new System.Drawing.Size(70, 28);
            this.BathPoroduct3_lb.TabIndex = 10;
            this.BathPoroduct3_lb.Text = "제품";
            // 
            // Bath2_tm
            // 
            this.Bath2_tm.Tick += new System.EventHandler(this.Bath2_tm_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 499);
            this.Controls.Add(this.BathPoroduct3_lb);
            this.Controls.Add(this.BathPoroduct2_lb);
            this.Controls.Add(this.BathPoroduct1_lb);
            this.Controls.Add(this.BathSolution3_lb);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.BathSolution2_lb);
            this.Controls.Add(this.Bath2_ct);
            this.Controls.Add(this.BathSolution1_lb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.test_tb);
            this.Controls.Add(this.vath1_ct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vath1_ct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bath2_ct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart vath1_ct;
        private System.Windows.Forms.Timer Main_tm;
        private System.Windows.Forms.TextBox test_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label BathSolution1_lb;
        private System.Windows.Forms.DataVisualization.Charting.Chart Bath2_ct;
        private System.Windows.Forms.Label BathSolution2_lb;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label BathSolution3_lb;
        private System.Windows.Forms.Label BathPoroduct1_lb;
        private System.Windows.Forms.Label BathPoroduct2_lb;
        private System.Windows.Forms.Label BathPoroduct3_lb;
        private System.Windows.Forms.Timer Bath2_tm;
    }
}

