Public Class CElementBMP
    Inherits TSPLElementEtiqueta

    'Propietats d'imatges
    Private celImageFilename As String
    Private celNeedsDownloading As Boolean = False

    Sub New()
        Me.ElementType = celTypeOfElement.BMPImage
        Me.Name = "BMP"
    End Sub

    'Description
    'This command Is used To print BMP format image.
    'Syntax
    'PUTBMP X, Y, ”filename”
    'Parameter Description
    'X The x-coordinate Of the BMP format image
    'Y The y-coordinate Of the BMP format image
    'filename The downloaded BMP filename.

    Property ImageFilename() As String
        Get
            Return celImageFilename
        End Get
        Set(ByVal value As String)
            celImageFilename = value
        End Set
    End Property
    ReadOnly Property NeedsDownloading() As Boolean
        Get
            Return celNeedsDownloading
        End Get
    End Property

End Class
