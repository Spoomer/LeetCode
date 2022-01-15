using System.Text;

namespace LeetCode.Test;

internal class Tools
{

    public static string[] GetArrayFromString(string arrayString)
    {
        List<string> list = new();
        for (int i = 0; i < arrayString.Length; i++)
        {
            if (arrayString[i] == '[' || arrayString[i] == ']')
            {
                continue;
            }
            if (arrayString[i] == '\"')
            {
                i++;
                StringBuilder sb = new(10);
                while (arrayString[i] != '\"')
                {
                    sb.Append(arrayString[i]);
                    i++;
                }
                list.Add(sb.ToString());
            }
        }
        return list.ToArray();
    }
}
