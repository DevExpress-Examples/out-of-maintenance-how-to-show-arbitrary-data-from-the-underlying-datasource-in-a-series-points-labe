Imports System
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace LabelTextCustomData
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub


		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

			Call (New nwindDataSetTableAdapters.ProductsTableAdapter()).Fill(nwindDataSet.Products)
			nwindDataSetBindingSource.DataSource = nwindDataSet
		End Sub

		Private Sub chartControl1_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs) Handles chartControl1.CustomDrawSeriesPoint
			e.LabelText = CType(e.SeriesPoint.Tag, DataRowView)("QuantityPerUnit").ToString()
		End Sub
	End Class
End Namespace