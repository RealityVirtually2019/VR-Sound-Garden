using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Transform player;
    public ArrayList waterableAssets;
    public AudioSource waterSound;
 

    // Update is called once per frame
    void Update()
    {

        if (pouring())
        {
            waterSound.volume = 1;
            int j = 0;
            while (j< waterableAssets.Count)
            {
                if (inRange(waterableAssets[j]))
                {
                    //Increase water percentage by some rate
                    increasePercentage(waterableAssets[j]);
                }
                j += 1;
            }
        }
        
        if (pointingToTele())
        {
            // Tele to direction by step amount
        }

        if (!pouring())
        {
            waterSound.volume = 0;
        }
        
    }
// Todo:
    void teleToPoint()
    {

    }
    bool pointingToTele()
    {
        return (leftTriggerDown() && leftJoystick());
    }
    bool leftTriggerDown()
    {
        return true;
    }
    bool leftJoystick()
    {
        return true;
    }
    void increasePercentage(object o)
    {

    }
    bool inRange(object t)
    {
        return true;
    }

    bool pouring()
    {
        return (belowAxis() && triggerHeld());
    }

    bool belowAxis()
    {
        return true;
    }

    bool triggerHeld()
    {
        return true;
    }

    
}
