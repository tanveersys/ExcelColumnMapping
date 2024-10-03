using MappingExcelColumn.Models;

namespace MappingExcelColumn.Interface;

public interface IMappingService
{
    List<Dictionary<string, string>> MapFields(List<DataRow> rows, List<MappingField> mappingFields);
}
