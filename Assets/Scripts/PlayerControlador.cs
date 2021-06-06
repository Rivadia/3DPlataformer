using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerControlador : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    public float gravityScale=5f;

    Vector3 moveDirection;

    Vector3 jumpDirection;

     bool playerGround;

     bool jumpButton;
  
    

    CharacterController characterController;





    public void OnMove(InputAction.CallbackContext context){

        moveDirection =context.ReadValue<Vector2>();
       
    }

   public void OnJump(InputAction.CallbackContext context){
        
        // if(context.action.triggered){
        //     Debug.Log("Si llegas");
        //     jumpDirection.y = jumpForce;
        // }
     jumpButton=context.action.triggered;
     
    }






    void move(Vector2 direction){
        Vector3 moveDirection = new Vector3(direction.x,0,direction.y);
        moveDirection=moveDirection*moveSpeed;
        characterController.Move(moveDirection*Time.deltaTime);

        //this.transform.position=this.transform.position+(moveDirection*Time.deltaTime*moveSpeed);
    }

    void JumpMove(){
      float yStore=jumpDirection.y;

       jumpDirection.y=yStore;
    //    playerGround=characterController.isGrounded;

    
    //    if(playerGround && jumpDirection.y < 0.5f){
    //        jumpDirection.y=0;
    //    }
    //     Debug.Log(playerGround);

        if(jumpButton){
            jumpDirection.y = jumpForce;
        }
     
        jumpDirection.y  += Physics.gravity.y*Time.deltaTime*gravityScale;
        characterController.Move(jumpDirection*Time.deltaTime);
    }

  

    // Start is called before the first frame update
    void Awake()
    {
        characterController=GetComponent<CharacterController>();
       
    }

    // Update is called once per frame
    void Update()
    {
        JumpMove();
        move(moveDirection);
    }

     
}
