#include <bits/stdc++.h>

using namespace std;

int main(){
	long long T,N,result;

	
	//test case
	cin >> T;
	
	while(T-- > 0){
		//input size array
		
		cin >> N;
		
		long long A[N];
		
		long long odd =0;
		long long even =0;
		
		
		for(long long x =0; x < N; x++){
			cin >> A[x];
			if(A[x] % 2 == 1){
				odd++;
			}else{
			    even++;
			}
			
			
		}
		
	
		
		
		
		
	
		
		
		result = odd / 2;
		cout << result << '\n';
	

	}
		return 0;
}
