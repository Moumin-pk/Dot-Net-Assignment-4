
// #1 Store Data

// Use a list or array to store the data sample: 15, -9, 10, 45, 87, 10, 23, 56.

using System.Collections.Generic;

int[] storeData = new int[8] { 15, -9, 10, 45, 87, 10, 23, 56 };


// #2 print Method

void PrintData()
{
    foreach (int displayUserdata in storeData)
    {
        Console.Write($"{displayUserdata} ");
    }
}
Console.Write("Print Data: ");
PrintData();
Console.WriteLine();

// #3 Sort Method
// Create a method called SortData which takes the data, sorts it, and returns the sorted data. Take an extra optional param of type char whose value could be A or D. If the value is A then sort it in ascending order; if D descending, Its by default value would be D

char typeSort = 'd';
Console.Write("Sort Array: ");
Console.WriteLine(SortData(storeData, typeSort));


string SortData(int[] list, char typeSort = 'd')
{
    // Conditon for Asscending
    if (typeSort == 'a')
    {
        for (int i = 0; i < list.Length; i++)
        {
            for (int j = i; j < list.Length; j++)
            {
                int swap;
                if (list[i] > list[j])
                {
                    swap = storeData[i];
                    list[i] = list[j];
                    list[j] = swap;
                }
            }
        }
        return string.Join(", ", list);
    }

    // Condition for Descending
    else
    {
        for (int i = 0; i < list.Length; i++)
        {
            for (int j = i; j < list.Length; j++)
            {
                int swap;
                if (list[i] < list[j])
                {
                    swap = list[i];
                    list[i] = list[j];
                    list[j] = swap;
                }
            }
        }
        return string.Join(", ", list);
    }
}


////  #4  IsitemFound Method:
//// Create a method IsItemFound which takes the data and an integer entry, returning true if the entry is found and false otherwise.

int itemFound = 5;
Console.Write("IsitemFound: ");
Console.WriteLine(IsitemFound(storeData, itemFound));

bool IsitemFound(int[] list, int targetItem)
{
    bool find = false;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] == targetItem)
        {
            return find = true;
        }
    }

    return find;

}

// #5 Search Method
// Create a method SearchData which takes the data and an integer parameter. It uses the IsItemFound method to check if the item exists. If it does, print the index where the item is found; otherwise, print a message indicating that the item was not found.


int searchItem = 23;
Console.Write("Search Method: ");
SearchMethod(storeData, searchItem);

void SearchMethod(int[] list, int searchItem)
{
    int findindex = 0;
    bool condition = false;

    // Search target value
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] == searchItem)
        {
            findindex = i;
            condition = true;
        }
    }

    // Display message
    if (condition == true)
    {
        Console.WriteLine($"{searchItem} was found in this index {findindex}");
    }
    else
    {
        Console.WriteLine($"{searchItem} was Not Found in this List ");
    }
}



// #6  Reverse Data Method
// Create a method ReverseData which takes the data and returns it in reverse order.

Console.Write("Reverse Data: ");
Console.WriteLine(ReverseData(storeData));

string ReverseData(int[] list)
{
    int[] reversedata = new int[list.Length];
    for (int i = 0; i < list.Length; i++)
    {
        reversedata[i] = list[list.Length - 1 - i];
    }
    return string.Join(", ", reversedata);
}


//// #7 Find Maximum Method:
//// Create a method FindMax which finds and returns the maximum value in the data without using built-in methods.



//// Maximum Method

Console.Write("Maximum: ");
Console.WriteLine(Maximum(storeData));
int Maximum(int[] list)
{
    int swap;
    for (int i = 0; i < list.Length; i++)
    {
        for (int j = i; j < list.Length; j++)
        {
            if (list[i] < list[j])
            {
                swap = list[i];
                list[i] = list[j];
                list[j] = swap;
            }
        }
    }

    return list[0];
}



// #8  Minimum Method
// Create a method FindMin which finds and returns the minimum value in the data without using built-in methods.

Console.Write("Minimum: ");
Console.WriteLine(Minimum(storeData));
int Minimum(int[] list)
{
    int swap;
    for (int i = 0; i < list.Length; i++)
    {
        for (int j = i; j < list.Length; j++)
        {
            if (list[i] > list[j])
            {
                swap = list[i];
                list[i] = list[j];
                list[j] = swap;
            }
        }
    }
    return list[0];
}


//// #9 Compute Average Method:
//// Create a method ComputeAverage which computes and returns the average of the data values.


// Average Method

Console.Write("Average: ");
Console.WriteLine(Average(storeData));

int Average(int[] list)
{
    int result;
    int sum = 0;
    int count = list.Length;
    for (int i = 0; i < list.Length; i++)
    {
        sum += list[i];
    }
    result = sum / count;
    return result;
}


// #10 Count Occurreneces Method:
// Create a method CountOccurrences which takes the data and an integer entry and returns the number of times the entry appears in the data.

int entry = 10;
Console.Write("Count Occurrences: ");
Console.WriteLine($"{entry} appears in this {CountOccurrences(storeData, entry)} Time");

int CountOccurrences(int[] list, int entry)
{
    int count = 0;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i] == entry)
        {
            count++;
        }
    }
    return count;
}




//#11  Find Median Method
// Create a method FindMedian that sorts the list and finds the median value, which is the middle element in an odd-length list, or the average of the two middle elements in an even-length list.

Console.Write("Median: ");
Console.WriteLine(Median(storeData));

double Median(int[] list)
{

    // Sort the array in ascending order
    Array.Sort(list);

    int length = list.Length;
    int mid = length / 2;

    // Check condition even or odd
    if (length % 2 == 0)
    {
        return (list[mid - 1] + list[mid]) / 2.0;
    }
    else
    {
        return list[mid];
    }
}

// 13 Find Unique Values Method:
// Create a method FindUniqueValues that returns a list of unique values in the data, removing any duplicates.

List<int> list = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

Console.Write("Find Uniqe value : ");
List<int> uniqeValue = FindUniqeValues(list);

foreach (int value in uniqeValue) { 
Console.Write(value);
}
Console.WriteLine();


// Method
List<int> FindUniqeValues(List<int> list)
{
    List<int> finduniqeValue = new List<int> { };

    foreach (int item in list) { 
        if(!finduniqeValue.Contains(item)) {
            finduniqeValue.Add(item); 
        }
    }      
    return finduniqeValue;
}


// 14 Mode Method:
// Create a method FindMode that finds the most frequently occurring number in the list.


FindMode(list);

void FindMode(List<int> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        int count = 0;
        int index = 0;
        for (int j = i; j < list.Count; j++)
        {
            if (list[i] == list[j])
            {
                count++;
                index = list[i];
            }
        }
        Console.WriteLine($"index {index} or Time {count}");
    }



    // 15 Sort Two Lists Method
    // Create a method Sort that takes two lists, sorts them, and returns a sorted list

    List<int> list1 = new List<int> { 25, 30, 26, 38 };
    List<int> list2 = new List<int> { 30, 250, 286, 37 };

    Console.Write("Sort Two lists: ");
    List<int> sortedList = SortTwoLists(list1, list2);
    Console.WriteLine(string.Join(", ", sortedList));
    List<int> SortTwoLists(List<int> list1, List<int> list2)
    {
        List<int> mergeList = list1.Concat(list2).ToList();
        mergeList.Sort();

        return mergeList;
    }


    // #16 Merge Two Lists Method:
    // Create a method Merge that takes two lists, merges them into one, and returns the sorted merged list.


    Console.Write("Merge Two Lists: ");
    List<int> mergeList = Merge(list1, list2);
    Console.WriteLine(string.Join(", ", mergeList));

    List<int> Merge(List<int> list1, List<int> list2)
    {
        List<int> mergeList = list1.Concat(list2).ToList();

        return mergeList;
    }
}





