using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreDemo
{
    class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(gamer.NationalityId, gamer.FirstName, gamer.LastName, gamer.BirthYear).Result;
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
