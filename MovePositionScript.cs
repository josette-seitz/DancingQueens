using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePositionScript : MonoBehaviour {
    public Transform[] pathPoints;
    public float moveSpeed = 12;
    private int currPath;
    Color[] randColor = new Color[6];

    private void Start() {
        randColor[0] = Color.red;
        randColor[1] = Color.blue;
        randColor[2] = Color.green;
        randColor[3] = Color.yellow;
        randColor[4] = Color.magenta;
        randColor[5] = Color.cyan;
    }

    void Update () {
        if (transform.position != pathPoints[currPath].position)
        {
            Vector3 moveToNextPoint = Vector3.MoveTowards(transform.position, pathPoints[currPath].position, moveSpeed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(moveToNextPoint);
        }
        else
        {
            GetComponent<Renderer>().material.color = randColor[Random.Range(0, randColor.Length)];
            currPath++;
            if (currPath.Equals(pathPoints.Length))
            {
                currPath = 0;
            }
        }
    }
}
