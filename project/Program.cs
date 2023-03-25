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