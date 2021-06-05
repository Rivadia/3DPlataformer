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

            Vector3 directionX = new Vector3(0,0,direction.y*moveSpeed*Time.deltaTime);
            this.transform.position =   this.transform.position + transform.TransformDirection(directionX) ;
            

        //this.transform.Translate(new Vector3(direction.x*moveSpeed*Time.deltaTime,0,direction.y*moveSpeed*Time.deltaTime));
    }

    void RotateDirection(Vector2 direction){

     Vector2 rotacion = Vector2.zero;
     rotacion.x =direction.x *rotationSpeed;
     rotacion.x *=Time.deltaTime;
     Vector3 rotacionX = new Vector3 (0,rotacion.x,0); 
     transform.Rotate( transform.TransformDirection(rotacionX));
     
    }
    void RotateDirection(float direction){

     Vector2 rotacion=Vector2.zero ;
     rotacion.x= direction *rotationSpeed;
     rotacion.x *=Time.deltaTime;
     Vector3 rotacionX = new Vector3 (0,rotacion.x,0); 
     transform.Rotate( rotacionX);
     
    }

    // Update is called once per frame
    void Update()
    {
        move(moveDirection);
        RotateDirection(moveDirection.x);
    }
}
