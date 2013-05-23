namespace Dota2.ItemEditor.ItemEditor.Controls {
    partial class ItemEditControl {
        /// <summary> 
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナで生成されたコード

        /// <summary> 
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.heroPictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.overwriteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.defaultButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.heroPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // heroPictureBox
            // 
            this.heroPictureBox.Location = new System.Drawing.Point(0, 0);
            this.heroPictureBox.Name = "heroPictureBox";
            this.heroPictureBox.Size = new System.Drawing.Size(128, 77);
            this.heroPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heroPictureBox.TabIndex = 0;
            this.heroPictureBox.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.overwriteButton);
            this.splitContainer1.Panel1.Controls.Add(this.saveButton);
            this.splitContainer1.Panel1.Controls.Add(this.defaultButton);
            this.splitContainer1.Panel1.Controls.Add(this.heroPictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(331, 440);
            this.splitContainer1.SplitterDistance = 79;
            this.splitContainer1.TabIndex = 2;
            // 
            // overwriteButton
            // 
            this.overwriteButton.Location = new System.Drawing.Point(134, 8);
            this.overwriteButton.Name = "overwriteButton";
            this.overwriteButton.Size = new System.Drawing.Size(75, 23);
            this.overwriteButton.TabIndex = 3;
            this.overwriteButton.Text = "Save(&S)";
            this.overwriteButton.UseVisualStyleBackColor = true;
            this.overwriteButton.Click += new System.EventHandler(this.overwriteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(134, 45);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Export...";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // defaultButton
            // 
            this.defaultButton.Location = new System.Drawing.Point(215, 8);
            this.defaultButton.Name = "defaultButton";
            this.defaultButton.Size = new System.Drawing.Size(75, 23);
            this.defaultButton.TabIndex = 1;
            this.defaultButton.Text = "Default";
            this.defaultButton.UseVisualStyleBackColor = true;
            this.defaultButton.Click += new System.EventHandler(this.defaultButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(329, 355);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "ItemBuildファイル|default_*.txt|すべてのファイル|*.*";
            // 
            // ItemEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ItemEditControl";
            this.Size = new System.Drawing.Size(331, 440);
            ((System.ComponentModel.ISupportInitialize)(this.heroPictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox heroPictureBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button defaultButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button overwriteButton;
        private System.Windows.Forms.Button saveButton;
    }
}
