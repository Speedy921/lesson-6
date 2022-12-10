using System.Globalization;

Console.WriteLine("****Fun with Methods*****\n");
//передать две переменные по знач
int x = 9, y = 10;
Console.WriteLine("Before call: X:{0}, Y: {1}, x,y");
//значение перед вызовом
Console.WriteLine("Answer is {0}", Add(x,y));
//результат сложения
Console.WriteLine("After call: X: {0}, Y: {1}", x, y);
//значение после вывзова
Console.ReadLine(); 

Console.WriteLine("*****Fun with Methods*****");
//присваивать начальные значения локальным переменных исп
//как выходные параметры не обяххательно при условии что они
//применяются в таком качестве впервые 
AddusingOutParam(90, 90, out int ans);
Console.WriteLine("90 + 90 = {0}", ans);
Console.ReadLine();

Console.WriteLine("*****Fun with Methods*****");
string str1 = "Flip";
String str2 = "Flop";
Console.WriteLine("Before: {0}, {1}", str1, str2); //до
SwapStrings(ref str1, ref str2);
Console.WriteLine("After: {0}, {1}", str1, str2);//После
Console.ReadLine();

Console.WriteLine("*****Fun with Methods*****");
//передать список знач double разделеных запятыми 
double averange;
averange = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
//вывод среднего знач для переданых данных
Console.WriteLine("Averange of data is: {0}", averange);
// или передать массив значений double
double[] data = { 4.0, 3.2, 5.7 };
averange = CalculateAverage(data);
//вывод среднего знач для переданных данных
Console.WriteLine("Averange of data is: {0}", averange);
//среднее из 0 равно 0!
//вывод среднего значения для переданных данных
Console.WriteLine("Average of data is: {0}", CalculateAverage());
Console.ReadLine();

EnterLogData("Oh no! Grid cant find data");
EnterLogData("oh no! I cant find the payroll data", "CFO");
Console.ReadLine();

Console.WriteLine("****Fun with Methods*****");

DisplayFancyMessage(message: "Wow! Very Fancy indeed",
    textColor: ConsoleColor.DarkRed,
    backgroundColor: ConsoleColor.White);
DisplayFancyMessage(backgroundColor: ConsoleColor.Green,
    message: "Testing...",
    textColor: ConsoleColor.DarkBlue);
Console.ReadLine();

Console.WriteLine("****Fun with Method Overloading*****");
//вызов версии int метода Add()
Console.WriteLine(Add(10,10));
//вЫзод верисии long метода Add() с исп нвого раздеоителя
Console.WriteLine(Add(900_000_000_000, 900_000_000_000));
//вызов версии double метода Add() 
Console.WriteLine(Add(4.3, 4.4);
Console.ReadLine();


//члены сжатые до выражений
//синтаксический сахар
static int Add1(int x, int y) => x + y;


//статическая локасльная функция 
static int AddWrapperWithStatic(int x, int y)
{
    //выполнение проверки достоверности
    return Add(x, y);

    static int Add(int x, int y)
    { return x + y; }
}

static int Add(int x, int y)
{
    int ans = x + y;
    //вызывающий код не увидит эти изм
    //так как модмфицируется копия исходных данных
    x = 10000;
    y = 88888;
    return ans;
}

//использование модификатора OUT
//значения выходных параметров должны быть 
//установлены внутри выхываемого метода
static void AddusingOutParam (int x, int y, out int ans)
{
    ans = x + y;
}

//Использование модификатора Ref
//ссылочные параметры 
static void SwapStrings(ref string s1, ref string s2)
{
    string tempStr = s1;
        s1 = s2;
    s2 = tempStr;
}

//использование параметра IN
static int AddReadOnly(in int x, in int y)
{
    //ошибка CS8331 Cannot assign to variable 'in int';
    //because it is a readonly variable
    //не удается присвоить значение переменной  in int
    //поскольку она допускает только чтение
    //x = 10000;
    //y = 88888;
    int ans = x + y;
    return ans;
}

//использование модификатора params 
//возвращение среднего из некоторого количства знач double
static double CalculateAverage(params double[] values)
{
    Console.WriteLine("You sent me {0} doubles.", values.Length);

    double sum = 0;
    if(values.Length == 0)
    {
        return sum;
    }
    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }
    return (sum / values.Length);
}

//определение необязательных параметров 
static void EnterLogData(string message, string owner = "Progrrammer")
{
    Console.Beep();
    Console.WriteLine("Error: {0}", message); //сведение об ошибке 
    Console.WriteLine("Owner of Error:{0}", owner); //владелец Ошибки
}

//именнованые параметры 
static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
{
    //сохранить старые цвета для восстановления после вывода сообщения 
    ConsoleColor oldTextColor = Console.ForegroundColor;
    ConsoleColor oldbackgroundColor = Console.BackgroundColor;

    //установить новые цвета и вывести сообщение
    Console.ForegroundColor = textColor;
    Console.BackgroundColor = backgroundColor;
    Console.WriteLine(message);

    //Восстановить предидущие цвета
    Console.ForegroundColor = oldTextColor;
    Console.BackgroundColor = oldbackgroundColor;
}

//перегрезка методов 
public static class AddOperations
{
    //перегруженный метод Add()
    public static int Add(int x, int y)
    {
        return x + y;
    }
    //перегруженный метод Add()
    public static double Add(double x, double y)
    {
        return x + y;
    }
    //перегруженный метод Add()
    public static long Add(long x, long y)
    {
        return x + y;
    }