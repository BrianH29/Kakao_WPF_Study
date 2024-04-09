using Jamesnet.Wpf.Controls;
using System.Windows;
using System.Windows.Controls;

namespace Kakao.Chat.UI.Views
{
    public class ChatContent : JamesContent
    {
        static ChatContent()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ChatContent), new FrameworkPropertyMetadata(typeof(ChatContent)));
        }

        public ChatContent()
        {

        }
    }
}
