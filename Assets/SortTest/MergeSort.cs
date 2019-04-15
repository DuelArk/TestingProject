using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MergeSort : SortClass
{
    public override void Sort()
    {
        BeforeText();
        Divide(0, list.Length - 1);
        ResultText();
    }

    private void Divide(int low, int high)
    {
        int mid;
        if(low < high)
        {
            mid = (low + high) / 2;
            Divide(low, mid);
            Divide(mid + 1, high);
            Merge(low, mid, high);
        }
    }

    private void Merge(int low, int mid, int high)
    {
        int i = low;
        int j = mid + 1;
        int k = low;

        while(i <= mid && j <= high)
        {
            if (list[i] < list[j])
            {
                list2[k++] = list[i++];
            }
            else if (list[i] >= list[j])
            {
                list2[k++] = list[j++];
            }
        }

        if(i >= mid)
        {
            while (j <= high)
            {
                list2[k++] = list[j++];
            }
        }

        if (j >= high)
        {
            while (i <= mid)
            {
                list2[k++] = list[i++];
            }
        }

        for(int a = low; a <= high; a++)
        {
            list[a] = list2[a];
        }
    }
}
