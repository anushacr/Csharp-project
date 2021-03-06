using CityBusManagment.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusManagment.DAL.Repository
{
    public interface IBusStopRepository
    {
        public void AddBusStop(BusStop busstop);
        public void UpdateBusStop(BusStop busstop);
        public void DeleteBusStop(int routeNo);
        public BusStop GetBusNo(int busNo);
        IEnumerable<BusStop> GetBusStop();
    }
}
