using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoseVar : MonoBehaviour
{
    public GameObject[] var;

    public void Start()
    {
        var[Random.Range(0,var.Length)].SetActive(true);
    }
}
