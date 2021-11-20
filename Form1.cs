using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Calculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool btn0WasClicked = false;
        private bool btn1WasClicked = false;
        private bool btn2WasClicked = false;
        private bool btn3WasClicked = false;
        private int counterBtn0WasClicked = 0;
        private int counterBtn1WasClicked = 0;
        private int counterBtn2WasClicked = 0;
        private int counterBtn3WasClicked = 0;
        private bool btnLogX1WasClicked = false;
        private bool btnLogXAWasClicked = false;
        private bool btnLogXbaseXWasClicked = false;
        private bool btnLogXABWasClicked = false;
        private bool btnLogXBdividesAWasClicked = false;
        private bool btnLogXAdivides1WasClicked = false;
        private bool btnLogXAtoPowerBWasClicked = false;
        private bool btnLogXtoPowerLogXAWasClicked = false;
        private bool btnLogXxNSQRTofAWasClicked = false;
        private bool btnLogXbaseXtoPowerAWasClicked = false;
        private bool btnLnXWasClicked = false;
        private bool btnLnOfAxBSQRTCWasClicked = false;
        private bool btnLogXminus1ofAWasClicked = false;
        private bool btnAtoPowerLogBCWasClicked = false;
        private bool btnLogBSQRTAofCWasClicked = false;
        private bool btnLogAofSQRTBWasClicked = false;
        private bool btnLogXtoPowerKofAWasClicked = false;
        private bool btnLogSQRTAofBWasClicked = false;
        private bool btnLogAofXaddedToLogBofXWasClicked = false;
        private bool btnLogBofXsubtractedFromLogAofXWasClicked = false;
        private bool btnLog1dividedByXofAWasClicked = false;



        private void btnLogX1_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLogX1WasClicked = true;
            log.formula = btnLogX1.Text;
            log.intResult = 0;

        }

        private void btnLogXA_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLogXAWasClicked = true;
            log.formula = btnLogXA.Text;
        }

       
        private void btnLogXbaseX_Click(object sender, EventArgs e)
        {

            Logarithm log;
            log = new Logarithm();
            btnLogXbaseXWasClicked = true;
            log.formula = btnLogXbaseX.Text;

        }

        private void btnLogXAB_Click(object sender, EventArgs e)
        {

            Logarithm log;
            log = new Logarithm();
            btnLogXABWasClicked = true;
            log.formula = btnLogXAB.Text;

        }

        private void btnLogXBdividesA_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLogXBdividesAWasClicked = true;
            log.formula = btnLogXBdividesA.Text;
        }

        private void btnLogXAdivides1_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLogXAdivides1WasClicked = true;
            log.formula = btnLogXAdivides1.Text;
        }

        private void btnLogXAtoPowerB_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLogXAtoPowerBWasClicked = true;
            log.formula = btnLogXAtoPowerB.Text;
        }

        private void btnXtoPowerLogXA_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLogXtoPowerLogXAWasClicked = true;
            log.formula = btnXtoPowerLogXA.Text;

        }

        private void btnLogXxNSQRTofA_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLogXxNSQRTofAWasClicked = true;
            log.formula = btnLogXxNSQRTofA.Text;
        }

        private void btnLogXbaseXtoPowerA_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLogXbaseXtoPowerAWasClicked = true;
            log.formula = btnLogXbaseXtoPowerA.Text;
        }

        private void btnLnX_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLnXWasClicked = true;
            log.formula = btnLnX.Text;
        }

        private void btnLnofAxBSQRTC_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLnOfAxBSQRTCWasClicked = true;
            log.formula = btnLnofAxBSQRTC.Text;
        }

        private  void btnLogXminus1ofA_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLogXminus1ofAWasClicked = true;
            log.formula = btnLogXminus1ofA.Text;
        }

        private void btnAtoPowerLogBC_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnAtoPowerLogBCWasClicked = true;
            log.formula = btnAtoPowerLogBC.Text;
        }

        private void btnLogBSQRTAofC_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLogBSQRTAofCWasClicked = true;
            log.formula = btnLogBSQRTAofC.Text;
        }

        private void btnLogAofSQRTB_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLogAofSQRTBWasClicked = true;
            log.formula = btnLogAofSQRTB.Text;
        }



        private void btnLogXtoPowerKofA_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLogXtoPowerKofAWasClicked = true;
            log.formula = btnLogXtoPowerKofA.Text;
        }

        private void btnLogSQRTAofB_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLogSQRTAofBWasClicked = true;
            log.formula = btnLogSQRTAofB.Text;
        }

        private void btnLogAofXaddedToLogBofX_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLogAofXaddedToLogBofXWasClicked = true;
            log.formula = btnLogAofXaddedToLogBofX.Text;
        }

        private void btnLogBofXsubtractedFromLogAofX_Click(object sender, EventArgs e)
        {
            Logarithm log;
            log = new Logarithm();
            btnLogBofXsubtractedFromLogAofXWasClicked = true;
            log.formula = btnLogBofXsubtractedFromLogAofX.Text;
        }

        private void btnLog1dividedByXofA_Click(object sender, EventArgs e)
        {

            Logarithm log;
            log = new Logarithm();
            btnLog1dividedByXofAWasClicked = true;
            log.formula = btnLog1dividedByXofA.Text;

        }
        
           private void btn0_Click(object sender, EventArgs e)
        {
            btn0WasClicked = true;
            counterBtn0WasClicked++;

            if (btnLogX1WasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                log.intVarX = int.Parse(btn0.Text);
                txtDisplayScreen.Text += '\n';
                log.intResult = (int)Math.Log(1, log.intVarX);
                txtDisplayScreen.Text += $"log{log.intVarX}(1) = ";
                txtDisplayScreen.Text += log.intResult.ToString();
            }

            if (btnLogXAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn0WasClicked == 1) { log.doubleVarX = double.Parse(btn0.Text); }
                else if (counterBtn0WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn0.Text);
                    log.doubleVariableA = double.Parse(btn0.Text);
                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXbaseXWasClicked)
            {
                Logarithm log;
                log = new Logarithm();

                if (counterBtn0WasClicked == 1) { log.doubleVarX = double.Parse(btn0.Text); }
                else if (counterBtn0WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn0.Text);
                    log.doubleVariableA = double.Parse(btn0.Text);
                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.intVarX}({log.intVarX}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }
            
              if (btnLogXABWasClicked)
            {
                Logarithm log;
                log = new Logarithm();

                if (counterBtn0WasClicked == 1) { log.doubleVarX = double.Parse(btn0.Text); }
                else if (counterBtn0WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn0.Text);
                    log.doubleVariableA = double.Parse(btn0.Text);
                }
                else
                {
                    log.doubleVarX = double.Parse(btn0.Text);
                    log.doubleVariableA = double.Parse(btn0.Text);
                    log.doubleVariableB = double.Parse(btn0.Text);

                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX) + Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} * {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXBdividesAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn0WasClicked == 1) { log.doubleVarX = double.Parse(btn0.Text); }
                else if (counterBtn0WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn0.Text);
                    log.doubleVariableA = double.Parse(btn0.Text);
                }
                else
                {
                    log.doubleVarX = double.Parse(btn0.Text);
                    log.doubleVariableA = double.Parse(btn0.Text);
                    log.doubleVariableB = double.Parse(btn0.Text);

                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX) - Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} : {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXAdivides1WasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn0WasClicked == 1) { log.doubleVarX = double.Parse(btn0.Text); }
                else if (counterBtn0WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn0.Text);
                    log.doubleVariableA = double.Parse(btn0.Text);

                    log.doubleResult = -Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}(1:{log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXAtoPowerBWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn0WasClicked == 1) { log.doubleVarX = double.Parse(btn0.Text); }
                else if (counterBtn0WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn0.Text);
                    log.doubleVariableA = double.Parse(btn0.Text);
                }
                else
                {
                    log.doubleVarX = double.Parse(btn0.Text);
                    log.doubleVariableA = double.Parse(btn0.Text);
                    log.doubleVariableB = double.Parse(btn0.Text);

                    log.doubleResult = log.doubleVariableB * Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} ^ {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            btn1WasClicked = true;
            counterBtn1WasClicked++;

            if (btnLogX1WasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                log.intVarX = int.Parse(btn1.Text);
                txtDisplayScreen.Text += '\n';
                txtDisplayScreen.Text += $"log{log.intVarX}(1) = ";
                txtDisplayScreen.Text += log.intResult.ToString(); 
            }

            if (btnLogXAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn1WasClicked == 1) { log.doubleVarX = double.Parse(btn1.Text); }
                else if (counterBtn1WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXbaseXWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                log.intVarX = int.Parse(btn1.Text);
                log.intResult = 1;
                txtDisplayScreen.Text += '\n';
                txtDisplayScreen.Text += $"log{log.intVarX}({log.intVarX}) = ";
                txtDisplayScreen.Text += log.intResult.ToString();
            }

            if (btnLogXABWasClicked)
            {
                Logarithm log;
                log = new Logarithm();

                if (counterBtn1WasClicked == 1) { log.doubleVarX = double.Parse(btn1.Text); }
                else if (counterBtn1WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);
                }
                else
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleVariableB = double.Parse(btn1.Text);

                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX) + Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} * {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXBdividesAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn1WasClicked == 1) { log.doubleVarX = double.Parse(btn1.Text); }
                else if (counterBtn1WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);
                }
                else
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleVariableB = double.Parse(btn1.Text);

                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX) - Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} : {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXAdivides1WasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn1WasClicked == 1) { log.doubleVarX = double.Parse(btn1.Text); }
                else if (counterBtn1WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);

                    log.doubleResult = -Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}(1:{log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXAtoPowerBWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn1WasClicked == 1) { log.doubleVarX = double.Parse(btn1.Text); }
                else if (counterBtn1WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);
                }
                else
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleVariableB = double.Parse(btn1.Text);

                    log.doubleResult = log.doubleVariableB * Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} ^ {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXtoPowerLogXAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn1WasClicked == 1) { log.doubleVarX = double.Parse(btn1.Text); }
                else if (counterBtn1WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);

                    log.doubleResult = log.doubleVariableA;
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"{log.doubleVarX}^log{log.doubleVarX}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXxNSQRTofAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn1WasClicked == 1) { log.doubleVarX = double.Parse(btn1.Text); }
                else if (counterBtn1WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);
                }
                else
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.intVariableN = int.Parse(btn1.Text);

                    log.doubleResult = (double)1 / log.intVariableN * Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}x{log.intVariableN}SQRT({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXbaseXtoPowerAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn1WasClicked == 1) { log.intVarX = int.Parse(btn1.Text); }
                else if (counterBtn1WasClicked == 2)
                {
                    log.intVarX = int.Parse(btn1.Text);
                    log.intVariableA = int.Parse(btn1.Text);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.intVarX}({log.intVarX}^{log.intVariableA}) = ";
                    txtDisplayScreen.Text += log.intResult;
                }
            }

            if (btnLnXWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn1WasClicked == 1)
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleResult = Math.Log(log.doubleVarX, 2.718);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"ln({log.doubleVarX}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }


            if (btnLnOfAxBSQRTCWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn1WasClicked == 1)
                {
                    log.doubleVariableA = double.Parse(btn1.Text);
                }
                else if (counterBtn1WasClicked == 2)

                {
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleVariableB = double.Parse(btn1.Text);
                }
                else

                {
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleVariableB = double.Parse(btn1.Text);
                    log.doubleVariableC = double.Parse(btn1.Text);

                    log.doubleResult = Math.Log(log.doubleVariableA * Math.Pow(log.doubleVariableC, 1 / log.doubleVariableB), 2.718);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"ln({log.doubleVariableA}*{log.doubleVariableB}SQRT({log.doubleVariableC})) = ";
                    txtDisplayScreen.Text += log.doubleResult;

                }
            }
            
               if (btnLogXminus1ofAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn1WasClicked == 1) { log.doubleVarX = double.Parse(btn1.Text); }
                else if (counterBtn1WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);

                    log.doubleResult = 1 / Math.Log(log.doubleVarX - 1, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX - 1}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }


            if (btnAtoPowerLogBCWasClicked)
            {
                Logarithm log;
                log = new Logarithm();

                if (counterBtn1WasClicked == 1)
                {
                    log.doubleVariableA = double.Parse(btn1.Text);
                }

                else if (counterBtn1WasClicked == 2)

                {
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleVariableB = double.Parse(btn1.Text);
                }

                else
                {
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleVariableB = double.Parse(btn1.Text);
                    log.doubleVariableC = double.Parse(btn1.Text);

                    // log.doubleResult = Math.Pow(log.doubleVariableA, Math.Log(log.doubleVariableC, log.doubleVariableB));
                    log.doubleResult = log.doubleVariableA * Math.Log(log.doubleVariableC, log.doubleVariableB);

                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"{log.doubleVariableC}^log{log.doubleVariableB}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogBSQRTAofCWasClicked)
            {
                Logarithm log;
                log = new Logarithm();

                if (counterBtn1WasClicked == 1)
                {
                    log.doubleVariableA = double.Parse(btn1.Text);
                }

                else if (counterBtn1WasClicked == 2)
                {
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleVariableB = double.Parse(btn1.Text);
                }

                else

                {
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleVariableB = double.Parse(btn1.Text);
                    log.doubleVariableC = double.Parse(btn1.Text);

                    log.doubleResult = log.doubleVariableB * Math.Log(log.doubleVariableC, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVariableB}SQRT{log.doubleVariableA}({log.doubleVariableC}) = ";
                    txtDisplayScreen.Text += log.doubleResult;

                }
            }

            if (btnLogAofSQRTBWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn1WasClicked == 1) { log.doubleVariableA = double.Parse(btn1.Text); }
                else if (counterBtn1WasClicked == 2)
                {
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleVariableB = double.Parse(btn1.Text);

                    log.doubleResult = (double)1 / 2 * Math.Log(log.doubleVariableB, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVariableA}(SQRT({log.doubleVariableB})) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }
            


            if (btnLogXtoPowerKofAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();

                if (counterBtn1WasClicked == 1)
                {
                    log.doubleVariableA = double.Parse(btn1.Text);
                }

                else if (counterBtn1WasClicked == 2)

                {
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleVarX = double.Parse(btn1.Text);
                }

                else

                {
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.intVariableK = int.Parse(btn1.Text);

                    log.doubleResult = (double)1 / log.intVariableK * Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}^{log.intVariableK}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;

                }
            } 
            
            if (btnLogSQRTAofBWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn1WasClicked == 1) { log.doubleVariableA = double.Parse(btn1.Text); }
                else if (counterBtn1WasClicked == 2)
                {
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleVariableB = double.Parse(btn1.Text);

                    log.doubleResult = 2 * Math.Log(log.doubleVariableB, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"logSQRT{log.doubleVariableA}({log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }
            
             if (btnLogAofXaddedToLogBofXWasClicked)
            {
                Logarithm log;
                log = new Logarithm();

                if (counterBtn1WasClicked == 1) { log.doubleVarX = double.Parse(btn1.Text); }

                else if (counterBtn1WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);
                }

                else
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleVariableB = double.Parse(btn1.Text);

                    //log.doubleResult = Math.Pow(log.doubleVariableA, (Math.Log(log.doubleVariableB, log.doubleVariableA))/ (Math.Log(log.doubleVariableB, log.doubleVariableA)+1));

                    log.doubleResult = 2 * Math.Log(log.doubleVarX, log.doubleVariableA);
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA}) + log{log.doubleVarX}({log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogBofXsubtractedFromLogAofXWasClicked)
            {
                Logarithm log;
                log = new Logarithm();

                if (counterBtn1WasClicked == 1) { log.doubleVarX = double.Parse(btn1.Text); }
                else if (counterBtn1WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);
                }
                else
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);
                    log.doubleVariableB = double.Parse(btn1.Text);

                    log.doubleResult = Math.Log(log.doubleVarX, log.doubleVariableA) - Math.Log(log.doubleVarX, log.doubleVariableA);
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA}) - log{log.doubleVarX}({log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLog1dividedByXofAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();

                if (counterBtn1WasClicked == 1) { log.doubleVarX = double.Parse(btn1.Text); }
                else if (counterBtn1WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn1.Text);
                    log.doubleVariableA = double.Parse(btn1.Text);

                    log.doubleResult = -Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log1/{log.doubleVarX}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }
            
        }




        private void btn2_Click(object sender, EventArgs e)
        {
            btn2WasClicked = true;
            counterBtn2WasClicked++;

            if (btnLogX1WasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                log.intVarX = int.Parse(btn2.Text);
                txtDisplayScreen.Text += '\n';
                txtDisplayScreen.Text += $"log{log.intVarX}(1) = ";
                txtDisplayScreen.Text += log.intResult.ToString();
            }

            if (btnLogXAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1) { log.doubleVarX = double.Parse(btn2.Text); }
                else if (counterBtn2WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);

                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

         

            if (btnLogXbaseXWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                log.intVarX = int.Parse(btn2.Text);
                log.intResult = 1;
                txtDisplayScreen.Text += '\n';
                txtDisplayScreen.Text += $"log{log.intVarX}({log.intVarX}) = ";
                txtDisplayScreen.Text += log.intResult.ToString();
            }


            if (btnLogXABWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1) { log.doubleVarX = double.Parse(btn2.Text); }
                else if (counterBtn2WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                }
                else
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);

                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX) + Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} * {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXBdividesAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1) { log.doubleVarX = double.Parse(btn2.Text); }
                else if (counterBtn2WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                }
                else
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);

                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX) - Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} : {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXAdivides1WasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1) { log.doubleVarX = double.Parse(btn2.Text); }
                else if (counterBtn2WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);

                    log.doubleResult = -Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}(1:{log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }



            if (btnLogXAtoPowerBWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1) { log.doubleVarX = double.Parse(btn2.Text); }
                else if (counterBtn2WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                }
                else
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);

                    log.doubleResult = log.doubleVariableB * Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} ^ {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXtoPowerLogXAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1) { log.doubleVarX = double.Parse(btn2.Text); }
                else if (counterBtn2WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);

                    log.doubleResult = log.doubleVariableA;
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"{log.doubleVarX}^log{log.doubleVarX}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXxNSQRTofAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1) { log.doubleVarX = double.Parse(btn2.Text); }
                else if (counterBtn2WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                }
                else
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.intVariableN = int.Parse(btn2.Text);

                    log.doubleResult = (double)1 / log.intVariableN * Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}x{log.intVariableN}SQRT({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXbaseXtoPowerAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1) { log.intVarX = int.Parse(btn2.Text); }
                else if (counterBtn2WasClicked == 2)
                {
                    log.intVarX = int.Parse(btn2.Text);
                    log.intVariableA = int.Parse(btn2.Text);

                    log.intResult = log.intVariableA;
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.intVarX}({log.intVarX}^{log.intVariableA}) = ";
                    txtDisplayScreen.Text += log.intResult;
                }
            }

            if (btnLnXWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1)
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleResult = Math.Log(log.doubleVarX, 2.718);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"ln({log.doubleVarX}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLnOfAxBSQRTCWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1)
                {
                    log.doubleVariableA = double.Parse(btn2.Text);
                }
                else if (counterBtn2WasClicked == 2)

                {
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);
                }
                else 

                {
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);
                    log.doubleVariableC = double.Parse(btn2.Text);

                    log.doubleResult = Math.Log(log.doubleVariableA * Math.Pow(log.doubleVariableC, 1 / log.doubleVariableB), 2.718);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"ln({log.doubleVariableA}*{log.doubleVariableB}SQRT({log.doubleVariableC})) = ";
                    txtDisplayScreen.Text += log.doubleResult;

                }

            }



           

            if (btnLogXminus1ofAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1) { log.doubleVarX = double.Parse(btn2.Text); }
                else if (counterBtn2WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);

                    log.doubleResult = 1 / Math.Log(log.doubleVarX-1, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX-1}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }


            if (btnAtoPowerLogBCWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1)
                {
                    log.doubleVariableA = double.Parse(btn2.Text);
                }
                else if (counterBtn2WasClicked == 2)

                {
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);
                }
                else

                {
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);
                    log.doubleVariableC = double.Parse(btn2.Text);

                    log.doubleResult = Math.Pow(log.doubleVariableC, Math.Log(log.doubleVariableA, log.doubleVariableB)); 
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"{log.doubleVariableC}^log{log.doubleVariableB}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;

                }

            }

            if (btnLogBSQRTAofCWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1)
                {
                    log.doubleVariableA = double.Parse(btn2.Text);
                }

                else if (counterBtn2WasClicked == 2)
                {
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);
                }

                else

                {
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);
                    log.doubleVariableC = double.Parse(btn2.Text);

                    log.doubleResult = log.doubleVariableB * Math.Log(log.doubleVariableC, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVariableB}SQRT{log.doubleVariableA}({log.doubleVariableC}) = ";
                    txtDisplayScreen.Text += log.doubleResult;

                }

            }

            if (btnLogAofSQRTBWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1) { log.doubleVariableA = double.Parse(btn2.Text); }
                else if (counterBtn2WasClicked == 2)
                {
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);

                    log.doubleResult = (double)1/2*Math.Log(log.doubleVariableB, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVariableA}(SQRT({log.doubleVariableB})) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogXtoPowerKofAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();

                if (counterBtn2WasClicked == 1)
                {
                    log.doubleVariableA = double.Parse(btn2.Text);
                }
                else if (counterBtn2WasClicked == 2)

                {
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVarX = double.Parse(btn2.Text);
                }
                else

                {
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.intVariableK = int.Parse(btn2.Text);

                    log.doubleResult = (double)1 / log.intVariableK * Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}^{log.intVariableK}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;

                }
            }

            if (btnLogSQRTAofBWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1) { log.doubleVariableA= double.Parse(btn2.Text); }
                else if (counterBtn2WasClicked == 2)
                {
                    log.doubleVariableA= double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);

                    log.doubleResult = 2* Math.Log(log.doubleVariableB, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"logSQRT{log.doubleVariableA}({log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogAofXaddedToLogBofXWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1) { log.doubleVarX = double.Parse(btn2.Text); }
                else if (counterBtn2WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                }
                else
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);

                    //log.doubleResult = Math.Pow(log.doubleVariableA, (Math.Log(log.doubleVariableB, log.doubleVariableA))/ (Math.Log(log.doubleVariableB, log.doubleVariableA)+1));


                    log.doubleResult = 2 * Math.Log(log.doubleVarX, log.doubleVariableA);
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA}) + log{log.doubleVarX}({log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLogBofXsubtractedFromLogAofXWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1) { log.doubleVarX = double.Parse(btn2.Text); }
                else if (counterBtn2WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                }
                else
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);

                    log.doubleResult = Math.Log(log.doubleVarX, log.doubleVariableA) - Math.Log(log.doubleVarX, log.doubleVariableA);
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA}) - log{log.doubleVarX}({log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }

            if (btnLog1dividedByXofAWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                if (counterBtn2WasClicked == 1) { log.doubleVarX = double.Parse(btn2.Text); }
                else if (counterBtn2WasClicked == 2)
                {
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);

                    log.doubleResult = - Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log1/{log.doubleVarX}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }
        }


        private void btn3_Click(object sender, EventArgs e)
        {
            btn3WasClicked = true;

            counterBtn3WasClicked++;

            if (btnLogX1WasClicked)
            {
                Logarithm log;
                log = new Logarithm();
                log.intVarX = int.Parse(btn3.Text);
                txtDisplayScreen.Text += '\n';
                txtDisplayScreen.Text += $"log{log.intVarX}(1) = ";
                txtDisplayScreen.Text += log.intResult.ToString();
            }


            if (btnLogXAWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn3.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

            }

            if (btnLogXABWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX) + Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} * {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 2 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX) + Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} * {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 3)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn3.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX) + Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} * {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }
            }


            else if (btnLogXBdividesAWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX) - Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} : {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 2 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX) - Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} : {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 3)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn3.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = Math.Log(log.doubleVariableA, log.doubleVarX) - Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} : {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

            }


            if (btnLogXAdivides1WasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleResult = -Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}(1:{log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn3.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleResult = -Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}(1:{log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }
            
            }

            if (btnLogXAtoPowerBWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = log.doubleVariableB * Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} ^ {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 2 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = log.doubleVariableB *  Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} ^ {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 3)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn3.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = log.doubleVariableB * Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA} ^ {log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }
            }


            if (btnLogXtoPowerLogXAWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleResult = log.doubleVariableA;
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"{log.doubleVarX} ^ log{log.doubleVarX}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn3.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleResult = log.doubleVariableA;
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"{log.doubleVarX} ^ log{log.doubleVarX}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

            }

            if (btnLogXxNSQRTofAWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.intVariableN = int.Parse(btn3.Text);
                    log.doubleResult = (double)1 / log.intVariableN * Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}x{log.intVariableN}SQRT({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 2 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.intVariableN= int.Parse(btn3.Text);
                    log.doubleResult = (double)1 / log.intVariableN * Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}x{log.intVariableN}SQRT({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 3)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn3.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.intVariableN = int.Parse(btn3.Text);
                    log.doubleResult = (double)1 / log.intVariableN * Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}x{log.intVariableN}SQRT({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }
            }

            if (btnLogXbaseXtoPowerAWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.intVarX = int.Parse(btn2.Text);
                    log.intVariableA = int.Parse(btn3.Text);
                    log.doubleResult = log.intVariableA;
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.intVarX}({log.intVarX}^{log.intVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.intVarX = int.Parse(btn3.Text);
                    log.intVariableA = int.Parse(btn3.Text);
                    log.doubleResult = log.intVariableA;
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.intVarX}({log.intVarX}^{log.intVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

            }


            if (btnLnOfAxBSQRTCWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleVariableC = double.Parse(btn3.Text);
                    log.doubleResult = Math.Log(log.doubleVariableA * Math.Pow(log.doubleVariableC, 1 / log.doubleVariableB), 2.718);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"ln({log.doubleVariableA}*{log.doubleVariableB}SQRT({log.doubleVariableC})) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 2 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);
                    log.doubleVariableC = double.Parse(btn3.Text);
                    log.doubleResult = Math.Log(log.doubleVariableA * Math.Pow(log.doubleVariableC, 1 / log.doubleVariableB), 2.718);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"ln({log.doubleVariableA}*{log.doubleVariableB}SQRT({log.doubleVariableC})) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 3)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleVariableC = double.Parse(btn3.Text);
                    log.doubleResult = Math.Log(log.doubleVariableA * Math.Pow(log.doubleVariableC, 1 / log.doubleVariableB), 2.718);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"ln({log.doubleVariableA}*{log.doubleVariableB}SQRT({log.doubleVariableC})) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }
            
            }

            if (btnLnXWasClicked)
            {
                Logarithm log;
                log = new Logarithm();
               
                if (counterBtn3WasClicked == 1)
                {
                    log.doubleVarX = double.Parse(btn3.Text);
                    log.doubleResult = Math.Log(log.doubleVarX, 2.718);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"ln({log.doubleVarX}) = ";
                    txtDisplayScreen.Text += log.doubleResult;
                }
            }


            if (btnLogXminus1ofAWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleResult = 1 / Math.Log(log.doubleVarX - 1, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX - 1}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn3.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleResult = 1 / Math.Log(log.doubleVarX - 1, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX - 1}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }
            }

            if (btnAtoPowerLogBCWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleVariableC = double.Parse(btn3.Text);
                    log.doubleResult = Math.Pow(log.doubleVariableC, Math.Log(log.doubleVariableA, log.doubleVariableB));
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"{log.doubleVariableC}^log{log.doubleVariableB}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 2 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);
                    log.doubleVariableC = double.Parse(btn3.Text);
                    log.doubleResult = Math.Pow(log.doubleVariableC, Math.Log(log.doubleVariableA, log.doubleVariableB));
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"{log.doubleVariableC}^log{log.doubleVariableB}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 3)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleVariableC = double.Parse(btn3.Text);
                    log.doubleResult = Math.Pow(log.doubleVariableC, Math.Log(log.doubleVariableA, log.doubleVariableB));
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"{log.doubleVariableC}^log{log.doubleVariableB}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }
            }

            if (btnLogBSQRTAofCWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleVariableC = double.Parse(btn3.Text);
                    log.doubleResult = log.doubleVariableB * Math.Log(log.doubleVariableC, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVariableB}SQRT{log.doubleVariableA}({log.doubleVariableC}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 2 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn2.Text);
                    log.doubleVariableC = double.Parse(btn3.Text);
                    log.doubleResult = log.doubleVariableB * Math.Log(log.doubleVariableC, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVariableB}SQRT{log.doubleVariableA}({log.doubleVariableC}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 3)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleVariableC = double.Parse(btn3.Text);
                    log.doubleResult = log.doubleVariableB * Math.Log(log.doubleVariableC, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVariableB}SQRT{log.doubleVariableA}({log.doubleVariableC}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }
            }


            if (btnLogAofSQRTBWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = (double)1 / 2 * Math.Log(log.doubleVariableB, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVariableA}(SQRT({log.doubleVariableB})) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = (double)1 / 2 * Math.Log(log.doubleVariableB, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVariableA}(SQRT({log.doubleVariableB})) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

            }


            if (btnLogXtoPowerKofAWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVarX = double.Parse(btn3.Text);
                    log.intVariableK = int.Parse(btn3.Text);
                    log.doubleResult = (double)1 / log.intVariableK * Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}^{log.intVariableK}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 2 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.intVariableK = int.Parse(btn3.Text);
                    log.doubleResult = (double)1 / log.intVariableK * Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}^{log.intVariableK}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 3)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVarX = double.Parse(btn3.Text);
                    log.intVariableK = int.Parse(btn3.Text);
                    log.doubleResult = (double)1 / log.intVariableK * Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}^{log.intVariableK}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }
            }


            if (btnLogSQRTAofBWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = 2 * Math.Log(log.doubleVariableB, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"logSQRT{log.doubleVariableA}({log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = 2 * Math.Log(log.doubleVariableB, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"logSQRT{log.doubleVariableA}({log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

            }

            if (btnLogAofXaddedToLogBofXWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = 2 * Math.Log(log.doubleVarX, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA}) + log{log.doubleVarX}({log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 2 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    if (log.doubleVariableB - log.doubleVariableA == 1) 
                    {
                        log.doubleResult = 1 + Math.Log(log.doubleVarX, log.doubleVariableA);
                    }
                    log.doubleResult = Math.Log(log.doubleVarX, log.doubleVariableA) + Math.Log(log.doubleVarX, log.doubleVariableA) / Math.Log(log.doubleVariableB, log.doubleVariableA); 
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA}) + log{log.doubleVarX}({log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 3)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn3.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = 2 * Math.Log(log.doubleVarX, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA}) + log{log.doubleVarX}({log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }
            }

            if (btnLogBofXsubtractedFromLogAofXWasClicked)
            {

                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = Math.Log(log.doubleVarX, log.doubleVariableA) - Math.Log(log.doubleVarX, log.doubleVariableB);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA}) + log{log.doubleVarX}({log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 2 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn2.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    if (log.doubleVariableB - log.doubleVariableA == 1)
                    {
                        log.doubleResult = 1 + Math.Log(log.doubleVarX, log.doubleVariableA);
                    }
                    log.doubleResult = Math.Log(log.doubleVarX, log.doubleVariableA) - Math.Log(log.doubleVarX, log.doubleVariableA) / Math.Log(log.doubleVariableB, log.doubleVariableA);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA}) + log{log.doubleVarX}({log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                else if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 3)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn3.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleVariableB = double.Parse(btn3.Text);
                    log.doubleResult = Math.Log(log.doubleVarX, log.doubleVariableA) - Math.Log(log.doubleVarX, log.doubleVariableB);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log{log.doubleVarX}({log.doubleVariableA}) + log{log.doubleVarX}({log.doubleVariableB}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }
            }

            if (btnLog1dividedByXofAWasClicked)
            {
                if (btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 1 && counterBtn3WasClicked == 1)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn2.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleResult = - Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log1/{log.doubleVarX}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }

                if (!btn2WasClicked && btn3WasClicked && counterBtn2WasClicked == 0 && counterBtn3WasClicked == 2)
                {
                    Logarithm log;
                    log = new Logarithm();
                    log.doubleVarX = double.Parse(btn3.Text);
                    log.doubleVariableA = double.Parse(btn3.Text);
                    log.doubleResult = - Math.Log(log.doubleVariableA, log.doubleVarX);
                    txtDisplayScreen.Text += '\n';
                    txtDisplayScreen.Text += $"log1/{log.doubleVarX}({log.doubleVariableA}) = ";
                    txtDisplayScreen.Text += log.doubleResult.ToString();
                }
            }
        }
    }
}
