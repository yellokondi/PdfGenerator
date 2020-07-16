using PDFGenerator.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDFGenerator.DAL
{
    public interface IDbRepository
    {
        Task<List<Client>> GetClients();
        Task<List<Company>> GetCompanies();
        Task<List<Models.Dto.Task>> GetTasks();
        Task<List<Photo>> GetPhotos();
        Task<List<MyImages>> GetMyImages();
    }
}
