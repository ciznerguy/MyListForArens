using MyQueueForThelma;
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


        // פעולה המקבלת רשימה של מספרים שלמים
        // מחזירה את אורכה
        
        public static int LengthOfList(Node<int> head)
        {
            Node<int> temp = head;
            int length = 0;
            while (temp != null)
            {
                length++;
                temp = temp.GetNext();
            }
            return length;
        }

        // 6
        // remove the element at a specific position in the list
        // param1 : Node<int>
        // param2 : int (position)
        // return : Node<int>
        // example: param1: ->1->2->3->4, param2: 2, return: ->1->3->4
        // example: param1: ->1->2->3->4, param2: 1, return: ->2->3->4
        public static Node<int> RemoveAtPosition(Node<int> lst, int position)
        {
            if (position < 0)
            {
                return lst;
            }
            if (LengthOfList(lst) < position)
            {
                return lst;
            }
            if (position == 1)
            {
                return lst.GetNext();
            }
            Node<int> temp = lst;
            for (int i = 1; i < position - 1; i++)
            {
                temp = temp.GetNext();
            }
            temp.SetNext(temp.GetNext().GetNext());
            return lst;



        }


        // יש לכתוב פעולה המקבלת מספר רנדומלי
        // הפעולה תחזיר רשימה חדשה באורך הנתון
        // המכילה מספרים רנדומליים בין 1 ל-100
        // סדר הפתרון
        // 1. יצירת אובייקט מסוג Random
        // 2.יצירת חוליה ראשונה שתהא ראש הרשימה
        // 3.לולאה שרצה עד לאורך המבוקש
        // 4. בתוך הלולאה יצירת מספר רנדומלי ויצירת חוליה להוספה
        // 5. החזרת ראש הרשימה

        // רמז לא לשכוח לא לאבד את הראש של הרשימה
        public static Node<int> CreateRandomList(int length)
        {
            Random rand = new Random();
            // הגדרת חוליית דמי
            // לעיתים נבנה חוליית דמי כדי לא לאבד את הראש של הרשימה
            Node<int> head = new Node<int>(-99);
            Node<int> temp = head;
            for (int i = 0; i < length; i++)
            {   int num = rand.Next(1,101);
                Node<int> newNode = new Node<int>(num);
                temp.SetNext(newNode);
                temp = temp.GetNext() ;
            }
            return head.GetNext();
        }


        // יש לכתוב פעולה המקבלת רשימה של מספרים שלמים
        // הפעולה תחזיר רשימה חדשה של כל המספרים הזוגיים ברשימה המקורית

        public static Node<int> GetEvenNumbers(Node<int> head)
        {
            Node<int> dummyHead = new Node<int>(-1);
            Node<int> tempNewList = dummyHead;
            Node<int> tempOriginalList = head;
            while (tempOriginalList != null)
            {
                if (tempOriginalList.GetValue() % 2 == 0)
                {
                    Node<int> newNode = new Node<int>(tempOriginalList.GetValue());
                    tempNewList.SetNext(newNode);
                    tempNewList = tempNewList.GetNext();
                }
                tempOriginalList = tempOriginalList.GetNext();
            }
            return dummyHead.GetNext();
        }


        // יש לכתוב פעולה המקבלת רשימה של אבני דומינו
        // הפעולה תחזיר רשימה חדשה של אבני הדומינו שסכומן 7
        public static Node<Domino> DominoSumSeven(Node<Domino> head)
        {
            Node<Domino> temp = head;
            Node<Domino> dummyHead = new Node<Domino>(null);
            Node<Domino> current = dummyHead;
            while (temp != null)
            {
                if(temp.GetValue().GetLeft()+temp.GetValue().GetRight() == 7)
                {
                    Node<Domino> newNode = new Node<Domino>(temp.GetValue());
                    current.SetNext(newNode);
                    current = current.GetNext();
                }
                temp = temp.GetNext();
            }
            return dummyHead.GetNext();
        }

        // יש לכתוב פעולה המקבלת רשימה של תלמידים
        //  מחלקת תלמיד כוללת שם, תז, מערך של 10 ציונים
        // הפעולה תחזיר רשימה חדשה של שמות תלמידים שהממוצע שלהם מעל 75 


        public static Node<string> GetTopStudents(Node<Student> head)
        {
            Node<Student> temp = head;
            Node<string> dummyHead = new Node<string>(null);
            Node<string> current = dummyHead;
            while (temp != null)
            {
                if (temp.GetValue().GetAverage() > 75)
                {
                    Node<string> newNode = new Node<string>(temp.GetValue().GetName());
                    current.SetNext(newNode);
                    current = current.GetNext();
                }
                temp = temp.GetNext();
            }
            return dummyHead.GetNext();
        }
        static void Main(string[] args)
        {
           // Node<int> n1 = new Node<int>(25);
           // Node<int> n2 = new Node<int>(3);
           // Node<int> n3 = new Node<int>(100);
           // n1.SetNext(n2);
           // n2.SetNext(n3);
           // Console.WriteLine(n3);

           ////  PrintList(n1);

           // int sum = SumList(n1);
           // Console.WriteLine(sum);

           // Node<char> c1 = new Node<char>('c');
           // Node<char> c2 = new Node<char>('H');
           // Node<char> c3 = new Node<char>('+');

           // c1.SetNext(c2);
           // c2.SetNext(c3);
           // Console.WriteLine(c1);

           // if (IsCharInList(c1, 'x')==true)
           // {
           //     Console.WriteLine("found");
           // }

           // Console.WriteLine(ReturnLast(n1));

            Domino d1 = new Domino(3,4);
            Domino d2 = new Domino(2,5);
            Domino d3 = new Domino(6,2);

            Node<Domino> dom1 = new Node<Domino>(d1);
            //Console.WriteLine(d1.GetLeft());
            //Console.WriteLine(dom1.GetValue());

            Node<Domino> dom2 = new Node<Domino>(d2);
            dom1.SetNext(dom2);

            Node<Domino> dom3 = new Node<Domino>(d3);
            dom2.SetNext(dom3);
            Console.WriteLine(dom1);


        }
    }
}
