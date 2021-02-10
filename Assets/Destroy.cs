using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//課題

public class Destroy : MonoBehaviour
{
    private GameObject unitychan;

    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
    }


    void Update()
    {
        if (transform.position.z < unitychan.transform.position.z - 7.0f)
        {
            Destroy(gameObject);
        }
    }
}
