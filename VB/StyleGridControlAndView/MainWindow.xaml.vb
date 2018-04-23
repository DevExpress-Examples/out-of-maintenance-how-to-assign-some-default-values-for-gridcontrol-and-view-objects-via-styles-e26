Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Themes

Namespace StyleGridControlAndView
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			grid.DataSource = Me.Resources("items")
			grid1.DataSource = Me.Resources("items")
			grid2.DataSource = Me.Resources("items")
			grid3.DataSource = Me.Resources("items")
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			ThemeManager.SetThemeName(Me, "Office2007Black")
		End Sub
	End Class
End Namespace
