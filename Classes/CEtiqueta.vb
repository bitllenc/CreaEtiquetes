Imports System.Xml.Serialization
<XmlInclude(GetType(CElementText)), XmlInclude(GetType(CElementBarcode)), XmlInclude(GetType(CElementBMP)),
    XmlInclude(GetType(CElementPCX)), XmlInclude(GetType(CElementBox)), XmlInclude(GetType(CElementBar))>
Public Class TSPLEtiqueta

    Private etName As String
    Private etWidth As Single
    Private etHeight As Single
    Private etHasBlackLine As Boolean
    Private etBlackLineShift As Single
    Private etUpperGap As Single
    Private etLeftGap As Single
    Private etLeftMargin As Single
    Private etRightMargin As Single
    Private etUpperMargin As Single
    Private etLowerMargin As Single
    Private etContainedElements As New List(Of Object)
    Private etFilename As String
    Private etDescription As String
    Private etNumberCreatedElements As Integer = 0

    'Private celVisuControl As New Control
    Private etIsSaved As Boolean


    Sub New()

    End Sub

    Sub New(ByVal _name As String)
        Name = _name
    End Sub

    Property Name() As String
        Get
            Return etName
        End Get
        Set(ByVal value As String)
            etName = value
        End Set
    End Property
    Property Width() As Single
        Get
            Return etWidth
        End Get
        Set(ByVal value As Single)
            etWidth = value
        End Set
    End Property
    Property Height() As Single
        Get
            Return etHeight
        End Get
        Set(ByVal value As Single)
            etHeight = value
        End Set
    End Property
    Property HasBlackLine() As Boolean
        Get
            Return etHasBlackLine
        End Get
        Set(ByVal value As Boolean)
            etHasBlackLine = value
        End Set
    End Property
    Property BlackLineShift() As Single
        Get
            Return etBlackLineShift
        End Get
        Set(ByVal value As Single)
            etBlackLineShift = value
        End Set
    End Property
    Property UpperGap() As Single
        Get
            Return etUpperGap
        End Get
        Set(ByVal value As Single)
            etUpperGap = value
        End Set
    End Property
    Property LeftGap() As Single
        Get
            Return etLeftGap
        End Get
        Set(ByVal value As Single)
            etLeftGap = value
        End Set
    End Property
    Property LeftMargin() As Single
        Get
            Return etLeftMargin
        End Get
        Set(ByVal value As Single)
            etLeftMargin = value
        End Set
    End Property
    Property RightMargin() As Single
        Get
            Return etRightMargin
        End Get
        Set(ByVal value As Single)
            etRightMargin = value
        End Set
    End Property
    Property UpperMargin() As Single
        Get
            Return etUpperMargin
        End Get
        Set(ByVal value As Single)
            etUpperMargin = value
        End Set
    End Property
    Property LowerMargin() As Single
        Get
            Return etLowerMargin
        End Get
        Set(ByVal value As Single)
            etLowerMargin = value
        End Set
    End Property
    ReadOnly Property ContainedElements() As List(Of Object)
        Get
            Return etContainedElements
        End Get
    End Property
    Property FileName() As String
        Get
            Return etFilename
        End Get
        Set(ByVal value As String)
            etFilename = value
        End Set
    End Property
    Property Description() As String
        Get
            Return etDescription
        End Get
        Set(ByVal value As String)
            etDescription = value
        End Set
    End Property
    Property IsSaved() As Boolean
        Get
            Return etIsSaved
        End Get
        Set(value As Boolean)
            etIsSaved = value
        End Set
    End Property
    ReadOnly Property NumberCreatedElements() As Integer
        Get
            Return etNumberCreatedElements
        End Get
    End Property

    Public Sub AddElement(obj As Object)
        etContainedElements.Add(obj)
        etNumberCreatedElements = etNumberCreatedElements + 1
    End Sub
    Public Sub RemoveElement(ByVal index As Integer)
        etContainedElements.RemoveAt(index)
    End Sub
    Protected Sub ClearElements()
        etContainedElements.Clear()
    End Sub


    'Public Sub Print()
    '    'S'escriu la comanda Print per cada un dels elements que formen l'etiqueta
    '    For Each Element As TSPLElementEtiqueta In etContainedElements
    '        If Element.ToBePrinted Then
    '            Element.Print()
    '        End If
    '    Next
    'End Sub

    'Public Sub SetMm2PrinterPoints(ByVal Mm2PrinterPoints As Integer, ByVal ToElements As Boolean)
    '    'Configura la proporció entre mil·límetres i punts d'impressora per l'etiqueta

    '    '1. Configura la proporció de cada una de les propietats de la classe CMida d'una etiqueta
    '    etWidth.mm2PrinterPoints = Mm2PrinterPoints
    '    etHeight.mm2PrinterPoints = Mm2PrinterPoints
    '    etUpperGap.mm2PrinterPoints = Mm2PrinterPoints
    '    etLeftGap.mm2PrinterPoints = Mm2PrinterPoints
    '    etLeftMargin.mm2PrinterPoints = Mm2PrinterPoints
    '    etRightMargin.mm2PrinterPoints = Mm2PrinterPoints
    '    'etXOrigin.mm2PrinterPoints = Mm2PrinterPoints
    '    'etYOrigin.mm2PrinterPoints = Mm2PrinterPoints

    '    '2. Pot transmetre aquesta mateixa proporció a cada un dels elements d'una etiqueta
    '    If ToElements Then
    '        For Each Element As TSPLElementEtiqueta In etContainedElements
    '            'Configura la proporció entre mil·límetres i punts d'impressora per cada un dels elements
    '            'de l'etiqueta
    '            Element.SetMm2PrinterPoints(Mm2PrinterPoints)
    '        Next
    '    End If
    'End Sub

    'Public Sub SetMm2LabelPoints(ByVal Mm2LabelPoints As Integer, ByVal ToElements As Boolean)
    '    'Configura la proporció entre mil·límetres i punts de formulari per l'etiqueta

    '    '1. Configura la proporció de cada una de les propietats de la classe CMida d'una etiqueta
    '    etWidth.mm2LabelPoints = Mm2LabelPoints
    '    etHeight.mm2LabelPoints = Mm2LabelPoints
    '    etUpperGap.mm2LabelPoints = Mm2LabelPoints
    '    etLeftGap.mm2LabelPoints = Mm2LabelPoints
    '    etLeftMargin.mm2LabelPoints = Mm2LabelPoints
    '    etRightMargin.mm2LabelPoints = Mm2LabelPoints
    '    'etXOrigin.mm2LabelPoints = Mm2LabelPoints
    '    'etYOrigin.mm2LabelPoints = Mm2LabelPoints

    '    '2. Pot transmetre aquesta mateixa proporció a cada un dels elements d'una etiqueta
    '    If ToElements Then
    '        For Each Element As TSPLElementEtiqueta In etContainedElements
    '            'Configura la proporció entre mil·límetres i punts de formulari per cada un dels elements
    '            'de l'etiqueta
    '            Element.SetMm2LabelPoints(Mm2LabelPoints)
    '        Next
    '    End If
    'End Sub
    '=================================== Funcions de disseny dels elements de l'etiqueta ===========================

    '    Public Sub dfAfegeixText(ByVal Text As String, ByVal FontName As String, ByVal FontStyle As TSPLElementEtiqueta.celFontStyles, _
    '                             ByVal Underline As Boolean, ByVal FontSize As Integer, ByVal Rotation As Short, _
    '                             ByVal XPosition As Integer, ByVal YPosition As Integer, Optional ByVal ToBePrinted As Boolean = True, Optional ByVal ElementName As String = "Text")


    '        Dim NouElementText As New TSPLElementEtiqueta
    '        With NouElementText
    '            .ElementType = TSPLElementEtiqueta.celTypeOfElement.Text
    '            .FontName = FontName
    '            .FontStyle = FontStyle
    '            .FontUnderline = Underline
    '            .Height.mm = 0
    '            .FontSize.mm = FontSize
    '            .Name = ElementName
    '            .Rotation = Rotation
    '            .Text = Text
    '            .XPos.mm = XPosition
    '            .Ypos.mm = YPosition
    '            .ToBePrinted = ToBePrinted
    '        End With

    '        etContainedElements.Add(NouElementText)

    '    End Sub
    '    Public Sub dfAfegeixCodiBarres(ByVal CodeType As TSPLElementEtiqueta.celCodeTypes, ByVal CodeData As String, ByVal HumanInterpretation As Boolean, _
    '                                    ByVal NarrowBarRatio As Integer, ByVal WideBarRatio As Integer, ByVal Height As Integer, ByVal Rotation As Short, _
    '                                   ByVal XPosition As Integer, ByVal YPosition As Integer, Optional ByVal ToBePrinted As Boolean = True, Optional ByVal ElementName As String = "CodiBarres")

    '        Dim NouCodibarres As New TSPLElementEtiqueta
    '        With NouCodibarres
    '            .CodeData = CodeData
    '            .CodeType = CodeType
    '            .ElementType = TSPLElementEtiqueta.celTypeOfElement.Barcode
    '            .Height.mm = Height
    '            .HumanInterpretation = HumanInterpretation
    '            .Name = ElementName
    '            .NarrowBarRatio = NarrowBarRatio
    '            .Rotation = Rotation
    '            .WideBarRatio = WideBarRatio
    '            .XPos.mm = XPosition
    '            .Ypos.mm = YPosition
    '            .ToBePrinted = ToBePrinted
    '        End With

    '        etContainedElements.Add(NouCodibarres)
    '    End Sub

    '    Public Sub dfAfegeixLinia(ByVal Height As Integer, ByVal Width As Integer, ByVal XPosition As Integer, ByVal YPosition As Integer, Optional ByVal ToBePrinted As Boolean = True, Optional ByVal ElementName As String = "Linia")
    '        Dim NovaLinia As New TSPLElementEtiqueta
    '        With NovaLinia
    '            .ElementType = TSPLElementEtiqueta.celTypeOfElement.Line
    '            .Height.mm = Height
    '            .Width.mm = Width
    '            .Name = ElementName
    '            .XPos.mm = XPosition
    '            .Ypos.mm = YPosition
    '            .ToBePrinted = ToBePrinted
    '        End With

    '        etContainedElements.Add(NovaLinia)
    '    End Sub

    '    Public Sub dfAfegeixImatgeBMP(ByVal FilePath As String, ByVal XPosition As Integer, ByVal YPosition As Integer, Optional ByVal ToBePrinted As Boolean = True, Optional ByVal ElementName As String = "Imatge")
    '        Dim NovaImatge As New TSPLElementEtiqueta
    '        With NovaImatge
    '            .ElementType = TSPLElementEtiqueta.celTypeOfElement.BMPImage
    '            .ImageFilename = FilePath.ToUpper
    '            .Name = ElementName
    '            .XPos.mm = XPosition
    '            .Ypos.mm = YPosition
    '            .ToBePrinted = ToBePrinted
    '        End With

    '        If System.IO.File.Exists(FilePath) Then
    '            etContainedElements.Add(NovaImatge)
    '        Else
    '            MsgBox("No s'ha trobat l'arxiu de la imatge")
    '        End If
    '    End Sub

    '    Public Sub dfAfegeixImatgePCX(ByVal FilePath As String, ByVal XPosition As Integer, ByVal YPosition As Integer, Optional ByVal ToBePrinted As Boolean = True, Optional ByVal ElementName As String = "Imatge")
    '        Dim NovaImatge As New TSPLElementEtiqueta
    '        With NovaImatge
    '            .ElementType = TSPLElementEtiqueta.celTypeOfElement.PCXImage
    '            .ImageFilename = FilePath.ToUpper
    '            .Name = ElementName
    '            .XPos.mm = XPosition
    '            .Ypos.mm = YPosition
    '            .ToBePrinted = ToBePrinted

    '        End With
    '        If System.IO.File.Exists(FilePath) Then
    '            etContainedElements.Add(NovaImatge)
    '        Else
    '            MsgBox("No s'ha trobat l'arxiu de la imatge")
    '        End If
    '    End Sub

End Class
