using UnityEngine;
using Zenject;

[CreateAssetMenu(fileName = "SettingsInstaller", menuName = "Installers/SettingsInstaller")]
public class SettingsInstaller : ScriptableObjectInstaller<SettingsInstaller>
{
    public GameSettings gameSettings;

    public override void InstallBindings()
    {
        // bind to the class type and bind the actual instance as well
        Container.BindInterfacesAndSelfTo<GameSettings>().FromInstance(gameSettings).AsSingle();
    }
}