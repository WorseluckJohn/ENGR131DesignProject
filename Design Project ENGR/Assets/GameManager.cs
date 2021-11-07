using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SpriteRenderer crosswalk;
    public Material red;
    public Material green;
    public int crosswalkLength = 8;
    public bool toggled;

    // Start is called before the first frame update
    void Start()
    {
       
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
            for (i = 1; i <= crosswalkLength; i++)
            {
                GameObject.Find($"Crosswalks ({i})").GetComponent<MeshRenderer>().material = green;
            }
        }
        else if(!toggled)
        {
            for (i = 1; i <= crosswalkLength; i++)
            {
                GameObject.Find($"Crosswalks ({i})").GetComponent<MeshRenderer>().material = red;
            }
        }
    }

    IEnumerator trafficLights()
    {
        yield return new WaitForSecondsRealtime(3);
        toggled = !toggled;
    }
}
