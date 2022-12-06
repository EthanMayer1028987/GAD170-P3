using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBus : MonoBehaviour {
    
    private static EventBus _current;

    public static EventBus Current { get { return _current; } }

    private int lives = 3;

    private void Awake()
    {
        if (_current != null && _current != this)
        {
            Destroy(this.gameObject);
        } else {
            _current = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // public function that returns lives
    public int ReturnLives()
    {
        return lives;
    }

    // Public function that takes one life away
    public void ReduceLives()
    {
        lives--;
    }
    
    public event Action TestEvent;

    public void TestEventTrigger()
    {
        TestEvent();
    }

    public event Action Daytime;
    
    public void DaytimeTrigger()
    {
        Daytime();
    }
    
    public event Action Nighttime;

    public void NighttimeTrigger()
    {
        Nighttime();
    }

}