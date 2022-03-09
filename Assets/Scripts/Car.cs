using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public Vector2 SpeedMinMax = new Vector2(.1f, 2f);
    private Vector3 _startPosition;
    private float _speed;

    // Start is called before the first frame update
    void Start()
    {
        Setup();
    }

    void Setup()
    {
        _startPosition = transform.position;
        _speed = Random.Range(SpeedMinMax.x, SpeedMinMax.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            transform.position = _startPosition;
        }
    }
}
