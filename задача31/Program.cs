﻿//Задать массив из 8 элементов и вывести их на экран

int[] a = new int[8];
Random random = new Random();
for(int i=0; i<a.Length; i++)
    a[i]=random.Next(0,10);
for(int i=0; i<a.Length; i++)
    Console.Write(a[i]+" ");