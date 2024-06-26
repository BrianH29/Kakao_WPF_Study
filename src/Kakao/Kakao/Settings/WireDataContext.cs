﻿using Jamesnet.Wpf.Global.Location;
using Kakao.Chat.Local.ViewModels;
using Kakao.Chat.UI.Views;
using Kakao.Forms.Local.ViewModel;
using Kakao.Forms.UI.Views;
using Kakao.Friends.Local.ViewModels;
using Kakao.Friends.UI.Views;
using Kakao.Login.Local.ViewModels;
using Kakao.Login.UI.Views;
using Kakao.Main.Local.ViewModels;
using Kakao.Main.UI.Views;
using Kakao.More.Local.ViewModels;
using Kakao.More.UI.Views;

namespace Kakao.Settings
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<KakaoWindow, KakaoViewModel>();
            items.Register<LoginContent, LoginContentViewModel>();
            items.Register<MainContent, MainContentViewModel>();
            items.Register<FriendsContent, FriendsContentViewModel>();
            items.Register<ChatContent, ChatContentViewModel>();
            items.Register<MoreContent, MoreContentViewModel>();
        }
    }
}
