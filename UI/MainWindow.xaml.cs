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
using Engine.ViewModels;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession _gameSession;

        public MainWindow()
        {
            InitializeComponent();

            _gameSession = new GameSession();

            // This is what the XAML file uses for its values. the DataContext is a builtin property for XAML files.
            DataContext = _gameSession;
        }

        //TODO: Make this button work; currently throws NullReferenceException for the array being empty
        private void ButtonCreatePlayer_OnClick(Object sender, RoutedEventArgs e)
        {
            _gameSession.previousPlayers.SetValue(_gameSession.CurrentPlayer,0);
            _gameSession.CurrentPlayer = new Engine.Models.Player();
            
        }

        private void OnClick_MoveNorth(Object sender, RoutedEventArgs e)
        {
            _gameSession.MoveNorth();
            
        }
        private void OnClick_MoveWest(Object sender, RoutedEventArgs e)
        {
            _gameSession.MoveWest();
        }
        private void OnClick_MoveEast(Object sender, RoutedEventArgs e)
        {
            _gameSession.MoveEast();
        }
        private void OnClick_MoveSouth(Object sender, RoutedEventArgs e)
        {
            _gameSession.MoveSouth();
        }
    }
}
