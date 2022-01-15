using System.Linq;

namespace LeetCode.Test;
public class GroupAnagramsTests
{
    [Fact]
    public void ShouldBeEqual_GroupAnagrams()
    {
        var input = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        IList<IList<string>> expected = new string[][] 
                                        { 
                                            new string[] { "ate", "eat", "tea" },
                                            new string[] { "nat", "tan" },
                                            new string[] { "bat" }
                                        };
        var actual = GroupAnagramsProb.GroupAnagrams(input);

        bool compareAll = true;
        foreach(var actualItem in actual)
        {
            var sorted = actualItem.OrderBy(x=>x);
            foreach(var expectedItem in expected)
            {
                if(expectedItem.SequenceEqual(sorted))
                {
                    compareAll = true;
                    break;
                }
                else
                {
                    compareAll &= false;
                }
            }
        }
        Assert.True(compareAll);
    }
}
