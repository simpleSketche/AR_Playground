using UnityEngine;
using Zenject;

public class GreeterInstaller : MonoInstaller<GreeterInstaller>
{
    public override void InstallBindings()
    {
        // binding a interface to a concrete class as singleton object
        // nonLazy method here is to tell the machine to create the instance at the beginnging of the game.
        // without the method, this instance is only created when it's needed.
        Container.Bind<IGreeter>().To<Greeter>().AsSingle().NonLazy();

        // binding a interface to a concrete class as regular object which would be created new everytime this is called.
        //Container.Bind<IGreeter>().To<Greeter>().AsTransient();
    }
}