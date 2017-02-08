using System.Threading.Tasks;
using Xamarin.Forms;

namespace Popup
{
    public static class NavigationExtension
    {
        public static Task PushPopupAsync(this INavigation sender, PopupPage page, bool animate = true)
        {
            return PopupNavigation.PushAsync(page, animate);
        }

        public static Task PopPopupAsync(this INavigation sender, bool animate = true)
        {
            return PopupNavigation.PopAsync(animate);
        }

        public static Task PopAllPopupAsync(this INavigation sender, bool animate = true)
        {
            return PopupNavigation.PopAllAsync(animate);
        }

        public static Task RemovePopupPageAsync(this INavigation sender, PopupPage page, bool animate = true)
        {
            return PopupNavigation.RemovePageAsync(page, animate);
        }
    }
}
