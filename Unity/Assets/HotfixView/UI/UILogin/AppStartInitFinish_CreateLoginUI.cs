namespace ET
{
	public class AppStartInitFinish_CreateLoginUI: AEvent<EventType.AppStartInitFinish>
	{
		protected override async ETTask Run(EventType.AppStartInitFinish args)
		{
			FUIComponent fuiComponent = Game.Scene.GetComponent<FUIComponent>();

			FUI ui = await FUILoginFactory.Create(args.ZoneScene);
			Game.Scene.GetComponent<FUIComponent>().Add(ui);
		}
	}
}
