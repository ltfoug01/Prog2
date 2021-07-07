using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Form1 : Form
    {
        string time;
        public Form1()
        {
            InitializeComponent();
        }

        private void registerTimeButton_Click(object sender, EventArgs e)
        {
            //Returns to form if textbox is empty.
            if (lastNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Enter Last Name");
                return;
            }
            string lastName;//Student's lastName variable.
            char letter; //First letter.

            const string SR_DATE = "March 29";//Sr Register Date.
            const string JR_DATE = "March 30";//Jr Register Date.
            const string SOPH_DATE1 = "March 31";// Soph Register Date.
            const string SOPH_DATE2 = "April 03";// Soph Register Date.
            const string FROSH_DATE1 = "April 04";//Fresh Register Date.
            const string FROSH_DATE2 = "April 05";//Fresh Register Date.
            const string EIGHT_THIRTY = "8:30 AM";//Register Time.
            const string TEN = "10:00 AM";//Register Time.
            const string ELEVEN_THIRTY = "11.30 AM";//Register Time.
            const string TWO = "2:00 PM";//Register Time.
            const string FOUR = "4:00 PM";//Register Time.

            lastName = lastNameTextBox.Text;//Assigns textbox string to lastName.
            lastName = lastName.ToUpper();//lastName to uppercase.
            letter = lastName[0];//Letter cotains first Letter in uppercase.
            
            if (char.IsLetter(letter))//Validates that letter contains a char.
            {
                if (seniorRadioButton.Checked || juniorRadioButton.Checked)
                {
                    if (letter <= 'D')
                    {
                        time = ELEVEN_THIRTY;
                    }
                    else if (letter <= 'I')//Range E-I.
                    {
                       time = TWO;
                    }
                    else if (letter <= 'O')//Range J-O.
                    {
                        time = FOUR;
                    }
                    else if (letter <= 'S')//Range P-S.
                    {
                        time = EIGHT_THIRTY;
                    }
                    else //Range T-Z.
                    {
                        time = TEN;
                    }
                    if (seniorRadioButton.Checked)
                    {
                        registerTimeLabel.Text = SR_DATE + " " + time;//Senior date and time.
                    }
                    else
                    {
                        registerTimeLabel.Text = JR_DATE + " " + time;//Junior date and time.
                    }
                }
                else
                {
                    if (letter <= 'B')//Range A-B.
                    {
                        if (sophRadioButton.Checked)
                            registerTimeLabel.Text = SOPH_DATE1 + " " + FOUR;
                        else
                            registerTimeLabel.Text = FROSH_DATE1 + " " + FOUR;
                    }
                    else if (letter <= 'D')//Range C-D.
                    {
                        if (sophRadioButton.Checked)
                            registerTimeLabel.Text = SOPH_DATE2 + " " + EIGHT_THIRTY;
                        else
                            registerTimeLabel.Text = FROSH_DATE2 + " " + EIGHT_THIRTY;
                    }
                    else if (letter <= 'F')//Range E-F.
                    {
                        if (sophRadioButton.Checked)
                            registerTimeLabel.Text = SOPH_DATE2 + " " + TEN;
                        else
                            registerTimeLabel.Text = FROSH_DATE2 + " " + TEN;
                    }
                    else if (letter <= 'I')//Range G-I
                    {
                        if (sophRadioButton.Checked)
                            registerTimeLabel.Text = SOPH_DATE2 + " " + ELEVEN_THIRTY;
                        else
                            registerTimeLabel.Text = FROSH_DATE2 + " " + ELEVEN_THIRTY;
                    }
                    else if (letter <= 'L')//Range J-L.
                    {
                        if (sophRadioButton.Checked)
                            registerTimeLabel.Text = SOPH_DATE2 + " " + TWO;
                        else
                            registerTimeLabel.Text = FROSH_DATE2 + " " + TWO;
                    }
                    else if (letter <= 'O')//Range M-O.
                    {
                        time = FOUR;
                        if (sophRadioButton.Checked)
                            registerTimeLabel.Text = SOPH_DATE2 + " " + FOUR;
                        else
                            registerTimeLabel.Text = FROSH_DATE2 + " " + FOUR;
                    }
                    else if (letter <= 'Q')//Range P-Q.
                    {
                        if (sophRadioButton.Checked)
                            registerTimeLabel.Text = SOPH_DATE1 + " " + EIGHT_THIRTY;
                        else
                            registerTimeLabel.Text = FROSH_DATE1 + " " + EIGHT_THIRTY;
                    }
                    else if (letter <= 'S')//Range R-S.
                    {
                        if (sophRadioButton.Checked)
                            registerTimeLabel.Text = SOPH_DATE1 + " " + TEN;
                        else
                            registerTimeLabel.Text = FROSH_DATE1 + " " + TEN;
                    }
                    else if (letter <= 'V')//Range T-V
                    {
                        if (sophRadioButton.Checked)
                            registerTimeLabel.Text = SOPH_DATE1 + " " + ELEVEN_THIRTY;
                        else
                            registerTimeLabel.Text = FROSH_DATE1 + " " + ELEVEN_THIRTY;
                    }
                    else //Range W-Z.
                    {
                        if (sophRadioButton.Checked)
                            registerTimeLabel.Text = SOPH_DATE1 + " " + TWO;
                        else
                            registerTimeLabel.Text = FROSH_DATE1 + " " + TWO;
                    }
                } 
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }  
        }
        //Clears the form.
        private void clearButton_Click(object sender, EventArgs e)
        {
            registerTimeLabel.Text = "";
            lastNameTextBox.Text = "";
        }
    }
}
