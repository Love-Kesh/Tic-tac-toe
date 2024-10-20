namespace Tic_tac_toe
{
    internal class CheckForWin
    {
        private bool CheckVertical(string b1, string b2, string b3)
        {
            return (b1 == b2 && b2 == b3 && !string.IsNullOrEmpty(b1));
        }

        private bool CheckHorizontal(string b1, string b2, string b3)
        {
            return (b1 == b2 && b2 == b3 && !string.IsNullOrEmpty(b1));
        }

        private bool CheckDiagonal(string b1, string b2, string b3)
        {
            return (b1 == b2 && b2 == b3 && !string.IsNullOrEmpty(b1));
        }

        public bool HasWinner(string[] buttonTexts)
        {
            if (CheckVertical(buttonTexts[0], buttonTexts[3], buttonTexts[6]) ||
                CheckVertical(buttonTexts[1], buttonTexts[4], buttonTexts[7]) ||
                CheckVertical(buttonTexts[2], buttonTexts[5], buttonTexts[8]))
            {
                return true;
            }

            if (CheckHorizontal(buttonTexts[0], buttonTexts[1], buttonTexts[2]) ||
                CheckHorizontal(buttonTexts[3], buttonTexts[4], buttonTexts[5]) ||
                CheckHorizontal(buttonTexts[6], buttonTexts[7], buttonTexts[8]))
            {
                return true;
            }

            if (CheckDiagonal(buttonTexts[0], buttonTexts[4], buttonTexts[8]) ||
                CheckDiagonal(buttonTexts[2], buttonTexts[4], buttonTexts[6]))
            {
                return true;
            }

            return false;
        }
    }
}
