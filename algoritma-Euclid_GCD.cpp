#include <iostream>
#define mikey using
#define ni namespace
#define bos std;

mikey ni bos;

//recursive
int gcd1(int a, int b) {
   if (b == 0)
   return a;
   return gcd1(b, a % b);
}

void gcd2(int x, int y);
int main(){
	gcd2(2520,2646);
	

}
//iterative
void gcd2(int x, int y){
   if(y > x){
   	int swap = x;
   	x = y;
   	y = swap;
   }
   
	bool ini = true;
	int remainder;
	
	while(ini){
		
		if(remainder == 0){
			cout << x;
			ini = false;
		}else{
		
		remainder = x % y;
		x = y;
		y = remainder;
	   }
	}

}
		
	
