using System;

// README.md를 읽고 아래에 코드를 작성하세요.



var basic = new { ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 50, Difficulty = "보통" };
var user = new { ResolutionWidth = 1920, ResolutionHeight = 1080, Volume = 80, Difficulty = "어려움" };


Console.WriteLine("=== 게임 설정 비교 ===");
Console.WriteLine("[기본 설정]");
Console.WriteLine(basic);
Console.WriteLine("[사용자 설정]");
Console.WriteLine(user);

Console.WriteLine("[타입 비교]");
Console.WriteLine($"같은 타입: {basic.GetType() == user.GetType()} (속성 구조가 동일)");

Console.WriteLine();
Console.WriteLine("[값 비교]");
Console.WriteLine($"Equals 결과: {basic.Equals(user)} (Volume, Difficulty 값이 다름)");

Console.WriteLine();
Console.WriteLine("[백업 설정]");
var backup = basic;
Console.WriteLine(backup);
Console.WriteLine($"기본 설정과 Equals: {backup.Equals(basic)} (모든 값이 동일)");

Console.WriteLine("=== 설정 목록 (배열) ===");

var setting = new[]
{
    basic, user, backup
};

int count = 1;
foreach (var set in setting)
    Console.WriteLine($"설정{count++} : {set.ResolutionWidth}x{set.ResolutionHeight}, 볼륨: {set.Volume}, 난이도 {set.Difficulty}");



Console.WriteLine("=== 속성 순서가 다른 설정 ===");
var _basic = new { Volume = 50, Difficulty = "보통", ResolutionWidth = 1920, ResolutionHeight = 1080 };
Console.WriteLine(_basic);
Console.WriteLine($"기본 설정과 같은 타입: {basic.GetType() == _basic.GetType()} (속성 순서가 달라 다른 타입)");



