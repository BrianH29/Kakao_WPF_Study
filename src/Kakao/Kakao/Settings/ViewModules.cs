using Jamesnet.Wpf.Controls;
using Kakao.Core.Names;
using Kakao.Friends.UI.Views;
using Kakao.Login.UI.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace Kakao.Settings
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //프리즘을 통해서 UI 객체들을 등록시켜 놓고 이제 폼쓰든 로그인이든 독립적으로, 참조를 걸지 않고도 다른 뷰를 가져와서 쓸 수 있게 해준다.
            containerRegistry.RegisterSingleton<IViewable, LoginContent>(ContentNameManager.Login);
            containerRegistry.RegisterSingleton<IViewable, FriendsContent>(ContentNameManager.Friends);
        }
    }
}
