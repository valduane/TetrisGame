using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject[] myBlocks;
   

    void Start()
    {
        Next();
    }

   
    void Update()
    {
  
    }

    public void Next()
    {
        int index = Random.Range(0, myBlocks.Length);
        Instantiate(myBlocks[index], transform.position, Quaternion.identity);
    }



}
