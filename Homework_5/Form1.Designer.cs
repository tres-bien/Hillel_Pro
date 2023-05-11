namespace Homework_5
{
    partial class fWordSearcher
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
            splitContainer1 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            tDisplayText = new TextBox();
            tWordSearch = new TextBox();
            splitContainer2 = new SplitContainer();
            bShow = new Button();
            bSearch = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(661, 338);
            splitContainer1.SplitterDistance = 307;
            splitContainer1.SplitterWidth = 1;
            splitContainer1.TabIndex = 1;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(tDisplayText);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(tWordSearch);
            splitContainer3.Size = new Size(661, 307);
            splitContainer3.SplitterDistance = 278;
            splitContainer3.SplitterWidth = 1;
            splitContainer3.TabIndex = 2;
            // 
            // tDisplayText
            // 
            tDisplayText.Dock = DockStyle.Fill;
            tDisplayText.Location = new Point(0, 0);
            tDisplayText.MaxLength = 300;
            tDisplayText.Multiline = true;
            tDisplayText.Name = "tDisplayText";
            tDisplayText.ScrollBars = ScrollBars.Vertical;
            tDisplayText.Size = new Size(661, 278);
            tDisplayText.TabIndex = 1;
            // 
            // tWordSearch
            // 
            tWordSearch.Dock = DockStyle.Fill;
            tWordSearch.Location = new Point(0, 0);
            tWordSearch.Multiline = true;
            tWordSearch.Name = "tWordSearch";
            tWordSearch.Size = new Size(661, 28);
            tWordSearch.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.IsSplitterFixed = true;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(bShow);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(bSearch);
            splitContainer2.Size = new Size(661, 30);
            splitContainer2.SplitterDistance = 330;
            splitContainer2.SplitterWidth = 1;
            splitContainer2.TabIndex = 1;
            // 
            // bShow
            // 
            bShow.Dock = DockStyle.Fill;
            bShow.Location = new Point(0, 0);
            bShow.Name = "bShow";
            bShow.Size = new Size(330, 30);
            bShow.TabIndex = 0;
            bShow.Text = "Show Text";
            bShow.UseVisualStyleBackColor = true;
            bShow.Click += button1_Click;
            // 
            // bSearch
            // 
            bSearch.Dock = DockStyle.Fill;
            bSearch.Location = new Point(0, 0);
            bSearch.Name = "bSearch";
            bSearch.Size = new Size(330, 30);
            bSearch.TabIndex = 0;
            bSearch.Text = "Search";
            bSearch.UseVisualStyleBackColor = true;
            bSearch.Click += bSearch_Click;
            // 
            // fWordSearcher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 338);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fWordSearcher";
            Text = "Word Searcher";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private TextBox tDisplayText;
        private Button bSearch;
        private SplitContainer splitContainer2;
        private Button bShow;
        private SplitContainer splitContainer3;
        private TextBox tWordSearch;
    }
}