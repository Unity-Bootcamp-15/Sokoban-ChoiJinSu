namespace sokoban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            // 콘솔을 가지고 게임을 만들어보자
            // 콘솔의 여러기능을 알아보자 > Console 라이브러리를 가보자(f1)

            // 게임의 타이틀씬 > 로딩중 
            // 게임을 초기화하는 과정
            Console.ResetColor(); // 색상초기화
            Console.Clear(); // 콘솔 속 내용 초기화
            //색깔 조정
            Console.BackgroundColor = ConsoleColor.Blue; // 뒷배경
            Console.ForegroundColor = ConsoleColor.White; // 글씨
            // 제목 수정
            Console.Title = "Sokoban";
            //Console.WriteLine(Console.Title);
            // 커서도 숨겨야 함
            Console.CursorVisible = false;


            




            while (true)
            {

            }
        }
    }
}
