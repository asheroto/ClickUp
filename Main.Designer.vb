<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.WV = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.Timer_Title = New System.Windows.Forms.Timer(Me.components)
        Me.SystemTrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Startup = New System.Windows.Forms.Timer(Me.components)
        CType(Me.WV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'WV
        '
        Me.WV.CreationProperties = Nothing
        Me.WV.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WV.Location = New System.Drawing.Point(0, 0)
        Me.WV.Name = "WV"
        Me.WV.Size = New System.Drawing.Size(800, 450)
        Me.WV.Source = New System.Uri("https://app.clickup.com/", System.UriKind.Absolute)
        Me.WV.TabIndex = 0
        Me.WV.ZoomFactor = 1.0R
        '
        'Timer_Title
        '
        Me.Timer_Title.Interval = 1000
        '
        'SystemTrayIcon
        '
        Me.SystemTrayIcon.ContextMenuStrip = Me.ContextMenu
        Me.SystemTrayIcon.Icon = CType(resources.GetObject("SystemTrayIcon.Icon"), System.Drawing.Icon)
        Me.SystemTrayIcon.Text = "ClickUp"
        Me.SystemTrayIcon.Visible = True
        '
        'ContextMenu
        '
        Me.ContextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenu.Name = "ContextMenu"
        Me.ContextMenu.Size = New System.Drawing.Size(104, 48)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'Startup
        '
        Me.Startup.Enabled = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.WV)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClickUp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.WV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WV As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Timer_Title As Timer
    Friend WithEvents SystemTrayIcon As NotifyIcon
    Friend WithEvents ContextMenu As ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Startup As Timer
End Class
