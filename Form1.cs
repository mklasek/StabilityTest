

using System.Text;

namespace StabilityTest
{
    public partial class Form1 : Form
    {
        private Pinger Kevin = new Pinger();
        private int NumOfPings;
        private int WaitTime;

        public Form1()
        {
            InitializeComponent();
            NumOfPings = trackBarNumOfPings.Value;
            WaitTime = 800;
            lblTrackBar.Text = trackBarNumOfPings.Value.ToString();
            lblAddress.Text = Kevin.Destination;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnChangeAddress_Click(object sender, EventArgs e)
        {
            bool result = false;
            await Task.Run(() => result = Kevin.TestPingSetAddr(textBoxAddress.Text));

            if (result)
            {
                lblAddress.Text = Kevin.Destination;
            }
            else
                MessageBox.Show("Entered address is invalid or there is no connection to the Internet!", "Error");

        }

        private void trackBarNumOfPings_Scroll(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(trackBarNumOfPings, trackBarNumOfPings.Value.ToString());
            NumOfPings = trackBarNumOfPings.Value;
            lblTrackBar.Text = trackBarNumOfPings.Value.ToString();
        }

        private void radioWait1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWait1.Checked)
            {
                WaitTime = 300;
            }
        }

        private void radioWait2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWait2.Checked)
            {
                WaitTime = 500;
            }
        }

        private void radioWait3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioWait3.Checked)
            {
                WaitTime = 800;
            }
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            EnableControl(false);
            long[] results = new long[NumOfPings];

            var progress = new Progress<int>(percent =>
            {
                progressBar1.Value = percent;
            });

            //run test
            results = await Task.Run(() => results = Kevin.PingTest(NumOfPings, WaitTime, progress));

            int failed;
            List<long> filtered = new List<long>();

            //0 = failed ping
            //calculate things
            (failed, filtered) = Util.FilterZeros(results);
            double avg = Math.Round(filtered.Average(), 1);
            long med = Util.Median(filtered);
            (int spikes, double avgspike, double avggap) = Util.ProcessSpikes(filtered, WaitTime);
            avgspike = Math.Round(avgspike, 1);
            avggap = Math.Round(avggap, 1);

            //write labels
            lblAverage.Text = "Average = " + avg.ToString() + " ms";
            lblMedian.Text = "Median = " + med.ToString() + " ms";
            lblFailed.Text = "Failed pings = " + failed.ToString();
            lblSpikes.Text = "Spikes = " + spikes.ToString();
            lblAvgSpike.Text = "Average spike = " + avgspike.ToString() + " ms";
            lblGaps.Text = "Average sec between spikes = " + Math.Round(avggap / 1000d);

            //set label colors
            if (failed > 0) lblFailed.ForeColor = Color.Red;
            else lblFailed.ForeColor = Color.Green;

            if (avg < 50) lblAverage.ForeColor = Color.Green;
            else if (avg >= 50 && avg < 80) lblAverage.ForeColor = Color.Orange;
            else lblAverage.ForeColor = Color.Red;

            if (med < 50) lblMedian.ForeColor = Color.Green;
            else if (med >= 50 && med < 80) lblMedian.ForeColor = Color.Orange;
            else lblMedian.ForeColor = Color.Red;

            if (spikes < NumOfPings * 0.02f) lblSpikes.ForeColor = Color.Green;
            else if (spikes >= NumOfPings * 0.05f && spikes < NumOfPings * 0.1) lblSpikes.ForeColor = Color.Orange;
            else lblSpikes.ForeColor = Color.Red;

            if (avgspike > 0) lblAvgSpike.ForeColor = Color.Red;
            else lblAvgSpike.ForeColor= Color.Green;


            if (checkBoxSaveData.Checked)
            {
                var stringbuilder = new StringBuilder();

                stringbuilder.Append("Pinging " + Kevin.Destination);
                foreach (long point in results)
                {
                    stringbuilder.Append(point.ToString());
                    stringbuilder.Append("\n");
                }
                stringbuilder.Append("\n\n");
                File.WriteAllText(textBoxFileName.Text + ".txt", stringbuilder.ToString());
            }
            if (checkBoxSaveRes.Checked)
            {
                var stringbuilder = PackResults();

                if (checkBoxSaveData.Checked)
                    File.AppendAllText(textBoxFileName.Text + ".txt", stringbuilder.ToString());
                else
                    File.WriteAllText(textBoxFileName.Text + ".txt", stringbuilder.ToString());
            }

            EnableControl(true);
        }

        private void EnableControl(bool state)
        {
            radioWait1.Enabled = state;
            radioWait2.Enabled = state;
            radioWait3.Enabled = state;
            trackBarNumOfPings.Enabled = state;
            btnStart.Enabled = state;
            btnChangeAddress.Enabled = state;
            checkBoxSaveData.Enabled = state;
            checkBoxSaveRes.Enabled = state;
        }

        private StringBuilder PackResults()
        {
            var stringbuilder = new StringBuilder();

            stringbuilder.Append("Pinged " + Kevin.Destination + " " + NumOfPings + " times" + "\n");
            stringbuilder.Append(lblAverage.Text + "\n");
            stringbuilder.Append(lblMedian.Text + "\n");
            stringbuilder.Append(lblFailed.Text + "\n");
            stringbuilder.Append(lblSpikes.Text + "\n");
            stringbuilder.Append(lblAvgSpike.Text + "\n");
            stringbuilder.Append(lblGaps.Text + "\n");

            return stringbuilder;
        }

    }
}