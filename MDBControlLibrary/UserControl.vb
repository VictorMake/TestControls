Imports System.ComponentModel
Imports System.Globalization
Imports System.Reflection

''' <summary>
''' TypeConverter для Enum, преобразовывающий Enum к строке с
''' учетом атрибута Description
''' </summary>
Public Class EnumTypeConverter
    Inherits EnumConverter

    Private _EnumType As Type
    ''' <summary>
    ''' Инициализирует экземпляр
    ''' </summary>
    ''' <param name="type">тип Enum</param>
    Public Sub New(ByVal type As Type)
        MyBase.New(type)
        _EnumType = type
    End Sub

    Public Overloads Overrides Function CanConvertTo(ByVal context As ITypeDescriptorContext, ByVal destType As Type) As Boolean
        Return destType Is GetType(String)
    End Function

    Public Overloads Overrides Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object, ByVal destType As Type) As Object
        Dim fi As FieldInfo = _EnumType.GetField([Enum].GetName(_EnumType, value))
        Dim dna As DescriptionAttribute = DirectCast(Attribute.GetCustomAttribute(fi, GetType(DescriptionAttribute)), DescriptionAttribute)
        If dna IsNot Nothing Then
            Return dna.Description
        Else
            Return value.ToString()
        End If
    End Function

    Public Overloads Overrides Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal srcType As Type) As Boolean
        Return srcType Is GetType(String)
    End Function

    Public Overloads Overrides Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object) As Object
        For Each fi As FieldInfo In _EnumType.GetFields()
            Dim dna As DescriptionAttribute = DirectCast(Attribute.GetCustomAttribute(fi, GetType(DescriptionAttribute)), DescriptionAttribute)
            If (dna IsNot Nothing) AndAlso (DirectCast(value, String) = dna.Description) Then
                Return [Enum].Parse(_EnumType, fi.Name)
            End If
        Next
        Return [Enum].Parse(_EnumType, DirectCast(value, String))
    End Function
End Class

Public Class UserControl
    Public Enum EnumTypeOfControls
        <Description("Используется TextBox")> _
        TextBox
        <Description("Используется ListBox")> _
        ListBox
        <Description("Используется CheckBox")> _
        CheckBox
        <Description("Используется ComboBox")> _
        ComboBox
        <Description("Используется ComboBox")> _
        DateBox
        <Description("Используется TimeBox")> _
        TimeBox
        <Description("Используется DigitalBox")> _
        DigitalBox
    End Enum

    Public Shared Function GetDescriptionAttribute(ByVal value As EnumTypeOfControls) As String
        Dim _EnumType As Type = GetType(EnumTypeOfControls)
        Dim fi As FieldInfo = _EnumType.GetField([Enum].GetName(_EnumType, value))
        Dim dna As DescriptionAttribute = CType(Attribute.GetCustomAttribute(fi, GetType(DescriptionAttribute)), DescriptionAttribute)
        If dna IsNot Nothing Then
            Return dna.Description
        Else
            Return value.ToString()
        End If
    End Function
End Class

Public Interface IUserControl
        'Event SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    Property Name() As String
    Property Text() As String
    ReadOnly Property GetDescriptionAttribute() As String
#Region "Control Properties"
    ReadOnly Property TypeOfControls() As Type

    <TypeConverter(GetType(EnumTypeConverter))> _
   ReadOnly Property EnumOfType() As UserControl.EnumTypeOfControls
    Property IndexLocationOnPanel() As Integer ' Место На Панели
    Property Description() As String ' Описание
    Property InputOrOutput() As Boolean 'используется в процедуре ValidatedUserValue
    'If mInputOrOutput=True Then если для ввода, то пользователь обязательно должен заполнить это поле
    '    Return ЗначениеПользователя <> ""
    'Else
    '    Return True если для вывода (mInputOrOutput=False), то проверку ввода пользователя можно не производить
    'End If
    Property Value() As String
    Property Query() As String
    Property BooleanValue() As Boolean ' Логическое Значение - если чек то используется это поле
    Property UserValue() As String ' Значение Пользователя
    Sub EraseValue()
    Function ValidatedUserValue() As Boolean
    Property keyControlStage() As Integer ' keyКонтролДляУровня
    Property Row() As Integer
    Property Col() As Integer
#End Region
End Interface




