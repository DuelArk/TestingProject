using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSort : SortClass
{
    public override void Sort()
    {
        BeforeText();
        Quick(0, list.Length - 1);
        ResultText();
    }

    private void Quick(int begin, int end)
    {
        if(begin < end)
        {
            int left = begin;
            int right = end;
            int pivot = Random.Range(begin, end + 1);
            int temp;

            while(left < right)
            {
                while(list[left] < list[pivot] && left < right)
                {
                    left++;
                }
                while(list[right] >= list[pivot] && left < right)
                {
                    right--;
                }
                if(left < right)
                {
                    temp = list[left];
                    list[left] = list[right];
                    list[right] = temp;
                }
            }

            temp = list[pivot];
            list[pivot] = list[right];
            list[right] = temp;

            Quick(begin, left - 1);
            Quick(left + 1, end);
        }
    }
}
