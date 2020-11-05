Public Class Customer
    Private _Firstname As String
    Private _Lastname As String
    Private _Job As String
    Private _Amountmoney As String

#Region "Constructors"
    Private _p1 As String
    Private _p2 As String


    Public Sub New()
        'default constructor
        _Firstname = ""
        _Lastname = ""
        _Job = ""
        _Amountmoney = ""
    End Sub
    Public Sub New(ByVal firstname As String, ByVal lastname As String, ByVal jobtype As String, ByVal amountmoney As String)
        Me._Firstname = firstname
        Me._Lastname = lastname
        Me._Job = jobtype
        Me._Amountmoney = amountmoney
    End Sub
#End Region
#Region "Properties"

    Sub New(p1 As String, p2 As String)
        ' TODO: Complete member initialization 
        _p1 = p1
        _p2 = p2

    End Sub

    Public Property FirstName As String
        Get
            Return _Firstname
        End Get
        Set(value As String)
            _Firstname = value
        End Set
    End Property
    Public Property LastName As String
        Get
            Return _Lastname
        End Get
        Set(value As String)
            _Lastname = value
        End Set
    End Property
    Public Property jobtype As String
        Get
            Return _Job
        End Get
        Set(value As String)
            _Job = value
        End Set
    End Property
    Public Property amountmoney As String
        Get
            Return _Amountmoney
        End Get
        Set(value As String)
            _Amountmoney = value
        End Set
    End Property
#End Region
End Class
