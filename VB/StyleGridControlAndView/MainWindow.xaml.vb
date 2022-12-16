Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Core

Namespace StyleGridControlAndView

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = Resources("items")
            Me.grid1.ItemsSource = Resources("items")
            Me.grid2.ItemsSource = Resources("items")
            Me.grid3.ItemsSource = Resources("items")
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ThemeManager.SetThemeName(Me, "Office2007Black")
        End Sub
    End Class
End Namespace
