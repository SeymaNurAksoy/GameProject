using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adaptor
{
    public  class MernisAdapter:ICustomerCheckService
    {
      

        public bool CheckIfRealPersonel(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
                customer.NationalyId, customer.FirstName, customer.LastName, customer.Birthday))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
