Module accionsEtiquetes
    Private labelsCreatedEver As Integer = 0

    Public Sub AddNewLabel(ByRef lblList As List(Of TSPLEtiqueta))

        lblList.Add(New TSPLEtiqueta("NewLabel" + labelsCreatedEver.ToString))
        labelsCreatedEver = labelsCreatedEver + 1

    End Sub

    Public Sub RemoveLabel(ByRef lblList As List(Of TSPLEtiqueta), ByVal index As Integer)

        lblList.RemoveAt(index)

    End Sub

    Public Sub AddElementToLabel(ByRef lblList As List(Of TSPLEtiqueta), ByVal labelIndex As Integer, ByVal elementType As TSPLElementEtiqueta.celTypeOfElement)

        If elementType = TSPLElementEtiqueta.celTypeOfElement.Barcode Then
            lblList(labelIndex).AddElement(New CElementBarcode)
        ElseIf elementType = TSPLElementEtiqueta.celTypeOfElement.BlankRegion Then
        ElseIf elementType = TSPLElementEtiqueta.celTypeOfElement.BMPImage Then
            lblList(labelIndex).AddElement(New CElementBMP)
        ElseIf elementType = TSPLElementEtiqueta.celTypeOfElement.Box Then
            lblList(labelIndex).AddElement(New CElementBox)
        ElseIf elementType = TSPLElementEtiqueta.celTypeOfElement.Line Then
            lblList(labelIndex).AddElement(New CElementBar)
        ElseIf elementType = TSPLElementEtiqueta.celTypeOfElement.MatrixCode Then
        ElseIf elementType = TSPLElementEtiqueta.celTypeOfElement.PCXImage Then
            lblList(labelIndex).AddElement(New CElementPCX)
        ElseIf elementType = TSPLElementEtiqueta.celTypeOfElement.ReverseRegion Then
        ElseIf elementType = TSPLElementEtiqueta.celTypeOfElement.Text Then
            lblList(labelIndex).AddElement(New CElementText)
        End If

        lblList(labelIndex).IsSaved = False

    End Sub

    Public Sub RemoveElementFromLabel(ByRef lblList As List(Of TSPLEtiqueta), ByVal labelIndex As Integer, ByVal elementIndex As Integer)

        lblList(labelIndex).RemoveElement(elementIndex)
        lblList(labelIndex).IsSaved = False
    End Sub
End Module
