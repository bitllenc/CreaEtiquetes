Public Class CDataBase

    'Connexions i variables referents a la base de dades
    '    Dim cdbConnectionString As String
    Dim cdbDataBasePath As String
    Dim cdbConnection As New System.Data.OleDb.OleDbConnection '(ConnectionString)
    Dim cdbCommand As New System.Data.OleDb.OleDbCommand
    Dim cdbReader As System.Data.OleDb.OleDbDataReader
    Dim cdblstColumnNames As New List(Of String)
    Dim cdblstTipusReferencies As New List(Of TipusReferencia)  'Referències de diferents fabricants
    Dim cdbActiveReference As New Integer   'Índex de la columna de Referències activa

    Public Structure TipusReferencia
        Public NumeroColumna As Integer
        Public NomColumna As String
        Public NumeroColumnaCodibarres As Integer
        Public NomColumnaCodibarres As String
    End Structure

    'Dim cdblstReturnedValues As New List(Of String)
    '1. Set DataBasePath()
    '2. OpenConnection()
    '[3. GetColumnNames()]
    '4. Use query functions 
    'X. CloseConnection()


    ReadOnly Property ConnectionString() As String
        Get
            Return cdbConnection.ConnectionString
        End Get
        'Set(ByVal value As String)
        '    value = cdbConnectionString
        'End Set
    End Property

    Property DataBasePath() As String
        Get
            Return cdbDataBasePath
        End Get
        Set(ByVal value As String)
            cdbDataBasePath = value
            'cdbConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & value
            cdbConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & value  'Configures the DB connection
            cdbCommand.Connection = cdbConnection
        End Set
    End Property

    ReadOnly Property NomsColumnes() As List(Of String)
        Get
            Return cdblstColumnNames
        End Get
    End Property
    Property TipusReferencies() As List(Of TipusReferencia)
        Get
            Return cdblstTipusReferencies
        End Get
        Set(ByVal value As List(Of TipusReferencia))
            cdblstTipusReferencies = value
        End Set
    End Property
    Property ActiveReference() As Integer
        Get
            Return cdbActiveReference
        End Get
        Set(ByVal value As Integer)
            cdbActiveReference = value
        End Set
    End Property

    Public Sub CloseConnection()
        cdbConnection.Close()
    End Sub

    Public Sub OpenConnection()
        cdbConnection.Open() 'obre la connexió amb la base de dades configurada a la ConnectionString
    End Sub

    Public Sub GetColumnNames(ByVal Table As String)
        'Dim lstColumnNames As New List(Of String)
        Dim NumeroColumna As Short

        cdbCommand.CommandText = "SELECT * FROM " & Table   'SQLQuery: Carrega tots els elements de la Taula DB
        'cdbCommand.Connection = cdbConnection               'Configura la connexió
        cdbReader = cdbCommand.ExecuteReader                'Executa la consulta
        cdbReader.Read()    'Es llegeixen els resultats

        cdblstColumnNames.Clear()
        For NumeroColumna = 0 To cdbReader.FieldCount - 1   'Per cada un dels camps
            cdblstColumnNames.Add(cdbReader.GetName(NumeroColumna).ToString.Trim) '...i s'omple la llista de resultats
        Next

        cdbReader.Close()   'Es llegeixen els resultats

    End Sub

    Public Function GetAllColumnValues(ByVal Column As String, ByVal Table As String) As List(Of String)
        'Agafa tots els elements d'un camp (Columna) i els col·loca en una llista
        Dim lstReturnedValues As New List(Of String)
        Dim NumeroColumna As Short

        cdbCommand.CommandText = "SELECT * FROM " & Table   'SQLQuery: Es llegeix tota la taula
        'cdbCommand.Connection = cdbConnection               'Configura la connexió
        cdbReader = cdbCommand.ExecuteReader                'Executa la consulta

        lstReturnedValues.Clear()   'Borra els valors 

        NumeroColumna = cdbReader.GetOrdinal(Column) 'S'agafa el número de la columna que interessa

        While cdbReader.Read()    'Es llegeixen els camps...
            If Not (IsDBNull(cdbReader.Item(NumeroColumna))) Then   'Filtra els valors nuls
                lstReturnedValues.Add(cdbReader.Item(NumeroColumna).ToString.Trim.ToUpper) '...i s'omple la llista de resultats
            End If
        End While

        cdbReader.Close()   'Es llegeixen els resultats

        Return lstReturnedValues

    End Function
    Public Function SearchRegister(ByVal Value As String, ByVal Field As String, ByVal Table As String) As List(Of List(Of String))
        Dim NumeroColumna As Short

        Dim lstResults As New List(Of List(Of String))

        cdbCommand.CommandText = "SELECT * FROM " & Table & " WHERE (" & Field & "='" & Value & "')"  'SQLQuery: Es llegeix tota la taula
        'cdbCommand.Connection = cdbConnection               'Configura la connexió
        cdbReader = cdbCommand.ExecuteReader                'Executa la consulta

        'lstRegister.Clear()   'Borra els valors 
        lstResults.Clear()

        While cdbReader.Read()    'Es llegeix un camp rera l'altre...
            Dim lstRegister As New List(Of String)
            For NumeroColumna = 0 To cdbReader.FieldCount - 1   'Per cada un dels camps
                lstRegister.Add(cdbReader.Item(NumeroColumna).ToString.Trim) '...i s'omple la llista de resultats d'un registre
            Next
            lstResults.Add(lstRegister)
            'lstRegister.Clear()
        End While

        cdbReader.Close()

        Return lstResults
    End Function

    Public Function GetColumnIndex(ByVal NomColumna As String) As Int16
        Return cdblstColumnNames.IndexOf(NomColumna)
    End Function


End Class
