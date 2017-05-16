namespace NMIBP_text_search_project
{
    partial class add
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
            this.Title = new System.Windows.Forms.Label();
            this.Keywords = new System.Windows.Forms.Label();
            this.Summary = new System.Windows.Forms.Label();
            this.Body = new System.Windows.Forms.Label();
            this.titletextbox = new System.Windows.Forms.TextBox();
            this.keywordstextbox = new System.Windows.Forms.TextBox();
            this.summarytextbox = new System.Windows.Forms.TextBox();
            this.bodytextbox = new System.Windows.Forms.TextBox();
            this.addgroupbox = new System.Windows.Forms.GroupBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.messagelabel = new System.Windows.Forms.Label();
            this.addgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(41, 16);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 20;
            this.Title.Text = "Title";
            // 
            // Keywords
            // 
            this.Keywords.AutoSize = true;
            this.Keywords.Location = new System.Drawing.Point(15, 42);
            this.Keywords.Name = "Keywords";
            this.Keywords.Size = new System.Drawing.Size(53, 13);
            this.Keywords.TabIndex = 21;
            this.Keywords.Text = "Keywords";
            // 
            // Summary
            // 
            this.Summary.AutoSize = true;
            this.Summary.Location = new System.Drawing.Point(18, 73);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(50, 13);
            this.Summary.TabIndex = 22;
            this.Summary.Text = "Summary";
            // 
            // Body
            // 
            this.Body.AutoSize = true;
            this.Body.Location = new System.Drawing.Point(37, 136);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(31, 13);
            this.Body.TabIndex = 23;
            this.Body.Text = "Body";
            // 
            // titletextbox
            // 
            this.titletextbox.Location = new System.Drawing.Point(74, 13);
            this.titletextbox.Name = "titletextbox";
            this.titletextbox.Size = new System.Drawing.Size(228, 20);
            this.titletextbox.TabIndex = 1;
            // 
            // keywordstextbox
            // 
            this.keywordstextbox.Location = new System.Drawing.Point(74, 39);
            this.keywordstextbox.Name = "keywordstextbox";
            this.keywordstextbox.Size = new System.Drawing.Size(228, 20);
            this.keywordstextbox.TabIndex = 2;
            // 
            // summarytextbox
            // 
            this.summarytextbox.Location = new System.Drawing.Point(74, 65);
            this.summarytextbox.Multiline = true;
            this.summarytextbox.Name = "summarytextbox";
            this.summarytextbox.Size = new System.Drawing.Size(228, 50);
            this.summarytextbox.TabIndex = 3;
            // 
            // bodytextbox
            // 
            this.bodytextbox.Location = new System.Drawing.Point(74, 136);
            this.bodytextbox.Multiline = true;
            this.bodytextbox.Name = "bodytextbox";
            this.bodytextbox.Size = new System.Drawing.Size(228, 93);
            this.bodytextbox.TabIndex = 4;
            // 
            // addgroupbox
            // 
            this.addgroupbox.Controls.Add(this.bodytextbox);
            this.addgroupbox.Controls.Add(this.titletextbox);
            this.addgroupbox.Controls.Add(this.summarytextbox);
            this.addgroupbox.Controls.Add(this.Title);
            this.addgroupbox.Controls.Add(this.keywordstextbox);
            this.addgroupbox.Controls.Add(this.Keywords);
            this.addgroupbox.Controls.Add(this.Summary);
            this.addgroupbox.Controls.Add(this.Body);
            this.addgroupbox.Location = new System.Drawing.Point(12, 12);
            this.addgroupbox.Name = "addgroupbox";
            this.addgroupbox.Size = new System.Drawing.Size(341, 240);
            this.addgroupbox.TabIndex = 0;
            this.addgroupbox.TabStop = false;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(143, 258);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 5;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // messagelabel
            // 
            this.messagelabel.AutoSize = true;
            this.messagelabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.messagelabel.Location = new System.Drawing.Point(157, 284);
            this.messagelabel.Name = "messagelabel";
            this.messagelabel.Size = new System.Drawing.Size(0, 13);
            this.messagelabel.TabIndex = 9;
            this.messagelabel.Visible = false;
            // 
            // add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 311);
            this.Controls.Add(this.messagelabel);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.addgroupbox);
            this.Name = "add";
            this.Text = "Add form";
            this.addgroupbox.ResumeLayout(false);
            this.addgroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Keywords;
        private System.Windows.Forms.Label Summary;
        private System.Windows.Forms.Label Body;
        private System.Windows.Forms.TextBox titletextbox;
        private System.Windows.Forms.TextBox keywordstextbox;
        private System.Windows.Forms.TextBox summarytextbox;
        private System.Windows.Forms.TextBox bodytextbox;
        private System.Windows.Forms.GroupBox addgroupbox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label messagelabel;
    }
}

