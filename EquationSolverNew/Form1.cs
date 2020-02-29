using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace EquationSolverNew
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }

        public int GetNthIndex(string s, char t, int n)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t)
                {
                    count++;
                    if (count == n)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
        double FractionToDouble(string fraction)
        {
            double result;

            if (double.TryParse(fraction, out result))
            {
                return result;
            }

            string[] split = fraction.Split(new char[] { ' ', '/' });

            if (split.Length == 2 || split.Length == 3)
            {
                int a, b;

                if (int.TryParse(split[0], out a) && int.TryParse(split[1], out b))
                {
                    if (split.Length == 2)
                    {
                        return (double)a / b;
                    }

                    int c;

                    if (int.TryParse(split[2], out c))
                    {
                        return a + (double)b / c;
                    }
                }
            }

            throw new FormatException("Not a valid Number.");
        }

        
        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                string check = txtTheEquation.Text;
                char equal = '=';
                
                if (check.IndexOf(equal) != check.LastIndexOf(equal))
                {
                    MessageBox.Show("The Equation May only contain one equal");
                    
                }

                else
                {
                  
                    
                    string[] thequation = txtTheEquation.Text.Split('=');

                    float solution = 0;
                    string[] splitted = thequation[0].Split('x');
                    float RHS = float.Parse(thequation[1]);

                    
                    

                    //Case1 : the Equation is in the form x + b=c

                    if(splitted[0] == "" && splitted[1] != "")
                    {

                  

                        if (float.Parse(splitted[1]) < 0)
                        {
                            solution = RHS + (float.Parse(splitted[1]) * -1);
                        }
                        else if (float.Parse(splitted[1]) > 0)
                        {
                            solution = RHS - float.Parse(splitted[1]);
                        }
                        MessageBox.Show("X = " + solution.ToString(), "The Result!", MessageBoxButtons.OK);
                    }

                    //End Case1

                    //Case2: The Equation is in the form ax = c

                    

                    else if(splitted[1] == "" && splitted[0] != "")
                    {
                        string strsplitted0 = FractionToDouble(splitted[0]).ToString();
                        solution = RHS / float.Parse(strsplitted0);
                        MessageBox.Show("X = " + solution.ToString(), "The Result!", MessageBoxButtons.OK);
                    }

                    //End Case2

                    //Case3 : The Equation is in the form ax + b = c

                    else if(splitted[1] != "" && splitted[0] != "")
                    {
                        string strsplitted0 = FractionToDouble(splitted[0]).ToString();
                        if (float.Parse(splitted[1]) < 0)
                        {

                            RHS = RHS + (float.Parse(splitted[1]) * -1);
                            solution = RHS / float.Parse(strsplitted0);
                        }
                        else if (float.Parse(splitted[1]) > 0)
                        {

                            RHS = RHS - float.Parse(splitted[1]);
                            solution = RHS / float.Parse(strsplitted0);
                        }


                        MessageBox.Show("X = " + solution.ToString(), "The Result!", MessageBoxButtons.OK);
                    }

                    //Case4 : The Equation is in the form x = c

                    else if(splitted[1] == "" && splitted[0] == "")
                    {
                        MessageBox.Show("Please Enter a valid equation and try again!");
                    }

                    //No X

                    else
                    {
                        MessageBox.Show("Error!");
                    }
                   

                    //string[] thequation = txtTheEquation.Text.Split('=');
                    //string[] numbersstring = Regex.Split(thequation[0], @"\D+");
                    //float[] numbers = Array.ConvertAll(numbersstring, s => float.Parse(s));
                    //float RHS = float.Parse(thequation[1]);
                    //float solution = 0;
                    //if (numbers[1] < 0)
                    //{
                    //    MessageBox.Show("the number" + numbers[1].ToString() + "is less than zero");
                    //    RHS = RHS + (numbers[1] * -1);
                    //    solution = RHS / numbers[0];
                    //}
                    //else if (numbers[1] > 0)
                    //{
                    //    MessageBox.Show("the number" + numbers[1].ToString() + "is bigger than zero");
                    //    RHS = RHS - numbers[1];
                    //    solution = RHS / numbers[0];
                    //}

                    //MessageBox.Show(solution.ToString());
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void btnSolve2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] theequation = txtTheEquation2.Text.Split('=');
                string[] splitted = theequation[0].Split('X', 'x');
                double a;
                double b;
                double c;
                double RHS;
                double solution1;
                double solution2;
                string[] splitted2 = theequation[1].Split('x');

                void descrimnant()
                {
                    if ((Math.Pow(b, 2)) - 4 * a * c > 0)
                    {
                        solution1 = (-b + Math.Sqrt(Math.Abs(b * b - 4 * (a * c)))) / (2 * a);
                        solution2 = (-b - Math.Sqrt(Math.Abs(b * b - 4 * (a * c)))) / (2 * a);
                        MessageBox.Show("X1 = " + solution1.ToString() + "\n" + "X2 = " + solution2.ToString(), "The Result!", MessageBoxButtons.OK);
                    }
                    else if ((Math.Pow(b, 2)) - 4 * a * c == 0)
                    {
                        solution1 = (-b + Math.Sqrt(Math.Abs(b * b - 4 * (a * c)))) / (2 * a);
                        solution2 = (-b - Math.Sqrt(Math.Abs(b * b - 4 * (a * c)))) / (2 * a);
                        MessageBox.Show("X = " + solution1.ToString(), "The Result!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        solution1 = (-b + Math.Sqrt(Math.Abs(b * b - 4 * (a * c)))) / (2 * a);
                        solution2 = (-b - Math.Sqrt(Math.Abs(b * b - 4 * (a * c)))) / (2 * a);
                        MessageBox.Show("X1 = " + solution1.ToString() + "i" + "\n" + "X2 = " + solution2.ToString() + "i", "The Result!", MessageBoxButtons.OK);
                    }
                }

                string check = txtTheEquation2.Text;
                char equal = '=';

                if (check.IndexOf(equal) != check.LastIndexOf(equal))
                {
                    MessageBox.Show("The Equation May only contain one equal");

                }

                else
                {
                   
                    

                    if (splitted[0] == "")
                    {
                        a = 1;
                        splitted[0] = "1";
                    }



                    //End Check1

                    //Check2: If aX = -1


                    else if (splitted[0] == "-")
                    {
                        a = -1;
                        splitted[0] = "-1";
                    }

                    else if(splitted[0] != "")
                    {
                        a = FractionToDouble(splitted[0]);

                    }
                    else
                    {
                        a = 0;
                        MessageBox.Show("Error 404");
                    }
                    
                    if (splitted[0] == "")
                    {
                        splitted[0] = "1";
                    }

                    //End Check2





                    //Check5: If aX = 0

                    if (FractionToDouble(splitted[0]) == 0)
                    {
                        MessageBox.Show("The Equation must have X with a value not Equal 0");
                    }

                    //End Check5
                    else
                    {
                        

                       

                       

                        //End Check6

                        //Check3: If bx = 1

                        if (splitted[1] == "+")
                        {
                            if (splitted.Length != 2 && splitted[1] != "")
                            {
                                b = 1;
                                splitted[1] = "1";
                            }
                               
                        }

                        //End Check3

                        //Check4:If bx = -1

                        else if (splitted[1] == "-")
                        {
                            if (splitted.Length != 2 && splitted[1] != "")
                            {
                                b = -1;
                                splitted[1] = "-1";
                            }
                               
                        }
                        else
                        {
                            if (splitted.Length != 2 && splitted[1] != "") {
                                b = FractionToDouble(splitted[1]);
                            }
                                
                        }

                        //End Check4

                        //Check6: If aX = 1

                       
                      




                        //Case1: the Equation is in the form aX + c = 0

                        if (splitted.Length == 2 && splitted2.Length == 1)
                        {
                            
                            if(splitted[1] == "" && splitted[0] != "" && splitted2.Length == 1)
                            {
                                b = 0;
                                c = FractionToDouble(theequation[1]) * -1;

                                descrimnant();
                            }
                            else if(splitted2.Length != 1)
                            {
                                MessageBox.Show("Error");
                            }
                            else
                            {
                                //Check If RHS != 0

                                if (splitted2.Length == 1)
                                {
                                    a = float.Parse(splitted[0]);
                                    b = 0;
                                    c = float.Parse(splitted[1]);
                                    RHS = float.Parse(theequation[1]);
                                    if (RHS > 0)
                                    {
                                        c = c - RHS;
                                    }

                                    else if (RHS < 0)
                                    {
                                        c = c + RHS;
                                    }
                                    else if (RHS == 0)
                                    {
                                        c = float.Parse(splitted[1]);
                                    }
                                    descrimnant();
                                }
                                //End Check

                                else
                                {
                                    if (splitted2[1] == "")
                                    {
                                        if (splitted2[0] == "-")
                                        {
                                            a = FractionToDouble(splitted[0]);
                                            b = ((-1) * -1);
                                            c = FractionToDouble(splitted[1]);
                                        }

                                        else if (splitted2[0] == "")
                                        {
                                            a = FractionToDouble(splitted[0]);
                                            b = ((1) * -1);
                                            c = FractionToDouble(splitted[1]);
                                        }
                                        else
                                        {
                                            a = FractionToDouble(splitted[0]);
                                            b = (FractionToDouble(splitted2[0]) * -1);
                                            c = FractionToDouble(splitted[1]);
                                        }



                                        descrimnant();
                                    }
                                    else
                                    {


                                        RHS = float.Parse(theequation[1]);
                                        MessageBox.Show("this equation dont have x");
                                        a = FractionToDouble(splitted[0]);
                                        b = 0;
                                        c = FractionToDouble(splitted[1]);

                                        //CheckS: If the RHS != 0

                                        if (RHS > 0)
                                        {
                                            c = c - RHS;
                                        }

                                        else if (RHS < 0)
                                        {
                                            c = c + RHS;
                                        }

                                        //End CheckS

                                        descrimnant();
                                    }


                                }
                            }

                        }


                        //End Case1

                        //Case2: The Equation is in the form aX + bx = 0
                        
                        else if (splitted.Length == 3 && splitted[2] == "")
                        {
                            
                            a = FractionToDouble(splitted[0]);
                            b = FractionToDouble(splitted[1]);
                            c = 0;
                            RHS = float.Parse(theequation[1]);
                            //CheckS: If the RHS != 0

                            if (RHS > 0)
                            {
                                c = c - RHS;
                            }

                            else if (RHS < 0)
                            {
                                c = c + RHS;
                            }

                            //End CheckS

                            descrimnant();

                        }

                        //End Case2

                        //Case3: The Equation is in the form aX + bx + c = 0
                        
                        else if (splitted.Length == 3 && splitted[1] != "" && splitted[2] != "")
                        {
                            

                            a = FractionToDouble(splitted[0]);
                            b = FractionToDouble(splitted[1]);
                            c = FractionToDouble(splitted[2]);
                            RHS = float.Parse(theequation[1]);
                            //CheckS: If the RHS != 0

                            if (RHS > 0)
                            {
                                c = c - RHS;
                            }

                            else if (RHS < 0)
                            {
                                c = c + RHS;
                            }

                            //End CheckS


                            descrimnant();
                        }

                        //End Case3

                      //Case4: The Equation is in the form aX = bx + c

                        else if(splitted.Length == 2 && splitted2.Length == 2)
                        {
                            if (splitted2[0] == "" && splitted2[1] != "")
                            {
                                b = 1 * -1;
                                c = FractionToDouble(splitted2[1]) * -1;
                            }
                            else if (splitted2[0] == "-" && splitted2[1] != "")
                            {
                                b = -1 * -1;
                                c = FractionToDouble(splitted2[1]) * -1;
                            }
                            else if(splitted2[0] != "" && splitted2[1] != "")
                            {
                                b = FractionToDouble(splitted2[0]) * -1;
                                c = FractionToDouble(splitted2[1]) * -1;
                            }
                            else
                            {
                                b = 0;
                                c = 0;
                                MessageBox.Show("Error2");
                            }

                            descrimnant();

                        }

                        //End Case4

                        else
                        {
                            MessageBox.Show("Error!");
                        }

                        

                    }
                }

 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        
    }
}
