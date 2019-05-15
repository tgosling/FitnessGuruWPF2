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
using System.Windows.Shapes;

namespace FitnessGuruWPF2
{
    /// <summary>
    /// Interaction logic for MemberInfo.xaml
    /// </summary>
    
    public enum MonthOptions { Jan=1, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec}
    public partial class MemberInfo : Window
    {
        public MemberInfo()
        {
            InitializeComponent();

            //Populate year comobo box
            for (int i = (DateTime.UtcNow.Year - 18); i >= 1910; --i)
                cmbYear.Items.Add(i);
            //populate months combo box
            foreach (var month in Enum.GetNames(typeof(MonthOptions)))
                cmbMonth.Items.Add(month);
            //TO-DO: Poulate day in comobo box, counting for leap year and month
            for (int i = 0; i <= 31; ++i)
                cmbDay.Items.Add(i);

            //Populate provinces
            string[] provinces = new string[] { Properties.Resources.shrtAlb, Properties.Resources.shrtBC, Properties.Resources.shrtMN, Properties.Resources.shrtNB,
                Properties.Resources.shrtNF,  Properties.Resources.shrtNWT, Properties.Resources.shrtNS, Properties.Resources.shrtNU, Properties.Resources.shrtONT, Properties.Resources.shrtPEI,
                Properties.Resources.shrtQUE,Properties.Resources.shrtSASK, Properties.Resources.shrtYUK };

            foreach(string prov in provinces)
                cmbUsrPrv.Items.Add(prov);

            //populate trainers
            string[] trainers = new string[] {Properties.Resources.Train0, Properties.Resources.Train1, Properties.Resources.Train2,
                        Properties.Resources.Train3, Properties.Resources.Train4, Properties.Resources.Train5};

            foreach (string trainer in trainers)
                cmBoxUsrTrain.Items.Add(trainer);

        }
    }
}
