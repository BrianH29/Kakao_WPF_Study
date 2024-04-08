using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace Kakao.Login.UI.Views
{
    public class LoginContent : JamesContent
    {
        static LoginContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(LoginContent), new FrameworkPropertyMetadata(typeof(LoginContent)));
        }

        public LoginContent()
        {
           
        }
    }
}
