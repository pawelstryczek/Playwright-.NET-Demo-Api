using FluentAssertions;
using static JSonPlaceHolderApiPlaywrightTests.TestData.PostData;
namespace JSonPlaceHolderApiPlaywrightTests;

public class JSonPlaceHolderApiTests : TestBase
{
    [Test]
    public void GetPostTest()
    {
		//Arrange
		var expectedPost = GetExpectedPost();

        //Act
        var post = ApiClient.ReadPostById(postId:1);

		//Assertions
        post.Should().NotBeNull();
        post.title.Should().Be(expectedPost.title);
        post.body.Should().Be(expectedPost.body);
        post.id.Should().Be(expectedPost.id);
        post.userId.Should().Be(expectedPost.userId); 
	}
}