namespace DataBaseAdapter
{
    partial class Form1
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
            this.vListBox1 = new VIBlend.WinForms.Controls.vListBox();
            this.vLabel1 = new VIBlend.WinForms.Controls.vLabel();
            this.SuspendLayout();
            // 
            // vListBox1
            // 
            this.vListBox1.Location = new System.Drawing.Point(13, 102);
            this.vListBox1.Name = "vListBox1";
            this.vListBox1.RoundedCornersMaskListItem = ((byte)(15));
            this.vListBox1.Size = new System.Drawing.Size(870, 266);
            this.vListBox1.TabIndex = 0;
            this.vListBox1.Text = "vListBox1";
            this.vListBox1.VIBlendScrollBarsTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.vListBox1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // vLabel1
            // 
            this.vLabel1.BackColor = System.Drawing.Color.Transparent;
            this.vLabel1.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.vLabel1.Ellipsis = false;
            this.vLabel1.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel1.Location = new System.Drawing.Point(12, 73);
            this.vLabel1.Multiline = true;
            this.vLabel1.Name = "vLabel1";
            this.vLabel1.Size = new System.Drawing.Size(99, 23);
            this.vLabel1.TabIndex = 1;
            this.vLabel1.Text = " 运行信息";
            this.vLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel1.UseMnemonics = true;
            this.vLabel1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 503);
            this.Controls.Add(this.vLabel1);
            this.Controls.Add(this.vListBox1);
            this.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "DataBaseAdapter-CPL-LWD";
            this.ResumeLayout(false);

        }

        #endregion

        private VIBlend.WinForms.Controls.vListBox vListBox1;
        private VIBlend.WinForms.Controls.vLabel vLabel1;

    }
}

