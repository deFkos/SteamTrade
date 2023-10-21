using SteamTrade.baseSelect;
using SteamTrade.Controls.Combobox.cmbCur;
using SteamTrade.Controls.Combobox.cmbGame;
using SteamTrade.Controls.Dockpanel.Animation;
using SteamTrade.Controls.Listbox.listBoxW;
using SteamTrade.Controls.Radiobuttons.rdbuttonQ;
using SteamTrade.datasource.ConnectionAPI.request;
using SteamTrade.datasource.ConnectionAPI.response;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SteamTrade
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            baseSelectBD baseSel = new baseSelectBD();

            List<RadioButton> radioButtons = new List<RadioButton>()
            {
                rdBattle, rdWell, rdField, rdMinimal, rdFactory
            };

            rdQuality rdQuality = new rdQuality(radioButtons);

            cmbcurrency cmbcurrency = new cmbcurrency(cmbCurrency);

            cmbgameid cmbgameid = new cmbgameid(cmbGameid);

            listWeaponBD listWeaponBD = new listWeaponBD(listWeapon1, listWeapon2, listWeapon3);

            List<ListBox> listListBox = new List<ListBox>()
            {
                listWeapon1, listWeapon2, listWeapon3
            };

            List<ComboBox> cmbbox = new List<ComboBox>()
            {
                cmbCurrency
            };

            listListBox.ForEach(x => x.SelectionChanged += (sender, args) =>
            {
               foreach (RadioButton rb in radioButtons)
               {
                    if(rb.IsChecked == true && cmbCurrency.SelectedItem != null )
                    {
                        input();
                    }
               }
            });
            cmbbox.ForEach(x => x.SelectionChanged += (sender, args) =>
            {
                foreach(ListBox lsBox in listListBox)
                {
                    foreach(RadioButton rdbutton in radioButtons)
                    {
                        if (lsBox.SelectedItem != null && rdbutton.IsChecked == true )
                        {
                            input();
                        }
                    }                 
                }
            });
            radioButtons.ForEach(x => x.Checked += (sender, args) =>
            {
                foreach (ListBox lsBox in listListBox)
                {
                    if (lsBox.SelectedItem != null && cmbCurrency.SelectedItem != null)
                    {
                        input();
                    }
                }
            });
            searchTxb.TextChanged += (sender, args) =>
            {
                foreach (ListBox lsBox in listListBox)
                {
                    foreach (RadioButton rdbutton in radioButtons)
                    {
                        if (lsBox.SelectedItem != null && rdbutton.IsChecked == true && cmbCurrency.SelectedItem != null)
                        {
                            input();
                        }
                    }
                }
            };
        }

        public void input()
        {
            List<RadioButton> radioButtons = new List<RadioButton>()
                {
                    rdBattle, rdWell, rdField, rdMinimal, rdFactory
                };
            SelectedWeapon selWep = new SelectedWeapon(listWeapon1, listWeapon2, listWeapon3);
            if (searchTxb.Text.Length > 4)
            {
                foreach (RadioButton radioButton in radioButtons)
                {
                    if (radioButton.IsChecked == true)
                    {
                        Iresponse.skin = searchTxb.Text;
                        requestApi requestApi = new requestApi(cmbCurrency, cmbGameid, radioButton);
                        tex1.Text = Iresponse.Price;
                    }
                }
            }
        }

        public void AnimationPanel()
        {
            Dispatcher.Invoke((Action)(async () =>
            {
                if (Controls.Dockpanel.Animation.IAnimation.configurationSelect)
                {
                    while (mnCategories.Width < (Width / 2.7))
                    {
                        InvokeAnimation();
                        await Task.Delay(1);
                    }
                    Controls.Dockpanel.Animation.IAnimation.configurationSelect = false;
                }
                else
                {
                    while (mnCategories.Width > 150)
                    {
                        InvokeAnimation();
                        await Task.Delay(1);
                    }
                    Controls.Dockpanel.Animation.IAnimation.configurationSelect = true;
                }
            }));
        }
        private void InvokeAnimation()
        {
            Thickness thickness = mnCategories.Margin;
            if (Controls.Dockpanel.Animation.IAnimation.configurationSelect)
            {
                AnimationPanelCateg anPalCateg = new AnimationPanelCateg(thickness, mnCategories);
            }
            else
            {
                AnimationPanelCateg anPalCateg = new AnimationPanelCateg(thickness, mnCategories, -1);
            }
        }

        private void mnCategories_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            AnimationPanel();           
        }

        private void searchTxb_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            searchTxb.Text = null;
        }
    }
}
