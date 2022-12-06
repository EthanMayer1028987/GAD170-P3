using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteractions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
              
    }

    // Update is called once per frame
    void Update()
    {
        // Input bund so when you press a button it tells you many lives are left

        if(Input.GetKeyDown("l")) {
            print("You currently have "+EventBus.Current.ReturnLives()+ " lives.");
        }

        // Input bid so when you press a button you die by reloading scene
        if(Input.GetKeyDown("u")) {
            // This unalives the player and moves them to the start
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            EventBus.Current.ReduceLives();
        }

        if(Input.GetKeyDown("["))
        {
            EventBus.Current.NighttimeTrigger();
        }

        if(Input.GetKeyDown("]"))
        {
            EventBus.Current.DaytimeTrigger();
        }
    }

}
