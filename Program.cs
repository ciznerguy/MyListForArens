using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    internal class Program
    {
        // יש לכתוב פעולה המקבלת רשימה של מספרים שלמים
        // הפעולה תדפיס את כל אברי הרשימה
        // בסוף יודפס נאל
        // null
        public static void PrintList(Node<int> head)
        {
            Node<int> temp = head;
            while (temp != null)
            {
                Console.Write($"{temp.GetValue()} >> ");
                temp = temp.GetNext();
                
            }
            Console.WriteLine("null");
        }
        // יש לכתוב פעולה המקבלת הפניה לרשימה של שלמים
        // הפעולה תחזיר את סכום הרשימה
        public static int SumList(Node<int> head)
        {
            Node<int> temp = head;
            int sum = 0;
            while (temp != null)
            {
                sum += temp.GetValue();
                temp = temp.GetNext();

            }

            return sum;
        }

        // יש לכתוב פעולה המקבלת הפניה לרשימה של תווים ותו
        // הפעולה תחזיר אמת אם התו קיים באחת החוליות
        public static bool IsCharInList(Node<char> head, char ch)
        {
            Node<char> temp = head;
            while (temp != null)
            { 
            if(ch == temp.GetValue())
                {
                    return true;
                }
                temp = temp.GetNext();

            }
            return false;

        }
        // יש לכתוב פעולה המקבלת רשימה של שלמים
        // ומחזירה את הערך האחרון ברשימה

        public static int ReturnLast(Node<int> head)
        {
            Node<int> temp = head;
            while (temp.HasNext())
            {
                temp = temp.GetNext();
            }

            return temp.GetValue();

        }

        public static int FindMax(Node<int> head)
        {
            Node<int> temp = head;
            int max = int.MinValue;
            while (temp != null)
            {
                if (temp.GetValue() > max)
                {
                    max = temp.GetValue(); 
                }
                temp = temp.GetNext();
            }

            return max;
        }
        static void Main(string[] args)
        {
            Node<int> n1 = new Node<int>(25);
            Node<int> n2 = new Node<int>(3);
            Node<int> n3 = new Node<int>(100);
            n1.SetNext(n2);
            n2.SetNext(n3);
            //Console.WriteLine(n3);

            PrintList(n1);

            //int sum = SumList(null);
            //Console.WriteLine(sum);

            //Node<char> c1 = new Node<char>('c');
            //Node<char> c2 = new Node<char>('H');
            //Node<char> c3 = new Node<char>('+');

            //c1.SetNext(c2);
            //c2.SetNext(c3);
            //Console.WriteLine(c1);

            //if (IsCharInList(c1, 'x')==true)
            //{
            //    Console.WriteLine("found");
            //}

            Console.WriteLine(ReturnLast(n1));

        }
    }
}
