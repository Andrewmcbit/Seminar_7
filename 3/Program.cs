/*Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.*/ 


void PrintElementsFromArray(int[] inputArray, int length){
    if (length == inputArray.Length-1){
        Console.Write(inputArray[length] + " ");
        PrintElementsFromArray(inputArray, length-1);
    } else {   
        if (length >= 0){
            Console.Write(inputArray[length] + " ");
            PrintElementsFromArray(inputArray, length-1);
        }
    }
}

int[] array = {3,2,6,76,8,1,4}; // 4,1,8,76,6,2,3
PrintElementsFromArray(array, array.Length-1);