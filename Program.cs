Console.WriteLine("Шаг 1");
Console.Write("Сколько студентов в группе? ");
int studentsCount = int.Parse(Console.ReadLine());
int[] grades = new int[studentsCount];
int sum = 0;

for (int i = 0; i < grades.Length; i++){
    Console.Write($"Оценка студента {i + 1}: ");
    grades[i] = int.Parse(Console.ReadLine());
    sum += grades[i];
}

foreach (int grade in grades){
    Console.WriteLine(grade);
}
double avar = (double)sum / grades.Length;
Console.WriteLine($"Средний балл группы: {avar}");

Console.WriteLine("Шаг 2");
int[] points = {4, 7, 2, 9, 5, 11, 15};

for (int k = 0; k < points.Length; k++){
    if (points[k] < 10){
        points[k] = points[k] + 1;
    }
}

foreach (int point in points){
    Console.WriteLine(point);
}