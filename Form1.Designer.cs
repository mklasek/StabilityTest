namespace StabilityTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.btnChangeAddress = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarNumOfPings = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.radioWait1 = new System.Windows.Forms.RadioButton();
            this.radioWait2 = new System.Windows.Forms.RadioButton();
            this.radioWait3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblDebug = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAvgSpike = new System.Windows.Forms.Label();
            this.lblGaps = new System.Windows.Forms.Label();
            this.lblFailed = new System.Windows.Forms.Label();
            this.lblSpikes = new System.Windows.Forms.Label();
            this.lblMedian = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblTrackBar = new System.Windows.Forms.Label();
            this.checkBoxSaveData = new System.Windows.Forms.CheckBox();
            this.checkBoxSaveRes = new System.Windows.Forms.CheckBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumOfPings)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddress
            // 
            this.lblAddress.BackColor = System.Drawing.SystemColors.Window;
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(71, 66);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(201, 49);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "seznam.cz";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxAddress.Location = new System.Drawing.Point(391, 72);
            this.textBoxAddress.MaxLength = 30;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(249, 35);
            this.textBoxAddress.TabIndex = 5;
            // 
            // btnChangeAddress
            // 
            this.btnChangeAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChangeAddress.Location = new System.Drawing.Point(664, 68);
            this.btnChangeAddress.Name = "btnChangeAddress";
            this.btnChangeAddress.Size = new System.Drawing.Size(114, 44);
            this.btnChangeAddress.TabIndex = 6;
            this.btnChangeAddress.Text = "Enter";
            this.btnChangeAddress.UseVisualStyleBackColor = true;
            this.btnChangeAddress.Click += new System.EventHandler(this.btnChangeAddress_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Address to ping";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(372, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Address change";
            // 
            // trackBarNumOfPings
            // 
            this.trackBarNumOfPings.LargeChange = 10;
            this.trackBarNumOfPings.Location = new System.Drawing.Point(50, 206);
            this.trackBarNumOfPings.Maximum = 300;
            this.trackBarNumOfPings.Minimum = 10;
            this.trackBarNumOfPings.Name = "trackBarNumOfPings";
            this.trackBarNumOfPings.Size = new System.Drawing.Size(328, 45);
            this.trackBarNumOfPings.TabIndex = 9;
            this.trackBarNumOfPings.TickFrequency = 5;
            this.trackBarNumOfPings.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarNumOfPings.Value = 60;
            this.trackBarNumOfPings.Scroll += new System.EventHandler(this.trackBarNumOfPings_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Number of pings";
            // 
            // radioWait1
            // 
            this.radioWait1.AutoSize = true;
            this.radioWait1.Location = new System.Drawing.Point(45, 26);
            this.radioWait1.Name = "radioWait1";
            this.radioWait1.Size = new System.Drawing.Size(80, 25);
            this.radioWait1.TabIndex = 11;
            this.radioWait1.Text = "300 ms";
            this.radioWait1.UseVisualStyleBackColor = true;
            this.radioWait1.CheckedChanged += new System.EventHandler(this.radioWait1_CheckedChanged);
            // 
            // radioWait2
            // 
            this.radioWait2.AutoSize = true;
            this.radioWait2.Location = new System.Drawing.Point(45, 54);
            this.radioWait2.Name = "radioWait2";
            this.radioWait2.Size = new System.Drawing.Size(80, 25);
            this.radioWait2.TabIndex = 12;
            this.radioWait2.Text = "500 ms";
            this.radioWait2.UseVisualStyleBackColor = true;
            this.radioWait2.CheckedChanged += new System.EventHandler(this.radioWait2_CheckedChanged);
            // 
            // radioWait3
            // 
            this.radioWait3.AutoSize = true;
            this.radioWait3.Checked = true;
            this.radioWait3.Location = new System.Drawing.Point(45, 82);
            this.radioWait3.Name = "radioWait3";
            this.radioWait3.Size = new System.Drawing.Size(80, 25);
            this.radioWait3.TabIndex = 13;
            this.radioWait3.TabStop = true;
            this.radioWait3.Text = "800 ms";
            this.radioWait3.UseVisualStyleBackColor = true;
            this.radioWait3.CheckedChanged += new System.EventHandler(this.radioWait3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioWait3);
            this.groupBox1.Controls.Add(this.radioWait2);
            this.groupBox1.Controls.Add(this.radioWait1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(26, 257);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 116);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wait between pings";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(50, 407);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(838, 36);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 15;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(683, 138);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(205, 82);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start test";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDebug.Location = new System.Drawing.Point(804, 462);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(61, 15);
            this.lblDebug.TabIndex = 17;
            this.lblDebug.Text = "debugtext";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAvgSpike);
            this.groupBox2.Controls.Add(this.lblGaps);
            this.groupBox2.Controls.Add(this.lblFailed);
            this.groupBox2.Controls.Add(this.lblSpikes);
            this.groupBox2.Controls.Add(this.lblMedian);
            this.groupBox2.Controls.Add(this.lblAverage);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(276, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 138);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // lblAvgSpike
            // 
            this.lblAvgSpike.AutoSize = true;
            this.lblAvgSpike.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAvgSpike.Location = new System.Drawing.Point(333, 89);
            this.lblAvgSpike.Name = "lblAvgSpike";
            this.lblAvgSpike.Size = new System.Drawing.Size(151, 20);
            this.lblAvgSpike.TabIndex = 5;
            this.lblAvgSpike.Text = "Average spike = 0 ms";
            // 
            // lblGaps
            // 
            this.lblGaps.AutoSize = true;
            this.lblGaps.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGaps.Location = new System.Drawing.Point(333, 45);
            this.lblGaps.Name = "lblGaps";
            this.lblGaps.Size = new System.Drawing.Size(218, 20);
            this.lblGaps.TabIndex = 4;
            this.lblGaps.Text = "Average ms between spikes = 0";
            // 
            // lblFailed
            // 
            this.lblFailed.AutoSize = true;
            this.lblFailed.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFailed.Location = new System.Drawing.Point(183, 45);
            this.lblFailed.Name = "lblFailed";
            this.lblFailed.Size = new System.Drawing.Size(74, 20);
            this.lblFailed.TabIndex = 3;
            this.lblFailed.Text = "Failed = 0";
            // 
            // lblSpikes
            // 
            this.lblSpikes.AutoSize = true;
            this.lblSpikes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSpikes.Location = new System.Drawing.Point(183, 89);
            this.lblSpikes.Name = "lblSpikes";
            this.lblSpikes.Size = new System.Drawing.Size(77, 20);
            this.lblSpikes.TabIndex = 2;
            this.lblSpikes.Text = "Spikes = 0";
            // 
            // lblMedian
            // 
            this.lblMedian.AutoSize = true;
            this.lblMedian.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMedian.Location = new System.Drawing.Point(21, 89);
            this.lblMedian.Name = "lblMedian";
            this.lblMedian.Size = new System.Drawing.Size(108, 20);
            this.lblMedian.TabIndex = 1;
            this.lblMedian.Text = "Median = 0 ms";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAverage.Location = new System.Drawing.Point(19, 45);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(113, 20);
            this.lblAverage.TabIndex = 0;
            this.lblAverage.Text = "Average = 0 ms";
            // 
            // lblTrackBar
            // 
            this.lblTrackBar.AutoSize = true;
            this.lblTrackBar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTrackBar.Location = new System.Drawing.Point(384, 206);
            this.lblTrackBar.Name = "lblTrackBar";
            this.lblTrackBar.Size = new System.Drawing.Size(25, 20);
            this.lblTrackBar.TabIndex = 19;
            this.lblTrackBar.Text = "60";
            // 
            // checkBoxSaveData
            // 
            this.checkBoxSaveData.AutoSize = true;
            this.checkBoxSaveData.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSaveData.Location = new System.Drawing.Point(379, 140);
            this.checkBoxSaveData.Name = "checkBoxSaveData";
            this.checkBoxSaveData.Size = new System.Drawing.Size(136, 24);
            this.checkBoxSaveData.TabIndex = 20;
            this.checkBoxSaveData.Text = "Save data to file";
            this.checkBoxSaveData.UseVisualStyleBackColor = true;
            // 
            // checkBoxSaveRes
            // 
            this.checkBoxSaveRes.AutoSize = true;
            this.checkBoxSaveRes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxSaveRes.Location = new System.Drawing.Point(522, 140);
            this.checkBoxSaveRes.Name = "checkBoxSaveRes";
            this.checkBoxSaveRes.Size = new System.Drawing.Size(148, 24);
            this.checkBoxSaveRes.TabIndex = 21;
            this.checkBoxSaveRes.Text = "Save results to file";
            this.checkBoxSaveRes.UseVisualStyleBackColor = true;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxFileName.Location = new System.Drawing.Point(522, 170);
            this.textBoxFileName.MaxLength = 30;
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(143, 33);
            this.textBoxFileName.TabIndex = 22;
            this.textBoxFileName.Text = "data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(448, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Filename";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(914, 498);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.checkBoxSaveRes);
            this.Controls.Add(this.checkBoxSaveData);
            this.Controls.Add(this.lblTrackBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarNumOfPings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangeAddress);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.lblAddress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarNumOfPings)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblAddress;
        private TextBox textBoxAddress;
        private Button btnChangeAddress;
        private Label label1;
        private Label label2;
        private TrackBar trackBarNumOfPings;
        private Label label3;
        private ToolTip toolTip1;
        private RadioButton radioWait1;
        private RadioButton radioWait2;
        private RadioButton radioWait3;
        private GroupBox groupBox1;
        private ProgressBar progressBar1;
        private Button btnStart;
        private Label lblDebug;
        private GroupBox groupBox2;
        private Label lblGaps;
        private Label lblFailed;
        private Label lblSpikes;
        private Label lblMedian;
        private Label lblAverage;
        private Label lblAvgSpike;
        private Label lblTrackBar;
        private CheckBox checkBoxSaveData;
        private CheckBox checkBoxSaveRes;
        private TextBox textBoxFileName;
        private Label label4;
    }
}