String[] array = {
    "1234",
    "12",
    "1",
    "asdf",
    "gri",
    "asdfh",
    "3"
};

ShowArr(array);
string[] changedArr = filtrArr(array);
ShowArr(changedArr);

void ShowArr(string[] arrShow){
    for(int i = 0; i < arrShow.Length; i++){
        Console.Write(arrShow[i] + " ");
    }
    Console.WriteLine();
}

String[] filtrArr(String[] arr){
    String str = "";
    for(int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= 3 ){
            str = String.Concat(str, " ", arr[i]);
        }
    }
    str = str.Substring(1);
    return str.Split(' ');
}
