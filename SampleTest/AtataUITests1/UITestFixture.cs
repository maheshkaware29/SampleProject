using SampleProject.PageObjectModel;

namespace SampleProject
{
    [Parallelizable(ParallelScope.Self)]
    public class UITestFixture
    {
        [SetUp]
        public void SetUp() =>
            AtataContext.Configure().Build();

        [TearDown]
        public void TearDown() =>
            AtataContext.Current?.Dispose();
        public void Login()
        {
            Go.To<LoginPage>()
                .Email.Set("admin@mail.com")
                .Password.Set("abc123")
                .SignIn.Click();
        }
    }
}
