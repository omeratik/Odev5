using Recap.Abstract;
using Recap.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap.Adapters
{
	public class MernisServiceAdapter : IUserCheckService
	{

		public bool CheckIfRealPerson(User user)
		{
			KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
			Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(user.NationalityId), user.FirstName,
				user.LastName, user.DateOfBirth.Year);
			return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
		}
	}
}
