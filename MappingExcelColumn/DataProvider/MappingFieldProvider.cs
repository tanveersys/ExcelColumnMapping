using MappingExcelColumn.Interface;
using MappingExcelColumn.Models;
using MappingExcelColumn.SampleData;

namespace MappingExcelColumn.DataProvider;

public class MappingFieldProvider : IMappingFieldProvider
{
    public List<MappingField> GetMappingFields()
    {
        return new List<MappingField>
        {
            new MappingField
            {
                DatabaseColumn = "ProductName",
                DataType = "string",
                FileColumn = "Product Name",
                IsRequired = true
            },
            new MappingField
            {
                DatabaseColumn = "Description",
                DataType = "string",
                FileColumn = "Description",
                IsRequired = true
            },
            new MappingField
            {
                DatabaseColumn = "Price",
                DataType = "decimal",
                FileColumn = "Price",
                IsRequired = true
            },
            new MappingField
            {
                DatabaseColumn = "StockQuantity",
                DataType = "int",
                FileColumn = "Stock Quantity",
                IsRequired = true
            },
            new MappingField
            {
                DatabaseColumn = "SKU",
                DataType = "string",
                FileColumn = "SKU",
                IsRequired = true
            },
            new MappingField
            {
                DatabaseColumn = "Brand",
                DataType = "string",
                FileColumn = "Brand",
                IsRequired = false
            },
            new MappingField
            {
                DatabaseColumn = "Weight",
                DataType = "string",
                FileColumn = "Weight",
                IsRequired = false
            },
            new MappingField
            {
                DatabaseColumn = "Dimensions",
                DataType = "string",
                FileColumn = "Dimensions",
                IsRequired = false
            },
            new MappingField
            {
                DatabaseColumn = "DiscountPrice",
                DataType = "decimal",
                FileColumn = "Discount Price",
                IsRequired = false
            },
            new MappingField
            {
                DatabaseColumn = "ShippingCost",
                DataType = "decimal",
                FileColumn = "Shipping Cost",
                IsRequired = false
            }
        };
    }


    public List<DataRow> GetSampleDataRows()
    {
        return ProductSampleData.GetProductSampleDataRows();
    }
}
