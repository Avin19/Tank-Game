using UnityEngine;



public class TankModel
{
    private TankController tankController;
    public float movementSpeed;
    public float rotationSpeed;

    public TankTypes tankType;

    public Material color;

    public TankModel(float movement, float rotation, TankTypes tankType , Material _color)
    {
        this.movementSpeed = movement;
        this.rotationSpeed =rotation;
        this.tankType = tankType;
        this.color = _color;

    }
     public void SetTankController(TankController tankController)
    {
        this.tankController = tankController;
    }
}