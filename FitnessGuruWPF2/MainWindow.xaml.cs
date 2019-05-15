using System.Windows;


namespace FitnessGuruWPF2
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (App.Current.checkLogin(tbUsrNmLogin.Text, tbUsrPsWrdLogin.Text))
            {
                App.Current.memberInfo.ShowDialog();
                App.Current.mainWindow.Hide();
            }
            else
                MessageBox.Show("The entered Username or password are wrong. \nPlease enter your proper username and password", "Login Error");
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            //Add if to check if user already exists
            App.Current.registerUser(tbUsrNmLogin.Text, tbUsrPsWrdLogin.Text);
            App.Current.memberInfo.ShowDialog();
        }

    }
}
