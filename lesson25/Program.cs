using lesson25;

Console.WriteLine("****Fun with Interface Name Clashes*****\n");

Octagon oct = new Octagon();

//для доступа к членам Draw() должно исп приведение 
IDrawToForm itForm = (IDrawToForm)oct;
itForm.Draw();

//сокращенная форма записи 
((IDrawToPrinter)oct).Draw();

//ключевое слово is
if(oct is IDrawToMemory dtm)
{
    dtm.Draw();
}
Console.ReadLine();
