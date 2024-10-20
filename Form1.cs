
namespace Tic_tac_toe
{
    public partial class Mode_Selection : Form
    {
        public Mode_Selection()
        {
            InitializeComponent();
        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            Regular regularGame = new Regular();
            regularGame.ShowDialog();
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            Advanced advancedGame = new Advanced();
            advancedGame.ShowDialog();
        }
    }
}
