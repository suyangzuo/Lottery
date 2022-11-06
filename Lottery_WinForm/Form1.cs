namespace Lottery_WinForm
{
    public partial class Main_Form : Form
    {
        private enum State
        {
            Running, Suspend, Stop
        }
        private static string currentName;
        private static State currentState = State.Stop;

        public Main_Form()
        {
            InitializeComponent();
            CustomInit();
        }

        public void CustomInit()
        {
            this.Menu2_Exit.Click += ExitProgram;
            this.FormClosing += FormIsClosing;
            this.Menu2_ReadFile.Click += ReadNameList;
            this.Button_Go.Click += RollNames;
            this.Menu2_PrizeSettings.Click += PrizeSetting;
            foreach (var item in Menu1_Theme.DropDownItems)
            {
                if (item is ToolStripMenuItem dropdownItem)
                {
                    dropdownItem.Click += (object sender, EventArgs e) =>
                    {
                        if (sender is ToolStripMenuItem menuItem)
                        {
                            //if (menuItem.Checked) return;
                            foreach (var menu in Menu1_Theme.DropDownItems)
                            {
                                if (menu is ToolStripMenuItem colorMenu)
                                {
                                    colorMenu.Checked = false;
                                }
                            }
                            menuItem.Checked = true;
                        }
                    };
                }
            }
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            var result = MessageBox.Show("退出程序？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("退出程序？", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void ReadNameList(object sender, EventArgs e)
        {
            ReadTextDialog.InitialDirectory = $"{Application.StartupPath}";
            ReadTextDialog.Filter = "文本文档(*.txt)|*.txt";
            ReadTextDialog.RestoreDirectory = true;
            ReadTextDialog.FileName = null;
            if (ReadTextDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string textFileName = ReadTextDialog.FileName;
            if (string.IsNullOrEmpty(textFileName)) return;
            using var textReader = new StreamReader(textFileName, Encoding.UTF8);
            string nameReaded = textReader.ReadToEnd();
            if (string.IsNullOrEmpty(nameReaded))
            {
                Label_Name.Text = "文本为空！";
                return;
            }
            Information.Names.AddRange(nameReaded.Split("，"));
        }

        private void SetBackColor(object sender, EventArgs e)
        {
            //Waiting for code...
        }

        private void PrizeSetting(object sender, EventArgs e)
        {
            var prizeSettingsForm = new PrizeSettings(this);
            prizeSettingsForm.Show();
        }

        private void RollNames(object sender, EventArgs e)
        {
            if (Information.Names.Count <= 0)
            {
                Label_Name.Text = "尚未导入名单";
                return;
            }
            if (currentState == State.Running)
            {
                currentState = State.Suspend;
                Button_Go.Text = "继续";
                return;
            }
            if (currentState == State.Stop || currentState == State.Suspend)
            {
                currentState = State.Running;
                Button_Go.Text = "暂停";
            }
            var r = new Random(Guid.NewGuid().GetHashCode());
            var threadRollNames = new Thread(() =>
            {
                while (Information.Names.Count > 0)
                {
                    Thread.Sleep(300);
                    if (currentState != State.Running) return;
                    int index = r.Next(0, Information.Names.Count);
                    currentName = Information.Names[index];
                    if (this.InvokeRequired)
                    {
                        this.Invoke(() =>
                        {
                            Label_Name.Text = currentName;
                        });
                    }
                }
            });
            threadRollNames.Start();
        }
    }
}