using JSonPlaceHolderApiPlaywrightTests.Models;

namespace JSonPlaceHolderApiPlaywrightTests.TestData
{
	public static class PostData
	{
		public static Post GetExpectedPost()
		{
			return new Post()
			{
				userId = 1,
				id = 1,
				title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
				body = "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
			};
		}
	}
}