#region Task1
//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.


//GetNumber(20);


//static void GetNumber(int n = 21)
//{
//	if (n % 3 == 0 && n % 7 == 0)
//	{
//		Console.WriteLine("bolunur");
//	}
//	else
//	{
//		Console.WriteLine("bolunmur");
//	}
//}
#endregion

#region Task2
//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.



//GetSum(2,4 );
//static void GetSum(int n,int m)
//{

//    int sum = 0;

//	if (n % 2 == 0 && m % 2 == 0 )
//	{
//		sum = n + m;
//		Console.WriteLine(sum);
//	}
//	else
//	{
//		Console.WriteLine("duzgun reqem daxil edin");
//	}

//}

#endregion

#region Task3
//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.



//    static int GetNumSum(int n , int m )
//{
//	int sum = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 1)
//		{
//            sum += i;
//        }


//	}
//    return sum;

//}
//var result = GetNumSum(5, 10);

//Console.WriteLine( result);



#endregion

#region Task4

//4) Verilmish arrayin icindeki tek ededlerin cemini tapin.

//int[] arr = {1,2,5,8,9,10 };


//GetArrSum(arr);
//static void GetArrSum(int[] arr)
//{
//	int sum = 0;
//	foreach (int item in arr)
//	{
//		if (item % 2 == 1)
//		{
//			sum += item;

//		}
//	}
//	Console.WriteLine(sum);
//}


#endregion

#region Task5
//5) Verilmish arrayin icindeki cut ededlerin sayini tapin.


//int[] arr = { 1, 2, 3, 6, 7, 8, 10 };

//GetSumArr(arr);

//static void GetSumArr(int[] arr)
//{
//	 int count = 0;
//	foreach (var item in arr)
//	{
//		if (item % 2 == 0)
//		{
//			count++;

//		}
//	}
//	Console.WriteLine(count);
//}


#endregion

#region Task6
//6) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.


//GetNumCount(1, 10);
//static void GetNumCount(int n,int m)
//{
//    int count = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 1) 
//		{
//			count++;
//		}
//	}
//	Console.WriteLine(count);
//}
#endregion

#region Task7
//7) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.



//GetNumberSum(1, 10);

//static void GetNumberSum(int n, int m)
//{
//	int sum = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 0)
//		{
//			sum+=i;
//		}
//	}
//	Console.WriteLine(sum);
//}
#endregion

#region Task8
//8) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.

//GetNumCount(1, 10);
//static void GetNumCount(int n, int m)
//{
//	int count = 0;
//	for (int i = n; i < m; i++)
//	{
//		if (i % 2 == 0)
//		{
//			count++;
//		}
//	}
//	Console.WriteLine(count);
//}



#endregion

#region Task9
//9) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.


//GetComplexOrPromise(10);
//static void GetComplexOrPromise(int n)
//{
//	int count = 0;
//	if (n < 0)
//	{
//		Console.WriteLine("duzgun reqem daxil edin");
//	}
//	else if (n == 1)
//	{
//		Console.WriteLine("ne sadedir ne murekkeb");
//	}
//	for (int i = 1; i <= n; i++)
//	{
//		if (i % 2 == 0)
//		{
//			count ++;
//		}
//	}
//	if (count > 2)
//	{
//		Console.WriteLine("murekkeb ededdir");
//	}
//	else
//	{
//		Console.WriteLine("sade eddedir");
//	}

//}


#endregion

#region Task10
//10)n ededinin faktorialini hesablamaq.



//GetFactorial(3);
// static void GetFactorial(int n)
//{
//	int multiple = 1;
//	for (int i = 1; i <= n; i++)
//	{
//		multiple*= i;
//	}
//	Console.WriteLine(multiple);
//}

#endregion





















