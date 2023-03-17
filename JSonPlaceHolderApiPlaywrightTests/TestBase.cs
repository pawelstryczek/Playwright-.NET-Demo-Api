using JSonPlaceHolderApiPlaywrightTests.Clients;

namespace JSonPlaceHolderApiPlaywrightTests;

public abstract class TestBase
{
    protected JsonPlaceHolderClient ApiClient;

	[SetUp]
	public void Setup() => ApiClient = new JsonPlaceHolderClient();
}