using MappingExcelColumn.Interface;
using Microsoft.AspNetCore.Mvc;

namespace MappingExcelColumn.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MappingController : ControllerBase
{
    private readonly IMappingService _mappingService;
    private readonly IMappingFieldProvider _mappingFieldProvider;

    public MappingController(IMappingService mappingService, IMappingFieldProvider mappingFieldProvider)
    {
        _mappingService = mappingService;
        _mappingFieldProvider = mappingFieldProvider;
    }

    [HttpPost("map-fields")]
    public IActionResult MapFields()
    {
        // Get mapping fields from the provider
        var mappingFields = _mappingFieldProvider.GetMappingFields();
        var rows = _mappingFieldProvider.GetSampleDataRows();

        // Map fields
        var mappedResult = _mappingService.MapFields(rows, mappingFields);

        return Ok(mappedResult);
    }
}
