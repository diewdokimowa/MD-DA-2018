using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private decimal applications;

        public Form2(decimal applications)
        {
            this.applications = applications;
            InitializeComponent();

            runModel();
        }

        private void runModel()
        {
            var process = new Process();
            process.StartInfo.FileName = "Rscript";
            process.StartInfo.Arguments = $"--vanilla ../../model.R --applications {applications}";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;

            process.Start();
            process.WaitForExit();
            var result = process.StandardOutput.ReadToEnd();
            var error = process.StandardError.ReadToEnd();
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show(error, "Произошла ошибка", MessageBoxButtons.OK);
                return;
            }
            parseOutput(result);
        }

        private void parseOutput(string output)
        {
            var lines = output.Split('\n');
            
            var line11 = lines[11].Trim().Split(' ');
            pValue.Text = line11[line11.Length - 2];

            var line16 = lines[16].Trim().Split(',');
            rSquaredValue.Text = line16[0].Split(' ').Last();
            adjustedRSquaredValue.Text = line16[1].Split(' ').Last();

            var line19 = lines[19].Trim().Split(' ');
            commentsValue.Text = line19.Last();

            var line20 = lines[20].Trim().Split(' ');
            maeValue.Text = line20.Last();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
