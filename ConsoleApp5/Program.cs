
using System;
using System.Collections;

class StringCollection
{
    static void Main()
    {
      
        ArrayList al = new ArrayList();

        Console.WriteLine("Исходное количество элементов: " + al.Count);

        Console.WriteLine();

        Console.WriteLine("Добавить 6 элементов");
        
        al.Add('С');
        al.Add('A');
        al.Add('E');
        al.Add('В');
        al.Add('D');
        al.Add('F');

        Console.WriteLine("Количество элементов: " + al.Count);

  
        Console.Write("Текущее содержимое: ");
        for (int i = 0; i < al.Count; i++)
            Console.Write(al[i] + " ");
        Console.WriteLine("\n");

        Console.WriteLine("Удалить 2 элемента");

        al.Remove('F');
        al.Remove('A');

        Console.WriteLine("Количество элементов: " + al.Count);

        
        Console.Write("Содержимое: ");
        foreach (char с in al)
            Console.Write(с + " ");
        Console.WriteLine("\n");

        Console.WriteLine("Добавить еще 20 элементов");
     
        for (int i = 0; i < 20; i++)
            al.Add((char)('a' + i));
        Console.WriteLine("Текущая емкость: " + al.Capacity);
        Console.WriteLine("Количество элементов после добавления 20 новых: " +
                        al.Count);
        Console.Write("Содержимое: ");
        foreach (char с in al)
            Console.Write(с + " ");
        Console.WriteLine("\n");

        
        Console.WriteLine("Изменить три первых элемента");
        al[0] = 'X';
        al[1] = 'Y';
        al[2] = 'Z';
        Console.Write("Содержимое: ");
        foreach (char с in al)
      
        Console.WriteLine("");
    }
}