namespace ET
{
	public class LoginFinish_RemoveLoginUI: AEvent<EventType.LoginFinish>
	{
		protected override async ETTask Run(EventType.LoginFinish args)
		{
			Game.Scene.GetComponent<FUIComponent>().Remove(FUIType.UILogin);
			Game.Scene.GetComponent<FUIPackageComponent>().RemovePackage(FUIPackage.FUILogin);
			await ETTask.CompletedTask;
		}
	}
}
