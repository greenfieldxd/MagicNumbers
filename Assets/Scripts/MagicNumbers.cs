using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicNumbers : MonoBehaviour
{
    // Start is called before the first frame update

    int minNumber = 1;
    int maxNumber = 1000;
    int guess;
    int attempts = 1;
    string playerName = "Vitya";

    void Start()
    {
        Debug.Log("Добро пожаловать, " + playerName);
        StartGame();
    }

    void StartGame()
    {
        minNumber = 1;
        maxNumber = 1000;

        Debug.Log("Загадайте число.");
        Debug.Log("Минимальное число: " + minNumber);
        Debug.Log("Максимальное число: " + maxNumber);
        UpdateGuess();
    }

    void UpdateGuess()
    {
        guess = (minNumber + maxNumber) / 2;
        Debug.Log("Ваше число: " + guess + "?");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minNumber = guess;
            attempts++;
            UpdateGuess();
        }
        
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxNumber = guess;
            attempts++;
            UpdateGuess();
        }

        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Я угадал, ваше число: " + guess + ". Колличество попыток: " + attempts);
            StartGame();
        }

    }

}
