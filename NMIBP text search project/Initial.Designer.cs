namespace NMIBP_text_search_project
{
    partial class Initial
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
            this.add = new System.Windows.Forms.Button();
            this.group = new System.Windows.Forms.GroupBox();
            this.analize = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.group.SuspendLayout();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(6, 19);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(331, 63);
            this.add.TabIndex = 0;
            this.add.Text = "Add new article";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // group
            // 
            this.group.Controls.Add(this.analize);
            this.group.Controls.Add(this.search);
            this.group.Controls.Add(this.add);
            this.group.Location = new System.Drawing.Point(12, 12);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(343, 237);
            this.group.TabIndex = 1;
            this.group.TabStop = false;
            // 
            // analize
            // 
            this.analize.Location = new System.Drawing.Point(6, 160);
            this.analize.Name = "analize";
            this.analize.Size = new System.Drawing.Size(331, 71);
            this.analize.TabIndex = 2;
            this.analize.Text = "Searching analysis";
            this.analize.UseVisualStyleBackColor = true;
            this.analize.Click += new System.EventHandler(this.analysis_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(6, 88);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(331, 66);
            this.search.TabIndex = 1;
            this.search.Text = "Search through articles";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 261);
            this.Controls.Add(this.group);
            this.Name = "Initial";
            this.Text = "Articles";
            this.group.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.GroupBox group;
        private System.Windows.Forms.Button analize;
        private System.Windows.Forms.Button search;
    }
}