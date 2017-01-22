Public Class CElementText
    Inherits CreaEtiquetes.TSPLElementEtiqueta

    'Propietats de textos
    Private celFontName As String
    Private celFontStyle As celFontStyles
    Private celFontSize As Single
    Private celFontUnderline As Boolean
    Private celText As String

    Sub New()
        Me.ElementType = celTypeOfElement.Text
        Me.Name = "Text"

    End Sub
    'Private celIsFont As Boolean

    'TEXT X, Y, ”font”, rotation, x-multiplication, y-multiplication, “content”
    'Parameter Description
    'X: The x-coordinate Of the text
    'Y: The y-coordinate Of the text
    'font: Font name
    '   0 Monotye CG Triumvirate Bold Condensed, font width and height Is stretchable
    '   1 8 x 12 fixed pitch dot font
    '   2 12 x 20 fixed pitch dot font
    '   3 16 x 24 fixed pitch dot font
    '   4 24 x 32 fixed pitch dot font
    '   5 32 x 48 dot fixed pitch font
    '   6 14 x 19 dot fixed pitch font OCR-B
    '   7 21 x 27 dot fixed pitch font OCR-B
    '   8 14 x25 dot fixed pitch font OCR-A
    '   ROMAN.TTF Monotye CG Triumvirate Bold Condensed, font width And height proportion Is fixed
    'Rotation: The rotation angle Of text
    '   0 0 degree
    '   90 90 degrees, in clockwise direction
    '   180 180 degrees, in clockwise direction
    '   270 270 degrees, in clockwise direction
    'X-multiplication: Horizontal multiplication, up To 10x.
    '   Available factors :  1~10
    '   For “ROMAN.TTF” true type font, this parameter Is ignored.
    '   For font “0”, this parameter Is used To specify the width (point) of true type font.
    '   1 point=1/72 inch.
    'Y-multiplication: Vertical multiplication, up To 10x.
    '   Available factors :  1~10
    '   TSC Auto ID Technology Co., Ltd. 58 Copyright 2006 All Rights Reserved.
    '   For True type font, this parameter Is used To specify the height(Point) Of True type font.
    '   1 point=1/72 inch.

    Public Enum celFontStyles
        Normal = 0
        Italics = 1
        Bold = 2
        Bold_Italics = 3
    End Enum

    Public Property FontName() As String
        Get
            Return celFontName
        End Get
        Set(ByVal value As String)
            celFontName = value
        End Set
    End Property
    Public Property FontStyle() As celFontStyles
        Get
            Return celFontStyle
        End Get
        Set(ByVal value As celFontStyles)
            celFontStyle = value
        End Set
    End Property
    Public Property FontSize() As Single
        Get
            Return celFontSize
        End Get
        Set(ByVal value As Single)
            celFontSize = value
        End Set
    End Property
    Public Property FontUnderline() As Boolean
        Get
            Return celFontUnderline
        End Get
        Set(ByVal value As Boolean)
            celFontUnderline = value
        End Set
    End Property
    Public Property Text() As String
        Get
            Return celText
        End Get
        Set(ByVal value As String)
            celText = value
        End Set
    End Property



End Class
