using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using HealthCare_BLL;

namespace HealthCareAppointment.Controllers
{
    public class StatesController : Controller
    {
        IStates _statesBAL;
        
        public StatesController(IStates _stateBAL) 
        {
            this._statesBAL = _stateBAL;
        }

        // GET: States
        //public List<State> GetStateById(int id)
        //{
        //    List<State> _state = new List<State>();
        //    State stateObj = new State();

        //    var obj = _statesBAL.GetStatetById(id);

        //    return obj;
        //}
    }
}