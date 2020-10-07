Imports System.ComponentModel

Public Class UserControlComboBox
    Inherits Windows.Forms.UserControl
    Implements IUserControl

    Public Event ComboBoxSelectedIndexChanged As EventHandler

    Sub New()
        MyBase.New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        'Me.new("Empty")
        ' Add any initialization after the InitializeComponent() call.
        Name = "Empty"
        EnumOfType = UserControl.EnumTypeOfControls.ComboBox
        TypeOfControls = GetType(UserControlComboBox)
    End Sub

    Sub New(ByVal Name As String)
        MyBase.New()
        Me.Name = Name
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        EnumOfType = UserControl.EnumTypeOfControls.ComboBox
        TypeOfControls = GetType(UserControlComboBox)
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
        ComboBox.Items.Clear()
        'ComboBox может быть заполнен запросом
        ComboBox.SelectedIndex = -1
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
            Me.ToolTip1.SetToolTip(Me.ComboBox, mDescription)
        End Set
    End Property

    Public Property InputOrOutput() As Boolean Implements IUserControl.InputOrOutput
    Public Property Value() As String Implements IUserControl.Value
        Get
            Return mValue
        End Get
        Set(ByVal value As String)
            If value IsNot Nothing Then
                If value <> "" Then
                    mValue = value
                    Dim strItem() As String = value.Split(";"c)
                    ComboBox.Items.AddRange(strItem)
                    If CStr(ComboBox.Items(0)) = vbNullString Then
                        ComboBox.Items.RemoveAt(0)
                    End If
                End If
            End If
        End Set
    End Property

    Public Property BooleanValue() As Boolean Implements IUserControl.BooleanValue
    Public Property UserValue() As String Implements IUserControl.UserValue
        Get
            mUserValue = InvokeGetTextEX(Function()
                                             Return ComboBox.Text
                                         End Function) 'GetComboBoxText() ' ComboBox.Text
            Return mUserValue
        End Get
        Set(ByVal value As String)
            If value IsNot Nothing Then
                mUserValue = value
                If ComboBox.Items.IndexOf(mUserValue) = -1 Then
                    ComboBox.Items.Add(mUserValue)
                    ComboBox.Text = mUserValue
                Else
                    ComboBox.SelectedIndex = ComboBox.Items.IndexOf(mUserValue)
                End If
            End If
        End Set
    End Property

    'Private Function GetComboBoxText() As String
    '    If InvokeRequired Then
    '        Invoke(New MethodInvoker(Function()
    '                                     Return GetComboBoxText()
    '                                 End Function))
    '    Else
    '        Return ComboBox.Text
    '    End If
    'End Function

    Public Property Row() As Integer Implements IUserControl.Row
    Public Property Col() As Integer Implements IUserControl.Col
#End Region

    Private Sub ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles ComboBox.SelectedIndexChanged
        RaiseEvent ComboBoxSelectedIndexChanged(Me, e)
    End Sub
End Class
