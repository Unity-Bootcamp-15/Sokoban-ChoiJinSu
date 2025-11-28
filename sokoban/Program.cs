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
            Console.Clear();


            int currentXPosition = 5;
            int currentYPosition = 10;
            int newXPosition;
            int newYPosition;

            Console.SetCursorPosition(5, 10);
            Console.Write("%");


            while (true) { 

            ConsoleKeyInfo keyInfo = Console.ReadKey();// 키를 입력 받았다
                if (Console.GetCursorPosition().Left >= Console.BufferWidth || Console.GetCursorPosition().Top >= Console.BufferHeight) { 
            
                        if (keyInfo.Key == ConsoleKey.DownArrow)
                        {
                           // 아래로간다 > Y가 증가 
                           newXPosition = currentXPosition;
                           newYPosition = ++currentYPosition;

                                Console.Clear();
                                Console.SetCursorPosition(newXPosition, newYPosition);
                                Console.Write("%");

                        }
                        else if (keyInfo.Key == ConsoleKey.UpArrow)
                            {
                                //위로 간다 > Y가 감소 
                                newXPosition = currentXPosition;
                                newYPosition = --currentYPosition;

                                Console.Clear();
                                Console.SetCursorPosition(newXPosition, newYPosition);
                                Console.Write("%");

                        }
                        else if (keyInfo.Key == ConsoleKey.LeftArrow)
                        {
                            // 왼쪽으로 > X가 감소
                            newXPosition = --currentXPosition;
                            newYPosition = currentYPosition;

                            Console.Clear();
                            Console.SetCursorPosition(newXPosition, newYPosition);
                            Console.Write("%");

                        }
                        else if (keyInfo.Key == ConsoleKey.RightArrow)
                        {
                            // 오른쪽으로 > X가 증가 
                            newXPosition = ++currentXPosition;
                            newYPosition = currentYPosition;

                            Console.Clear();
                            Console.SetCursorPosition(newXPosition, newYPosition);
                            Console.Write("%");


                        // 벽을 만들어라
                        for(int i = 0; i <  30; i++)
                        {
                            Console.Write('■');
                        }
                        

                        }
                 }
            }
        }
    }
}
