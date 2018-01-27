using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToScript : MonoBehaviour {
    public Transform[] pathPoints;
    public float moveSpeed = 12;
    private int currPath = 0;
    Color[] randColor = new Color[6];

    void Start () {
        randColor[0] = Color.red;
        randColor[1] = Color.blue;
        randColor[2] = Color.green;
        randColor[3] = Color.yellow;
        randColor[4] = Color.magenta;
        randColor[5] = Color.cyan;
    }
	
	void Update () {
            iTween.MoveTo(gameObject, iTween.Hash("position", pathPoints[currPath].position, 
                "speed", moveSpeed, "easetype", "linear", "oncomplete", "PathOfQueen"));
	}

    void PathOfQueen()
    {
        GetComponent<Renderer>().material.color = randColor[Random.Range(0, randColor.Length)];
        currPath++;
        if (currPath.Equals(pathPoints.Length))
        {
            currPath = 0;
        }
    }
}
