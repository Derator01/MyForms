using KLIN;

namespace MyForms
{
    public partial class MainMenu : Form
    {
        KLINInstanse kLINInstanse = new();

        public MainMenu()
        {
            InitializeComponent();

        }

        private void MainBtn0_Click(object sender, EventArgs e)
        {
            OpenGLWindow engine = new();
            engine.ShowDialog();
        }

        private void MainBtn1_Click(object sender, EventArgs e)
        {

        }

        private void MainBtn2_Click(object sender, EventArgs e)
        {

        }
    }
}