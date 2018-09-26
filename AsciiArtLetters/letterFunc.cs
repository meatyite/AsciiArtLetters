using System;
using System.Runtime.InteropServices;
using AsciiArtLetters;

namespace AsciiArtLetters
{
	[ComVisible(true)]
	public static class letterFunc
	{

        //checks if char is upper
		public static bool isUpper(char chr)
		{
			return char.IsUpper(chr);
		}

		public static string get(char toGet, int font)
		{
			string str = String.Empty;

            switch (font)
			{
				case(0):
					switch (toGet) 
					{
						case ('a'):
							str = GraffitiL.a();
							break;
						case('b'):
							str = GraffitiL.b();
							break;
						case('c'):
							str = GraffitiL.c();
							break;
						case('d'):
							str = GraffitiL.d();
							break;
						case ('e'):
                            str = GraffitiL.e();
                            break;
						case ('f'):
                            str = GraffitiL.f();
                            break;
						case ('g'):
                            str = GraffitiL.g();
                            break;
						case ('h'):
                            str = GraffitiL.h();
                            break;
						case ('i'):
							str = GraffitiL.i();
							break;
						case('j'):
							str = GraffitiL.j();
							break;
						case ('k'):
							str = GraffitiL.k();
							break;
						case ('l'):
							str = GraffitiL.l();
							break;
						case ('m'):
                            str = GraffitiL.m();
							break;
						case('n'):
							str = GraffitiL.n();
							break;
						case('o'):
							str = GraffitiL.o();
							break;
						case('p'):
							str = GraffitiL.p();
							break;
						case('q'):
							str = GraffitiL.q();
							break;
						case('r'):
							str = GraffitiL.r();
							break;
						case('s'):
							str = GraffitiL.s();
							break;
						case('t'):
							str = GraffitiL.t();
							break;
						case ('u'):
                            str = GraffitiL.u();
                            break;
						case ('v'):
                            str = GraffitiL.v();
                            break;
						case ('w'):
                            str = GraffitiL.w();
                            break;
						case('x'):
							str = GraffitiL.x();
							break;
						case('y'):
							str = GraffitiL.y();
							break;
						case('z'):
							str = GraffitiL.z();
							break;
						case ('A'):
                            str = GraffitiH.a();
                            break;
						case ('B'):
                            str = GraffitiH.b();
                            break;
						case ('C'):
                            str = GraffitiH.c();
                            break;
						case ('D'):
                            str = GraffitiH.d();
                            break;
						case ('E'):
                            str = GraffitiH.e();
                            break;
						case ('F'):
                            str = GraffitiH.f();
                            break;
                        case ('G'):
                            str = GraffitiH.g();
                            break;
                        case ('H'):
                            str = GraffitiH.h();
                            break;
                        case ('I'):
                            str = GraffitiH.i();
                            break;
                        case ('J'):
                            str = GraffitiH.j();
                            break;
                        case ('K'):
                            str = GraffitiH.k();
                            break;
                        case ('L'):
                            str = GraffitiH.l();
                            break;
                        case ('M'):
                            str = GraffitiH.m();
                            break;
                        case ('N'):
                            str = GraffitiH.n();
                            break;
                        case ('O'):
                            str = GraffitiH.o();
                            break;
                        case ('P'):
                            str = GraffitiH.p();
                            break;
                        case ('Q'):
                            str = GraffitiH.q();
                            break;
                        case ('R'):
                            str = GraffitiH.r();
                            break;
                        case ('S'):
                            str = GraffitiH.s();
                            break;
                        case ('T'):
                            str = GraffitiH.t();
                            break;
                        case ('U'):
                            str = GraffitiH.u();
                            break;
                        case ('V'):
                            str = GraffitiH.v();
                            break;
                        case ('W'):
                            str = GraffitiH.w();
                            break;
                        case ('X'):
                            str = GraffitiH.x();
                            break;
                        case ('Y'):
                            str = GraffitiH.y();
                            break;
                        case ('Z'):
                            str = GraffitiH.z();
                            break;
					}
					break;
			}

			return str;
		}


		//TODO: make a getall() function that combines all the given strings into a single readable string
	}
}
