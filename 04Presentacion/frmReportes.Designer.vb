<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportes
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
        Me.crvVisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvVisorReporte
        '
        Me.crvVisorReporte.ActiveViewIndex = -1
        Me.crvVisorReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvVisorReporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvVisorReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvVisorReporte.Location = New System.Drawing.Point(0, 0)
        Me.crvVisorReporte.Name = "crvVisorReporte"
        Me.crvVisorReporte.ShowGroupTreeButton = False
        Me.crvVisorReporte.Size = New System.Drawing.Size(587, 510)
        Me.crvVisorReporte.TabIndex = 0
        Me.crvVisorReporte.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 510)
        Me.Controls.Add(Me.crvVisorReporte)
        Me.Name = "frmReportes"
        Me.Text = "frmReportes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crvVisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
