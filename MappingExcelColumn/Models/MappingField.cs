namespace MappingExcelColumn.Models;

public class MappingField
{
    public string DatabaseColumn { get; set; }
    public string DataType { get; set; }
    public string FileColumn { get; set; }
    public bool IsRequired { get; set; }
}
