using log4net.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PDFGenerator.Models.Dto;
using SqlFu;
using SqlFu.Providers.SqlServer;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace PDFGenerator.DAL
{
    public class DbRepository : IDbRepository
    {
        private readonly IConfiguration _config;
        private readonly ILogger<DbRepository> _logger;
        

        public DbRepository(IConfiguration config, ILogger<DbRepository> logger)
        {
            _config = config;
            _logger = logger;
            InitializeSqlFu();
        }

        private void InitializeSqlFu()
        {
            //Add SqlFu service to the service container:
            var dbContext = _config.GetConnectionString("PDFGeneratorDB");
            SqlFuManager.Configure(c =>
            {
                c.AddProfile<IPdfGeneratorDb>(new SqlServer2012Provider(SqlClientFactory.Instance.CreateConnection), dbContext);
                c.OnException = (cmd, ex) => _logger.LogError(cmd.FormatCommand(), ex);
            });
        }
        public async Task<List<Client>> GetClients()
        {
            System.Threading.CancellationToken ct = default;
            List<Client> result;
            using(DbConnection db = SqlFuManager.GetDbFactory<IPdfGeneratorDb>().Create())
            {
                result = await db.QueryAsync<Client>(ct, SqlQueries.GetClients);
            }
            return result;
        }

        public Task<List<Company>> GetCompanies()
        {
            throw new NotImplementedException();
        }

        public Task<List<MyImages>> GetMyImages()
        {
            throw new NotImplementedException();
        }

        public Task<List<Photo>> GetPhotos()
        {
            throw new NotImplementedException();
        }

        public Task<List<Models.Dto.Task>> GetTasks()
        {
            throw new NotImplementedException();
        }
    }
}
