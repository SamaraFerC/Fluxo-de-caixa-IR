using FluxoCaixa.Domain.Entities;

namespace FluxoCaixa.Domain.Interfaces
{
    public interface IActivity
    {
       IEnumerable<Activity> GetAllActivities();

    }
}
