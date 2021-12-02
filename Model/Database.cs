using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code.Model
{
    public class Database
    {
        public void DatabaseConnectionSetup(IServiceCollection services)
        {
            String Server = "";
            String Database = "";
            String User = "";
            String Pass = "";

            var connection = @"Server=" + Server 
                + "; Database=" + Database 
                + "; user id=" + User 
                + ";pwd=" + ";";

            //services.AddDbContext<DbApiContext>(options => options.UseSqlServer(connection));
        }
    }
}
