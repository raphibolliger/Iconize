using Android.Content;
using Android.Views;
using Plugin.Iconize;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(IconNavigationPage), typeof(IconNavigationRenderer))]

namespace Plugin.Iconize
{
    /// <summary>
    /// Defines the <see cref="IconNavigationPage" /> renderer.
    /// </summary>
    /// <seealso cref="Xamarin.Forms.Platform.Android.AppCompat.NavigationPageRenderer" />
    public class IconNavigationRenderer : NavigationPageRenderer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IconNavigationRenderer"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public IconNavigationRenderer(Context context)
            : base(context)
        {
            // Intentionally left blank
        }

        protected override void UpdateMenuItemIcon(Context context, IMenuItem menuItem, ToolbarItem toolBarItem)
        {
            if (toolBarItem is IconToolbarItem iconToolbarItem)
            {
                var icon = iconToolbarItem.GetToolbarItemDrawable(context);
                if (icon != null)
                {
                    menuItem.SetIcon(icon);
                    return;
                }
            }

            base.UpdateMenuItemIcon(context, menuItem, toolBarItem);
        }
    }
}