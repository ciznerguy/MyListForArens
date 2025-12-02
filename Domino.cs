using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueForThelma
{
    public class Domino
    {   
        private int left;
        private int right;
        public Domino(int left, int right)
        {
            this.left = left;
            this.right = right;
        }
        public int GetLeft()
        {
            return left;
        }
        public int GetRight()
        {
            return right;
        }
        public void SetLeft(int left)
        {
            this.left = left;
        }
        public void SetRight(int right)
        {
            this.right = right;
        }

        public override string ToString()
        {
            return $"[{this.left}|{this.right}]";
        }
        
    }
}
