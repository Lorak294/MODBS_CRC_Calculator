using System.Diagnostics;

namespace MODBS_CRC_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcCRCBtn_Click(object sender, EventArgs e)
        {
            int iterCount = (int)iterationCountInput.Value;
            byte[] bytes = CRCCalculator.HexStrToByteArray(bytesInput.Text);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            ushort crc = CRCCalculator.CalculateUsingTable(bytes);
            watch.Stop();
            decimal elapsedMs = watch.ElapsedTicks / (decimal)Stopwatch.Frequency * 1000;

            resultLabel.Text = crc.ToString("X");
            totalTimeLabel.Text = elapsedMs.ToString();
            singleTimeLabel.Text = (elapsedMs / iterCount).ToString();
        }

        private void bytesInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            char[] allowedChars = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'];

            foreach (char character in bytesInput.Text.ToUpper().ToArray())
            {
                if (!allowedChars.Contains(character))
                {
                    MessageBox.Show(string.Format("'{0}' is not a hexadecimal character", character));
                    e.Cancel = true;
                    break;
                }
            }
        }
    }
}
