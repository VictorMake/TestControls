Imports System.ComponentModel

Public Class UserControlListBox
    Inherits Windows.Forms.UserControl
    Implements IUserControl

    Public Event ListBoxSelectedIndexChanged As EventHandler
    Sub New()
        MyBase.New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Name = "Empty"
        EnumOfType = UserControl.EnumTypeOfControls.ListBox
        TypeOfControls = GetType(UserControlListBox)
    End Sub

    Sub New(ByVal Name As String)
        MyBase.New()
        Me.Name = Name
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        EnumOfType = UserControl.EnumTypeOfControls.ListBox
        TypeOfControls = GetType(UserControlListBox)
    End Sub

#Region "Variables and Enumerations"
    Private mText As String
    Private mDescription As String
    Private mValue As String
    Private mUserValue As String
    Private mGetDescriptionAttribute As String
#End Region

    Public Overloads Property keyControlStage() As Integer Implements IUserControl.keyControlStage

    Public Overloads Function ValidatedUserValue() As Boolean Implements IUserControl.ValidatedUserValue
        If InputOrOutput Then
            Return UserValue <> ""
        Else
            Return True
        End If
    End Function

    Public Overloads Sub EraseValue() Implements IUserControl.EraseValue
        'ListBox.Items.Clear()
        'ComboBox может быть заполнен запросом
        ListBox.SelectedIndex = -1
        mValue = ""
        mUserValue = ""
    End Sub

    Public Overloads Property Query() As String Implements IUserControl.Query
    Public Overloads Property Name() As String Implements IUserControl.Name

    Public Overloads Property Text() As String Implements IUserControl.Text
        Get
            Return mText
        End Get
        Set(ByVal value As String)
            mText = value
            LabelText.Text = mText
        End Set
    End Property

    Public ReadOnly Property GetDescriptionAttribute() As String Implements IUserControl.GetDescriptionAttribute
        Get
            Return UserControl.GetDescriptionAttribute(EnumOfType)
        End Get
    End Property


#Region "Control Properties"
    Public ReadOnly Property TypeOfControls() As Type Implements IUserControl.TypeOfControls

    <TypeConverter(GetType(EnumTypeConverter))>
    Public ReadOnly Property EnumOfType() As UserControl.EnumTypeOfControls Implements IUserControl.EnumOfType 'ReadOnly
    Public Property IndexLocationOnPanel() As Integer Implements IUserControl.IndexLocationOnPanel

    Public Property Description() As String Implements IUserControl.Description
        Get
            Return mDescription
        End Get
        Set(ByVal value As String)
            mDescription = value
            Me.ToolTip1.SetToolTip(Me.ListBox, mDescription)
        End Set
    End Property

    Public Property InputOrOutput() As Boolean Implements IUserControl.InputOrOutput

    Public Property Value() As String Implements IUserControl.Value
        Get
            Return mValue
        End Get
        Set(ByVal value As String)
            If value IsNot Nothing Then
                mValue = value
                Dim strItem() As String = value.Split(";"c)
                ListBox.Items.AddRange(strItem)
            End If
        End Set
    End Property

    Public Property BooleanValue() As Boolean Implements IUserControl.BooleanValue

    Public Property UserValue() As String Implements IUserControl.UserValue
        Get
            If ListBox.InvokeGetIntegerEX(Function()
                                              Return ListBox.SelectedIndex
                                          End Function) <> -1 Then
                mUserValue = CStr(ListBox.InvokeGetObjectEX(Function()
                                                                Return CStr(ListBox.SelectedItem)
                                                            End Function))
            Else
                mUserValue = ""
            End If

            'If ListBox.SelectedIndex <> -1 Then
            '    mЗначениеПользователя = ListBox.SelectedItem
            'Else
            '    mЗначениеПользователя = ""
            'End If
            Return mUserValue
        End Get
        Set(ByVal value As String)
            If value IsNot Nothing Then
                mUserValue = value
                ListBox.SelectedIndex = ListBox.Items.IndexOf(mUserValue)
            End If
        End Set
    End Property

    Public Property Row() As Integer Implements IUserControl.Row
    Public Property Col() As Integer Implements IUserControl.Col
#End Region

    Private Sub ListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox.SelectedIndexChanged
        RaiseEvent ListBoxSelectedIndexChanged(Me, e)
    End Sub
End Class
