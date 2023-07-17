namespace GDSEDITOR
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simplifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillMeshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeViaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Pnl_MegreVia = new System.Windows.Forms.Panel();
            this.Btn_DoMerge = new System.Windows.Forms.Button();
            this.Pnl_FillMesh = new System.Windows.Forms.Panel();
            this.Btn_DoFill = new System.Windows.Forms.Button();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbx_Threshold = new System.Windows.Forms.TextBox();
            this.Tbx_Distance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.Pnl_MegreVia.SuspendLayout();
            this.Pnl_FillMesh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1127, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.simplifyToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // simplifyToolStripMenuItem
            // 
            this.simplifyToolStripMenuItem.Name = "simplifyToolStripMenuItem";
            this.simplifyToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.simplifyToolStripMenuItem.Text = "Simplify";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillMeshToolStripMenuItem,
            this.mergeViaToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // fillMeshToolStripMenuItem
            // 
            this.fillMeshToolStripMenuItem.Name = "fillMeshToolStripMenuItem";
            this.fillMeshToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.fillMeshToolStripMenuItem.Text = "Fill Mesh";
            this.fillMeshToolStripMenuItem.Click += new System.EventHandler(this.FillMeshToolStripMenuItem_Click);
            // 
            // mergeViaToolStripMenuItem
            // 
            this.mergeViaToolStripMenuItem.Name = "mergeViaToolStripMenuItem";
            this.mergeViaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.mergeViaToolStripMenuItem.Text = "Merge Via";
            this.mergeViaToolStripMenuItem.Click += new System.EventHandler(this.MergeViaToolStripMenuItem_Click);
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip2.Location = new System.Drawing.Point(0, 720);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1127, 22);
            this.statusStrip2.TabIndex = 2;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(61, 17);
            this.toolStripStatusLabel1.Text = "Gds Editor";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Pnl_FillMesh);
            this.splitContainer1.Panel1.Controls.Add(this.Pnl_MegreVia);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.Controls.Add(this.PicBox);
            this.splitContainer1.Size = new System.Drawing.Size(1127, 628);
            this.splitContainer1.SplitterDistance = 183;
            this.splitContainer1.TabIndex = 3;
            // 
            // Pnl_MegreVia
            // 
            this.Pnl_MegreVia.Controls.Add(this.Tbx_Distance);
            this.Pnl_MegreVia.Controls.Add(this.label2);
            this.Pnl_MegreVia.Controls.Add(this.Btn_DoMerge);
            this.Pnl_MegreVia.Location = new System.Drawing.Point(10, 13);
            this.Pnl_MegreVia.Name = "Pnl_MegreVia";
            this.Pnl_MegreVia.Size = new System.Drawing.Size(166, 259);
            this.Pnl_MegreVia.TabIndex = 0;
            // 
            // Btn_DoMerge
            // 
            this.Btn_DoMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DoMerge.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_DoMerge.Location = new System.Drawing.Point(6, 15);
            this.Btn_DoMerge.Name = "Btn_DoMerge";
            this.Btn_DoMerge.Size = new System.Drawing.Size(166, 52);
            this.Btn_DoMerge.TabIndex = 1;
            this.Btn_DoMerge.Text = "Excecute";
            this.Btn_DoMerge.UseVisualStyleBackColor = true;
            // 
            // Pnl_FillMesh
            // 
            this.Pnl_FillMesh.Controls.Add(this.Tbx_Threshold);
            this.Pnl_FillMesh.Controls.Add(this.label1);
            this.Pnl_FillMesh.Controls.Add(this.Btn_DoFill);
            this.Pnl_FillMesh.Location = new System.Drawing.Point(10, 295);
            this.Pnl_FillMesh.Name = "Pnl_FillMesh";
            this.Pnl_FillMesh.Size = new System.Drawing.Size(179, 240);
            this.Pnl_FillMesh.TabIndex = 0;
            // 
            // Btn_DoFill
            // 
            this.Btn_DoFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_DoFill.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Btn_DoFill.Location = new System.Drawing.Point(6, 15);
            this.Btn_DoFill.Name = "Btn_DoFill";
            this.Btn_DoFill.Size = new System.Drawing.Size(166, 52);
            this.Btn_DoFill.TabIndex = 0;
            this.Btn_DoFill.Text = "Excecute";
            this.Btn_DoFill.UseVisualStyleBackColor = true;
            // 
            // PicBox
            // 
            this.PicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBox.Location = new System.Drawing.Point(0, 0);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(936, 624);
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AllowDrop = true;
            this.splitContainer2.Panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.SplitContainer2_Panel1_DragDrop);
            this.splitContainer2.Panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.SplitContainer2_Panel1_DragEnter);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1127, 696);
            this.splitContainer2.SplitterDistance = 64;
            this.splitContainer2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(7, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "面積閾値 : ";
            // 
            // Tbx_Threshold
            // 
            this.Tbx_Threshold.Location = new System.Drawing.Point(6, 125);
            this.Tbx_Threshold.Name = "Tbx_Threshold";
            this.Tbx_Threshold.Size = new System.Drawing.Size(167, 19);
            this.Tbx_Threshold.TabIndex = 2;
            // 
            // Tbx_Distance
            // 
            this.Tbx_Distance.Location = new System.Drawing.Point(6, 125);
            this.Tbx_Distance.Name = "Tbx_Distance";
            this.Tbx_Distance.Size = new System.Drawing.Size(166, 19);
            this.Tbx_Distance.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "距離閾値 : ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 742);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "GDS EDITOR";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.Pnl_MegreVia.ResumeLayout(false);
            this.Pnl_MegreVia.PerformLayout();
            this.Pnl_FillMesh.ResumeLayout(false);
            this.Pnl_FillMesh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simplifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillMeshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeViaToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Panel Pnl_FillMesh;
        private System.Windows.Forms.Panel Pnl_MegreVia;
        private System.Windows.Forms.Button Btn_DoMerge;
        private System.Windows.Forms.Button Btn_DoFill;
        private System.Windows.Forms.TextBox Tbx_Distance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tbx_Threshold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
    }
}

