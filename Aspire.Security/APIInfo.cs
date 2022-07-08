using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspire.Security
{
  public class APIInfo
  {
    public string Name { get; set; } = string.Empty;
    public string Url { get; set; } = string.Empty;
    public APIHeaders Headers { get; set; } = new APIHeaders();

  }
}
