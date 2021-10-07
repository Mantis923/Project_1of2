/// HomeWork 4  (Graded Assignment)    
/// File Name: Homework_Week4_GradedAssin_1
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola
///
///This is a GUI program that reads in the amount of a monthly mortgage payment 
///and the outstanding balance (i.e., the amount still owed) and then outputs the amount of 
///the payment that goes to interest and the amount that goes to 
///principal (i.e., the amount that goes to reducing the debt). The annual interest payment is 6.39%.
/// A defined constant for the interest rate.The payments are made monthly, so the interest is only one-tenth
/// of the annual interest rate of 6.39 percent.

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

namespace Homework_Week4_GradedAssin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterResultsButton_Click(object sender, RoutedEventArgs e)
        {
            //double InterestPayment, out_standing_balance, NumberOfPayments = 360;
            const double InterestRate = .0639;
            double monthlyRate = InterestRate / 12;
            double outstandingBalance = 250000;//@ 30 years which is 360 months



            double MonthlyMortagePayment = Convert.ToDouble(MonthlyMortagePaymentTextBox.Text);//1560.66

            double OutstandingBalance = Convert.ToDouble(OutstandingBalanceTextBox.Text);//250,000



            double monthlyInterestAmount = outstandingBalance * monthlyRate;

            double PrincleAmount = MonthlyMortagePayment - monthlyInterestAmount;



            MessageBox.Show("The amount that goes to payment that goes to interest is  : " + monthlyInterestAmount + " " +
                " and the payment amount that goes to principle is: " + " " + PrincleAmount);



        }
    }
}
