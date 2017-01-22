Public Class TSPLImpressora

    Private Declare Sub downloadpcx Lib "tsclib.dll" (ByVal Filename As String, ByVal ImageName As String)
    Private Declare Sub barcode Lib "tsclib.dll" (ByVal X As String, ByVal Y As String, ByVal CodeType As String, ByVal Height_Renamed As String, ByVal Readable As String, ByVal rotation As String, ByVal Narrow As String, ByVal Wide As String, ByVal Code As String)
    Private Declare Sub printerfont Lib "tsclib.dll" (ByVal X As String, ByVal Y As String, ByVal FontName As String, ByVal rotation As String, ByVal Xmul As String, ByVal Ymul As String, ByVal Content As String)
    Private Declare Sub windowsfont Lib "tsclib.dll" (ByVal X As Short, ByVal Y As Short, ByVal fontheight_Renamed As Short, ByVal rotation As Short, ByVal fontstyle As Short, ByVal fontunderline As Short, ByVal FaceName As String, ByVal TextContent As String)

    Private Declare Sub sendcommand Lib "tsclib.dll" (ByVal command_Renamed As String)
    Private Declare Sub openport Lib "tsclib.dll" (ByVal PrinterName As String)
    Private Declare Sub closeport Lib "tsclib.dll" ()
    Private Declare Sub setup Lib "tsclib.dll" (ByVal LabelWidth As String, ByVal LabelHeight As String, ByVal Speed As String, ByVal Density As String, ByVal Sensor As String, ByVal Vertical As String, ByVal Offset As String)
    Private Declare Sub clearbuffer Lib "tsclib.dll" ()
    Private Declare Sub printlabel Lib "tsclib.dll" (ByVal NumberOfSet As String, ByVal NumberOfCopy As String)

    Enum cienPrintingSpeeds As Short
        ' inch_per_sec_1 = 1.0
        ' inch_per_sec_1_5 = 1.5
        ' inch_per_sec_2 = 2.0
        ' inch_per_sec_3 = 3.0
        inch_per_sec_4 = 4
        inch_per_sec_6 = 6
        inch_per_sec_8 = 8
        inch_per_sec_10 = 10
        ' inch_per_sec_12 = 12.0
    End Enum
    Enum cienDPI
        DPI_200
        DPI_300
    End Enum
    Enum cienDirection As Short
        FeedDirection = 0
        ReverseFeedDirection = 1
    End Enum
    Enum cienOnOff
        Enabled
        Disabled
    End Enum

    Private ciNomImpressora As String = "TSC 248M"
    Private ciPort As String = "TSC TTP-248M"
    Private ciDPI As Single = 200
    Private ciPrintSpeed As cienPrintingSpeeds = cienPrintingSpeeds.inch_per_sec_6
    Private ciPointsPerMM As Single = 8
    Private ciDensity As Single = 15 'Value from 0 to 15
    Private ciPrintDirection As cienDirection = cienDirection.ReverseFeedDirection
    Private ciMirror As Single = 0
    Private ciCountry As String = "034"
    Private ciCodepage As String = "SPA"
    Private ciXOffset As Single
    Private ciYoffset As Single
    Private ciLimitFeed As Short = 10   'Posa límit a la llargada de paper si no troba el fina de l'etiqueta
    Private ciCutter As String = "OFF"
    Private ciPeel As String = "OFF"
    Private ciTear As String = "ON"
    Private ciRibbonSensor As String = "ON"


    Property Name() As String
        Get
            Return ciNomImpressora
        End Get
        Set(ByVal Nom_Impressora As String)
            ciNomImpressora = Nom_Impressora
        End Set
    End Property
    Property Port() As String
        Get
            Return ciPort
        End Get
        Set(ByVal value As String)
            ciPort = value
        End Set
    End Property
    Property DPI() As cienDPI
        Get
            Return ciDPI
        End Get
        Set(ByVal value As cienDPI)
            ciDPI = value
            If value = cienDPI.DPI_200 Then
                ciPointsPerMM = 8
            ElseIf value = cienDPI.DPI_300 Then
                ciPointsPerMM = 12
            End If
        End Set
    End Property
    Property PrintSpeed() As cienPrintingSpeeds
        Get
            Return ciPrintSpeed
        End Get
        Set(ByVal value As cienPrintingSpeeds)
            ciPrintSpeed = value
        End Set
    End Property
    ReadOnly Property PointsPerMM() As Short
        Get
            Return ciPointsPerMM
        End Get
    End Property
    Property Density() As Short
        Get
            Return ciDensity
        End Get
        Set(ByVal value As Short)
            If value < 0 Then
                ciDensity = 0
            ElseIf value > 15 Then
                ciDensity = 15
            Else
                ciDensity = value
            End If
        End Set
    End Property
    Property PrintDirection() As cienDirection
        Get
            Return ciPrintDirection
        End Get
        Set(ByVal value As cienDirection)
            ciPrintDirection = value
        End Set
    End Property
    Property Mirror() As Boolean
        Get
            If ciMirror = 0 Then
                Return False
            Else
                Return True
            End If
        End Get
        Set(ByVal value As Boolean)
            If value = False Then
                ciMirror = 0
            Else
                ciMirror = 1
            End If
        End Set
    End Property
    Property Country() As String
        Get
            Return ciCountry
        End Get
        Set(ByVal value As String)
            ciCountry = value
        End Set
    End Property
    Property Codepage() As String
        Get
            Return ciCodepage
        End Get
        Set(ByVal value As String)
            ciCodepage = value
        End Set
    End Property
    Property XOffset() As Single
        Get
            Return ciXOffset
        End Get
        Set(ByVal value As Single)
            ciXOffset = value
        End Set
    End Property

    Property YOffset() As Single
        Get
            Return ciYoffset
        End Get
        Set(ByVal value As Single)
            ciYoffset = value
        End Set
    End Property
    Property LimitFeed() As Short
        Get
            Return ciLimitFeed
        End Get
        Set(ByVal value As Short)
            ciLimitFeed = value
        End Set
    End Property
    Property CutterEnabled() As cienOnOff
        Get
            If ciCutter = "ON" Then
                Return cienOnOff.Enabled
            Else
                Return cienOnOff.Disabled
            End If
        End Get
        Set(ByVal value As cienOnOff)
            If value = cienOnOff.Enabled Then
                ciCutter = "ON"
            Else
                ciCutter = "OFF"
            End If
        End Set
    End Property
    Property PeelEnabled() As cienOnOff
        Get
            If ciPeel = "ON" Then
                Return cienOnOff.Enabled
            Else
                Return cienOnOff.Disabled
            End If
        End Get
        Set(ByVal value As cienOnOff)
            If value = cienOnOff.Enabled Then
                ciPeel = "ON"
            Else
                ciPeel = "OFF"
            End If
        End Set
    End Property
    Property TearEnabled() As cienOnOff
        Get
            If ciTear = "ON" Then
                Return cienOnOff.Enabled
            Else
                Return cienOnOff.Disabled
            End If
        End Get
        Set(ByVal value As cienOnOff)
            If value = cienOnOff.Enabled Then
                ciTear = "ON"
            Else
                ciTear = "OFF"
            End If
        End Set
    End Property
    Property RibbonSensorEnabled() As cienOnOff
        Get
            If ciRibbonSensor = "ON" Then
                Return cienOnOff.Enabled
            Else
                Return cienOnOff.Disabled
            End If
        End Get
        Set(ByVal value As cienOnOff)
            If value = cienOnOff.Enabled Then
                ciRibbonSensor = "ON"
            Else
                ciRibbonSensor = "OFF"
            End If
        End Set
    End Property
    Sub SendPrinterCommand(ByVal Command As String)
        Call openport(ciPort)
        Call sendcommand(Command)
        Call closeport()
    End Sub
    Sub SetupLabel(ByVal Etiqueta As TSPLEtiqueta)
        'Configura la proporció entre mil·límetres i punts d'impressora
        'Etiqueta.SetMm2PrinterPoints(cimm2Points, False)    'Per la configuració de la impressora només fa falta convertir les mides de l'etiqueta

        Call openport(ciPort)
        'Configuració general
        Call setup((Etiqueta.Width).ToString,
                   (Etiqueta.Height).ToString,
                   Val(ciPrintSpeed).ToString,
                   ciDensity.ToString,
                   Val(Etiqueta.HasBlackLine).ToString,
                   (Etiqueta.UpperGap).ToString,
                   (Etiqueta.BlackLineShift).ToString)

        'Hardware de l'impressora
        Call sendcommand("SET CUTTER " & ciCutter)
        Call sendcommand("SET PEEL " & ciPeel)
        Call sendcommand("SET TEAR " & ciTear)
        Call sendcommand("SET RIBBON " & ciRibbonSensor)


        'Altra configuració
        Call sendcommand("DIRECTION " & Val(ciPrintDirection).ToString)     'Mirror no disponible per aquesta impressora
        Dim x_offset As String = (ToPoints(Etiqueta.LeftMargin) + ToPoints(Etiqueta.LeftGap) + ToPoints(XOffset)).ToString
        Dim y_offset As String = (ToPoints(Etiqueta.UpperMargin) + ToPoints(ciYoffset)).ToString
        Call sendcommand("REFERENCE " & (ToPoints(Etiqueta.LeftMargin) + ToPoints(Etiqueta.LeftGap) + ToPoints(XOffset)).ToString & "," & (ToPoints(Etiqueta.UpperMargin) + ToPoints(ciYoffset)).ToString)
        Call sendcommand("LIMITFEED " & ciLimitFeed.ToString)    'Posa límit a la llargada de paper si no troba el fina de l'etiqueta
        Call sendcommand("COUNTRY " & ciCountry)
        Call sendcommand("CODEPAGE " & ciCodepage)



        Call closeport()
    End Sub

    Public Sub PrintLabel(ByRef Etiqueta As TSPLEtiqueta, ByVal NumeroCopies As Short)
        'Configura la proporció entre mil·límetres i punts d'impressora
        'Etiqueta.SetMm2PrinterPoints(cimm2Points, True) 'Per la impressió fa falta convertir les mides de l'etiqueta i la de tots els seus elements

        Call openport(Me.Port)
        Call clearbuffer()  'borra qualsevol element que hi hagi al buffer de la impressora
        Call sendcommand("HOME")
        Call sendcommand("KILL")    'borra tots els elements de la DRAM de la impressora (imatges)

        ProcessaElementsAImprimir(Etiqueta.ContainedElements)

        'S'envia la comanda d'imprimir a la impressora
        printlabel("1", NumeroCopies.ToString)
        sendcommand("FEED 30")
        Call closeport()
    End Sub

    Private Function ToPoints(ByVal val As Single)
        Return val * PointsPerMM
    End Function

    Private Sub ProcessaElementsAImprimir(ByVal Elements As List(Of Object))
        'Segurament caldrà recorrer la llista d'Object de dalt a baix i mirar el valor d'Element.ElementType
        For idx As Integer = 0 To Elements.Count - 1 Step 1

            If Elements.Item(idx).GetType.Equals(GetType(CElementText)) Then
                PrintTextElement(Elements(idx))
                Continue For
            End If


            If Elements.Item(idx).GetType.Equals(GetType(CElementBarcode)) Then
            PrintBarcodeElement(Elements(idx))
                Continue For
            End If

            If Elements.Item(idx).GetType.Equals(GetType(CElementBMP)) Then
                PrintBMPImageElement(Elements(idx))
                Continue For
            End If

            If Elements.Item(idx).GetType.Equals(GetType(CElementPCX)) Then
                PrintPCXImageElement(Elements(idx))
                Continue For
            End If

            If Elements.Item(idx).GetType.Equals(GetType(CElementBox)) Then
                PrintBoxElement(Elements(idx))
                Continue For
            End If

            If Elements.Item(idx).GetType.Equals(GetType(CElementBar)) Then
                PrintBarElement(Elements(idx))
                Continue For
            End If

        Next

        'For Each text As CElementText In Elements

        'Next

        'For Each barcode As CElementBarcode In Elements
        '    PrintBarcodeElement(barcode)
        'Next

        'For Each BMPImage As CElementBMP In Elements
        '    PrintBMPImageElement(BMPImage)
        'Next

        'For Each PCXImage As CElementPCX In Elements
        '    PrintPCXImageElement(PCXImage)
        'Next

        'For Each box As CElementBox In Elements
        '    PrintBoxElement(box)
        'Next

        'For Each bar As CElementBar In Elements
        '    PrintBarElement(bar)
        'Next

        '=== REVERSE ===
        'Case celTypeOfElement.ReverseRegion 'L'element és una regió on es canvia blanc per negre
        'strCommand = "REVERSE " & celXPos.Printer.ToString & ", " & celYpos.Printer.ToString & ", " & celWidth.Printer.ToString & ", " & celHeight.Printer.ToString
        'Call sendcommand(strCommand)
        '=== MATRIX CODE ===
        'Case celTypeOfElement.MatrixCode    'L'element és un codi 2D
        'If StrComp(celCodeType, "QRCODE") Then
        '    'NO DISPONIBLE Call sendcommand("QRCODE ")
        'ElseIf StrComp(celCodeType, "DMATRIX") Then
        '    'NO DISPONIBLE Call sendcommand("DMATRIX ")
        'ElseIf StrComp(celCodeType, "MAXICODE") Then
        '    'NO DISPONIBLE Call sendcommand("MAXICODE ")
        'ElseIf StrComp(celCodeType, "PDF417") Then
        '    'NO DISPONIBLE Call sendcommand("PDF417 ")
        'End If
        ''=== BLANK REGION ===
        'Case celTypeOfElement.BlankRegion   'L'element és un quadrat en blanc
        '            strCommand = "ERASE " & celXPos.Printer.ToString & ", " & celYpos.Printer.ToString & ", " & celWidth.Printer.ToString & ", " & celHeight.Printer.ToString
        '            Call sendcommand(strCommand)

    End Sub

    Private Sub PrintTextElement(ByVal textEl As CElementText)
        Dim X, Y, fontSize, rotation, fontStyle, underline As Short ', txt7, txt8, txt9 As Short
        Dim fontName, text As String

        X = CInt(ToPoints(textEl.XPos))
        Y = CInt(ToPoints(textEl.Ypos))
        fontSize = CInt(textEl.FontSize)
        rotation = CInt(textEl.Rotation)
        fontStyle = CInt(textEl.FontStyle)
        underline = CInt(textEl.FontUnderline)
        fontName = textEl.FontName
        text = textEl.Text

        'Call windowsfont(X, Y, fontSize, rotation, fontStyle, underline, fontName, text)
        Call windowsfont(0, 0, 10, 0, 1, 0, "Arial", "text")
    End Sub
    Private Sub PrintBarcodeElement(ByVal barcodeEl As CElementBarcode)
        Dim X, Y, codeType, height, humanReadable, rotation, narrow, wide, code As String

        X = ToPoints(barcodeEl.XPos).ToString
        Y = ToPoints(barcodeEl.Ypos).ToString
        codeType = barcodeEl.CodeTypeName
        height = ToPoints(barcodeEl.Height).ToString
        humanReadable = Val(barcodeEl.HumanInterpretation).ToString
        rotation = barcodeEl.Rotation.ToString
        narrow = barcodeEl.NarrowBarRatio.ToString
        wide = barcodeEl.WideBarRatio.ToString
        code = barcodeEl.CodeData

        'Call barcode(X, Y, codeType, height, humanReadable, rotation, narrow, wide, code)
        Call barcode("0", "0", "EAN13", "10", "1", "0", "1", "20", "123456789122")

    End Sub
    Private Sub PrintBMPImageElement(ByVal BMPEl As CElementBMP)
        Dim X, Y, filename As String

        X = ToPoints(BMPEl.XPos).ToString
        Y = ToPoints(BMPEl.Ypos).ToString
        filename = Chr(34) & BMPEl.ImageFilename.Split("\")(BMPEl.ImageFilename.Split("\").Length - 1).ToUpper & Chr(34)

        'strCommand = BMPEl.ImageFilename.Split("\")(BMPEl.ImageFilename.Split("\").Length - 1).ToUpper
        'strCommand = celImageFilename.ToUpper      'per si l'anterior no funciona
        'strCommand2 = "PUTBMP " & ToPoints(BMPEl.XPos).ToString & ", " & ToPoints(BMPEl.Ypos).ToString & ", " & Chr(34) & strCommand & Chr(34)
        Call sendcommand("PUTBMP " & X & "," & Y & "," & filename)
    End Sub
    Private Sub PrintPCXImageElement(ByVal PCXEl As CElementPCX)
        Dim X, Y, filename As String

        X = ToPoints(PCXEl.XPos).ToString
        Y = ToPoints(PCXEl.Ypos).ToString
        filename = Chr(34) & PCXEl.ImageFilename.Split("\")(PCXEl.ImageFilename.Split("\").Length - 1).ToUpper & Chr(34)

        'strCommand = PCXEl.ImageFilename.Split("\")(PCXEl.ImageFilename.Split("\").Length - 1).ToUpper
        'strCommand2 = "PUTPCX " & ToPoints(PCXEl.XPos).ToString & ", " & ToPoints(PCXEl.Ypos).ToString & ", " & Chr(34) & strCommand & Chr(34)
        'Call sendcommand(strCommand2)
        Call sendcommand("PUTPCX " & X & "," & Y & "," & filename)
    End Sub
    Private Sub PrintBoxElement(ByVal BOXEl As CElementBox)
        Dim X_start, Y_start, X_end, Y_end, lineThickness As String
        X_start = ToPoints(BOXEl.XPos).ToString
        Y_start = ToPoints(BOXEl.Ypos).ToString
        X_end = (ToPoints(BOXEl.Width) + ToPoints(BOXEl.XPos)).ToString
        Y_end = (ToPoints(BOXEl.Height) + ToPoints(BOXEl.Ypos)).ToString
        lineThickness = ToPoints(BOXEl.LineThickness).ToString


        'strCommand = "BOX " & ToPoints(BOXEl.XPos).ToString & "," & ToPoints(BOXEl.Ypos).ToString & "," & (ToPoints(BOXEl.Width) + ToPoints(BOXEl.XPos)).ToString & "," & (ToPoints(BOXEl.Height) + ToPoints(BOXEl.Ypos)).ToString & "," & ToPoints(BOXEl.LineThickness).ToString
        Call sendcommand("BOX " & X_start & "," & Y_start & "," & X_end & "," & Y_end & "," & lineThickness)
    End Sub
    Private Sub PrintBarElement(ByVal BAREl As CElementBar)
        Dim x, y, width, height As String
        x = ToPoints(BAREl.XPos).ToString
        y = ToPoints(BAREl.Ypos).ToString
        width = ToPoints(BAREl.Width).ToString
        height = ToPoints(BAREl.Height).ToString

        'strCommand = "BAR " & celXPos.Printer.ToString & "," & celYpos.Printer.ToString & "," & celWidth.Printer.ToString & "," & celHeight.Printer.ToString
        Call sendcommand("BAR " & x & "," & y & "," & width & "," & height)
    End Sub

    Public Sub DownloadImage(ByVal imgFilename As String)
        'Descarrega els arxius d'imatges a la impressora
        Call downloadpcx(imgFilename, imgFilename.Split("\")(imgFilename.Split("\").Length - 1).ToUpper)
    End Sub


End Class
