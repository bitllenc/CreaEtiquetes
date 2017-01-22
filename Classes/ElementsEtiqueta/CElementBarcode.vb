Public Class CElementBarcode
    Inherits TSPLElementEtiqueta

    'Propietats de codis de barres
    Private celNarrowBarRatio As Short
    Private celWideBarRatio As Short
    Private celCodeData As String
    Private celHumanInterpretation As Byte
    Private celErrorCorrection As String
    Private celCodeType As celCodeTypes

    'Call barcode(  
    'celXPos.Printer.ToString, 
    'celYpos.Printer.ToString, 
    'celCodeTypeNames(celCodeType), 
    'celHeight.Printer.ToString, 
    'Val(celHumanInterpretation).ToString, 
    'celRotation.ToString, 
    'celNarrowBarRatio.ToString, 
    'celWideBarRatio.ToString, 
    'celCodeData)

    'BARCODE X, Y, ”code type”, height, human readable, rotation, narrow, wide,“code”
    'Parameter Description
    'X: Specify the x-coordinate Of the bar code On label
    'Y: Specify the y-coordinate Of the bar code On label
    'code type: see table
    'height: bar code height expressed by dot
    'human readable:
    '   0: human Not readable
    '   1: human readable
    'rotation: Rotate bar code clockwise in degrees
    '   0 non rotation
    '   90 rotate 90 degrees clockwise
    '   180 rotate 180 degrees clockwise
    '   270 rotate 270 degrees clockwise
    'narrow width: Of narrow element In dot
    'wide width: Of wide element In dot
    'code: number the maximum number Of digits Of bar code content is on a table in pag 34


    Public Enum celCodeTypes As Byte
        Code_128
        Code_128M
        EAN128
        Code_2of5
        Code_2of5C
        Code_39
        Code_39C
        Code_93
        EAN13
        EAN13p2
        EAN13p5
        EAN8
        EAN8p2
        EAN8p5
        CODA
        POST
        UPCA
        UPCAp2
        UPCAp5
        UPCE
        UPCEp2
        UPCEp5
    End Enum
    Private celCodeTypeNames() As String = New String() {"128", "128M", "EAN128", "25", "25C", "39", "39C", "93", "EAN13",
    "EAN13+2", "EAN13+5", "EAN8", "EAN8+2", "EAN8+5", "CODA", "POST", "UPCA", "UPCA+2", "UPCA+5", "UPCE", "UPCE+2", "UPCE+5"}

    Sub New()
        Me.ElementType = celTypeOfElement.Barcode
        Me.Name = "Barcode"
    End Sub

    Property NarrowBarRatio() As Short
        Get
            Return celNarrowBarRatio
        End Get
        Set(ByVal value As Short)
            celNarrowBarRatio = value
        End Set
    End Property
    Property WideBarRatio() As Short
        Get
            Return celWideBarRatio
        End Get
        Set(ByVal value As Short)
            celWideBarRatio = value
        End Set
    End Property

    Property CodeData() As String
        Get
            Return celCodeData
        End Get
        Set(ByVal value As String)
            celCodeData = value
        End Set
    End Property
    Property HumanInterpretation() As Boolean
        Get
            If celHumanInterpretation = 1 Then
                Return True
            Else
                Return False
            End If
        End Get
        Set(ByVal value As Boolean)
            If value Then
                celHumanInterpretation = 1
            Else
                celHumanInterpretation = 0
            End If
        End Set
    End Property
    Property ErrorCorrection() As String
        Get
            Return celErrorCorrection
        End Get
        Set(ByVal value As String)
            celErrorCorrection = value
        End Set
    End Property
    Property CodeType() As celCodeTypes
        Get
            Return celCodeType
        End Get
        Set(ByVal value As celCodeTypes)
            celCodeType = value
        End Set
    End Property

    ReadOnly Property CodeTypeName() As String
        Get
            Return celCodeTypeNames(celCodeType)
        End Get
        'Set(ByVal value As celCodeTypes)
        '    celCodeType = value
        'End Set
    End Property


End Class
