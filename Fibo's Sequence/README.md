## Fibo's Sequence
Fibo is a big fan of numbers, specially of big ones. He loves sequences that grow fast, his favorite is a well know sequence, the Fibonacci Sequence. Someday he decided to create a new sequence using his favorite one. His new sequence is build multiplying consecutive Fibonacci numbers. So he gets two initial Fibonacci numbers of indexes A and B. The first element of the new sequence is the Fibonacci number of index A multiplied by the number of index B, the second one is the Fibonacci number of index A+1 multiplied by the number of index B+1, and so on. He knows how to get any element of his sequence, but he would like to know another thing. He would like to know the sum of the first N numbers of the new sequence. Can you help him?

PS:Fibonacci(0) = 0 and Fibonacchi(1) = 1

Input
The input file has a lot of test cases. Each test case has three integers, A, B, and N(1 <= A, B, B <= 1000000000), their meaning was explained in the text above. The input ends with three zeros.

Output
For each test case you hace to pring one number, the sum of the N first elements of Fibo's sequence. This numbers can be really large, so you have to print it MOD 1000000007.
Sample Input
1 1 5
3 4 5
0 0 0
Sample Output
40
438
