using Home_task_1_1;

try
{
    var values = Console.ReadLine().Split().Select(s => int.Parse(s)).ToList();
    SpiralMatrix matrix = new SpiralMatrix(values[0], values[1]);
    matrix.Print();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}