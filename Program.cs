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

Console.WriteLine("Шаг 3");
int[] grades1 = {4, 5, 3, 5, 4, 2};

for(int a = 0; a < grades1.Length; a++){
    for(int b = 0; b < grades1.Length -1 - a; b++){
        if (grades1[b] < grades1[b+1]){
            int temp = grades1[b];
            grades1[b] = grades1[b + 1];
            grades1[b + 1] = temp;
        }
    }
}
foreach (int grade1 in grades1){
    Console.WriteLine(grade1);
}



Console.WriteLine("Шаг 4");
int[] GenerateScheduleSlots(int lessonsCount){
    int[] slots = new int[lessonsCount];

    for (int c = 0; c < lessonsCount; c++){
        slots[c] = c + 1;
    }

    return slots;
}

int[] GenerateEvenSlots(int lessonsCount){
    int[] evenSlots = new int[lessonsCount];
    int evenNumber = 2; 

    for (int j = 0; j < lessonsCount; j++)
    {
        evenSlots[j] = evenNumber;
        evenNumber += 2; 
    }
    return evenSlots;
}

int[] slots = GenerateScheduleSlots(6);

foreach (int slot in slots){
    Console.WriteLine(slot);
}

int[] evenSlots = GenerateEvenSlots(6);
Console.WriteLine("Чётные слоты (2, 4, 6...):");

foreach (int evenSlot in evenSlots){
    Console.WriteLine(evenSlot);
}


Console.WriteLine("Шаг 5");
int[] grades2 = {4, 5, 3, 5, 4, 2};
Array.Sort(grades2);

foreach (int grade2 in grades2){
    Console.WriteLine(grade2);
}


Console.WriteLine("Самостоятельное задание: А");
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

int[] squares = new int[n];

for (int s = 0; s < n; s++){
    squares[s] = (s + 1) * (s + 1); 
}

foreach (int sq in squares){
    Console.WriteLine(sq);
}



Console.WriteLine("Самостоятельное задание: Б");
int[] numbers = { 5, -3, 8, -1, 0, -7, 4 };

for (int r = 0; r < numbers.Length; r++)
{
    if (numbers[r] < 0)
    {
        numbers[r] = 0;
    }
}

foreach (int num in numbers){
    Console.Write(num + " ");
Console.WriteLine();
}


Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


Console.WriteLine("Вариант 1");
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] arr = new int[size];
int sum1 = 0;

for (int q = 0; q < size; q++){
    Console.Write($"Элемент {q + 1}: ");
    arr[q] = int.Parse(Console.ReadLine());
    sum1 += arr[q];
}
Console.WriteLine($"Сумма: {sum1}");

Console.WriteLine("Вариант 6");
int[] arr1 = {7, 2, 9, 4, 5};
Array.Sort(arr1);

int median = arr1[arr1.Length / 2];
Console.WriteLine($"Медиана: {median}");