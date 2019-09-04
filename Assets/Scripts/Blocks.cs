using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Blocks : MonoBehaviour
{

    float falling = 0f;
    public AudioClip BreakSound;
    static public float toFall = 1f;
    Vector2 moveDirection = Vector2.zero;
    float side = 0f;

    void Start()
    {
        if (!isDontCollide())
        {
            int SceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(SceneIndex);
            Boundaries.score = 0;
        }
    }


    void Update()
    {
        if (tag == "Block" || tag == "Square")
            Movement();
        Touches();
    }

    bool isDontCollide()
    {
        foreach (Transform child in transform)
        {
            Vector2 v = Boundaries.round(child.position);
            if (!Boundaries.inside(v))
                return false;
            if (Boundaries.grid[(int)v.x, (int)v.y] != null && Boundaries.grid[(int)v.x, (int)v.y].parent != transform)
                return false;
        }
        return true;
    }

    void updateGrid()
    {
        for (int y = 0; y < Boundaries.h; ++y)
            for (int x = 0; x < Boundaries.w; ++x)
                if (Boundaries.grid[x, y] != null)
                    if (Boundaries.grid[x, y].parent == transform)
                        Boundaries.grid[x, y] = null;
        foreach (Transform child in transform)
        {
            Vector2 v = Boundaries.round(child.position);
            Boundaries.grid[(int)v.x, (int)v.y] = child;
        }
    }

    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0);
            if (isDontCollide())
                updateGrid();
            else
                transform.position += new Vector3(1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0);
            if (isDontCollide())
                updateGrid();
            else
                transform.position += new Vector3(-1, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && tag != "Square")
        {
            transform.Rotate(0, 0, -90);
            if (isDontCollide())
                updateGrid();
            else
                transform.Rotate(0, 0, 90);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Time.time - falling >= toFall)
        {
            transform.position += new Vector3(0, -1, 0);
            if (isDontCollide())
            {
                updateGrid();
            }
            else
            {
                transform.position += new Vector3(0, 1, 0);
                Boundaries.deleteAll();
                if (SceneManager.GetActiveScene().buildIndex != 4)
                {
                    AudioSource.PlayClipAtPoint(BreakSound, Camera.main.transform.position);
                }
                gameObject.tag = "Dead";
                FindObjectOfType<Spawn>().Next();
                enabled = false;
            }
            falling = Time.time;
        }
    }

    void SpeedStatus()
    {
        bool stat = Boundaries.SpeedOfGame();
        if (stat)
        {
            toFall -= 0.5f;
            stat = false;
            Debug.Log(toFall);
        }
    }

    public void LeftMovement()
    {
        transform.position += new Vector3(-1, 0, 0);
        if (isDontCollide())
            updateGrid();
        else
            transform.position += new Vector3(1, 0, 0);
    }

    public void RightMovement()
    {
        transform.position += new Vector3(1, 0, 0);
        if (isDontCollide())
            updateGrid();
        else
            transform.position += new Vector3(-1, 0, 0);
    }

    public void DownMovement()
    {
        if (tag != "Dead")
        {
            transform.position += new Vector3(0, -1, 0);
            if (isDontCollide())
            {
                updateGrid();
            }
            else
            {
                transform.position += new Vector3(0, 1, 0);
                Boundaries.deleteAll();
                if (SceneManager.GetActiveScene().buildIndex != 4)
                {
                    AudioSource.PlayClipAtPoint(BreakSound, Camera.main.transform.position);
                }
                gameObject.tag = "Dead";
                FindObjectOfType<Spawn>().Next();
                enabled = false;
            }
            falling = Time.time;
        }
    }

    void Up()
    {
        if (tag != "Square")
        {
            transform.Rotate(0, 0, -90);
            if (isDontCollide())
                updateGrid();
            else
                transform.Rotate(0, 0, 90);
        }
    }
    void Touches()
    {
        if (tag != "Dead")
 {
            if (Input.touchCount > 0 && Time.time - side >= 0.3f)
            {
                Touch touch = Input.GetTouch(0);
                Vector2 posOnScreen = touch.position;
                if (Screen.orientation == ScreenOrientation.LandscapeLeft)
                {
                    if (posOnScreen.x > Screen.width - (Screen.width / 3))
                        RightMovement();
                    else if (posOnScreen.x < Screen.width / 3)
                        LeftMovement();
                    else if (posOnScreen.y > Screen.height / 2)
                        Up();
                    else if (posOnScreen.y < Screen.height / 2)
                        DownMovement();
                    Debug.Log(posOnScreen);
                    side = Time.time;
                }
                else if (Screen.orientation == ScreenOrientation.Portrait)
                {
                    if (posOnScreen.x > Screen.width - (Screen.width / 3))
                        RightMovement();
                    else if (posOnScreen.x < Screen.width / 3)
                        LeftMovement();
                    else if (posOnScreen.y > Screen.height/2)
                        Up();
                    else if (posOnScreen.y < Screen.height / 2)
                        DownMovement();
                    Debug.Log(posOnScreen);
                    side = Time.time;
                }
            }
    }
}



}

