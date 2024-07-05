<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuevaAgencia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtID = New TextBox()
        txtNombre = New TextBox()
        gridNuevaAgencia = New DataGridView()
        btnGuardarAgencia = New Button()
        CType(gridNuevaAgencia, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(242, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 0
        Label1.Text = "ID AGENCIA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(242, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 15)
        Label2.TabIndex = 1
        Label2.Text = "NOMBRE"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(377, 69)
        txtID.Name = "txtID"
        txtID.Size = New Size(100, 23)
        txtID.TabIndex = 2
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(377, 128)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(100, 23)
        txtNombre.TabIndex = 3
        ' 
        ' gridNuevaAgencia
        ' 
        gridNuevaAgencia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gridNuevaAgencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridNuevaAgencia.Location = New Point(69, 200)
        gridNuevaAgencia.Name = "gridNuevaAgencia"
        gridNuevaAgencia.Size = New Size(652, 150)
        gridNuevaAgencia.TabIndex = 4
        ' 
        ' btnGuardarAgencia
        ' 
        btnGuardarAgencia.Location = New Point(567, 73)
        btnGuardarAgencia.Name = "btnGuardarAgencia"
        btnGuardarAgencia.Size = New Size(75, 23)
        btnGuardarAgencia.TabIndex = 5
        btnGuardarAgencia.Text = "GUARDAR"
        btnGuardarAgencia.TextImageRelation = TextImageRelation.TextAboveImage
        btnGuardarAgencia.UseVisualStyleBackColor = True
        ' 
        ' frmNuevaAgencia
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnGuardarAgencia)
        Controls.Add(gridNuevaAgencia)
        Controls.Add(txtNombre)
        Controls.Add(txtID)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmNuevaAgencia"
        Text = "frmNuevaAgencia"
        CType(gridNuevaAgencia, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents gridNuevaAgencia As DataGridView
    Friend WithEvents btnGuardarAgencia As Button
End Class
