using FlexiMvvm;
using FlexiMvvm.Views;
using VacationsTracker.Core.Presentation.ViewModels.Login;

namespace VacationsTracker.iOS.Views.Login
{
    internal class LoginViewController : ViewController<LoginViewModel>
    {
        public new LoginView View
        {
            get => (LoginView)base.View.NotNull();
            set => base.View = value;
        }

        public override void LoadView()
        {
            View = new LoginView();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            NavigationController.NavigationBarHidden = true;
        }
    }
}