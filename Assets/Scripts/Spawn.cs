using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject[] myBlocks;
    public GameObject[] blocksInGame;
    private int _index;

    void Start()
    {
        _index = Random.Range(0, myBlocks.Length);
        Next();
    }

   
    void Update()
    {
        _PlayerNext();
    }

    public void Next()
    {
            Instantiate(myBlocks[_index], transform.position, Quaternion.identity);
            _index = Random.Range(0, blocksInGame.Length);
    }

    private void _PlayerNext()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            _index = 0;
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            _index = 1;

        else if (Input.GetKeyDown(KeyCode.Alpha3))
            _index = 2;

        else if (Input.GetKeyDown(KeyCode.Alpha4))
            _index = 3;
    }

    void isGBlock()
    {
        blocksInGame[0] = myBlocks[0];
    }

    void isSquare()
    {
        blocksInGame[1] = myBlocks[1];
    }
    
    void isStick()
    {
        blocksInGame[2] = myBlocks[2];
    }

    void isTBlock()
    {
        blocksInGame[3] = myBlocks[4];
    }
}
