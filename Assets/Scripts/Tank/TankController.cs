using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    private TankModel tankModel;

    private TankView tankView;
    private Rigidbody rb;

    public TankController(TankModel _tankModel , TankView _tankView)
    {


        /*
        This is a constructor . When it is created it is carrying the Tankview and tankModel reference 

        Here tankView and tankModel's reference are stored . After storing then this created 



        */
        tankModel = _tankModel;
        tankModel.SetTankController(this);
        tankView = GameObject.Instantiate<TankView>(_tankView);
      
      
        tankView.SetTankController(this);
        rb = tankView.GetRigidbody();
        

    }
    public void Move(float movement, float movementSpeed)
    {
        rb. velocity = tankView.transform.forward*movement * movementSpeed;

    }
    public void Rotate(float rotate , float rotateSpeed)
    {
       Vector3 vector = new Vector3(0f, rotate*rotateSpeed ,0f);
       Quaternion deltaRotation = Quaternion.Euler(vector*Time.deltaTime);
       rb.MoveRotation(rb.rotation *deltaRotation);
    }
   
}
