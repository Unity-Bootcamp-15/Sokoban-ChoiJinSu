namespace sokoban
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 키 입력 처리
            // - 방향키를 누르면 방향키의 방향으로 플레이어가 이동합니다.
            // 일단 단순한 케이스 > 즉 한 방향부터 먼저 하자

            // 데이터를 다루자 > ~ 을 때 > ~한다면 > if
            // 아래 방향키를 누른다. > 아래 방향키가 눌렸는가? > ConsoleKeyInfo.key가 그 키가 맞는지 확인 한다 > 아래방향키를 담은 값
            // 1. 아래 방향키를 눌렀을 때 (이건 자연어)
            // 아래 방향키 > 키를 어떻게 입력 받지? >> Console.ReadKey();
            // 키를 입력받는 기능이 있는지 체크 > Console class에서 찾자 > readkey() >
            ConsoleKeyInfo keyInfo = Console.ReadKey();// 키를 입력 받았다
                                                       // 키 입력 받았어. 근데 이게 아래방향키인지 어찌 알아? > 판별해야겠네 > 동위연산자 ==
                                                       // 컴퓨터가 알아듣는 건 연산자 > keyInfo 속의 key를 확인해야한다
                                                       // ConsoleKeyInfo.key가 현재 누른 데이터가 있겠다
                                                       // (keyInfo.key) == (아래방향키 > 이걸 어떻게 알지??)
                                                       // > 일단 key컴포넌트가 ConsoleKey니까 같으려면 같은 타입 이어야 겠네 > 번호키가 Consolekey에 키를 받는 컴포넌트가 있네 
                                                       // keyInfo.Key == ConsoleKey.DownArrow;
                                                       // 라면 이라 했으니 선택문으로 가야한다
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {

                // 1-1 .플레이어가 아래로 이동하게 해라 => 
                // 이동이라는 건 좌표가 바뀐다는 거지 > 그럼 x,y좌표가 필요하겠네 > 좌표 어떻게 구해?? > Y값을 담아줘야겠네
                // 아래로 가려면 y값이 커져야해 > ++
                //y = y + 1; //++y , y += 1

                // 어? 캐릭터가 없네? > 다시 그려줘야해


            }
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {

                // 1-1 .플레이어가 아래로 이동하게 해라 => 
                // 이동이라는 건 좌표가 바뀐다는 거지 > 그럼 x,y좌표가 필요하겠네 > 좌표 어떻게 구해?? > Y값을 담아줘야겠네
                // 아래로 가려면 y값이 커져야해 > ++
                //y = y - 1;

            }
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {

                // 1-1 .플레이어가 아래로 이동하게 해라 => 
                // 이동이라는 건 좌표가 바뀐다는 거지 > 그럼 x,y좌표가 필요하겠네 > 좌표 어떻게 구해?? > Y값을 담아줘야겠네
                // 아래로 가려면 y값이 커져야해 > ++
                x = x - 1;

            }
            if (keyInfo.Key == ConsoleKey.RightArrow)
            {

                // 1-1 .플레이어가 아래로 이동하게 해라 => 
                // 이동이라는 건 좌표가 바뀐다는 거지 > 그럼 x,y좌표가 필요하겠네 > 좌표 어떻게 구해?? > Y값을 담아줘야겠네
                // 아래로 가려면 y값이 커져야해 > ++
                x = x + 1;

            }

            // 결국 프로그래머는 사람이 한 말을 컴퓨터가 이해할 수 있게 바꾸는 것 > 통역가라 봐도 무방
            // 어떤 데이터에 무슨 연산을 할 것인가? 이걸 살펴야 한다.


            while (true) { 
            
            }

        }






    }
                




            }
        }
    }
}
