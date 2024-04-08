using Kakao.Settings;

namespace Kakao
{
    internal class Starter
    {
        //App.xaml, MainWindow 내부적으로 돌고 있는 형식을 수동으로 변경
        [STAThread]
        private static void Main(string[] args) 
        {
            //Run은 void 타입이 아니기 때문에 return 값이 있다. 그래서 가독성을 위해 앞에 _ =  해줌
            _ = new App()
                .AddInversionModule<ViewModules>()
                .AddInversionModule<DirectModule>()
                .AddWireDataContext<WireDataContext>()
                .Run();
        }
    }
}
