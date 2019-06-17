using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace LabelTextCustomData {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e) {
            
            new nwindDataSetTableAdapters.ProductsTableAdapter().Fill(nwindDataSet.Products);
            nwindDataSetBindingSource.DataSource = nwindDataSet;
        }

        private void chartControl1_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            e.LabelText = ((DataRowView)e.SeriesPoint.Tag)["QuantityPerUnit"].ToString(); 
        }
    }
}