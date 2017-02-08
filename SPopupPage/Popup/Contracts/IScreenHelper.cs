using Xamarin.Forms;

namespace Popup
{
    public interface IScreenHelper
    {
        Rectangle ScreenSize { get; }
        Thickness ScreenOffsets { get; }
    }
}
