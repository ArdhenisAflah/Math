Contoh Soal 6.1: Activity Selection
Anda diberikan N buah aktivitas. Aktivitas ke-i dinyatakan dalam hai
.start,ai
.endi. Artinya,
aktivitas ini dimulai pada waktu ai
.start dan berakhir pada waktu ai
.end. Pada setiap
satuan waktu, Anda dapat mengikuti paling banyak satu aktivitas. Dengan kata lain, Anda
dapat mengikuti dua aktivitas i dan j jika ai
.end ≤ aj
.start atau aj
.end ≤ ai
.start. Anda ingin
mengatur jadwal sedemikian sehingga Anda bisa mengikuti aktivitas sebanyak mungkin.
Contoh
Aktivitas: [{1,3},{2,6},{5,7},{8,9}]
Solusi: Anda dapat hadir di 3 aktivitas berbeda yang tidak saling tumpang tindih, yaitu [{1,3},
{5,7}, dan {8,9}]

Pseudo Code/Algoritma:

: function SOLVEACTIVITYSELECTION(a,N)
2: SortByEndTime(a,N) . Urutkan a secara menaik berdasarkan a[i].end
3: selectedCount ← 0
4: startTime ← 0
5: for i ← 1, N do
6: if (a[i].start ≥ startTime) then
7: selectedCount ← selectedCount +1
8: startTime ← a[i].end
9: end if
10: end for
11: return selectedCount
12: end function
