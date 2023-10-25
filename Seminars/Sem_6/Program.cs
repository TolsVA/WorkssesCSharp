int[] arr = new int[]{6, 3, 8, 97, 43, 4, 5};
System.Console.WriteLine($"[{String.Join(", ", arr)}]");


System.Console.WriteLine($"[{String.Join(", ", InverseArray(arr, 0 , arr.Length -1))}]");
// void fulArr(int[] arr, int index) {
//     if (index == 0)
//     {
//         temp = arr[index];
//         arr[index] = arr[index + 1];
//     } else if (index == arr.Length - 1)
//     {
//         arr[index] = temp;
//         return;
//     } else {
//         arr[index] = arr[index + 1];
//     }
// fulArr(arr, ++index);

// }

// разворот массива
int[] InverseArray(int[] arr, int first, int last ) {
    if (first < last) InverseArray(SwapElements(arr, first, last), ++first, --last);
    return arr;
}

// меняем элименты местами
int[] SwapElements(int[] arr, int x, int y) {
    int temp = arr[x];
    arr[x] = arr[y];
    arr[y] = temp;
    return arr;
}

System.Console.WriteLine(2.0/-4.0);