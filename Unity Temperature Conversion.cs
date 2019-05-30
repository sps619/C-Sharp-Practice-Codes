using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        double fahrenheit = 0;
        print("Fahrenheit Temperature input: " + fahrenheit);
        double celsius = (fahrenheit - 32) / 9;
        celsius *= 5;
        print("Temperature in Celsius: " + celsius);
        double calFahrenheit = (celsius * 9) / 5;
        calFahrenheit += 32;
        print("Temperature in Fahrenheit: " + calFahrenheit);
        
    }
}
