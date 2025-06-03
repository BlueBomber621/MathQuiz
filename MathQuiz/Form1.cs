namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Declare fields at the class level to ensure they are accessible throughout the class
        private Random randomizer = new();
        private int questionNum = 0;
        private int timeLeft = 30;
        private int questionAnswer = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }

        public void Quiz_Start()
        {
            // Start timer
            timeLeft = 300;
            timer.Enabled = true;
            timer.Start();
            timeLabel.Text = "5:00";

            // Prep question number
            questionNum = 1;
        }

        public int Generate_Question()
        {
            int eTypeSel1, ePart1, ePart2, eType1;
                eTypeSel1 = 1 + ((int)Math.Floor((decimal)(questionNum / 5)));
                eType1 = randomizer.Next(1, ((eTypeSel1 < 5) ? eTypeSel1 : 5 ));
                if (eType1 == 4)
                {
                    ePart2 = randomizer.Next(2, 12);
                    ePart1 = ePart2 * randomizer.Next(2, 2 + questionNum);
                }
                else
                {
                     ePart1 = (eType1 != 5) ? randomizer.Next(1, 5 + (int)(3 * Math.Round((double)questionNum / eType1))) : randomizer.Next(2, 6 + questionNum);
                     ePart2 = (eType1 != 5) ? randomizer.Next(1, 5 + (int)(3 * Math.Round((double)questionNum / eType1))) : randomizer.Next(2, 3);
                }
                if (eType1 == 1) { equationLabel.Text = $"{ePart1} + {ePart2}"; return ePart1 + ePart2; }
                else if (eType1 == 2) { equationLabel.Text = $"{ePart1} - {ePart2}"; return ePart1 - ePart2; }
                else if (eType1 == 3) { equationLabel.Text = $"{ePart1} * {ePart2}"; return ePart1 * ePart2; }
                else if (eType1 == 4) { equationLabel.Text = $"{ePart1} / {ePart2}"; return ePart1 / ePart2; }
                else if (eType1 == 5) { equationLabel.Text = $"{ePart1} ^ {ePart2}"; return (int)Math.Pow(ePart1, ePart2); }
                return 0;
        }

        private void buttonCont_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                Quiz_Start();
                buttonCont.Text = "Submit";
                questionLabel.Text = "Q " + questionNum;
                questionAnswer = Generate_Question();
            }
            else
            {
                if ((double)numericAnswer.Value == questionAnswer && timeLeft > 0)
                {
                    questionAnswer = 99999;
                    numericAnswer.Value = 0;
                    if (questionNum != 50)
                    {
                        questionNum++;
                        timeLeft += 5;
                        timeLabel.Text = $"{Math.Floor((double)timeLeft / 60)}:{((timeLeft % 60 > 9) ? Math.Round((double)timeLeft % 60) : "0" + Math.Round((double)timeLeft % 10))}";
                        questionLabel.Text = "Q " + questionNum;
                        questionAnswer = Generate_Question();
                    }
                    else
                    {
                        equationLabel.Text = "You Win!";
                        buttonCont.Enabled = false;
                        numericAnswer.Enabled = false;
                        timer.Stop();
                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                timeLabel.Text = $"{Math.Floor((decimal)timeLeft/60)}:{Math.Round((decimal)timeLeft%60)}";
            }
            else
            {
                timer.Stop();
                timeLabel.Text = "Time's up!";
                equationLabel.Text = "You Lose, Time's Up!";
                buttonCont.Enabled = false;
                numericAnswer.Enabled = false;
            }
        }
    }
}
