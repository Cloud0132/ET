namespace ET
{
	public class EnterMapFinish_RemoveLobbyUI: AEvent<EventType.EnterMapFinish>
	{
		protected override async ETTask Run(EventType.EnterMapFinish args)
		{
            await UIHelper.Remove(args.ZoneScene, UIType.UILobby);
		}
	}
}
