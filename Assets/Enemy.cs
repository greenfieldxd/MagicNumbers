using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string enemyName;
    public Player playerVar;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, " + playerVar.playerName + ", I am is your Enemy");
        Debug.Log(playerVar);
    }

    public void RunAway()
    {
        Debug.Log("I'm scared");
    }

    void Win()
    {
        Debug.Log("I WON!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
