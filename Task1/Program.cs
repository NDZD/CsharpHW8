// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int m = 5;        
int n = 6;  

int [,] CreateArr(int m, int n){
    
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


int [,] GetSortArray(int [,] arr){
    int temp = 0;
    int a = arr.GetLength(1) - 1;

        for (int i = 0; i < arr.GetLength(0); i++){
            int c = arr.GetLength(1) - 1;
        
            while (c >= 0){
            int m = 0;
                while(m < c){
                    if(arr[i,m] < arr[i,m+1]){
                    temp = arr[i,m];
                    arr[i,m] = arr[i,m+1];
                    arr[i,m+1] = temp;
                    }                    
                    m++;                
                }
            
                c--;
            } 
        }
    return arr;
}

int [,] Printarr(int [,] arr){
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            System.Console.Write($"{arr[i,j]} ");
        }
        System.Console.WriteLine();
    }
    return arr;
}
int[,] array = CreateArr(m,n);
System.Console.WriteLine();
Printarr(GetSortArray(array));