namespace MappingExcelColumn.Models;

public class DataRow
{
    public int RowId { get; set; }
    public Dictionary<string, ColumnData> RowData { get; set; }
}