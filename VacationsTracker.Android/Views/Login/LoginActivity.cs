using Android.App;
using Android.OS;
using FlexiMvvm.Bindings;
using FlexiMvvm.Views;
using VacationsTracker.Core.Presentation.ViewModels.Login;

namespace VacationsTracker.Droid.Views.Login
{
    [Activity(Label = "LoginActivity")]
    internal class LoginActivity : BindableAppCompatActivity<LoginViewModel>
    {
        private LoginActivityViewHolder ViewHolder { get; set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.activity_login);

            ViewHolder = new LoginActivityViewHolder(this);
        }

        public override void Bind(BindingSet<LoginViewModel> bindingSet)
        {
            base.Bind(bindingSet);

            //TODO here we define binding map
            /*
            bindingSet.Bind(ViewHolder.LoginButton)
                .For(v => v.ClickBinding())
                .To(vm => vm.)
                */
        }
    }
}