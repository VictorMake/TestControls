Imports System
Imports System.ComponentModel
Imports System.Globalization
Imports System.Reflection


Public Class Form1



    'Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    MessageBox.Show(UserControlComboBox1.ЗначениеПользователя)
    '    UserControlComboBox1.Text = UserControlComboBox1.ЗначениеПользователя

    'End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    UserControlComboBox1.ЗначениеПользователя = UserControlComboBox1.ЗначениеПользователя
    'End Sub
    Dim WithEvents UserControlListBox2 As MDBControlLibrary.UserControlListBox

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ''MessageBox.Show(UserControlDate1.ЗначениеПользователя)
        'Dim MyDate As New DateTime
        'MyDate = TimeOfDay
        'Dim MyString As String = MyDate.ToString("HH:mm")
        'UserControlTime1.ЗначениеПользователя = MyString ' Format(TimeOfDay, "HH:mm")

        'MessageBox.Show(UserControlTime1.ЗначениеПользователя)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'UserControlListBox1.Value = "1;2;3;4"
        UserControlComboBox1.Value = "1;2;3;4"
        UserControlComboBox1.Value = "1;2;3;4"

        'UserControlComboBox1.


        Me.UserControlListBox2 = New MDBControlLibrary.UserControlListBox
        Me.FlowLayoutPanel1.Controls.Add(Me.UserControlListBox2)
        Me.UserControlListBox2.InputOrOutput = False
        'Me.UserControlListBox2.Location = New System.Drawing.Point(3, 3)
        Me.UserControlListBox2.Name = "UserControlListBox2"
        'Me.UserControlListBox2.Size = New System.Drawing.Size(200, 100)
        'Me.UserControlListBox2.TabIndex = 0
        Me.UserControlListBox2.Value = "1;2;3;4"
        'Me.UserControlListBox2.ЗначениеПользователя = Nothing
        Me.UserControlListBox2.ЛогическоеЗначение = False
        'Me.UserControlListBox2.МестоНаПанели = 0
        Me.UserControlListBox2.Text = "Ввод чего-то"
        Me.UserControlListBox2.Описание = "Ввод"
        AddHandler UserControlListBox2.ListBoxSelectedIndexChanged, AddressOf Me.SelectedIndexChanged


        '       public Form1(AbstractFactory factory, Form form) : base(form)
        '{
        '  Ok = (Button)factory.CreateControl(
        '         typeof(Button), 
        '         new object[]{0, 10, 100, 70, 20, "Ok"});
        '  form.AddControl(Ok);
        '}
        'public readonly Button Ok;



    End Sub

    'Private Sub UserControlListBox1_ListBoxSelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    MessageBox.Show(UserControlListBox1.ЗначениеПользователя)
    'End Sub

    'Private Sub UserControlComboBox1_ComboBoxSelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    MessageBox.Show(UserControlComboBox1.ЗначениеПользователя)
    'End Sub

    Private Sub SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'For Each item As Object In CheckedListMenu.DropDownItems
        '    If (TypeOf item Is ToolStripMenuItem) Then
        '        Dim itemObject As ToolStripMenuItem = CType(item, ToolStripMenuItem)
        '        itemObject.Checked = False
        '    End If
        'Next
        'Dim selectedItem As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        'selectedItem.Checked = True

        '1 способ привести к типу
        'typeof UserControlListBox2 is MDBControlLibrary.UserControlListBox вернет True
        If (TypeOf sender Is MDBControlLibrary.UserControlListBox) Then
            'If (TypeOf sender Is ListBox) Then
            Dim SelectedObject As MDBControlLibrary.UserControlListBox = CType(sender, MDBControlLibrary.UserControlListBox)
            'обработка SelectedObject
            'MessageBox.Show(SelectedObject.EnumOfType)

            'MessageBox.Show(SelectedObject.EnumOfType.ToString)

        ElseIf (TypeOf sender Is MDBControlLibrary.UserControlComboBox) Then
            'ElseIf (TypeOf sender Is ComboBox) Then
            Dim SelectedObject As MDBControlLibrary.UserControlComboBox = CType(sender, MDBControlLibrary.UserControlComboBox)
            'обработка UserControlComboBox
            MessageBox.Show(SelectedObject.EnumOfType.ToString)
        End If
        '2 способ привести к интерфейсу
        Dim SelectedObject2 As MDBControlLibrary.IUserControl = CType(sender, MDBControlLibrary.IUserControl)
        'MessageBox.Show(SelectedObject2.EnumOfType.ToString)
        'MessageBox.Show(SelectedObject2.ЗначениеПользователя)

        'MessageBox.Show(SelectedObject2.EnumOfType)

        'Dim _EnumType As Type = GetType(MDBControlLibrary.UserControl.EnumTypeOfControls)
        'Dim strDescription As String
        'Dim fi As FieldInfo = _EnumType.GetField([Enum].GetName(_EnumType, SelectedObject2.EnumOfType))
        'Dim dna As DescriptionAttribute = CType(Attribute.GetCustomAttribute(fi, GetType(DescriptionAttribute)), DescriptionAttribute)
        'If dna IsNot Nothing Then
        '    strDescription = dna.Description
        'Else
        '    strDescription = SelectedObject2.EnumOfType.ToString()
        'End If
        'MessageBox.Show(strDescription)


        MessageBox.Show(SelectedObject2.GetDescriptionAttribute)



        'GetType(typename)
        '?GetType(MDBControlLibrary.UserControlListBox)
        '{System.RuntimeType}
        '    System.RuntimeType: {Name = "UserControlListBox" FullName = "MDBControlLibrary.UserControlListBox"}
        '?GetType(MDBControlLibrary.UserControlListBox).ToString
        '"MDBControlLibrary.UserControlListBox"
        '2 способ

        'lstMultiSelect.SelectionMode = CType(System.Enum.Parse(GetType(SelectionMode), cboSelectionMode.Text), SelectionMode)
        'Dim SelectedObject2 As Control = CType(System.Enum.Parse(GetType(SelectionMode), sender.Name), MDBControlLibrary.ClassType)
        'Dim SelectedObject2 As Control '= New Control ' GetType(sender.TypeOfControls)
        'SelectedObject2.EnumOfType = CType(System.Enum.Parse(GetType(MDBControlLibrary.ClassType.TypeOfControls), sender.EnumOfType), MDBControlLibrary.ClassType.TypeOfControls)

        'ApplicationManager.CreateObject(Of String, Type, String, String, Boolean, Boolean)()
        'Me.CreateObject(Of String, Type, String, String, Boolean, Boolean)()
        'SelectedObject2 = CType(sender, sender.TypeOfControls)

    End Sub


    'Sub TestExcel()
    '    Dim xlApp As Microsoft.Office.Interop.Excel.Application
    '    Dim xlBook As Microsoft.Office.Interop.Excel.Workbook
    '    Dim xlSheet As Microsoft.Office.Interop.Excel.Worksheet

    '    xlApp = CType(CreateObject("Excel.Application"), _
    '                Microsoft.Office.Interop.Excel.Application)
    '    xlBook = CType(xlApp.Workbooks.Add, _
    '                Microsoft.Office.Interop.Excel.Workbook)
    '    xlSheet = CType(xlBook.Worksheets(1), _
    '                Microsoft.Office.Interop.Excel.Worksheet)

    '    ' The following statement puts text in the second row of the sheet.
    '    xlSheet.Cells(2, 2) = "This is column B row 2"
    '    ' The following statement shows the sheet.
    '    xlSheet.Application.Visible = True
    '    ' The following statement saves the sheet to the C:\Test.xls directory.
    '    xlSheet.SaveAs("C:\Test.xls")
    '    ' Optionally, you can call xlApp.Quit to close the workbook.
    'End Sub


End Class
