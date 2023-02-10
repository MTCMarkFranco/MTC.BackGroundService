namespace MTC.BackGroundService;
using System.Management.Automation;
using System.Text;

public sealed class PowerShellBackgroundService
{
    private readonly PowerShell _powerShell;
    
    public PowerShellBackgroundService()
    {
            // if _powerShell is null create an instance of PowerShell
            _powerShell = PowerShell.Create();
    }

    public string GetPSOutPut()
    {
                // create a new stringbuilder that will append the results of the commands
                var stringBuilder = new StringBuilder();
                
                 _powerShell.Commands.AddCommand("Get-Process");
                var results = _powerShell.Invoke();
                
                // Print the results of the commands
                foreach (var result in results)
                {
                    stringBuilder.Append(result.ToString());
                }

        return stringBuilder.ToString();
    }

   
}