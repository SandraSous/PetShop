using Microsoft.Data.SqlClient;
using System.Data;

namespace PetShop.Data; 
public class DapperContext {
    private readonly IConfiguration _configuration;
    private readonly string _ConnectionString;

    public DapperContext(IConfiguration configuration) {
        _configuration = configuration;
        _ConnectionString = _configuration.GetConnectionString("DefaultConnection")!;
    }
    public IDbConnection CreateConnection() => new SqlConnection(_ConnectionString);
   
}
