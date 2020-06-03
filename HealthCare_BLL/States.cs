using HealthCare_DAL;
using Models;
using Repositories;
using System.Collections.Generic;
using System.Linq;

namespace HealthCare_BLL
{
    public class States : IStates
    {
        IUnitOfWork unitOfWork;
        IStatesRepository _statesRepository;

        public States(IUnitOfWork unitOfWork, IStatesRepository _statesRepository)
        {
            this.unitOfWork = unitOfWork;
            this._statesRepository = _statesRepository;
        }

        //public State GetStatesById(int id)
        //{
        //    State state;
        //    state = _statesRepository.SingleOrDefault(x => x.Id == id).ToList();
        //    return state;
        //}

        public List<State> GetStatetById(int id)
        {
            List<State> states;
            states = _statesRepository.GetMany(x => x.StateId == id).ToList();
            return states;
        }
    }

    public interface IStates
    {
        //State GetStatesById(int id);
        List<State> GetStatetById(int id);
    }
}