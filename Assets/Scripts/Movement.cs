using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _mainThrust = 200f;
    [SerializeField] private float _rotationThrust = 200f;
    
    private Rigidbody _rigidbodyRocket;
    private AudioSource _audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _rigidbodyRocket = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();

    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (!_audioSource.isPlaying)
            {
                _audioSource.Play();
            }
            _rigidbodyRocket.AddRelativeForce(Vector3.up * _mainThrust * Time.deltaTime);
        }
        else
        {
            _audioSource.Stop();
        }
        
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ApplyRotation(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            ApplyRotation(Vector3.back);
        }
    }

    void ApplyRotation(Vector3 rotationVector)
    {
        _rigidbodyRocket.freezeRotation = true;
        transform.Rotate(rotationVector * _rotationThrust * Time.deltaTime);
        _rigidbodyRocket.freezeRotation = false;
    }
}
