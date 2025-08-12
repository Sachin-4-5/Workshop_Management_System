using System.Collections.Generic;
using WorkshopManagementSystem.DAL;
using WorkshopManagementSystem.Models;

namespace WorkshopManagementSystem.BLL
{
    public class RegistrationService
    {
        private readonly RegistrationRepository _repo = new RegistrationRepository();
        private readonly WorkshopRepository _workshopRepo = new WorkshopRepository();

        public List<Registration> GetRegistrationsByUser(int userId) => _repo.GetByUserId(userId);

        public Registration GetByUserAndWorkshop(int userId, int workshopId) => _repo.GetByUserAndWorkshop(userId, workshopId);

        public bool RegisterForWorkshop(int userId, int workshopId)
        {
            // duplicate?
            var existing = _repo.GetByUserAndWorkshop(userId, workshopId);
            if (existing != null) return false;

            var workshop = _workshopRepo.GetById(workshopId);
            if (workshop == null) return false;

            int registered = _repo.GetCountByWorkshop(workshopId);
            if (registered >= workshop.Capacity) return false;

            return _repo.Add(userId, workshopId);
        }

        public int GetCountByWorkshop(int workshopId) => _repo.GetCountByWorkshop(workshopId);
    }
}
