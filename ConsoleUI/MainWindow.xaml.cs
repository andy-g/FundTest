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

namespace ConsoleUI
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

        private void btnGetInfo_Click(object sender, RoutedEventArgs e)
        {
            if (dateBirthDate.SelectedDate == null)
            {
                MessageBox.Show("Please specify a birthdate first.");
                return;
            }
            DateTime birthDate = dateBirthDate.SelectedDate.GetValueOrDefault();

            //FlowDocument myFlowDoc = new FlowDocument();
            //myFlowDoc.Blocks.Add(new Paragraph(new Run(ConsoleTest.DateHelper.CurrentDate())));
            //myFlowDoc.Blocks.Add(new Paragraph(new Run(ConsoleTest.DateHelper.YourAge(birthDate))));
            //myFlowDoc.Blocks.Add(new Paragraph(new Run(ConsoleTest.DateHelper.DaysToBirthday(birthDate))));
            //myFlowDoc.Blocks.Add(new Paragraph(new Run()));

            //txtOutput.Document = myFlowDoc;
            txtOutput.Text = String.Format("{0}\n{1}\n{2}\n{3}",
                ConsoleTest.DateHelper.CurrentDate(),
                ConsoleTest.DateHelper.YourAge(birthDate),
                ConsoleTest.DateHelper.DaysToBirthday(birthDate),
                ConsoleTest.DateHelper.OutputStarSign(birthDate));
        }
    }
}
