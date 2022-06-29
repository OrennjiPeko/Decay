using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer_Decay : MonoBehaviour {
   

    public IEnumerator RedRoutine()
    {
        yield return new WaitForSeconds(2.0f);
        Timer.currentScore += 10;
        Destroy(this.gameObject);
    }

    public void StartTimer()
    {
        if (CompareTag("Red"))
        {
            StartCoroutine("RedRoutine");
        }
        if (CompareTag("Blue"))
        {
            StartCoroutine("BlueRoutine");
        }
        if (CompareTag("White"))
        {
            StartCoroutine("WhiteRoutine");
        }
        if (CompareTag("BlueWall"))
        {
            StartCoroutine("BlueWall1");
        }
        if (CompareTag("SecondWall"))
        {
            StartCoroutine("SecondWall");
        }
        if (CompareTag("ThridWall"))
        {
            StartCoroutine("ThridWall");
        }

    }

    public IEnumerator BlueRoutine()
    {
        yield return new WaitForSeconds(3.5f);
        Timer.currentScore += 30;
        Destroy(this.gameObject);
    }

    public IEnumerator WhiteRoutine()
    {
        yield return new WaitForSeconds(2.5f);
        Timer.currentScore += 15;
        Destroy(this.gameObject);
    }

    public IEnumerator BlueWall1()
    {
        yield return new WaitForSeconds(5.0f);
        Timer.currentScore -= 50;
        Destroy(this.gameObject);
    }

    public IEnumerator SecondWall()
    {
        yield return new WaitForSeconds(5.0f);
        Timer.currentScore -= 100;
        Destroy(this.gameObject);
    }

    public IEnumerator ThridWall()
    {
        yield return new WaitForSeconds(5.0f);
        Timer.currentScore -= 250;
        Destroy(this.gameObject);
    }
}
