namespace ET
{
    [ObjectSystem]
    public class FUILoginComponentSystem : AwakeSystem<FUILoginComponent>
    {
        public override void Awake(FUILoginComponent self)
        {
            FUI login = self.GetParent<FUI>();

            self.AccountInput = login.Get("accountInput");
            Log.Debug("**************AccountInput + " + (self.AccountInput.GObject == null));
            
            login.Get("loginButton").GObject.asButton.onClick.Add(() => LoginBtnOnClick(self));
        }

        public static void LoginBtnOnClick(FUILoginComponent self)
        {
             Log.Debug("**************AccountInput + " + (self.AccountInput.GObject == null) + "**********" + self.AccountInput.GObject.asTextInput.text);
            LoginHelper.Login(self.DomainScene(), "127.0.0.1:10002", self.AccountInput.GObject.asTextInput.text).Coroutine();
        }
    }
}