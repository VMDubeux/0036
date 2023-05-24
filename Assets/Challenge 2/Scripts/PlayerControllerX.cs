using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject DogPrefab;
    private float _lastDogTime = 0;
    private int _dogDelay = 1;

    void Start()
    {

    }

    void Update()
    {
        float _timer = Time.time;
        Debug.Log(_timer);

        if (Input.GetKeyDown(KeyCode.Space) && _timer - _lastDogTime > _dogDelay) // On spacebar press, send dog
        {
            Instantiate(DogPrefab, transform.position, DogPrefab.transform.rotation);
            _lastDogTime = Time.time;
        }
    }
}
