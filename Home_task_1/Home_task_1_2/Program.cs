using Home_task_1_2;

Matrix matrix = new Matrix();
matrix.GenerateRandomMatrix(4, 10);

matrix.PrintMatrix();
Console.WriteLine(matrix.MaxLineStats());