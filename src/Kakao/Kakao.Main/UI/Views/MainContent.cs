using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace Kakao.Main.UI.Views
{
    public class MainContent : JamesContent
    {
        static MainContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(MainContent), new FrameworkPropertyMetadata(typeof(MainContent)));
        }

        public MainContent()
        {

        }
    }
}
