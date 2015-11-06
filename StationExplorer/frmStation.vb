Public Class frmStation

    ''' <summary>
    ''' Select station ids and station names from the Climsoft station table and display
    ''' these in listViewToPopulate. The limit parameter must be supplied and will limit the
    ''' number of stations displayed.
    ''' </summary>
    ''' <param name="listViewToPopulate">The ListView control that will display the data</param>
    ''' <param name="limit">An integer value to limit the number of results</param>
    Private Sub populateListWithStationData(listViewToPopulate As ListView, limit As Integer)
        Dim dataAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim ds As New DataSet
        Dim item As New ListViewItem
        Dim stationId As String
        Dim stationName As String
        Dim sql As String
        Dim totalRows As Integer

        Try
            sql = "SELECT stationId, stationName FROM station LIMIT 50;"
            dataAdapter = New MySql.Data.MySqlClient.MySqlDataAdapter(sql, frmLogin.dbConnection)
            dataAdapter.Fill(ds, "station")
            listViewToPopulate.Columns.Clear()
            listViewToPopulate.Columns.Add("Station Id", 80)
            listViewToPopulate.Columns.Add("Station Name", 200)
            totalRows = ds.Tables("station").Rows.Count

            For count = 0 To totalRows - 1 Step 1
                stationId = ds.Tables("station").Rows(count).Item("stationId")
                stationName = ds.Tables("station").Rows(count).Item("stationName")
                item = New ListViewItem({stationId, stationName})
                listViewToPopulate.Items.Add(item)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmStation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim limit As Integer = 100
        Me.Text = String.Format("Station Explorer (Limted to first {0} stations)", limit)
        populateListWithStationData(lvwStation, limit)
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        frmLogin.Close()
        Me.Close()
    End Sub
End Class