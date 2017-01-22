<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.sbarImpressoraLBL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.TreeView = New System.Windows.Forms.TreeView()
        Me.treeViewToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsl_Etiqueta = New System.Windows.Forms.ToolStripLabel()
        Me.tsb_CreaEtiqueta = New System.Windows.Forms.ToolStripButton()
        Me.tsb_EliminaEtiqueta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparador1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsl_Elements = New System.Windows.Forms.ToolStripLabel()
        Me.tsbd_AfegeixElement = New System.Windows.Forms.ToolStripDropDownButton()
        Me.TextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodiDeBarresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImatgeBMPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImatgePCXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuadratToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LíniaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsb_EliminarElement = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.PropertyGrid = New System.Windows.Forms.PropertyGrid()
        Me.ElementMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AfegirNouElementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarEtiquetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AfegirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextElementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CodiDeBarresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImatgeBMPToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImatgePCXToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuadratToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LíniaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarElementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageListElements = New System.Windows.Forms.ImageList(Me.components)
        Me.SaveFileElement = New System.Windows.Forms.SaveFileDialog()
        Me.sbarImpressoraTXT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sbarCOMPortLBL = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sbarCOMPortTXT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Panel1.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.treeViewToolStrip.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.SuspendLayout()
        Me.ElementMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(919, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.StatusBar)
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 496)
        Me.Panel1.TabIndex = 1
        '
        'StatusBar
        '
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbarImpressoraLBL, Me.sbarImpressoraTXT, Me.sbarCOMPortLBL, Me.sbarCOMPortTXT, Me.ToolStripProgressBar1})
        Me.StatusBar.Location = New System.Drawing.Point(0, 474)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(919, 22)
        Me.StatusBar.TabIndex = 1
        Me.StatusBar.Text = "StatusStrip1"
        '
        'sbarImpressoraLBL
        '
        Me.sbarImpressoraLBL.Name = "sbarImpressoraLBL"
        Me.sbarImpressoraLBL.Size = New System.Drawing.Size(68, 17)
        Me.sbarImpressoraLBL.Text = "Impressora:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Size = New System.Drawing.Size(919, 496)
        Me.SplitContainer1.SplitterDistance = 238
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ToolStripContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnPrint)
        Me.SplitContainer2.Size = New System.Drawing.Size(234, 492)
        Me.SplitContainer2.SplitterDistance = 314
        Me.SplitContainer2.TabIndex = 0
        '
        'ToolStripContainer1
        '
        Me.ToolStripContainer1.BottomToolStripPanelVisible = False
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TreeView)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(234, 289)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.LeftToolStripPanelVisible = False
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.RightToolStripPanelVisible = False
        Me.ToolStripContainer1.Size = New System.Drawing.Size(234, 314)
        Me.ToolStripContainer1.TabIndex = 2
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.treeViewToolStrip)
        '
        'TreeView
        '
        Me.TreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView.Location = New System.Drawing.Point(0, 0)
        Me.TreeView.Name = "TreeView"
        Me.TreeView.ShowNodeToolTips = True
        Me.TreeView.Size = New System.Drawing.Size(234, 289)
        Me.TreeView.TabIndex = 1
        '
        'treeViewToolStrip
        '
        Me.treeViewToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.treeViewToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsl_Etiqueta, Me.tsb_CreaEtiqueta, Me.tsb_EliminaEtiqueta, Me.ToolStripSeparador1, Me.tsl_Elements, Me.tsbd_AfegeixElement, Me.tsb_EliminarElement})
        Me.treeViewToolStrip.Location = New System.Drawing.Point(3, 0)
        Me.treeViewToolStrip.Name = "treeViewToolStrip"
        Me.treeViewToolStrip.Size = New System.Drawing.Size(227, 25)
        Me.treeViewToolStrip.TabIndex = 0
        '
        'tsl_Etiqueta
        '
        Me.tsl_Etiqueta.Name = "tsl_Etiqueta"
        Me.tsl_Etiqueta.Size = New System.Drawing.Size(53, 22)
        Me.tsl_Etiqueta.Text = "Etiqueta:"
        Me.tsl_Etiqueta.ToolTipText = "Etiqueta:"
        '
        'tsb_CreaEtiqueta
        '
        Me.tsb_CreaEtiqueta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_CreaEtiqueta.Image = CType(resources.GetObject("tsb_CreaEtiqueta.Image"), System.Drawing.Image)
        Me.tsb_CreaEtiqueta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_CreaEtiqueta.Name = "tsb_CreaEtiqueta"
        Me.tsb_CreaEtiqueta.Size = New System.Drawing.Size(23, 22)
        Me.tsb_CreaEtiqueta.Text = "Nova etiqueta"
        Me.tsb_CreaEtiqueta.ToolTipText = "Crea etiqueta"
        '
        'tsb_EliminaEtiqueta
        '
        Me.tsb_EliminaEtiqueta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_EliminaEtiqueta.Image = CType(resources.GetObject("tsb_EliminaEtiqueta.Image"), System.Drawing.Image)
        Me.tsb_EliminaEtiqueta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_EliminaEtiqueta.Name = "tsb_EliminaEtiqueta"
        Me.tsb_EliminaEtiqueta.Size = New System.Drawing.Size(23, 22)
        Me.tsb_EliminaEtiqueta.Text = "Elimina l'etiqueta"
        '
        'ToolStripSeparador1
        '
        Me.ToolStripSeparador1.Name = "ToolStripSeparador1"
        Me.ToolStripSeparador1.Size = New System.Drawing.Size(6, 25)
        '
        'tsl_Elements
        '
        Me.tsl_Elements.Name = "tsl_Elements"
        Me.tsl_Elements.Size = New System.Drawing.Size(58, 22)
        Me.tsl_Elements.Text = "Elements:"
        Me.tsl_Elements.ToolTipText = "Elements:"
        '
        'tsbd_AfegeixElement
        '
        Me.tsbd_AfegeixElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbd_AfegeixElement.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextToolStripMenuItem, Me.CodiDeBarresToolStripMenuItem, Me.ImatgeBMPToolStripMenuItem, Me.ImatgePCXToolStripMenuItem, Me.QuadratToolStripMenuItem, Me.LíniaToolStripMenuItem})
        Me.tsbd_AfegeixElement.Image = CType(resources.GetObject("tsbd_AfegeixElement.Image"), System.Drawing.Image)
        Me.tsbd_AfegeixElement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbd_AfegeixElement.Name = "tsbd_AfegeixElement"
        Me.tsbd_AfegeixElement.Size = New System.Drawing.Size(29, 22)
        Me.tsbd_AfegeixElement.Text = "Afegeix un element..."
        '
        'TextToolStripMenuItem
        '
        Me.TextToolStripMenuItem.Name = "TextToolStripMenuItem"
        Me.TextToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TextToolStripMenuItem.Tag = ""
        Me.TextToolStripMenuItem.Text = "Text"
        '
        'CodiDeBarresToolStripMenuItem
        '
        Me.CodiDeBarresToolStripMenuItem.Name = "CodiDeBarresToolStripMenuItem"
        Me.CodiDeBarresToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CodiDeBarresToolStripMenuItem.Tag = "dim element as TSPLElementEtiqueta.celTypeOfElement.Barcode"
        Me.CodiDeBarresToolStripMenuItem.Text = "Codi de barres"
        '
        'ImatgeBMPToolStripMenuItem
        '
        Me.ImatgeBMPToolStripMenuItem.Name = "ImatgeBMPToolStripMenuItem"
        Me.ImatgeBMPToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ImatgeBMPToolStripMenuItem.Tag = "TSPLElementEtiqueta.celTypeOfElement.BMP"
        Me.ImatgeBMPToolStripMenuItem.Text = "Imatge BMP"
        '
        'ImatgePCXToolStripMenuItem
        '
        Me.ImatgePCXToolStripMenuItem.Name = "ImatgePCXToolStripMenuItem"
        Me.ImatgePCXToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ImatgePCXToolStripMenuItem.Tag = "TSPLElementEtiqueta.celTypeOfElement.PCX"
        Me.ImatgePCXToolStripMenuItem.Text = "Imatge PCX"
        '
        'QuadratToolStripMenuItem
        '
        Me.QuadratToolStripMenuItem.Name = "QuadratToolStripMenuItem"
        Me.QuadratToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.QuadratToolStripMenuItem.Tag = "TSPLElementEtiqueta.celTypeOfElement.Box"
        Me.QuadratToolStripMenuItem.Text = "Quadrat"
        '
        'LíniaToolStripMenuItem
        '
        Me.LíniaToolStripMenuItem.Name = "LíniaToolStripMenuItem"
        Me.LíniaToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.LíniaToolStripMenuItem.Tag = "TSPLElementEtiqueta.celTypeOfElement.Bar"
        Me.LíniaToolStripMenuItem.Text = "Línia"
        '
        'tsb_EliminarElement
        '
        Me.tsb_EliminarElement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsb_EliminarElement.Image = CType(resources.GetObject("tsb_EliminarElement.Image"), System.Drawing.Image)
        Me.tsb_EliminarElement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsb_EliminarElement.Name = "tsb_EliminarElement"
        Me.tsb_EliminarElement.Size = New System.Drawing.Size(23, 22)
        Me.tsb_EliminarElement.Text = "Elimina l'element"
        Me.tsb_EliminarElement.ToolTipText = "Eliminar l'element"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Guarda..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(142, 18)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.Text = "Imprimir"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.PropertyGrid)
        Me.SplitContainer3.Size = New System.Drawing.Size(673, 492)
        Me.SplitContainer3.SplitterDistance = 420
        Me.SplitContainer3.TabIndex = 0
        '
        'SplitContainer4
        '
        Me.SplitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SplitContainer4.Size = New System.Drawing.Size(420, 492)
        Me.SplitContainer4.SplitterDistance = 281
        Me.SplitContainer4.TabIndex = 0
        '
        'PropertyGrid
        '
        Me.PropertyGrid.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.PropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGrid.Location = New System.Drawing.Point(0, 0)
        Me.PropertyGrid.Name = "PropertyGrid"
        Me.PropertyGrid.Size = New System.Drawing.Size(249, 492)
        Me.PropertyGrid.TabIndex = 0
        '
        'ElementMenuStrip
        '
        Me.ElementMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AfegirNouElementToolStripMenuItem, Me.EliminarEtiquetaToolStripMenuItem, Me.ToolStripSeparator1, Me.AfegirToolStripMenuItem, Me.EliminarElementToolStripMenuItem})
        Me.ElementMenuStrip.Name = "ElementMenuStrip"
        Me.ElementMenuStrip.Size = New System.Drawing.Size(182, 98)
        '
        'AfegirNouElementToolStripMenuItem
        '
        Me.AfegirNouElementToolStripMenuItem.Name = "AfegirNouElementToolStripMenuItem"
        Me.AfegirNouElementToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AfegirNouElementToolStripMenuItem.Text = "Afegir nova etiqueta"
        '
        'EliminarEtiquetaToolStripMenuItem
        '
        Me.EliminarEtiquetaToolStripMenuItem.Name = "EliminarEtiquetaToolStripMenuItem"
        Me.EliminarEtiquetaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.EliminarEtiquetaToolStripMenuItem.Text = "Eliminar etiqueta"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'AfegirToolStripMenuItem
        '
        Me.AfegirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextElementToolStripMenuItem, Me.CodiDeBarresToolStripMenuItem1, Me.ImatgeBMPToolStripMenuItem1, Me.ImatgePCXToolStripMenuItem1, Me.QuadratToolStripMenuItem1, Me.LíniaToolStripMenuItem1})
        Me.AfegirToolStripMenuItem.Name = "AfegirToolStripMenuItem"
        Me.AfegirToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AfegirToolStripMenuItem.Text = "Afegir element..."
        '
        'TextElementToolStripMenuItem
        '
        Me.TextElementToolStripMenuItem.Name = "TextElementToolStripMenuItem"
        Me.TextElementToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.TextElementToolStripMenuItem.Text = "Text"
        '
        'CodiDeBarresToolStripMenuItem1
        '
        Me.CodiDeBarresToolStripMenuItem1.Name = "CodiDeBarresToolStripMenuItem1"
        Me.CodiDeBarresToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.CodiDeBarresToolStripMenuItem1.Text = "Codi de barres"
        '
        'ImatgeBMPToolStripMenuItem1
        '
        Me.ImatgeBMPToolStripMenuItem1.Name = "ImatgeBMPToolStripMenuItem1"
        Me.ImatgeBMPToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.ImatgeBMPToolStripMenuItem1.Text = "Imatge BMP"
        '
        'ImatgePCXToolStripMenuItem1
        '
        Me.ImatgePCXToolStripMenuItem1.Name = "ImatgePCXToolStripMenuItem1"
        Me.ImatgePCXToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.ImatgePCXToolStripMenuItem1.Text = "Imatge PCX"
        '
        'QuadratToolStripMenuItem1
        '
        Me.QuadratToolStripMenuItem1.Name = "QuadratToolStripMenuItem1"
        Me.QuadratToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.QuadratToolStripMenuItem1.Text = "Quadrat"
        '
        'LíniaToolStripMenuItem1
        '
        Me.LíniaToolStripMenuItem1.Name = "LíniaToolStripMenuItem1"
        Me.LíniaToolStripMenuItem1.Size = New System.Drawing.Size(150, 22)
        Me.LíniaToolStripMenuItem1.Text = "Línia"
        '
        'EliminarElementToolStripMenuItem
        '
        Me.EliminarElementToolStripMenuItem.Name = "EliminarElementToolStripMenuItem"
        Me.EliminarElementToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.EliminarElementToolStripMenuItem.Text = "Eliminar element"
        '
        'ImageListElements
        '
        Me.ImageListElements.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageListElements.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListElements.TransparentColor = System.Drawing.Color.Transparent
        '
        'SaveFileElement
        '
        Me.SaveFileElement.FileName = "Etiqueta"
        Me.SaveFileElement.Title = "Guardar etiqueta"
        '
        'sbarImpressoraTXT
        '
        Me.sbarImpressoraTXT.Name = "sbarImpressoraTXT"
        Me.sbarImpressoraTXT.Size = New System.Drawing.Size(127, 17)
        Me.sbarImpressoraTXT.Text = "<<nom_impressora>>"
        '
        'sbarCOMPortLBL
        '
        Me.sbarCOMPortLBL.Name = "sbarCOMPortLBL"
        Me.sbarCOMPortLBL.Size = New System.Drawing.Size(63, 17)
        Me.sbarCOMPortLBL.Text = "Port COM:"
        '
        'sbarCOMPortTXT
        '
        Me.sbarCOMPortTXT.Name = "sbarCOMPortTXT"
        Me.sbarCOMPortTXT.Size = New System.Drawing.Size(121, 17)
        Me.sbarCOMPortTXT.Text = "ToolStripStatusLabel1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 520)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Etiquetes - GUMARCRIS SL"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.treeViewToolStrip.ResumeLayout(False)
        Me.treeViewToolStrip.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.SplitContainer4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.ResumeLayout(False)
        Me.ElementMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents TreeView As TreeView
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents PropertyGrid As PropertyGrid
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents treeViewToolStrip As ToolStrip
    Friend WithEvents tsb_CreaEtiqueta As ToolStripButton
    Friend WithEvents ToolStripSeparador1 As ToolStripSeparator
    Friend WithEvents tsbd_AfegeixElement As ToolStripDropDownButton
    Friend WithEvents TextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CodiDeBarresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImatgeBMPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImatgePCXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuadratToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LíniaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsb_EliminaEtiqueta As ToolStripButton
    Friend WithEvents tsb_EliminarElement As ToolStripButton
    Friend WithEvents tsl_Etiqueta As ToolStripLabel
    Friend WithEvents tsl_Elements As ToolStripLabel
    Friend WithEvents btnPrint As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ElementMenuStrip As ContextMenuStrip
    Friend WithEvents AfegirNouElementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarEtiquetaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfegirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextElementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CodiDeBarresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImatgeBMPToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ImatgePCXToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QuadratToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LíniaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents EliminarElementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageListElements As ImageList
    Friend WithEvents SaveFileElement As SaveFileDialog
    Friend WithEvents StatusBar As StatusStrip
    Friend WithEvents sbarImpressoraLBL As ToolStripStatusLabel
    Friend WithEvents sbarImpressoraTXT As ToolStripStatusLabel
    Friend WithEvents sbarCOMPortLBL As ToolStripStatusLabel
    Friend WithEvents sbarCOMPortTXT As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
End Class
