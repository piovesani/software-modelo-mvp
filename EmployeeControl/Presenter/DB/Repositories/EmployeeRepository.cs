using EmployeeControl.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeControl.Presenter.DB.Repositories
{
    public class EmployeeRepository
    {
        private readonly DbSet<EmployeeModel> _dbSet;
        private readonly DbContext _context;

        public EmployeeRepository(Context context)
        {
            _context = context;
            _dbSet = context.Set<EmployeeModel>();
        }

        public void Save(EmployeeModel model)
        {
            if(model.Id != default)
            {
                _dbSet.Entry(model).State = EntityState.Modified;
                _dbSet.Update(model);
            }
            else
            {
                _dbSet.Add(model);
            }
            _context.SaveChanges();
        }

        public List<EmployeeModel> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}
