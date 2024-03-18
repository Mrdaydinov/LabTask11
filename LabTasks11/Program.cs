namespace LabTasks11
{
    internal class Program
    {

        static void Reverse(string text)
        {
            foreach (var item in text.Reverse())
            {
                Console.Write(item);
            }
        }

        static void Split(string text)
        {
            foreach (var item in text.Split("::"))
            {
                Console.Write(item);
            }

        }

        static void Split2(string text)
        {
            foreach (var item in text.Split(' ', ',', '.', '/'))
            {
                Console.Write(item);
            }
        }

        static void Delete(string text)
        {
            Console.WriteLine(text.Replace("a", ""));
        }

        static void IsPalindrome(string text)
        {
            var revText = text.Reverse().ToArray();
            bool flag = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != revText[i])
                    flag = false;
                    
            }

            Console.WriteLine(flag);
        }



        static void Main(string[] args)
        {
            //Task 1


            //Reverse("Hello");


            //Task 2


            //string text = "a::b::c::d::e";
            //Split(text);


            //Task 3

            //string text = "a b,c.d/e";
            //Split2(text);


            //Task 4

            //string text = "banana";
            //Delete(text);


            //Task 5

            //string text = "hello";
            //string text2 = "radar";

            //IsPalindrome (text);
            //IsPalindrome(text2);
        }
    }
}
