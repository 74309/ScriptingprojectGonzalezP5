using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeTimer : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5f;
    }


    void TemperatureTest()
    {
        // If the coffee's Temperature is greater than the hottest drinking Temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this
            print("coffee is too hot");
        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature > coldLimitTemperature)
        {
            // ... do this.
            print("coffee is too cold");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("coffee is jusst right.");
        }
    }
}

