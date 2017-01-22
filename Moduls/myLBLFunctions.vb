'============================================== myLBLFunctions.vb ===========================================
'==  En tot el programa només hi ha una etiqueta que es visualitza (Display), per això totes les funcions de 
'==  myLBLFunctions fan referència a la variable de frmPrincipal: ActiveLabelDisplay i actuen directament
'==  sobre ella
'============================================== myLBLFunctions.vb ===========================================

Module myLBLFunctions
    Private Const lblXmargin As Integer = 20
    Private Const lblYmargin As Integer = 30
    Private Const lblmm2LabelPoints As Integer = 3 'Aquest valor (lblmm2LabelPoints) pot anar canviant segons la mida del formulari
    Private Const LBLFONTSCALE As Decimal = 0.075


    Sub lblfMostraEtiquetaBlanca(ByVal etiqueta As TSPLEtiqueta)
        Dim EtiquetaBlanca As New Label

        'etiqueta.SetMm2LabelPoints(lblmm2LabelPoints, False) 'Configura la proporció entre els mm i els punts del formulari
        'Aquest valor (lblmm2LabelPoints) pot anar canviant segons la mida del formulari

        EtiquetaBlanca.Parent = frmPrincipal.gbVistaPrevia 'shpContenidor
        EtiquetaBlanca.AutoSize = False
        EtiquetaBlanca.Anchor = AnchorStyles.Top And AnchorStyles.Left
        EtiquetaBlanca.Location = New System.Drawing.Size(New System.Drawing.Point( _
                                        lblXmargin, lblYmargin))
        'EtiquetaBlanca.Top = lblYmargin

        EtiquetaBlanca.Width = etiqueta.Width.Label
        EtiquetaBlanca.Height = etiqueta.Height.Label
        EtiquetaBlanca.BorderStyle = BorderStyle.FixedSingle
        EtiquetaBlanca.BackColor = Color.White
        EtiquetaBlanca.ForeColor = Color.Black
        EtiquetaBlanca.Visible = True

        EtiquetaBlanca.Show()
    End Sub

    Private Sub lblfAfegeixElementADisplay(ByVal Etiqueta As TSPLEtiqueta, ByVal Index As Short)
        Dim NouLabel As New Label

        Etiqueta.SetMm2LabelPoints(lblmm2LabelPoints, True) 'Configura la proporció entre els mm i els punts del formulari
        'Aquest valor pot anar canviant segons la mida del formulari

        NouLabel.Parent = frmPrincipal.gbVistaPrevia
        NouLabel.Left = Etiqueta.ContainedElements(Index).XPos.Label + lblXmargin
        NouLabel.Top = Etiqueta.ContainedElements(Index).Ypos.Label + lblYmargin
        NouLabel.BringToFront()
        NouLabel.Visible = Etiqueta.ContainedElements(Index).ToBePrinted 'si no s'ha d'imprimir, es posa no visible
        AddHandler NouLabel.Click, AddressOf lblfSeleccionaLabel    'se li assigna la funció lblSeleccionaLabel en l'event click

        Select Case Etiqueta.ContainedElements(Index).ElementType
            Case TSPLElementEtiqueta.celTypeOfElement.Text
                NouLabel.AutoSize = True
                'NouLabel.ForeColor = 
                NouLabel.BackColor = Color.White
                NouLabel.Text = Etiqueta.ContainedElements(Index).Text
                Dim calcFontSize As Integer = CInt(CDec(Etiqueta.ContainedElements(Index).FontSize.Label) * LBLFONTSCALE)
                NouLabel.Font = New System.Drawing.Font(Etiqueta.ContainedElements(Index).FontName, calcFontSize, lblfGetElementFontStyle(Etiqueta.ContainedElements(Index)))
            Case TSPLElementEtiqueta.celTypeOfElement.Barcode
                NouLabel.BackColor = Color.Gray
                NouLabel.AutoSize = False
                'NouLabel.Width = lblfmm2label(Etiqueta.ContainedElements(Index).Width)
                If Etiqueta.ContainedElements(Index).HumanInterpretation Then
                    NouLabel.Height = Etiqueta.ContainedElements(Index).Height.Label + 5 * lblmm2LabelPoints
                Else
                    NouLabel.Height = Etiqueta.ContainedElements(Index).Height.Label
                End If
                NouLabel.Height = Etiqueta.ContainedElements(Index).Height.Label
                NouLabel.Text = Etiqueta.ContainedElements(Index).CodeData & "X"
                NouLabel.Font = New System.Drawing.Font("Courier New", 8, FontStyle.Regular)
                NouLabel.TextAlign = ContentAlignment.BottomCenter
            Case TSPLElementEtiqueta.celTypeOfElement.Line
                NouLabel.BackColor = Color.Black
                NouLabel.AutoSize = False
                NouLabel.Text = ""
                NouLabel.Size = New System.Drawing.Size(New System.Drawing.Point( _
                                        Etiqueta.ContainedElements(Index).Height.Label, _
                                        Etiqueta.ContainedElements(Index).Width.Label))
                'NouLabel.Width = lblfmm2label(Etiqueta.ContainedElements(Index).Width)
            Case TSPLElementEtiqueta.celTypeOfElement.BMPImage
                Dim tmpImatge As Image = Image.FromFile(Etiqueta.ContainedElements(Index).ImageFilename)  'Application.StartupPath & "\" & Etiqueta.ContainedElements(Index).ImageFilename)
                NouLabel.BackColor = Color.Transparent
                NouLabel.Image = tmpImatge
                NouLabel.AutoSize = False
                NouLabel.Size = tmpImatge.Size
                'New System.Drawing.Size(New System.Drawing.Point( _
                '                                       lblfmm2label(tmpImatge.Height), _
                '                                       lblfmm2label(tmpImatge.Width)))
        End Select

        NouLabel.Tag = frmPrincipal.ActiveLabelDisplay.Count 'Se li dóna aquesta propietat per identificar-lo dins la llista
        frmPrincipal.ActiveLabelDisplay.Add(NouLabel) 'Agrega el component a la llista. La llista de l'etiqueta i de ActiveLabelDisplay tenen el mateix nombre d'elements

    End Sub

    Sub lblfActualitzaElementDisplay(ByVal Etiqueta As TSPLEtiqueta, ByVal Index As Short)

        Etiqueta.SetMm2LabelPoints(lblmm2LabelPoints, True) 'Configura la proporció entre els mm i els punts del formulari
        'Aquest valor pot anar canviant segons la mida del formulari

        frmPrincipal.ActiveLabelDisplay(Index).Left = Etiqueta.ContainedElements(Index).XPos.Label + lblXmargin 'Possible valor a ser actualitzat
        frmPrincipal.ActiveLabelDisplay(Index).Top = Etiqueta.ContainedElements(Index).Ypos.Label + lblYmargin 'Possible valor a ser actualitzat
        frmPrincipal.ActiveLabelDisplay(Index).BringToFront()


        'Possible valor a ser actualitzat, segons el tipus
        Select Case Etiqueta.ContainedElements(Index).ElementType
            Case TSPLElementEtiqueta.celTypeOfElement.Text
                frmPrincipal.ActiveLabelDisplay(Index).AutoSize = True
                frmPrincipal.ActiveLabelDisplay(Index).ForeColor = Color.Black
                frmPrincipal.ActiveLabelDisplay(Index).BackColor = Color.Transparent
                frmPrincipal.ActiveLabelDisplay(Index).Text = Etiqueta.ContainedElements(Index).Text
                Dim calcFontSize As Integer = CInt(CDec(Etiqueta.ContainedElements(Index).FontSize.Label) * LBLFONTSCALE)
                frmPrincipal.ActiveLabelDisplay(Index).Font = New System.Drawing.Font(Etiqueta.ContainedElements(Index).FontName, calcFontSize, lblfGetElementFontStyle(Etiqueta.ContainedElements(Index)))
            Case TSPLElementEtiqueta.celTypeOfElement.Barcode
                frmPrincipal.ActiveLabelDisplay(Index).AutoSize = False
                frmPrincipal.ActiveLabelDisplay(Index).BackColor = Color.Gray
                'frmPrincipal.ActiveLabelDisplay(Index).Width = Etiqueta.ContainedElements(Index).Width.Label
                frmPrincipal.ActiveLabelDisplay(Index).Height = Etiqueta.ContainedElements(Index).Height.Label
                frmPrincipal.ActiveLabelDisplay(Index).Text = Etiqueta.ContainedElements(Index).CodeData

        End Select

        frmPrincipal.ActiveLabelDisplay(Index).BorderStyle = BorderStyle.FixedSingle
        frmPrincipal.ActiveLabelDisplay(Index).ForeColor = Color.YellowGreen
        frmPrincipal.ActiveLabelDisplay(Index).Visible = Etiqueta.ContainedElements(Index).ToBePrinted 'si no s'ha d'imprimir, es posa no visible

    End Sub
    Sub lblfMostraElementsEtiqueta(ByVal etiqueta As TSPLEtiqueta)
        Dim i As Short
        For i = 0 To etiqueta.ContainedElements.Count - 1
            lblfAfegeixElementADisplay(etiqueta, i)
        Next
    End Sub

    Sub lblfRedrawEtiqueta(ByVal Etiqueta As TSPLEtiqueta)
        lblfClearLabelDisplay(frmPrincipal.ActiveLabelDisplay)
        lblfMostraElementsEtiqueta(Etiqueta)

    End Sub
    Sub lblfClearLabelDisplay(ByRef LabelDisplay As List(Of Label))
        For Each Element As Label In LabelDisplay
            Element.Hide() 'Dispose()
        Next
        LabelDisplay.Clear()
    End Sub

    Private Function lblfGetElementFontStyle(ByRef Element As TSPLElementEtiqueta) As System.Drawing.FontStyle
        Dim Style As New System.Drawing.FontStyle
        Select Case Element.FontStyle
            Case TSPLElementEtiqueta.celFontStyles.Normal
                Style = FontStyle.Regular
            Case TSPLElementEtiqueta.celFontStyles.Bold
                Style = FontStyle.Bold
            Case TSPLElementEtiqueta.celFontStyles.Italics
                Style = FontStyle.Italic
            Case TSPLElementEtiqueta.celFontStyles.Bold_Italics
                Style = FontStyle.Bold And FontStyle.Italic
        End Select

        If Element.FontUnderline Then
            Style = Style And FontStyle.Underline
        End If

        Return Style
    End Function

    Private Function lblfSeleccionaLabel(ByVal sender As Label, ByVal e As System.EventArgs) As Short
        frmPrincipal.RessaltaLabel(frmPrincipal.ActiveLabelDisplay, sender.Tag)
        'For Each Component As Label In frmPrincipal.ActiveLabelDisplay
        '    Component.BorderStyle = BorderStyle.None
        '    Component.ForeColor = Color.Black
        'Next
        'sender.BorderStyle = BorderStyle.FixedSingle
        'sender.ForeColor = Color.YellowGreen
        'frmPrincipal.SelectedElement = sender
        ''Posa el valor de la checkbox
        'frmPrincipal.chkVisible.Checked = frmPrincipal.ActiveLabel.ContainedElements(sender.Tag).ToBePrinted
        'frmPrincipal.propgElement.SelectedObject = frmPrincipal.ActiveLabel.ContainedElements(sender.Tag)
    End Function

End Module
