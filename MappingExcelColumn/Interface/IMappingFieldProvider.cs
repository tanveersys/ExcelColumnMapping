using MappingExcelColumn.Models;

namespace MappingExcelColumn.Interface;

public interface IMappingFieldProvider
{
    List<MappingField> GetMappingFields();
    List<DataRow> GetSampleDataRows();
}
