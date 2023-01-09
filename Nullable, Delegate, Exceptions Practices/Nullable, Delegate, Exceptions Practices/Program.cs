


#region Nullable


//string name = null;

//int? num = null;

//if (name == null)
//{
//    Console.WriteLine("dsds");
//}


//int? m = 5;

//GetPersonById(m);

//static void GetPersonById(string id)
//{
//	if (id == null)
//	{
//		Console.WriteLine("NotFound");
//	}
//}
#endregion




using Nullable__Delegate__Exceptions_Practices;
using Nullable__Delegate__Exceptions_Practices.Constatns;
using ServiceLayer.Services;
using ServiceLayer.Services.Interface;

PracticeDelegate calculate = new PracticeDelegate();

//calculate.CheckDelegate();

//calculate.CheckWord();

//calculate.ShowString();







//try
//{
//    int m = 5;
//    int n = 0;
//    var res = m / n;

//    int[] arr = { 1, 2, 3 };

//    arr[5] = 100;
//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);
//}

//Divide(5, 1);
//static void Divide(int n,int m)
//{
//	bool IsSuccess = false;	
//	try
//	{
//		//int[] arr = { 1, 2, 3 };
//		//arr[5] = 100;

//		var result = n / m;

//		IsSuccess = true;
//		Console.WriteLine(result);

//	}
//	catch (Exception ex)
//	{
//		Console.WriteLine(ex.Message);
//		IsSuccess= false;
//	}
//	finally
//	{
//		string message=string.Empty;
//		if (IsSuccess)
//		{
//			message=("Regiater is ok");
//		}
//		else
//		{
//			message=("Something is wrong");
//		}
//		SendEmail(message);
//	}

//}

//static void SendEmail(string message)
//{
//	Console.WriteLine(message);
//}



//Login("pervin123", "pervin12345");
//static void Login(string username, string password)
//{
//	try
//	{
//		if (username == "pervin123" && password == "pervin12345") 
//		{
//			Console.WriteLine("Login is succes");
//		}
//		else
//		{
//			throw new InvalidLoginException(ExceptionMessages.InvalidLogin);
//		}
//	}
//	catch (Exception ex)
//	{
//		Console.WriteLine(ex.Message);
//	}
//}

IEmployeeeService service = new EmployeServices();

Console.WriteLine(service.GetCountByAge(25));