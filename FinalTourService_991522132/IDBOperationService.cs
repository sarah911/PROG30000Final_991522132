using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FinalTourService_991522132
{
    [ServiceContract]
    public interface IDBOperationService
    {
        [OperationContract]
        string InsertATour(User user);

        [OperationContract]
        List<User> RetrieveTourInfo();
    }
}
