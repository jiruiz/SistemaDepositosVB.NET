Imports CapaNegocio
Imports CapaEntidad
Public Class frmNuevaAgencia
    Dim capaNegocio As New CNAgencia
    Private listadoAgencias As New DataSet



    Private Sub frmNuevaAgencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Call generaCodigo()
        Call cargaAgencias()
    End Sub

    Sub generaCodigo()
        txtID.Text = capaNegocio.nuevoCodigo
    End Sub

    Function getId() As String
        Return txtID.Text
    End Function
    Function getNombre() As String
        Return txtNombre.Text

    End Function
    Sub cargaAgencias()
        Dim capaNegocio As New CNAgencia
        listadoAgencias = capaNegocio.listadoAgencias()
        gridNuevaAgencia.DataSource = capaNegocio.listadoAgencias.Tables("Agencias")

    End Sub

    Private Sub btnGuardarAgencia_Click(sender As Object, e As EventArgs) Handles btnGuardarAgencia.Click
        Dim objeto As New CEAgencia
        objeto.idAgencia = getId()
        objeto.nombre = getNombre()

        capaNegocio.nuevaAgencia(objeto)
        ' Actualiza el ID después de guardar la nueva agencia
        txtNombre.Text = String.Empty


        Call cargaAgencias()
        Call generaCodigo()
    End Sub


End Class