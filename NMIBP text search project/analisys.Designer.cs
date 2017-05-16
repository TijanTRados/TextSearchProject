namespace NMIBP_text_search_project
{
    partial class analisys
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
            this.labelfrom = new System.Windows.Forms.Label();
            this.labelto = new System.Windows.Forms.Label();
            this.radiogroup = new System.Windows.Forms.GroupBox();
            this.daybutton = new System.Windows.Forms.RadioButton();
            this.hourbutton = new System.Windows.Forms.RadioButton();
            this.allgroup = new System.Windows.Forms.GroupBox();
            this.datefrom = new System.Windows.Forms.DateTimePicker();
            this.dateto = new System.Windows.Forms.DateTimePicker();
            this.resultgroup = new System.Windows.Forms.GroupBox();
            this.analysebutton = new System.Windows.Forms.Button();
            this.resultcontainer = new System.Windows.Forms.WebBrowser();
            this.sqlbox = new System.Windows.Forms.TextBox();
            this.radiogroup.SuspendLayout();
            this.allgroup.SuspendLayout();
            this.resultgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelfrom
            // 
            this.labelfrom.AutoSize = true;
            this.labelfrom.Location = new System.Drawing.Point(40, 21);
            this.labelfrom.Name = "labelfrom";
            this.labelfrom.Size = new System.Drawing.Size(30, 13);
            this.labelfrom.TabIndex = 2;
            this.labelfrom.Text = "From";
            // 
            // labelto
            // 
            this.labelto.AutoSize = true;
            this.labelto.Location = new System.Drawing.Point(50, 44);
            this.labelto.Name = "labelto";
            this.labelto.Size = new System.Drawing.Size(20, 13);
            this.labelto.TabIndex = 3;
            this.labelto.Text = "To";
            // 
            // radiogroup
            // 
            this.radiogroup.Controls.Add(this.hourbutton);
            this.radiogroup.Controls.Add(this.daybutton);
            this.radiogroup.Location = new System.Drawing.Point(282, 10);
            this.radiogroup.Name = "radiogroup";
            this.radiogroup.Size = new System.Drawing.Size(92, 58);
            this.radiogroup.TabIndex = 4;
            this.radiogroup.TabStop = false;
            // 
            // daybutton
            // 
            this.daybutton.AutoSize = true;
            this.daybutton.Location = new System.Drawing.Point(29, 11);
            this.daybutton.Name = "daybutton";
            this.daybutton.Size = new System.Drawing.Size(44, 17);
            this.daybutton.TabIndex = 0;
            this.daybutton.TabStop = true;
            this.daybutton.Text = "Day";
            this.daybutton.UseVisualStyleBackColor = true;
            // 
            // hourbutton
            // 
            this.hourbutton.AutoSize = true;
            this.hourbutton.Location = new System.Drawing.Point(29, 34);
            this.hourbutton.Name = "hourbutton";
            this.hourbutton.Size = new System.Drawing.Size(48, 17);
            this.hourbutton.TabIndex = 1;
            this.hourbutton.TabStop = true;
            this.hourbutton.Text = "Hour";
            this.hourbutton.UseVisualStyleBackColor = true;
            // 
            // allgroup
            // 
            this.allgroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allgroup.Controls.Add(this.analysebutton);
            this.allgroup.Controls.Add(this.dateto);
            this.allgroup.Controls.Add(this.datefrom);
            this.allgroup.Controls.Add(this.radiogroup);
            this.allgroup.Controls.Add(this.labelto);
            this.allgroup.Controls.Add(this.labelfrom);
            this.allgroup.Location = new System.Drawing.Point(12, 2);
            this.allgroup.Name = "allgroup";
            this.allgroup.Size = new System.Drawing.Size(515, 74);
            this.allgroup.TabIndex = 5;
            this.allgroup.TabStop = false;
            // 
            // datefrom
            // 
            this.datefrom.Location = new System.Drawing.Point(76, 17);
            this.datefrom.Name = "datefrom";
            this.datefrom.Size = new System.Drawing.Size(200, 20);
            this.datefrom.TabIndex = 6;
            // 
            // dateto
            // 
            this.dateto.Location = new System.Drawing.Point(76, 44);
            this.dateto.Name = "dateto";
            this.dateto.Size = new System.Drawing.Size(200, 20);
            this.dateto.TabIndex = 6;
            // 
            // resultgroup
            // 
            this.resultgroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultgroup.Controls.Add(this.resultcontainer);
            this.resultgroup.Location = new System.Drawing.Point(12, 185);
            this.resultgroup.Name = "resultgroup";
            this.resultgroup.Size = new System.Drawing.Size(515, 269);
            this.resultgroup.TabIndex = 6;
            this.resultgroup.TabStop = false;
            // 
            // analysebutton
            // 
            this.analysebutton.Location = new System.Drawing.Point(405, 21);
            this.analysebutton.Name = "analysebutton";
            this.analysebutton.Size = new System.Drawing.Size(75, 36);
            this.analysebutton.TabIndex = 7;
            this.analysebutton.Text = "Analyse";
            this.analysebutton.UseVisualStyleBackColor = true;
            this.analysebutton.Click += new System.EventHandler(this.analyse_click);
            // 
            // resultcontainer
            // 
            this.resultcontainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultcontainer.Location = new System.Drawing.Point(6, 19);
            this.resultcontainer.MinimumSize = new System.Drawing.Size(20, 20);
            this.resultcontainer.Name = "resultcontainer";
            this.resultcontainer.Size = new System.Drawing.Size(503, 250);
            this.resultcontainer.TabIndex = 0;
            // 
            // sqlbox
            // 
            this.sqlbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlbox.Location = new System.Drawing.Point(15, 82);
            this.sqlbox.Multiline = true;
            this.sqlbox.Name = "sqlbox";
            this.sqlbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sqlbox.Size = new System.Drawing.Size(512, 97);
            this.sqlbox.TabIndex = 7;
            // 
            // analisys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 466);
            this.Controls.Add(this.sqlbox);
            this.Controls.Add(this.resultgroup);
            this.Controls.Add(this.allgroup);
            this.Name = "analisys";
            this.Text = "Searching analysis";
            this.radiogroup.ResumeLayout(false);
            this.radiogroup.PerformLayout();
            this.allgroup.ResumeLayout(false);
            this.allgroup.PerformLayout();
            this.resultgroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelfrom;
        private System.Windows.Forms.Label labelto;
        private System.Windows.Forms.GroupBox radiogroup;
        private System.Windows.Forms.RadioButton hourbutton;
        private System.Windows.Forms.RadioButton daybutton;
        private System.Windows.Forms.GroupBox allgroup;
        private System.Windows.Forms.DateTimePicker dateto;
        private System.Windows.Forms.DateTimePicker datefrom;
        private System.Windows.Forms.GroupBox resultgroup;
        private System.Windows.Forms.Button analysebutton;
        private System.Windows.Forms.WebBrowser resultcontainer;
        private System.Windows.Forms.TextBox sqlbox;
    }
}