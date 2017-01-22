Public Class CMida
    Private cmMm As Integer
    Private cmPrinter As Integer
    Private cmLabel As Integer

    Private cmMm2Printer As Integer
    Private cmMm2Label As Integer

    Property mm2PrinterPoints() As Integer
        Get
            Return cmMm2Printer
        End Get
        Set(ByVal value As Integer)
            cmMm2Printer = value
        End Set
    End Property
    Property mm2LabelPoints() As Integer
        Get
            Return cmMm2Label
        End Get
        Set(ByVal value As Integer)
            cmMm2Label = value
        End Set
    End Property
    'Property Size_mm() As Integer
    '    Get
    '        Return cmMm
    '    End Get
    '    Set(ByVal value As Integer)
    '        cmMm = value
    '    End Set
    'End Property

    ReadOnly Property Printer() As Integer
        Get
            Return (cmMm * cmMm2Printer)
        End Get
    End Property
    ReadOnly Property Label() As Integer
        Get
            Return (cmMm * cmMm2Label)
        End Get
    End Property
    Property mm() As Integer
        Get
            Return (cmMm)
        End Get
        Set(ByVal value As Integer)
            cmMm = value
        End Set
    End Property
    Public Sub New()

    End Sub
    Public Sub New(ByVal Size_mm As Integer)
        cmMm = Size_mm
    End Sub
    'Public Sub New(ByVal Size_mm As Integer, ByVal Proportion_mm_points As Short)
    '    cmMm = Size_mm
    '    cmMm2Printer = Proportion_mm_points
    'End Sub
    'Public Sub New(ByVal Size_mm As Integer, ByVal Proportion_mm_label As Short)
    '    cmMm = Size_mm
    '    cmMm2Label = Proportion_mm_label
    'End Sub
End Class
