using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object_controller : MonoBehaviour {

    bool isDecay = false;
    Color Decay;
    public Timer_Decay timerVar;
	void Start () {
        Decay = Color.green;
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isDecay = true;
            timerVar.StartTimer();
        }
    }
    // Update is called once per frame
    void Update () {
        if (isDecay)
        {
            GetComponent<MeshRenderer>().material.color = Decay;
        }
	}
}
