Imports System.IO
Imports System.Xml.Serialization
Public Module myUsuari


    'Noms de les columnes de la base de dades
    'Public colRefGumarcris As String = "RefGumarcris"
    'Public colCodiDeBarres As String = "CodiBarres"
    'Public colOrigen As String = "Origen"
    Public colItemsBox As String = "UnitatsCaixa"

    Public Structure tConfiguracio
        Public ArxiuCFGImpressora As String
        Public XOffset As Single
        Public YOffset As Single
        Public ArxiuBaseDades As String
        Public AccessTableName As String
        Public DirectoriImatges As String
        Public DirectoriEtiquetes As String
        Public ArxiuEtiquetaUtilitzada As String
    End Structure

    Public Function InicialitzaConfiguracioPrograma() As tConfiguracio
        Dim Arxiu As New System.IO.StreamReader("config.xml")
        Dim Config As tConfiguracio
        Dim serialitzador As New System.Xml.Serialization.XmlSerializer(GetType(tConfiguracio))
        Config = CType(serialitzador.Deserialize(Arxiu), tConfiguracio)
        Arxiu.Close()
        Return Config
    End Function

    Public Sub GuardaConfiguracioPrograma(ByVal ConfiguracioPrograma As tConfiguracio)
        Dim Arxiu As New System.IO.StreamWriter("config.xml")
        Dim Serialitzador As New System.Xml.Serialization.XmlSerializer(GetType(tConfiguracio))
        Serialitzador.Serialize(Arxiu, ConfiguracioPrograma)
        Arxiu.Close()
    End Sub

    Public Function InicialitzaImpressora(ByVal arxiu_impressora As String) As TSPLImpressora
        Dim XMLImpressora As New TSPLImpressora
        Dim Serialitzador As New System.Xml.Serialization.XmlSerializer(GetType(TSPLImpressora))
        Dim ArxiuFontXML As New System.IO.StreamReader(arxiu_impressora)

        XMLImpressora = CType(Serialitzador.Deserialize(ArxiuFontXML), TSPLImpressora)
        ArxiuFontXML.Close()

        Return XMLImpressora
    End Function

    Public Function InicialitzaEtiqueta(ByVal NomArxiuXML As String) As TSPLEtiqueta
        Dim XMLEtiqueta As New TSPLEtiqueta("xmlImportedLabel")
        Dim Serialitzador As New System.Xml.Serialization.XmlSerializer(GetType(TSPLEtiqueta))
        Dim ArxiuFontXML As New System.IO.StreamReader(NomArxiuXML)

        XMLEtiqueta = CType(Serialitzador.Deserialize(ArxiuFontXML), TSPLEtiqueta)
        ArxiuFontXML.Close()

        Return XMLEtiqueta
    End Function

    Public Function GuardaEtiqueta(ByVal etiqueta As TSPLEtiqueta, ByVal NomArxiuXML As String) As TSPLEtiqueta
        'Dim XMLEtiqueta As New TSPLEtiqueta("xmlImportedLabel")
        ' Dim Serialitzador As New System.Xml.Serialization.XmlSerializer(GetType(TSPLEtiqueta))
        'Dim ArxiuXML As New System.IO.StreamReader(NomArxiuXML)
        'Dim XMLWriter As System.Xml.XmlWriter


        Dim objStreamWriter As New StreamWriter(NomArxiuXML)
        Dim x As New XmlSerializer(etiqueta.GetType)

        x.Serialize(objStreamWriter, etiqueta)
        objStreamWriter.Close()


        'XMLWriter.
        'XMLEtiqueta = CType(Serialitzador.Serialize(XMLWriter), TSPLEtiqueta)
        'ArxiuFontXML.Close()

        'Return XMLEtiqueta
    End Function

    Public Sub myCarregaElementsEtiqueta(ByVal NomArxiuXML As String, ByRef Etiqueta As TSPLEtiqueta, ByVal DadesItem As List(Of String), ByVal NomsColumnes As List(Of String))
        Dim XMLEtiqueta As New TSPLEtiqueta("xmlImportedLabel")
        XMLEtiqueta = InicialitzaEtiqueta(NomArxiuXML)

        'Carrega els components de l'etiqueta: S'afegeixen tots els elements a l'etiqueta
        'Si s'agafessin les dades d'un arxiu, aquí hi aniria el codi per fer-ho
        For index As Short = 0 To XMLEtiqueta.ContainedElements.Count - 1
            Select Case XMLEtiqueta.ContainedElements(index).ElementType
                Case TSPLElementEtiqueta.celTypeOfElement.Text
                    'Etiqueta.dfAfegeixText(ProcessaCamps(XMLEtiqueta.ContainedElements(index).Text, DadesItem, NomsColumnes),
                    '                        XMLEtiqueta.ContainedElements(index).FontName,
                    '                        XMLEtiqueta.ContainedElements(index).FontStyle,
                    '                        XMLEtiqueta.ContainedElements(index).FontUnderline,
                    '                        XMLEtiqueta.ContainedElements(index).FontSize.mm,
                    '                        XMLEtiqueta.ContainedElements(index).Rotation,
                    '                        XMLEtiqueta.ContainedElements(index).XPos.mm,
                    '                        XMLEtiqueta.ContainedElements(index).Ypos.mm,
                    '                        XMLEtiqueta.ContainedElements(index).ToBePrinted,
                    '                        XMLEtiqueta.ContainedElements(index).Name)
                Case TSPLElementEtiqueta.celTypeOfElement.Barcode
                    'Etiqueta.dfAfegeixCodiBarres(XMLEtiqueta.ContainedElements(index).CodeType,
                    '                             ProcessaCamps(XMLEtiqueta.ContainedElements(index).CodeData, DadesItem, NomsColumnes),
                    '                             XMLEtiqueta.ContainedElements(index).HumanInterpretation,
                    '                             XMLEtiqueta.ContainedElements(index).NarrowBarRatio,
                    '                             XMLEtiqueta.ContainedElements(index).WideBarRatio,
                    '                             XMLEtiqueta.ContainedElements(index).Height.mm,
                    '                             XMLEtiqueta.ContainedElements(index).Rotation,
                    '                             XMLEtiqueta.ContainedElements(index).XPos.mm,
                    '                             XMLEtiqueta.ContainedElements(index).Ypos.mm,
                    '                             XMLEtiqueta.ContainedElements(index).ToBePrinted,
                    '                             XMLEtiqueta.ContainedElements(index).Name)
                Case TSPLElementEtiqueta.celTypeOfElement.BMPImage
                    'Etiqueta.dfAfegeixImatgeBMP(frmPrincipal.Configuracio.DirectoriImatges & "\" & ProcessaCamps(XMLEtiqueta.ContainedElements(index).ImageFilename, DadesItem, NomsColumnes),
                    '                            XMLEtiqueta.ContainedElements(index).XPos.mm,
                    '                            XMLEtiqueta.ContainedElements(index).Ypos.mm,
                    '                            XMLEtiqueta.ContainedElements(index).ToBePrinted,
                    '                            XMLEtiqueta.ContainedElements(index).Name)
            End Select
        Next

    End Sub

    Private Function ProcessaCamps(ByVal Text As String, ByVal DadesItem As List(Of String), ByVal NomsColumnes As List(Of String)) As String
        Dim campIndex_ini, campIndex_fi As Integer
        Dim campNom, campValor As String

        'While Text.Contains("|*")
        '    campIndex_ini = Text.IndexOf("|*")
        '    Text = Text.Remove(campIndex_ini, 2)
        '    campIndex_fi = Text.IndexOf("*|")
        '    Text = Text.Remove(campIndex_fi, 2)

        '    campNom = Text.Substring(campIndex_ini, campIndex_fi - campIndex_ini)
        '    'Casos especials
        '    If StrComp(campNom, "Referencia") = 0 Then  '|*Referencia*| enlloc de |*RefGumarcris*| o |*RefFabricant*|
        '        campValor = DadesItem(NomsColumnes.IndexOf(frmPrincipal.BaseDeDades.TipusReferencies(frmPrincipal.BaseDeDades.ActiveReference).NomColumna))
        '    ElseIf StrComp(campNom, "CodiBarres") = 0 Then  '|*CodiBarres*| enlloc de |*CodiBGumarcris*| o |*CodiBFabricant*|
        '        campValor = DadesItem(NomsColumnes.IndexOf(frmPrincipal.BaseDeDades.TipusReferencies(frmPrincipal.BaseDeDades.ActiveReference).NomColumnaCodibarres))
        '    Else
        '        campValor = DadesItem(NomsColumnes.IndexOf(campNom))
        '    End If
        '    Text = Text.Replace(campNom, campValor)

        'End While

        Return Text
    End Function

    Public Sub myEscriuLog(ByVal Referencia As String, ByVal Numero As String)
        Dim arxiu_log As New System.IO.StreamWriter("registre.log", True)
        arxiu_log.WriteLine(Now().ToString() & " - " & Referencia & " - " & Numero)
        arxiu_log.Close()
    End Sub

End Module
