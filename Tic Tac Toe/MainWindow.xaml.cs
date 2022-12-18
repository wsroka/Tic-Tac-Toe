using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool isPlayer1Turn { get; set; }
        public int counter { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }
        public void NewGame()
        {
            isPlayer1Turn = false;
            counter = 0;
            Button_0_0.Content = null;
            Button_1_0.Content = null;
            Button_2_0.Content = null;
            Button_0_1.Content = null;
            Button_1_1.Content = null;
            Button_2_1.Content = null;
            Button_0_2.Content = null;
            Button_1_2.Content = null;
            Button_2_2.Content = null;

            Button_0_0.Background = Brushes.White;
            Button_1_0.Background = Brushes.White;
            Button_2_0.Background = Brushes.White;
            Button_0_1.Background = Brushes.White;
            Button_1_1.Background = Brushes.White;
            Button_2_1.Background = Brushes.White;
            Button_0_2.Background = Brushes.White;
            Button_1_2.Background = Brushes.White;
            Button_2_2.Background = Brushes.White;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button.Content == null)
            {
                counter++;
                if (counter > 9)
                {
                    NewGame();
                    return;
                }
                isPlayer1Turn ^= true;
                button.Content = isPlayer1Turn ? "O" : "X";
            }
            else if (button.Content != null && counter == 9)
            {
                NewGame();
                return;
            }
            if (CheckIfPlayerWon())
            {
                counter = 9;
            }
        }
        private bool CheckIfPlayerWon()
        {
            if (Button_0_0.Content != null && Button_0_0.Content == Button_1_0.Content && Button_0_0.Content == Button_2_0.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_0.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                return true;
            }
            if (Button_0_1.Content != null && Button_0_1.Content == Button_1_1.Content && Button_0_1.Content == Button_2_1.Content)
            {
                Button_0_1.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                return true;
            }
            if (Button_0_2.Content != null && Button_0_2.Content == Button_1_2.Content && Button_0_2.Content == Button_2_2.Content)
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }
            if (Button_0_0.Content != null && Button_0_0.Content == Button_0_1.Content && Button_0_0.Content == Button_0_2.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_0_1.Background = Brushes.Green;
                Button_0_2.Background = Brushes.Green;
                return true;
            }
            if (Button_1_0.Content != null && Button_1_0.Content == Button_1_1.Content && Button_1_0.Content == Button_1_2.Content)
            {
                Button_1_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_1_2.Background = Brushes.Green;
                return true;
            }
            if (Button_2_0.Content != null && Button_2_0.Content == Button_2_1.Content && Button_2_0.Content == Button_2_2.Content)
            {
                Button_2_0.Background = Brushes.Green;
                Button_2_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }
            if (Button_0_0.Content != null && Button_0_0.Content == Button_1_1.Content && Button_0_0.Content == Button_2_2.Content)
            {
                Button_0_0.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_2.Background = Brushes.Green;
                return true;
            }
            if (Button_0_2.Content != null && Button_0_2.Content == Button_1_1.Content && Button_0_2.Content == Button_2_0.Content)
            {
                Button_0_2.Background = Brushes.Green;
                Button_1_1.Background = Brushes.Green;
                Button_2_0.Background = Brushes.Green;
                return true;
            }
            return false;
        }
    }
}
