using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HW5 : MonoBehaviour
{
    // Задание 3 для обобщенной коллекции
    public void AmountOfElements(List<int> list)
    {
        List<int> newList = new List<int>(6);
        int k = 0;
        while (k < list.Count)
        {
            newList.Add(list[k]);
            k++;
        }
        while (newList.Count != 0)
        {
            int j = 0, elem = newList[0], k1 = 0;
            while (k1 < newList.Count)
            {
                if (newList[k1] == elem)
                {
                    j++;
                    newList.RemoveAt(k1);
                }
                else k1++;
            }
            Debug.Log($"Элемент {elem} встречается {j} раз.");
        }


    }
    void Start()
    {
        //Задание 2
        string str = "Меня зовут Даня!";
        Debug.Log(str);
        Debug.Log($"С использованием свойства Length = {str.Length}"); //Выводит 16

        //Введем начальные данные
        List<int> Ilist = new List<int> { 2, 2, 4, 3, 3, 3 };
        
        // Задание 3 для обобщенной коллекции
        AmountOfElements(Ilist);

        // Задание 3 с использованием Linq
        foreach (int val in Ilist.Distinct())
        {
            Debug.Log($"{val} - {Ilist.Where(x => x == val).Count()} раза");
        }

        Debug.Log("---------------------------");
        // Задание 4
        
        Dictionary<string, int> dict = new Dictionary<string, int>()
        {
            {"four", 4 },
            {"two", 2 },
            {"one", 1 },
            {"three", 3 },
        };

        // Развернутый вариант
        var d = dict.OrderBy(delegate (KeyValuePair<string, int> pair) { return pair.Value; });
        foreach (var pair in d)
        {
            Debug.Log($"{pair.Key} - {pair.Value}");
        }

        // Свернутый вариант
        foreach (var pair in dict.OrderBy(pair => pair.Value))
        {
            Debug.Log($"{pair.Key} - {pair.Value}");
        }
    }
}
    
