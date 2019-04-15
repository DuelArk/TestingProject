using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class SortClass : MonoBehaviour
{
    [Range(0,10)]
    public int listLength;
    public int[] list;
    public Text beforeText;
    public Text resultText;
    public int[] list2;

    void Start()
    {
        list = new int[listLength];
        list2 = new int[listLength];
        for (int i = 0; i < listLength; i++)
        {
            list[i] = Random.Range(0, 21);
        }
    }

    public void BeforeText()
    {
        string str = "";
        for (int i = 0; i < list.Length; i++)
        {
            str += list[i] + " ";
        }
        beforeText.text = str;
    }

    public void ResultText()
    {
        string str = "";
        for(int i = 0; i < list.Length; i++)
        {
            str += list[i] + " ";
        }
        resultText.text = str;
    }

    public abstract void Sort();
}
