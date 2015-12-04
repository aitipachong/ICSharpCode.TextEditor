namespace Sample
{
    partial class FrmSample
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSample));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbModes = new System.Windows.Forms.ComboBox();
            this.txtContent = new ICSharpCode.TextEditor.TextEditorControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "SyntaxModes:";
            // 
            // cmbModes
            // 
            this.cmbModes.FormattingEnabled = true;
            this.cmbModes.Location = new System.Drawing.Point(109, 21);
            this.cmbModes.Name = "cmbModes";
            this.cmbModes.Size = new System.Drawing.Size(167, 20);
            this.cmbModes.TabIndex = 1;
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Encoding = ((System.Text.Encoding)(resources.GetObject("txtContent.Encoding")));
            this.txtContent.Location = new System.Drawing.Point(12, 59);
            this.txtContent.Name = "txtContent";
            this.txtContent.ShowEOLMarkers = true;
            this.txtContent.ShowSpaces = true;
            this.txtContent.ShowTabs = true;
            this.txtContent.ShowVRuler = true;
            this.txtContent.Size = new System.Drawing.Size(627, 362);
            this.txtContent.TabIndex = 2;
            // 
            // FrmSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 433);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.cmbModes);
            this.Controls.Add(this.label1);
            this.Name = "FrmSample";
            this.Text = "ICSharpCode.TextEditor Sample";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbModes;
        private ICSharpCode.TextEditor.TextEditorControl txtContent;

    }
}

