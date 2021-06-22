
namespace PTCGO.Auto.Redeemer.Simple
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.resolutionComboBox = new System.Windows.Forms.ComboBox();
            this.codesTextBox = new System.Windows.Forms.TextBox();
            this.resolutionLabel = new System.Windows.Forms.Label();
            this.redeemButton = new System.Windows.Forms.Button();
            this.pasteCodesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resolutionComboBox
            // 
            this.resolutionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolutionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resolutionComboBox.FormattingEnabled = true;
            this.resolutionComboBox.Location = new System.Drawing.Point(12, 36);
            this.resolutionComboBox.Name = "resolutionComboBox";
            this.resolutionComboBox.Size = new System.Drawing.Size(293, 32);
            this.resolutionComboBox.TabIndex = 0;
            // 
            // codesTextBox
            // 
            this.codesTextBox.Location = new System.Drawing.Point(12, 116);
            this.codesTextBox.Multiline = true;
            this.codesTextBox.Name = "codesTextBox";
            this.codesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.codesTextBox.Size = new System.Drawing.Size(293, 291);
            this.codesTextBox.TabIndex = 1;
            // 
            // resolutionLabel
            // 
            this.resolutionLabel.AutoSize = true;
            this.resolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resolutionLabel.ForeColor = System.Drawing.Color.White;
            this.resolutionLabel.Location = new System.Drawing.Point(12, 9);
            this.resolutionLabel.Name = "resolutionLabel";
            this.resolutionLabel.Size = new System.Drawing.Size(154, 24);
            this.resolutionLabel.TabIndex = 2;
            this.resolutionLabel.Text = "Select resolution:";
            // 
            // redeemButton
            // 
            this.redeemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.redeemButton.Location = new System.Drawing.Point(12, 429);
            this.redeemButton.Name = "redeemButton";
            this.redeemButton.Size = new System.Drawing.Size(293, 51);
            this.redeemButton.TabIndex = 3;
            this.redeemButton.Text = "Auto redeem!";
            this.redeemButton.UseVisualStyleBackColor = true;
            this.redeemButton.Click += new System.EventHandler(this.redeemButton_Click);
            // 
            // pasteCodesLabel
            // 
            this.pasteCodesLabel.AutoSize = true;
            this.pasteCodesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pasteCodesLabel.ForeColor = System.Drawing.Color.White;
            this.pasteCodesLabel.Location = new System.Drawing.Point(12, 89);
            this.pasteCodesLabel.Name = "pasteCodesLabel";
            this.pasteCodesLabel.Size = new System.Drawing.Size(118, 24);
            this.pasteCodesLabel.TabIndex = 4;
            this.pasteCodesLabel.Text = "Paste codes:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(320, 490);
            this.Controls.Add(this.pasteCodesLabel);
            this.Controls.Add(this.redeemButton);
            this.Controls.Add(this.resolutionLabel);
            this.Controls.Add(this.codesTextBox);
            this.Controls.Add(this.resolutionComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox resolutionComboBox;
        private System.Windows.Forms.TextBox codesTextBox;
        private System.Windows.Forms.Label resolutionLabel;
        private System.Windows.Forms.Button redeemButton;
        private System.Windows.Forms.Label pasteCodesLabel;
    }
}

