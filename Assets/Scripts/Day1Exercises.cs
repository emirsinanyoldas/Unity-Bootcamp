using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1Exercises : MonoBehaviour
{
    //DATA STRUCTURES
//    int class1 = 14;
//    float jumpSpeed = 10.5f;
//    string nameOfPlayer = "Simon";
//    bool isGameOver = false;
//    bool isGameStart = true;
    
    //ARITCHMETIC OPERATIONS
    int a = 7;
    int b = 12;
    int sum;
    // Start is called before the first frame update
    void Start()
    {
/*
        Debug.Log("Bunu kendim yazdým");
        Debug.Log("class1 : " + class1);
        Debug.Log("JumpSpeed : " + jumpSpeed);
        Debug.Log("Player Name : " + nameOfPlayer);
        Debug.Log("Is the game over : " + isGameOver);
        Debug.Log("Is the game start : " + isGameStart);
*/
        int sum1 = a + b;
        Debug.Log("Sum : " + sum);

        bool isEqual = (a == b);
        Debug.Log("are they equal : " + isEqual);

        bool isNotEqual= (a != b);
        Debug.Log("aren't they equal : " + isNotEqual);

        bool isGreaterThan = (a > b);
        Debug.Log("is a greater than b : " + isGreaterThan);

        bool isSunny = false;
        bool isWeekend = true;

        bool goToBeach = isSunny && isWeekend;
        Debug.Log("Can we go to beach : " + goToBeach);

        bool stayHome = isSunny || isWeekend;
        Debug.Log("Are we stay at home : " + !stayHome);

        bool goOut = !isSunny || isWeekend;
        Debug.Log("Can we go out : " + goOut);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
