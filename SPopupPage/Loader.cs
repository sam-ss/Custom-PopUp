using Xamarin.Forms;

namespace Popup
{
    public static class Loader
    {
        public static void Load()
        {
#if __IOS__
            new PopupPageRenderer();
#endif
        }
    }

#if !__PLATFORM_PCL__
    [RenderWith(typeof(_PopupPageRenderer))]
#endif
    public class _PopupPageRenderer { }
}
