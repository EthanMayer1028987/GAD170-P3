using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotlightController : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        EventBus.Current.Daytime += Daytime;
        EventBus.Current.Nighttime += Nighttime;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Daytime() {
        gameObject.GetComponent<Light>().enabled = true;
    }

    private void Nighttime() {
        gameObject.GetComponent<Light>().enabled = false;
    }
}