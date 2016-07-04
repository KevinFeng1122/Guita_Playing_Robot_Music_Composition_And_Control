<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 选择和弦
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ListViewGroup10 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("A", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup11 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("B", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup12 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("C", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup13 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("D", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup14 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("E", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup15 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("F", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup16 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("G", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup17 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("#", System.Windows.Forms.HorizontalAlignment.Center)
        Dim ListViewGroup18 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("b", System.Windows.Forms.HorizontalAlignment.Center)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(选择和弦))
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.新增和弦ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.编辑和弦ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.仅显示文字ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        ListViewGroup10.Header = "A"
        ListViewGroup10.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup10.Name = "lsvGroupA"
        ListViewGroup11.Header = "B"
        ListViewGroup11.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup11.Name = "lsvGroupB"
        ListViewGroup12.Header = "C"
        ListViewGroup12.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup12.Name = "lsvGroupC"
        ListViewGroup13.Header = "D"
        ListViewGroup13.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup13.Name = "lsvGroupD"
        ListViewGroup14.Header = "E"
        ListViewGroup14.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup14.Name = "lsvGroupE"
        ListViewGroup15.Header = "F"
        ListViewGroup15.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup15.Name = "lsvGroupF"
        ListViewGroup16.Header = "G"
        ListViewGroup16.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup16.Name = "lsvGroupG"
        ListViewGroup17.Header = "#"
        ListViewGroup17.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup17.Name = "lsvGroup#"
        ListViewGroup18.Header = "b"
        ListViewGroup18.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center
        ListViewGroup18.Name = "lsvGroupb"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup10, ListViewGroup11, ListViewGroup12, ListViewGroup13, ListViewGroup14, ListViewGroup15, ListViewGroup16, ListViewGroup17, ListViewGroup18})
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(622, 420)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新增和弦ToolStripMenuItem, Me.编辑和弦ToolStripMenuItem, Me.仅显示文字ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(137, 70)
        '
        '新增和弦ToolStripMenuItem
        '
        Me.新增和弦ToolStripMenuItem.Name = "新增和弦ToolStripMenuItem"
        Me.新增和弦ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.新增和弦ToolStripMenuItem.Text = "新增和弦"
        '
        '编辑和弦ToolStripMenuItem
        '
        Me.编辑和弦ToolStripMenuItem.Name = "编辑和弦ToolStripMenuItem"
        Me.编辑和弦ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.编辑和弦ToolStripMenuItem.Text = "编辑和弦"
        '
        '仅显示文字ToolStripMenuItem
        '
        Me.仅显示文字ToolStripMenuItem.CheckOnClick = True
        Me.仅显示文字ToolStripMenuItem.Name = "仅显示文字ToolStripMenuItem"
        Me.仅显示文字ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.仅显示文字ToolStripMenuItem.Text = "仅显示文字"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "#Cm.png")
        Me.ImageList1.Images.SetKeyName(1, "#Dm.png")
        Me.ImageList1.Images.SetKeyName(2, "#F.png")
        Me.ImageList1.Images.SetKeyName(3, "#F7.png")
        Me.ImageList1.Images.SetKeyName(4, "#Fm.png")
        Me.ImageList1.Images.SetKeyName(5, "#Gm.png")
        Me.ImageList1.Images.SetKeyName(6, "A.png")
        Me.ImageList1.Images.SetKeyName(7, "A7.png")
        Me.ImageList1.Images.SetKeyName(8, "Am.png")
        Me.ImageList1.Images.SetKeyName(9, "B.png")
        Me.ImageList1.Images.SetKeyName(10, "B7.png")
        Me.ImageList1.Images.SetKeyName(11, "bB.png")
        Me.ImageList1.Images.SetKeyName(12, "Bm.png")
        Me.ImageList1.Images.SetKeyName(13, "C.png")
        Me.ImageList1.Images.SetKeyName(14, "C7.png")
        Me.ImageList1.Images.SetKeyName(15, "D.png")
        Me.ImageList1.Images.SetKeyName(16, "D7.png")
        Me.ImageList1.Images.SetKeyName(17, "Dm.png")
        Me.ImageList1.Images.SetKeyName(18, "E.png")
        Me.ImageList1.Images.SetKeyName(19, "E7.png")
        Me.ImageList1.Images.SetKeyName(20, "Em.png")
        Me.ImageList1.Images.SetKeyName(21, "F.png")
        Me.ImageList1.Images.SetKeyName(22, "G.png")
        Me.ImageList1.Images.SetKeyName(23, "G7.png")
        Me.ImageList1.Images.SetKeyName(24, "Gm.png")
        Me.ImageList1.Images.SetKeyName(25, "用户自定义和弦.png")
        '
        '选择和弦
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 420)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "选择和弦"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "选择和弦"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 新增和弦ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 仅显示文字ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 编辑和弦ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
