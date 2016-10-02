namespace ShinyAddFirewallRule
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uiButtonRun = new System.Windows.Forms.Button();
            this.uiProgram = new System.Windows.Forms.ComboBox();
            this.uiName = new System.Windows.Forms.TextBox();
            this.uiLabelProgram = new System.Windows.Forms.Label();
            this.uiLabelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uiButtonRun
            // 
            this.uiButtonRun.Enabled = false;
            this.uiButtonRun.Location = new System.Drawing.Point(12, 65);
            this.uiButtonRun.Name = "uiButtonRun";
            this.uiButtonRun.Size = new System.Drawing.Size(141, 23);
            this.uiButtonRun.TabIndex = 0;
            this.uiButtonRun.Text = "Run netsh.exe";
            this.uiButtonRun.UseVisualStyleBackColor = true;
            this.uiButtonRun.Click += new System.EventHandler(this.uiButtonRun_Click);
            // 
            // uiProgram
            // 
            this.uiProgram.FormattingEnabled = true;
            this.uiProgram.Location = new System.Drawing.Point(89, 12);
            this.uiProgram.Name = "uiProgram";
            this.uiProgram.Size = new System.Drawing.Size(554, 21);
            this.uiProgram.TabIndex = 1;
            this.uiProgram.SelectedIndexChanged += new System.EventHandler(this.uiProgram_SelectedIndexChanged);
            // 
            // uiName
            // 
            this.uiName.Location = new System.Drawing.Point(89, 39);
            this.uiName.Name = "uiName";
            this.uiName.ReadOnly = true;
            this.uiName.Size = new System.Drawing.Size(360, 20);
            this.uiName.TabIndex = 2;
            // 
            // uiLabelProgram
            // 
            this.uiLabelProgram.AutoSize = true;
            this.uiLabelProgram.Location = new System.Drawing.Point(12, 15);
            this.uiLabelProgram.Name = "uiLabelProgram";
            this.uiLabelProgram.Size = new System.Drawing.Size(49, 13);
            this.uiLabelProgram.TabIndex = 3;
            this.uiLabelProgram.Text = "Program:";
            // 
            // uiLabelName
            // 
            this.uiLabelName.AutoSize = true;
            this.uiLabelName.Location = new System.Drawing.Point(12, 42);
            this.uiLabelName.Name = "uiLabelName";
            this.uiLabelName.Size = new System.Drawing.Size(61, 13);
            this.uiLabelName.TabIndex = 4;
            this.uiLabelName.Text = "Rule name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 97);
            this.Controls.Add(this.uiLabelName);
            this.Controls.Add(this.uiLabelProgram);
            this.Controls.Add(this.uiName);
            this.Controls.Add(this.uiProgram);
            this.Controls.Add(this.uiButtonRun);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "ShinyAddFirewallRule";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiButtonRun;
        private System.Windows.Forms.ComboBox uiProgram;
        private System.Windows.Forms.TextBox uiName;
        private System.Windows.Forms.Label uiLabelProgram;
        private System.Windows.Forms.Label uiLabelName;
    }
}