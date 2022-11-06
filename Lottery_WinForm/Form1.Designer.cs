namespace Lottery_WinForm
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Label_Name = new System.Windows.Forms.Label();
            this.Button_Go = new System.Windows.Forms.Button();
            this.MenuStrip_Top = new System.Windows.Forms.MenuStrip();
            this.Menu1_File = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2_ReadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1_Theme = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2_Default = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2_Red = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2_Green = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2_Blue = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2_Orange = new System.Windows.Forms.ToolStripMenuItem();
            this.ReadTextDialog = new System.Windows.Forms.OpenFileDialog();
            this.Label_Prize = new System.Windows.Forms.Label();
            this.Menu1_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu2_PrizeSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Name.Location = new System.Drawing.Point(252, 147);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(601, 81);
            this.Label_Name.TabIndex = 0;
            this.Label_Name.Text = "获奖人";
            this.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Go
            // 
            this.Button_Go.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Button_Go.Location = new System.Drawing.Point(469, 442);
            this.Button_Go.Name = "Button_Go";
            this.Button_Go.Size = new System.Drawing.Size(170, 68);
            this.Button_Go.TabIndex = 1;
            this.Button_Go.Text = "开始";
            this.Button_Go.UseVisualStyleBackColor = true;
            // 
            // MenuStrip_Top
            // 
            this.MenuStrip_Top.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MenuStrip_Top.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu1_File,
            this.Menu1_Theme,
            this.Menu1_Settings});
            this.MenuStrip_Top.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_Top.Name = "MenuStrip_Top";
            this.MenuStrip_Top.Size = new System.Drawing.Size(1102, 32);
            this.MenuStrip_Top.TabIndex = 2;
            this.MenuStrip_Top.Text = "menuStrip1";
            // 
            // Menu1_File
            // 
            this.Menu1_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu2_ReadFile,
            this.Menu2_Exit});
            this.Menu1_File.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Menu1_File.Name = "Menu1_File";
            this.Menu1_File.Size = new System.Drawing.Size(62, 28);
            this.Menu1_File.Text = "文件";
            // 
            // Menu2_ReadFile
            // 
            this.Menu2_ReadFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Menu2_ReadFile.Name = "Menu2_ReadFile";
            this.Menu2_ReadFile.Size = new System.Drawing.Size(146, 34);
            this.Menu2_ReadFile.Text = "读取";
            // 
            // Menu2_Exit
            // 
            this.Menu2_Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Menu2_Exit.Name = "Menu2_Exit";
            this.Menu2_Exit.Size = new System.Drawing.Size(146, 34);
            this.Menu2_Exit.Text = "退出";
            // 
            // Menu1_Theme
            // 
            this.Menu1_Theme.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu2_Default,
            this.Menu2_Red,
            this.Menu2_Green,
            this.Menu2_Blue,
            this.Menu2_Orange});
            this.Menu1_Theme.Name = "Menu1_Theme";
            this.Menu1_Theme.Size = new System.Drawing.Size(62, 28);
            this.Menu1_Theme.Text = "主题";
            // 
            // Menu2_Default
            // 
            this.Menu2_Default.Checked = true;
            this.Menu2_Default.CheckOnClick = true;
            this.Menu2_Default.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Menu2_Default.Name = "Menu2_Default";
            this.Menu2_Default.Size = new System.Drawing.Size(146, 34);
            this.Menu2_Default.Text = "默认";
            // 
            // Menu2_Red
            // 
            this.Menu2_Red.CheckOnClick = true;
            this.Menu2_Red.Name = "Menu2_Red";
            this.Menu2_Red.Size = new System.Drawing.Size(146, 34);
            this.Menu2_Red.Text = "红";
            // 
            // Menu2_Green
            // 
            this.Menu2_Green.CheckOnClick = true;
            this.Menu2_Green.Name = "Menu2_Green";
            this.Menu2_Green.Size = new System.Drawing.Size(146, 34);
            this.Menu2_Green.Text = "绿";
            // 
            // Menu2_Blue
            // 
            this.Menu2_Blue.CheckOnClick = true;
            this.Menu2_Blue.Name = "Menu2_Blue";
            this.Menu2_Blue.Size = new System.Drawing.Size(146, 34);
            this.Menu2_Blue.Text = "蓝";
            // 
            // Menu2_Orange
            // 
            this.Menu2_Orange.CheckOnClick = true;
            this.Menu2_Orange.Name = "Menu2_Orange";
            this.Menu2_Orange.Size = new System.Drawing.Size(146, 34);
            this.Menu2_Orange.Text = "橙";
            // 
            // ReadTextDialog
            // 
            this.ReadTextDialog.FileName = "openFileDialog1";
            // 
            // Label_Prize
            // 
            this.Label_Prize.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Prize.Location = new System.Drawing.Point(252, 266);
            this.Label_Prize.Name = "Label_Prize";
            this.Label_Prize.Size = new System.Drawing.Size(601, 81);
            this.Label_Prize.TabIndex = 0;
            this.Label_Prize.Text = "奖品";
            this.Label_Prize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu1_Settings
            // 
            this.Menu1_Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu2_PrizeSettings});
            this.Menu1_Settings.Name = "Menu1_Settings";
            this.Menu1_Settings.Size = new System.Drawing.Size(62, 28);
            this.Menu1_Settings.Text = "设置";
            // 
            // Menu2_PrizeSettings
            // 
            this.Menu2_PrizeSettings.Name = "Menu2_PrizeSettings";
            this.Menu2_PrizeSettings.Size = new System.Drawing.Size(182, 34);
            this.Menu2_PrizeSettings.Text = "奖项设置";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1102, 692);
            this.Controls.Add(this.Button_Go);
            this.Controls.Add(this.Label_Prize);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.MenuStrip_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip_Top;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "抽奖";
            this.MenuStrip_Top.ResumeLayout(false);
            this.MenuStrip_Top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Label_Name;
        private Button Button_Go;
        private MenuStrip MenuStrip_Top;
        private ToolStripMenuItem Menu1_File;
        private ToolStripMenuItem Menu2_ReadFile;
        private ToolStripMenuItem Menu2_Exit;
        private OpenFileDialog ReadTextDialog;
        private ToolStripMenuItem Menu1_Theme;
        private ToolStripMenuItem Menu2_Red;
        private Label Label_Prize;
        private ToolStripMenuItem Menu2_Default;
        private ToolStripMenuItem Menu2_Green;
        private ToolStripMenuItem Menu2_Blue;
        private ToolStripMenuItem Menu2_Orange;
        private ToolStripMenuItem Menu1_Settings;
        private ToolStripMenuItem Menu2_PrizeSettings;
    }
}