int[] array = { 1, 2, 3, 4, 5, 6 };


Console.WriteLine(Sum(array));
static int Sum(int[] array)
{
    int sum = 0;
    //Previouly I was store are 32 bit integer // 4 bytes
    for (int i = 0; i < array.Length; i++)
    {
        //When we use i, JIT uses zero-extenstion, in that we convert 32 bit to 64 bit or 4 Bytes to 8 Bytes
        //Now we store int as 64 bit or 8 Byte, so we dont use zero extension any more, This is called Induction Variable (IV) windening
        sum+= array[i];
    }
    return sum;
}