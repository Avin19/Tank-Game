using UnityEngine;


public class TankView :MonoBehaviour
{
    private TankController tankController;

    private float movement ;
    private float rotation;

   private Rigidbody rb;
    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }
    private void Update() {
        Movement();
        if(movement!= 0)
        {
            tankController.Move(movement , 30f);
        }
        if(rotation != 0 )
        {
            tankController.Rotate(rotation,30f);
        }
    }
    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");   
    }

    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController; 
    }
    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}