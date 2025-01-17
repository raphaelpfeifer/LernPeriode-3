namespace LP3_WinForms
{
    public partial class Form1 : Form
    {

        public enum player 
        {
            X, O
        }

        player currentPlayer;
        Random random = new Random();
        int playerWinCount = 0;
        int cpuWinCount = 0;



        public Form1()
        {
            InitializeComponent();
            restartGame();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void CPUmove(object sender, EventArgs e)
        {

        }

        private void PlayerClickButton(object sender, EventArgs e)
        {

        }

        private void RestartGame(object sender, EventArgs e)
        {

        }

        private void checkGame()
        {

        }

         private void restartGame()
         {
            List<Button> buttons = new List<Button> {button1, button2, button3, button4, button5, button6, 
            button7, button8, button9};

            foreach (Button x in buttons)
            {
                
            }
         }

}  

}
