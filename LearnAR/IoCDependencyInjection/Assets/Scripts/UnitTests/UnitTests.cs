using Zenject;
using NUnit.Framework;

[TestFixture]
public class UnitTests : ZenjectUnitTestFixture
{
    // Path of the SettingsInstaller, under Assets/Resources/SettingsInstaller.asset
    // because InstallFromResource already contains Assets/Resources, so remove it from the path
    // and remove file type .asset
    private string testSettingsPath = "SettingsInstaller";

    [SetUp]
    public void BindInterface()
    {
        // bind the installers that contain the classes/methods to test

        SettingsInstaller.InstallFromResource(testSettingsPath, Container);

        TestInstaller.Install(Container);
    }

    [Test]
    public void WillGreeterResolve()
    {
        IGreeter obj = Container.Resolve<IGreeter>();
        Assert.NotNull(obj);
    }

    [Test]
    public void IGreeterResolveAsGreetingObject()
    {
        IGreeter obj = Container.Resolve<IGreeter>() as Greeter;
        Assert.NotNull(obj);
    }

    /// <summary>
    /// Intentionally failed case example.
    /// </summary>
    [Test]
    public void IGreeterMessageAsHelloWelcome()
    {
        string msg = Container.Resolve<IGreeter>().Message;
        Assert.AreEqual(msg, "Hello Welcome!");
    }

    /// <summary>
    /// At end of unit test, the container unbinds all objects.
    /// </summary>
    [TearDown]
    public void TearDown()
    {
        Container.UnbindAll();
    }
}