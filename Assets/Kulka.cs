using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kulka : MonoBehaviour
{
    private List<Color> randomColors;
    private System.Random random = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        randomColors = new List<Color> () { Color.red, Color.green, Color.blue, Color.magenta, Color.yellow };
        Reset();
    }

    void Reset()
    {
        transform.position = new Vector3(0f, 3f, 0f);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        SetRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
	    if(transform.position.y < -10f)
	    {
            Reset();
        }
        
    }

    void SetRandomColor()
    {
        // Call SetColor using the shader property name "_Color" and setting the color to red
        int index = random.Next(randomColors.Count);
        GetComponent<Renderer>().material.SetColor("_Color", randomColors[index]);
    }
}
