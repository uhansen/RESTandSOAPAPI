using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RESTandSOAPAPI.Models;
using System.ServiceModel;

namespace RESTandSOAPAPI.SoapService
{

    [ServiceContract]
    public interface IAirPressureService
    {
        [OperationContract]
        Response GetAirPresureByPosition(Request request);
    }

    public class AirPressureService : IAirPressureService
    {
        public Response GetAirPresureByPosition(Request request)
        {
            return new Response()
            {
                Pressure = 1008.0
            };
        }
    }
}
