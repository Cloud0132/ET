namespace ET
{
    public class FUIInitComponent: Entity
    {
        public async ETTask Init()
        {
            //TODO Login中依赖了5V5Map中的资源，所以要加载他，正确做法是将公用资源打入一个包
            // await ETModel.Game.Scene.GetComponent<FUIPackageComponent>().AddPackageAsync(FUIPackage.FUI5v5Map);
            await Game.Scene.GetComponent<FUIPackageComponent>().AddPackageAsync(FUIPackage.FUILogin);
            // await ETModel.Game.Scene.GetComponent<FUIPackageComponent>().AddPackageAsync(FUIPackage.FUIHeadBar);
            // await Game.Scene.GetComponent<FUIPackageComponent>().AddPackageAsync(FUIPackage.FUILobby);
            // await Game.Scene.GetComponent<FUIPackageComponent>().AddPackageAsync(FUIPackage.FUIDialog);
        }

        public override void Dispose()
        {
            if (IsDisposed)
            {
                return;
            }

            base.Dispose();

            Game.Scene.GetComponent<FUIPackageComponent>().RemovePackage(FUIPackage.FUILogin);
            // ETModel.Game.Scene.GetComponent<FUIPackageComponent>().RemovePackage(FUIPackage.FUIHeadBar);
            // ETModel.Game.Scene.GetComponent<FUIPackageComponent>().RemovePackage(FUIPackage.FUILobby);
            // ETModel.Game.Scene.GetComponent<FUIPackageComponent>().RemovePackage(FUIPackage.FUIDialog);
        }
    }
}