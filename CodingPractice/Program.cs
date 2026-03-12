using System;

// README.md를 읽고 코드를 작성하세요.

var student = new { Name = "김철수", Grade = 3, Score = 95.5 };



Console.WriteLine(student.Name);
Console.WriteLine(student.Grade);
Console.WriteLine(student.Score);

string name = "이영희";
int age = 28;

var per = new { Name = name, Age = age };

Console.WriteLine($"person1 = {per.Name}, {per.Age}");

var per2 = new { name, age };

Console.WriteLine($"person2 = {per2.name}, {per2.age}");


string str = "Hello";

var anony = new { str,len = str.Length };

Console.WriteLine($"텍스트: {anony.str}");
Console.WriteLine($"길이: {anony.len}");


int price = 25000;

var anony1 = new { Id = 100, Name = "마우스", price, formatPrice = price.ToString("N0") };

Console.WriteLine($"ID: {anony1.Id}");
Console.WriteLine($"상품명: {anony1.Name}");
Console.WriteLine($"가격: {anony1.price}");
Console.WriteLine($"포맷된 가격: {anony1.formatPrice}원");



var point1 = new {X = 1, Y = 2};
var point2 = new {X = 3, Y = 4 };

Console.WriteLine($"같은 타입: {point1.GetType() == point2.GetType()}");

point1 = point2;
Console.WriteLine($"point1: ({point1.X}, {point1.Y})");


var a = new { x = 1, y = 2};
var b = new { x = 1, y = 2};
var c = new { x = 3, y = 4};

Console.WriteLine($"a.Equals(b): {a.Equals(b)}");
Console.WriteLine($"a.Equals(c): {a.Equals(c)}");


Console.WriteLine($"a == b: {a == b}");
a = c;

Console.WriteLine($" a == c: {a == c}");


var an1 = new[]
{
    new {Name = "김철수", Score = 85 },
    new {Name = "이영희", Score = 92 },
    new {Name = "박민수", Score = 78 }
};

Console.WriteLine("=== 학생 점수 목록 ===");

foreach(var an in an1)
{
    Console.WriteLine($"{an.Name}: {an.Score}점");
}

var an2 = new[]
{
    new { Name = "키보드", Price = 125000},
    new { Name = "키보드", Price = 125000},
    new { Name = "키보드", Price = 125000}
};

Console.WriteLine($"첫 번째 상품{an2[0].Name}");
Console.WriteLine($"상품 개수: {an2.Length}");

int sum = 0;
foreach(var an in an2)
{
    sum += an.Price;
}

Console.WriteLine($"총 가격: {sum:N0}원");


var an3 = new { X = 1, Y = "Object 1" };
var an4 = new { X = 2, Y = "Object 2" };

Console.WriteLine(an3);

an3 = an4;

Console.WriteLine(an3);


var an5 = new { Name = "홍길동", Age = 30 };

var tup = ("홍길동", 30);

Console.WriteLine($"익명 타입: {an5.Name}, {an5.Age}");
Console.WriteLine($"튜플: {tup.Item1}, {tup.Item2}");


var an6 = new { Name = "김영희", Age = 25, City = "서울" };

Console.WriteLine (an6);
Console.WriteLine (an6.ToString());

Console.WriteLine("=== 직원 정보 ===");

var an7 = new[]
{
    new {Name = "김철수", Team = "개발팀", Pay = 5000},
    new {Name = "이영희", Team = "기획팀", Pay = 4500},
    new {Name = "박민수", Team = "개발팀", Pay = 5500}
};

foreach(var an in an7)
{
    Console.WriteLine($"{an.Name} ({an.Team}) - {an.Pay:N0}만원");
}

string[] names = { "사과", "바나나", "오렌지" };
int[] prices = { 1000, 1500, 2000 };

var fruits = new[]
{
    new { Name = names[0], Price = prices[0] },
    new { Name = names[1], Price = prices[1] },
    new { Name = names[2], Price = prices[2] }
};
Console.WriteLine("=== 과일 가격표 ===");

foreach(var fruit in fruits)
    Console.WriteLine($"{fruit.Name}: {fruit.Price}원");
