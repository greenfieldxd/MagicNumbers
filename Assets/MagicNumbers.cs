using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    // Start is called before the first frame update

    int minNumber = 1;
    int maxNumber = 1000;
    int guess;
    string playerName = "Vitya";

    void Start()
    {
        Debug.Log("Добро пожаловать, " + playerName);
        Debug.Log("Загадайте число.");
        Debug.Log("Минимальное число: " + minNumber);
        Debug.Log("Максимальное число: " + maxNumber);

        guess = (minNumber + maxNumber) / 2;
        Debug.Log("Ваше число: " + guess + "?");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Ваше число больше 500");
        }
        
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Ваше число меньше 500");
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Я угадал, ваше число: " + guess);
        }

    }

}
