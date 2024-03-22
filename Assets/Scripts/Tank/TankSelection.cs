using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    [SerializeField] private TankSpawnner tankSpawnner;

   public void GreenTankSelector()
   {
        tankSpawnner.CreateTank(0);
        transform.gameObject.SetActive(false);
   }
   public void BlueTankSelector()
   {
        tankSpawnner.CreateTank(1);
        transform.gameObject.SetActive(false);
   }
   public void RedTankSelector()
   {
        tankSpawnner.CreateTank(2);
        transform.gameObject.SetActive(false);
   }
}
