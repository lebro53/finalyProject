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