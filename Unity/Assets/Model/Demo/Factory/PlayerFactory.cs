namespace ET
{
    public static class PlayerFactory
    {
        public static Player Create(Scene zoneScene,long id)
        {
            Player player = EntityFactory.CreateWithId<Player>(zoneScene, id);
            PlayerComponent playerComponent = zoneScene.GetComponent<PlayerComponent>();
            playerComponent.Add(player);
            return player;
        }
    }
}