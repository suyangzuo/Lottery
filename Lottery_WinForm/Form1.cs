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
            Label_Name.Text = Information.Names[0];
        }
    }
}