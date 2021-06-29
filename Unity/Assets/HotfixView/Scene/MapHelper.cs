using System;


namespace ET
{
    public static class MapHelper
    {
        public static async ETVoid EnterMapAsync(Scene zoneScene, string sceneName)
        {
            try
            {
                // 加载Unit资源
                ResourcesComponent resourcesComponent = zoneScene.GetComponent<ResourcesComponent>();
                await resourcesComponent.LoadBundleAsync($"unit.unity3d");

                //加载资源
                await resourcesComponent.LoadBundleAsync("map.unity3d");

                // 切换到map场景
			    using (SceneChangeComponent sceneChangeComponent = zoneScene.AddComponent<SceneChangeComponent>())
			    {
				    await sceneChangeComponent.ChangeSceneAsync("Map");
			    }
                zoneScene.AddComponent<OperaComponent>();


                G2C_EnterMap g2CEnterMap = await zoneScene.GetComponent<SessionComponent>().Session.Call(new C2G_EnterMap()) as G2C_EnterMap;

                UnitComponent unitComponent = zoneScene.GetComponent<UnitComponent>();
                unitComponent.MyUnit = unitComponent.Get(g2CEnterMap.UnitId);
                
                Game.EventSystem.Publish(new EventType.EnterMapFinish() {ZoneScene = zoneScene}).Coroutine();
            }
            catch (Exception e)
            {
                Log.Error(e);
            }	
        }
    }
}