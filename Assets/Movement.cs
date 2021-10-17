using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; //mengatur kecepatan object player
    public Rigidbody2D rb; //deklarasi Rigidbody2D
    Vector2 movement; //deklarasi movement
    public int arah; //deklarasi arah 
    
    void Update()
    {
        if (arah==0)
        {
            movement.x = 1f;
            movement.y = 1f;
            //bergerah ke kanan 45 derajat
        }

        if (arah==1)
        {
            movement.x = -1f;
            movement.y = 1f;
            //bergerak ke kiri 45 derajat
        }
    }
    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //deklarasi agar object bergerak

    if (Input.GetKey("z"))
        {
        arah=1;
        //bergerak ke kiri atau menganggil function if(arah==1) ketika user mengklik z
        }

    if (Input.GetKey("x"))
        {
        arah=0;
        //bergerak ke kanan atau mengaggil function if(arah==-1) ketika user mengklik x
        }
         
    }
}

 /*if (Input.GetKey("z"))
        {
            if(arah == 1){
                    movement.x = 1f;//Input.GetAxisRaw("Horizontal");
                    movement.y = 1f;//Input.GetAxisRaw("Vertical");
                    //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
                    arah= 2;}
            if(arah == 2){
                    movement.x = -1f;//Input.GetAxisRaw("Horizontal");
                    movement.y = 1f;//Input.GetAxisRaw("Vertical");
                    //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
                    arah= 1;}
            else
                    movement.x = -1f;//Input.GetAxisRaw("Horizontal");
                    movement.y = 1f;//Input.GetAxisRaw("Vertical");
                    //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
                    arah= 1;
        }*/
        ///if (Input.GetKey("p"))
        //{
        //    movement.x = 1f;
        //    movement.y = 1f;
            
        //}

        //if (Input.GetKey("x"))
        //{
        //    movement.x = 1f;
        //    movement.y = 1f;
        //    rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //}