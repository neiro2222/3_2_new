using System;
class HelloWorld {

  static void Main() {
    
    IArray[] base_Array  = new IArray[3];
    
    Console.WriteLine("Введите false, если хотите случайный ввод, иначе введите true");


    bool flag = bool.Parse(Console.ReadLine());
    
    Console.WriteLine("Одномерные массивы ");
    base_Array[0] = new D1_arrays(flag);     
    Console.WriteLine("Двумерные массивы ");   
    base_Array[1] = new D2_arrays(flag);
    Console.WriteLine("Ступенчатые массивы ");
    base_Array[2]= new Step_arrays(flag);

    for (int i = 0; i < base_Array.Length; i++) {
      base_Array[i].Print();
      base_Array[i].Average();
    }
    
    base_Array[0].Change(flag);
    base_Array[0].Print();

    IPrinter[] printer = new IPrinter[4];

    Console.WriteLine("Одномерные массивы ");
    printer[0] = new D1_arrays(flag);     
    Console.WriteLine("Двумерные массивы ");   
    printer[1] = new D2_arrays(flag);
    Console.WriteLine("Ступенчатые массивы ");
    printer[2] = new Step_arrays(flag);
    Console.WriteLine("Дата ");
    printer[3] = new data();

    for (int i = 0; i < printer.Length; i++) {
      base_Array[i].Print();
    }
    
  }

}
