using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aspire.Security
{
  public static  class AuthTools
  {
    /// <summary>
    /// To be implemented 
    /// </summary>
    /// <param name="password"></param>
    /// <returns></returns>
    public static string Hash(string password)
    {

      // SHA256 is disposable by inheritance.  
      using (var sha256 = SHA256.Create())
      {
        // Send a sample text to hash.  
        var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
        // Get the hashed string.  
        var hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
        // Print the string.   
        return hash;
      }
    }

    public static bool ConfirmPassword(string password, string confirmpassword)
    {
      return password == confirmpassword;

    }
  }
}
