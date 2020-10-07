Imports System.ComponentModel

Public Class UserControlTextBox
    Inherits Windows.Forms.UserControl
    Implements IUserControl

    Public Event TextBoxTextChanged As EventHandler

    Sub New()
        MyBase.New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'Me.new("Empty")
        ' Add any initialization after the InitializeComponent() call.
        Name = "Empty"
        EnumOfType = UserControl.EnumTypeOfControls.TextBox
        TypeOfControls = GetType(UserControlTextBox)
    End Sub

    Sub New(ByVal Name As String)
        MyBase.New()
        Me.Name = Name
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        EnumOfType = UserControl.EnumTypeOfControls.TextBox
        TypeOfControls = GetType(UserControlTextBox)
    End Sub

#Region "Variables and Enumerations"
    Private mText As String
    Private mDescription As String
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
        TextBox.Text = ""
        mUserValue = TextBox.Text
    End Sub

    Public Overloads Property Query() As String Implements IUserControl.Query
    Public Overloads Property Name() As String Implements IUserControl.Name

#Region "Control Properties"
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
            Me.ToolTip1.SetToolTip(Me.TextBox, mDescription)
        End Set
    End Property

    Public Property InputOrOutput() As Boolean Implements IUserControl.InputOrOutput

    Public Property Value() As String Implements IUserControl.Value
        Get
            mUserValue = TextBox.Text
            Return mUserValue
        End Get
        Set(ByVal value As String)
            mUserValue = value
            TextBox.Text = mUserValue
        End Set
    End Property

    Public Property BooleanValue() As Boolean Implements IUserControl.BooleanValue

    Public Property UserValue() As String Implements IUserControl.UserValue
        Get
            mUserValue = InvokeGetTextEX(Function()
                                             Return TextBox.Text
                                         End Function) 'TextBox.Text
            Return mUserValue
        End Get
        Set(ByVal value As String)
            mUserValue = value
            TextBox.Text = mUserValue
        End Set
    End Property

    Public Property Row() As Integer Implements IUserControl.Row
    Public Property Col() As Integer Implements IUserControl.Col
#End Region

    Private Sub TextBox_TextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles TextBox.TextChanged
        RaiseEvent TextBoxTextChanged(Me, e)
    End Sub
End Class
