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

        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);
        tankView.SetTankController(this);
        tankModel.SetTankController(this);
        rb = tankView.GetRigidbody();
        tankView.ChangeColor(tankModel.color);
        tankView.SetShellSpeed(tankModel.shellSpeed);

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

    public TankModel GetTankModel()
    {
        return tankModel;
    }
   
}
