using System;
using VacationsTracker.iOS.Theme.Light;

namespace VacationsTracker.iOS.Theme
{
    internal abstract class AppTheme
    {
        public static AppTheme Current { get; private set; } = new LightAppTheme();

        public abstract AppThemeColors Colors { get; }

        public virtual AppThemeDimens Dimens { get; } = new AppThemeDimens();

        public virtual AppThemeFonts Fonts { get; } = new AppThemeFonts();

        public static void Set(AppTheme theme)
        {
            Current = theme ?? throw new ArgumentNullException(nameof(theme));
        }
    }
}