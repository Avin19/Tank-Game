using UnityEngine;


public class TankView :MonoBehaviour
{
    private TankController tankController;


    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController; 
    }
}