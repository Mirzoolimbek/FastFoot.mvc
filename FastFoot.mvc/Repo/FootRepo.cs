using FastFoot.mvc.DataLayer;
using FastFoot.mvc.Interface;
using FastFoot.mvc.Models;

namespace FastFoot.mvc.Repo
{
    public class FootRepo : IFootInterface
    {
        private DataContext _datacontext;

        public FootRepo(DataContext dataContext)
        {
            _datacontext = dataContext; 
        }
        public Foot AddFoot(Foot foot)
        {
           _datacontext.Foots.Add(foot);
           _datacontext.SaveChanges();
            return foot;
        }

        public void DeleteFoot(int id)
        {
           var foot = _datacontext.Foots.FirstOrDefault(f => f.Id == id);
            _datacontext.Foots.Remove(foot);
            _datacontext.SaveChanges();
        }

        public List<Foot> GetAllFoots()
        {
           var allFoots = _datacontext.Foots.ToList();
            return allFoots;
        }

        public Foot GetById(Guid footId)
        {
            var foot = _datacontext.Foots.FirstOrDefault(f =>f.Id == footId);
            return foot;
        }

        public Foot UpdateFoot(Foot foot)
        {
            _datacontext.Foots.Update(foot);
            _datacontext.SaveChanges();
            return foot;
        }
    }
}
