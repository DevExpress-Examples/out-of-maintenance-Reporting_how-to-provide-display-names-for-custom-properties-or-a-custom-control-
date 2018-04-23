Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing.Design
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
' ...

Namespace EUD_CustomProperty
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As New XtraReport()

			report.Bands.Add(New DetailBand())

			AddHandler report.DesignerLoaded, AddressOf report_DesignerLoaded

			report.ShowDesignerDialog()
		End Sub

		Private Sub report_DesignerLoaded(ByVal sender As Object, ByVal e As DesignerLoadedEventArgs)
			Dim item As New ToolboxItem(GetType(CustomControl))
			Dim ts As IToolboxService = TryCast(e.DesignerHost.GetService(GetType(IToolboxService)), IToolboxService)

			ts.AddToolboxItem(item)
		End Sub
	End Class
End Namespace