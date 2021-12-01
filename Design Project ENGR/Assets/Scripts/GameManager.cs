using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SpriteRenderer crosswalk;
    public Material red;
    public Material green;
    public int crosswalkLength = 2;
    public bool toggled;
    public GameObject trafficLightRed;
    public GameObject trafficLightGreen;

    // Start is called before the first frame update
    void Start()
    {
    //    trafficLightGreen = GameObject.Find("TrafficLightGreen");
    //    trafficLightRed = GameObject.Find("TrafficLightRed");
    }

    // Update is called once per frame
    void Update()
    {
        changeColor();
    }

    void changeColor()
    {
        int i;

        if (toggled)
        {
            for (i = 1; i < crosswalkLength; i++)
            {
                //GameObject.Find($"TrafficLight").GetComponent<MeshRenderer>().material[3];
                GameObject.Find($"Crosswalk ({i})").GetComponent<MeshRenderer>().material = red;
                trafficLightRed.SetActive(false);
                trafficLightGreen.SetActive(true);
            }
        }
        else if(!toggled)
        {
            for (i = 1; i < crosswalkLength; i++)
            {
                GameObject.Find($"Crosswalk ({i})").GetComponent<MeshRenderer>().material = green;
                trafficLightRed.SetActive(true);
                trafficLightGreen.SetActive(false);

            }
        }
    }

    IEnumerator trafficLights()
    {
        yield return new WaitForSecondsRealtime(3);
        toggled = !toggled;
    }
}
