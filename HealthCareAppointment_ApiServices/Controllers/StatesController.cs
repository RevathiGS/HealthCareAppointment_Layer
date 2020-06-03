using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Models;
using HealthCare_BLL;

namespace HealthCareAppointment_ApiServices.Controllers
{
    public class StatesController : ApiController
    {
        IStates _statesBAL;
        public StatesController(IStates _stateBAL)
        {
            this._statesBAL = _stateBAL;
        }

        [HttpGet]
        public List<State> GetStateById(int id)
        {
            List<State> _state = new List<State>();
            State stateObj = new State();


            return _state;
        }
    }
}
