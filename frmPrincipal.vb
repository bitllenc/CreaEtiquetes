Imports System.Xml.Serialization

Public Class frmPrincipal
    Dim LstEtiquetes As New List(Of TSPLEtiqueta)

    Dim impressora As New TSPLImpressora

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            inicialitzaImpressora(impressora)

            TextToolStripMenuItem.Tag = CType(TSPLElementEtiqueta.celTypeOfElement.Text, Object)
            'TextElementToolStripMenuItem = TextToolStripMenuItem


            sbarImpressoraTXT.Text = impressora.Name
            sbarCOMPortTXT.Text = impressora.Port

            'Using myGraphics As Graphics = Me.CreateGraphics()
            '    MessageBox.Show(String.Format("Resolution X: {0} dpi, Resolution Y: {1} dpi", myGraphics.DpiX, myGraphics.DpiY),
            '                    "Windows Resolution")
            'End Using
        Catch exc As Exception
            MsgBox("Ha saltat una excepció a Form Load: " + exc.Message, MsgBoxStyle.Critical, "EXCEPCIÓ!!!")
        End Try


    End Sub

    Private Sub tsb_CreaEtiqueta_Click(sender As Object, e As EventArgs) Handles tsb_CreaEtiqueta.Click, AfegirNouElementToolStripMenuItem.Click

        AddNewLabel(LstEtiquetes)

        UpdateTreeView(LstEtiquetes)
    End Sub

    Private Sub UpdatePropertyGrid(ByRef _LstEtiquetes As List(Of TSPLEtiqueta))
        Dim currentNode = TreeView.SelectedNode

        If isLabel(currentNode) Then
            PropertyGrid.SelectedObject = _LstEtiquetes(currentNode.Index)
        ElseIf isElement(currentNode)
            PropertyGrid.SelectedObject = _LstEtiquetes(currentNode.Parent.Index).ContainedElements(currentNode.Index)
        End If

    End Sub

    Private Function getNodeIndex(ByVal _treeNode As TreeNode) As Integer
        If Not IsNothing(_treeNode) Then
            Return _treeNode.Index
        End If
        Return -1
    End Function
    Private Function getLabelNodeIndex(ByVal _treeNode As TreeNode) As Integer
        If Not IsNothing(_treeNode) Then
            Dim parentNode As TreeNode = _treeNode

            For idxLevel As Integer = _treeNode.Level To 1 Step -1
                parentNode = _treeNode.Parent
            Next idxLevel

            Return parentNode.Index
        End If
        Return -1
    End Function

    Private Function isLabel(ByVal _node As TreeNode)
        If Not IsNothing(_node) Then
            If (_node.Level = 0) Then
                Return True
            End If
        End If
        Return False
    End Function
    Private Function isElement(ByVal _node As TreeNode)
        If Not IsNothing(_node) Then
            If (_node.Level = 1) Then
                Return True
            End If
        End If
        Return False
    End Function


    Private Sub UpdateTreeView(ByRef _LstEtiquetes As List(Of TSPLEtiqueta))
        Dim expandedNodes(49) As Boolean
        Dim idx As Integer = 0
        Dim idxSelectedNode As Integer = getLabelNodeIndex(TreeView.SelectedNode)

        If idxSelectedNode < 0 Then
            idxSelectedNode = 0
        End If

        For Each node As TreeNode In TreeView.Nodes
            expandedNodes(idx) = node.IsExpanded
            idx = idx + 1
        Next

        TreeView.BeginUpdate()

        TreeView.Nodes.Clear()
        Dim i As Int16 = 0
        Dim j As Int16 = 0
        For Each etiqueta As TSPLEtiqueta In _LstEtiquetes
            Dim NewNode As New TreeNode

            NewNode.Text = etiqueta.Name
            NewNode.ContextMenuStrip = ElementMenuStrip

            If Not IsNothing(etiqueta.FileName) Then
                NewNode.Text = NewNode.Text + (" - (" + etiqueta.FileName.Split("\").Last + ")")
                NewNode.ToolTipText = etiqueta.FileName
            End If

            If Not etiqueta.IsSaved Then
                NewNode.Text = NewNode.Text + "*"
            End If

            TreeView.Nodes.Add(NewNode)

            j = 0
            For Each element As Object In etiqueta.ContainedElements
                Dim newENode As New TreeNode

                newENode.Text = element.Name


                If Not element.tobeprinted Then
                    newENode.ForeColor = Color.DarkGray
                End If

                TreeView.Nodes.Item(i).Nodes.Add(newENode)
                j = j + 1
            Next
            i = i + 1
        Next
        TreeView.EndUpdate()

        If Not IsNothing(expandedNodes) Then
            For Each node As TreeNode In TreeView.Nodes
                If expandedNodes(node.Index) Then
                    node.Expand()
                End If
            Next
        End If

        TreeView.SelectedNode = TreeView.Nodes.Item(idxSelectedNode)

    End Sub

    Private Sub tsb_EliminaEtiqueta_Click(sender As Object, e As EventArgs) Handles tsb_EliminaEtiqueta.Click, EliminarEtiquetaToolStripMenuItem.Click
        If isLabel(TreeView.SelectedNode) Then
            RemoveLabel(LstEtiquetes, getLabelNodeIndex(TreeView.SelectedNode))
        End If

        UpdateTreeView(LstEtiquetes)
    End Sub

    Private Sub tsb_EliminarElement_Click(sender As Object, e As EventArgs) Handles tsb_EliminarElement.Click, EliminarElementToolStripMenuItem.Click

        If isElement(TreeView.SelectedNode) Then
            RemoveElementFromLabel(LstEtiquetes, getLabelNodeIndex(TreeView.SelectedNode), getNodeIndex(TreeView.SelectedNode))
        End If

        UpdateTreeView(LstEtiquetes)
    End Sub

    Private Sub TreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView.AfterSelect
        UpdatePropertyGrid(LstEtiquetes)

    End Sub

    'Private Sub afegeixElement(sender As Object, e As EventArgs)
    '    AddElementToLabel(LstEtiquetes, getLabelNodeIndex(TreeView.SelectedNode), CType(sender.tag, TSPLElementEtiqueta).ElementType)
    '    UpdateTreeView(LstEtiquetes)
    'End Sub
    Private Sub TextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextToolStripMenuItem.Click, TextElementToolStripMenuItem.Click
        AddElementToLabel(LstEtiquetes, getLabelNodeIndex(TreeView.SelectedNode), TSPLElementEtiqueta.celTypeOfElement.Text)

        UpdateTreeView(LstEtiquetes)
    End Sub

    Private Sub CodiDeBarresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodiDeBarresToolStripMenuItem.Click, CodiDeBarresToolStripMenuItem1.Click
        AddElementToLabel(LstEtiquetes, getLabelNodeIndex(TreeView.SelectedNode), TSPLElementEtiqueta.celTypeOfElement.Barcode)

        UpdateTreeView(LstEtiquetes)
    End Sub

    Private Sub ImatgeBMPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImatgeBMPToolStripMenuItem.Click, ImatgeBMPToolStripMenuItem1.Click
        AddElementToLabel(LstEtiquetes, getLabelNodeIndex(TreeView.SelectedNode), TSPLElementEtiqueta.celTypeOfElement.BMPImage)

        UpdateTreeView(LstEtiquetes)
    End Sub

    Private Sub ImatgePCXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImatgePCXToolStripMenuItem.Click, ImatgePCXToolStripMenuItem1.Click
        AddElementToLabel(LstEtiquetes, getLabelNodeIndex(TreeView.SelectedNode), TSPLElementEtiqueta.celTypeOfElement.PCXImage)

        UpdateTreeView(LstEtiquetes)
    End Sub

    Private Sub QuadratToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuadratToolStripMenuItem.Click, QuadratToolStripMenuItem1.Click

        AddElementToLabel(LstEtiquetes, getLabelNodeIndex(TreeView.SelectedNode), TSPLElementEtiqueta.celTypeOfElement.Box)

        UpdateTreeView(LstEtiquetes)
    End Sub

    Private Sub LíniaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LíniaToolStripMenuItem.Click, LíniaToolStripMenuItem1.Click

        AddElementToLabel(LstEtiquetes, getLabelNodeIndex(TreeView.SelectedNode), TSPLElementEtiqueta.celTypeOfElement.Line)

        UpdateTreeView(LstEtiquetes)
    End Sub



    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim selectedNode As TreeNode = TreeView.SelectedNode
        Dim etiqueta As New TSPLEtiqueta("printable")
        Dim msgInfo As String


        If Not IsNothing(selectedNode) Then

            etiqueta = LstEtiquetes.Item(getLabelNodeIndex(selectedNode))
            msgInfo = "Imprimiràs l'etiqueta '" + etiqueta.Name + "'"

            If MsgBoxResult.Ok = MsgBox(msgInfo, MsgBoxStyle.OkCancel, "Confirmació d'impressió") Then
                'Imprimir
                impressora.PrintLabel(etiqueta, 1)
            End If

        Else

            MsgBox("Not has seleccionat cap etiqueta", MsgBoxStyle.OkCancel, "Confirmació d'impressió")
        End If

    End Sub

    Private Sub inicialitzaImpressora(ByRef impressora As TSPLImpressora)
        With impressora


        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim labelIndex As Integer = getLabelNodeIndex(TreeView.SelectedNode)
        Dim res As New DialogResult

        If IsNothing(LstEtiquetes(labelIndex).FileName) Then

            SaveFileElement.AddExtension = True
            SaveFileElement.Filter = "Arxius etiquetes|*.xml"
            res = SaveFileElement.ShowDialog()

            If res = DialogResult.OK Then
                GuardaEtiqueta(LstEtiquetes(labelIndex), SaveFileElement.FileName)
                LstEtiquetes(labelIndex).FileName = SaveFileElement.FileName
                LstEtiquetes(labelIndex).IsSaved = True
            End If

        Else
            GuardaEtiqueta(LstEtiquetes(labelIndex), LstEtiquetes(labelIndex).FileName)
            LstEtiquetes(labelIndex).IsSaved = True
        End If

        UpdateTreeView(LstEtiquetes)

    End Sub

    Private Sub PropertyGrid_PropertyValueChanged(s As Object, e As PropertyValueChangedEventArgs) Handles PropertyGrid.PropertyValueChanged
        UpdateTreeView(LstEtiquetes)
    End Sub

End Class