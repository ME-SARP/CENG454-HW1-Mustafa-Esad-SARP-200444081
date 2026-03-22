// FlightController.cs
// CENG 454 - HW1: Sky-High Prototype
// Author: Mustafa Esad Sarp | Student ID: 200444081

using UnityEngine;

public class FlightController : MonoBehaviour
{
    [SerializeField] private float pitchSpeed = -20f;   
    [SerializeField] private float yawSpeed = 15f;      
    [SerializeField] private float rollSpeed = 45f;     
    [SerializeField] private float thrustSpeed = 100f;  

   
    private Rigidbody rb;

    void Start()
    {
       
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        
        float pitchInput = Input.GetAxis("Vertical");
        float pitchAmount = pitchInput * pitchSpeed * Time.deltaTime;

        
        float yawInput = Input.GetAxis("Horizontal");
        float yawAmount = yawInput * yawSpeed * Time.deltaTime;

        
        transform.Rotate(pitchAmount, yawAmount, 0f, Space.Self);
    }
}