using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // get the monthly interest rate
                //decimal yearlyInterestRate =
                 //   Convert.ToDecimal(txtInterestRate.Text);
                //decimal monthlyInterestRate =
                 //   yearlyInterestRate / 12 / 100;

                // get the number of months
                //int years = Convert.ToInt32(txtYears.Text);
                //int months = years * 12;

                 // future value
                
                decimal numberGrade =
                        Convert.ToDecimal(txtNumberGrade.Text);
                //String letterGrade; 

                if(numberGrade >=90)
                {
                    txtLetterGrade.Text = "A";
                }
                else if (numberGrade >= 80 && numberGrade < 90)
                {
                    txtLetterGrade.Text = "B";
                }
                else if (numberGrade >= 70 && numberGrade < 80)
                {
                    txtLetterGrade.Text = "C";
                }
                else if (numberGrade >= 60 && numberGrade < 70)
                {
                    txtLetterGrade.Text = "D";
                }
                else if (numberGrade >= 0 && numberGrade < 60)
                {
                    txtLetterGrade.Text = "F";
                }

                else // monthly investment
                {
                  
                    txtLetterGrade.Text =
                        String.Format("{0:c}", "InValid");
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("OverflowException. Try using number between 0-100.", "Entry Error");
            }
            catch (FormatException)
            {
                MessageBox.Show("All entries must be numeric.", "Entry Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace + ": " + ex.Message, "Unknown Exception");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
