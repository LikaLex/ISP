#pragma once
#include <stdio.h>
#include <math.h>
extern "C" {
	__declspec(dllexport) int addition(int a, int b);
	__declspec(dllexport) int subtraction(int a, int b);
	__declspec(dllexport) int multiplication(int a, int b);
	__declspec(dllexport) double division(int a, int b);
	__declspec(dllexport) int nod(int a, int b);
}