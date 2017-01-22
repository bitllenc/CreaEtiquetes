Public Class CElementBar
    Inherits TSPLElementEtiqueta

    Sub New()
        Me.ElementType = celTypeOfElement.Line
        Me.Name = "Bar"
    End Sub

    'Syntax
    'BAR x, y, width, height
    'Parameter Description
    'x: The upper left corner x-coordinate In dot
    'y: The upper left corner y-coordinate In dot
    'width: The width Of bar In dot
    'height: The height Of bar In dot

End Class
