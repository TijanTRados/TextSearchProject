namespace NMIBP_text_search_project
{
    partial class search
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
            this.searchbox = new System.Windows.Forms.TextBox();
            this.andradio = new System.Windows.Forms.RadioButton();
            this.addorgroup = new System.Windows.Forms.GroupBox();
            this.orradio = new System.Windows.Forms.RadioButton();
            this.optionone = new System.Windows.Forms.RadioButton();
            this.optiontwo = new System.Windows.Forms.RadioButton();
            this.optiongroup = new System.Windows.Forms.GroupBox();
            this.sqlbox = new System.Windows.Forms.TextBox();
            this.resultgroup = new System.Windows.Forms.GroupBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.resultcontainer = new System.Windows.Forms.WebBrowser();
            this.addorgroup.SuspendLayout();
            this.optiongroup.SuspendLayout();
            this.resultgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchbox
            // 
            this.searchbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbox.Location = new System.Drawing.Point(12, 12);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(414, 20);
            this.searchbox.TabIndex = 0;
            // 
            // andradio
            // 
            this.andradio.AutoSize = true;
            this.andradio.Location = new System.Drawing.Point(28, 18);
            this.andradio.Name = "andradio";
            this.andradio.Size = new System.Drawing.Size(48, 17);
            this.andradio.TabIndex = 1;
            this.andradio.Text = "AND";
            this.andradio.UseVisualStyleBackColor = true;
            // 
            // addorgroup
            // 
            this.addorgroup.Controls.Add(this.orradio);
            this.addorgroup.Controls.Add(this.andradio);
            this.addorgroup.Location = new System.Drawing.Point(12, 38);
            this.addorgroup.Name = "addorgroup";
            this.addorgroup.Size = new System.Drawing.Size(109, 71);
            this.addorgroup.TabIndex = 2;
            this.addorgroup.TabStop = false;
            // 
            // orradio
            // 
            this.orradio.AutoSize = true;
            this.orradio.Location = new System.Drawing.Point(28, 41);
            this.orradio.Name = "orradio";
            this.orradio.Size = new System.Drawing.Size(41, 17);
            this.orradio.TabIndex = 3;
            this.orradio.TabStop = true;
            this.orradio.Text = "OR";
            this.orradio.UseVisualStyleBackColor = true;
            this.orradio.CheckedChanged += new System.EventHandler(this.orradio_CheckedChanged);
            // 
            // optionone
            // 
            this.optionone.AutoSize = true;
            this.optionone.Location = new System.Drawing.Point(25, 18);
            this.optionone.Name = "optionone";
            this.optionone.Size = new System.Drawing.Size(193, 17);
            this.optionone.TabIndex = 3;
            this.optionone.Text = "Based on morphology and semantic";
            this.optionone.UseVisualStyleBackColor = true;
            // 
            // optiontwo
            // 
            this.optiontwo.AutoSize = true;
            this.optiontwo.Location = new System.Drawing.Point(25, 41);
            this.optiontwo.Name = "optiontwo";
            this.optiontwo.Size = new System.Drawing.Size(107, 17);
            this.optiontwo.TabIndex = 4;
            this.optiontwo.Text = "Fuzzy text search";
            this.optiontwo.UseVisualStyleBackColor = true;
            // 
            // optiongroup
            // 
            this.optiongroup.Controls.Add(this.optiontwo);
            this.optiongroup.Controls.Add(this.optionone);
            this.optiongroup.Location = new System.Drawing.Point(127, 38);
            this.optiongroup.Name = "optiongroup";
            this.optiongroup.Size = new System.Drawing.Size(284, 71);
            this.optiongroup.TabIndex = 5;
            this.optiongroup.TabStop = false;
            // 
            // sqlbox
            // 
            this.sqlbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlbox.Location = new System.Drawing.Point(12, 115);
            this.sqlbox.Multiline = true;
            this.sqlbox.Name = "sqlbox";
            this.sqlbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sqlbox.Size = new System.Drawing.Size(414, 123);
            this.sqlbox.TabIndex = 6;
            // 
            // resultgroup
            // 
            this.resultgroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultgroup.Controls.Add(this.resultcontainer);
            this.resultgroup.Location = new System.Drawing.Point(12, 244);
            this.resultgroup.Name = "resultgroup";
            this.resultgroup.Size = new System.Drawing.Size(414, 173);
            this.resultgroup.TabIndex = 7;
            this.resultgroup.TabStop = false;
            // 
            // searchbutton
            // 
            this.searchbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchbutton.Location = new System.Drawing.Point(153, 423);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(146, 23);
            this.searchbutton.TabIndex = 8;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.search_buttonclick);
            // 
            // resultcontainer
            // 
            this.resultcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultcontainer.Location = new System.Drawing.Point(3, 16);
            this.resultcontainer.MinimumSize = new System.Drawing.Size(20, 20);
            this.resultcontainer.Name = "resultcontainer";
            this.resultcontainer.Size = new System.Drawing.Size(408, 154);
            this.resultcontainer.TabIndex = 0;
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 460);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.resultgroup);
            this.Controls.Add(this.sqlbox);
            this.Controls.Add(this.searchbox);
            this.Controls.Add(this.addorgroup);
            this.Controls.Add(this.optiongroup);
            this.Name = "search";
            this.Text = "Search documents";
            this.addorgroup.ResumeLayout(false);
            this.addorgroup.PerformLayout();
            this.optiongroup.ResumeLayout(false);
            this.optiongroup.PerformLayout();
            this.resultgroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.RadioButton andradio;
        private System.Windows.Forms.GroupBox addorgroup;
        private System.Windows.Forms.RadioButton orradio;
        private System.Windows.Forms.RadioButton optionone;
        private System.Windows.Forms.RadioButton optiontwo;
        private System.Windows.Forms.GroupBox optiongroup;
        private System.Windows.Forms.TextBox sqlbox;
        private System.Windows.Forms.GroupBox resultgroup;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.WebBrowser resultcontainer;
    }
}