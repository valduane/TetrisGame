using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] myBlocks;
    public int variantSpawn;
    public int numbersChooseBlock=0;
    public int[] nBlock=new int[7];
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
        PlayerPrefs.SetInt("variantSpawn", 1);
      
        Debug.Log(variantSpawn);

    }
    public void ClickModeSetOfShare()
    {
        PlayerPrefs.SetInt("number", 0);
        PlayerPrefs.DeleteKey("1");
        PlayerPrefs.DeleteKey("2");
        PlayerPrefs.DeleteKey("3");
        PlayerPrefs.DeleteKey("4");
    }
    public void RememberShareZ()
    {
        Debug.Log("sd");
        if (PlayerPrefs.GetInt("1") == 0)
        {
            PlayerPrefs.SetInt("1", 1);
            numbersChooseBlock = PlayerPrefs.GetInt("number");
            numbersChooseBlock++;
            
            PlayerPrefs.SetInt("number", numbersChooseBlock);
        }
    }
    
    public void RememberShareO()
    {
        if (PlayerPrefs.GetInt("2") == 0)
        {
            PlayerPrefs.SetInt("2", 2);
            numbersChooseBlock = PlayerPrefs.GetInt("number");
            numbersChooseBlock++;
            Debug.Log(numbersChooseBlock);
            PlayerPrefs.SetInt("number", numbersChooseBlock);
        }
}
    
    public void RememberShareI()
    {
        if (PlayerPrefs.GetInt("3") == 0)
        {
            PlayerPrefs.SetInt("3", 3);
            numbersChooseBlock = PlayerPrefs.GetInt("number");
            numbersChooseBlock++;
            Debug.Log(numbersChooseBlock);
            PlayerPrefs.SetInt("number", numbersChooseBlock);
        }
    }
    public void RememberShareT()
    {
        if (PlayerPrefs.GetInt("4") == 0)
        {
            PlayerPrefs.SetInt("4", 4);
            numbersChooseBlock = PlayerPrefs.GetInt("number");
            numbersChooseBlock++;
            Debug.Log(numbersChooseBlock);
            PlayerPrefs.SetInt("number", numbersChooseBlock);
        }
    }


    public void Next()
    {
      
        variantSpawn=PlayerPrefs.GetInt("variantSpawn");
        Debug.Log(variantSpawn);

        if (variantSpawn == 1)
        {
            numbersChooseBlock=PlayerPrefs.GetInt("number");
            Debug.Log(numbersChooseBlock);
            index = Random.Range(0, numbersChooseBlock-1);
            for(int i=1;i<= numbersChooseBlock;i++)
            {
                nBlock[i-1]= PlayerPrefs.GetInt(i.ToString());
            }
            Debug.Log(nBlock[index]);
            Instantiate(myBlocks[nBlock[index]], transform.position, Quaternion.identity);
        }
        else
        {
           // Debug.Log(numberBlock.Length);
           // Debug.Log("debug");
            index = Random.Range(0, myBlocks.Length);
            Instantiate(myBlocks[index], transform.position, Quaternion.identity);
        }
    }
}