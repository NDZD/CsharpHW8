// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

//int m = 5;        
//int n = 6;  

int [,] CreateArr(int m, int n){                    //Создаем массив с произвольными числами от 1 до 10
    
    int [,] arr = new int [m, n];

    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            arr [i,j] = new Random().Next(10);
            System.Console.Write($"{arr[i,j]} ");
        }        
        System.Console.WriteLine();        
    }
    return arr;   
}
int [] RowSum(int [,] arr){                         //Делаем сложение чисел в каждой строке,
    int [] array = new int [arr.GetLength(0)];      // результат записываем в одномерный массив
        
    for(int i = 0; i < arr.GetLength(0); i++){
        int sum = 0;
        for(int j = 0; j < arr.GetLength(1); j++){
                sum = sum + arr[i,j];
                array[i] = sum;
                
        }
        //System.Console.WriteLine(array[i]);
    }
    return array;
}

int MinSum(int [] arr){                             // Находим наименьшее число в одномерном массиве
    //int i = 0;
    int minSum = arr[0];
    for (int i = 0; i <= arr.Length -1; i++)
    {
        if(arr[i] <= minSum){
            minSum = arr[i];
        }        
    }
    //System.Console.WriteLine(minSum + " minsum");
    return minSum;    
}


void PrintResult(int [] arr, int minSum){           //Находим позицию числа в массиве
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == minSum)
        {
            System.Console.WriteLine($"{i+1}-я строка с наименьшей суммой элементов");
        }
    }
}
int [] arr1 = RowSum(CreateArr(4,3));
System.Console.WriteLine();
PrintResult(arr1, MinSum(arr1));