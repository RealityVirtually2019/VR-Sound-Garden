using System.Collections;
using UnityEngine;

public class music_scaling : MonoBehaviour
{
    public AudioSource deadSource;
    public AudioSource betterSource;
    public AudioSource bestSource;
    public float mindistance = 6.0f;
    public float maxdistance = 10.0f;
    public Transform player;
    public float startingWater;
    // Update is called once per frame
    void Update()
    {
        deadSource.volume = getDistanceScaledVolume()* getSourcesWaterMaxVolume(deadSource);
        betterSource.volume = getDistanceScaledVolume()* getSourcesWaterMaxVolume(betterSource);
        bestSource.volume = getDistanceScaledVolume()*getSourcesWaterMaxVolume(bestSource);
        
    }
    float getDistanceScaledVolume()
    {
        if (player)
        {
            float dist = Vector3.Distance(player.position, transform.position);
            float scaling;
            if (dist < mindistance)
            {
                scaling = 1f;
            }
            else if (dist < maxdistance)
            {
                float range = (maxdistance - mindistance);
                scaling = 1 - .01f * dist;
            }
            else
            {

                scaling = 0f;
            }
            return scaling;
        }
        else
        {
            return 0;
        }
    }

    float getSourcesWaterMaxVolume(AudioSource source)
    {
        float deadWater = 0.25f;
        float betterWater = 0.5f;
        float perfectWater = 1f;

        if (source == deadSource)
        {
            if (startingWater > deadWater)
            {
                return 0;
            }
            else
            {
                return (0.68f-startingWater);
            }
        }
        else if (source == betterSource)
        {
            if(startingWater > betterWater)
            {
                return 0;
            }
            else if(startingWater < 0.5f){
                return (0.2f + 1.2f*startingWater);
            }
            else
            {
                return (0.8f-startingWater);
            }

        }
        else
        {
            return (startingWater);
        }
        
    }
}
