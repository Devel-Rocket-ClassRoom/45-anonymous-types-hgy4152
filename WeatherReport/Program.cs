using System;

// README.md를 읽고 아래에 코드를 작성하세요.


var weather = new[]
{
    new { Day = "월요일", Htemp = 12, Ltemp = 3, Rain = 20},
    new { Day = "화요일", Htemp = 8, Ltemp = -1, Rain = 60},
    new { Day = "수요일", Htemp = 5, Ltemp = -3, Rain = 80},
    new { Day = "목요일", Htemp = 10, Ltemp = 2, Rain = 40},
    new { Day = "금요일", Htemp = 15, Ltemp = 5, Rain = 10},
};

Console.WriteLine("=== 5일간 날씨 예보 ===");
Console.WriteLine("요일\t최고기온  최저기온  강수확률");
Console.WriteLine("------------------------------------");

double sum = 0;
int count = 0;
foreach (var w in weather)
{
    Console.WriteLine($"{w.Day}\t{w.Htemp,6}도 {w.Ltemp,6}도 {w.Rain,6}%");
    sum += w.Htemp;

    if(w.Rain >= 50)
        count++;
}
Console.WriteLine("------------------------------------");
Console.WriteLine($"최고기온 평균: {sum/weather.Length}");
Console.WriteLine($"비 올 가능성 높은 날(50% 이상): {count}일");
