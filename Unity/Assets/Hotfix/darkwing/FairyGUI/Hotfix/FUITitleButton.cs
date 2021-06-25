/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace DCETHotfix
{
    public partial class FUITitleButton : GButton
    {
        public GImage bg;
        public const string URL = "ui://2w4fpdl4hbe5a";

        public static FUITitleButton CreateInstance()
        {
            return (FUITitleButton)UIPackage.CreateObject("Hotfix", "TitleButton");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            bg = (GImage)GetChild("bg");
        }
    }
}