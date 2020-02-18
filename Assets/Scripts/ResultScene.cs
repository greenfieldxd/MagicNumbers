using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultScene : MonoBehaviour
{

    public Text resultText;

    // Start is called before the first frame update
    void Start()
    {
        MagicNumbersUI magicNumbers = FindObjectOfType<MagicNumbersUI>();
        int number = magicNumbers.guess;
        resultText.text = "Ты молодец! Компьютеру было сложно, но он все равно смог отгадать твое число, равное " + number + ".";

        Destroy(magicNumbers.gameObject); //Destroy Game Object 
        //Destoy(magicNumbers); //destroy component
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
