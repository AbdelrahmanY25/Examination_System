namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            int numOfQ;
            do {
                Console.Write("Choose Between Teacher Or Student Select [T - S]  ");
                ch = char.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 't':
                    case 'T':
                        Console.Write("How Many Questions You Want  ");
                        try
                        {
                            numOfQ = int.Parse(Console.ReadLine());
                            if (numOfQ > 0 && numOfQ < 25)
                            {
                                Console.WriteLine("\n================= Start Set Queation =================");
                                Questions q = new Questions(DateTime.Now, numOfQ);
                                q.StartExam();

                                Console.WriteLine("\n================= Start Answering =================\n");
                                Response re = new Response(DateTime.Now, numOfQ); 
                                re.StartExam();
                            }
                            else
                            {
                                throw new Exception("Invaled Input You Must Enter Number Between 1 and 25");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);   
                        }
                        break;
                }
            } while (ch != 't' && ch != 'T');

        }
    }
}
