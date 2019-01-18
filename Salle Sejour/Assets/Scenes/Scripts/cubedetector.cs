using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class cubedetector : MonoBehaviour {
    public GameManager Gm;
    public int index;

    public Material rightMat ;
    private bool detected;


    private void Start()
    {
        Gm = GameObject.Find("[GameManager]").GetComponent<GameManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(index);
        Debug.Log(collision.collider.gameObject.GetComponent<Renderer>().material.name);
        if (collision.collider.gameObject.GetComponent<Renderer>().material.name  == rightMat.name + " (Instance)"&& !detected)
        {
            Debug.Log(index);
            GetComponent<Renderer>().material = rightMat;
            Gm.puzzleComplete[index] = true;
            Destroy(collision.collider.gameObject);
            detected = true;

        }
    }
}
