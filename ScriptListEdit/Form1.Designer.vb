﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmScriptListEdit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.lblGAFile = New System.Windows.Forms.Label()
        Me.tabControlRoot = New System.Windows.Forms.TabControl()
        Me.tabLuainfo = New System.Windows.Forms.TabPage()
        Me.dgvLuainfo = New System.Windows.Forms.DataGridView()
        Me.tabControlRoot.SuspendLayout()
        Me.tabLuainfo.SuspendLayout()
        CType(Me.dgvLuainfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(743, 40)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 35
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.Location = New System.Drawing.Point(665, 40)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(75, 23)
        Me.btnOpen.TabIndex = 34
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.AllowDrop = True
        Me.txtFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFile.Location = New System.Drawing.Point(46, 14)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(772, 20)
        Me.txtFile.TabIndex = 31
        '
        'lblGAFile
        '
        Me.lblGAFile.AutoSize = True
        Me.lblGAFile.Location = New System.Drawing.Point(14, 17)
        Me.lblGAFile.Name = "lblGAFile"
        Me.lblGAFile.Size = New System.Drawing.Size(26, 13)
        Me.lblGAFile.TabIndex = 33
        Me.lblGAFile.Text = "File:"
        '
        'tabControlRoot
        '
        Me.tabControlRoot.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControlRoot.Controls.Add(Me.tabLuainfo)
        Me.tabControlRoot.Location = New System.Drawing.Point(12, 66)
        Me.tabControlRoot.Margin = New System.Windows.Forms.Padding(0)
        Me.tabControlRoot.Name = "tabControlRoot"
        Me.tabControlRoot.Padding = New System.Drawing.Point(10, 4)
        Me.tabControlRoot.SelectedIndex = 0
        Me.tabControlRoot.Size = New System.Drawing.Size(806, 686)
        Me.tabControlRoot.TabIndex = 46
        '
        'tabLuainfo
        '
        Me.tabLuainfo.Controls.Add(Me.dgvLuainfo)
        Me.tabLuainfo.Location = New System.Drawing.Point(4, 24)
        Me.tabLuainfo.Margin = New System.Windows.Forms.Padding(0)
        Me.tabLuainfo.Name = "tabLuainfo"
        Me.tabLuainfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLuainfo.Size = New System.Drawing.Size(798, 658)
        Me.tabLuainfo.TabIndex = 2
        Me.tabLuainfo.Text = "luainfo"
        Me.tabLuainfo.UseVisualStyleBackColor = True
        '
        'dgvLuainfo
        '
        Me.dgvLuainfo.AllowUserToAddRows = False
        Me.dgvLuainfo.AllowUserToDeleteRows = False
        Me.dgvLuainfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvLuainfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLuainfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLuainfo.Location = New System.Drawing.Point(3, 3)
        Me.dgvLuainfo.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvLuainfo.Name = "dgvLuainfo"
        Me.dgvLuainfo.RowHeadersWidth = 60
        Me.dgvLuainfo.Size = New System.Drawing.Size(792, 652)
        Me.dgvLuainfo.TabIndex = 39
        '
        'frmScriptListEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 761)
        Me.Controls.Add(Me.tabControlRoot)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.lblGAFile)
        Me.Name = "frmScriptListEdit"
        Me.Text = "Script List Edit"
        Me.tabControlRoot.ResumeLayout(False)
        Me.tabLuainfo.ResumeLayout(False)
        CType(Me.dgvLuainfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents lblGAFile As System.Windows.Forms.Label
    Friend WithEvents tabControlRoot As TabControl
    Friend WithEvents tabLuainfo As TabPage
    Friend WithEvents dgvLuainfo As DataGridView
End Class
