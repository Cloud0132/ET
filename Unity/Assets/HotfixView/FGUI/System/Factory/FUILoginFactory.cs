using FairyGUI;

namespace ET
{
    public static class FUILoginFactory
    {
        public static async ETTask<FUI> Create(Scene zoneScene)
        {
            await ETTask.CompletedTask;

            // Game.Scene.GetComponent<FUIPackageComponent>().AddPackage(FUIType.UILogin);

            FUI fui = EntityFactory.CreateWithParent<FUI, GObject>(zoneScene, UIPackage.CreateObject(FUIPackage.FUILogin, FUIType.UILogin));
            fui.Name = FUIType.UILogin;

            fui.AddComponent<FUILoginComponent>();

            return fui;
        }
    }
}