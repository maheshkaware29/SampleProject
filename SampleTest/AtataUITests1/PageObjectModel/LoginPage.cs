using Atata;
using _ = SampleProject.PageObjectModel.LoginPage;

namespace SampleProject.PageObjectModel
{
    [Url("signin")]
    public class LoginPage : Page<_>
    {
        public TextInput<_> Email { get; set; }
        public PasswordInput<_> Password { get; set; }
        public Button<_> SignIn { get; set; }
    }
}
