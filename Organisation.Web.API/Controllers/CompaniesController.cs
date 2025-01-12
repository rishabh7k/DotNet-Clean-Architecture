using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Organisation.Presentation.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompaniesController : ControllerBase
{
    private readonly List<Company> _companies = new List<Company>()
    {
        new Company{Name="Test1",Id="1"},
        new Company{Name="Test2",Id="2"},
        new Company{Name="Test3",Id="3"},
    };

    [HttpGet]
    public async Task<IActionResult> GetCompanies()
    {
        await Task.CompletedTask;
        return Ok(_companies);
    }

    [HttpGet("company/{id:length(1)}")]
    public async Task<IActionResult> GetCompanyById(string id)
    {
        var company=_companies.Find(x => x.Id == id);
        await Task.CompletedTask;
        if (company == null)
            return NotFound(company);
        return Ok(company);
    }

    [HttpPost("company")]
    public async Task<IActionResult> AddCompany([FromBody]Company company)
    {
        await Task.CompletedTask;
        _companies.Add(company);
        return CreatedAtAction("GetCompanyById", new {id=company.Id},company);
    }

    [HttpPut("company/{id:length(1)}")]
    public async Task<IActionResult> UpdateCompany(string id, [FromBody] Company updatedCompany)
    {
        var company = _companies.Find(x => x.Id == id);
        if (company == null)
            return NotFound();

        company.Name = updatedCompany.Name;
        await Task.CompletedTask;
        return NoContent();
    }

    [HttpDelete("company/{id:length(1)}")]
    public async Task<IActionResult> DeleteCompany(string id)
    {
        var company = _companies.Find(x => x.Id == id);
        if (company == null)
            return NotFound();

        _companies.Remove(company);
        await Task.CompletedTask;
        return NoContent();
    }

}



