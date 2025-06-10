using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using stageapi.Models;

namespace stageapi.Controllers;

[ApiController]
[Route("[controller]")]
public class StageController : ControllerBase
{
    private readonly ILogger<StageController> _logger;

    List<Stage> stages = new List<Stage>
    {
        new Stage { BedrijfsNaam = "Tech Innovators BV", StageVergoeding = 500.00, Stad = "Amsterdam" },
        new Stage { BedrijfsNaam = "Green Solutions", StageVergoeding = 600.50, Stad = "Rotterdam" },
        new Stage { BedrijfsNaam = "Future Designs", StageVergoeding = 450.75, Stad = "Utrecht" },
        new Stage { BedrijfsNaam = "EduWorld", StageVergoeding = 400.00, Stad = "Den Haag" },
        new Stage { BedrijfsNaam = "Code Creators", StageVergoeding = 550.00, Stad = "Eindhoven" }
    };


    public StageController(ILogger<StageController> logger)
    {
        _logger = logger;
    }
}
