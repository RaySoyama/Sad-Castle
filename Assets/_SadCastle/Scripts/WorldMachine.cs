﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMachine : MonoBehaviour
{
    public AnimationClip clip;
    public float time;
    void Update()
    {
        time = Time.timeSinceLevelLoad;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SpawnBeachball();
            AnimationEvent evt = new AnimationEvent() { functionName = "SpawnBeachball", time = Time.timeSinceLevelLoad};
            clip.AddEvent(evt);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            SpawnVolleyball();
            AnimationEvent evt = new AnimationEvent() { functionName = "SpawnVolleyball", time = Time.timeSinceLevelLoad };
            clip.AddEvent(evt);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnKid();
            AnimationEvent evt = new AnimationEvent() { functionName = "SpawnKid", time = Time.timeSinceLevelLoad };
            clip.AddEvent(evt);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SpawnShark();
            AnimationEvent evt = new AnimationEvent() { functionName = "SpawnShark", time = Time.timeSinceLevelLoad };
            clip.AddEvent(evt);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            SpawnLightning();
            AnimationEvent evt = new AnimationEvent() { functionName = "SpawnLightning", time = Time.timeSinceLevelLoad };
            clip.AddEvent(evt);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            SpawnCoconut();
            AnimationEvent evt = new AnimationEvent() { functionName = "SpawnCoconut", time = Time.timeSinceLevelLoad };
            clip.AddEvent(evt);
        }
        
        if(Input.GetKeyDown(KeyCode.S))
        {
            SpawnBottle();
            AnimationEvent evt = new AnimationEvent() { functionName = "SpawnBottle", time = Time.timeSinceLevelLoad };
            clip.AddEvent(evt);
        }


        if(Input.GetKeyDown(KeyCode.D))
        {
            SpawnMeteor();
            AnimationEvent evt = new AnimationEvent() { functionName = "SpawnMeteor", time = Time.timeSinceLevelLoad };
            clip.AddEvent(evt);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            SpawnFish();
            AnimationEvent evt = new AnimationEvent() { functionName = "SpawnFish", time = Time.timeSinceLevelLoad };
            clip.AddEvent(evt);
        }

    }


    public void SpawnBeachball()
    {
        SpawnManager.instance.SpawnEntity(SpawnManager._Entity.Beachball);
    }
    public void SpawnVolleyball()
    {
        SpawnManager.instance.SpawnEntity(SpawnManager._Entity.Volleyball);
    }
    public void SpawnKid()
    {
        SpawnManager.instance.SpawnEntity(SpawnManager._Entity.Kid);
    }

    public void SpawnShark()
    {
        SpawnManager.instance.SpawnEntity(SpawnManager._Entity.Shark);
    }

    public void SpawnLightning()
    {
        SpawnManager.instance.SpawnEntity(SpawnManager._Entity.Lightning);
    }
    
    public void SpawnCoconut()
    {
        SpawnManager.instance.SpawnEntity(SpawnManager._Entity.Coconut);
    }

    public void SpawnMeteor()
    {
        SpawnManager.instance.SpawnEntity(SpawnManager._Entity.Meteor);
    }
    public void SpawnBottle()
    {
        SpawnManager.instance.SpawnEntity(SpawnManager._Entity.Beer);
    }
    public void SpawnFish()
    {
        SpawnManager.instance.SpawnEntity(SpawnManager._Entity.Fish);
    }
}