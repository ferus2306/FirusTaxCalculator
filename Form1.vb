Imports System.IO

Public Class Form1
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        employeeListBox.Items.Add(employeeNameTextBox.Text)
        hourlyPayListBox.Items.Add(hourlyPayTextBox.Text)
        socialSecurityListBox.Items.Add(socialSecurityTextBox.Text)
        ficaListBox.Items.Add(ficaTextBox.Text)
        stateListBox.Items.Add(stateTextBox.Text)

        employeeNameTextBox.Text = ""
        hourlyPayTextBox.Text = ""
        socialSecurityTextBox.Text = ""
        ficaTextBox.Text = ""
        stateTextBox.Text = ""
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim fStreamWriter As StreamWriter
        fStreamWriter = My.Computer.FileSystem.OpenTextFileWriter("employees.txt", False)
        Dim count As Integer = employeeListBox.Items.Count
        fStreamWriter.WriteLine(count)
        For i = 0 To count - 1
            fStreamWriter.WriteLine(employeeListBox.Items(i))
            fStreamWriter.WriteLine(hourlyPayListBox.Items(i))
            fStreamWriter.WriteLine(socialSecurityListBox.Items(i))
            fStreamWriter.WriteLine(ficaListBox.Items(i))
            fStreamWriter.WriteLine(stateListBox.Items(i))
        Next
        fStreamWriter.Close()
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click
        employeeListBox.Items.Clear()
        hourlyPayListBox.Items.Clear()
        socialSecurityListBox.Items.Clear()
        ficaListBox.Items.Clear()
        stateListBox.Items.Clear()
        Dim fStreamReader As StreamReader
        fStreamReader = File.OpenText("employees.txt")
        Dim count As Integer
        count = fStreamReader.ReadLine
        For i = 1 To count

            Dim name, hourlyPay, fica, state, socialSecurity As String
            name = fStreamReader.ReadLine
            hourlyPay = fStreamReader.ReadLine
            socialSecurity = fStreamReader.ReadLine
            fica = fStreamReader.ReadLine
            state = fStreamReader.ReadLine

            employeeListBox.Items.Add(name)
            hourlyPayListBox.Items.Add(hourlyPay)
            socialSecurityListBox.Items.Add(socialSecurity)
            ficaListBox.Items.Add(fica)
            stateListBox.Items.Add(state)

        Next
        fStreamReader.Close()
    End Sub

    Private Sub EmployeeTextBox_TextChanged(sender As Object, e As EventArgs) Handles employeeNameTextBox.TextChanged
        If employeeNameTextBox.Text = "" Then
            addButton.Enabled = False
        Else
            addButton.Enabled = True
        End If


        If employeeListBox.SelectedIndex > -1 Then
            deleteButton.Enabled = True
        Else
            deleteButton.Enabled = False
        End If


        If employeeListBox.Items.Count >= 1 Then
            loadButton.Enabled = False
        Else
            loadButton.Enabled = True
        End If

    End Sub

    Private Sub EmployeeListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles employeeListBox.SelectedIndexChanged
        hourlyPayListBox.SelectedIndex = employeeListBox.SelectedIndex
        ficaListBox.SelectedIndex = employeeListBox.SelectedIndex
        stateListBox.SelectedIndex = employeeListBox.SelectedIndex
        socialSecurityListBox.SelectedIndex = employeeListBox.SelectedIndex

        employeeNameTextBox.Text = employeeListBox.SelectedItem
        hourlyPayTextBox.Text = hourlyPayListBox.SelectedItem
        socialSecurityTextBox.Text = socialSecurityListBox.SelectedItem
        ficaTextBox.Text = ficaListBox.SelectedItem
        stateTextBox.Text = stateListBox.SelectedItem


    End Sub


    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click

        Dim index As Integer = employeeListBox.SelectedIndex

        employeeListBox.Items.RemoveAt(index)
        hourlyPayListBox.Items.RemoveAt(index)
        socialSecurityListBox.Items.RemoveAt(index)
        ficaListBox.Items.RemoveAt(index)
        stateListBox.Items.RemoveAt(index)
    End Sub

    Private Sub TotalHoursTextBox_TextChanged(sender As Object, e As EventArgs) Handles totalHoursTextBox.TextChanged
        Dim checkBeforeTax, state, fica, socialSecurity, totalPayAfterTax As Integer

        If totalHoursTextBox.Text IsNot "" Then
            Dim fStreamReader As StreamReader
            fStreamReader = File.OpenText("employees.txt")
            Dim count As Integer
            count = fStreamReader.ReadLine

            checkBeforeTax = Int(totalHoursTextBox.Text) * Int(hourlyPayListBox2.SelectedItem)

            fica = checkBeforeTax * ficaListBox2.SelectedItem
            socialSecurity = checkBeforeTax * socialSecurityListBox2.SelectedItem
            state = checkBeforeTax * stateListBox2.SelectedItem
            totalPayAfterTax = checkBeforeTax - fica - state - socialSecurity

            checkBeforeTaxLabel.Text = checkBeforeTax
            stateLabel.Text = stateListBox2.SelectedItem
            ficaLabel.Text = ficaListBox2.SelectedItem
            nameLabel.Text = employeeListBox2.SelectedItem
            hourlyPaylLabel.Text = hourlyPayListBox2.SelectedItem


            socialSecurityLabel.Text = socialSecurityListBox2.SelectedItem
            totalPayAfterTaxLabel.Text = totalPayAfterTax


            fStreamReader.Close()
        End If
    End Sub

    Private Sub LoadButton2_Click(sender As Object, e As EventArgs) Handles loadButton2.Click
        Dim fStreamReader As StreamReader
        fStreamReader = File.OpenText("employees.txt")
        Dim count As Integer
        count = fStreamReader.ReadLine
        For i = 1 To count
            Dim name, hourlyPay, fica, state, socialSecurity As String
            name = fStreamReader.ReadLine
            hourlyPay = fStreamReader.ReadLine
            socialSecurity = fStreamReader.ReadLine
            fica = fStreamReader.ReadLine
            state = fStreamReader.ReadLine

            employeeListBox2.Items.Add(name)
            hourlyPayListBox2.Items.Add(hourlyPay)
            socialSecurityListBox2.Items.Add(socialSecurity)
            ficaListBox2.Items.Add(fica)
            stateListBox2.Items.Add(state)
        Next

    End Sub

    Private Sub EmployeeListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles employeeListBox2.SelectedIndexChanged
        hourlyPayListBox2.SelectedIndex = employeeListBox2.SelectedIndex
        ficaListBox2.SelectedIndex = employeeListBox2.SelectedIndex
        stateListBox2.SelectedIndex = employeeListBox2.SelectedIndex
        socialSecurityListBox2.SelectedIndex = employeeListBox2.SelectedIndex


    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        employeeNameTextBox.Text = ""
        hourlyPayTextBox.Text = ""
        socialSecurityTextBox.Text = ""
        ficaTextBox.Text = ""
        stateTextBox.Text = ""
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs) Handles modifyButton.Click

        Dim index As Integer = employeeListBox.SelectedIndex
        hourlyPayListBox.Items(index) = hourlyPayTextBox.Text
        socialSecurityListBox.Items(index) = socialSecurityTextBox.Text
        ficaListBox.Items(index) = ficaTextBox.Text
        stateListBox.Items(index) = stateTextBox.Text
        employeeListBox.Items(index) = employeeNameTextBox.Text


        employeeNameTextBox.Text = ""
        hourlyPayTextBox.Text = ""
        socialSecurityTextBox.Text = ""
        ficaTextBox.Text = ""
        stateTextBox.Text = ""

    End Sub

    Private Sub HourlyPayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles hourlyPayListBox.SelectedIndexChanged
        employeeListBox.SelectedIndex = hourlyPayListBox.SelectedIndex
        ficaListBox.SelectedIndex = hourlyPayListBox.SelectedIndex
        stateListBox.SelectedIndex = hourlyPayListBox.SelectedIndex
        socialSecurityListBox.SelectedIndex = hourlyPayListBox.SelectedIndex
    End Sub

    Private Sub SocialSecurityListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles socialSecurityListBox.SelectedIndexChanged
        employeeListBox.SelectedIndex = socialSecurityListBox.SelectedIndex
        ficaListBox.SelectedIndex = socialSecurityListBox.SelectedIndex
        stateListBox.SelectedIndex = socialSecurityListBox.SelectedIndex
        hourlyPayListBox.SelectedIndex = socialSecurityListBox.SelectedIndex
    End Sub

    Private Sub FicaListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ficaListBox.SelectedIndexChanged
        employeeListBox.SelectedIndex = ficaListBox.SelectedIndex
        socialSecurityListBox.SelectedIndex = ficaListBox.SelectedIndex
        stateListBox.SelectedIndex = ficaListBox.SelectedIndex
        hourlyPayListBox.SelectedIndex = ficaListBox.SelectedIndex
    End Sub

    Private Sub StateListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles stateListBox.SelectedIndexChanged
        employeeListBox.SelectedIndex = stateListBox.SelectedIndex
        socialSecurityListBox.SelectedIndex = stateListBox.SelectedIndex
        ficaListBox.SelectedIndex = stateListBox.SelectedIndex
        hourlyPayListBox.SelectedIndex = stateListBox.SelectedIndex
    End Sub
End Class
