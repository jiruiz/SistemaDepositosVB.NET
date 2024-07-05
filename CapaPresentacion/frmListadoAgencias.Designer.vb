<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoAgencias
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
        gridAgencias = New DataGridView()
        lblTotalAgencias = New Label()
        Label4 = New Label()
        CType(gridAgencias, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(235, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(243, 30)
        Label1.TabIndex = 0
        Label1.Text = "LISTADO DE AGENCIAS"
        ' 
        ' gridAgencias
        ' 
        gridAgencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        gridAgencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gridAgencias.Location = New Point(33, 143)
        gridAgencias.Name = "gridAgencias"
        gridAgencias.Size = New Size(696, 181)
        gridAgencias.TabIndex = 1
        ' 
        ' lblTotalAgencias
        ' 
        lblTotalAgencias.AutoSize = True
        lblTotalAgencias.Location = New Point(574, 374)
        lblTotalAgencias.Name = "lblTotalAgencias"
        lblTotalAgencias.Size = New Size(41, 15)
        lblTotalAgencias.TabIndex = 3
        lblTotalAgencias.Text = "Label3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(176, 366)
        Label4.Name = "Label4"
        Label4.Size = New Size(201, 25)
        Label4.TabIndex = 4
        Label4.Text = "TOTAL DE AGENCIAS "
        ' 
        ' frmListadoAgencias
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(lblTotalAgencias)
        Controls.Add(gridAgencias)
        Controls.Add(Label1)
        Name = "frmListadoAgencias"
        Text = "frmListadoAgencias"
        CType(gridAgencias, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gridAgencias As DataGridView
    Friend WithEvents lblTotalAgencias As Label
    Friend WithEvents Label4 As Label
End Class
