using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawnner : MonoBehaviour
{
    [System.Serializable]
    public class Tank{
        public float movementSpeed;

        public float rotateSpeed;
        public TankTypes tankType;
        public Material color;
    }
    public List<Tank> tankList;
    [SerializeField] private TankView tankView;
    void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(tankList[1].movementSpeed , tankList[1].rotateSpeed , tankList[1].tankType , tankList[0].color);
        TankController tankController = new TankController(tankModel , tankView);
    }
}
