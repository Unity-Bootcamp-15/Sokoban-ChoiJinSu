namespace sokoban
{
    internal class Program
    {

        enum Direction { 
        
           None,
           Left,
           Right,
           Down,
           Up
        
        
        }
        
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
            


            while (true) {

                // 키를 입력 받았다                                    
                // 키 입력 받았어. 근데 이게 아래방향키인지 어찌 알아? > 판별해야겠네 > 동위연산자 ==             
                // 컴퓨터가 알아듣는 건 연산자 > keyInfo 속의 key를 확인해야한다
                // ConsoleKeyInfo.key가 현재 누른 데이터가 있겠다
                // (keyInfo.key) == (아래방향키 > 이걸 어떻게 알지??)
                // > 일단 key컴포넌트가 ConsoleKey니까 같으려면 같은 타입 이어야 겠네 > 번호키가 Consolekey에 키를 받는 컴포넌트가 있네 
                // keyInfo.Key == ConsoleKey.DownArrow;
                // 라면 이라 했으니 선택문으로 가야한다


                // 게임 데이터 초기화
                int mapSizeMinX = 0;
                int mapSizeMinY = 0;
                int mapSizeMaxX = 10;
                int mapSizeMaxY = 10;
                bool isGameOver = false;



                // 플레이어 데이터
                int playerX = 5;
                int playerY = 10;
                Direction playerDirection = Direction.None;

                
                
                // 벽 데이터
                int wallX = 3;
                int wallY = 3;

                // 박스 데이터
                int boxX = 6;
                int boxY = 6;

                // 골 데이터
                int goalX = 4;
                int goalY = 5;


                //--------------- Render -----------------

                Console.Clear();

                Console.SetCursorPosition(goalX, goalY);
                Console.Write("O");
                Console.SetCursorPosition(boxX, boxY);
                Console.Write("#");
                Console.SetCursorPosition(wallX, wallY);
                Console.Write("@");
                Console.SetCursorPosition(playerX, playerY);
                Console.Write("P");

                // --------------------------ProcessInput--------------------
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                // ------------------------------Update --------------------
                // 플레이어 이동 처리 > rangeOutOf오류 처리
                int newPlayerX = playerX;
                int newPlayerY = playerY;




                if (keyInfo.Key == ConsoleKey.DownArrow)
                {

                    // 1-1 .플레이어가 아래로 이동하게 해라 => 
                    // 이동이라는 건 좌표가 바뀐다는 거지 > 그럼 x,y좌표가 필요하겠네 > 좌표 어떻게 구해?? > Y값을 담아줘야겠네
                    // 아래로 가려면 y값이 커져야해 > ++
                    //playerY = playerY + 1; //++y , y += 1
                    playerDirection = Direction.Down;

                    // 어? 캐릭터가 없네? > 다시 그려줘야해
                    // 위치 입력 > 캐릭터 출력
                    // Render
                    // ProcessInput
                    // Update 
                    //이 세가지를 묶어서 FrameWork라 한다
                    // 이러한 과정 하나를 Frame이라 한다
                    // 프레임워크 : 뼈대 > 응용프로그램의 동작 순서
                    // 그리는 단계 > 키 입력 > 업데이트(게임월드를 최신화) 

                }
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {

                    // 1-1 .플레이어가 아래로 이동하게 해라 => 
                    // 이동이라는 건 좌표가 바뀐다는 거지 > 그럼 x,y좌표가 필요하겠네 > 좌표 어떻게 구해?? > Y값을 담아줘야겠네
                    // 아래로 가려면 y값이 커져야해 > ++
                    //playerY = playerY - 1;
                    // 위치 입력 > 캐릭터 출력
                    playerDirection = Direction.Up;
                }
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                {

                    // 1-1 .플레이어가 아래로 이동하게 해라 => 
                    // 이동이라는 건 좌표가 바뀐다는 거지 > 그럼 x,y좌표가 필요하겠네 > 좌표 어떻게 구해?? > Y값을 담아줘야겠네
                    // 아래로 가려면 y값이 커져야해 > ++
                    //playerX = playerX - 1;
                    // 위치 입력 > 캐릭터 출력
                    playerDirection = Direction.Left;
                }
                if (keyInfo.Key == ConsoleKey.RightArrow)
                {

                    // 1-1 .플레이어가 아래로 이동하게 해라 => 
                    // 이동이라는 건 좌표가 바뀐다는 거지 > 그럼 x,y좌표가 필요하겠네 > 좌표 어떻게 구해?? > Y값을 담아줘야겠네
                    // 아래로 가려면 y값이 커져야해 > ++
                    playerX = playerX + 1;
                    // 위치 입력 > 캐릭터 출력
                    playerDirection = Direction.Right;

                }

                

                //잔상이 남는다 > 이전 위치가 출력된다 > 왜 이러지 ? > 디버그 해보자
                // 이전 화면이 남기 때문 > 이전 장면을 없애려면 > 초기화 하자
                // 유니티는 디버거도 어려운데 > 멈추고 싶지만 어렵다 > 그래서 콘솔창으로 기본기를 늘려가야 한다.
                // 이전 화면을 지우자 > 출력창을 다 지우고 다시 쓴다면? 
                // 왜 깜박깜빡댈까> 플리커링 > 이전화면이 지워질때 남아서

                // 어? 캐릭터가 콘솔창을 넘어갔어 > ArgumentOutOfRange 발생
                // 값이 - 1로 가서 오류야 > 0까지는 되는데 넘어섰어


                // 결국 프로그래머는 사람이 한 말을 컴퓨터가 이해할 수 있게 바꾸는 것 > 통역가라 봐도 무방
                // 어떤 데이터에 무슨 연산을 할 것인가? 이걸 살펴야 한다.




                switch (playerDirection)
                {
                    case Direction.Left:
                        newPlayerX = Math.Max(mapSizeMaxX, playerX - 1);
                        break;
                    case Direction.Right:
                        newPlayerX = Math.Min(mapSizeMaxX, playerX + 1);
                        break;
                    case Direction.Up:
                        newPlayerY = Math.Max(mapSizeMaxY, playerX - 1);
                        break;
                    case Direction.Down:
                        newPlayerY = Math.Min(mapSizeMaxY, playerX + 1);
                        break;
                    default: 
                        Console.Clear();
                        //Log를 이용한 오류 처리
                        Console.WriteLine($"[Error] at 플레이어 이동 처리 : 잘못된 방향입니다.{playerDirection}");
                        return; //break하면 그냥 switch문만 벗어나는 거니까 return처리
                }

                // 플레이어와 벽의 충돌 처리
                // 1. 플레이어와 벽이 충돌했는지 감지한다. => (플레이어 좌표) == (벽 좌표)
                bool isSamePlayerXAndWallX = newPlayerX == wallX;
                bool isSamePlayerYAndWallY = newPlayerY == wallY;
                bool isCollidedPlayerWithWall = isSamePlayerXAndWallX && isSamePlayerYAndWallY;

                // 2. 충돌했다면 위치를 다시 되돌린다.
                if (isCollidedPlayerWithWall)
                {
                    // 움직임을 반영하지 않는다.
                    continue;
                }

                // 플레이어와 박스의 충돌 처리
                // 1. 플레이어와 박스의 충돌을 감지한다.
                bool isSamePlayerXAndBoxX = newPlayerX == boxX;
                bool isSamePlayerYAndBoxY = newPlayerY == boxY;
                bool isCollidedPlayerWithBox = isSamePlayerXAndBoxX && isSamePlayerYAndBoxY;

                // 2. 충돌했다면 박스의 새 좌표를 갱신한다.
                int newBoxX = boxX;
                int newBoxY = boxY;
                if (isCollidedPlayerWithBox)
                {
                    switch (playerDirection)
                    {
                        case Direction.Left:
                            newBoxX = Math.Max(mapSizeMinX, boxX - 1);
                            newPlayerX = newBoxX + 1;
                            break;
                        case Direction.Right:
                            newBoxX = Math.Min(mapSizeMaxX, boxX + 1);
                            newPlayerX = newBoxX - 1;
                            break;
                        case Direction.Up:
                            newBoxY = Math.Max(mapSizeMinY, boxY - 1);
                            newPlayerY = newBoxY + 1;
                            break;
                        case Direction.Down:
                            newBoxY = Math.Min(mapSizeMaxY, boxY + 1);
                            newPlayerY = newBoxY - 1;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine($"[Error] at 박스 이동 처리: 잘못된 방향입니다. {playerDirection}");
                            return;
                    }
                }

                // 박스와 벽의 충돌 처리
                // 1. 박스와 벽의 충돌을 감지한다.
                bool isSameBoxXAndWallX = newBoxX == wallX;
                bool isSameBoxYAndWallY = newBoxY == wallY;
                bool isCollidedBoxWithWall = isSameBoxXAndWallX && isSameBoxYAndWallY;

                // 2. 충돌했다면 좌표 갱신을 하지 않는다.
                if (isCollidedBoxWithWall)
                {
                    continue;
                }

                // 박스와 골의 충돌 처리
                // 1. 박스와 골의 충돌을 감지한다.
                bool isSameBoxXAndGoalX = newBoxX == goalX;
                bool isSameBoxYAndGoalY = newBoxY == goalY;
                bool isCollidedBoxWithGoal = isSameBoxXAndGoalX && isSameBoxYAndGoalY;

                // 2. 충돌했다면 게임을 끝낸다.
                if (isCollidedBoxWithGoal)
                {
                    isGameOver = true;
                }

                // 좌표를 갱신한다.
                boxX = newBoxX;
                boxY = newBoxY;

                playerX = newPlayerX;
                playerY = newPlayerY;


            }

            // 게임 종료 처리
            Console.Clear();
            Console.WriteLine("축하합니다! 게임을 클리어하셨습니다!");







        }



            // 플레이어와 벽의 충돌 처리
            // 1. 플레이와와 벽이 충돌했는지 감사한다 >> 플레이어 좌표 == 벽 좌표
            // 2. 충돌했다면 >> 위치를 원위치 시킨다 > continue; > 반영 안한다
            // 플레이어의 좌표를 갱신한다 > 다시 값을 넣는다
            // P#인 상태에서 오른쪽키를 누른 경우 > 다시 왼쪽으로 보낸다 > 어떻게 알어?
            // (1) 키를 저장했다가 가져온다...
            // (2) 방향데이터를 파악한다
            // (3) 움직일 방향을 예측하여 움직임을 반영하지 않는다 > 기존 움직임을 이용하자(이걸로 해보자)
            // >> 결국 추가데이터가 필요하다
            // 키를 저장?, 방향데이터? 나중에 점점 물건이 늘어나면...
            // > 그걸 다 일일이 판별해야하는데 
            // P@# 같은 경우 어떻게 해야하지??>처리할 데이터가 점점 복잡해진다
            // 하지만 방향데이터가 있는 것도 좋기에 방향데이터를 쓰긴 할건데



            // P#인 상태에서 오른쪽키를 누른 경우 > 다시 왼쪽으로 보낸다

            // 충돌했다면 박스의 충돌을 감지한다
            // 충돌했다면 박스의 새 좌표를 갱신한다

            // 박스의 위치를 어떻게 갱신하지?? > 이동방향을 이용하자
            // if문을 스위치에 넣는다? > 굳이..
            // 조건이 필요가 없다 >newPlayerX를 box기준에서 -1 +1 하면 되니까


            // 일관적으로 가져가는 게 유지보수에 편하다


            // 충돌했다면 박스와 벽의 충돌을 감지한다
            // 충돌했다면 박스의 새 좌표를 갱신하지 않는다 > contunue처리


            // 박스와 골의 충돌 > 충돌했다면 게임을 끝낸다 > break처리 또는 isGameOver를 선언 후 그걸 true처리
            // 수업을 못 들은 리스크는 본인이 지는 것
            // 회사에서도 휴가가기 전에 본인이 할 것을 끝내고 가는 것이다. 야근을 해서라도
            




















        






    }
                




            
        
    
}
