'TODA LA LOGICA DEL MANTENIMIENTO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports CapaEntidad
Public Class DAOAgencia
    Dim objConnect As New Conexion
    Dim connect As SqlConnection
    Dim dAdapter As SqlDataAdapter


    Public Function listadoAgencias() As DataSet
        Dim dSet As New DataSet
        connect = objConnect.conectar

        dAdapter = New SqlDataAdapter("SELECT * FROM agencia", connect)
        dAdapter.Fill(dSet, "Agencias")
        Return dSet
    End Function


    Public Function nuevoCodigo() As String
        Dim connect As SqlConnection = objConnect.conectar()
        connect.Open()

        Dim dAdapter As New SqlDataAdapter("SELECT MAX(ID) FROM agencia", connect)
        Dim ultimo As Object = dAdapter.SelectCommand.ExecuteScalar()

        connect.Close()

        If ultimo IsNot DBNull.Value AndAlso ultimo IsNot Nothing Then
            Dim siguienteID As Integer = Convert.ToInt32(ultimo) + 1
            Return siguienteID.ToString()
        Else
            Return "No se encontró ningún ID."
        End If
    End Function




    Public Sub nuevaAgencia(ByVal objAg As CEAgencia)
        connect = objConnect.conectar
        Try
            connect.Open()
            dAdapter = New SqlDataAdapter("INSERT INTO Agencia (Nombre) VALUES (@Nombre)", connect)
            dAdapter.SelectCommand.CommandType = CommandType.Text

            With dAdapter.SelectCommand.Parameters
                .Add("@Nombre", SqlDbType.VarChar).Value = objAg.nombre

            End With
            dAdapter.SelectCommand.ExecuteNonQuery()
            MsgBox("Agencia Registrada Correctamente...!!")


        Catch ex As Exception
            MsgBox("Error al registrar Agencia" & ex.Message, MsgBoxStyle.Critical)
        Finally
            dAdapter.Dispose()
            connect.Dispose()

        End Try
    End Sub
End Class
