using System;

namespace Lottery_WinForm
{
    public partial class Main_Form : Form
    {

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
            this.Button_Go.Click += ButtonGo_Click;
            this.Menu2_PrizeSettings.Click += PrizeSetting;
            foreach (var item in Menu1_Theme.DropDownItems)
            {
                if (item is ToolStripMenuItem dropdownItem)
                {
                    dropdownItem.Click += (object? sender, EventArgs e) =>
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

        private void ExitProgram(object? sender, EventArgs e)
        {
            var result = MessageBox.Show("�˳�����", "�˳�", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) Environment.Exit(0);
        }

        private void FormIsClosing(object? sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("�˳�����", "�˳�", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) e.Cancel = true;
            else Environment.Exit(0);
        }

        private void ReadNameList(object? sender, EventArgs e)
        {
            ReadTextDialog.InitialDirectory = $"{Application.StartupPath}";
            ReadTextDialog.Filter = "�ı��ĵ�(*.txt)|*.txt";
            ReadTextDialog.RestoreDirectory = true;
            ReadTextDialog.FileName = null;
            if (ReadTextDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string? textFileName = ReadTextDialog.FileName;
            if (string.IsNullOrEmpty(textFileName)) return;
            using var textReader = new StreamReader(textFileName, Encoding.UTF8);
            string nameReaded = textReader.ReadToEnd();
            if (string.IsNullOrEmpty(nameReaded))
            {
                Label_Name.Text = "�ı�Ϊ�գ�";
                return;
            }
            Names.AddRange(nameReaded.Split("��"));
            Label_Name.Text = "������ȡ�ɹ���";
        }

        private void SetBackColor(object sender, EventArgs e)
        {
            //Waiting for code...
        }

        private void PrizeSetting(object? sender, EventArgs e)
        {
            var prizeSettingsForm = new PrizeSettings(this);
            prizeSettingsForm.Show();
        }

        private void ButtonGo_Click(object? sender, EventArgs e)
        {
            if (Names.Count <= 0)
            {
                Label_Name.Text = "��δ��������";
                return;
            }
            if (currentState == State.Running)
            {
                currentState = State.Suspend;
                Button_Go.Text = "����";
                GetLotteryResult();
                return;
            }
            if (currentState == State.Stop || currentState == State.Suspend)
            {
                currentState = State.Running;
                Button_Go.Text = "��ͣ";
            }
            var r = new Random(Guid.NewGuid().GetHashCode());
            var threadRollNames = new Thread(() =>
            {
                while (Information.Names.Count > 0)
                {
                    Thread.Sleep(300);
                    if (currentState != State.Running) return;
                    Monitor.Enter(r);
                    int nameIndex = r.Next(0, Names.Count);
                    int prizeIndex = r.Next(0, 1);
                    Monitor.Exit(r);
                    lock (objLock) currentName = Names[nameIndex];
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

        private void GetLotteryResult()
        {

        }
    }
}