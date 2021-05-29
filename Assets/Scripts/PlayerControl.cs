using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    private Vector3 moveDirection;

    InputAction myInputAction = new InputAction();

    // Start is called before the first frame update
    void Start()
    {
         
         

        
    }

    // Update is called once per frame
    void Update()
    {
      
         myInputAction.AddCompositeBinding("Axis(minValue=0,maxValue=2)").With("Negative","<Keyboard>/a").With("Positive","<Keyboard>/d");
         
        
         Debug.Log(myInputAction.GetBindingIndex());
       
        
    }
}
