Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports CapaEntidad
Public Class CEAgencia
    Private _idAgencia As Int16
    Private _nombre As String

    Public Property idAgencia As String
        Get
            Return _idAgencia
        End Get
        Set(value As String)
            _idAgencia = value
        End Set
    End Property



    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
End Class
