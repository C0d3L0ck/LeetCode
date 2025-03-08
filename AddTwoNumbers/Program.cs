using System;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode Algorithm = new();
        List<ListNode> ListNodes = new();
        ListNode Output = new();
        string suml1 = "";
        string suml2 = "";
        while ((l1 != null || l2 != null))
        {

            if (l1 != null)
            {
                suml1 += l1.val.ToString();
                Algorithm.next = l1.next;
                l1 = Algorithm.next;
            }


            if (l2 != null)
            {
                suml2 += l2.val.ToString();
                Algorithm.next = l2.next;
                l2 = Algorithm.next;
            }
        }

        int total = int.Parse(suml1) + int.Parse(suml2);

        string ConvertingToNode = total.ToString();
        char[] Vuelta = ConvertingToNode.ToCharArray();
        Array.Reverse(Vuelta);

        string Volteado = new string(Vuelta);

        int[] enteros = new int[Volteado.Length];


        for (int i = 0; i < Volteado.Count(); i++)
        {
            enteros[i] = int.Parse(Volteado[i].ToString());
            ListNode trueList = new ListNode(enteros[i], null);
            ListNodes.Add(trueList);
        }

        for (int i = 0; i != ListNodes.Count; i++)
        {
            if (i == ListNodes.Count - 1)
                break;
            else
                ListNodes[i].next = ListNodes[i + 1];

        }
        Output = ListNodes.FirstOrDefault();
        return Output;
    }

}


class Program
{
    static void Main(string[] args)
    {
        ListNode l2 = new ListNode(9,
                 new ListNode(9,
                     new ListNode(9,
                         new ListNode(9,
                             new ListNode(9,
                                 new ListNode(9,
                                     new ListNode(9)))))));

       
        ListNode l1 = new ListNode(9,
                        new ListNode(9,
                            new ListNode(9,
                                new ListNode(9))));

        Solution solution = new Solution();

        ListNode Output = solution.AddTwoNumbers(l1, l2);

        Console.WriteLine($"{Output.val} + {Output.next}");
    }
}
