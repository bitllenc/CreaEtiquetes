Public Class NumberEntryUC
    Dim _Unit As String
    Dim _Value As Short
    Dim _ID As String

    Property Unit() As String
        Get
            Return _Unit
        End Get
        Set(ByVal value As String)
            _Unit = value
            lbl_Unit.Text = _Unit
        End Set
    End Property

    Property _IDTag() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
            lbl_ID.Text = _ID
        End Set
    End Property

    Property Value() As Short
        Get
            Return _Value
        End Get
        Set(ByVal value As Short)
            _Value = value
            txt_Val.Text = CStr(value)
        End Set
    End Property

    Private Sub txt_Val_Enter(sender As Object, e As EventArgs) Handles txt_Val.Enter
        ToValue(CType(sender, TextBox).Text)
    End Sub
    Private Sub txt_Val_LostFocus(sender As Object, e As EventArgs) Handles txt_Val.LostFocus
        ToValue(CType(sender, TextBox).Text)
    End Sub
    Private Sub txt_Val_TextChanged(sender As Object, e As EventArgs) Handles txt_Val.TextChanged
        ToValue(CType(sender, TextBox).Text)
    End Sub


    Private Sub ToValue(v As String)
        If IsNumeric(v) Then
            Value = CShort(Val(v))
        Else
            MsgBox("Introdueix un nombre enter", MsgBoxStyle.Exclamation, "Error en el nombre")
        End If
    End Sub


End Class
