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
                MessageBox.Show("Please specify a birthdate first.", "Birthdate required.");
                return;
            }
            DateTime birthDate = dateBirthDate.SelectedDate.GetValueOrDefault();

            FlowDocument myFlowDoc = new FlowDocument();
            Paragraph DateInfoText = new Paragraph();
            DateInfoText.Inlines.Add(new Bold(new Run(ConsoleTest.DateHelper.CurrentDate())));
            DateInfoText.Inlines.Add(new LineBreak());
            DateInfoText.Inlines.Add(ConsoleTest.DateHelper.YourAge(birthDate));
            DateInfoText.Inlines.Add(new LineBreak());
            DateInfoText.Inlines.Add(ConsoleTest.DateHelper.DaysToBirthday(birthDate));
            DateInfoText.Inlines.Add(new LineBreak());
            DateInfoText.Inlines.Add(ConsoleTest.DateHelper.OutputStarSign(birthDate));

            myFlowDoc.Blocks.Add(DateInfoText);
            rtbOutput.Document = myFlowDoc;
        }
    }
}
