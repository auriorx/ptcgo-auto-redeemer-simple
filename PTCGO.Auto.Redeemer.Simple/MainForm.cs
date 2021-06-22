using PTCGO.Auto.Redeemer.Simple.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace PTCGO.Auto.Redeemer.Simple
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(7, 27, 51);
            this.resolutionComboBox.Items.AddRange(Settings.Resolutions.Select(_ => _.ResolutionName).ToArray());
        }

        private void redeemButton_Click(object sender, EventArgs e)
        {
            AutoRedeem();
        }

        private void AutoRedeem()
        {
            if (string.IsNullOrEmpty(resolutionComboBox.Text))
            {
                MessageBox.Show("Please select a resolution.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(codesTextBox.Text))
            {
                MessageBox.Show("Please insert some codes.", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var codes = new List<string>(this.codesTextBox.Text.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries)).Where(code => !code.Equals(string.Empty)).ToList();
            var clickEvents = Settings.Resolutions.First(_ => _.ResolutionName == resolutionComboBox.Text).ClickEvents;

            var codeRedeemerCount = 0;
            Thread.Sleep(500);
            foreach (var code in codes)
            {
                // Click on the box where we insert the code
                Global.SimulateClick(clickEvents.First(x => x.Name.Equals("clickOnCodeBox")).Coordinates.x, clickEvents.First(x => x.Name.Equals("clickOnCodeBox")).Coordinates.y);
                Thread.Sleep(250);

                // Type the code
                SendKeys.Send(code);
                Thread.Sleep(250);

                // Click on the box to add the code
                Global.SimulateClick(clickEvents.First(x => x.Name.Equals("clickOnAddCode")).Coordinates.x, clickEvents.First(x => x.Name.Equals("clickOnAddCode")).Coordinates.y);                
                Thread.Sleep(250);

                // In case of duplicates, always try to dismiss the error so we can always continue to the next code
                Global.SimulateClick(clickEvents.First(x => x.Name.Equals("clickOnDuplicateErrorOkButton")).Coordinates.x, clickEvents.First(x => x.Name.Equals("clickOnDuplicateErrorOkButton")).Coordinates.y);                
                Thread.Sleep(750);

                codeRedeemerCount++;

                if (codeRedeemerCount == 10)
                {
                    // Handle submitting codeCount
                    Global.SimulateClick(clickEvents.First(x => x.Name.Equals("clickOnSubmitCodes")).Coordinates.x, clickEvents.First(x => x.Name.Equals("clickOnSubmitCodes")).Coordinates.y);
                    
                    Thread.Sleep(1000);
                    Global.SimulateClick(clickEvents.First(x => x.Name.Equals("clickOnSubmitCodesDoneButton")).Coordinates.x, clickEvents.First(x => x.Name.Equals("clickOnSubmitCodesDoneButton")).Coordinates.y);                    
                    Thread.Sleep(750);
                    codeRedeemerCount = 0;
                }                
            }
        }
    }
}
