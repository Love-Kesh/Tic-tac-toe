
namespace Tic_tac_toe
{
    public partial class Advanced : Form
    {
        public Advanced()
        {
            InitializeComponent();
        }

        private void btnAdv_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (!string.IsNullOrEmpty(btn.Text))
                return;

            Regular regularGame = new Regular();
            regularGame.ShowDialog();

            if (!string.IsNullOrEmpty(regularGame.Winner))
            {
                btn.Text = regularGame.Winner;
                btn.Enabled = false;
            }
            else
            {
                btn.Text = "Draw";
                btn.Enabled = false;
            }

            CheckOverallWinner();
        }

        private void CheckOverallWinner()
        {
            string[] buttonTexts = new string[]
            {
                btnAdv1.Text, btnAdv2.Text, btnAdv3.Text,
                btnAdv4.Text, btnAdv5.Text, btnAdv6.Text,
                btnAdv7.Text, btnAdv8.Text, btnAdv9.Text
            };

            string overallWinner = GetOverallWinner(buttonTexts);
            if (!string.IsNullOrEmpty(overallWinner))
            {
                MessageBox.Show($"Overall winner: {overallWinner}", "Game Over");
            }
            else if (Array.TrueForAll(buttonTexts, text => !string.IsNullOrEmpty(text)))
            {
                MessageBox.Show("It's a draw!", "Game Over");
            }
        }

        private string GetOverallWinner(string[] buttonTexts)
        {
            CheckForWin checkForWin = new CheckForWin();

            if (checkForWin.HasWinner(buttonTexts))
            {
                return buttonTexts[0];
            }

            return ""; // no winner found
        }
    }
}
