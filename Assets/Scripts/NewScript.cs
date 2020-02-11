using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour
{
    int sumOfNumbers;
    int correctSum = 50;
    int attempts = 0;

    // Start is called before the first frame update

    void Start()
    {
        Debug.Log("Добро пожаловать, нажимайте цифры от 1 до 9. Доберитесь до 50.");
        sumOfNumbers = 0;
        
    }

    void CheckSum()
    {
        attempts++;
        if (sumOfNumbers >= correctSum)
        {
            Debug.Log("Игра окончена. Сумма равна: " + sumOfNumbers + ". Количество попыток: " + attempts);
            attempts = 0;
            sumOfNumbers = 0;
        }
        else
        {
            Debug.Log("Сумма чисел равна: " + sumOfNumbers);
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            sumOfNumbers = sumOfNumbers + 1;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            sumOfNumbers = sumOfNumbers + 2;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            sumOfNumbers = sumOfNumbers + 3;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            sumOfNumbers = sumOfNumbers + 4;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            sumOfNumbers = sumOfNumbers + 5;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            sumOfNumbers = sumOfNumbers + 6;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            sumOfNumbers = sumOfNumbers + 7;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            sumOfNumbers = sumOfNumbers + 8;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            sumOfNumbers = sumOfNumbers + 9;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            sumOfNumbers = 0;
            Debug.Log("Сумма равна 0.");
        }
    }

}
