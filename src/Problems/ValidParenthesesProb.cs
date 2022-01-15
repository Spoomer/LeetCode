namespace LeetCode.Problems;

public class ValidParenthesesProb
{
    public static bool IsValid(string s)
    {
        Stack<char> parenthesesStack = new();
        for (var i = 0; i < s.Length; i++)
        {
            switch (s[i])
            {
                case '(':
                    parenthesesStack.Push(')');
                    break;
                case ')':
                    if (parenthesesStack.Count == 0) return false;
                    if (parenthesesStack.Peek() == ')')
                    {
                        parenthesesStack.Pop();
                        continue;
                    }
                    else return false;
                case '[':
                    parenthesesStack.Push(']');
                    break;
                case ']':
                    if (parenthesesStack.Count == 0) return false;
                    if (parenthesesStack.Peek() == ']')
                    {
                        parenthesesStack.Pop();
                        continue;
                    }
                    else return false;
                case '{':
                    parenthesesStack.Push('}');
                    break;
                case '}':
                    if (parenthesesStack.Count == 0) return false;
                    if (parenthesesStack.Peek() == '}')
                    {
                        parenthesesStack.Pop();
                        continue;
                    }
                    else return false;
                default:
                    break;
            }

        }
        if (parenthesesStack.Count > 0) return false;
        else return true;
    }
}
