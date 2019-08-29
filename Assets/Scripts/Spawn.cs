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
        PlayerPrefs.DeleteKey("5");
        PlayerPrefs.DeleteKey("6");
        PlayerPrefs.DeleteKey("7");

    }
    public void RememberShareZ()
    {
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

    public void RememberShareG()
    {
        if (PlayerPrefs.GetInt("5") == 0)
        {
            PlayerPrefs.SetInt("5", 5);
            numbersChooseBlock = PlayerPrefs.GetInt("number");
            numbersChooseBlock++;
            Debug.Log(numbersChooseBlock);
            PlayerPrefs.SetInt("number", numbersChooseBlock);
        }
    }

    public void RememberShareS()
    {
        if (PlayerPrefs.GetInt("6") == 0)
        {
            PlayerPrefs.SetInt("6", 6);
            numbersChooseBlock = PlayerPrefs.GetInt("number");
            numbersChooseBlock++;
            Debug.Log(numbersChooseBlock);
            PlayerPrefs.SetInt("number", numbersChooseBlock);
        }
    }

    public void RememberShareL()
    {
        if (PlayerPrefs.GetInt("7") == 0)
        {
            PlayerPrefs.SetInt("7", 7);
            numbersChooseBlock = PlayerPrefs.GetInt("number");
            numbersChooseBlock++;
            Debug.Log(numbersChooseBlock);
            PlayerPrefs.SetInt("number", numbersChooseBlock);
        }
    }





    public void Next()
    {
      
        variantSpawn=PlayerPrefs.GetInt("variantSpawn");
    

        if (variantSpawn == 1)
        {
            int n = 0;
            numbersChooseBlock =PlayerPrefs.GetInt("number");
      
            index = Random.Range(0, numbersChooseBlock);
            Debug.Log(numbersChooseBlock);
            Debug.Log(index);
            for (int i=1;i<=7;i++)
            {
                
                if (PlayerPrefs.GetInt(i.ToString()) != 0)
                {
                    nBlock[n] = PlayerPrefs.GetInt(i.ToString())-1;
                    n++;
                }
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