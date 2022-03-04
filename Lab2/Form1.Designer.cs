
namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btStop = new System.Windows.Forms.Button();
            this.edRateD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.edRateE = new System.Windows.Forms.NumericUpDown();
            this.btPredict = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRateD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRateE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btStop);
            this.groupBox1.Controls.Add(this.edRateD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.edRateE);
            this.groupBox1.Controls.Add(this.btPredict);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(474, 34);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(144, 44);
            this.btStop.TabIndex = 7;
            this.btStop.Text = "Стоп";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // edRateD
            // 
            this.edRateD.DecimalPlaces = 2;
            this.edRateD.Location = new System.Drawing.Point(103, 69);
            this.edRateD.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.edRateD.Name = "edRateD";
            this.edRateD.Size = new System.Drawing.Size(120, 22);
            this.edRateD.TabIndex = 6;
            this.edRateD.Value = new decimal(new int[] {
            1044,
            0,
            0,
            65536});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Курс $";
            // 
            // edRateE
            // 
            this.edRateE.DecimalPlaces = 2;
            this.edRateE.Location = new System.Drawing.Point(103, 34);
            this.edRateE.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.edRateE.Name = "edRateE";
            this.edRateE.Size = new System.Drawing.Size(120, 22);
            this.edRateE.TabIndex = 3;
            this.edRateE.Value = new decimal(new int[] {
            12684,
            0,
            0,
            131072});
            // 
            // btPredict
            // 
            this.btPredict.Location = new System.Drawing.Point(308, 34);
            this.btPredict.Name = "btPredict";
            this.btPredict.Size = new System.Drawing.Size(144, 44);
            this.btPredict.TabIndex = 2;
            this.btPredict.Text = "Старт";
            this.btPredict.UseVisualStyleBackColor = true;
            this.btPredict.Click += new System.EventHandler(this.btPredict_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Курс €";
            // 
            // chart1
            // 
            chartArea7.AxisX.Minimum = 0D;
            chartArea7.AxisY.Minimum = 100D;
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(12, 125);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series13.BorderWidth = 3;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.IsValueShownAsLabel = true;
            series13.LabelFormat = "C";
            series13.Legend = "Legend1";
            series13.Name = "Курс Евро";
            series13.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series14.BorderWidth = 3;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.IsValueShownAsLabel = true;
            series14.LabelFormat = "C";
            series14.Legend = "Legend1";
            series14.Name = "Курс Доллара";
            series14.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Size = new System.Drawing.Size(973, 503);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 673);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edRateD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edRateE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown edRateE;
        private System.Windows.Forms.Button btPredict;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown edRateD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btStop;
    }
}

