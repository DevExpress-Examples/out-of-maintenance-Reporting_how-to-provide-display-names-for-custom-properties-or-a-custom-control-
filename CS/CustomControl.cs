using System.ComponentModel;
using DevExpress.XtraReports.UI;
// ...

namespace EUD_CustomProperty {
    class DummyResFinder {

    }

    [ToolboxItem(true)]
    public class CustomControl : XRControl {

        private string customText;

        public CustomControl() {
            customText = string.Empty;
        }

        [
        Description("Gets or sets custom text."),
        DXDisplayName(typeof(DummyResFinder), "Resource1", "CustomControl.CustomText", "CustomText")
        ]
        public string CustomText {
            get { return customText; }
            set { customText = value; }
        }
    }

}
