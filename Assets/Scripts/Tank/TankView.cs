using UnityEngine;
using TMPro;



public class TankView :MonoBehaviour
{
    private TankController tankController;
    [SerializeField] private Transform shellSpawnPosition;
    [SerializeField] private GameObject pfShell;
    [SerializeField] private TextMeshProUGUI healthText;
    private float shellSpeed;


    private float movement ;
    private float rotation;

   private Rigidbody rb;

   [SerializeField]private MeshRenderer[] childs;
    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }
    private void Start() {
        GameObject cam = GameObject.FindGameObjectWithTag("MainCamera");
        cam.transform.SetParent(transform);
        cam.transform.position= new Vector3(0f, 2.3f,-5f);
    }
    private void Update() {
        Movement();
        if(movement!= 0)
        {
            tankController.Move(movement , tankController.GetTankModel().movementSpeed);
        }
        if(rotation != 0 )
        {
            tankController.Rotate(rotation,tankController.GetTankModel().rotationSpeed);
        }
        FireShell();
    }
   
    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotation = Input.GetAxis("Horizontal");   
    }
    private void FireShell()
    {
        if(Input.GetMouseButtonDown(0))
        {
           GameObject shell= Instantiate(pfShell,shellSpawnPosition.position,transform.rotation);
           shell.GetComponent<ShellCollider>().ShellSpped(shellSpeed);
        }
    }

    public void SetTankController(TankController tankController)
    {
        this.tankController = tankController; 
    }
    public Rigidbody GetRigidbody()
    {
        return rb;
    }
    public void ChangeColor(Material color)
    {
        for (int i =0 ; i < childs.Length ; i++)
        {
            childs[i].material = color;
        }
    }
    public void SetShellSpeed(float sheelSpeed)
    {
        this.shellSpeed =sheelSpeed;
    }
}