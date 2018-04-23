Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
' ...

Namespace EUD_CustomProperty
	Friend Class DummyResFinder

	End Class

	<ToolboxItem(True)> _
	Public Class CustomControl
		Inherits XRControl

		Private customText_Renamed As String

		Public Sub New()
			customText_Renamed = String.Empty
		End Sub

		<Description("Gets or sets custom text."), DXDisplayName(GetType(DummyResFinder), "Resource1", "CustomControl.CustomText", "CustomText")> _
		Public Property CustomText() As String
			Get
				Return customText_Renamed
			End Get
			Set(ByVal value As String)
				customText_Renamed = value
			End Set
		End Property
	End Class

End Namespace
