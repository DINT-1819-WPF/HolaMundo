Class MainWindow
    Private Sub AceptarButton_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show(If(HolaRadioButton.IsChecked, "Hola ", "Adiós ") & NombreTextBox.Text, "Hola Mundo", MessageBoxButton.OK, MessageBoxImage.Information)
    End Sub
End Class
