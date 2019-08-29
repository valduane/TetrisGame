using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    string d;
   // public PlayerPrefsValue[] Nx;
    public int[] Uno = new int[] { 2, 3, 4 };
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("2", 2);
        PlayerPrefs.SetInt("2", 3);
        int x = PlayerPrefs.GetInt("er");
        Debug.Log(x);
        int y = 2;
        d = y.ToString();
        x= PlayerPrefs.GetInt(d);
        Debug.Log(x);
     
    }


    // Update is called once per frame
    void Update()
    {
        
    }


}
/*[SerializeField]
public class PlayerPrefsValue
{
    public string Name;
    public int number;
}
*/