using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Boundaries : MonoBehaviour
{
    public static int w = 10;
    public static int h = 20;
    public static Transform[,] grid = new Transform[w, h];
    static int score = 0;
    int speed = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    

    void Start()
    {
        scoreText.text = score.ToString();
    }

 
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public static Vector2 round(Vector2 position)
    {
        return new Vector2(Mathf.Round(position.x),
                           Mathf.Round(position.y));
    }


    public static bool inside(Vector2 pos)
    {
        return ((int)pos.x >= 0 && (int)pos.x < w && (int)pos.y >= 0);
    }

    public static void delete(int y)
    {
        for (int i = 0; i < w; ++i)
        {
            Destroy(grid[i, y].gameObject);
            grid[i, y] = null;
        }
    }

    public static void fall(int y)
    {
        for (int i = 0; i < w; ++i)
        {
            if (grid[i, y] != null)
            {
                grid[i, y - 1] = grid[i, y];
                grid[i, y] = null;
                grid[i, y - 1].position += new Vector3(0, -1, 0);
            }
        }
    }

    public static void above(int y)
    {
        for (int i = y; i < h; ++i)
            fall(i);
    }

    public static bool isFull(int y)
    {
        for (int i = 0; i < w; ++i)
            if (grid[i, y] == null)
                return false;
        return true;
    }

    public static void deleteAll()
    {
        for (int y = 0; y < h; ++y)
        {
            if (isFull(y))
            {
                delete(y);
                above(y + 1);
                --y;
                score += 20;
            }
        }
    }

    public int SpeedOfGame()
    {
        if (score % 100 == 0)
        {
            return (speed = 1);
        }
        else
            return (speed = 0);
    }


}
