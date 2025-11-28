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

int mapSizeMinX = 0;
int mapSizeMinY = 0;
int mapSizeMaxX = 20;
int mapSizeMaxY = 20;


//벽을 만들어라
// 이제 변수가 두개니까 > 변수를 구체적으로 써야한다
int wallX = 3;
int wallY = 3;





int XPosition = 5;
int YPosition = 10;




// 버퍼 초과 문제 해결법

while (true)
{
    Console.Clear();
    Console.SetCursorPosition(wallX, wallY);
    Console.Write("#");
    Console.SetCursorPosition(XPosition, YPosition);
    Console.Write("%");

    ConsoleKeyInfo keyInfo = Console.ReadKey();// 키를 입력 받았다

    if (keyInfo.Key == ConsoleKey.DownArrow)
    {

        // 아래로간다 > Y가 증가 

        YPosition = Math.Min(mapSizeMaxY, YPosition + 1);


    }
    else if (keyInfo.Key == ConsoleKey.UpArrow)
    {
        // 아래로간다 > Y가 증가 

        YPosition = Math.Max(mapSizeMinY, YPosition - 1);

    }
    else if (keyInfo.Key == ConsoleKey.LeftArrow)
    {

        // playerX < 0 > -1 로 오류 >Math라이브러리를 써보자

        //Console.SetCursorPosition(newXPosition, newYPosition);
        XPosition = Math.Max(mapSizeMinX, XPosition - 1);

    }
    else if (keyInfo.Key == ConsoleKey.RightArrow)
    {
        XPosition = Math.Min(mapSizeMaxX, XPosition + 1);

    }
    // 플레이어랑 벽과의 충돌 처리
    //1. 플레이어 랑 벽이 충돌했는가 > 어떤 데이터(플레이어 좌표, 벽 좌표)
    // 어떤 연산자 : == (같은지?)  > 20,20에 도착하면 "충돌함" 메시지
    //>> 플레이어 좌표 == 벽 좌표

    bool isSamePlayerXAndWallX = XPosition == mapSizeMaxX;
    bool isSamePlayerYAndWallY = YPosition == mapSizeMaxY;
    bool isColliedPlayerWithWall = isSamePlayerXAndWallX && isSamePlayerYAndWallY;
    if (isColliedPlayerWithWall)
    {
        // >> 부딪히면 > 그 전 키를 받아라
        // > 이동시켜라 > 키의 방향에 맞게 무효화 시켜라, 뒤로 가게 하라

        //오른쪽에서 부딪히면 > 오른쪽으로 보내고
        //XPosition = XPosition + 1;
        // 왼쪽에서 부딪히면 > 왼쪽으로 보내고
        //XPosition = XPosition - 1;
        // 움직이기 전 좌표를 이용한다.


        //    //// 밑에서 부딪힘 > 밑으로 보내고
        //    //// 위에서 부딪힘 > 위로 보내고
        if (keyInfo.Key == ConsoleKey.DownArrow)
        {
            // 아래로간다 > Y가 증가 
            YPosition = Math.Min(wallY, YPosition + 1);

        }
        else if (keyInfo.Key == ConsoleKey.UpArrow)
        {
            // 위로간다 > Y가 감소 
            YPosition = Math.Max(wallY, YPosition - 1);
        }
        else if (keyInfo.Key == ConsoleKey.LeftArrow)
        {

            // playerX < 0 > -1 로 오류 >Math라이브러리를 써보자

            XPosition = Math.Max(wallX, XPosition - 1);

        }
        else if (keyInfo.Key == ConsoleKey.RightArrow)
        {
            XPosition = Math.Min(wallX, XPosition + 1);
        }
    }

    // 1. 이전 좌표로 되돌린다






}
