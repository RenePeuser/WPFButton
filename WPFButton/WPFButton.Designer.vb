Option Strict On
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Windows.Forms.Integration

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WPFButton
    Inherits System.Windows.Forms.UserControl

    'InteropUserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    Private WithEvents wpfButtonEvents As WPFButtonTemplate.WPFButtonTemplate
    Private wpfButton As New WPFButtonTemplate.WPFButtonTemplate

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font


        Dim elementHost As New ElementHost

        wpfButton.Name = "wpfButton"
        '
        elementHost.Dock = System.Windows.Forms.DockStyle.Fill
        elementHost.Location = New System.Drawing.Point(0, 0)
        elementHost.Name = "elementHost"
        elementHost.Size = New System.Drawing.Size(148, 148)
        elementHost.TabIndex = 0
        elementHost.Child = wpfButton

        Me.Controls.Add(elementHost)

    End Sub
End Class
