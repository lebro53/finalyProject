// Method--------------------------------------------------
int Promt(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
string ElemArray(string massege)
{
	Console.WriteLine(massege);
	string value = Console.ReadLine();
	return value;
}
string[] CreateArrayString(int size)
{
	string[] array = new string[size];
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = ElemArray("Введите элемент массива: ");
	}
	return array;
}
int QuantityElemArrayLessThree(string[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i].Length <= 3)
		{
			count++;
		}
	}
	return count;
}
string[] NewArrayString(string[] array, int size)
{
	int count = 0;
	string[] newArray = new string[size];
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i].Length <= 3)
		{
			newArray[count] = array[i];
			count++;
		}
	}
	return newArray;
}
void PrintArray(string[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write($"{array[i]}, ");
		else Console.Write($"{array[i]}");
	}
	Console.WriteLine("]");
}


// Program body--------------------------------------------
int number = Promt("Введите размер массива: ");
if (number > 0)
{
	string[] arr = CreateArrayString(number);
	int quantity = QuantityElemArrayLessThree(arr);
	string[] newArr = NewArrayString(arr, quantity);
	Console.Clear();
	PrintArray(arr);
	Console.WriteLine();
	PrintArray(newArr);
}
else Console.WriteLine("Размер массива должен быть больше 0!");