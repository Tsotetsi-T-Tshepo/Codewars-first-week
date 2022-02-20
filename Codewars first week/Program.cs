using System;
using System.Collections.Generic;
using System.Linq;

namespace First_week_of_CodeWares
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES FOR TEST CASES
            string testStringPoper = "Test string";
            string testStringIrregular = "tEst@ str1ng>|";
            int[] intArrayNonNegative = { 21, 242, 12, 4, 65, 2, 3, 5, 76, 43, 9, 0, 2, 3, 4, 5, 67, 0, 0, 0, 546 };
            int[] intArrayNegative = { -21, 242, 12, 4, 65, 2, -3, 5, 76, -43, -9, 0, 2, 3, -4, -5, -67, 0, 0, 0, 546 };
            string[] stringArray = { "cat", "dog", "bird", "fish", "Majid", "Makensie", "Makenzie", "Makin", "Maksim", "Maksymilian", "Malachai", "Malachi", "Malachy", "Malakai", "Raees", "Raegan", "Rafael", "Rafal", "Rafferty", "Rafi" };
            List<object> alphaNumericList = new List<object> { 1, 2, "a", "b", "aasf", "1", "123", 231 };
            List<int> intList = new List<int> { 1, 2, 4, 57, 76, 4, 23, 3, 5, 7, 9, 8, 54, 32, 23, 231 };
            List<string> stringList = new List<string> { "awaken", "alien", "bat", "air", "1", "123", "Toast" };
            
            //TEST CASES
            Console.WriteLine($"Square sum: {Kata.SquareSum(intArrayNonNegative)}");
            Console.WriteLine($"\nRemove first and last charater: {Kata.Remove_char(testStringPoper)}");
            Console.WriteLine($"\nList filtering: ");
            foreach (int number in Kata.GetIntegersFromList(alphaNumericList))
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine($"\n\nSum of two lowest positive intergers: {Kata.sumTwoSmallestNumbers(intArrayNonNegative)}");
            Console.WriteLine($"\nFriend or foe: ");
            foreach (string name in Kata.FriendOrFoe(stringArray))
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine($"\n\nBinary addition: {Kata.AddBinary(1, 4)}");
            Console.WriteLine($"\nArray diffrence: ");
            foreach (int num in Kata.ArrayDiff(new[] { 12, 1, 3, 4 }, new[] { 12, 1, 4, 6 }))
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine($"\n\nFind unique number: {Kata.GetUnique(new[] { 1, 2, 2, 2 })}");
            Console.WriteLine($"\nWho likes it: {Kata.Likes(stringArray)}");
            Console.WriteLine($"\nReplace with alphabet position: {Kata.AlphabetPosition(testStringPoper)}");
            Console.WriteLine($"\nDetect pangram: {Kata.IsPangram("The quick brown fox jumps over the lazy dog")}");
            Console.WriteLine($"\nBit counting: {Kata.CountBits(12)}");
            Console.WriteLine($"\nDuplicate encoder: {Kata.DuplicateEncode(testStringPoper)}");
            Console.WriteLine($"\nSum of digits/ digital root: {Kata.DigitalRoot(12312412412)}");
            Console.WriteLine($"\nRot13 cypher: {Kata.Rot13("Gur dhvpx oebja sbk whzcf bire 13 ynml qbtf.")}");
            Console.WriteLine($"\nMoving zeroes to the end: ");
            foreach (int num in Kata.MoveZeroes(new[] { 1, 23, 4, 0, 0, 0, 2, 3 }))
            {
                Console.Write($"{num} ");
            }

            Console.ReadKey();
        }
    }
    class Kata
    {
        #region Square sum
        //https://www.codewars.com/kata/515e271a311df0350d00000f (8 kyu) Square(n) Sum
        public static int SquareSum(int[] n)
        {
            return n.Sum(num => Convert.ToInt32(Math.Pow(Convert.ToDouble(num), 2)));

        }
        #endregion

        #region Remove First and Last Character
        //https://www.codewars.com/kata/56bc28ad5bdaeb48760009b0 (8 kyu) Remove First and Last Character
        public static string Remove_char(string s)
        {
            return s.Substring(1, s.Length - 2);
        }
        #endregion

        #region List Filtering
        //https://www.codewars.com/kata/53dbd5315a3c69eed20002dd (7 kyu) List Filtering
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            var list = listOfItems.Where(item => item.GetType() == typeof(int)).ToList();
            var newList = list.Cast<int>().ToList();
            return newList;
        }
        #endregion

        #region Sum of two lowest positive integers
        //https://www.codewars.com/kata/558fc85d8fd1938afb000014 (7 kyu) Sum of two lowest positive integers
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            List<int> list = new List<int>(numbers);
            int min1 = list.Min();
            list.Remove(min1);
            int min2 = list.Min();
            return min1 + min2;
        }
        #endregion

        #region Friend or Foe
        //https://www.codewars.com/kata/55b42574ff091733d900002f (7 kyu) Friend or Foe
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> friends = new List<string>();
            foreach (string name in names)
            {
                if (name.Length == 4)
                {
                    friends.Add(name);
                }
            }
            return friends;
        }
        #endregion

        #region Binary Addition
        //https://www.codewars.com/kata/551f37452ff852b7bd000139 (7 kyu) Binary Addition
        public static string AddBinary(int a, int b)
        {
            return $"{Convert.ToString((a + b), 2)}";
        }
        #endregion

        #region Array.diff
        //https://www.codewars.com/kata/523f5d21c841566fde000009 (6 kyu) Array.diff
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> list = new List<int>();
            foreach (int i in a)
            {
                if (b.Contains(i) == false)
                {
                    list.Add(i);
                }
            }
            int[] array = list.ToArray();
            return array;
        }
        #endregion

        #region Find the Unique Number
        //https://www.codewars.com/kata/585d7d5adb20cf33cb000235 (6 kyu) Find The Unique Number
        public static int GetUnique(IEnumerable<int> numbers)
        {
            int first = 0, firstValue = 0, second = 0, secondValue = 0, count = 0;
            HashSet<int> set = new HashSet<int>(numbers.Distinct());

            foreach (int i in set)
            {
                if (count == 0)
                {
                    firstValue = i;
                    first = numbers.Where(c => c == i).Count();
                    count++;
                }
                else
                {
                    secondValue = i;
                    second = numbers.Where(c => c == i).Count();
                }
            }
            return first > second ? secondValue : firstValue;
        }
        #endregion

        #region Who likes it
        //https://www.codewars.com/kata/5266876b8f4bf2da9b000362 (6 kyu) Who Likes It?
        public static string Likes(string[] name)
        {
            int count = name.Length;
            if (count == 0)
            {
                return "no one likes this";
            }
            else if (count == 1)
            {
                return $"{name[0]} likes this";
            }
            else if (count == 2)
            {
                return $"{name[0]} and {name[1]} like this";
            }
            else if (count == 3)
            {
                return $"{name[0]}, {name[1]} and {name[2]} like this";
            }
            else
            {
                return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
        }
        #endregion

        #region Replace With Alphabet Position
        //https://www.codewars.com/kata/546f922b54af40e1e90001da (6 kyu) Replace With Alphabet Position
        public static string AlphabetPosition(string text)
        {
            char[] textArr = text.Where(letter => Char.IsLetter(letter)).ToArray();
            string newText = new string(textArr);
            text = newText.ToLower();

            #region Alphabet Position dictionary
            Dictionary<int, char> alphabets = new Dictionary<int, char>();
            alphabets.Add(1, 'a');
            alphabets.Add(2, 'b');
            alphabets.Add(3, 'c');
            alphabets.Add(4, 'd');
            alphabets.Add(5, 'e');
            alphabets.Add(6, 'f');
            alphabets.Add(7, 'g');
            alphabets.Add(8, 'h');
            alphabets.Add(9, 'i');
            alphabets.Add(10, 'j');
            alphabets.Add(11, 'k');
            alphabets.Add(12, 'l');
            alphabets.Add(13, 'm');
            alphabets.Add(14, 'n');
            alphabets.Add(15, 'o');
            alphabets.Add(16, 'p');
            alphabets.Add(17, 'q');
            alphabets.Add(18, 'r');
            alphabets.Add(19, 's');
            alphabets.Add(20, 't');
            alphabets.Add(21, 'u');
            alphabets.Add(22, 'v');
            alphabets.Add(23, 'w');
            alphabets.Add(24, 'x');
            alphabets.Add(25, 'y');
            alphabets.Add(26, 'z');
            #endregion
            for (int i = 0; i < text.Length; i++)
            {
                foreach (KeyValuePair<int, char> item in alphabets)
                {
                    if (text[i] == item.Value)
                    {
                        text = text.Replace(text[i].ToString(), item.Key.ToString() + " ");
                    }
                }
            }
            return text.Trim(' ');
        }
        #endregion

        #region Detect Pangram
        // https://www.codewars.com/kata/545cedaa9943f7fe7b000048 (6 kyu) Detect Pangram
        public static bool IsPangram(string str)
        {
            str = str.ToLower();
            #region Alpahbets HashSet
            HashSet<char> alphabets = new HashSet<char>();
            alphabets.Add('a');
            alphabets.Add('b');
            alphabets.Add('c');
            alphabets.Add('d');
            alphabets.Add('e');
            alphabets.Add('f');
            alphabets.Add('g');
            alphabets.Add('h');
            alphabets.Add('i');
            alphabets.Add('j');
            alphabets.Add('k');
            alphabets.Add('l');
            alphabets.Add('m');
            alphabets.Add('n');
            alphabets.Add('o');
            alphabets.Add('p');
            alphabets.Add('q');
            alphabets.Add('r');
            alphabets.Add('s');
            alphabets.Add('t');
            alphabets.Add('u');
            alphabets.Add('v');
            alphabets.Add('w');
            alphabets.Add('x');
            alphabets.Add('y');
            alphabets.Add('z');
            #endregion
            foreach (char letter in alphabets)
            {
                if (!str.Contains(letter))
                {
                    return false;
                }
            }

            return true;
        }
        #endregion

        #region Bit Counting
        //https://www.codewars.com/kata/526571aae218b8ee490006f4 (6 kyu) Bit Counting
        public static int CountBits(int n)
        {
            return (Convert.ToString(n, 2)).Where(c => c == '1').Count();
        }
        #endregion
        #region Duplicate Encoder
        //https://www.codewars.com/kata/541c8630095125aba6000c00 (6 kyu) Duplicate Encoder
        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();
            string newWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                newWord += word.Remove(i, 1).Contains(word[i]) ? ')' : '(';
            }
            return newWord;
        }
        #endregion

        #region Sum of Digits / Digital Root
        //https://www.codewars.com/kata/541c8630095125aba6000c00 (6 kyu) Sum of Digits/Digital Root
        public static int DigitalRoot(long n)
        {
            long j = 0;

            if (n > 10)
            {
                do
                {
                    j += (n % 10);
                    n = n / 10;
                } while (n > 10);
                j += (n);
                n = j;
                return DigitalRoot(n);
            }
            else if (n == 10)
            {
                return Convert.ToInt16(n / 10);
            }
            return Convert.ToInt16(n);
        }
        #endregion

        #region Rot13
        //https://www.codewars.com/kata/530e15517bc88ac656000716 (6 kyu) Rot13
        public static string Rot13(string message)
        {
            // your code here
            string newMesg = "";

            List<char> rot13_1 = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M' };
            List<char> rot13_2 = new List<char> { 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };


            List<char> rot13_3 = new List<char> { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm' };
            List<char> rot13_4 = new List<char> { 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            foreach (char i in message)
            {
                int temp;
                if (rot13_1.Contains(i))
                {
                    temp = rot13_1.IndexOf(i);
                    newMesg += rot13_2[temp];
                }
                else if (rot13_2.Contains(i))
                {
                    temp = rot13_2.IndexOf(i);
                    newMesg += rot13_1[temp];
                }
                else if (rot13_3.Contains(i))
                {
                    temp = rot13_3.IndexOf(i);
                    newMesg += rot13_4[temp];
                }
                else if (rot13_4.Contains(i))
                {
                    temp = rot13_4.IndexOf(i);
                    newMesg += rot13_3[temp];
                }
                else
                {
                    newMesg += i;
                }

            }
            return newMesg;
        }
        #endregion

        #region Moving Zeroes To The End
        //https://www.codewars.com/kata/52597aa56021e91c93000cb0 (5 kyu) Moving Zero To The End
        public static int[] MoveZeroes(int[] arr)
        {
            int noZeroes = arr.Count(c => c == 0);
            List<int> list = new List<int>(arr);

            list.RemoveAll(c => c == 0);
            while (noZeroes > 0)
            {
                list.Add(0);
                noZeroes--;
            }
            int[] moved = list.ToArray();
            return moved;
        }
        #endregion
    }
}
