using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject[] myBlocks;
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
            _index = Random.Range(0, myBlocks.Length);
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

}
