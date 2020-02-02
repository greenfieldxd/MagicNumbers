using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript : MonoBehaviour
{
    int SumOfNumbers;
    int CorrectSum = 50;
    int attempts = 0;

    // Start is called before the first frame update

    void Start()
    {
        Debug.Log("Добро пожаловать, нажимайте цифры от 1 до 9. Доберитесь до 50.");
        SumOfNumbers = 0;
        
    }

    void CheckSum()
    {
        attempts++;
        if (SumOfNumbers >= CorrectSum)
        {
            Debug.Log("Игра окончена. Сумма равна: " + SumOfNumbers + ". Количество попыток: " + attempts);
            attempts = 0;
            SumOfNumbers = 0;
        }
        else
        {
            Debug.Log("Сумма чисел равна: " + SumOfNumbers);
        }
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SumOfNumbers = SumOfNumbers + 1;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SumOfNumbers = SumOfNumbers + 2;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SumOfNumbers = SumOfNumbers + 3;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SumOfNumbers = SumOfNumbers + 4;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SumOfNumbers = SumOfNumbers + 5;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SumOfNumbers = SumOfNumbers + 6;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            SumOfNumbers = SumOfNumbers + 7;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            SumOfNumbers = SumOfNumbers + 8;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            SumOfNumbers = SumOfNumbers + 9;
            CheckSum();
        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            SumOfNumbers = 0;
            Debug.Log("Сумма равна 0.");
        }
    }

}
