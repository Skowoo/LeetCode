using System.Text;

namespace LeetCode.Hard
{
    internal class NumberOfAtoms
    {
        public static string CountOfAtoms(string formula)
        {
            Stack<Dictionary<string, int>> stack = new();
            Dictionary<string, int> atoms = [];
            int i = 0;

            while (i < formula.Length)
            {
                char ch = formula[i];

                if (ch == '(')
                {
                    stack.Push(atoms);
                    atoms = [];
                    i++;
                }
                else if (ch == ')')
                {
                    i++;
                    int start = i;
                    int multiplicity = 1;
                    if (i < formula.Length && char.IsDigit(formula[i]))
                    {
                        while (i < formula.Length && char.IsDigit(formula[i]))
                            i++;

                        multiplicity = int.Parse(formula[start..i]);
                    }

                    if (stack.Count > 0)
                    {
                        Dictionary<string, int> tempMap = atoms;
                        atoms = stack.Pop();
                        foreach (var key in tempMap.Keys)
                        {
                            if (atoms.ContainsKey(key))
                                atoms[key] += tempMap[key] * multiplicity;
                            else
                                atoms[key] = tempMap[key] * multiplicity;
                        }
                    }
                }
                else
                {
                    int start = i;

                    i++;

                    while (i < formula.Length && char.IsLower(formula[i]))
                        i++;

                    string element = formula[start..i];
                    start = i;

                    while (i < formula.Length && char.IsDigit(formula[i]))
                        i++;

                    int count = start < i ? int.Parse(formula[start..i]) : 1;

                    if (atoms.ContainsKey(element))
                        atoms[element] += count;
                    else
                        atoms[element] = count;
                }
            }

            StringBuilder result = new();
            foreach (var entry in atoms.OrderBy(x => x.Key))
            {
                result.Append(entry.Key);
                if (entry.Value > 1)
                    result.Append(entry.Value);
            }

            return result.ToString();
        }
    }
}
