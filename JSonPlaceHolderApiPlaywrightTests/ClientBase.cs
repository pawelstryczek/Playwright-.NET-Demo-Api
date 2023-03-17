
using Microsoft.Playwright;

namespace JSonPlaceHolderApiPlaywrightTests
{
	public abstract class ClientBase
	{
		protected IPlaywright playwright;
		protected IAPIRequestContext request;

		public ClientBase() 
		{
			playwright = Playwright.CreateAsync().Result;
			request = playwright.APIRequest.NewContextAsync().Result;
		}
	}
}
