using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine(arm(153));
  }

  public static int arm(int userNum){
    // Получаем число пользователя в виде строки
    // Полученные эл-ты строки добаляем в коллекцию
    string strNum = Convert.ToString(userNum);
    List<string> nums = new List<string>();

    foreach (var num in strNum)
    {
      nums.Add(num.ToString());
    }

    // С помощью метода Pow() возводим числа в коллекции
    double sum = 0;
    foreach(var num in nums)
    {
      double intValue = Convert.ToDouble(num);
      sum = sum + Math.Pow(intValue, 3);
    }
    
    // Проверяем на число Армстронга
    if(sum == userNum)
        Console.WriteLine("true");
      else
        Console.WriteLine("false");
    return userNum;
  }
}