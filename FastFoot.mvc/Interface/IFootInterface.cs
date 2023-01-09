using FastFoot.mvc.Models;

namespace FastFoot.mvc.Interface
{
    public interface IFootInterface
    {
        List<Foot> GetAllFoots();
        Foot GetById(Guid footId);
        Foot AddFoot(Foot foot);
        Foot UpdateFoot(Foot foot);
        void DeleteFoot(int id);
    }
}
