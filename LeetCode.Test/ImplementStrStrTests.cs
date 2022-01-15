namespace LeetCode.Test;

public class ImplementStrStrTests
{
    [Fact]
    public void ImplementStrStrTest1()
    {
        ImplementStrStrProb str = new();
        Assert.Equal(2, str.StrStr("hello", "ll"));
    }
    [Fact]
    public void ImplementStrStrTest2()
    {
        ImplementStrStrProb str = new();
        Assert.Equal(-1, str.StrStr("aaaa", "aab"));
    }
    [Fact]
    public void ImplementStrStrTest3()
    {
        ImplementStrStrProb str = new();
        Assert.Equal(0, str.StrStr("", ""));
    }
    [Fact]
    public void ImplementStrStrTest4()
    {
        ImplementStrStrProb str = new();
        Assert.Equal(6, str.StrStr("asdasdab", "ab"));
    }
}
