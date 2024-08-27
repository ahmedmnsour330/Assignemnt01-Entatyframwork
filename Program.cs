using Assignemnt01_Entatyframwork.Context;
using Microsoft.EntityFrameworkCore;

namespace Assignemnt01_Entatyframwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CompanyDBContext dBContext = new CompanyDBContext();
            dBContext.Database.Migrate();
        }
    }
}
