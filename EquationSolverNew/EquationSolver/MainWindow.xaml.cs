using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EquationSolver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Show all the controls related to the coefficent entery
            lbA.Visibility = Visibility.Visible;
            lbB.Visibility = Visibility.Visible;
            lbC.Visibility = Visibility.Visible;

            txtA.Visibility = Visibility.Visible;
            txtB.Visibility = Visibility.Visible;
            txtC.Visibility = Visibility.Visible;

            //Hide all the controls related to the equation entry
            lbEnterEquation.Visibility = Visibility.Hidden;
            txtEquation.Visibility = Visibility.Hidden;
            lbTip.Visibility = Visibility.Hidden;
            lbTip1.Visibility = Visibility.Hidden;
            lbTip2.Visibility = Visibility.Hidden;

            rbUseCoefficents.IsChecked = true;
        }

        private void btnSolve_Click(object sender, RoutedEventArgs e)
        {
            string Solution1 = "";
            string Solution2 = "";
            MathOperations mo = new MathOperations();

            //If the user will enter the equation, then use the equation written to solve
            if (rbEnterEquation.IsChecked == true)
            {
                
                EquationDataExtractor edx = new EquationDataExtractor(txtEquation.Text);

                double a = edx.a;
                double b = edx.b;
                double c = edx.c;

                Solution1 = mo.SolveQuadraticEquation(a, b, c).Solution1;
                Solution2 = mo.SolveQuadraticEquation(a, b, c).Solution2;
            }

            //If the user will enter the coefficents, then use them to solve the equation
            else
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);
                Solution1 = mo.SolveQuadraticEquation(a, b, c).Solution1;
                Solution2 = mo.SolveQuadraticEquation(a, b, c).Solution2;
            }

            //Show the 2 solutions of the equation if both of them exist
            if (Solution2 != "")
            {
                MessageBox.Show("X1 = " + "\n\n" + Solution1 + "\n\n" + "X2 = " + "\n\n" + Solution2);
            }

            //Show the solution if only 1 exist
            else
            {
                MessageBox.Show("X = " + Solution1);
            }

        }

        private void rbUseCoefficents_Checked(object sender, RoutedEventArgs e)
        {
            //Show all the controls related to the coefficent entery
            lbA.Visibility = Visibility.Visible;
            lbB.Visibility = Visibility.Visible;
            lbC.Visibility = Visibility.Visible;

            txtA.Visibility = Visibility.Visible;
            txtB.Visibility = Visibility.Visible;
            txtC.Visibility = Visibility.Visible;

            //Hide all the controls related to the equation entry
            lbEnterEquation.Visibility = Visibility.Hidden;
            txtEquation.Visibility = Visibility.Hidden;
            lbTip.Visibility = Visibility.Hidden;
            lbTip1.Visibility = Visibility.Hidden;
            lbTip2.Visibility = Visibility.Hidden;
        }

        private void rbEnterEquation_Checked(object sender, RoutedEventArgs e)
        {
            //Show all the controls related to the equation entry
            lbEnterEquation.Visibility = Visibility.Visible;
            txtEquation.Visibility = Visibility.Visible;
            lbTip.Visibility = Visibility.Visible;
            lbTip1.Visibility = Visibility.Visible;
            lbTip2.Visibility = Visibility.Visible;

            //Hide all the controls related to the coefficent entery
            lbA.Visibility = Visibility.Hidden;
            lbB.Visibility = Visibility.Hidden;
            lbC.Visibility = Visibility.Hidden;

            txtA.Visibility = Visibility.Hidden;
            txtB.Visibility = Visibility.Hidden;
            txtC.Visibility = Visibility.Hidden;
        }
    }
}
