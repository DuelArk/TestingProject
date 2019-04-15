using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour
{
    public Vector3 rotation = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rotation = transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        rotation += Vector3.right;
        transform.eulerAngles = rotation;
    }
}
