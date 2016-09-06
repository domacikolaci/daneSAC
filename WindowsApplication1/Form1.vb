'Author: Adam Knezevic
'Project: Sac - Shop
'Date last modified:18/07/2016

Public Class frmMain
    'Declaring Array for storing ailse usage
    Dim arrAisle(2) As String
    'Declaring Array for maintaining next empty element
    Dim intIndex As Integer
    'Decminal maintains total cost of goods
    Dim decTotalCost As Decimal

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Adds the numbers to the combo box cboAisle
        cboAisle.Items.Add("1")
        cboAisle.Items.Add("2")
        cboAisle.Items.Add("3")
        cboAisle.Items.Add("4")
        cboAisle.Items.Add("5")
        cboAisle.Items.Add("6")
        cboAisle.Items.Add("7")
        cboAisle.Items.Add("8")
        cboAisle.Items.Add("9")
        cboAisle.Items.Add("10")

    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click

        'Collects the data entered into txtCost and puts it into the array
        arrAisle(intIndex) = cboAisle.SelectedItem
        decTotalCost = CDec(txtCost.Text)
        intIndex += 1
        'Clears txtCost
        txtCost.Clear()

    End Sub

    Private Sub btnFinalise_Click(sender As Object, e As EventArgs) Handles btnFinalise.Click
        'Decimil decAverageCost
        Dim decAverageCost As Integer
        'Declaring intergers for use in btnFinalise
        Dim intCurrentElement As Integer
        Dim intCurrentValue As Integer
        Dim intElementFreq As Integer
        Dim intMostPopularAisle As Integer
        Dim intLeastPopularAisle As Integer
        Dim intLargestFreq As Integer
        Dim intLeastFreq As Integer

        'Sorts the array arrAisle
        Array.Sort(arrAisle)

        'Procceses all the info in the array
        For i = 0 To intIndex - 1
            intCurrentElement = arrAisle(i)
            If intCurrentElement = intCurrentValue Then
                intElementFreq += 1
            ElseIf i > 0 Then
                If intElementFreq > intLargestFreq Then
                    intMostPopularAisle = arrAisle(i - 1)
                    intLargestFreq = intElementFreq
                ElseIf intElementFreq <= intLeastFreq Then
                    intLeastPopularAisle = arrAisle(i - 1)
                    intLeastFreq = intElementFreq
                End If
                intCurrentValue = intCurrentElement
                intElementFreq = 1
            End If
            Debug.WriteLine("Most frequent " & intMostPopularAisle)
            Debug.WriteLine("Least populer " & intLeastPopularAisle)
        Next
    End Sub
End Class
