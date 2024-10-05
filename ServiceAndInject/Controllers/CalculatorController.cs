using Microsoft.AspNetCore.Mvc;
using ServiceAndInject.Interfaces;

namespace ServiceAndInject.Controllers;

public class CalculatorController : ControllerBase
{

    private readonly ICalculatorService<int> _calculatorService;

    public CalculatorController(ICalculatorService<int> calculatorService)
    {
        _calculatorService = calculatorService;
    }
    
    [HttpGet("subtract")]
    public int Subtract([FromQuery] int left, [FromQuery] int right)
    {
        return _calculatorService.Subtract(left, right);
    }

    [HttpGet("add")]
    public int Add([FromQuery] int left, [FromQuery] int right)
    {
        return _calculatorService.Add(left, right);
    }

    [HttpGet("multiply")]
    public int Multiply([FromQuery] int left, [FromQuery] int right)
    {
        return _calculatorService.Multiply(left, right);
    }

    [HttpGet("divide")]
    public int Divide([FromQuery] int left, [FromQuery] int right)
    {
        return _calculatorService.Divide(left, right);
    }
    
    

    

}