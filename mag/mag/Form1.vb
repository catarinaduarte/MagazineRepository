Public Class Form1
    Private Sub ListaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ListaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ListaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DBFinalDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DBFinalDataSet.Lista' table. You can move, or remove it, as needed.
        Me.ListaTableAdapter.Fill(Me.DBFinalDataSet.Lista)

    End Sub

    Private Sub Nome_AutorLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Nome_AutorTextBox_TextChanged(sender As Object, e As EventArgs) Handles Nome_AutorTextBox.TextChanged

    End Sub

    Private Sub TituloArtTextBox_TextChanged(sender As Object, e As EventArgs) Handles TituloArtTextBox.TextChanged

    End Sub

    Private Sub NomeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MesAnoRevLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TipoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CodArtLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TituloArtLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CodArtTextBox_TextChanged(sender As Object, e As EventArgs) Handles CodArtTextBox.TextChanged

    End Sub

    Private Sub TipoTextBox_TextChanged(sender As Object, e As EventArgs) Handles TipoTextBox.TextChanged

    End Sub

    Private Sub MesAnoRevTextBox_TextChanged(sender As Object, e As EventArgs) Handles MesAnoRevTextBox.TextChanged

    End Sub

    Private Sub NomeTextBox_TextChanged(sender As Object, e As EventArgs) Handles NomeTextBox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class
