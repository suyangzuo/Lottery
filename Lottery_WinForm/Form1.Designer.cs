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
            this.ReadTextDialog = new System.Windows.Forms.OpenFileDialog();
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
            this.Label_Name.Text = "点击按钮开始抽奖";
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
            this.Menu1_File});
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
            // ReadTextDialog
            // 
            this.ReadTextDialog.FileName = "openFileDialog1";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1102, 692);
            this.Controls.Add(this.Button_Go);
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
    }
}