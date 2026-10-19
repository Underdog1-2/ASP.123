using System.Numerics;

namespace Blazor.Components.Pages
{
	public partial class Power
	{
		int number = 2;		//Исходное число
		int power = 0;		//Показатель степени
		BigInteger result = 1;	//Результат возведения в степень

		void Calculate()
		{
			result = BigInteger.Pow(number, Math.Abs(power));
			if (power < 0 && result != 0)
			{
				result = BigInteger.One / result;	//Для целых чисел отрицательная степень даёт 0
			}
		}
	}
}
