using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MagicNumbersUI : MonoBehaviour
{

    public int minNumber = 1;
    public int maxNumber = 1000;
    int guess;
    int attempts = 1;

    public Text textGuess;
    public TextMeshProUGUI textCount;


    void Start()
    {
        //guess = (minNumber + maxNumber) / 2;   до этого работало через эту строку, сделали через Рандом

        guess = Random.Range(minNumber, maxNumber + 1);
        textGuess.text = "Ваше число " + guess + "?";
        textCount.text = "Attempts: " + attempts;

    }

    public void Lager()
    {
        minNumber = guess;
        UpdateGuess();
        Start();
    }

    public void Smaller()
    {
        maxNumber = guess;     
        UpdateGuess();
        Start();
    }

    void UpdateGuess()
    {
        guess = (minNumber + maxNumber) / 2;
        attempts++;
    }
}
