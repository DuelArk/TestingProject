using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AR_Ball : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject arCam;
    private Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Physics.CheckSphere(transform.position, 10))
        {
            transform.position = spawnPoint.transform.position;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
