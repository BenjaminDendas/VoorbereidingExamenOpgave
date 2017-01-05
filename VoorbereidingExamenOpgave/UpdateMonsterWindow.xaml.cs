using Ado3LagenMonster;
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

namespace VoorbereidingExamenOpgave
{
    /// <summary>
    /// Interaction logic for UpdateMonsterWindow.xaml
    /// </summary>
    public partial class UpdateMonsterWindow : Window
    {
        public Monster MObject { get; set; }
        public UpdateMonsterWindow(Monster M)
        {
            InitializeComponent();
            MObject = M;
            hpTextBox.DataContext = MObject;
            nameTextBox.DataContext = MObject;
            attackTextBox.DataContext = MObject;
            aliveCheckBox.DataContext = MObject;
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            if(Utillity.CheckAddOrUpdateMonsterFields(nameTextBox,attackTextBox,hpTextBox))
            {
                MonsterDB.UpdateMonster(this.MObject);
                MessageBox.Show("Monster updated");
            }
        }
    }
}
