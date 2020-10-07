namespace ATM
{
    partial class ATMInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ATMInput));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextNumberCard = new System.Windows.Forms.TextBox();
            this.InputNumbCard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.TextPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextNumberCard);
            this.panel1.Controls.Add(this.InputNumbCard);
            this.panel1.Name = "panel1";
            // 
            // TextPassword
            // 
            resources.ApplyResources(this.TextPassword, "TextPassword");
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.TextChanged += new System.EventHandler(this.TextPassword_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextNumberCard
            // 
            resources.ApplyResources(this.TextNumberCard, "TextNumberCard");
            this.TextNumberCard.Name = "TextNumberCard";
            this.TextNumberCard.TextChanged += new System.EventHandler(this.TextNumberCard_TextChanged);
            // 
            // InputNumbCard
            // 
            resources.ApplyResources(this.InputNumbCard, "InputNumbCard");
            this.InputNumbCard.Name = "InputNumbCard";
            this.InputNumbCard.UseVisualStyleBackColor = true;
            this.InputNumbCard.Click += new System.EventHandler(this.InputNumbCard_Click);
            // 
            // ATMInput
            // 
            this.AcceptButton = this.InputNumbCard;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ATMInput";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button InputNumbCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox TextNumberCard;
        public System.Windows.Forms.TextBox TextPassword;
    }
}