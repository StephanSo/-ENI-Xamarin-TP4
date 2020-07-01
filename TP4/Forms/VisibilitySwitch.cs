
using Xamarin.Forms;

namespace TP4.Forms
{
    public class VisibilitySwitch
    {
        public View InitialVisible { get; }
        public View NextVisible { get; }

        public VisibilitySwitch(View initialVisible, View nextVisible)
        {
            this.InitialVisible = initialVisible;
            this.NextVisible = nextVisible;
        }

        public void Switch()
        {
            if (this.InitialVisible.IsVisible)
            {
                this.InitialVisible.IsVisible = false;
                this.NextVisible.IsVisible = true;
            }
            else
            {
                this.InitialVisible.IsVisible = true;
                this.NextVisible.IsVisible = false;
            }
        }
    }
}
