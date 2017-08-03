#include <math.h>
extern "C" {
	__declspec(dllexport) int addition(int a, int b) {
		return a + b;
	}
	__declspec(dllexport) int subtraction(int a, int b) {
		return a - b;
	}
	__declspec(dllexport) int multiplication(int a, int b) {
		return a * b;
	}
	__declspec(dllexport) double division(int a, int b) {
		return a * 1.0 / b ;
	}
	__declspec(dllexport) int nod(int a, int b) {
		int p = 0;
		a = abs(a); b = abs(b);
		if (b > a)
		{
			p = a;
			a = b;
			b = p;
		}
		do
		{
			p = a % b; a = b; b = p;
		} while (b != 0);
		return (a);
	}
}