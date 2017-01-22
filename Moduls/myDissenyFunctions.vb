Module myDissenyFunctions
    'Public Sub dfAfegeixText(ByVal Text As String, ByVal FontName As String, ByVal FontStyle As TSPLElementEtiqueta.celFontStyles, _
    '                         ByVal Underline As Boolean, ByVal Height As Integer, ByVal Rotation As Short, _
    '                         ByVal XPosition As Integer, ByVal YPosition As Integer, Optional ByVal ToBePrinted As Boolean = True, Optional ByVal ElementName As String = "Text")


    '    Dim NouElementText As New TSPLElementEtiqueta
    '    With NouElementText
    '        .ElementType = TSPLElementEtiqueta.celTypeOfElement.Text
    '        .FontName = FontName
    '        .FontStyle = FontStyle
    '        .FontUnderline = Underline
    '        .Height = New CMida(Height)
    '        .Name = ElementName
    '        .Rotation = Rotation
    '        .Text = Text
    '        .XPos = New CMida(XPosition)
    '        .Ypos = New CMida(YPosition)
    '        .ToBePrinted = ToBePrinted
    '        'Es creen la resta de mides
    '        .Width = New CMida(0)
    '        .NarrowBarRatio = New CMida(0)
    '        .WideBarRatio = New CMida(0)
    '        .LineThickness = New CMida(0)

    '    End With

    '    dfAfegeixElementAActiveLabel(NouElementText)

    'End Sub
    'Public Sub dfAfegeixCodiBarres(ByVal CodeType As TSPLElementEtiqueta.celCodeTypes, ByVal CodeData As String, ByVal HumanInterpretation As Boolean, _
    '                                ByVal NarrowBarRatio As Integer, ByVal WideBarRatio As Integer, ByVal Height As Integer, ByVal Rotation As Short, _
    '                               ByVal XPosition As Integer, ByVal YPosition As Integer, Optional ByVal ToBePrinted As Boolean = True, Optional ByVal ElementName As String = "CodiBarres")
    '    'Call barcode(celXPos.ToString, celYpos.ToString, celCodeType, celHeight.ToString, celHumanInterpretation.ToString, celRotation.ToString, celNarrowBarRatio.ToString, celWideBarRatio.ToString, celCodeData)

    '    Dim NouCodibarres As New TSPLElementEtiqueta
    '    With NouCodibarres
    '        .CodeData = CodeData
    '        .CodeType = CodeType
    '        .ElementType = TSPLElementEtiqueta.celTypeOfElement.Barcode
    '        .Height = New CMida(Height)
    '        .HumanInterpretation = HumanInterpretation
    '        .Name = ElementName
    '        .NarrowBarRatio = New CMida(NarrowBarRatio)
    '        .Rotation = Rotation
    '        .WideBarRatio = New CMida(WideBarRatio)
    '        .XPos = New CMida(XPosition)
    '        .Ypos = New CMida(YPosition)
    '        .ToBePrinted = ToBePrinted

    '        'Es creen la resta de mides
    '        .Width = New CMida(0)
    '        .LineThickness = New CMida(0)
    '    End With

    '    dfAfegeixElementAActiveLabel(NouCodibarres)
    'End Sub

    'Public Sub dfAfegeixLinia(ByRef Height As Integer, ByVal Width As Integer, ByVal XPosition As Integer, ByVal YPosition As Integer, Optional ByVal ToBePrinted As Boolean = True, Optional ByVal ElementName As String = "Linia")
    '    Dim NovaLinia As New TSPLElementEtiqueta
    '    With NovaLinia
    '        .ElementType = TSPLElementEtiqueta.celTypeOfElement.Line
    '        .Height = New CMida(Height)
    '        .Width = New CMida(Width)
    '        .Name = ElementName
    '        .XPos = New CMida(XPosition)
    '        .Ypos = New CMida(YPosition)
    '        .ToBePrinted = ToBePrinted

    '        'Es creen la resta de mides
    '        .NarrowBarRatio = New CMida(0)
    '        .WideBarRatio = New CMida(0)
    '        .LineThickness = New CMida(0)
    '    End With

    '    dfAfegeixElementAActiveLabel(NovaLinia)
    'End Sub

    'Public Sub dfAfegeixImatgeBMP(ByVal FilePath As String, ByVal XPosition As Integer, ByVal YPosition As Integer, Optional ByVal ToBePrinted As Boolean = True, Optional ByVal ElementName As String = "Imatge")
    '    Dim NovaImatge As New TSPLElementEtiqueta
    '    With NovaImatge
    '        .ElementType = TSPLElementEtiqueta.celTypeOfElement.BMPImage
    '        .ImageFilename = FilePath.ToUpper
    '        .Name = ElementName
    '        .XPos = New CMida(XPosition)
    '        .Ypos = New CMida(YPosition)
    '        .ToBePrinted = ToBePrinted

    '        'Es creen la resta de mides
    '        .Height = New CMida(0)
    '        .Width = New CMida(0)
    '        .NarrowBarRatio = New CMida(0)
    '        .WideBarRatio = New CMida(0)
    '        .LineThickness = New CMida(0)
    '    End With
    '    If System.IO.File.Exists(FilePath) Then
    '        dfAfegeixElementAActiveLabel(NovaImatge)
    '    Else
    '        MsgBox("No s'ha trobat l'arxiu de la imatge")
    '    End If
    'End Sub

    'Public Sub dfAfegeixImatgePCX(ByVal FilePath As String, ByVal XPosition As Integer, ByVal YPosition As Integer, Optional ByVal ToBePrinted As Boolean = True, Optional ByVal ElementName As String = "Imatge")
    '    Dim NovaImatge As New TSPLElementEtiqueta
    '    With NovaImatge
    '        .ElementType = TSPLElementEtiqueta.celTypeOfElement.PCXImage
    '        .ImageFilename = FilePath.ToUpper
    '        .Name = ElementName
    '        .XPos = New CMida(XPosition)
    '        .Ypos = New CMida(YPosition)
    '        .ToBePrinted = ToBePrinted

    '        'Es creen la resta de mides
    '        .Height = New CMida(0)
    '        .Width = New CMida(0)
    '        .NarrowBarRatio = New CMida(0)
    '        .WideBarRatio = New CMida(0)
    '        .LineThickness = New CMida(0)
    '    End With
    '    If System.IO.File.Exists(FilePath) Then
    '        dfAfegeixElementAActiveLabel(NovaImatge)
    '    Else
    '        MsgBox("No s'ha trobat l'arxiu de la imatge")
    '    End If
    'End Sub

    Public Sub dfAfegeixElementAActiveLabel(ByVal NouElement As TSPLElementEtiqueta)
        frmPrincipal.ActiveLabel.ContainedElements.Add(NouElement)
    End Sub

    'With NouCodibarres
    '    .CodeData = CodeData
    '    .CodeType = CodeType
    '    .ElementType = TSPLElementEtiqueta.celTypeOfElement.Barcode
    '    .ErrorCorrection = ErrorCorrection
    '    .FontName = "Arial Narrow"
    '    .FontStyle = "NORMAL"
    '    .FontUnderline = False
    '    .Height = Height
    '    .HumanInterpretation = HumanInterpretation
    '    .ImageFilename = "E:\06.Impressora etiquetes\ProjecteVB\Imatges\LOGO_ULR.BMP"
    '    .LineThickness = 2
    '    .Name = ElementName
    '    .NarrowBarRatio = NarrowBarRatio
    '    .Rotation = Rotation
    '    .Text = "PROVA IMATGE"
    '    .WideBarRatio = WideBarRatio
    '    .Width = Width
    '    .XPos = XPosition
    '    .Ypos = YPosition
    '    .ToBePrinted = ToBePrinted
    'End With
End Module