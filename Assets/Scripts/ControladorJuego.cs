using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ControladorJuego : MonoBehaviour
{


    Vector2 moveDirection;

    public float moveSpeed;

    public float rotationSpeed;


    public void onMove(InputAction.CallbackContext context){

            moveDirection= context.ReadValue<Vector2>();
    }

     void move(Vector2 direction){

        if (direction.sqrMagnitude > 1f)
            direction.Normalize();

            this.transform.position =   this.transform.position + new Vector3(0,0,direction.y*moveSpeed*Time.deltaTime);

        //this.transform.Translate(new Vector3(direction.x*moveSpeed*Time.deltaTime,0,direction.y*moveSpeed*Time.deltaTime));
    }

    void RotateDirection(float direction){

     float rotacion = direction * rotationSpeed;
     rotacion*=Time.deltaTime;
     transform.Rotate(0,rotacion,0);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move(moveDirection);
        RotateDirection(moveDirection.x);
    }
}
