using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDo_Tasks_App
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

        private void Add_Task_Btn_Click(object sender, RoutedEventArgs e)
        {
            if (TextBox_1.Text == null) {
                TextBox_1.Text = tskfield.Text ;
                tskfield.Text = " ";
                return;
            }
            else if(TextBox_1.Text!=null)
            {
                TextBox_2.Text=tskfield.Text ;
                tskfield.Text = " ";
            }
            else if (TextBox_2.Text!=null) 
            {
                TextBox_3.Text=tskfield.Text  ;
                tskfield.Text = " ";
            }

        }
    }
}