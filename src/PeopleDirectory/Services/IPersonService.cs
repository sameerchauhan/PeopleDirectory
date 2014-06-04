﻿using System.Collections.Generic;
using System.ServiceModel;

namespace Services
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        List<PersonDto> GetListOfPeople();

        [OperationContract]
        PersonDetailsDto GetPersonDetails(string name);
    }
}
