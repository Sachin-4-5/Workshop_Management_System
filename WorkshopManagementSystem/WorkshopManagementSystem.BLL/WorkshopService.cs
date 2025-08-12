using System.Collections.Generic;
using WorkshopManagementSystem.DAL;
using WorkshopManagementSystem.Models;

namespace WorkshopManagementSystem.BLL
{
    public class WorkshopService
    {
        private readonly WorkshopRepository _repo = new WorkshopRepository();

        public List<Workshop> GetAllWorkshops() => _repo.GetAll();
        public Workshop GetWorkshopById(int id) => _repo.GetById(id);
        public bool AddWorkshop(Workshop w) => _repo.Add(w);
        public int GetRegistrationCount(int workshopId) => _repo.GetRegistrationCount(workshopId);
    }
}
