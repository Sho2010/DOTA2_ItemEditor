namespace DOTA2_ItemEditor
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.heroChoiceControl = new Dota2.ItemEditor.Controls.HeroChoiceControl();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.itemEditControl1 = new Dota2.ItemEditor.ItemEditor.Controls.ItemEditControl();
            this.itemChoiceControl = new Dota2.ItemEditor.Controls.ItemChoiceControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.heroChoiceControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1182, 590);
            this.splitContainer1.SplitterDistance = 347;
            this.splitContainer1.TabIndex = 0;
            // 
            // heroChoiceControl
            // 
            this.heroChoiceControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heroChoiceControl.Location = new System.Drawing.Point(0, 0);
            this.heroChoiceControl.Name = "heroChoiceControl";
            this.heroChoiceControl.Size = new System.Drawing.Size(345, 588);
            this.heroChoiceControl.TabIndex = 0;
            this.heroChoiceControl.HeroSelected += new Dota2.ItemEditor.Controls.HeroSelectEventHandler(this.heroChoiceControl_HeroSelected);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.itemEditControl1);
            this.splitContainer2.Panel1MinSize = 210;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.itemChoiceControl);
            this.splitContainer2.Size = new System.Drawing.Size(831, 590);
            this.splitContainer2.SplitterDistance = 433;
            this.splitContainer2.TabIndex = 0;
            // 
            // itemEditControl1
            // 
            this.itemEditControl1.AutoScroll = true;
            this.itemEditControl1.AutoSize = true;
            this.itemEditControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemEditControl1.Location = new System.Drawing.Point(0, 0);
            this.itemEditControl1.Name = "itemEditControl1";
            this.itemEditControl1.Size = new System.Drawing.Size(431, 588);
            this.itemEditControl1.TabIndex = 0;
            // 
            // itemChoiceControl
            // 
            this.itemChoiceControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemChoiceControl.Location = new System.Drawing.Point(0, 0);
            this.itemChoiceControl.Name = "itemChoiceControl";
            this.itemChoiceControl.Size = new System.Drawing.Size(392, 588);
            this.itemChoiceControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 590);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "DOTA2 ItemBuilder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private Dota2.ItemEditor.Controls.HeroChoiceControl heroChoiceControl;
        private Dota2.ItemEditor.ItemEditor.Controls.ItemEditControl itemEditControl1;
        private Dota2.ItemEditor.Controls.ItemChoiceControl itemChoiceControl;

    }
}

