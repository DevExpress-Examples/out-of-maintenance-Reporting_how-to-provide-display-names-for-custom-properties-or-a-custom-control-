using System;
using System.Drawing.Design;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
// ...

namespace EUD_CustomProperty {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XtraReport report = new XtraReport();

            report.Bands.Add(new DetailBand());

            report.DesignerLoaded += new DesignerLoadedEventHandler(report_DesignerLoaded);

            report.ShowDesignerDialog();
        }

        void report_DesignerLoaded(object sender, DesignerLoadedEventArgs e) {
            ToolboxItem item = new ToolboxItem(typeof(CustomControl));
            IToolboxService ts = e.DesignerHost.GetService(typeof(IToolboxService)) as IToolboxService;

            ts.AddToolboxItem(item);
        }
    }
}