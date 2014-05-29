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
            this.components = new System.ComponentModel.Container();
            this.lstRunningInfo = new VIBlend.WinForms.Controls.vListBox();
            this.vLabel1 = new VIBlend.WinForms.Controls.vLabel();
            this.vLabel2 = new VIBlend.WinForms.Controls.vLabel();
            this.vComboBox1 = new VIBlend.WinForms.Controls.vComboBox();
            this.vLabel3 = new VIBlend.WinForms.Controls.vLabel();
            this.vTextBox1 = new VIBlend.WinForms.Controls.vTextBox();
            this.vLabel4 = new VIBlend.WinForms.Controls.vLabel();
            this.vTextBox2 = new VIBlend.WinForms.Controls.vTextBox();
            this.vCheckBox1 = new VIBlend.WinForms.Controls.vCheckBox();
            this.StartButton = new VIBlend.WinForms.Controls.vButton();
            this.StopButton = new VIBlend.WinForms.Controls.vButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vCircularProgressBar1 = new VIBlend.WinForms.Controls.vCircularProgressBar();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据库查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRunningInfo
            // 
            this.lstRunningInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lstRunningInfo.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstRunningInfo.Location = new System.Drawing.Point(12, 144);
            this.lstRunningInfo.Name = "lstRunningInfo";
            this.lstRunningInfo.RoundedCornersMaskListItem = ((byte)(15));
            this.lstRunningInfo.Size = new System.Drawing.Size(985, 357);
            this.lstRunningInfo.TabIndex = 0;
            this.lstRunningInfo.Text = "vListBox1";
            this.lstRunningInfo.VIBlendScrollBarsTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.lstRunningInfo.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // vLabel1
            // 
            this.vLabel1.BackColor = System.Drawing.Color.Transparent;
            this.vLabel1.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.vLabel1.Ellipsis = false;
            this.vLabel1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vLabel1.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel1.Location = new System.Drawing.Point(13, 94);
            this.vLabel1.Multiline = true;
            this.vLabel1.Name = "vLabel1";
            this.vLabel1.Size = new System.Drawing.Size(99, 23);
            this.vLabel1.TabIndex = 1;
            this.vLabel1.Text = " 运行状态:";
            this.vLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel1.UseMnemonics = true;
            this.vLabel1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // vLabel2
            // 
            this.vLabel2.BackColor = System.Drawing.Color.Transparent;
            this.vLabel2.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.vLabel2.Ellipsis = false;
            this.vLabel2.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vLabel2.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel2.Location = new System.Drawing.Point(28, 44);
            this.vLabel2.Multiline = true;
            this.vLabel2.Name = "vLabel2";
            this.vLabel2.Size = new System.Drawing.Size(85, 34);
            this.vLabel2.TabIndex = 2;
            this.vLabel2.Text = "主机IP:";
            this.vLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel2.UseMnemonics = true;
            this.vLabel2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // vComboBox1
            // 
            this.vComboBox1.BackColor = System.Drawing.Color.White;
            this.vComboBox1.DisplayMember = "";
            this.vComboBox1.DropDownArrowBackgroundEnabled = true;
            this.vComboBox1.DropDownMaximumSize = new System.Drawing.Size(1000, 1000);
            this.vComboBox1.DropDownMinimumSize = new System.Drawing.Size(10, 10);
            this.vComboBox1.DropDownResizeDirection = VIBlend.WinForms.Controls.SizingDirection.Both;
            this.vComboBox1.DropDownWidth = 116;
            this.vComboBox1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vComboBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.vComboBox1.Location = new System.Drawing.Point(119, 44);
            this.vComboBox1.Name = "vComboBox1";
            this.vComboBox1.RoundedCornersMaskListItem = ((byte)(15));
            this.vComboBox1.Size = new System.Drawing.Size(116, 31);
            this.vComboBox1.TabIndex = 3;
            this.vComboBox1.UseThemeBackColor = false;
            this.vComboBox1.UseThemeDropDownArrowColor = true;
            this.vComboBox1.ValueMember = "";
            this.vComboBox1.VIBlendScrollBarsTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.vComboBox1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // vLabel3
            // 
            this.vLabel3.BackColor = System.Drawing.Color.Transparent;
            this.vLabel3.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.vLabel3.Ellipsis = false;
            this.vLabel3.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vLabel3.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel3.Location = new System.Drawing.Point(254, 44);
            this.vLabel3.Multiline = true;
            this.vLabel3.Name = "vLabel3";
            this.vLabel3.Size = new System.Drawing.Size(91, 31);
            this.vLabel3.TabIndex = 4;
            this.vLabel3.Text = "接收端口:";
            this.vLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel3.UseMnemonics = true;
            this.vLabel3.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // vTextBox1
            // 
            this.vTextBox1.BackColor = System.Drawing.Color.White;
            this.vTextBox1.BoundsOffset = new System.Drawing.Size(1, 1);
            this.vTextBox1.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.vTextBox1.DefaultText = "Empty...";
            this.vTextBox1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vTextBox1.Location = new System.Drawing.Point(363, 44);
            this.vTextBox1.MaxLength = 32767;
            this.vTextBox1.Name = "vTextBox1";
            this.vTextBox1.PasswordChar = '\0';
            this.vTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vTextBox1.SelectionLength = 0;
            this.vTextBox1.SelectionStart = 0;
            this.vTextBox1.Size = new System.Drawing.Size(66, 31);
            this.vTextBox1.TabIndex = 5;
            this.vTextBox1.Text = " 9001";
            this.vTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.vTextBox1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // vLabel4
            // 
            this.vLabel4.BackColor = System.Drawing.Color.Transparent;
            this.vLabel4.DisplayStyle = VIBlend.WinForms.Controls.LabelItemStyle.TextOnly;
            this.vLabel4.Ellipsis = false;
            this.vLabel4.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vLabel4.ImageAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel4.Location = new System.Drawing.Point(457, 44);
            this.vLabel4.Multiline = true;
            this.vLabel4.Name = "vLabel4";
            this.vLabel4.Size = new System.Drawing.Size(115, 31);
            this.vLabel4.TabIndex = 6;
            this.vLabel4.Text = "解析错误:";
            this.vLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.vLabel4.UseMnemonics = true;
            this.vLabel4.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // vTextBox2
            // 
            this.vTextBox2.BackColor = System.Drawing.Color.White;
            this.vTextBox2.BoundsOffset = new System.Drawing.Size(1, 1);
            this.vTextBox2.ControlBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.vTextBox2.DefaultText = "Empty...";
            this.vTextBox2.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vTextBox2.Location = new System.Drawing.Point(578, 44);
            this.vTextBox2.MaxLength = 32767;
            this.vTextBox2.Name = "vTextBox2";
            this.vTextBox2.PasswordChar = '\0';
            this.vTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.vTextBox2.SelectionLength = 0;
            this.vTextBox2.SelectionStart = 0;
            this.vTextBox2.Size = new System.Drawing.Size(123, 31);
            this.vTextBox2.TabIndex = 7;
            this.vTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.vTextBox2.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // vCheckBox1
            // 
            this.vCheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.vCheckBox1.Checked = true;
            this.vCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.vCheckBox1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vCheckBox1.Location = new System.Drawing.Point(735, 44);
            this.vCheckBox1.Name = "vCheckBox1";
            this.vCheckBox1.Size = new System.Drawing.Size(174, 31);
            this.vCheckBox1.TabIndex = 8;
            this.vCheckBox1.Text = "保存WITS文件";
            this.vCheckBox1.UseVisualStyleBackColor = false;
            this.vCheckBox1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            // 
            // StartButton
            // 
            this.StartButton.AllowAnimations = true;
            this.StartButton.BackColor = System.Drawing.Color.Transparent;
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StartButton.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartButton.Location = new System.Drawing.Point(269, 87);
            this.StartButton.Name = "StartButton";
            this.StartButton.RoundedCornersMask = ((byte)(15));
            this.StartButton.Size = new System.Drawing.Size(100, 41);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "开  始";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.StartButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // StopButton
            // 
            this.StopButton.AllowAnimations = true;
            this.StopButton.BackColor = System.Drawing.Color.Transparent;
            this.StopButton.Enabled = false;
            this.StopButton.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StopButton.Location = new System.Drawing.Point(549, 87);
            this.StopButton.Name = "StopButton";
            this.StopButton.RoundedCornersMask = ((byte)(15));
            this.StopButton.Size = new System.Drawing.Size(100, 41);
            this.StopButton.TabIndex = 10;
            this.StopButton.Text = "停  止";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.VISTABLUE;
            this.StopButton.Click += new System.EventHandler(this.Stop_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip1.Location = new System.Drawing.Point(0, 513);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1009, 24);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(125, 19);
            this.toolStripStatusLabel1.Text = "适配器状态:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Yellow;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(72, 19);
            this.toolStripStatusLabel2.Text = "就绪！";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(125, 19);
            this.toolStripStatusLabel3.Text = "数据库链接:";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.Color.Yellow;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(72, 19);
            this.toolStripStatusLabel4.Text = "就绪！";
            // 
            // vCircularProgressBar1
            // 
            this.vCircularProgressBar1.AllowAnimations = true;
            this.vCircularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.vCircularProgressBar1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vCircularProgressBar1.ForeColor = System.Drawing.Color.MediumOrchid;
            this.vCircularProgressBar1.IndicatorsCount = 8;
            this.vCircularProgressBar1.Location = new System.Drawing.Point(135, 87);
            this.vCircularProgressBar1.Maximum = 100;
            this.vCircularProgressBar1.Minimum = 0;
            this.vCircularProgressBar1.Name = "vCircularProgressBar1";
            this.vCircularProgressBar1.Size = new System.Drawing.Size(50, 41);
            this.vCircularProgressBar1.TabIndex = 14;
            this.vCircularProgressBar1.Text = "vCircularProgressBar1";
            this.vCircularProgressBar1.UseThemeBackground = true;
            this.vCircularProgressBar1.Value = 0;
            this.vCircularProgressBar1.VIBlendTheme = VIBlend.Utilities.VIBLEND_THEME.METROBLUE;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1009, 27);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 数据库查询ToolStripMenuItem
            // 
            this.数据库查询ToolStripMenuItem.Name = "数据库查询ToolStripMenuItem";
            this.数据库查询ToolStripMenuItem.Size = new System.Drawing.Size(126, 23);
            this.数据库查询ToolStripMenuItem.Text = "数据库查询";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1009, 537);
            this.Controls.Add(this.vCircularProgressBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.vCheckBox1);
            this.Controls.Add(this.vTextBox2);
            this.Controls.Add(this.vLabel4);
            this.Controls.Add(this.vTextBox1);
            this.Controls.Add(this.vLabel3);
            this.Controls.Add(this.vComboBox1);
            this.Controls.Add(this.vLabel2);
            this.Controls.Add(this.vLabel1);
            this.Controls.Add(this.lstRunningInfo);
            this.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "DataBaseAdapter-CPL-LWD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VIBlend.WinForms.Controls.vListBox lstRunningInfo;
        private VIBlend.WinForms.Controls.vLabel vLabel1;
        private VIBlend.WinForms.Controls.vLabel vLabel2;
        private VIBlend.WinForms.Controls.vComboBox vComboBox1;
        private VIBlend.WinForms.Controls.vLabel vLabel3;
        private VIBlend.WinForms.Controls.vTextBox vTextBox1;
        private VIBlend.WinForms.Controls.vLabel vLabel4;
        private VIBlend.WinForms.Controls.vTextBox vTextBox2;
        private VIBlend.WinForms.Controls.vCheckBox vCheckBox1;
        private VIBlend.WinForms.Controls.vButton StartButton;
        private VIBlend.WinForms.Controls.vButton StopButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private VIBlend.WinForms.Controls.vCircularProgressBar vCircularProgressBar1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 数据库查询ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;

    }
}

