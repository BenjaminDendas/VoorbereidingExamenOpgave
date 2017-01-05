using Ado3LagenMonster;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for MonsterWindow.xaml
    /// </summary>
    public partial class MonsterWindow : Window
    {
        private List<Monster> monsterList = null;
        private ObservableCollection<Monster> monsterCollection = new ObservableCollection<Monster>();
        public MonsterWindow()
        {
            InitializeComponent();
            monsterList = MonsterDB.GetMonsters();

            foreach(Monster m in monsterList)
            {
                monsterCollection.Add(m);
            }

            monsterDataGrid.DataContext = monsterCollection;
            monsterDataGrid.ColumnWidth = 70;
            monsterDataGrid.CanUserResizeColumns = true;
            monsterDataGrid.CanUserAddRows = false;
            monsterDataGrid.CanUserSortColumns = false;
            monsterDataGrid.CanUserDeleteRows = false;
            monsterDataGrid.CanUserReorderColumns = false;
            monsterDataGrid.IsReadOnly = true;
        }

        private void deleteMonsterButton_Click(object sender, RoutedEventArgs e)
        {
            if(monsterDataGrid.SelectedItem != null)
            {
                Monster m = (Monster)monsterDataGrid.SelectedItem;
                var bericht = MessageBox.Show("Bent u zeker dat u dit monster wilt verwijderen?", "Monster Verwijderen?", MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
                if (bericht == MessageBoxResult.Yes)
                {
                    MonsterDB.DeleteMonster(m);
                    monsterCollection.Remove(m);
                }
            }
            else
            {
                MessageBox.Show("Gelieve een monster te selecteren");
            }     
        }

        private void updateMonsterButton_Click(object sender, RoutedEventArgs e)
        {
            if(monsterDataGrid.SelectedItem != null)
            {
                Monster m = (Monster)monsterDataGrid.SelectedItem;
                UpdateMonsterWindow um = new UpdateMonsterWindow(m);
                um.ShowDialog();
            }
            else
            {
                MessageBox.Show("Gelieve een monster te selecteren");
            }
        }

        private void addMonsterButton_Click(object sender, RoutedEventArgs e)
        {
            AddMonsterWindow am = new AddMonsterWindow(ref monsterCollection);
            am.ShowDialog();
        }

        private void monsterDataGrid_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            monsterDataGrid.DataContext = monsterCollection;
        }
    }
}
