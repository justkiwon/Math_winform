using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math                                    // 이벤트 핸들러 --> 버튼 선택과 같은 이벤트에 대한 반응으로 실행되는 코드
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region define variable
        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();

        // These integer variables store the numbers
        // for the addition problem.
        int addend1;
        int addend2;
        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;

        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int dividend;
        int divisor;

        // This integer variable keeps track of the remaining time.
        int timeLeft;
        #endregion

        public void StartTheQuiz()  // plus and minus problem
        {
            #region add_point
            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);   // Next(51)은 두 난수가 0 ~ 50사이의 응답이 되도록 호출한다.
            addend2 = randomizer.Next(51);

            // Convert the two rancomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            sum.Value = 0;
            #endregion

            #region miner_point
            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            diffLeftLabel.Text = minuend.ToString();
            diffRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;
            #endregion

            #region multiplicate
            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            doubleLeftLabel.Text = multiplicand.ToString();
            doubleRightLabel.Text = multiplier.ToString();
            double1.Value = 0;
            #endregion
        
            #region diviser
            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            splitLeftLabel.Text = dividend.ToString();
            splitRightLabel.Text = divisor.ToString();
            split.Value = 0;
            #endregion

            #region the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
            #endregion
        }

        private void Start_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            Start.Enabled = false;  // start 컨트롤의 Enabled 속성을 false로 설정한다.
        }
        private bool CheckTheAnswer() // 수학 문제에 대한 답이 맞는지 check하는 것
        {
            if((addend1 + addend2 == sum.Value) && (minuend - subtrahend == difference.Value) &&
                                    (multiplicand*multiplier == double1.Value) && (dividend/divisor == split.Value))
                return true;
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user got the answer right.
                // Stop the timer and show a MessageBox.
                // adn show a MessageBox.
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                Start.Enabled= true;
            }
            else if (timeLeft > 0)
            {
                // If Check The Answer() returns false, keep counting down.
                // Decrese the time left by one second and display the new time left by updating
                // the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + "seconds";
                if(timeLeft == 5)
                {
                    timeLabel.BackColor = Color.Red;
                }
            }
            else
            {
                // If the user ran out of time, stop the timer, show a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                double1.Value = multiplicand*multiplier;
                split.Value = dividend/divisor;
                Start.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            //Select the whole answer in the NumericUpDown control
            NumericUpDown answerBox = sender as NumericUpDown;  // sender는 발신자라고 하는 이벤트가 발생하는 개체를 나타내고
                                                                                          // 보낸 사람 개체는 NumericUpDown 컨트롤이다
                                                                                          // 보낸 사람을 일반 개체에서 NumericUpDown 컨트롤로 캐스팅하거나 변환한다.
            if (answerBox != null) // answerBox가 성공적으로 캐스팅 되었는지 확인한다.
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length; // 현재  NumericUpDown 컨트롤에 있는 답변의 길이를 결정한다.
                answerBox.Select(0, lengthOfAnswer); // 응답 길이를 사용하여 컨트롤의 현재 값을 선택한다.
            }
        }
        private void NumericUpDown1_ValueChanged(Object sender, EventArgs e) // 속성 -> 작업 -> valueChange 에서 이 함수 이름인 NumericUpDown1_ValueChanged 를 작성하면 이벤트가 연결 된다.
        {
                                                                    // ValueChanged 이벤트가 발생하려면 Numeric 창의 값이 바뀔 때 마다 이벤트가 일어나고 사용자가 ENTER 키를 누르거나 컨트롤에서 벗어날 때 읽는다.
            MessageBox.Show("You are in the NumericUpDown.ValueChanged event.");    
        }
    }
}
