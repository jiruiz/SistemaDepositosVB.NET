Imports CapaNegocio

Public Class frmListadoAgencias
    Private listadoAgencias As New DataSet
    Private Sub frmListadoAgencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargaAgencias()
    End Sub

    Sub cargaAgencias()
        Dim capaNegocio As New CNAgencia
        listadoAgencias = capaNegocio.listadoAgencias()
        gridAgencias.DataSource = capaNegocio.listadoAgencias.Tables("Agencias")
        lblTotalAgencias.Text = capaNegocio.listadoAgencias.Tables("Agencias").Rows.Count

    End Sub


End Class




