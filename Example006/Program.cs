int a = new Random().Next(0, 10), 
    b = new Random().Next(0, 10),
    c = new Random().Next(0, 10),
    d = new Random().Next(0, 10),
    e = new Random().Next(0, 10);

int max = a;

if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (max < e) max = e;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);
Console.WriteLine(d);
Console.WriteLine(e);
Console.WriteLine(max);