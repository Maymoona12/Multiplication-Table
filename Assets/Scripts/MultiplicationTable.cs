using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
    for (int i =1 ; i < 11; i++)
    {
     Multiply(5,i);  
    }
    }

    int Multiply(int number1 , int number2){
    int result = 0;
    result = number1 * number2 ;
    Debug.Log( number1 + "*" + number2 + "=" + result);
    return result ;
    }
}
