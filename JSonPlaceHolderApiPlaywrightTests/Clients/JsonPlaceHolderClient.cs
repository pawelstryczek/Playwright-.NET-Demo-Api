using FluentAssertions;
using JSonPlaceHolderApiPlaywrightTests.Models;
using Microsoft.Playwright;
using static NUnit.Framework.TestContext;

namespace JSonPlaceHolderApiPlaywrightTests.Clients
{
	public class JsonPlaceHolderClient : ClientBase
	{
		public Post ReadPostById(int postId)
		{
			var options = new APIRequestContextOptions();
			//set headers
			options.Headers = new Dictionary<string, string>()
			{
				{ "Content-type", "application/json; charset=UTF-8"}
			};
			var response = request.GetAsync($"{Parameters.Get("webApiUrl")}/posts/{postId}", options).Result;
			//Check if status is 200
			response.Status.Should().Be(200);
			//Deserialize response body
			return response.JsonAsync<Post>().Result;
		}
	}
}
