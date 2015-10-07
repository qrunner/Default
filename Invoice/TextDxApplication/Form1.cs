using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraPivotGrid;


namespace TextDxApplication
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();
            InitPivotGridAndChart();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }
        void InitPivotGridAndChart()
        {
            string[] products = { "A", "B", "C", "D", "E" };
            BindingList<PivotGridDataItem> orders = new BindingList<PivotGridDataItem>();
            Random random = new Random();
            for (int productIndex = 0; productIndex < products.Length; productIndex++)
            {
                string product = products[productIndex];
                for (int year = 2010; year < 2012; year++)
                    for (int month = 1; month < 13; month++)
                    {
                        DateTime date = new DateTime(year, month, 1);
                        double price = (double)random.Next(10000) / 100;
                        orders.Add(new PivotGridDataItem(product, price, date));
                    }
            }
            pivotGridControl.DataSource = orders;
            pivotGridControl.Fields.Add(new PivotGridField("Product", PivotArea.RowArea));
            pivotGridControl.Fields.Add(new PivotGridField("Price", PivotArea.DataArea));
            PivotGridField yearField = new PivotGridField("Date", PivotArea.ColumnArea);
            yearField.Caption = "Year";
            yearField.GroupInterval = PivotGroupInterval.DateYear;
            PivotGridField monthField = new PivotGridField("Date", PivotArea.ColumnArea);
            monthField.Caption = "Month";
            monthField.GroupInterval = PivotGroupInterval.DateMonth;
            pivotGridControl.Fields.Add(yearField);
            pivotGridControl.Fields.Add(monthField);
            pivotGridControl.Groups.Add(yearField, monthField);
            yearField.CollapseAll();
            pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = false;
            pivotGridControl.OptionsChartDataSource.ProvideRowTotals = false;
            pivotGridControl.OptionsChartDataSource.ProvideRowGrandTotals = false;
            pivotGridControl.OptionsChartDataSource.ProvideRowCustomTotals = false;
            pivotGridControl.OptionsChartDataSource.ProvideColumnTotals = false;
            pivotGridControl.OptionsChartDataSource.ProvideColumnGrandTotals = false;
            pivotGridControl.OptionsChartDataSource.ProvideColumnCustomTotals = false;
            pivotGridControl.Cells.Selection = new Rectangle(0, 0, pivotGridControl.Cells.ColumnCount, pivotGridControl.Cells.RowCount);
        }

    }
}