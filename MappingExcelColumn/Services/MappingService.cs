using MappingExcelColumn.Interface;
using MappingExcelColumn.Models;

namespace MappingExcelColumn.Services;

public class MappingService : IMappingService
{
    //public List<Dictionary<string, string>> MapFields(List<DataRow> rows, List<MappingField> mappingFields)
    //{
    //    var result = new List<Dictionary<string, string>>();

    //    foreach (var dataRow in rows)
    //    {
    //        var mappedRow = new Dictionary<string, string>();
    //        foreach (var mapping in mappingFields)
    //        {
    //            var fileColumn = mapping.FileColumn;
    //            var dbColumn = mapping.DatabaseColumn;

    //            if (dataRow.RowData.TryGetValue(dbColumn, out var columnData))
    //            {
    //                mappedRow[fileColumn] = columnData.Data;
    //            }
    //        }
    //        result.Add(mappedRow);
    //    }

    //    return result;
    //}

    public List<Dictionary<string, string>> MapFields(List<DataRow> rows, List<MappingField> mappingFields)
    {
        if (rows == null || !rows.Any())
        {
            throw new ArgumentException("Rows list cannot be null or empty.", nameof(rows));
        }

        if (mappingFields == null || !mappingFields.Any())
        {
            throw new ArgumentException("Mapping fields list cannot be null or empty.", nameof(mappingFields));
        }

        var result = new List<Dictionary<string, string>>();
        foreach (var dataRow in rows)
        {
            var mappedRow = new Dictionary<string, string>();
            foreach (var mapping in mappingFields)
            {
                if (string.IsNullOrWhiteSpace(mapping.FileColumn) || string.IsNullOrWhiteSpace(mapping.DatabaseColumn))
                {
                    throw new InvalidOperationException("Mapping fields must have both FileColumn and DatabaseColumn set.");
                }
                var dbColumn = mapping.DatabaseColumn;
                var fileColumn = mapping.FileColumn;
                var dbColumnExists = dataRow.RowData.Keys
                    .Any(key => string.Equals(key, dbColumn, StringComparison.OrdinalIgnoreCase));

                if (dbColumnExists)
                {
                    if (dataRow.RowData.TryGetValue(dbColumn, out var columnData) && columnData != null)
                    {
                        mappedRow[fileColumn] = columnData.Data ?? string.Empty;
                    }
                    else
                    {
                        mappedRow[fileColumn] = string.Empty;
                    }
                }
                else
                {
                    mappedRow[fileColumn] = string.Empty;
                }
            }
            result.Add(mappedRow);
        }

        return result;
    }
}
