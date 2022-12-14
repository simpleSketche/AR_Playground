using UnityEngine;
using Zenject;

public class GreeterInstaller : MonoInstaller<GreeterInstaller>
{
    // reference the game prefab directly here
    // since the script is in monobehaviours, so we can reference directly
    public GreetingConsumer greetingConsumerPrefab;

    public override void InstallBindings()
    {
        // binding a interface to a concrete class as singleton object
        // nonLazy method here is to tell the machine to create the instance at the beginnging of the game.
        // without the method, this instance is only created when it's needed.
        Container.Bind<IGreeter>().To<Greeter>().AsSingle();

        // binding a interface to a concrete class as regular object which would be created new everytime this is called.
        //Container.Bind<IGreeter>().To<Greeter>().AsTransient();

        // binding the factory to the container, specifying the output object type and the factory to produce the object
        Container.BindFactory<GreetingConsumer, Factory>().FromComponentInNewPrefab(greetingConsumerPrefab);
    }
}