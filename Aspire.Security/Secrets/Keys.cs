using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspire.Security.Secrets
{
  public static  class Keys
  {
    public static APIInfo AspireAPI = new APIInfo()
    {
      Name = "AspireAPI",
      Url = "https://localhost:7235",
      Headers  = new APIHeaders()
    {
      Name = "x-api-key",
      Value = "******************************************"
    }
  };

    public static readonly string ConnectionString = "*********************************************";



  }
}
