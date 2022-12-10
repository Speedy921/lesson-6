
//члены сжатые до выражений
//синтаксический сахар
static int Add(int x, int y) => x + y;


//статическая локасльная функция 
static int AddWrapperWithStatic(int x, int y)
{
    //выполнение проверки достоверности
    return Add(x, y);

    static int Add(int x, int y)
    { return x + y; }
}