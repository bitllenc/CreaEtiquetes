Module myDBFunctions

    Function dbfGetCBARbyRef(ByVal Referencia As String, ByRef bdConnection As System.Data.OleDb.OleDbConnection) As List(Of String)
        Dim bdCommand As New System.Data.OleDb.OleDbCommand("SELECT CodiBarres FROM Spotlights WHERE (Referencia='" & Referencia & "')", bdConnection) 'Es busca el Codi de barres corresponent a la referencia
        Dim bdResultats As System.Data.OleDb.OleDbDataReader
        Dim lstResultats As New List(Of String)

        bdResultats = bdCommand.ExecuteReader 'Executa la consulta

        lstResultats.Clear()  'Borra la llista

        While bdResultats.Read() 'Es llegeixen els camps...
            lstResultats.Add(bdResultats.Item(0).ToString.Trim.ToUpper) '...i s'omple la llista de resultats
        End While

        bdResultats.Close()

        Return lstResultats
    End Function

    Function dbfGetAllRegisters(ByVal Columna As String, ByRef bdConnection As System.Data.OleDb.OleDbConnection) As List(Of String)
        'Agafa tots els elements d'un camp (Columna) i els col·loca en una llista
        Dim NumeroColumna As Short
        Dim bdCommand As New System.Data.OleDb.OleDbCommand("SELECT * FROM Spotlights", bdConnection) 'Es llegeix tota la taula
        Dim bdResultats As System.Data.OleDb.OleDbDataReader
        Dim lstResultats As New List(Of String)

        bdResultats = bdCommand.ExecuteReader   'Executa la consulta

        lstResultats.Clear()    'Borra la llista

        NumeroColumna = bdResultats.GetOrdinal(Columna) 'S'agafa el número de la columna que interessa
        While bdResultats.Read()    'Es llegeixen els camps...
            lstResultats.Add(bdResultats.Item(NumeroColumna).ToString.Trim.ToUpper) '...i s'omple la llista de resultats
        End While

        bdResultats.Close()

        Return lstResultats
    End Function

    Function dbfGetRegistreComplet(ByVal Referencia As String, ByRef bdConnection As System.Data.OleDb.OleDbConnection) As List(Of String)
        Dim bdCommand As New System.Data.OleDb.OleDbCommand("SELECT * FROM Spotlights WHERE (Referencia='" & Referencia & "')", bdConnection) 'Es busca el Codi de barres corresponent a la referencia
        Dim bdResultats As System.Data.OleDb.OleDbDataReader
        Dim lstRegistre As New List(Of String)
        Dim NumeroColumna As Short

        bdResultats = bdCommand.ExecuteReader 'Executa la consulta

        lstRegistre.Clear()  'Borra la llista

        bdResultats.Read() 'Es llegeix el camp trobat...

        For NumeroColumna = 0 To bdResultats.FieldCount - 1   'Per cada un dels camps
            lstRegistre.Add(bdResultats.Item(NumeroColumna).ToString.Trim) '...i s'omple la llista de resultats
        Next

        bdResultats.Close()

        Return lstRegistre
    End Function

    Function dbfGetNomsColumnes(ByVal Referencia As String, ByRef bdConnection As System.Data.OleDb.OleDbConnection) As List(Of String)
        Dim bdCommand As New System.Data.OleDb.OleDbCommand("SELECT * FROM Spotlights WHERE (Referencia='" & Referencia & "')", bdConnection) 'Es busca el Codi de barres corresponent a la referencia
        Dim bdResultats As System.Data.OleDb.OleDbDataReader
        Dim lstRegistre As New List(Of String)
        Dim NumeroColumna As Short

        bdResultats = bdCommand.ExecuteReader 'Executa la consulta

        lstRegistre.Clear()  'Borra la llista

        bdResultats.Read() 'Es llegeix el camp trobat...

        For NumeroColumna = 0 To bdResultats.FieldCount - 1   'Per cada un dels camps
            lstRegistre.Add(bdResultats.GetName(NumeroColumna).ToString.Trim) '...i s'omple la llista de resultats
        Next

        bdResultats.Close()

        Return lstRegistre
    End Function

End Module
