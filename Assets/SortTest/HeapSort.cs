using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeapSort : SortClass
{
    public override void Sort()
    {
        BeforeText();
        Heap(list.Length);
        ResultText();
    }

    private void Heap(int length)
    {
        int temp;
        for(int i = length - 1; i > 0; i--)
        {
            if(list[i] > list[(i - 1) / 2])
            {
                temp = list[i];
                list[i] = list[(i - 1) / 2];
                list[(i - 1) / 2] = temp;
            }
        }

        list2[length - 1] = list[0];
        for(int i=0; i < length - 1; i++)
        {
            list[i] = list[i + 1];
        }

        if (length > 1)
        {
            Heap(length - 1);
        }else if(length == 1)
        {
            for(int i = 0; i < list.Length; i++)
            {
                list[i] = list2[i];
            }
        }
    }
}
