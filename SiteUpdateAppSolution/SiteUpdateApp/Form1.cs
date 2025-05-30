namespace SiteUpdateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectBuild_Click(object sender, EventArgs e)
        {
            string buildPath = "";
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                buildPath = ofd.FileName;
                lblBuild.Text = buildPath;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

        }
    }
}
