using MappingExcelColumn.Models;

namespace MappingExcelColumn.SampleData;

public static class ProductSampleData
{
    public static List<DataRow> GetProductSampleDataRows()
    {
        return new List<DataRow>
        {
            new DataRow
            {
                RowId = 1,
                RowData = new Dictionary<string, ColumnData>
                {
                    { "Product Name", new ColumnData { FileColumn = "Product Name", Data = "Laptop X1" } },
                    { "Description", new ColumnData { FileColumn = "Description", Data = "High performance laptop" } },
                    { "Price", new ColumnData { FileColumn = "Price", Data = "1200.99" } },
                    { "Stock Quantity", new ColumnData { FileColumn = "Stock Quantity", Data = "50" } },
                    { "SKU", new ColumnData { FileColumn = "SKU", Data = "LTX100" } },
                    { "Brand", new ColumnData { FileColumn = "Brand", Data = "TechCorp" } },
                    { "Weight", new ColumnData { FileColumn = "Weight", Data = "2.5 kg" } },
                    { "Dimensions", new ColumnData { FileColumn = "Dimensions", Data = "30cm x 20cm x 2cm" } },
                    { "Discount Price", new ColumnData { FileColumn = "Discount Price", Data = "1100.00" } },
                    { "Shipping Cost", new ColumnData { FileColumn = "Shipping Cost", Data = "15.00" } }
                }
            },
            new DataRow
            {
                RowId = 2,
                RowData = new Dictionary<string, ColumnData>
                {
                    { "Product Name", new ColumnData { FileColumn = "Product Name", Data = "Smartphone Z5" } },
                    { "Description", new ColumnData { FileColumn = "Description", Data = "Latest 5G smartphone" } },
                    { "Price", new ColumnData { FileColumn = "Price", Data = "899.99" } },
                    { "Stock Quantity", new ColumnData { FileColumn = "Stock Quantity", Data = "100" } },
                    { "SKU", new ColumnData { FileColumn = "SKU", Data = "SMZ500" } },
                    { "Brand", new ColumnData { FileColumn = "Brand", Data = "MobileX" } },
                    { "Weight", new ColumnData { FileColumn = "Weight", Data = "200 g" } },
                    { "Dimensions", new ColumnData { FileColumn = "Dimensions", Data = "15cm x 7cm x 0.8cm" } },
                    { "Discount Price", new ColumnData { FileColumn = "Discount Price", Data = "850.00" } },
                    { "Shipping Cost", new ColumnData { FileColumn = "Shipping Cost", Data = "10.00" } }
                }
            },
            new DataRow
            {
                RowId = 3,
                RowData = new Dictionary<string, ColumnData>
                {
                    { "Product Name", new ColumnData { FileColumn = "Product Name", Data = "Tablet Pro 10" } },
                    { "Description", new ColumnData { FileColumn = "Description", Data = "Tablet with stylus" } },
                    { "Price", new ColumnData { FileColumn = "Price", Data = "599.99" } },
                    { "Stock Quantity", new ColumnData { FileColumn = "Stock Quantity", Data = "30" } },
                    { "SKU", new ColumnData { FileColumn = "SKU", Data = "TBP100" } },
                    { "Brand", new ColumnData { FileColumn = "Brand", Data = "GadgetWorks" } },
                    { "Weight", new ColumnData { FileColumn = "Weight", Data = "500 g" } },
                    { "Dimensions", new ColumnData { FileColumn = "Dimensions", Data = "25cm x 18cm x 0.9cm" } },
                    { "Discount Price", new ColumnData { FileColumn = "Discount Price", Data = "550.00" } },
                    { "Shipping Cost", new ColumnData { FileColumn = "Shipping Cost", Data = "8.00" } }
                }
            },
            new DataRow
            {
                RowId = 4,
                RowData = new Dictionary<string, ColumnData>
                {
                    { "Product Name", new ColumnData { FileColumn = "Product Name", Data = "Wireless Headphones Y3" } },
                    { "Description", new ColumnData { FileColumn = "Description", Data = "Noise-cancelling wireless headphones" } },
                    { "Price", new ColumnData { FileColumn = "Price", Data = "299.99" } },
                    { "Stock Quantity", new ColumnData { FileColumn = "Stock Quantity", Data = "75" } },
                    { "SKU", new ColumnData { FileColumn = "SKU", Data = "WHY300" } },
                    { "Brand", new ColumnData { FileColumn = "Brand", Data = "SoundTech" } },
                    { "Weight", new ColumnData { FileColumn = "Weight", Data = "150 g" } },
                    { "Dimensions", new ColumnData { FileColumn = "Dimensions", Data = "18cm x 18cm x 7cm" } },
                    { "Discount Price", new ColumnData { FileColumn = "Discount Price", Data = "270.00" } },
                    { "Shipping Cost", new ColumnData { FileColumn = "Shipping Cost", Data = "5.00" } }
                }
            },
            new DataRow
            {
                RowId = 5,
                RowData = new Dictionary<string, ColumnData>
                {
                    { "Product Name", new ColumnData { FileColumn = "Product Name", Data = "Smart Watch T7" } },
                    { "Description", new ColumnData { FileColumn = "Description", Data = "Fitness tracker with GPS" } },
                    { "Price", new ColumnData { FileColumn = "Price", Data = "199.99" } },
                    { "Stock Quantity", new ColumnData { FileColumn = "Stock Quantity", Data = "120" } },
                    { "SKU", new ColumnData { FileColumn = "SKU", Data = "SWT700" } },
                    { "Brand", new ColumnData { FileColumn = "Brand", Data = "FitWear" } },
                    { "Weight", new ColumnData { FileColumn = "Weight", Data = "50 g" } },
                    { "Dimensions", new ColumnData { FileColumn = "Dimensions", Data = "5cm x 4cm x 1cm" } },
                    { "Discount Price", new ColumnData { FileColumn = "Discount Price", Data = "180.00" } },
                    { "Shipping Cost", new ColumnData { FileColumn = "Shipping Cost", Data = "4.00" } }
                }
            },
            new DataRow
            {
                RowId = 6,
                RowData = new Dictionary<string, ColumnData>
                {
                    { "Product Name", new ColumnData { FileColumn = "Product Name", Data = "Bluetooth Speaker A2" } },
                    { "Description", new ColumnData { FileColumn = "Description", Data = "Portable Bluetooth speaker" } },
                    { "Price", new ColumnData { FileColumn = "Price", Data = "149.99" } },
                    { "Stock Quantity", new ColumnData { FileColumn = "Stock Quantity", Data = "200" } },
                    { "SKU", new ColumnData { FileColumn = "SKU", Data = "BSA200" } },
                    { "Brand", new ColumnData { FileColumn = "Brand", Data = "AudioBlast" } },
                    { "Weight", new ColumnData { FileColumn = "Weight", Data = "600 g" } },
                    { "Dimensions", new ColumnData { FileColumn = "Dimensions", Data = "10cm x 10cm x 8cm" } },
                    { "Discount Price", new ColumnData { FileColumn = "Discount Price", Data = "130.00" } },
                    { "Shipping Cost", new ColumnData { FileColumn = "Shipping Cost", Data = "7.00" } }
                }
            },
            new DataRow
            {
                RowId = 7,
                RowData = new Dictionary<string, ColumnData>
                {
                    { "Product Name", new ColumnData { FileColumn = "Product Name", Data = "Gaming Console X Pro" } },
                    { "Description", new ColumnData { FileColumn = "Description", Data = "Next-gen gaming console" } },
                    { "Price", new ColumnData { FileColumn = "Price", Data = "499.99" } },
                    { "Stock Quantity", new ColumnData { FileColumn = "Stock Quantity", Data = "40" } },
                    { "SKU", new ColumnData { FileColumn = "SKU", Data = "GCXP500" } },
                    { "Brand", new ColumnData { FileColumn = "Brand", Data = "GameMasters" } },
                    { "Weight", new ColumnData { FileColumn = "Weight", Data = "4 kg" } },
                    { "Dimensions", new ColumnData { FileColumn = "Dimensions", Data = "40cm x 30cm x 10cm" } },
                    { "Discount Price", new ColumnData { FileColumn = "Discount Price", Data = "450.00" } },
                    { "Shipping Cost", new ColumnData { FileColumn = "Shipping Cost", Data = "20.00" } }
                }
            }
        };
    }

}