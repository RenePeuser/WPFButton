Public Class WPFButtonTemplate

    Public Property Caption() As String
        Get
            Return Me._button1.Content.ToString
        End Get
        Set(value As String)
            Me._button1.Content = value
        End Set
    End Property

    Public Event tEST()

    Private Sub _button1_Click(sender As System.Object, e As System.Windows.RoutedEventArgs) Handles _button1.Click
        MessageBox.Show("_button1_Click")    
    End Sub



End Class
