using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject[] myBlocks;
    public int variantSpawn;
    public int numbersChooseBlock;
    public int[] numberBlock;

    void Start()
    {
        Next();
    }

   
    void Update()
    {
 
    }

    public void NextOfChooseOfShare()
    {

    }
    
    public void Next()
    {
        if (variantSpawn == 1)
        {

        }
        else
        {
            int index = Random.Range(0, myBlocks.Length);
            Instantiate(myBlocks[index], transform.position, Quaternion.identity);
        }
    }



}
