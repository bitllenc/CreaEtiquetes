Public Class CElementPCX
    Inherits TSPLElementEtiqueta

    'Propietats d'imatges
    Private celImageFilename As String
    Private celNeedsDownloading As Boolean = False

    Sub New()
        Me.ElementType = celTypeOfElement.PCXImage
        Me.Name = "PCX"
    End Sub


    'Syntax
    'PUTPCX X, Y, ”filename”
    'Parameter Description
    'X The x-coordinate Of the PCX image
    'Y The y-coordinate Of the PCX image
    'filename The downloaded PCX filename. Case sensitive

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
