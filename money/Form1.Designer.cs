namespace money
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.forPrice = new System.Windows.Forms.NumericUpDown();
            this.forDays = new System.Windows.Forms.NumericUpDown();
            this.btn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.rub = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ue = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.forSell = new System.Windows.Forms.NumericUpDown();
            this.forBuy = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.forPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Days";
            // 
            // forPrice
            // 
            this.forPrice.DecimalPlaces = 2;
            this.forPrice.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.forPrice.Location = new System.Drawing.Point(194, 44);
            this.forPrice.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.forPrice.Minimum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.forPrice.Name = "forPrice";
            this.forPrice.Size = new System.Drawing.Size(120, 22);
            this.forPrice.TabIndex = 2;
            this.forPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.forPrice.ThousandsSeparator = true;
            this.forPrice.Value = new decimal(new int[] {
            72,
            0,
            0,
            0});
            // 
            // forDays
            // 
            this.forDays.Location = new System.Drawing.Point(194, 88);
            this.forDays.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.forDays.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.forDays.Name = "forDays";
            this.forDays.Size = new System.Drawing.Size(120, 22);
            this.forDays.TabIndex = 3;
            this.forDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.forDays.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn.Location = new System.Drawing.Point(194, 135);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(120, 30);
            this.btn.TabIndex = 4;
            this.btn.Text = "Calculate";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // chart1
            // 
            chartArea3.AxisX.Maximum = 10D;
            chartArea3.AxisX.Minimum = 0D;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(376, 44);
            this.chart1.Name = "chart1";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.IsValueShownAsLabel = true;
            series3.LabelFormat = "f4";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(863, 410);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "RUB :";
            // 
            // rub
            // 
            this.rub.AutoSize = true;
            this.rub.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rub.Location = new System.Drawing.Point(128, 185);
            this.rub.Name = "rub";
            this.rub.Size = new System.Drawing.Size(61, 22);
            this.rub.TabIndex = 7;
            this.rub.Text = "10000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(31, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "UE :";
            // 
            // ue
            // 
            this.ue.AutoSize = true;
            this.ue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ue.Location = new System.Drawing.Point(128, 235);
            this.ue.Name = "ue";
            this.ue.Size = new System.Drawing.Size(21, 22);
            this.ue.TabIndex = 9;
            this.ue.Text = "0";
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuy.Location = new System.Drawing.Point(160, 296);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(154, 30);
            this.btnBuy.TabIndex = 10;
            this.btnBuy.Text = "Buy UE (count)";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSell
            // 
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSell.Location = new System.Drawing.Point(160, 365);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(154, 30);
            this.btnSell.TabIndex = 11;
            this.btnSell.Text = "Sell UE (count)";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // forSell
            // 
            this.forSell.Location = new System.Drawing.Point(12, 371);
            this.forSell.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.forSell.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.forSell.Name = "forSell";
            this.forSell.Size = new System.Drawing.Size(120, 22);
            this.forSell.TabIndex = 12;
            this.forSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.forSell.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // forBuy
            // 
            this.forBuy.Location = new System.Drawing.Point(12, 302);
            this.forBuy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.forBuy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.forBuy.Name = "forBuy";
            this.forBuy.Size = new System.Drawing.Size(120, 22);
            this.forBuy.TabIndex = 13;
            this.forBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.forBuy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 532);
            this.Controls.Add(this.forBuy);
            this.Controls.Add(this.forSell);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.ue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.forDays);
            this.Controls.Add(this.forPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.forPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown forPrice;
        private System.Windows.Forms.NumericUpDown forDays;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ue;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.NumericUpDown forSell;
        private System.Windows.Forms.NumericUpDown forBuy;
    }
}

