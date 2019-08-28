using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] myBlocks;
    public int variantSpawn;
    public int numbersChooseBlock;
    public int[] numberBlock=new int[4];
    public bool SerchShare = true;
    public int index;


    void Start()
    {
        Next();
    }


    void Update()
    {
    }
    public void ClickStart()
    {
        variantSpawn = 1;

    }
    public void RememberShareZ()
    { 
        for(int i=0;i<=numbersChooseBlock;i++)
        if(numberBlock[i]==0)
                SerchShare =false;
        if (SerchShare)
        {
            numberBlock[numbersChooseBlock + 1] = 0;
            numbersChooseBlock++;
        }
    }
    public void RememberShareO()
    {
        for (int i = 0; i <= numbersChooseBlock; i++)
            if (numberBlock[i] == 1)
                SerchShare = false;
            if (SerchShare)
            {
              numberBlock[numbersChooseBlock + 1] = 1;
              numbersChooseBlock++;
            }
}
    public void RememberShareI()
    {
        for (int i = 0; i <= numbersChooseBlock; i++)
            if (numberBlock[i] == 2) SerchShare = false;
        if (SerchShare)
        { 
            numberBlock[numbersChooseBlock + 1] = 2;
            numbersChooseBlock++;
        }
    }
    public void RememberShareT()
    {
        for (int i = 0; i <= numbersChooseBlock; i++)
            if (numberBlock[i] == 0) SerchShare = false;
        if (SerchShare)
        { 
            numberBlock[numbersChooseBlock + 1] = 3;
            numbersChooseBlock++;
        }
    }
    
    public void Next()
    {
        Debug.Log(variantSpawn);
        if (variantSpawn == 1)
        {
            index = Random.Range(0, numbersChooseBlock-1);
            Instantiate(myBlocks[numberBlock[index]], transform.position, Quaternion.identity);
        }
        else
        {
            index = Random.Range(0, myBlocks.Length);
            Instantiate(myBlocks[index], transform.position, Quaternion.identity);
        }
 