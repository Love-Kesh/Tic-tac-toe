
namespace Tic_tac_toe
{
    public partial class Regular : Form
    {
        public string Winner { get; private set; } = "";
        private bool isPlayerXTurn = true;
        private CheckForWin checkForWin = new CheckForWin();

        public Regular()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text != "")
                return;

            btn.Text = isPlayerXTurn ? "X" : "O";

            string[] buttonTexts = GetButtonTexts();

            if (checkForWin.HasWinner(buttonTexts))
            {
                Winner = btn.Text;
                MessageBox.Show($"Player {Winner} wins!", "Winner");
                this.Close();
                return;
            }

            if (CheckForDraw())
            {
                MessageBox.Show("It's a draw!", "Draw");
                this.Close();
                return;
            }

            isPlayerXTurn = !isPlayerXTurn;
        }

        private string[] GetButtonTexts()
        {
            return new string[]
            {
                btn1.Text,
                btn2.Text,
                btn3.Text,
                btn4.Text,
                btn5.Text,
                btn6.Text,
                btn7.Text,
                btn8.Text,
                btn9.Text
            };
        }

        private bool CheckForDraw()
        {
            string[] buttonTexts = GetButtonTexts();
            foreach (string text in buttonTexts)
            {
                if (string.IsNullOrEmpty(text))
                    return false;
            }
            return true;
        }
    }
}
