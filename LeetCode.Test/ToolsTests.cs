namespace LeetCode.Test;
public class ToolsTests
{
    [Fact]
    public void ShouldBeEqual_GetArrayFromString()
    {
        string arrayAsString = "[\"eat\",\"tea\",\"tan\",\"ate\",\"nat\",\"bat\"]";
        var expected = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        var actual = Tools.GetArrayFromString(arrayAsString);
        Assert.Equal(expected, actual);
    }
}
