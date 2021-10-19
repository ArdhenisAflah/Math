#include <iostream>
#include <stdlib.h>
#include <string>
#include <cstdlib>
#include <sstream>
using namespace std;


class Lib{
	public:
	
		
		int Count(string str,char delimit){
			//\0 stand for end of text(line).
				static int panjang;
			for(int x =0; str[x]!='\0'; x++){
				if(str[x] == delimit){
					panjang++;
				}
			}
			return panjang;
		}
		//splitter atau delimiter pembagi antar item array.
		int* SplitInit(string std,char delimiter){
			stringstream str;
			
		
			//get length
			int counter = Count(std,delimiter);
			
			//use malloc for allocationg memory.
			  int *A;
			
		
			
			//for loop
			
			int temp =0;
		    for(int x =0; x < counter; x++){
		    	if(std[x]==delimiter){
		    		str << string(1,std[x-1]);
		    		
		    		str >> temp;
		    		A[x-1]=temp;
				}
			}
			
			return A;
			
		}
		
};
class DynamicIntArrayz: public Lib{
	public:
		void getNumber(string arr){
			
		}
};

		

int main(){
	Lib dynamicArray;
	int *p;
    string arr = "26 40 60 70 ";
	int x =dynamicArray.Count(arr,' ');
    cout << "Length: " <<x << endl;
    
    p = (int*)malloc(x * sizeof(int));
   
   
    string S,T;
    
   
    
    stringstream X(arr);
    int c =0;
    while(getline(X,T,' ')){
    	p[c] = stoi(T);
    	c++;
	}
    
  
    
    
    for(int de = 0; de < x; de++){
    	cout << p[de]<<endl;
	}
   
   
   

	return 0;
}
