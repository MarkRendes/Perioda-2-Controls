﻿using System;
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
using System.Threading;

namespace WpfApp1
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

        public static bool a = true;
        public static int getal=1;



        private void btnTopLeft_Click(object sender, RoutedEventArgs e)
        {
            
            if (a==true)
            {
                btnTopLeft.IsEnabled = false;
                imgTopLeft.Visibility = Visibility.Visible;
                AI();
                win();
                a = true;
            }
            else if (a == false)
            {
                btnTopLeft.IsEnabled = false;
                imgTopLeft2.Visibility = Visibility.Visible;
                AI();
                win();
                a = false;
            }
            else
            {
                
            }

            if (a == true)
            {
                lblPlayer.Visibility = Visibility.Visible;
                lblPlayer2.Visibility = Visibility.Hidden;

            }
            else if (a == false)
            {
                lblPlayer.Visibility = Visibility.Hidden;
                lblPlayer2.Visibility = Visibility.Visible;

            }
        }

        private void btnTopMid_Click(object sender, RoutedEventArgs e)
        {
            
            if (a == true)
            {
                btnTopMid.IsEnabled = false;
                imgTopMid.Visibility = Visibility.Visible;
                AI();
                win();
                a = true;
            }
            else if (a == false)
            {
                btnTopMid.IsEnabled = false;
                imgTopMid2.Visibility = Visibility.Visible;
                AI();
                win();
                a = false;
            }
            else
            {

            }

            if (a == true)
            {
                lblPlayer.Visibility = Visibility.Visible;
                lblPlayer2.Visibility = Visibility.Hidden;
            }
            else if (a == false)
            {
                lblPlayer.Visibility = Visibility.Hidden;
                lblPlayer2.Visibility = Visibility.Visible;

            }
        }

        private void btnTopRight_Click(object sender, RoutedEventArgs e)
        {
            if (a == true)
            {
                btnTopRight.IsEnabled = false;
                imgTopRight.Visibility = Visibility.Visible;
                AI();
                win();
                a = true;
            }
            else if (a == false)
            {
                btnTopRight.IsEnabled = false;
                imgTopRight2.Visibility = Visibility.Visible;
                AI();
                win();
                a = false;
            }
            else
            {

            }

            if (a == true)
            {
                lblPlayer.Visibility = Visibility.Visible;
                lblPlayer2.Visibility = Visibility.Hidden;

            }
            else if (a == false)
            {
                lblPlayer.Visibility = Visibility.Hidden;
                lblPlayer2.Visibility = Visibility.Visible;

            }
        }

        private void btnRightMid_Click_1(object sender, RoutedEventArgs e)
        {
            
            if (a == true)
            {
                btnRightMid.IsEnabled = false;
                imgRightMid.Visibility = Visibility.Visible;
                AI();
                win();
                a = true;
            }
            else if (a == false)
            {
                btnRightMid.IsEnabled = false;
                imgRightMid2.Visibility = Visibility.Visible;
                AI();
                win();
                a = false;
            }
            else
            {

            }

            if (a == true)
            {
                lblPlayer.Visibility = Visibility.Visible;
                lblPlayer2.Visibility = Visibility.Hidden;

            }
            else if (a == false)
            {
                lblPlayer.Visibility = Visibility.Hidden;
                lblPlayer2.Visibility = Visibility.Visible;

            }
        }

        private void btnMidMid_Click(object sender, RoutedEventArgs e)
        {
            if (a == true)
            {
                btnMidMid.IsEnabled = false;
                imgMidMid.Visibility = Visibility.Visible;
                AI();
                win();
                a = true;
            }
            else if (a == false)
            {
                btnMidMid.IsEnabled = false;
                imgMidMid2.Visibility = Visibility.Visible;
                AI();
                win();
                a = false;
            }
            else
            {

            }

            if (a == true)
            {
                lblPlayer.Visibility = Visibility.Visible;
                lblPlayer2.Visibility = Visibility.Hidden;

            }
            else if (a == false)
            {
                lblPlayer.Visibility = Visibility.Hidden;
                lblPlayer2.Visibility = Visibility.Visible;

            }
        }

        private void btnBotRight_Click(object sender, RoutedEventArgs e)
        {
            if (a == true)
            {
                btnBotRight.IsEnabled = false;
                imgbotRight.Visibility = Visibility.Visible;
                AI();
                win();
                a = true;
            }
            else if (a == false)
            {
                btnBotRight.IsEnabled = false;
                imgbotRight2.Visibility = Visibility.Visible;
                AI();
                win();
                a = false;
            }
            else
            {

            }

            if (a == true)
            {
                lblPlayer.Visibility = Visibility.Visible;
                lblPlayer2.Visibility = Visibility.Hidden;

            }
            else if (a == false)
            {
                lblPlayer.Visibility = Visibility.Hidden;
                lblPlayer2.Visibility = Visibility.Visible;

            }
        }

        private void btnLeftMid_Click(object sender, RoutedEventArgs e)
        {
            if (a == true)
            {
                btnLeftMid.IsEnabled = false;
                imgLeftMid.Visibility = Visibility.Visible;
                AI();
                win();
                a = true;
            }
            else if (a == false)
            {
                btnLeftMid.IsEnabled = false;
                imgLeftMid2.Visibility = Visibility.Visible;
                AI();
                win();
                a = false;
            }
            else
            {

            }

            if (a == true)
            {
                lblPlayer.Visibility = Visibility.Visible;
                lblPlayer2.Visibility = Visibility.Hidden;

            }
            else if (a == false)
            {
                lblPlayer.Visibility = Visibility.Hidden;
                lblPlayer2.Visibility = Visibility.Visible;

            }

        }
        private void btnBotLeft_Click(object sender, RoutedEventArgs e)
        {
            if (a == true)
            {
                btnBotLeft.IsEnabled = false;
                imgBotLeft.Visibility = Visibility.Visible;
                AI();
                win();
                a = true;
            }
            else if (a == false)
            {
                btnBotLeft.IsEnabled = false;
                imgBotLeft2.Visibility = Visibility.Visible;
                AI();
                win();
                a = false;
            }
            else
            {

            }

            if (a == true)
            {
                lblPlayer.Visibility = Visibility.Visible;
                lblPlayer2.Visibility = Visibility.Hidden;
            }
            else if (a == false)
            {
                lblPlayer.Visibility = Visibility.Hidden;
                lblPlayer2.Visibility = Visibility.Visible;

            }

        }
        private void btnBotMid_Click(object sender, RoutedEventArgs e)
        {
            if (a == true)
            {
                btnBotMid.IsEnabled = false;
                imgBotMid.Visibility = Visibility.Visible;
                AI();
                win();
                a =true;
            }
            else if (a == false)
            {
                btnBotMid.IsEnabled = false;
                imgBotMid2.Visibility = Visibility.Visible;
                AI();
                win();
                a = false;
            }
            else
            {

            }

            if (a == true)
            {
                lblPlayer.Visibility = Visibility.Visible;
                lblPlayer2.Visibility = Visibility.Hidden;

            }
            else if (a == false)
            {
                lblPlayer.Visibility = Visibility.Hidden;
                lblPlayer2.Visibility = Visibility.Visible;

            }

        }

        private void win()
        {
            bool win = false;
           
            if (imgTopLeft.Visibility==Visibility.Visible && imgLeftMid.Visibility==Visibility.Visible && imgBotLeft.Visibility == Visibility.Visible)
            {
                lblWin.Visibility = Visibility.Visible;
                win = true;
            }
            else if (imgTopMid.Visibility==Visibility.Visible && imgMidMid.Visibility==Visibility.Visible && imgBotMid.Visibility==Visibility.Visible)
            {
                lblWin.Visibility = Visibility.Visible;
                win = true;
            }
            else if (imgTopRight.Visibility==Visibility.Visible && imgRightMid.Visibility==Visibility.Visible && imgbotRight.Visibility==Visibility.Visible)
            {
                lblWin.Visibility = Visibility.Visible;
                win = true;
            }
            else if (imgTopLeft.Visibility == Visibility.Visible && imgTopMid.Visibility == Visibility.Visible && imgTopRight.Visibility == Visibility.Visible)
            {
                lblWin.Visibility = Visibility.Visible;
                win = true;
            }
            else if (imgLeftMid.Visibility==Visibility.Visible && imgMidMid.Visibility==Visibility.Visible && imgRightMid.Visibility==Visibility.Visible)
            {
                lblWin.Visibility = Visibility.Visible;
                win = true;
            }
            else if (imgBotLeft.Visibility==Visibility.Visible && imgBotMid.Visibility==Visibility.Visible && imgbotRight.Visibility == Visibility.Visible)
            {
                lblWin.Visibility = Visibility.Visible;
                win = true;
            }
            else if (imgTopLeft.Visibility==Visibility.Visible && imgMidMid.Visibility==Visibility.Visible && imgbotRight.Visibility==Visibility.Visible)
            {
                lblWin.Visibility = Visibility.Visible;
                win = true;
            }
            else if (imgBotLeft.Visibility==Visibility.Visible && imgMidMid.Visibility==Visibility.Visible && imgTopRight.Visibility == Visibility.Visible)
            {
                lblWin.Visibility = Visibility.Visible;
                win = true;
            }

            else if (imgTopLeft2.Visibility == Visibility.Visible && imgLeftMid2.Visibility == Visibility.Visible && imgBotLeft2.Visibility == Visibility.Visible)
            {
                lblWin2.Visibility = Visibility.Visible;
                win = true;
            }
            else if (imgTopMid2.Visibility == Visibility.Visible && imgMidMid2.Visibility == Visibility.Visible && imgBotMid2.Visibility == Visibility.Visible)
            {
                lblWin2.Visibility = Visibility.Visible;
                win = true;
            }
            else if (imgTopRight2.Visibility == Visibility.Visible && imgRightMid2.Visibility == Visibility.Visible && imgbotRight2.Visibility == Visibility.Visible)
            {
                lblWin2.Visibility = Visibility.Visible;
                win = true;
            }
            else if (imgTopLeft2.Visibility == Visibility.Visible && imgTopMid2.Visibility == Visibility.Visible && imgTopRight2.Visibility == Visibility.Visible)
            {
                lblWin2.Visibility = Visibility.Visible;
                win = true;
            }
            else if (imgLeftMid2.Visibility == Visibility.Visible && imgMidMid2.Visibility == Visibility.Visible && imgRightMid2.Visibility == Visibility.Visible)
            {
                lblWin2.Visibility = Visibility.Visible;
                win = true;
            }
            else if (imgBotLeft2.Visibility == Visibility.Visible && imgBotMid2.Visibility == Visibility.Visible && imgbotRight2.Visibility == Visibility.Visible)
            {
                lblWin2.Visibility = Visibility.Visible;
                win = true;
            }
            else if (imgTopLeft2.Visibility == Visibility.Visible && imgMidMid2.Visibility == Visibility.Visible && imgbotRight2.Visibility == Visibility.Visible)
            {
                lblWin2.Visibility = Visibility.Visible;
                win = true;
            }
            else if (imgBotLeft2.Visibility == Visibility.Visible && imgMidMid2.Visibility == Visibility.Visible && imgTopRight2.Visibility == Visibility.Visible)
            {
                lblWin2.Visibility = Visibility.Visible;
                win = true;
            }
            else
            {
                return;
            }

            if (win==true)
            {
                btnTopLeft.IsEnabled = false;
                btnTopMid.IsEnabled = false;
                btnTopRight.IsEnabled = false;
                btnRightMid.IsEnabled = false;
                btnMidMid.IsEnabled = false;
                btnLeftMid.IsEnabled = false;
                btnBotLeft.IsEnabled = false;
                btnBotMid.IsEnabled = false;
                btnBotRight.IsEnabled = false;
            }

        }
        private void AI()

        {
            do
            {
                Random rnd = new Random();
                int randGetal = rnd.Next(1, 9);
                //int randGetal = 2;

                if (randGetal == 1 && btnTopLeft.IsEnabled == true)
                {
                    btnTopLeft.IsEnabled = false;

                    if (a == false)
                    {
                        imgTopLeft.Visibility = Visibility.Visible;
                    }
                    else if (a == true)
                    {
                        imgTopLeft2.Visibility = Visibility.Visible;
                    }

                    return;
                }
                else if (randGetal == 2 && btnTopMid.IsEnabled == true)
                {
                    btnTopMid.IsEnabled = false;

                    if (a == false)
                    {
                        imgTopMid.Visibility = Visibility.Visible;
                    }
                    else if (a == true)
                    {
                        imgTopMid2.Visibility = Visibility.Visible;
                    }

                    return;
                }
                else if (randGetal == 3 && btnTopRight.IsEnabled == true)
                {
                    btnTopRight.IsEnabled = false;

                    if (a == false)
                    {
                        imgTopRight.Visibility = Visibility.Visible;
                    }
                    else if (a == true)
                    {
                        imgTopRight2.Visibility = Visibility.Visible;
                    }

                    return;
                }
                else if (randGetal == 4 && btnLeftMid.IsEnabled == true)
                {
                    btnLeftMid.IsEnabled = false;

                    if (a == false)
                    {
                        imgLeftMid.Visibility = Visibility.Visible;
                    }
                    else if (a == true)
                    {
                        imgLeftMid2.Visibility = Visibility.Visible;
                    }

                    return;
                }
                else if (randGetal == 5 && btnMidMid.IsEnabled == true)
                {
                    btnMidMid.IsEnabled = false;

                    if (a == false)
                    {
                        imgMidMid.Visibility = Visibility.Visible;
                    }
                    else if (a == true)
                    {
                        imgMidMid2.Visibility = Visibility.Visible;
                    }

                    return;
                }
                else if (randGetal == 6 && btnRightMid.IsEnabled == true)
                {
                    btnRightMid.IsEnabled = false;

                    if (a == false)
                    {
                        imgRightMid.Visibility = Visibility.Visible;
                    }
                    else if (a == true)
                    {
                        imgRightMid2.Visibility = Visibility.Visible;
                    }

                    return;
                }
                else if (randGetal == 7 && btnBotLeft.IsEnabled == true)
                {
                    btnBotLeft.IsEnabled = false;

                    if (a == false)
                    {
                        imgBotLeft.Visibility = Visibility.Visible;
                    }
                    else if (a == true)
                    {
                        imgBotLeft2.Visibility = Visibility.Visible;
                    }

                    return;
                }
                else if (randGetal == 8 && btnBotMid.IsEnabled == true)
                {
                    btnBotMid.IsEnabled = false;

                    if (a == false)
                    {
                        imgBotMid.Visibility = Visibility.Visible;
                    }
                    else if (a == true)
                    {
                        imgBotMid2.Visibility = Visibility.Visible;
                    }

                    return;
                }
                else if (randGetal == 9 && btnBotRight.IsEnabled == true)
                {
                    btnBotRight.IsEnabled = false;

                    if (a == false)
                    {
                        imgbotRight.Visibility = Visibility.Visible;
                    }
                    else if (a == true)
                    {
                        imgbotRight2.Visibility = Visibility.Visible;
                    }

                    return;
                }
                else if (btnTopLeft.IsEnabled==false && btnTopMid.IsEnabled==false && btnTopRight.IsEnabled==false && btnRightMid.IsEnabled==false && btnMidMid.IsEnabled==false && btnLeftMid.IsEnabled==false && btnBotLeft.IsEnabled==false && btnBotMid.IsEnabled==false && btnBotRight.IsEnabled==false)
                {
                    return;
                }
                else
                {
                    
                }
            } while (true);
        }

        private void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
            Application.Current.Shutdown();
        }
    }
}
