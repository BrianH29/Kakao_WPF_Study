
namespace Kakao.Core.Models
{
    public class MenuModel
    {
        public string Id {  get; set; }

        public MenuModel DataGet(string id)
        {
            Id = id;
            return this;
        }
    }
}
