Public Class CElementBox
    Inherits TSPLElementEtiqueta

    'Propietats de box
    Private celLineThickness As Single       'En mm

    Sub New()
        Me.ElementType = celTypeOfElement.Box
        Me.Name = "Box"
        'Me.celVisuControl = Form.Controls.
    End Sub

    'Syntax
    'BOX X_start, Y_start, X_end, Y_end, line thickness
    'Parameter Description
    'X_start: Specify x-coordinate Of upper left corner In dot
    'Y_start: Specify y-coordinate Of upper left corner In dot
    'X_end: Specify x-coordinate Of lower right corner In dot -> X+width
    'Y_end: Specify y-coordinate Of lower right corner In dot -> Y+heigth
    'line thickness: Line thickness Of the box In dot

    Property LineThickness() As Single
        Get
            Return celLineThickness
        End Get
        Set(ByVal value As Single)
            celLineThickness = value
        End Set
    End Property

End Class
