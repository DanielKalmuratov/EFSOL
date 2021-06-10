using System;

namespace Block
{
    class Block {
        int int1;
        int int2;
        int int3;
        int int4;

        public Block(int int1, int int2, int int3, int int4)
        {
            this.int1 = int1;
            this.int2 = int2;
            this.int3 = int3;
            this.int4 = int4;
        }

        public override string ToString()
        {
            return $"Стороны блока: {int1}, {int2}, {int3}, {int4}.";
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Block))
            {
                return false;
            }
            Block block = (Block)obj;
            return (this.int1 == block.int1) && (this.int2==block.int2) && (this.int3==block.int3) && (this.int4==block.int4);
        }
        
        public override int GetHashCode()
        {
            return int1 ^ int2 ^ int3 ^ int4;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            Block block1 = new Block(12, 4, 7, 8); 
            Block block2 = new Block(1, 2, 3, 4);

            Console.WriteLine(block1.ToString());
            Console.WriteLine(block2.ToString());

            var res = block1.Equals(block2);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
