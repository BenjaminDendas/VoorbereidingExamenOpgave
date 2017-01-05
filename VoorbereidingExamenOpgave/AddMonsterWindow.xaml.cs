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
using System.Collections.ObjectModel;

namespace VoorbereidingExamenOpgave
{
    /// <summary>
    /// Interaction logic for AddMonsterWindow.xaml
    /// </summary>
    public partial class AddMonsterWindow : Window
    {
        private ObservableCollection<Monster> monsterCollection;

        public AddMonsterWindow()
        {
            InitializeComponent();
        }

        public AddMonsterWindow(ref ObservableCollection<Monster> monsterCollection)
        {
            InitializeComponent();
            this.monsterCollection = monsterCollection;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (Utillity.CheckAddOrUpdateMonsterFields(nameTextBox, attackTextBox, hpTextBox))
            {
                Monster m = new Monster {
                    MonsterId = MonsterDB.GetNextMonsterId(),
                    Alive = (bool)aliveCheckBox.IsChecked ? true : false,
                    Attack = int.Parse(attackTextBox.Text),
                    HP = int.Parse(hpTextBox.Text),
                    Name = nameTextBox.Text};

                MonsterDB.InsertMonster(m);
                monsterCollection.Add(m);

                MessageBox.Show("Monster Toegevoegd!");
            }
            else
            {
                MessageBox.Show("Gelieve alle velden in te vullen");
            }
        }
    }
}
