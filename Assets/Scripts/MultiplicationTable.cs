using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
    for (int i =1 ; i < 11; i++)
    {
    int multiplyResult = Multiply(5,i); 
     Debug.Log( 5 + "*" + i + "=" + multiplyResult); 
    }
    }

    int Multiply(int number1 , int number2){
    int result = 0;
    result = number1 * number2 ;
    return result ;
    }
}
