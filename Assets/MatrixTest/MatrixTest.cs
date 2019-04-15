using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatrixTest : MonoBehaviour
{
    private Matrix4x4 vm;
    public Text text1;
    public Text text2;

    // Start is called before the first frame update
    void Start()
    {
        vm = Camera.main.worldToCameraMatrix;
    }

    // Update is called once per frame
    void Update()
    {
        text1.text = Camera.main.name + "\n\n" + Camera.main.worldToCameraMatrix;
        text2.text = gameObject.name + "\n\n" + transform.localToWorldMatrix;
        Matrix4x4 p = vm;
        p.m01 += Mathf.Sin(Time.time * 1.2f) * 0.1f; //세로를 축으로 흔들리는 느낌?
        p.m10 += Mathf.Sin(Time.time * 1.5f) * 0.1f; //가로를 축으로 흔들리는 느낌?
        p.m00 += Mathf.Cos(Time.time * 1.2f) * 0.1f; //세로를 축으로 누르는 느낌?
        p.m11 += Mathf.Cos(Time.time * 1.5f) * 0.1f; //가로를 축으로 누르는 느낌?
        Camera.main.worldToCameraMatrix = p;
    }
}
