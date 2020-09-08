namespace ATM.View
{
    partial class ATMMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATMMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.EndButton = new System.Windows.Forms.Button();
            this.BalanceButton = new System.Windows.Forms.Button();
            this.CutBalanceButton = new System.Windows.Forms.Button();
            this.AddBalansButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.EndButton);
            this.panel1.Controls.Add(this.BalanceButton);
            this.panel1.Controls.Add(this.CutBalanceButton);
            this.panel1.Controls.Add(this.AddBalansButton);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // EndButton
            // 
            resources.ApplyResources(this.EndButton, "EndButton");
            this.EndButton.Name = "EndButton";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // BalanceButton
            // 
            resources.ApplyResources(this.BalanceButton, "BalanceButton");
            this.BalanceButton.Name = "BalanceButton";
            this.BalanceButton.UseVisualStyleBackColor = true;
            this.BalanceButton.Click += new System.EventHandler(this.BalanceButton_Click);
            // 
            // CutBalanceButton
            // 
            resources.ApplyResources(this.CutBalanceButton, "CutBalanceButton");
            this.CutBalanceButton.Name = "CutBalanceButton";
            this.CutBalanceButton.UseVisualStyleBackColor = true;
            this.CutBalanceButton.Click += new System.EventHandler(this.CutBalanceButton_Click);
            // 
            // AddBalansButton
            // 
            resources.ApplyResources(this.AddBalansButton, "AddBalansButton");
            this.AddBalansButton.Name = "AddBalansButton";
            this.AddBalansButton.UseVisualStyleBackColor = true;
            this.AddBalansButton.Click += new System.EventHandler(this.AddBalansButton_Click);
            // 
            // ATMMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ATMMenu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BalanceButton;
        private System.Windows.Forms.Button CutBalanceButton;
        private System.Windows.Forms.Button AddBalansButton;
        private System.Windows.Forms.Button EndButton;
    }
}