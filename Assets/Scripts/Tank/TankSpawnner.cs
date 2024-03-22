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

    public void CreateTank(int i )
    {
        TankModel tankModel = new TankModel(tankList[i].movementSpeed , tankList[i].rotateSpeed , tankList[i].tankType , tankList[i].color);
        TankController tankController = new TankController(tankModel , tankView);
    }
}
