#include "pch.h"
#include <cstdlib>
#include <iostream>
#include <conio.h>
#include <math.h>

using namespace std;


extern "C" __declspec(dllexport) double __stdcall Sum(double a, double b)
{
	return (a + b);
}

extern "C" __declspec(dllexport) double __stdcall Subtract(double a, double b)
{
	return (a - b);
}

extern "C" __declspec(dllexport) double __stdcall Multiply(double a, double b)
{
	return (a * b);
}

extern "C" __declspec(dllexport) double __stdcall Division(double a, double b)
{
	return (a / b);
}

extern "C" __declspec(dllexport) double __stdcall Square(double a)
{
	return (pow(a,2));
}

extern "C" __declspec(dllexport) double __stdcall Factorial(int n)
{
	if (n < 0)
		return 0;
	if (n == 0)
		return 1;
	else
		return n * Factorial(n - 1);
}

