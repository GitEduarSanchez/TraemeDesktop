Imports System.Windows.Forms
Public Class ClassColorDatagri
    Sub color(ByVal dt As DataGridView)
        dt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dt.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        dt.DefaultCellStyle.BackColor = Drawing.Color.White
        dt.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.LightBlue
        dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dt.AllowUserToAddRows = False
    End Sub
    Sub color1(ByVal dt As DataGridView)
        dt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dt.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        dt.DefaultCellStyle.BackColor = Drawing.Color.White
        dt.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.AliceBlue
        dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dt.AllowUserToAddRows = False
    End Sub
    Sub color2(ByVal dt As DataGridView)
        dt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dt.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        dt.DefaultCellStyle.BackColor = Drawing.Color.White
        dt.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.LightSteelBlue
        dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dt.AllowUserToAddRows = False
    End Sub
    Sub color3(ByVal dt As DataGridView)
        dt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dt.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        dt.DefaultCellStyle.BackColor = Drawing.Color.White
        dt.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.LightSlateGray
        dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dt.AllowUserToAddRows = False
    End Sub
    Sub color4(ByVal dt As DataGridView)
        dt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dt.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        dt.DefaultCellStyle.BackColor = Drawing.Color.White
        dt.AlternatingRowsDefaultCellStyle.BackColor = Drawing.Color.Silver
        dt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dt.AllowUserToAddRows = False
    End Sub


End Class
