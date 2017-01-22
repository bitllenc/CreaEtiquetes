Public Class TSPLElementEtiqueta

    'Private Declare Sub sendcommand Lib "tsclib.dll" (ByVal command_Renamed As String)
    'Private Declare Sub downloadpcx Lib "tsclib.dll" (ByVal Filename As String, ByVal ImageName As String)
    'Private Declare Sub barcode Lib "tsclib.dll" (ByVal X As String, ByVal Y As String, ByVal CodeType As String, ByVal Height_Renamed As String, ByVal Readable As String, ByVal rotation As String, ByVal Narrow As String, ByVal Wide As String, ByVal Code As String)
    'Private Declare Sub printerfont Lib "tsclib.dll" (ByVal X As String, ByVal Y As String, ByVal FontName As String, ByVal rotation As String, ByVal Xmul As String, ByVal Ymul As String, ByVal Content As String)
    'Private Declare Sub windowsfont Lib "tsclib.dll" (ByVal X As Short, ByVal Y As Short, ByVal fontheight_Renamed As Short, ByVal rotation As Short, ByVal fontstyle As Short, ByVal fontunderline As Short, ByVal FaceName As String, ByVal TextContent As String)

    'Declaració de tipus
    Public Enum celTypeOfElement
        Text
        PCXImage
        BMPImage
        Barcode
        Line
        Box
        BlankRegion
        ReverseRegion
        MatrixCode
    End Enum



    'Propietats comunes
    Private celName As String 'Nom de l'element que s'afegeix a l'etiqueta
    Private celXPos As Single    'En mm
    Private celYpos As Single    'En mm
    Private celHeight As Single  'En mm
    Private celWidth As Single   'En mm
    Private celRotation As Short
    Private celElementType As celTypeOfElement

    'Propietats d'estat
    Private celToBePrinted As Boolean = True
    'Private celIsPrinted As Boolean = False

    'Visualització a la pantalla
    'Friend celVisual As New Windows.Forms.Label


    Property Name() As String
        Get
            Return celName
        End Get
        Set(ByVal value As String)
            celName = value
        End Set
    End Property
    Property XPos() As Single
        Get
            Return celXPos
        End Get
        Set(ByVal value As Single)
            celXPos = value
        End Set
    End Property
    Property Ypos() As Single
        Get
            Return celYpos
        End Get
        Set(ByVal value As Single)
            celYpos = value
        End Set
    End Property
    Property Height() As Single
        Get
            Return celHeight
        End Get
        Set(ByVal value As Single)
            celHeight = value
        End Set
    End Property
    Property Width() As Single
        Get
            Return celWidth
        End Get
        Set(ByVal value As Single)
            celWidth = value
        End Set
    End Property

    Property Rotation() As Short
        Get
            Return celRotation
        End Get
        Set(ByVal value As Short)
            celRotation = value
        End Set
    End Property

    Protected Friend Property ElementType() As celTypeOfElement
        Get
            Return celElementType
        End Get
        Set(ByVal value As celTypeOfElement)
            celElementType = value
        End Set
    End Property

    Property ToBePrinted() As Boolean
        Get
            Return celToBePrinted
        End Get
        Set(ByVal value As Boolean)
            celToBePrinted = value
        End Set
    End Property

    'ReadOnly Property IsPrinted() As Boolean
    '    Get
    '        Return celIsPrinted
    '    End Get
    'End Property
    'Public Sub SetMm2PrinterPoints(ByVal Mm2PrinterPoints As Integer)
    '    'Configura la proporció entre mil·límetres i punts d'impressora

    '    '1. Configura la proporció de cada una de les propietats de la classe CMida d'una element d'etiqueta
    '    celXPos.mm2PrinterPoints = Mm2PrinterPoints
    '    celYpos.mm2PrinterPoints = Mm2PrinterPoints
    '    celHeight.mm2PrinterPoints = Mm2PrinterPoints
    '    celWidth.mm2PrinterPoints = Mm2PrinterPoints
    '    celFontSize.mm2PrinterPoints = 1    'Cas especial per les lletres, s'introdueixen les mides en punts
    '    'celNarrowBarRatio.mm2PrinterPoints = Mm2PrinterPoints
    '    'celWideBarRatio.mm2PrinterPoints = Mm2PrinterPoints
    '    celLineThickness.mm2PrinterPoints = Mm2PrinterPoints
    'End Sub
    'Public Sub SetMm2LabelPoints(ByVal Mm2LabelPoints As Integer)
    '    'Configura la proporció entre mil·límetres i punts de formulari

    '    '1. Configura la proporció de cada una de les propietats de la classe CMida d'una element d'etiqueta
    '    celXPos.mm2LabelPoints = Mm2LabelPoints
    '    celYpos.mm2LabelPoints = Mm2LabelPoints
    '    celHeight.mm2LabelPoints = Mm2LabelPoints
    '    celWidth.mm2LabelPoints = Mm2LabelPoints
    '    celFontSize.mm2LabelPoints = Mm2LabelPoints    'Cas especial per les lletres, s'introdueixen les mides en punts
    '    'celNarrowBarRatio.mm2LabelPoints = Mm2LabelPoints
    '    'celWideBarRatio.mm2LabelPoints = Mm2LabelPoints
    '    celLineThickness.mm2LabelPoints = Mm2LabelPoints

    '    'L'ideal seria //problema: no és una col·lecció d'aributs CMida
    '    'For Each atribut as Cmida in Me (=Classe ElementEtiqueta)
    '    '.Mm2LabelPoints = Mm2LabelPoints
    '    'Next

    'End Sub

    'Public Sub Download()
    '    'Descarrega els arxius d'imatges a la impressora
    '    Dim strCommand As String
    '    strCommand = celImageFilename.Split("\")(celImageFilename.Split("\").Length - 1).ToUpper
    '    Call downloadpcx(celImageFilename, strCommand)
    'End Sub

    'Public Sub Print()
    '    Dim strCommand, strCommand2 As String

    '    'Descarrega les imatges que faci falta a la impressora
    '    If celNeedsDownloading Then
    '        Download()
    '    End If

    '    'Genera i envia la comanda d'imprimir a la impressora
    '    Select Case celElementType
    '        '=== BARCODE ===
    '        Case celTypeOfElement.Barcode       'L'element és un codi de barres
    '            Call barcode(celXPos.Printer.ToString, celYpos.Printer.ToString, celCodeTypeNames(celCodeType), celHeight.Printer.ToString, Val(celHumanInterpretation).ToString, celRotation.ToString, celNarrowBarRatio.ToString, celWideBarRatio.ToString, celCodeData)
    '            '=== BLANK REGION ===
    '        Case celTypeOfElement.BlankRegion   'L'element és un quadrat en blanc
    '            strCommand = "ERASE " & celXPos.Printer.ToString & ", " & celYpos.Printer.ToString & ", " & celWidth.Printer.ToString & ", " & celHeight.Printer.ToString
    '            Call sendcommand(strCommand)
    '            '=== BMPIMAGE ===
    '        Case celTypeOfElement.BMPImage      'L'element és una imatge BMP
    '            strCommand = celImageFilename.Split("\")(celImageFilename.Split("\").Length - 1).ToUpper
    '            'strCommand = celImageFilename.ToUpper      'per si l'anterior no funciona
    '            strCommand2 = "PUTBMP " & celXPos.Printer.ToString & ", " & celYpos.Printer.ToString & ", " & Chr(34) & strCommand & Chr(34)
    '            Call sendcommand(strCommand2)
    '            '=== BOX ===
    '        Case celTypeOfElement.Box           'L'element és una caixa o marc
    '            strCommand = "BOX " & celXPos.Printer.ToString & "," & celYpos.Printer.ToString & "," & (celWidth.Printer + celXPos.Printer).ToString & "," & (celHeight.Printer + celYpos.Printer).ToString & "," & celLineThickness.Printer.ToString
    '            Call sendcommand(strCommand)
    '            '=== LINE ===
    '        Case celTypeOfElement.Line          'L'element és una línia
    '            strCommand = "BAR " & celXPos.Printer.ToString & "," & celYpos.Printer.ToString & "," & celWidth.Printer.ToString & "," & celHeight.Printer.ToString
    '            Call sendcommand(strCommand)
    '            '=== MATRIX CODE ===
    '        Case celTypeOfElement.MatrixCode    'L'element és un codi 2D
    '            If StrComp(celCodeType, "QRCODE") Then
    '                'NO DISPONIBLE Call sendcommand("QRCODE ")
    '            ElseIf StrComp(celCodeType, "DMATRIX") Then
    '                'NO DISPONIBLE Call sendcommand("DMATRIX ")
    '            ElseIf StrComp(celCodeType, "MAXICODE") Then
    '                'NO DISPONIBLE Call sendcommand("MAXICODE ")
    '            ElseIf StrComp(celCodeType, "PDF417") Then
    '                'NO DISPONIBLE Call sendcommand("PDF417 ")
    '            End If
    '            '=== PCX IMAGE ===
    '        Case celTypeOfElement.PCXImage      'L'element és una imatge PCX
    '            strCommand = celImageFilename.Split("\")(celImageFilename.Split("\").Length - 1).ToUpper
    '            strCommand2 = "PUTPCX " & celXPos.Printer.ToString & ", " & celYpos.Printer.ToString & ", " & Chr(34) & strCommand & Chr(34)
    '            Call sendcommand(strCommand2)
    '            '=== REVERSE ===
    '        Case celTypeOfElement.ReverseRegion 'L'element és una regió on es canvia blanc per negre
    '            strCommand = "REVERSE " & celXPos.Printer.ToString & ", " & celYpos.Printer.ToString & ", " & celWidth.Printer.ToString & ", " & celHeight.Printer.ToString
    '            Call sendcommand(strCommand)
    '            '=== TEXT ===
    '        Case celTypeOfElement.Text          'L'element és un text
    '            Dim txt1, txt2, txt3, txt4, txt5, txt6 As Short ', txt7, txt8, txt9 As Short
    '            txt1 = celXPos.Printer
    '            txt2 = celYpos.Printer
    '            txt3 = celFontSize.mm
    '            txt4 = CInt(celRotation)
    '            txt5 = CInt(celFontStyle)
    '            txt6 = CInt(celFontUnderline)
    '            Dim str1, str2 As String
    '            str1 = celFontName
    '            str2 = celText
    '            'txt9 = celCodeData
    '            Call windowsfont(txt1, txt2, txt3, txt4, txt5, txt6, str1, str2) '
    '            '                Call windowsfont(celXPos.Printer, celYpos.Printer, celFontSize.mm, CInt(celRotation), CInt(celFontStyle), CInt(celFontUnderline), celFontName, celText)
    '    End Select

    '    celIsPrinted = True
    'End Sub


End Class
