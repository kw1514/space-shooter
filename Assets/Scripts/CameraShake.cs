using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] float shakeDuration = 1f;
    [SerializeField] float shakeMagnitude = 0.5f;

    Vector3 intitialPosition;

    void Start()
    {
        intitialPosition = transform.position;
    }

    public void Play()
    {
        StartCoroutine(Shake());
    }

    IEnumerator Shake()
    {
        float elaspedTime = 0;

        while(elaspedTime < shakeDuration)
        {
            transform.position = intitialPosition + (Vector3)Random.insideUnitCircle * shakeMagnitude;
            elaspedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        transform.position = intitialPosition;
    }
}
