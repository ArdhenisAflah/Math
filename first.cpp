#include <iostream>
#include <ctype.h>
using namespace std;

int main(){
	string inputan = "";
	string numvar;
	string numtarget;
	string hasil;
	
	double dy;
	double dx;
	double result;
    //inputan
    /*
	1. 4x=16
	2. 16=4x
	3. 
	
	*/
	getline(cin,inputan);
	for(int x =0; x <20; x++){
		
		if(isdigit(inputan[x]) && inputan[x]!= '='){
			//jika x ada disamping kiri
			
			if(inputan[x+1] == 'x'){
			     
				cout << "INPUTAN KE" << x << inputan[x] << endl;
				for(int c =0; c < x+1; c++){
					
					numvar += inputan[c];
					
				}
				
				for(int s = x+1; s <= inputan.length(); s++){
					if(isdigit(inputan[s])){
						numtarget+=inputan[s];
					}
				}
				break;
		}
			//jika x  ada di samping kanan/.
		}else{
			for(int d = x+1;  d<=(inputan.length()-x); d++){
				numvar += inputan[d];
			}
			for(int cs = 0; cs<x+1; cs++){
					if(isdigit(inputan[cs])){
						numtarget+=inputan[cs];
					}
			}
			
			break;
		}
		
	}

  	dx = stod(numvar);
  	dy = stod(numtarget);
  	result = dy/dx;
  	
  	cout << result<<endl;
	
   

	return 0;
}
