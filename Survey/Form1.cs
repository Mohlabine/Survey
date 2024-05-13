using Survey.UserControls;
using System.Windows.Forms;

namespace Survey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            LoadControl(new NewSurvey());
        }
        private void LoadControl(UserControl control)
        {
            control.Parent = pnlHost;
            pnlHost.Controls.Add(control);

        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            LoadControl(new ViewResults());
        }
    }
}
