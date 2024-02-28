using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    private enum SwitchState
    {
        off,
        on, 
        blink
    }

    public Collider bola;
    public Material materialOff;
    public Material materialOn;
    public float score;

    private SwitchState state;

    private Renderer renderer;
    public ScoreManager scoreManager;

    void Start()
    {
        renderer = GetComponent<Renderer>();

        SetMaterial(false);

        StartCoroutine(BlinkTimerStart(5f));
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other == bola)
        {
            Toggle();
;        }
    }
    // Start is called before the first frame update
    private void SetMaterial(bool active)
    {
        if(active == true)
        {
            state = SwitchState.on;
            renderer.material = materialOn;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.off;
            renderer.material = materialOff;
            StartCoroutine(BlinkTimerStart(5f));
        }
    }

    private void Toggle()
    {
        if(state == SwitchState.on)
        {
            SetMaterial(false);
        }
        else
        {
            SetMaterial(true);
        }

        scoreManager.AddScore(score);
    }

    private IEnumerator Blink(int times)
    {

        state = SwitchState.blink;
        for(int i = 0; i < times; i++)
        {
            renderer.material = materialOn;
            yield return new WaitForSeconds(0.5f);
            renderer.material = materialOff;
            yield return new WaitForSeconds(0.5f);
        }

        state = SwitchState.off;

        StartCoroutine(BlinkTimerStart(5));
    }

    private IEnumerator BlinkTimerStart(float time)
    {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(5));
    }


}
